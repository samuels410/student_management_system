Imports System.Data.OleDb
Public Class enter_student_fee
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
        Label8.Visible = False


    End Sub


    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Panel1.Visible = True
        Dim i = DataGridView1.CurrentRow.Index
        student_id = DataGridView1.Item(7, i).Value
        Try
            Dim connection As New OleDbConnection(provider)
            Dim command As New OleDbCommand("SELECT * FROM students WHERE  ID = @ID ", connection)
            Dim stu_id As New OleDbParameter("@ID", student_id)
            command.Parameters.Add(stu_id)
            command.Connection.Open()
            Dim reader As OleDbDataReader = command.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                Dim student_name As String = reader.Item(1).ToString
                Label3.Text = student_name
                Dim mobile_number As String = reader.Item(9)
                Label4.Text = mobile_number
                Dim join_date As String = reader.Item(18)
                Label5.Text = join_date
                command.Connection.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = False
        Label8.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If TextBox2.Text = "" Then
                Label8.Visible = True
                Label8.Text = "Amount Cannot be Blank"

            Else
                Dim i = DataGridView1.CurrentRow.Index
                student_id = DataGridView1.Item(7, i).Value
                con = New OleDbConnection(provider)
                con.Open()
                Dim commandcheck As New OleDbCommand("SELECT * FROM student_payments" _
                 & " WHERE  paid_date=@paid_date and student_id=@student_id", con)
                Dim paid_date As New OleDbParameter("@paid_date", Me.DateTimePicker1.Text)
                commandcheck.Parameters.Add(paid_date)
                Dim students_id As New OleDbParameter("@student_id", student_id)
                commandcheck.Parameters.Add(students_id)
                Dim reader As OleDbDataReader = commandcheck.ExecuteReader
                If reader.HasRows Then
                    MsgBox("Student " + DataGridView1.Rows(i).Cells(0).Value + "already paid for this date")
                Else
                    str = "insert into student_payments (paid_date,student_id,student_name,amount) values ('" & DateTimePicker1.Text & "' ," & DataGridView1.Item(7, i).Value & ",'" & DataGridView1.Rows(i).Cells(0).Value.ToString & "','" & TextBox2.Text & "')"
                    cmd = New OleDbCommand(str, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Student Payment Entered")
                End If


                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class