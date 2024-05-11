<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addTeacher
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GroupBox2 = New GroupBox()
        btnDeleteInstructor = New Button()
        Label4 = New Label()
        LstInstructors = New ListBox()
        btnOKInstructor = New Button()
        GroupBox1 = New GroupBox()
        txtMiddleInitial = New TextBox()
        Label3 = New Label()
        txtFirstName = New TextBox()
        Label2 = New Label()
        btnAddInstructor = New Button()
        btnCancelInstructor = New Button()
        txtLastName = New TextBox()
        Label1 = New Label()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnDeleteInstructor)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(LstInstructors)
        GroupBox2.Controls.Add(btnOKInstructor)
        GroupBox2.Location = New Point(14, 191)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(373, 254)
        GroupBox2.TabIndex = 68
        GroupBox2.TabStop = False
        GroupBox2.Text = "List of Faculty Members"
        ' 
        ' btnDeleteInstructor
        ' 
        btnDeleteInstructor.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        btnDeleteInstructor.Location = New Point(211, 213)
        btnDeleteInstructor.Name = "btnDeleteInstructor"
        btnDeleteInstructor.Size = New Size(142, 29)
        btnDeleteInstructor.TabIndex = 64
        btnDeleteInstructor.Text = "DELETE INSTRUCTOR"
        btnDeleteInstructor.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(6, 213)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 20)
        Label4.TabIndex = 62
        ' 
        ' LstInstructors
        ' 
        LstInstructors.FormattingEnabled = True
        LstInstructors.ItemHeight = 20
        LstInstructors.Location = New Point(19, 26)
        LstInstructors.Name = "LstInstructors"
        LstInstructors.Size = New Size(334, 184)
        LstInstructors.TabIndex = 63
        ' 
        ' btnOKInstructor
        ' 
        btnOKInstructor.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        btnOKInstructor.Location = New Point(143, 213)
        btnOKInstructor.Name = "btnOKInstructor"
        btnOKInstructor.Size = New Size(62, 29)
        btnOKInstructor.TabIndex = 4
        btnOKInstructor.Text = "OK"
        btnOKInstructor.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtMiddleInitial)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtFirstName)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(btnAddInstructor)
        GroupBox1.Controls.Add(btnCancelInstructor)
        GroupBox1.Controls.Add(txtLastName)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(14, 10)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(373, 181)
        GroupBox1.TabIndex = 67
        GroupBox1.TabStop = False
        GroupBox1.Text = "Add Instructor"
        ' 
        ' txtMiddleInitial
        ' 
        txtMiddleInitial.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtMiddleInitial.Location = New Point(149, 112)
        txtMiddleInitial.Name = "txtMiddleInitial"
        txtMiddleInitial.Size = New Size(153, 27)
        txtMiddleInitial.TabIndex = 65
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(33, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 20)
        Label3.TabIndex = 66
        Label3.Text = "Middle Initial:"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtFirstName.Location = New Point(149, 82)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(153, 27)
        txtFirstName.TabIndex = 63
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(33, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 20)
        Label2.TabIndex = 64
        Label2.Text = "First Name:"
        ' 
        ' btnAddInstructor
        ' 
        btnAddInstructor.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        btnAddInstructor.Location = New Point(188, 146)
        btnAddInstructor.Name = "btnAddInstructor"
        btnAddInstructor.Size = New Size(75, 29)
        btnAddInstructor.TabIndex = 62
        btnAddInstructor.Text = "ADD"
        btnAddInstructor.UseVisualStyleBackColor = True
        ' 
        ' btnCancelInstructor
        ' 
        btnCancelInstructor.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancelInstructor.Location = New Point(269, 146)
        btnCancelInstructor.Name = "btnCancelInstructor"
        btnCancelInstructor.Size = New Size(84, 29)
        btnCancelInstructor.TabIndex = 5
        btnCancelInstructor.Text = "CANCEL"
        btnCancelInstructor.UseVisualStyleBackColor = True
        ' 
        ' txtLastName
        ' 
        txtLastName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtLastName.Location = New Point(149, 52)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(153, 27)
        txtLastName.TabIndex = 57
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(33, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 20)
        Label1.TabIndex = 58
        Label1.Text = "Last Name:"
        ' 
        ' addTeacher
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(400, 455)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "addTeacher"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Instructor"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Private WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnDeleteInstructor As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents LstInstructors As ListBox
    Friend WithEvents btnOKInstructor As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMiddleInitial As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAddInstructor As Button
    Friend WithEvents btnCancelInstructor As Button
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label1 As Label
End Class
