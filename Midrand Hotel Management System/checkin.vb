Imports System.Data.OleDb
Public Class checkin
    Dim cmd As New OleDb.OleDbCommand
    Dim sql As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim result As Integer
    Dim remarks As String = "Checkin"
    Dim con As OleDb.OleDbConnection = Myconnection()

    Public Function Myconnection() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\mhms.mdb")
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtadults.Clear()
        txtadvance.Clear()
        txtChildren.Clear()
        txtdays.Clear()
        txtdate.Value = Date.Now
        DateTimePicker1.Value = Date.Now
        DateTimePicker2.Value = Date.Now
        txtgname.Clear()
        txtRoom.Clear()
        rate.Clear()
        txttype.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main.BringToFront()
        main.Show()
        Me.Hide()
    End Sub

    Private Sub btncheckin_Click(sender As Object, e As EventArgs) Handles btncheckin.Click
        Dim sql = "INSERT INTO  checkin (GUESTNAME,ROOM_NO,ROOM_TYPE,ROOM_RATE,CHECKIN_DATE,NOOFDAYS,NOOFADULTS,NOOFCHILDREN,ADVANCE,REMARKS) VALUES ('" & txtgname.Text & "', '" & txtRoom.Text & "','" & txttype.Text & "', '" & rate.Text & "', '" & txtdate.Value & "', '" & txtdays.Text & "', '" & txtadults.Text & "', '" & txtChildren.Text & "', '" & txtadvance.Text & "', '" & btncheckin.Text & "')"
        cashiersave(sql)

        Try
            sql = "UPDATE rooms SET Status='Unavailable' WHERE IDrooms=" & RoomID

            con.Open()
            With cmd
                .CommandText = sql
                .Connection = con
            End With

            result = cmd.ExecuteNonQuery


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()



        End Try
        Try
            sql = "DELETE * FROM reserve  WHERE ID=" & GuestId
            con.Open()
            With cmd
                .CommandText = sql
                .Connection = con
            End With

            result = cmd.ExecuteNonQuery


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()


        End Try


        txtadults.Text = Nothing
        txtgname.Text = Nothing
        txtdays.Text = Nothing
        txttype.Text = Nothing
        txtRoom.Text = Nothing
        txtChildren.Text = Nothing
        rate.Text = Nothing
        txtadvance.Text = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        checkinlist.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        rooms.ShowDialog()
    End Sub
End Class