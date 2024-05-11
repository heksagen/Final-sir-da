Public Class addSchedule
    Private Sub addSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate ComboBox with days of the week
        comboBoxDay.Items.AddRange({"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})

        ' Populate ComboBox with existing room options
        comboBoxRoom.Items.AddRange({"Room 101", "Room 102", "Room 103"})

        ' Populate ComboBox with available courses
        comboBoxCourse.Items.AddRange({"BSIT 1B ", "BEED 2A", "BSHM 3C", "BSBA 1A"})

        ' Populate ComboBox with example instructor
        comboBoxInstructor.Items.Add("John Doe")

        ' Populate ComboBox with time intervals
        PopulateTimeComboBoxes()

        ' Set up ListView columns
        ListViewSchedule.View = View.Details
        ListViewSchedule.Columns.Add("Day", 100)
        ListViewSchedule.Columns.Add("Time In", 100)
        ListViewSchedule.Columns.Add("Time Out", 100)
        ListViewSchedule.Columns.Add("Room", 100)
        ListViewSchedule.Columns.Add("Section", 100)
        ListViewSchedule.Columns.Add("Instructor", 150)
    End Sub

    Private Sub PopulateTimeComboBoxes()
        ' Populate Time ComboBoxes with 30-minute intervals from 7:00 AM to 6:00 PM
        For hour As Integer = 7 To 18 ' Hours from 7 AM to 6 PM
            For minute As Integer = 0 To 30 Step 30 ' Minutes in 30-minute intervals
                If hour = 18 AndAlso minute = 30 Then
                    Exit For ' Exit the loop when it reaches 6:30 PM
                End If
                Dim formattedHour As Integer = If(hour > 12, hour - 12, hour)
                Dim timeString As String = $"{If(formattedHour < 10, "0", "")}{formattedHour}:{If(minute = 0, "00", "30")} {If(hour < 12, "AM", "PM")}"
                comboBoxTimeIn.Items.Add(timeString)
                comboBoxTimeOut.Items.Add(timeString)
            Next
        Next
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Handle form submission here
        If ValidateInput() Then
            Dim selectedDay As String = comboBoxDay.SelectedItem.ToString()
            Dim timeInValue As String = comboBoxTimeIn.SelectedItem.ToString()
            Dim timeOutValue As String = comboBoxTimeOut.SelectedItem.ToString()
            Dim roomValue As String = comboBoxRoom.SelectedItem.ToString()
            Dim courseValue As String = comboBoxCourse.SelectedItem.ToString()
            Dim instructorValue As String = comboBoxInstructor.SelectedItem.ToString()

            ' Add the schedule entry to the ListView
            Dim newItem As New ListViewItem({selectedDay, timeInValue, timeOutValue, roomValue, courseValue, instructorValue})
            ListViewSchedule.Items.Add(newItem)

            ' Optionally, you can clear the form fields after submission
            ClearFormFields()
        Else
            MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidateInput() As Boolean
        ' Check if all required fields are filled
        Return comboBoxDay.SelectedIndex <> -1 AndAlso
               comboBoxTimeIn.SelectedIndex <> -1 AndAlso
               comboBoxTimeOut.SelectedIndex <> -1 AndAlso
               comboBoxRoom.SelectedIndex <> -1 AndAlso
               comboBoxCourse.SelectedIndex <> -1 AndAlso
               comboBoxInstructor.SelectedIndex <> -1
    End Function

    Private Sub ClearFormFields()
        ' Clear all form fields
        comboBoxDay.SelectedIndex = -1
        comboBoxTimeIn.SelectedIndex = -1
        comboBoxTimeOut.SelectedIndex = -1
        comboBoxRoom.SelectedIndex = -1
        comboBoxCourse.SelectedIndex = -1
        comboBoxInstructor.SelectedIndex = -1
    End Sub
End Class
