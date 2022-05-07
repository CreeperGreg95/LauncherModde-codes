Public Class NewsMCLauncher
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("https://www.minecraft.net/fr-fr/article/new-java-realms--career-choices?ref=launcher")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://www.minecraft.net/fr-ca/article/new-realms-affordable-housing?ref=launcher")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        BaseLauncher.Show()
    End Sub
End Class