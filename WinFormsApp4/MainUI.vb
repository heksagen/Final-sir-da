Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class MainUI

    Private Sub MainUI_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ' When MainUI form is closed, close the login form if it's still open
        Dim loginForm As Login = Application.OpenForms("Form1")
        If Login IsNot Nothing Then
            Login.Close()
        End If
    End Sub
    Private Sub MainUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimer.Text = Now
    End Sub

    Private Sub btnClassManagement_Click(sender As Object, e As EventArgs) Handles btnClassManagement.Click
        addClass.Show()
    End Sub
    Private Sub btnRoomManagement_Click(sender As Object, e As EventArgs) Handles btnRoomManagement.Click
        txtRoomName.Show()
    End Sub
    Private Sub btnInstructorManagement_Click(sender As Object, e As EventArgs) Handles btnInstructorManagement.Click
        addTeacher.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnScheduleManagement.Click
        addSchedule.Show()
    End Sub
End Class

