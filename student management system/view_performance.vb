Imports System.Data.OleDb
Public Class view_performance
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim str As String

    Private Sub view_performance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            con = New OleDbConnection(provider)
            Dim cmd As OleDbCommand = New OleDbCommand("Select attendance_date,Attendance FROM student_attendances where student_id=@student_id ", con)
            Dim student As New OleDbParameter("@student_id", student_id)
            cmd.Parameters.Add(student)
            con.Open()
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "AttendanceTable")
            DataGridView1.DataSource = myDataSet.Tables("AttendanceTable").DefaultView

            Dim cmd1 As OleDbCommand = New OleDbCommand("Select paid_date,amount FROM student_payments where student_id=@student_id ", con)
            Dim student1 As New OleDbParameter("@student_id", student_id)
            cmd1.Parameters.Add(student1)

            Dim myDA1 As OleDbDataAdapter = New OleDbDataAdapter(cmd1)
            Dim myDataSet1 As DataSet = New DataSet()
            myDA1.Fill(myDataSet1, "FeesTable")
            DataGridView2.DataSource = myDataSet1.Tables("FeesTable").DefaultView

            ''form
            Dim connection As New OleDbConnection(provider)
            Dim command As New OleDbCommand("SELECT student_name,father_name,instrument_studying,doj,theory_passed,practical_passed,telephone,address FROM students WHERE  ID = @ID ", connection)
            Dim stu_id As New OleDbParameter("@ID", student_id)
            command.Parameters.Add(stu_id)
            command.Connection.Open()
            Dim reader As OleDbDataReader = command.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                TextBox1.Text = reader.Item(0).ToString
                TextBox2.Text = reader.Item(1).ToString
                TextBox3.Text = reader.Item(2).ToString
                TextBox4.Text = reader.Item(3).ToString
                TextBox5.Text = reader.Item(4).ToString
                TextBox6.Text = reader.Item(5).ToString
                TextBox7.Text = reader.Item(6).ToString
                TextBox8.Text = reader.Item(7).ToString
            End If

            con.Close()
            Call load_grid_fees()
            Call load_grid_attendance()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub DataGridView1_RowPrePaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles DataGridView1.RowPrePaint
        If e.RowIndex >= 0 Then
            Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value = e.RowIndex + 1
        End If
    End Sub
    
    Private Sub DataGridView2_RowPrePaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles DataGridView2.RowPrePaint
        If e.RowIndex >= 0 Then
            Me.DataGridView2.Rows(e.RowIndex).Cells(0).Value = e.RowIndex + 1
        End If
    End Sub

    Sub load_grid_attendance()
        DataGridView1.Columns(0).Width = "80"
        DataGridView1.Columns(1).Width = "132"
        DataGridView1.Columns(2).Width = "188"
        DataGridView1.Columns(0).HeaderText = "Serial No:"
        DataGridView1.Columns(1).HeaderText = "Date"
        DataGridView1.Columns(2).HeaderText = "Attendance"
        DataGridView1.RowHeadersVisible = False
    End Sub
    Sub load_grid_fees()
        DataGridView2.Columns(0).Width = "80"
        DataGridView2.Columns(1).Width = "132"
        DataGridView2.Columns(2).Width = "188"
        DataGridView2.Columns(0).HeaderText = "Serial No:"
        DataGridView2.Columns(1).HeaderText = "Paid Date"
        DataGridView2.Columns(2).HeaderText = "Amount"
        DataGridView2.RowHeadersVisible = False
    End Sub

End Class