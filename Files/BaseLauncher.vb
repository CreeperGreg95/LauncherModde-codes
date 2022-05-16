Public Class BaseLauncher
    Private Sub BaseLauncher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Les configurations pour les jeux commencent dès maintenant ! Ayez bien installé la DERNIERE VERSION du lanceur !", "INFORMATION !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        MessageBox.Show("Nous suivons actuellement les problèmes avec les services du lanceur Minecraft, vous pourriez rencontrer des connexions intermittentes. Nous enquêtons - Mojang Studios", "ALERT", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NewsMCLauncher.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WhatsNews.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Close()
        NewsMCLauncher.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        MessageBox.Show("Une erreur est survenue | Erreur : 45", "Oups !", MessageBoxButtons.OK, MessageBoxIcon.Error)
        WaitingLoading.ShowDialog()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        MessageBox.Show("Une erreur est survenue | Erreur : 56", "Oups !", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MessageBox.Show("Déjà dessus :|", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
        BaseLauncherConfig.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Loading.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        Settings.Show()
    End Sub
End Class