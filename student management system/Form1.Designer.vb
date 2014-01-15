<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeeDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterFeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewFeesDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndividualStudentReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentToolStripMenuItem, Me.AttendanceToolStripMenuItem, Me.FeeDetailsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(916, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewStudentToolStripMenuItem, Me.ListStudentsToolStripMenuItem, Me.EditStudentToolStripMenuItem, Me.IndividualStudentReportToolStripMenuItem})
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.StudentToolStripMenuItem.Text = "Student"
        '
        'NewStudentToolStripMenuItem
        '
        Me.NewStudentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NewStudentToolStripMenuItem.Name = "NewStudentToolStripMenuItem"
        Me.NewStudentToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.NewStudentToolStripMenuItem.Text = "New student"
        '
        'ListStudentsToolStripMenuItem
        '
        Me.ListStudentsToolStripMenuItem.Name = "ListStudentsToolStripMenuItem"
        Me.ListStudentsToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ListStudentsToolStripMenuItem.Text = "List Students"
        '
        'EditStudentToolStripMenuItem
        '
        Me.EditStudentToolStripMenuItem.Name = "EditStudentToolStripMenuItem"
        Me.EditStudentToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.EditStudentToolStripMenuItem.Text = "Edit students"
        '
        'AttendanceToolStripMenuItem
        '
        Me.AttendanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterAttendanceToolStripMenuItem, Me.ViewAttendanceToolStripMenuItem})
        Me.AttendanceToolStripMenuItem.Name = "AttendanceToolStripMenuItem"
        Me.AttendanceToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.AttendanceToolStripMenuItem.Text = "Attendance"
        '
        'EnterAttendanceToolStripMenuItem
        '
        Me.EnterAttendanceToolStripMenuItem.Name = "EnterAttendanceToolStripMenuItem"
        Me.EnterAttendanceToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.EnterAttendanceToolStripMenuItem.Text = "Enter Attendance"
        '
        'ViewAttendanceToolStripMenuItem
        '
        Me.ViewAttendanceToolStripMenuItem.Name = "ViewAttendanceToolStripMenuItem"
        Me.ViewAttendanceToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ViewAttendanceToolStripMenuItem.Text = "View Attendance"
        '
        'FeeDetailsToolStripMenuItem
        '
        Me.FeeDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterFeesToolStripMenuItem, Me.ViewFeesDetailsToolStripMenuItem})
        Me.FeeDetailsToolStripMenuItem.Name = "FeeDetailsToolStripMenuItem"
        Me.FeeDetailsToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.FeeDetailsToolStripMenuItem.Text = "Fee details"
        '
        'EnterFeesToolStripMenuItem
        '
        Me.EnterFeesToolStripMenuItem.Name = "EnterFeesToolStripMenuItem"
        Me.EnterFeesToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.EnterFeesToolStripMenuItem.Text = "Enter Fees"
        '
        'ViewFeesDetailsToolStripMenuItem
        '
        Me.ViewFeesDetailsToolStripMenuItem.Name = "ViewFeesDetailsToolStripMenuItem"
        Me.ViewFeesDetailsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ViewFeesDetailsToolStripMenuItem.Text = "View Fees details"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'IndividualStudentReportToolStripMenuItem
        '
        Me.IndividualStudentReportToolStripMenuItem.Name = "IndividualStudentReportToolStripMenuItem"
        Me.IndividualStudentReportToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.IndividualStudentReportToolStripMenuItem.Text = "Individual student Report"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(916, 328)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student management system"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnterAttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListStudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeeDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnterFeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewFeesDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndividualStudentReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
