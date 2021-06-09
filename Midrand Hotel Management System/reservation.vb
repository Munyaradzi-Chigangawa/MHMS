Public Class reservation

    Private Sub btncheckin_Click(sender As Object, e As EventArgs) Handles btnreserved.Click
        Dim sql = "INSERT INTO  reserve (GUESTNAME,ROOM_NO,ROOM_TYPE,ROOM_RATE,CHECKIN_DATE,NOOFDAYS,NOOFADULTS,NOOFCHILDREN,ADVANCE,REMARKS,RESERVATIONEND) VALUES ('" & txtgname1.Text & "', '" & txtRoom1.Text & "','" & txttype1.Text & "', '" & rate1.Text & "', '" & txtdate.Value & "', '" & txtdays1.Text & "', '" & txtadults1.Text & "', '" & txtChildren.Text & "', '" & txtadvance.Text & "','" & btnreserved.Text & "', '" & DateTimePicker2.Value & "')"

        save(sql)
        Try
            sql = "UPDATE tblrooms SET Status='Reserve' WHERE IDrooms=" & RoomID

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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main.BringToFront()
        main.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        checkinlist.ShowDialog()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        rooms.ShowDialog()
    End Sub
End Class