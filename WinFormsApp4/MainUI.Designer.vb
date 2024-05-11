<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainUI
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
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        StatusStrip1 = New StatusStrip()
        lblTimer = New ToolStripStatusLabel()
        Timer1 = New Timer(components)
        btnClassManagement = New Button()
        GroupBox1 = New GroupBox()
        btnScheduleManagement = New Button()
        btnInstructorManagement = New Button()
        btnRoomManagement = New Button()
        StatusStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblTimer})
        StatusStrip1.Location = New Point(0, 422)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 26)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' lblTimer
        ' 
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(153, 20)
        lblTimer.Text = "ToolStripStatusLabel1"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' btnClassManagement
        ' 
        btnClassManagement.Location = New Point(6, 26)
        btnClassManagement.Name = "btnClassManagement"
        btnClassManagement.Size = New Size(150, 28)
        btnClassManagement.TabIndex = 5
        btnClassManagement.Text = "Class Management"
        btnClassManagement.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnScheduleManagement)
        GroupBox1.Controls.Add(btnInstructorManagement)
        GroupBox1.Controls.Add(btnRoomManagement)
        GroupBox1.Controls.Add(btnClassManagement)
        GroupBox1.Location = New Point(12, 27)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(161, 392)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Dashboard"
        ' 
        ' btnScheduleManagement
        ' 
        btnScheduleManagement.Location = New Point(6, 155)
        btnScheduleManagement.Name = "btnScheduleManagement"
        btnScheduleManagement.Size = New Size(150, 55)
        btnScheduleManagement.TabIndex = 9
        btnScheduleManagement.Text = "Schedule Management"
        btnScheduleManagement.UseVisualStyleBackColor = True
        ' 
        ' btnInstructorManagement
        ' 
        btnInstructorManagement.Location = New Point(5, 94)
        btnInstructorManagement.Name = "btnInstructorManagement"
        btnInstructorManagement.Size = New Size(150, 55)
        btnInstructorManagement.TabIndex = 8
        btnInstructorManagement.Text = "Instructor " & vbCrLf & "Management"
        btnInstructorManagement.UseVisualStyleBackColor = True
        ' 
        ' btnRoomManagement
        ' 
        btnRoomManagement.Location = New Point(5, 60)
        btnRoomManagement.Name = "btnRoomManagement"
        btnRoomManagement.Size = New Size(150, 28)
        btnRoomManagement.TabIndex = 7
        btnRoomManagement.Text = "Room Management"
        btnRoomManagement.UseVisualStyleBackColor = True
        ' 
        ' MainUI
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 448)
        Controls.Add(GroupBox1)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "MainUI"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Class Scheduling System"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SubjectsToolStripMenuItem As ToolStripComboBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblTimer As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnClassManagement As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRoomManagement As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnInstructorManagement As Button
    Friend WithEvents btnScheduleManagement As Button
End Class
