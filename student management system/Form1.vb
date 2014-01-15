Public Class Form1

    Private Sub StudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem.Click

    End Sub

    Private Sub NewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewStudentToolStripMenuItem.Click
        add_student.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ListStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListStudentsToolStripMenuItem.Click
        Form2.Show()

    End Sub

    Private Sub EnterAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterAttendanceToolStripMenuItem.Click
        enter_attendance.Show()
    End Sub


    Private Sub EditStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditStudentToolStripMenuItem.Click
        list_students.Show()
    End Sub

    Private Sub ViewAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAttendanceToolStripMenuItem.Click
        view_attendance.Show()
    End Sub

    Private Sub EnterFeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterFeesToolStripMenuItem.Click
        enter_student_fee.Show()
    End Sub

    Private Sub ViewFeesDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewFeesDetailsToolStripMenuItem.Click
        view_fees.Show()
    End Sub

    Private Sub IndividualStudentReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndividualStudentReportToolStripMenuItem.Click
        view_consolidated_student_report.Show()
    End Sub
End Class
