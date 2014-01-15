Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'student_dbDataSet2.students' table. You can move, or remove it, as needed.
        Me.studentsTableAdapter.Fill(Me.student_dbDataSet2.students)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
    End Sub
End Class