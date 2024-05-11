
Public Class addSchedule
    Private Sub addSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate ComboBox with days of the week
        comboBoxDay.Items.AddRange({"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})

        ' Populate ComboBox with existing room options
        comboBoxRoom.Items.AddRange({"Room 101", "Room 102", "Room 103"})
        comboBoxCourse.Items.AddRange({"BSIT", "BEED", "BSHM", "BSBA"})

        ' Set up ListView columns
        ListViewSchedule.View = View.Details
        listViewSchedule.Columns.Add("Day", 100)
        listViewSchedule.Columns.Add("Time", 100)
        listViewSchedule.Columns.Add("Room", 100)
        ListViewSchedule.Columns.Add("Section", 100)
        ListViewSchedule.Columns.Add("Instructor", 150)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Handle form submission here
        Dim selectedDay As String = comboBoxDay.SelectedItem.ToString()
        Dim timeValue As String = textBoxTime.Text
        Dim roomValue As String = comboBoxRoom.SelectedItem.ToString()
        Dim courseValue As String = comboBoxCourse.SelectedItem.ToString()
        Dim instructorValue As String = textBoxInstructor.Text

        ' Add the schedule entry to the ListView
        Dim newItem As New ListViewItem({selectedDay, timeValue, roomValue, courseValue, instructorValue})
        listViewSchedule.Items.Add(newItem)

        ' Optionally, you can clear the form fields after submission
        ClearFormFields()
    End Sub

    Private Sub ClearFormFields()
        ' Clear all form fields
        comboBoxDay.SelectedIndex = -1
        textBoxTime.Clear()
        comboBoxRoom.SelectedIndex = -1
        comboBoxCourse.SelectedIndex = -1
        textBoxInstructor.Clear()
    End Sub


End Class