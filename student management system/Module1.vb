Imports System.Data.OleDb
Module Module1
    Public con As OleDbConnection
    Public path As String = String.Format("Data Source =C:\db\student_db.mdb")
    Public provider As String = "Provider=Microsoft.Jet.OLEDB.4.0;" + path
    Public student_id As Integer
End Module
