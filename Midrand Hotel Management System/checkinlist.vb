Public Class checkinlist
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
    Private Sub checkinlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt = New DataTable
        Try
            sql = "SELECT * FROM guests"
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
            DataGridView2.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()


        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        dt = New DataTable
        GuestId = DataGridView1.CurrentRow.Cells("ID").Value.ToString
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick

        'checkin
        checkin.txtgname.Text = DataGridView1.CurrentRow.Cells("FNAME").Value.ToString()
        checkin.txtgname.Text &= " " & DataGridView1.CurrentRow.Cells("LNAME").Value.ToString
        checkin.txtgname.Text &= " " & DataGridView1.CurrentRow.Cells("NATIONALITY").Value.ToString

        'reservation
        reservation.txtgname1.Text = DataGridView1.CurrentRow.Cells("FNAME").Value.ToString()
        reservation.txtgname1.Text &= " " & DataGridView1.CurrentRow.Cells("LNAME").Value.ToString
        reservation.txtgname1.Text &= " " & DataGridView1.CurrentRow.Cells("NATIONALITY").Value.ToString
        main.BringToFront()
        Me.Hide()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        dt = New DataTable
        GuestId = DataGridView1.CurrentRow.Cells("ID").Value.ToString
    End Sub

    Private Sub DataGridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.DoubleClick
        dt = New DataTable
        GuestId = DataGridView2.CurrentRow.Cells("ID").Value.ToString
        checkin.txtgname.Text &= " " & DataGridView2.CurrentRow.Cells("GUESTNAME").Value.ToString
        checkin.txtRoom.Text = DataGridView2.CurrentRow.Cells("ROOM_NO").Value.ToString()
        checkin.rate.Text = DataGridView2.CurrentRow.Cells("ROOM_RATE").Value.ToString()
        checkin.txttype.Text = DataGridView2.CurrentRow.Cells("ROOM_TYPE").Value.ToString()

        checkin.txtdate.Value = DataGridView2.CurrentRow.Cells("CHECKIN_DATE").Value.ToString()
        checkin.txtdays.Text = DataGridView2.CurrentRow.Cells("NOOFDAYS").Value.ToString()
        checkin.txtadults.Text = DataGridView2.CurrentRow.Cells("NOOFADULTS").Value.ToString()
        checkin.txtChildren.Text = DataGridView2.CurrentRow.Cells("NOOFCHILDREN").Value.ToString()
        checkin.txtadvance.Text = DataGridView2.CurrentRow.Cells("ADVANCE").Value.ToString()

        Me.Close()
    End Sub
End Class