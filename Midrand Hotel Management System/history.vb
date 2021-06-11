Public Class history
    Dim cmd As New OleDb.OleDbCommand
    Dim sql As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim result As Integer

    Dim conn As OleDb.OleDbConnection = Myconnection()

    Public Function Myconnection() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\mhms.mdb")
    End Function
    Private Sub history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        dt = New DataTable
        GuestId = DataGridView1.CurrentRow.Cells("ID").Value.ToString
        checkin.txtgname.Text &= " " & DataGridView1.CurrentRow.Cells("GUESTNAME").Value.ToString
        checkin.txtRoom.Text = DataGridView1.CurrentRow.Cells("ROOM_NO").Value.ToString()
        checkin.rate.Text = DataGridView1.CurrentRow.Cells("ROOM_RATE").Value.ToString()
        checkin.txttype.Text = DataGridView1.CurrentRow.Cells("ROOM_TYPE").Value.ToString()

        checkin.txtdate.Value = DataGridView1.CurrentRow.Cells("CHECKIN_DATE").Value.ToString()
        checkin.txtdays.Text = DataGridView1.CurrentRow.Cells("NOOFDAYS").Value.ToString()
        checkin.txtadults.Text = DataGridView1.CurrentRow.Cells("NOOFADULTS").Value.ToString()
        checkin.txtChildren.Text = DataGridView1.CurrentRow.Cells("NOOFCHILDREN").Value.ToString()
        checkin.txtadvance.Text = DataGridView1.CurrentRow.Cells("ADVANCE").Value.ToString()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Check in list" Then

            dt = New DataTable
            sql = "Select * from checkin where GUESTNAME LIKE '%" & TextBox1.Text & "%'"

            Try

                con.Open()
                da = New OleDb.OleDbDataAdapter(Sql, con)
                da.Fill(dt)
                DataGridView1.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

            con.Close()
        ElseIf ComboBox1.Text = "Check out list" Then
            dt = New DataTable
            sql = "Select * from checkout where GUESTNAME LIKE '%" & TextBox1.Text & "%'"

            Try

                con.Open()
                da = New OleDb.OleDbDataAdapter(Sql, con)
                da.Fill(dt)
                DataGridView1.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

            con.Close()

        ElseIf ComboBox1.Text = "Reserve list" Then
            Button2.Show()
            dt = New DataTable
            sql = "Select * from reserve where GUESTNAME LIKE '%" & TextBox1.Text & "%'"

            Try

                con.Open()
                da = New OleDb.OleDbDataAdapter(Sql, con)
                da.Fill(dt)
                DataGridView1.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

            con.Close()

        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Check in list" Then
            dt = New DataTable
            Try
                sql = "SELECT * FROM checkin"
                conn.Open()
                With cmd
                    .CommandText = sql
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

        ElseIf ComboBox1.Text = "Check out list" Then
            dt = New DataTable
            Try
                sql = "SELECT * FROM checkout"
                conn.Open()
                With cmd
                    .CommandText = sql
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

        ElseIf ComboBox1.Text = "Reserve list" Then
            Button2.Show()
            dt = New DataTable
            Try
                sql = "SELECT * FROM reserve"
                conn.Open()
                With cmd
                    .CommandText = sql
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
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim CancelReservation = MessageBox.Show("Are you want to Cancel Your Reservation", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If CancelReservation = DialogResult.Yes Then
            con.Open()

            sql = "Update rooms set Status = 'Available' where rooms= '" & DataGridView1.CurrentRow.Cells("ROOM_NO").Value & "'"

            Try

                da = New OleDb.OleDbDataAdapter(sql, con)
                da.Fill(dt)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

            da.Dispose()

            dt = New DataTable
            sql = "Delete * from reserve where ROOM_NO= '" & DataGridView1.CurrentRow.Cells("ROOM_NO").Value & "'"

            Try

                da = New OleDb.OleDbDataAdapter(sql, con)
                da.Fill(dt)
                DataGridView1.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try



            con.Close()
        Else : CancelReservation = DialogResult.No

        End If


    End Sub
End Class