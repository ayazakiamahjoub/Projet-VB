Public Enum UserRole
    Admin
    User
End Enum
Public Class RoleSelectionForm
    Public Shared Role As UserRole
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Role = UserRole.Admin
        MessageBox.Show("Rôle sélectionné : Admin")
        ProceedToLogin()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        Role = UserRole.User
        MessageBox.Show("Rôle sélectionné : User")
        ProceedToLogin()
    End Sub
    Private Sub ProceedToLogin()
        Try
            MessageBox.Show("Avant d'ouvrir LoginForm.")
            Dim loginForm As New LoginForm()
            MessageBox.Show("LoginForm créé.")
            loginForm.Show()
            MessageBox.Show("LoginForm affiché.")
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Erreur lors de l'ouverture de LoginForm: " & ex.Message)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class
