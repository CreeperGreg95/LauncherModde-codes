Public Class BaseLauncherConfig
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        BaseLauncher.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MessageBox.Show("Déjà dessus :|", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Close()
        BaseLauncherSkins.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
        BaseLauncherPatchNotes.Show()
    End Sub

    Private Sub BaseLauncherConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Close()
        BaseLauncherConfigModpackSteelialSettings.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Process.Start("C:\LauncherModde\Games\java_minecraft\packs\ModpackSteelial")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If Not System.IO.Directory.Exists("C:\LauncherModde\Games\java_minecraft\packs\ModpackSteelial") Then
            System.IO.Directory.CreateDirectory("C:\LauncherModde\Games\java_minecraft\packs\ModpackSteelial")
        End If
    End Sub
End Class