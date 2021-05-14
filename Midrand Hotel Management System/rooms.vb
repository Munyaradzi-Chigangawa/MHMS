Public Class rooms
    Dim cmd As New OleDb.OleDbCommand
    Dim sql As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim result As Integer
    Dim Fname As String
    Dim Lname As String

    Dim conn As OleDb.OleDbConnection = Myconnection()

    Public Function Myconnection() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\mhms.mdb")
    End Function
    Private Sub rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

     dt = New DataTable
        Try
            sql = "SELECT * FROM rooms"
            conn.Open()
            With cmd
                .CommandText = Sql
                .Connection = conn
            End With

            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView1.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()


        End Try
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Dim RoomStatus = DataGridView1.CurrentRow.Cells("Status").Value.ToString

        'checkin

        If RoomStatus = "Unavailable" Or RoomStatus = "Reserve" Then
            MessageBox.Show("Not Available")
        Else

            RoomID = DataGridView1.CurrentRow.Cells("IDrooms").Value.ToString

            checkin.txtRoom.Text = DataGridView1.CurrentRow.Cells("rooms").Value.ToString
            checkin.txttype.Text = DataGridView1.CurrentRow.Cells("room_types").Value.ToString
            checkin.rate.Text = DataGridView1.CurrentRow.Cells("Room_Rate").Value.ToString
            ' reserved
            reservation.txtRoom1.Text = DataGridView1.CurrentRow.Cells("rooms").Value.ToString
            reservation.txttype1.Text = DataGridView1.CurrentRow.Cells("room_types").Value.ToString
            reservation.rate1.Text = DataGridView1.CurrentRow.Cells("Room_Rate").Value.ToString


        End If

        Me.Close()

    End Sub
End Class