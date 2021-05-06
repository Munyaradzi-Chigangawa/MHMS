Imports System.Data.OleDb

Public Class login

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            password.PasswordChar = ""
        Else
            password.PasswordChar = "•"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\mhms.mdb")
        Dim cmd As OleDbCommand = New OleDbCommand( _
                   "SELECT * FROM users WHERE username = '" & _
                  username.Text & "'  AND [password] = '" & password.Text & "' ", con)
        Dim user As String = ""
        Dim pass As String = ""

        con.Open()

        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            user = sdr("username")
            pass = sdr("password")
            MsgBox("Successfully Logged in, Welcome.", MessageBoxIcon.Information, "Login Successful.")
            main.BringToFront()
            main.Show()
            Me.Hide()
        Else
                MsgBox("Invalid Login Details. Please Provide your Login Details", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End If
    End Sub
End Class