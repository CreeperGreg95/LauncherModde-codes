Public Class SettingsAccounts
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MessageBox.Show("Vous ne pouvez pas modifier ce compte !")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        MessageBox.Show("Aucun compte a été inséré dans le lanceur !")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        Settings.Show()
    End Sub
End Class