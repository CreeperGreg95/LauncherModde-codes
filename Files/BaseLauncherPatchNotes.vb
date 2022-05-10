Public Class BaseLauncherPatchNotes
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MessageBox.Show("Déjà dessus :|", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        BaseLauncher.Show()
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
        BaseLauncherConfig.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        BaseLauncherSkins.Show()
        Me.Close()
    End Sub

    Private Sub BaseLauncherPatchNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WhatsNews.Show()
    End Sub
End Class