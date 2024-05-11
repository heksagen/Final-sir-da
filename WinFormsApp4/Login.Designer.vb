<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Button1 = New Button()
        grpbxLogin = New GroupBox()
        chkShowPassword = New CheckBox()
        grpbxLogin.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 20)
        Label1.TabIndex = 0
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 20)
        Label2.TabIndex = 1
        Label2.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(96, 68)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(186, 27)
        txtPassword.TabIndex = 2
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(96, 35)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(186, 27)
        txtUsername.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(188, 131)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 4
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' grpbxLogin
        ' 
        grpbxLogin.Controls.Add(chkShowPassword)
        grpbxLogin.Controls.Add(Label1)
        grpbxLogin.Controls.Add(Button1)
        grpbxLogin.Controls.Add(txtPassword)
        grpbxLogin.Controls.Add(txtUsername)
        grpbxLogin.Controls.Add(Label2)
        grpbxLogin.Location = New Point(128, 126)
        grpbxLogin.Name = "grpbxLogin"
        grpbxLogin.Size = New Size(297, 179)
        grpbxLogin.TabIndex = 5
        grpbxLogin.TabStop = False
        grpbxLogin.Text = "Account Login"
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Location = New Point(150, 101)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(132, 24)
        chkShowPassword.TabIndex = 6
        chkShowPassword.Text = "Show Password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(561, 442)
        Controls.Add(grpbxLogin)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Form"
        grpbxLogin.ResumeLayout(False)
        grpbxLogin.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents grpbxLogin As GroupBox
    Friend WithEvents chkShowPassword As CheckBox

End Class
