<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddchild
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
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.txtparentNr = New System.Windows.Forms.TextBox()
        Me.CalendarChildBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.lblSchool = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblBirthdate = New System.Windows.Forms.Label()
        Me.lblLastname = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnSaveChild = New System.Windows.Forms.Button()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.txtSchoolname = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox
        '
        Me.GroupBox.BackColor = System.Drawing.Color.Tan
        Me.GroupBox.Controls.Add(Me.txtparentNr)
        Me.GroupBox.Controls.Add(Me.CalendarChildBirthDate)
        Me.GroupBox.Controls.Add(Me.lblSchool)
        Me.GroupBox.Controls.Add(Me.lblCategory)
        Me.GroupBox.Controls.Add(Me.lblBirthdate)
        Me.GroupBox.Controls.Add(Me.lblLastname)
        Me.GroupBox.Controls.Add(Me.lblName)
        Me.GroupBox.Controls.Add(Me.btnSaveChild)
        Me.GroupBox.Controls.Add(Me.cmbCategory)
        Me.GroupBox.Controls.Add(Me.txtSchoolname)
        Me.GroupBox.Controls.Add(Me.txtLastName)
        Me.GroupBox.Controls.Add(Me.txtName)
        Me.GroupBox.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(432, 214)
        Me.GroupBox.TabIndex = 0
        Me.GroupBox.TabStop = False
        '
        'txtparentNr
        '
        Me.txtparentNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtparentNr.Location = New System.Drawing.Point(331, 19)
        Me.txtparentNr.Name = "txtparentNr"
        Me.txtparentNr.Size = New System.Drawing.Size(74, 20)
        Me.txtparentNr.TabIndex = 12
        Me.txtparentNr.TabStop = False
        Me.txtparentNr.Visible = False
        '
        'CalendarChildBirthDate
        '
        Me.CalendarChildBirthDate.CalendarMonthBackground = System.Drawing.Color.RosyBrown
        Me.CalendarChildBirthDate.CustomFormat = "dd-MM-yyyy"
        Me.CalendarChildBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CalendarChildBirthDate.Location = New System.Drawing.Point(152, 99)
        Me.CalendarChildBirthDate.MaxDate = New Date(2011, 12, 4, 0, 0, 0, 0)
        Me.CalendarChildBirthDate.MinDate = New Date(1940, 1, 1, 0, 0, 0, 0)
        Me.CalendarChildBirthDate.Name = "CalendarChildBirthDate"
        Me.CalendarChildBirthDate.Size = New System.Drawing.Size(94, 20)
        Me.CalendarChildBirthDate.TabIndex = 11
        Me.CalendarChildBirthDate.Value = New Date(2011, 8, 18, 0, 0, 0, 0)
        '
        'lblSchool
        '
        Me.lblSchool.AutoSize = True
        Me.lblSchool.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchool.Location = New System.Drawing.Point(21, 127)
        Me.lblSchool.Name = "lblSchool"
        Me.lblSchool.Size = New System.Drawing.Size(46, 13)
        Me.lblSchool.TabIndex = 9
        Me.lblSchool.Text = "School"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(21, 154)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(57, 13)
        Me.lblCategory.TabIndex = 10
        Me.lblCategory.Text = "Category"
        '
        'lblBirthdate
        '
        Me.lblBirthdate.AutoSize = True
        Me.lblBirthdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthdate.Location = New System.Drawing.Point(21, 103)
        Me.lblBirthdate.Name = "lblBirthdate"
        Me.lblBirthdate.Size = New System.Drawing.Size(70, 13)
        Me.lblBirthdate.TabIndex = 8
        Me.lblBirthdate.Text = "Geb.Datum"
        '
        'lblLastname
        '
        Me.lblLastname.AutoSize = True
        Me.lblLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastname.Location = New System.Drawing.Point(21, 73)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(74, 13)
        Me.lblLastname.TabIndex = 7
        Me.lblLastname.Text = "Achternaam"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(21, 45)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(39, 13)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Naam"
        '
        'btnSaveChild
        '
        Me.btnSaveChild.Location = New System.Drawing.Point(289, 179)
        Me.btnSaveChild.Name = "btnSaveChild"
        Me.btnSaveChild.Size = New System.Drawing.Size(116, 25)
        Me.btnSaveChild.TabIndex = 5
        Me.btnSaveChild.Text = "Opslaan"
        Me.btnSaveChild.UseVisualStyleBackColor = True
        '
        'cmbCategory
        '
        Me.cmbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"CAT-1", "CAT-2", "CAT-3", "CAT-4"})
        Me.cmbCategory.Location = New System.Drawing.Point(152, 151)
        Me.cmbCategory.MaxDropDownItems = 4
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(253, 21)
        Me.cmbCategory.TabIndex = 4
        Me.cmbCategory.Text = "CAT-1"
        '
        'txtSchoolname
        '
        Me.txtSchoolname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSchoolname.Location = New System.Drawing.Point(152, 125)
        Me.txtSchoolname.Name = "txtSchoolname"
        Me.txtSchoolname.Size = New System.Drawing.Size(253, 20)
        Me.txtSchoolname.TabIndex = 3
        '
        'txtLastName
        '
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Location = New System.Drawing.Point(152, 73)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(253, 20)
        Me.txtLastName.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(152, 45)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(254, 20)
        Me.txtName.TabIndex = 0
        '
        'frmAddchild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Sienna
        Me.ClientSize = New System.Drawing.Size(440, 225)
        Me.Controls.Add(Me.GroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "frmAddchild"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Children"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveChild As System.Windows.Forms.Button
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents txtSchoolname As System.Windows.Forms.TextBox
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents lblSchool As System.Windows.Forms.Label
    Friend WithEvents lblBirthdate As System.Windows.Forms.Label
    Friend WithEvents lblLastname As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents CalendarChildBirthDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtparentNr As System.Windows.Forms.TextBox
End Class