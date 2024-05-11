Public Class Login
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String
        Dim password As String
        username = txtUsername.Text
        password = txtPassword.Text
        If (username.Equals("admin")) And (password.Equals("admin")) Then
            MessageBox.Show("Login Success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim form2 As New MainUI()
            form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Account", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub
End Class
