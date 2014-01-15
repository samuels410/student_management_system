Imports System.Data.OleDb
Public Class edit_student
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim str As String
    Private Sub edit_student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        list_students.Show()

    End Sub

    Private Sub edit_student_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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
                TextBox1.Text = student_name
                Dim father_name As String = reader.Item(2).ToString
                TextBox2.Text = father_name
                Dim occupation As String = reader.Item(3).ToString
                TextBox3.Text = occupation
                Dim place_of_work As String = reader.Item(4).ToString
                TextBox8.Text = place_of_work
                Dim dob As String = reader.Item(5)
                DateTimePicker1.Text = dob
                Dim class_studying As String = reader.Item(6)
                TextBox4.Text = class_studying
                Dim school_of_place As String = reader.Item(7)
                TextBox5.Text = school_of_place
                Dim telephone As String = reader.Item(8)
                TextBox6.Text = telephone
                Dim mobile_number As String = reader.Item(9)
                TextBox7.Text = mobile_number
                Dim class_day As String = reader.Item(10)
                ComboBox4.Text = class_day
                Dim class_time As String = reader.Item(11)
                NumericUpDown2.Value = class_time
                Dim email As String = reader.Item(12)
                TextBox10.Text = email
                Dim address As String = reader.Item(13)
                TextBox11.Text = address
                Dim instrument_studying As String = reader.Item(14)
                ComboBox5.Text = instrument_studying
                Dim examinations As String = reader.Item(15)
                ComboBox1.Text = examinations
                Dim theory_passed As String = reader.Item(16)
                ComboBox2.Text = theory_passed
                Dim practical_passed As String = reader.Item(17)
                ComboBox3.Text = practical_passed
                Dim doj As String = reader.Item(18)
                DateTimePicker2.Text = doj
                command.Connection.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con = New OleDbConnection(provider)
            con.Open()
            str = "update students set student_name = ' " & TextBox1.Text.Trim() & " ' ,father_name = ' " & TextBox2.Text.Trim() & " ' ,occupation = ' " & TextBox3.Text.Trim() & " ' ,place_of_work = ' " & TextBox8.Text.Trim() & " ' ,dob = ' " & DateTimePicker1.Text.Trim() & " ' , class_studying= ' " & TextBox4.Text.Trim() & " ' ,school_of_place = ' " & TextBox5.Text.Trim() & " ' ,telephone = ' " & TextBox6.Text.Trim() & " ' ,mobile_number = ' " & TextBox7.Text.Trim() & " ' ,class_day = ' " & ComboBox4.Text.Trim() & " ' ,class_time = ' " & NumericUpDown2.Value.ToString & " ' ,email = ' " & TextBox10.Text.Trim() & " ' ,address = ' " & TextBox11.Text.Trim() & " ' ,instrument_studying = ' " & ComboBox5.Text.Trim() & " ' , examinations = ' " & ComboBox1.Text.Trim() & " ' ,theory_passed = ' " & ComboBox2.Text.Trim() & " ' ,practical_passed = ' " & ComboBox3.Text.Trim() & " ' , doj= ' " & DateTimePicker2.Value & "'  where Id = " & student_id & ""
            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()
            MsgBox("Student Details Updated")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox("Are you sure ?", MsgBoxStyle.YesNoCancel, "Delete student") = MsgBoxResult.Yes Then
            Try
                con = New OleDbConnection(provider)
                con.Open()
                str = "delete from students where Id = " & student_id & ""
                cmd = New OleDbCommand(str, con)
                cmd.ExecuteNonQuery()
                MsgBox("Student Deleted")
                Me.Hide()
                list_students.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub
End Class