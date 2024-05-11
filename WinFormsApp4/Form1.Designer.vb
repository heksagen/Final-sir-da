<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addSchedule
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
        comboBoxDay = New ComboBox()
        comboBoxCourse = New ComboBox()
        dsd = New GroupBox()
        Label6 = New Label()
        Course = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        comboBoxTimeOut = New ComboBox()
        comboBoxTimeIn = New ComboBox()
        comboBoxInstructor = New ComboBox()
        btnSubmit = New Button()
        comboBoxRoom = New ComboBox()
        ListViewSchedule = New ListView()
        group = New GroupBox()
        dsd.SuspendLayout()
        group.SuspendLayout()
        SuspendLayout()
        ' 
        ' comboBoxDay
        ' 
        comboBoxDay.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxDay.FormattingEnabled = True
        comboBoxDay.Location = New Point(125, 62)
        comboBoxDay.Name = "comboBoxDay"
        comboBoxDay.Size = New Size(151, 28)
        comboBoxDay.TabIndex = 0
        ' 
        ' comboBoxCourse
        ' 
        comboBoxCourse.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxCourse.FormattingEnabled = True
        comboBoxCourse.Location = New Point(125, 198)
        comboBoxCourse.Name = "comboBoxCourse"
        comboBoxCourse.Size = New Size(151, 28)
        comboBoxCourse.TabIndex = 3
        ' 
        ' dsd
        ' 
        dsd.Controls.Add(Label6)
        dsd.Controls.Add(Course)
        dsd.Controls.Add(Label4)
        dsd.Controls.Add(Label3)
        dsd.Controls.Add(Label2)
        dsd.Controls.Add(Label1)
        dsd.Controls.Add(comboBoxTimeOut)
        dsd.Controls.Add(comboBoxTimeIn)
        dsd.Controls.Add(comboBoxInstructor)
        dsd.Controls.Add(btnSubmit)
        dsd.Controls.Add(comboBoxCourse)
        dsd.Controls.Add(comboBoxRoom)
        dsd.Controls.Add(comboBoxDay)
        dsd.Location = New Point(12, 12)
        dsd.Name = "dsd"
        dsd.Size = New Size(337, 426)
        dsd.TabIndex = 5
        dsd.TabStop = False
        dsd.Text = "Set Schedule"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(45, 240)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 20)
        Label6.TabIndex = 14
        Label6.Text = "Instructor:"
        ' 
        ' Course
        ' 
        Course.AutoSize = True
        Course.Location = New Point(62, 206)
        Course.Name = "Course"
        Course.Size = New Size(58, 20)
        Course.TabIndex = 13
        Course.Text = "Section"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(64, 172)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 20)
        Label4.TabIndex = 12
        Label4.Text = "Room:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(48, 138)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 20)
        Label3.TabIndex = 11
        Label3.Text = "Time out:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(58, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 20)
        Label2.TabIndex = 10
        Label2.Text = "Time in:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(78, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 20)
        Label1.TabIndex = 9
        Label1.Text = "Day:"
        ' 
        ' comboBoxTimeOut
        ' 
        comboBoxTimeOut.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxTimeOut.FormattingEnabled = True
        comboBoxTimeOut.Location = New Point(125, 130)
        comboBoxTimeOut.Name = "comboBoxTimeOut"
        comboBoxTimeOut.Size = New Size(151, 28)
        comboBoxTimeOut.TabIndex = 8
        ' 
        ' comboBoxTimeIn
        ' 
        comboBoxTimeIn.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxTimeIn.FormattingEnabled = True
        comboBoxTimeIn.Location = New Point(125, 96)
        comboBoxTimeIn.Name = "comboBoxTimeIn"
        comboBoxTimeIn.Size = New Size(151, 28)
        comboBoxTimeIn.TabIndex = 7
        ' 
        ' comboBoxInstructor
        ' 
        comboBoxInstructor.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxInstructor.FormattingEnabled = True
        comboBoxInstructor.Location = New Point(125, 232)
        comboBoxInstructor.Name = "comboBoxInstructor"
        comboBoxInstructor.Size = New Size(151, 28)
        comboBoxInstructor.TabIndex = 6
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(182, 278)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(94, 29)
        btnSubmit.TabIndex = 5
        btnSubmit.Text = "Apply"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' comboBoxRoom
        ' 
        comboBoxRoom.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxRoom.FormattingEnabled = True
        comboBoxRoom.Location = New Point(125, 164)
        comboBoxRoom.Name = "comboBoxRoom"
        comboBoxRoom.Size = New Size(151, 28)
        comboBoxRoom.TabIndex = 4
        ' 
        ' ListViewSchedule
        ' 
        ListViewSchedule.Location = New Point(6, 26)
        ListViewSchedule.Name = "ListViewSchedule"
        ListViewSchedule.Size = New Size(626, 384)
        ListViewSchedule.TabIndex = 6
        ListViewSchedule.UseCompatibleStateImageBehavior = False
        ' 
        ' group
        ' 
        group.Controls.Add(ListViewSchedule)
        group.Location = New Point(355, 12)
        group.Name = "group"
        group.Size = New Size(638, 426)
        group.TabIndex = 7
        group.TabStop = False
        group.Text = "List"
        ' 
        ' addSchedule
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1005, 452)
        Controls.Add(dsd)
        Controls.Add(group)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "addSchedule"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Schedule"
        dsd.ResumeLayout(False)
        dsd.PerformLayout()
        group.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents comboBoxDay As ComboBox
    Friend WithEvents comboBoxCourse As ComboBox
    Friend WithEvents dsd As GroupBox
    Friend WithEvents comboBoxRoom As ComboBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents ListViewSchedule As ListView
    Friend WithEvents group As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Course As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents comboBoxTimeOut As ComboBox
    Friend WithEvents comboBoxTimeIn As ComboBox
    Friend WithEvents comboBoxInstructor As ComboBox
End Class
