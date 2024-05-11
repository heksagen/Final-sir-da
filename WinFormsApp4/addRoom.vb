Public Class txtRoomName
    Private Sub AddRoom()
        Dim roomName As String = txtRoomNumber.Text.Trim()

        ' Check if the room name is filled
        If Not String.IsNullOrEmpty(roomName) Then
            ' Add the room to the listbox
            LstRooms.Items.Add(roomName)

            ' Clear the textbox content
            ClearRoomTextBox()
        Else
            MessageBox.Show("Please fill in the room name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ClearRoomTextBox()
        ' Clear the content of the room name textbox
        txtRoomNumber.Clear()
    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click
        AddRoom()
    End Sub

    Private Sub btnCancelRoom_Click(sender As Object, e As EventArgs) Handles btnCancelRoom.Click
        ClearRoomTextBox()
    End Sub

    Private Sub btnDeleteRoom_Click(sender As Object, e As EventArgs) Handles btnDeleteRoom.Click
        ' Remove the selected room from the listbox
        If LstRooms.SelectedIndex <> -1 Then
            LstRooms.Items.RemoveAt(LstRooms.SelectedIndex)
        Else
            MessageBox.Show("Please select a room to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnOKRoom_Click(sender As Object, e As EventArgs) Handles btnOKRoom.Click
        ' Perform any final operations and close the form
        Me.Close()
    End Sub
End Class