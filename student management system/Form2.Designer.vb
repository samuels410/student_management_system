<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.student_dbDataSet2 = New student_management_system.student_dbDataSet2()
        Me.studentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.studentsTableAdapter = New student_management_system.student_dbDataSet2TableAdapters.studentsTableAdapter()
        CType(Me.student_dbDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.studentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoSize = True
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.studentsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "student_management_system.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1358, 597)
        Me.ReportViewer1.TabIndex = 0
        '
        'student_dbDataSet2
        '
        Me.student_dbDataSet2.DataSetName = "student_dbDataSet2"
        Me.student_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'studentsBindingSource
        '
        Me.studentsBindingSource.DataMember = "students"
        Me.studentsBindingSource.DataSource = Me.student_dbDataSet2
        '
        'studentsTableAdapter
        '
        Me.studentsTableAdapter.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.student_dbDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.studentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents studentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents student_dbDataSet2 As student_management_system.student_dbDataSet2
    Friend WithEvents studentsTableAdapter As student_management_system.student_dbDataSet2TableAdapters.studentsTableAdapter
End Class
