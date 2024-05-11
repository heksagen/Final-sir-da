<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class txtRoomName
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
        btnDeleteRoom = New Button()
        Label4 = New Label()
        LstRooms = New ListBox()
        btnOKRoom = New Button()
        GroupBox1 = New GroupBox()
        btnAddRoom = New Button()
        btnCancelRoom = New Button()
        txtRoomNumber = New TextBox()
        Label1 = New Label()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnDeleteRoom)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(LstRooms)
        GroupBox2.Controls.Add(btnOKRoom)
        GroupBox2.Location = New Point(12, 185)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(373, 262)
        GroupBox2.TabIndex = 66
        GroupBox2.TabStop = False
        GroupBox2.Text = "List of Rooms"
        ' 
        ' btnDeleteRoom
        ' 
        btnDeleteRoom.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        btnDeleteRoom.Location = New Point(239, 213)
        btnDeleteRoom.Name = "btnDeleteRoom"
        btnDeleteRoom.Size = New Size(114, 29)
        btnDeleteRoom.TabIndex = 64
        btnDeleteRoom.Text = "DELETE ROOM"
        btnDeleteRoom.UseVisualStyleBackColor = True
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
        ' LstRooms
        ' 
        LstRooms.FormattingEnabled = True
        LstRooms.ItemHeight = 20
        LstRooms.Location = New Point(19, 26)
        LstRooms.Name = "LstRooms"
        LstRooms.Size = New Size(334, 184)
        LstRooms.TabIndex = 63
        ' 
        ' btnOKRoom
        ' 
        btnOKRoom.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        btnOKRoom.Location = New Point(158, 213)
        btnOKRoom.Name = "btnOKRoom"
        btnOKRoom.Size = New Size(75, 29)
        btnOKRoom.TabIndex = 4
        btnOKRoom.Text = "OK"
        btnOKRoom.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnAddRoom)
        GroupBox1.Controls.Add(btnCancelRoom)
        GroupBox1.Controls.Add(txtRoomNumber)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 15)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(373, 178)
        GroupBox1.TabIndex = 65
        GroupBox1.TabStop = False
        GroupBox1.Text = "Add Room"
        ' 
        ' btnAddRoom
        ' 
        btnAddRoom.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        btnAddRoom.Location = New Point(188, 135)
        btnAddRoom.Name = "btnAddRoom"
        btnAddRoom.Size = New Size(75, 29)
        btnAddRoom.TabIndex = 62
        btnAddRoom.Text = "ADD"
        btnAddRoom.UseVisualStyleBackColor = True
        ' 
        ' btnCancelRoom
        ' 
        btnCancelRoom.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancelRoom.Location = New Point(269, 135)
        btnCancelRoom.Name = "btnCancelRoom"
        btnCancelRoom.Size = New Size(84, 29)
        btnCancelRoom.TabIndex = 5
        btnCancelRoom.Text = "CANCEL"
        btnCancelRoom.UseVisualStyleBackColor = True
        ' 
        ' txtRoomNumber
        ' 
        txtRoomNumber.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtRoomNumber.Location = New Point(149, 52)
        txtRoomNumber.Name = "txtRoomNumber"
        txtRoomNumber.Size = New Size(153, 27)
        txtRoomNumber.TabIndex = 57
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(33, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 20)
        Label1.TabIndex = 58
        Label1.Text = "Room Number:"
        ' 
        ' txtRoomName
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(403, 461)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "txtRoomName"
        StartPosition = FormStartPosition.CenterScreen
        Text = "addRoom"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Private WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnDeleteRoom As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents LstRooms As ListBox
    Friend WithEvents btnOKRoom As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAddRoom As Button
    Friend WithEvents btnCancelRoom As Button
    Friend WithEvents txtRoomNumber As TextBox
    Friend WithEvents Label1 As Label
End Class
