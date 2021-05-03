Public Class splash

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub ProgressBarTimer_Tick(sender As Object, e As EventArgs) Handles ProgressBarTimer.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            ProgressBarTimer.Stop()
            login.Show()
            Me.Hide()
        End If

        Label3.Text = ProgressBar1.Value & "%"
        Label4.Text = DateTime.Now.ToString("dddd dd MMMM yyyy , hh:mm")
    End Sub
End Class
