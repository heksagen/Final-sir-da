Public Class addTeacher
    Private Sub AddInstructor()
        Dim firstName As String = txtFirstName.Text.Trim()
        Dim lastName As String = txtLastName.Text.Trim()
        Dim middleInitial As String = txtMiddleInitial.Text.Trim()

        ' Check if all fields are filled
        If Not String.IsNullOrEmpty(firstName) AndAlso Not String.IsNullOrEmpty(lastName) Then
            ' Concatenate the instructor's name
            Dim instructorName As String = $"{lastName}, {firstName} {middleInitial}. ".Trim()

            ' Add the instructor to the listbox
            LstInstructors.Items.Add(instructorName)

            ' Clear the textbox content
            ClearInstructorTextBoxes()
        Else
            MessageBox.Show("Please fill in the first name and last name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ClearInstructorTextBoxes()
        ' Clear the content of all instructor-related textboxes
        txtFirstName.Clear()
        txtLastName.Clear()
        txtMiddleInitial.Clear()
    End Sub

    Private Sub btnAddInstructor_Click(sender As Object, e As EventArgs) Handles btnAddInstructor.Click
        AddInstructor()
    End Sub

    Private Sub btnCancelInstructor_Click(sender As Object, e As EventArgs) Handles btnCancelInstructor.Click
        ClearInstructorTextBoxes()
    End Sub

    Private Sub btnDeleteInstructor_Click(sender As Object, e As EventArgs) Handles btnDeleteInstructor.Click
        ' Remove the selected instructor from the listbox
        If lstInstructors.SelectedIndex <> -1 Then
            lstInstructors.Items.RemoveAt(lstInstructors.SelectedIndex)
        Else
            MessageBox.Show("Please select an instructor to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnOKInstructor_Click(sender As Object, e As EventArgs) Handles btnOKInstructor.Click
        ' Perform any final operations and close the form
        Me.Close()
    End Sub
End Class