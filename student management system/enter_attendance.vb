Imports System.Data.OleDb
Public Class enter_attendance
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim str As String

    Private Sub enter_attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OleDbConnection(provider)
        Dim cmd As OleDbCommand = New OleDbCommand("Select student_name,telephone ,mobile_number,class_day,class_time,instrument_studying,doj,ID FROM students", con)
        con.Open()
        Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        Dim myDataSet As DataSet = New DataSet()
        myDA.Fill(myDataSet, "MyTable")
        DataGridView1.DataSource = myDataSet.Tables("MyTable").DefaultView
        con.Close()
        con = Nothing
        Call load_grid()

    End Sub
    Sub load_grid()
        DataGridView1.Columns(0).Width = "250"
        DataGridView1.Columns(1).Width = "200"
        DataGridView1.Columns(2).Width = "100"
        DataGridView1.Columns(3).Width = "150"
        DataGridView1.Columns(4).Width = "95"
        DataGridView1.Columns(5).Width = "100"
        DataGridView1.Columns(1).HeaderText = "Name"
        DataGridView1.Columns(2).HeaderText = "Telephone"
        DataGridView1.Columns(3).HeaderText = "Mobile"
        DataGridView1.Columns(4).HeaderText = "Class Day"
        DataGridView1.Columns(5).HeaderText = "Time Of Class"
        DataGridView1.Columns(6).HeaderText = "Instrument"
        DataGridView1.Columns(7).HeaderText = "Date of Join"
        DataGridView1.Columns(8).Visible = False


    End Sub


    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        con = New OleDbConnection(provider)
        Dim cmd As OleDbCommand = New OleDbCommand("Select student_name,telephone ,mobile_number,class_day,class_time,instrument_studying,doj,ID FROM students WHERE [student_name]  like '%" & TextBox1.Text & "%' ", con)
        con.Open()
        Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        Dim myDataSet As DataSet = New DataSet()
        myDA.Fill(myDataSet, "MyTable")
        DataGridView1.DataSource = myDataSet.Tables("MyTable").DefaultView
        con.Close()
        con = Nothing
        Call load_grid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim i = DataGridView1.CurrentRow.Index
        Try

            Dim a As Boolean
            con = New OleDbConnection(provider)
            con.Open()
            For i = 0 To DataGridView1.Rows.Count - 1
                a = CBool(DataGridView1.Rows(i).Cells(0).Value)
                If a = True Then
                    'MsgBox(DataGridView1.Rows(i).Cells(1).Value)
                    Dim commandcheck As New OleDbCommand("SELECT * FROM student_attendances" _
                     & " WHERE  attendance_date=@attendance_date and student_id=@student_id", con)
                    Dim attendance_date As New OleDbParameter("@attendance_date", Me.DateTimePicker1.Text)
                    commandcheck.Parameters.Add(attendance_date)
                    Dim students_id As New OleDbParameter("@student_id", Me.DataGridView1.Rows(i).Cells(8).Value)
                    commandcheck.Parameters.Add(students_id)
                    Dim reader As OleDbDataReader = commandcheck.ExecuteReader
                    If reader.HasRows Then
                        MsgBox("Attendance for" + DataGridView1.Rows(i).Cells(1).Value + "already entered")
                    Else
                        str = "insert into student_attendances (attendance_date,student_id,student_name) values ('" & DateTimePicker1.Text & "' ," & DataGridView1.Rows(i).Cells(8).Value & ",'" & DataGridView1.Rows(i).Cells(1).Value.ToString & "')"
                        cmd = New OleDbCommand(str, con)
                        cmd.ExecuteNonQuery()
                    End If
                End If
            Next

            MsgBox("Attendance entered sucessfully")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class