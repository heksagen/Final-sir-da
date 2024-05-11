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
        textBoxTime = New TextBox()
        comboBoxCourse = New ComboBox()
        textBoxInstructor = New TextBox()
        dsd = New GroupBox()
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
        comboBoxDay.Location = New Point(61, 59)
        comboBoxDay.Name = "comboBoxDay"
        comboBoxDay.Size = New Size(151, 28)
        comboBoxDay.TabIndex = 0
        ' 
        ' textBoxTime
        ' 
        textBoxTime.Location = New Point(73, 105)
        textBoxTime.Name = "textBoxTime"
        textBoxTime.Size = New Size(125, 27)
        textBoxTime.TabIndex = 1
        ' 
        ' comboBoxCourse
        ' 
        comboBoxCourse.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxCourse.FormattingEnabled = True
        comboBoxCourse.Location = New Point(73, 171)
        comboBoxCourse.Name = "comboBoxCourse"
        comboBoxCourse.Size = New Size(151, 28)
        comboBoxCourse.TabIndex = 3
        ' 
        ' textBoxInstructor
        ' 
        textBoxInstructor.Location = New Point(73, 205)
        textBoxInstructor.Name = "textBoxInstructor"
        textBoxInstructor.Size = New Size(125, 27)
        textBoxInstructor.TabIndex = 4
        ' 
        ' dsd
        ' 
        dsd.Controls.Add(btnSubmit)
        dsd.Controls.Add(comboBoxRoom)
        dsd.Controls.Add(comboBoxDay)
        dsd.Location = New Point(12, 12)
        dsd.Name = "dsd"
        dsd.Size = New Size(337, 426)
        dsd.TabIndex = 5
        dsd.TabStop = False
        dsd.Text = "Set Schedule"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(182, 278)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(94, 29)
        btnSubmit.TabIndex = 5
        btnSubmit.Text = "Button1"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' comboBoxRoom
        ' 
        comboBoxRoom.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxRoom.FormattingEnabled = True
        comboBoxRoom.Location = New Point(61, 126)
        comboBoxRoom.Name = "comboBoxRoom"
        comboBoxRoom.Size = New Size(151, 28)
        comboBoxRoom.TabIndex = 4
        ' 
        ' ListViewSchedule
        ' 
        ListViewSchedule.Location = New Point(6, 26)
        ListViewSchedule.Name = "ListViewSchedule"
        ListViewSchedule.Size = New Size(492, 384)
        ListViewSchedule.TabIndex = 6
        ListViewSchedule.UseCompatibleStateImageBehavior = False
        ' 
        ' group
        ' 
        group.Controls.Add(ListViewSchedule)
        group.Location = New Point(355, 12)
        group.Name = "group"
        group.Size = New Size(515, 426)
        group.TabIndex = 7
        group.TabStop = False
        group.Text = "List"
        ' 
        ' addSchedule
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(882, 452)
        Controls.Add(textBoxInstructor)
        Controls.Add(comboBoxCourse)
        Controls.Add(textBoxTime)
        Controls.Add(dsd)
        Controls.Add(group)
        Name = "addSchedule"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Schedule"
        dsd.ResumeLayout(False)
        group.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents comboBoxDay As ComboBox
    Friend WithEvents textBoxTime As TextBox
    Friend WithEvents comboBoxCourse As ComboBox
    Friend WithEvents textBoxInstructor As TextBox
    Friend WithEvents dsd As GroupBox
    Friend WithEvents comboBoxRoom As ComboBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents ListViewSchedule As ListView
    Friend WithEvents group As GroupBox
End Class
