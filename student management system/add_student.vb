Imports System.Data.OleDb

Public Class add_student
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim str As String
    

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cn = New OleDbConnection(provider)
            cn.Open()
            str = "insert into students (student_name,father_name,occupation,place_of_work,dob,class_studying,school_of_place,telephone," _
                 & "mobile_number,class_day,class_time,email,address,instrument_studying,examinations,theory_passed,practical_passed,doj) " _
                 & "values ('" & LTrim(TextBox1.Text) & "','" & LTrim(TextBox2.Text) & "','" & LTrim(TextBox3.Text) & "','" & LTrim(TextBox8.Text) & "'," _
                 & "'" & DateTimePicker1.Text & "','" & LTrim(TextBox4.Text) & "','" & LTrim(TextBox5.Text) & "','" & LTrim(TextBox6.Text) & "'," _
                 & "'" & LTrim(TextBox7.Text) & "','" & ComboBox4.Text & "','" & NumericUpDown2.Text & "','" & LTrim(TextBox10.Text) & "'," _
                 & "'" & LTrim(TextBox11.Text) & "','" & ComboBox5.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "'," _
                 & "'" & ComboBox3.Text & "','" & DateTimePicker2.Text & "')"

            cmd = New OleDbCommand(str, cn)
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("New Student added")
            Call clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()

    End Sub
    Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""



    End Sub
    


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call clear()
    End Sub

    Private Sub add_student_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class