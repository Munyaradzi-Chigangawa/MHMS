Imports System.Data.OleDb
Public Class guestinfo
    Dim Gender As String
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If Len(Trim(txtFName.Text)) = 0 Then
            MessageBox.Show("Sorry First Name cannot be empty.", "First Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFName.Focus()
        End If

        If Len(Trim(txtLName.Text)) = 0 Then
            MessageBox.Show("Sorry Surname cannot be empty.", "Surname", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLName.Focus()

            If Len(Trim(txtAddress.Text)) = 0 Then
                MessageBox.Show("Address cannot be empty.", "Address", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAddress.Focus()
            End If
        End If


        If RadioButton1.Checked Then
            Gender = "Male"
        ElseIf RadioButton2.Checked Then
            Gender = "Female"
        End If
        save("INSERT INTO  guests (FNAME,LNAME,NATIONALITY,ADDRESS,CONTACT_NO,GENDER,EMAIL) VALUES ('" & txtFName.Text & "', '" & txtLName.Text & "','" & txtNationality.Text & "', '" & txtAddress.Text & "', '" & txtNumber.Text & "', '" & Gender & "', '" & txtEmail.Text & "')")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        main.BringToFront()
        main.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtFName.Text = ""
        txtLName.Text = ""
        txtNationality.Text = ""
        txtAddress.Text = ""
        txtNumber.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        txtEmail.Text = ""
    End Sub

End Class