Public Class main

    Private Sub btnaccount_Click(sender As Object, e As EventArgs) Handles btnaccount.Click
        If MessageBox.Show("Please confirm shutting down the system!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs)

        guestinfo.Show()
        Me.Hide()
    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        checkin.Show()
        Me.Hide()
    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        cashier.Show()
        Me.Hide()
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        reservation.Show()
        Me.Hide()
    End Sub

    Private Sub btnGuest_Click_1(sender As Object, e As EventArgs) Handles btnGuest.Click
        guestinfo.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        rooms.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Search.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        history.ShowDialog()
    End Sub
End Class