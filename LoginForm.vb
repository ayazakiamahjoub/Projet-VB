Public Class LoginForm
    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Application.Exit()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        If RoleSelectionForm.Role = UserRole.Admin Then
            If username = "admin" AndAlso password = "admin" Then
                MessageBox.Show("Connexion réussie en tant qu'Admin.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim adminForm As New AdminForm()
                adminForm.Show()
                Me.Hide()
            Else
                lblErreur.Text = "Nom d'utilisateur ou mot de passe incorrect."
            End If
        ElseIf RoleSelectionForm.Role = UserRole.User Then
            If username = "user" AndAlso password = "user" Then
                MessageBox.Show("Connexion réussie en tant qu'Utilisateur.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim userForm As New UserForm()
                userForm.Show()
                Me.Hide()
            Else
                lblErreur.Text = "Nom d'utilisateur ou mot de passe incorrect."
            End If
        Else
            lblErreur.Text = "Erreur de sélection de rôle."
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class