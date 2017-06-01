Public Class frmAddchild

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox.Enter

    End Sub

    Private Sub frmAddchild_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Skin(Me)
        Skin(lblName)
        Skin(lblLastname)
        Skin(lblBirthdate)
        Skin(lblCategory)
        Skin(lblSchool)

        Me.CalendarChildBirthDate.CustomFormat = "dd-MM-yyyy"
        Me.CalendarChildBirthDate.Text = ""
        Me.Text = "Toevoegen Kind"
        Me.CalendarChildBirthDate.MaxDate = Today
        Dim companyNr As Integer = CInt(frmEmployee.txtCompanyNr.Text)
        Dim empNr As Integer = CInt(frmEmployee.txtEmployeeNr.Text)

        Me.txtparentNr.Text = GetEmployeeRecordNr(companyNr, empNr)
        GroupBox.Text = "Kind Toevoegen"
        Me.Refresh()
    End Sub

    Private Sub txtName_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.Enter

    End Sub

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress

    End Sub

    Private Sub txtName_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtName.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            ActiveControl.Text = UCase(Me.ActiveControl.Text)
            SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub txtLastName_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtLastName.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            ActiveControl.Text = UCase(Me.ActiveControl.Text)
            SelectNextControl(Me.ActiveControl, True, True, True, True)

        End If
    End Sub

    Private Sub txtSchoolname_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtSchoolname.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            ActiveControl.Text = UCase(Me.ActiveControl.Text)
            SelectNextControl(Me.ActiveControl, True, True, True, True)

        End If
    End Sub

End Class