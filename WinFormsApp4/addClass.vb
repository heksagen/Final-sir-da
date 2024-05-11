Public Class addClass
    Private Sub AddClass()
        Dim section As String = txtSection.Text.Trim()
        Dim course As String = txtCourse.Text.Trim()
        Dim yearLevel As String = txtYearLevel.Text.Trim()

        ' Check if all fields are filled
        If Not String.IsNullOrEmpty(section) AndAlso Not String.IsNullOrEmpty(course) AndAlso Not String.IsNullOrEmpty(yearLevel) Then
            ' Format the class information
            Dim classInfo As String = $"{course}-{yearLevel}{section} "

            ' Add the class to the listbox
            LstClasses.Items.Add(classInfo)

            ' Clear the textbox content
            ClearTextBoxes()
        Else
            MessageBox.Show("Please fill in all fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ClearTextBoxes()
        ' Clear the content of all textboxes
        txtSection.Clear()
        txtCourse.Clear()
        txtYearLevel.Clear()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearTextBoxes()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Remove the selected class from the listbox
        If LstClasses.SelectedIndex <> -1 Then
            LstClasses.Items.RemoveAt(LstClasses.SelectedIndex)
        Else
            MessageBox.Show("Please select a class to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Perform any final operations and close the form
        AddClass()
    End Sub

    Private Sub addClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class