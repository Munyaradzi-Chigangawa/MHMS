Public Class Search
    Dim cmd As New OleDb.OleDbCommand
    Dim sql As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim result As Integer

    Dim con As OleDb.OleDbConnection = Myconnection()

    Public Function Myconnection() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\mhms.mdb")
    End Function
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        dt = New DataTable
        sql = "Select * from guests where FNAME LIKE '%" & TextBox1.Text & "%'"

        Try

            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

        con.Close()
    End Sub

End Class