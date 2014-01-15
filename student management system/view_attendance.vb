Imports System.Data.OleDb
Public Class view_attendance
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim str As String

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            Dim search_date As Date = DateTimePicker1.Text
            con = New OleDbConnection(provider)
            Dim cmd As OleDbCommand = New OleDbCommand("Select attendance_date,student_name,Attendance FROM student_attendances where attendance_date=@attendance_date ", con)
            Dim attendance_date As New OleDbParameter("@attendance_date", Me.DateTimePicker1.Value.Date)
            cmd.Parameters.Add(attendance_date)
            con.Open()
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "MyTable")
            DataGridView1.DataSource = myDataSet.Tables("MyTable").DefaultView
            con.Close()
            con = Nothing
            Call load_grid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub view_attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim search_date As Date = DateTimePicker1.Text
            con = New OleDbConnection(provider)
            Dim cmd As OleDbCommand = New OleDbCommand("Select attendance_date,student_name,Attendance FROM student_attendances", con)
            con.Open()
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "MyTable")
            DataGridView1.DataSource = myDataSet.Tables("MyTable").DefaultView
            con.Close()
            con = Nothing
            Call load_grid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub load_grid()
        DataGridView1.Columns(0).Width = "250"
        DataGridView1.Columns(1).Width = "250"
        DataGridView1.Columns(2).Width = "233"
        DataGridView1.Columns(0).HeaderText = "Date"
        DataGridView1.Columns(1).HeaderText = "Student Name"
        DataGridView1.Columns(2).HeaderText = "Attendance"
    End Sub
End Class