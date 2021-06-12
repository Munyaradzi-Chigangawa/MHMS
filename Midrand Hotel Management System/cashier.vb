Public Class cashier
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

    Private Sub cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt = New DataTable
        Try
            Sql = "SELECT * FROM checkin"
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

    Private Sub btncheckout_Click(sender As Object, e As EventArgs) Handles btncheckout.Click
        txtc.Text = Val(txtcash.Text) - Val(txttotal.Text)


        checkout("INSERT INTO  checkout(GUESTNAME,ROOM_NO,ROOM_TYPE,ROOM_RATE,CHECKIN_DATE,NOOFDAYS,NOOFADULTS,NOOFCHILDREN,ADVANCE,REMARKS,CHECKOUT_DATE,CASH) VALUES ('" & txtname.Text & "', '" & txtroomno.Text & "','" & txttype.Text & "', '" & txtrate.Text & "', '" & txtdate.Text & "', '" & txtdays.Text & "', '" & txtadults.Text & "', '" & txtchildren.Text & "', '" & txtadvance.Text & "','" & btncheckout.Text & "','" & Dtime.Value & "','" & txttotal.Text & "')")

        Try
            Sql = "DELETE * FROM checkin  WHERE ID=" & GuestId
            conn.Open()
            With cmd
                .CommandText = Sql
                .Connection = conn
            End With

            result = cmd.ExecuteNonQuery


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()


        End Try


        'txtc.Text = Val(txttotal.Text) - Val(txtcash.Text)
        dt = New DataTable
        Try
            Sql = "SELECT * FROM checkin"
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
        Try
            Sql = "UPDATE rooms SET Status='Available' WHERE IDrooms=" & RoomID

            con.Open()
            With cmd
                .CommandText = Sql
                .Connection = con
            End With

            result = cmd.ExecuteNonQuery


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()



        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        GuestId = DataGridView1.CurrentRow.Cells("ID").Value.ToString
        txtname.Text = DataGridView1.CurrentRow.Cells("GUESTNAME").Value.ToString()
        txtroomno.Text = DataGridView1.CurrentRow.Cells("ROOM_NO").Value.ToString()
        txtrate.Text = DataGridView1.CurrentRow.Cells("ROOM_RATE").Value.ToString()
        txttype.Text = DataGridView1.CurrentRow.Cells("ROOM_TYPE").Value.ToString()

        txtdate.Text = DataGridView1.CurrentRow.Cells("CHECKIN_DATE").Value.ToString()
        txtdays.Text = DataGridView1.CurrentRow.Cells("NOOFDAYS").Value.ToString()
        txtadults.Text = DataGridView1.CurrentRow.Cells("NOOFADULTS").Value.ToString()
        txtchildren.Text = DataGridView1.CurrentRow.Cells("NOOFCHILDREN").Value.ToString()
        txtadvance.Text = DataGridView1.CurrentRow.Cells("ADVANCE").Value.ToString()

        txttotal.Text = Val(txtrate.Text) * Val(txtdays.Text) + Val(txtadvance.Text)
        dt = New DataTable

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        main.BringToFront()
        main.Show()
        Me.Hide()
    End Sub
End Class