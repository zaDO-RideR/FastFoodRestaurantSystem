Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If username = "admin" And password = "1199" Then
            MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim dashboard As New DashboardForm()
            dashboard.Show()
            Me.Hide()
        Else
            lblMessage.Text = "Invalid username or password."
            lblMessage.ForeColor = Color.Red
        End If
    End Sub
End Class
