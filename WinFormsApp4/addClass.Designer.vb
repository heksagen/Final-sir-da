<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addClass
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
        btnCancel = New Button()
        btnOK = New Button()
        txtSection = New TextBox()
        txtCourse = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        btnAdd = New Button()
        txtYearLevel = New TextBox()
        GroupBox2 = New GroupBox()
        btnDelete = New Button()
        Label4 = New Label()
        LstClasses = New ListBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnCancel
        ' 
        btnCancel.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancel.Location = New Point(269, 146)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(84, 29)
        btnCancel.TabIndex = 5
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnOK
        ' 
        btnOK.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        btnOK.Location = New Point(175, 213)
        btnOK.Name = "btnOK"
        btnOK.Size = New Size(75, 29)
        btnOK.TabIndex = 4
        btnOK.Text = "OK"
        btnOK.UseVisualStyleBackColor = True
        ' 
        ' txtSection
        ' 
        txtSection.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtSection.Location = New Point(123, 113)
        txtSection.Name = "txtSection"
        txtSection.Size = New Size(128, 27)
        txtSection.TabIndex = 56
        ' 
        ' txtCourse
        ' 
        txtCourse.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtCourse.Location = New Point(123, 52)
        txtCourse.Name = "txtCourse"
        txtCourse.Size = New Size(127, 27)
        txtCourse.TabIndex = 57
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(33, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 20)
        Label1.TabIndex = 58
        Label1.Text = "Course: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(33, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 20)
        Label2.TabIndex = 59
        Label2.Text = "Section:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(33, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 20)
        Label3.TabIndex = 60
        Label3.Text = "Year Level: "
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnAdd)
        GroupBox1.Controls.Add(txtYearLevel)
        GroupBox1.Controls.Add(btnCancel)
        GroupBox1.Controls.Add(txtSection)
        GroupBox1.Controls.Add(txtCourse)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(373, 190)
        GroupBox1.TabIndex = 61
        GroupBox1.TabStop = False
        GroupBox1.Text = "Add Class"
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdd.Location = New Point(188, 146)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 29)
        btnAdd.TabIndex = 62
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' txtYearLevel
        ' 
        txtYearLevel.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtYearLevel.Location = New Point(123, 82)
        txtYearLevel.Name = "txtYearLevel"
        txtYearLevel.Size = New Size(127, 27)
        txtYearLevel.TabIndex = 61
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnDelete)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(LstClasses)
        GroupBox2.Controls.Add(btnOK)
        GroupBox2.Location = New Point(12, 193)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(373, 254)
        GroupBox2.TabIndex = 62
        GroupBox2.TabStop = False
        GroupBox2.Text = "List of Classes"
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelete.Location = New Point(256, 213)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(101, 29)
        btnDelete.TabIndex = 64
        btnDelete.Text = "DELETE CLASS"
        btnDelete.UseVisualStyleBackColor = True
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
        ' LstClasses
        ' 
        LstClasses.FormattingEnabled = True
        LstClasses.ItemHeight = 20
        LstClasses.Location = New Point(19, 26)
        LstClasses.Name = "LstClasses"
        LstClasses.Size = New Size(334, 184)
        LstClasses.TabIndex = 63
        ' 
        ' addClass
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(398, 459)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "addClass"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Class Management"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Cancelbutton As Button
    Friend WithEvents OKbutton As Button
    Friend WithEvents Course1 As TextBox
    Friend WithEvents Year1 As NumericUpDown
    Friend WithEvents Section1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LstClasses As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Private WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents txtSection As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtYearLevel As TextBox
    Friend WithEvents btnDelete As Button
End Class
