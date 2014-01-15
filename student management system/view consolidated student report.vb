Imports System.Data.OleDb
Public Class view_consolidated_student_report
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim str As String

    Private Sub list_students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'student_dbDataSet1.students' table. You can move, or remove it, as needed.
        Me.studentsTableAdapter.Fill(Me.student_dbDataSet1.students)
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
        DataGridView1.Columns(0).HeaderText = "Name"
        DataGridView1.Columns(1).HeaderText = "Telephone"
        DataGridView1.Columns(2).HeaderText = "Mobile"
        DataGridView1.Columns(3).HeaderText = "Class Day"
        DataGridView1.Columns(4).HeaderText = "Time Of Class"
        DataGridView1.Columns(5).HeaderText = "Instrument"
        DataGridView1.Columns(6).HeaderText = "Date of Join"
        DataGridView1.Columns(7).Visible = False


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        con = New OleDbConnection(provider)
        Dim cmd As OleDbCommand = New OleDbCommand("Select student_name,telephone ,mobile_number,class_day,class_time,instrument_studying,doj,ID FROM students WHERE [student_name]  like '" & TextBox1.Text & "%' ", con)
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

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim i = DataGridView1.CurrentRow.Index
        student_id = DataGridView1.Item(7, i).Value
        Me.Hide()
        view_performance.Show()
    End Sub
End Class