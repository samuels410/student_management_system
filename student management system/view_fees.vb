Imports System.Data.OleDb
Public Class view_fees
    Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader
        Dim str As String


        Private Sub view_fees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Try
                Dim search_date As Date = DateTimePicker1.Text
                con = New OleDbConnection(provider)
            Dim cmd As OleDbCommand = New OleDbCommand("Select paid_date,student_name,amount,student_id FROM student_payments", con)
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

        Private Sub view_fees_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Try
            Dim search_date As Date = DateTimePicker1.Text
            con = New OleDbConnection(provider)
            Dim cmd As OleDbCommand = New OleDbCommand("Select paid_date,student_name,amount,student_id FROM student_payments", con)
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
        DataGridView1.Columns(2).HeaderText = "Amount"
        DataGridView1.Columns(3).Visible = False
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            Dim search_date As Date = DateTimePicker1.Text
            con = New OleDbConnection(provider)
            Dim cmd As OleDbCommand = New OleDbCommand("select paid_date,student_name,amount,student_id FROM student_payments where paid_date=@paid_date ", con)
            Dim paid_date As New OleDbParameter("@paid_date", Me.DateTimePicker1.Value.Date)
            cmd.Parameters.Add(paid_date)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim search_date As Date = DateTimePicker1.Text
            con = New OleDbConnection(provider)
            Dim cmd As OleDbCommand = New OleDbCommand("Select paid_date,student_name,amount,student_id FROM student_payments", con)
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
End Class