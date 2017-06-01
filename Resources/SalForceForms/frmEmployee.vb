Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.Strings

Public Class frmEmployee

    '-------------this piece of code is to resize combo boxes height!-----------
    Private Const CB_SETITEMHEIGHT As Int32 = &H153

    Private Declare Auto Function SendMessage Lib "user32.dll" (
ByVal hwnd As IntPtr,
ByVal wMsg As Int32,
ByVal wParam As Int32,
ByVal lParam As Int32
) As Int32

    '-------------this piece of code is to resize combo boxes height!-----------
    Private Sub SetComboEditHeight(
ByVal Control As ComboBox,
ByVal NewHeight As Int32
)
        SendMessage(Control.Handle, CB_SETITEMHEIGHT, -1, NewHeight)
        Control.Refresh()
    End Sub

    Private Function ResetControls()
        Dim cControl As Control
        For Each cControl In Me.TAB01.Controls
            If (TypeOf cControl Is TextBox) Or (TypeOf cControl Is MaskedTextBox) Then
                cControl.Text = ""
            End If
        Next cControl
        Me.Refresh()
        Return (0)
    End Function

    Private Sub frmEmployeeProfileBackup_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim SalforceConnectionstring As String

        SalforceConnectionstring = My.Settings("NewSalForceConnection")
        Using connection As New SqlConnection(SalforceConnectionstring)
            If connection.State = ConnectionState.Open Then
                connection.Close()
                connection.Dispose()
            End If
        End Using
    End Sub

    Private Sub frmEmployeeProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Select Case My.Settings.SalforceLanguage.ToString
            Case "English"
                Me.TabControl.TabPages(0).Text = "Employee"
                Me.TabControl.TabPages(1).Text = "Spouse & Kids"
                Me.TabControl.TabPages(2).Text = "Tax Data"
                Me.TabControl.TabPages(3).Text = "Notes"
                Me.TabControl.TabPages(4).Text = "Savings & Pension"
                Me.TabControl.TabPages(5).Text = "Calculations"
                Me.TabControl.TabPages(6).Text = "Components"
                Me.ToolStripStatusLabel1.Text = "Company"
                Me.ToolStripStatusLabel2.Text = "Island:"
                Me.ToolStripStatus.Text = "Internet:"

            Case "Dutch"
                Me.TabControl.TabPages(0).Text = "Employee"
                Me.TabControl.TabPages(1).Text = "Partner & Kinderen"
                Me.TabControl.TabPages(2).Text = "TBelasting"
                Me.TabControl.TabPages(3).Text = "Notities"
                Me.TabControl.TabPages(4).Text = "Spaar & Pensioen"
                Me.TabControl.TabPages(5).Text = "Calculaties"
                Me.TabControl.TabPages(6).Text = "Componenten"

            Case "Spanish"
                Me.TabControl.TabPages(0).Text = "Empleado"
                Me.TabControl.TabPages(1).Text = "Pareja & Hijos"
                Me.TabControl.TabPages(2).Text = "Impuestos"
                Me.TabControl.TabPages(3).Text = "Anotaciones"
                Me.TabControl.TabPages(4).Text = "Ahorros & Pension"
                Me.TabControl.TabPages(5).Text = "Calculos"
                Me.TabControl.TabPages(6).Text = "Componentes"

        End Select

        LoadCompanyCombo()                                           'MODULE FORMCONTROLS    -   Load Company names in the combobox
        AdjustComboHeights("frmEmployeeProfile")         'MODULE FORMCONTROLS    -   Adjust the heights of the comboboxes on this form
        SetInitialButtonStates("frmEmployeeProfile")        'MODULE FORMCONTROLS    -   Set buttons active or non active at start
        SkinForm()

    End Sub

    Private Sub txtEmployeeMAN_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmployeeMAN.Click
        If txtEmployeeMAN.Checked = True Then
            txtEmployeeVRW.Checked = False
        End If
    End Sub

    Private Sub txtEmployeeVRW_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmployeeVRW.Click
        If txtEmployeeVRW.Checked = True Then
            txtEmployeeMAN.Checked = False
        End If
    End Sub

    Private Sub btnretrieve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetrieve.Click

    End Sub

    Private Sub txtEmployeeCompanyNr_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs)
        If e.KeyCode = Keys.Enter Then
            SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtEmployeeCompanyNr_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If cmbSelectCompany.Text <> 0 Then
        '    btnSave.Enabled = True
        'End If
    End Sub

    Private Sub DataGridView2_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellEndEdit
        Dim SelectedCategory As String
        If e.ColumnIndex = 4 Then
            SelectedCategory = Me.DataGridView2.CurrentRow.Cells("Category").Value
            DataGridView2.CurrentRow.Cells("Ktoeslag").Value = RetrieveKinderToeslagAmount(SelectedCategory)
            Refresh()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Select Case TabControl.SelectedIndex
            Case 0

                UpdateEmployeeGridAftersave()
                DisableEmployeeTab()
            Case 1

                DisablePartnerTab()
            Case 2
                Update_Belasting_Tab()
                DisableBelastingtab()
            Case 4
                UpdateSpaartab()
                DisableSpaarTab()
        End Select

        'DisableVergoedingenTab()
        'DisableNotitiesTab()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim SelectedCompany, SelectedEmployee As Integer
        Dim Employee As New clsEmployee

        SelectedCompany = DataGridMain.SelectedCells.Item(0).Value
        SelectedEmployee = DataGridMain.SelectedCells.Item(1).Value

        If SelectedCompany.ToString = "" Then
            MsgBox(GetMessageString(1004, "Eng"), vbExclamation, Application.ProductName)
            Exit Sub
        End If
        If SelectedEmployee.ToString = "" Then
            MsgBox(GetMessageString(1006, "Eng"), vbExclamation, Application.ProductName)
            Exit Sub
        End If
        ' Employee.RemoveFromDatabase(SelectedCompany, SelectedEmployee)
        'If Employee.EmployeeRemovedWithSuccess = True Then
        '    MsgBox("Employee verwijderd met Success!", vbInformation, Application.ProductName)
        'Else
        '    MsgBox("Employee is NIET verwijderd!", vbInformation, Application.ProductName)
        'End If
        For Each row As DataGridViewRow In DataGridMain.SelectedRows
            DataGridMain.Rows.Remove(row)
        Next
    End Sub

    Private Sub DataGridMain_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridMain.CellMouseClick

        Select Case Me.TabControl.SelectedIndex
            Case 0
                Load_Employee_Tab()
            Case 1
                LoadPartnerAndKids()
            Case 2
                LoadEmpBelasting()
            Case 3
                LoadNotities()
            Case 4
                LoadVergoedingenTab()
            Case 5
            Case 6
                LoadComponentsTab()
            Case 7

        End Select

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Call EditButton()
    End Sub

    Private Sub cmbSelectDepartment_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSelectDepartment.SelectedValueChanged

    End Sub

    Private Sub btnNewEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnEdit_Click(sender, e)
        DataGridMain.SelectAll()
    End Sub

    Private Sub txtDateBegin_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDateBegin.Validated
        'Dim StartDate As Date
        'Dim EndDate As Date
        'If txtDateBegin.Text <> "" Then
        '    StartDate = CDate(txtDateBegin.Text)
        'End If

        'If txtDateEnd.Text <> "" Then
        '    EndDate = CDate(txtDateEnd.Text)
        'End If
        'Dim differenceInDays As Long = DateDiff(DateInterval.Day, EndDate, StartDate)
        'Dim spanFromDays As TimeSpan = New TimeSpan(CInt(differenceInDays), 0, 0, 0)
        'MsgBox(differenceInDays)
    End Sub

    Private Sub StripItemPrinten_Click(ByVal sender As Object, ByVal e As EventArgs)
        Throw New NotImplementedException
    End Sub

    Private Sub Kindtoevoegen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAddchild.Show()
    End Sub

    Private Sub TXTSALARY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTSALARY.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Dim Emp As New clsEmployee
            e.Handled = True

            If Convert.ToDouble(TXTSALARY.Text) < 0 Then
                MessageBox.Show(GetMessageString(1008, "Eng"), "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TXTSALARY.Text = 0
                TXTSALARY.Focus()
                Exit Sub
            End If

            TXTSALARY.Text = Decimal.Parse(TXTSALARY.Text).ToString("N")
            Me.Refresh()
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TXTSALARY_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXTSALARY.Validated
        If Convert.ToDouble(TXTSALARY.Text) < 0 Then
            MessageBox.Show(GetMessageString(1008, "Eng"), "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXTSALARY.Text = 0
            TXTSALARY.Focus()
            Exit Sub
        End If

        TXTSALARY.Text = Decimal.Parse(TXTSALARY.Text).ToString("N")
        Me.Refresh()
    End Sub

    Private Sub TXTSALARY_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TXTSALARY.Validating
        Dim currency As Decimal

        'Convert the current value to currency, with or without a currency symbol.
        If Not Decimal.TryParse(Me.TXTSALARY.Text, Globalization.NumberStyles.Number, Nothing, currency) Then
            'Don't let the user leave the field if the value is invalid.
            With TXTSALARY
                .HideSelection = False
                .SelectAll()
                '  .Text = "0.00"
                MessageBox.Show(GetMessageString(1010, "Eng"), "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)

                .HideSelection = True
            End With

            e.Cancel = True
        End If
    End Sub

    Private Sub txtBeschInsp_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBesInsp.Validated
        ' txtBesInsp.Text = Decimal.Parse(Me.txtBesInsp.Text).ToString("N")

    End Sub

    Private Sub txtBesInsp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtBesInsp.Validating
        Dim currency As Decimal

        'Convert the current value to currency, with or without a currency symbol.
        If Not Decimal.TryParse(Me.txtBesInsp.Text,
                                Globalization.NumberStyles.Number,
                                Nothing,
                                currency) Then
            'Don't let the user leave the field if the value is invalid.
            With txtBesInsp
                .HideSelection = False
                .SelectAll()
                .Text = "0.00"
                MessageBox.Show(GetMessageString(1010, "Eng"), "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)

                .HideSelection = True
            End With

            e.Cancel = True
        End If
    End Sub

    Private Sub txtOuderenToeslag_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOuderenToeslag.Validated
        txtOuderenToeslag.Text = Decimal.Parse(txtOuderenToeslag.Text).ToString("N")
    End Sub

    Private Sub txtOuderenToeslag_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtOuderenToeslag.Validating
        Dim currency As Decimal

        'Convert the current value to currency, with or without a currency symbol.
        If Not Decimal.TryParse(txtOuderenToeslag.Text,
                                Globalization.NumberStyles.Number,
                                Nothing,
                                currency) Then
            'Don't let the user leave the field if the value is invalid.
            With txtOuderenToeslag
                .HideSelection = False
                .SelectAll()
                .Text = "0.00"
                MessageBox.Show(GetMessageString(1010, "Eng"), "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)

                .HideSelection = True
            End With

            e.Cancel = True
        End If
    End Sub

    Private Sub txtKindToeslag_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtKindToeslag.KeyPress
        Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
    End Sub

    Private Sub txtKindToeslag_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKindToeslag.Validated
        'Display the value as local currency.
        txtKindToeslag.Text = Decimal.Parse(txtKindToeslag.Text).ToString("N")
    End Sub

    Private Sub txtKindToeslag_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtKindToeslag.Validating
        Dim currency As Decimal

        'Convert the current value to currency, with or without a currency symbol.
        If Not Decimal.TryParse(txtKindToeslag.Text,
                                Globalization.NumberStyles.Number,
                                Nothing,
                                currency) Then
            'Don't let the user leave the field if the value is invalid.
            With txtKindToeslag
                .HideSelection = False
                .SelectAll()
                .Text = "0.00"
                MessageBox.Show(GetMessageString(1010, "Eng"), "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)

                .HideSelection = True
            End With

            e.Cancel = True
        End If
    End Sub

    Private Sub txtAlleenVerdienerT_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlleenVerdienerT.Validated
        txtAlleenVerdienerT.Text = Decimal.Parse(txtAlleenVerdienerT.Text).ToString("N")
    End Sub

    Private Sub txtAlleenVerdienerT_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAlleenVerdienerT.Validating
        Dim currency As Decimal

        'Convert the current value to currency, with or without a currency symbol.
        If Not Decimal.TryParse(txtAlleenVerdienerT.Text,
                                Globalization.NumberStyles.Number,
                                Nothing,
                                currency) Then
            'Don't let the user leave the field if the value is invalid.
            With txtAlleenVerdienerT
                .HideSelection = False
                .SelectAll()
                .Text = "0.00"
                MessageBox.Show(GetMessageString(1010, "Eng"), "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)

                .HideSelection = True
            End With

            e.Cancel = True
        End If
    End Sub

    Private Sub txtCatWaarde_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAutoZaak.Validated
        'Display the value as local currency.
        txtTotalIncome.Text = CalculateTotalIncome()
        txtAutoZaak.Text = Decimal.Parse(txtAutoZaak.Text).ToString("N")
        Me.Refresh()
        ' Call LoadBerekeningTab()
    End Sub

    Private Sub txtCatWaarde_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAutoZaak.Validating
        Dim currency As Decimal

        'Convert the current value to currency, with or without a currency symbol.
        If Not Decimal.TryParse(txtAutoZaak.Text,
                                Globalization.NumberStyles.Number,
                                Nothing,
                                currency) Then
            'Don't let the user leave the field if the value is invalid.
            With txtAutoZaak
                .HideSelection = False
                .SelectAll()
                .Text = "0.00"
                MessageBox.Show(GetMessageString(1010, "Eng"), "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
                .HideSelection = True
            End With

            e.Cancel = True
        End If
    End Sub

    Private Sub txtAnderloon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnderloon.KeyPress
        If Asc(e.KeyChar) = 13 Then

            If Convert.ToDouble(txtAnderloon.Text) < 0 Then
                MessageBox.Show(GetMessageString(1010, "Eng"), "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAnderloon.Text = 0
                txtAnderloon.Focus()
                Exit Sub
            End If

            txtAnderloon.Text = Decimal.Parse(txtAnderloon.Text).ToString("N")
            Me.Refresh()
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtAnderloon_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAnderloon.Validated
        txtTotalIncome.Text = CalculateTotalIncome()
        'Display the value as local currency.
        txtAnderloon.Text = Decimal.Parse(txtAnderloon.Text).ToString("N")
        Me.Refresh()
        ' Call LoadBerekeningTab()
    End Sub

    Private Sub txtAnderloon_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAnderloon.Validating
        Dim currency As Decimal

        'Convert the current value to currency, with or without a currency symbol.
        If Not Decimal.TryParse(txtAnderloon.Text,
                                Globalization.NumberStyles.Number,
                                Nothing,
                                currency) Then
            'Don't let the user leave the field if the value is invalid.
            With txtAnderloon
                .HideSelection = False
                .SelectAll()
                .Text = "0.00"
                MessageBox.Show(GetMessageString(1010, "Eng"), "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)

                .HideSelection = True
            End With

            e.Cancel = True
        End If
    End Sub

    Private Sub txtPensioenfonds_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPensioenfonds.KeyPress

        If Asc(e.KeyChar) = 13 Then

            e.Handled = True

            If Convert.ToDouble(txtPensioenfonds.Text) < 0 Then
                MsgBox("Pensioenbedrag moet groter of gelijk zijn dan 0 !", vbOK, "SALFORCE")
                txtPensioenfonds.Text = 0
                txtPensioenfonds.Focus()
                Exit Sub
            End If

            Me.Refresh()

            txtPensioenfonds.Text = Decimal.Parse(txtPensioenfonds.Text).ToString("N")
            Me.Refresh()
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtPensioenfonds_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPensioenfonds.Validated
        txtPensioenfonds.Text = Decimal.Parse(txtPensioenfonds.Text).ToString("N")
        Me.Refresh()
    End Sub

    Private Sub txtPensioenFonds_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPensioenfonds.Validating
        Dim currency As Decimal

        'Convert the current value to currency, with or without a currency symbol.
        If Not Decimal.TryParse(Me.txtPensioenfonds.Text,
                                Globalization.NumberStyles.Number,
                                Nothing,
                                currency) Then
            'Don't let the user leave the field if the value is invalid.
            With txtPensioenfonds
                .HideSelection = False
                .SelectAll()
                .Text = "0.00"
                MessageBox.Show(GetMessageString(1010, "Eng"), "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)

                .HideSelection = True
            End With

            e.Cancel = True
        End If
    End Sub

    Private Sub CalendarPickerBirthdate_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CalendarPickerBirthdate.KeyPress

        If Asc(e.KeyChar) = 13 Then

            e.Handled = True
            Me.txtBirthdate.Text = Strings.Left(Me.CalendarPickerBirthdate.Text, 4) & Mid(Me.CalendarPickerBirthdate.Text, 4, 2) & Strings.Left(Me.CalendarPickerBirthdate.Text, 2)
            Refresh()
        End If
    End Sub

    Private Sub txtemployeeBirthDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalendarPickerBirthdate.ValueChanged
        Me.txtBirthdate.Text = Strings.Right(Me.CalendarPickerBirthdate.Text, 4) & Strings.Mid(Me.CalendarPickerBirthdate.Text, 4, 2) & Strings.Left(Me.CalendarPickerBirthdate.Text, 2)
        Me.CalendarPickerBirthdate.Visible = False
        Me.txtBirthdate.Visible = True
    End Sub

    Private Sub cmbPeriod_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPeriod.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub cmbPeriod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPeriod.SelectedIndexChanged
        txtPeriode.Text = cmbPeriod.SelectedIndex.ToString
    End Sub

    Private Sub DGVergoedingen_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVergoedingen.CellValidated

        '  If e.ColumnIndex = 2 Then
        'DGVergoedingen.Rows(7).Cells("Bedrag").Value = CalculateOnkostenVergoeding(2)
        ' End If
    End Sub

    Private Sub txtPartnerBelInkomen_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPartnerBelInkomen.KeyPress
        Dim Number As Double
        If Asc(e.KeyChar) = 13 Then
            If Double.TryParse(txtPartnerBelInkomen.Text, Number) = True Then
                txtPartnerBelInkomen.Text = Format(Convert.ToDouble(txtPartnerBelInkomen.Text), "N")
                Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            Else
                txtPartnerBelInkomen.Text = Format(0, "N")
            End If
        End If
    End Sub

    Private Sub cmbvaluta_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbvaluta.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub cmbvaluta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbvaluta.SelectedIndexChanged
        txtValuta.Text = cmbvaluta.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(DGVergoedingen.Rows(0).Cells("Code").Value & vbCrLf &
               DGVergoedingen.Rows(0).Cells("Omschrijving").Value & vbCrLf &
               DGVergoedingen.Rows(0).Cells("Bedrag").Value, vbOK, "SALFORCE")
    End Sub

    Private Sub DGVergoedingenB_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVergoedingenB.CellValidated
        '  If e.ColumnIndex = 2 Then
        'DGVergoedingenB.Rows(7).Cells("Bedrag").Value = CalculateOnkostenVergoeding(1)
        'Me.txtOnkostenVergoeding.Text = CalculateOnkostenVergoeding(1)
        '  End If

    End Sub

    Private Sub txtBelVergoeding_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOnkostenVergoeding.Validated
        Me.txtOnkostenVergoeding.Text = Decimal.Parse(Me.txtOnkostenVergoeding.Text).ToString("N")

    End Sub

    Private Sub txtBelVergoeding_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtOnkostenVergoeding.Validating
        Dim currency As Decimal

        'Convert the current value to currency, with or without a currency symbol.
        If Not Decimal.TryParse(Me.txtOnkostenVergoeding.Text,
                                Globalization.NumberStyles.Number,
                                Nothing,
                                currency) Then
            'Don't let the user leave the field if the value is invalid.
            With Me.txtOnkostenVergoeding
                .HideSelection = False
                .SelectAll()
                .Text = "0.00"
                MessageBox.Show(GetMessageString(1008, "Eng"), "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)

                .HideSelection = True
            End With
        Else
            Me.txtOnkostenVergoeding.Text = Decimal.Parse(Me.txtOnkostenVergoeding.Text).ToString("N")

        End If
        e.Cancel = True
    End Sub

    Private Sub txtVastBedragSpF_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
        If Convert.ToDouble(txtVastBedragSpF.Text) < 0 Then
            MessageBox.Show(GetMessageString(1008, "Eng"), "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtVastBedragSpF.Text = 0
            txtVastBedragSpF.Focus()
            Exit Sub
        End If

        txtVastBedragSpF.Text = Decimal.Parse(txtVastBedragSpF.Text).ToString("N")
        Me.Refresh()
    End Sub

    Private Sub txtVastBedragSpF_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Dim currency As Decimal

        'Convert the current value to currency, with or without a currency symbol.
        If Not Decimal.TryParse(Me.txtVastBedragSpF.Text,
                                Globalization.NumberStyles.Number,
                                Nothing,
                                currency) Then
            'Don't let the user leave the field if the value is invalid.
            With txtVastBedragSpF
                .HideSelection = False
                .SelectAll()
                '  .Text = "0.00"
                MessageBox.Show(GetMessageString(1010, "Eng"), "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)

                .HideSelection = True
            End With

            e.Cancel = True
        End If
    End Sub

    Private Sub CheckBoxPensioen_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBoxPensioen.CheckedChanged
        'With Me
        '    '  MsgBox(.CheckBoxPensioen.CheckState)

        '    If .btnEdit.Enabled = True Then
        '        If .CheckBoxPensioen.CheckState = CheckState.Checked Then
        '            .txtPensWGPerc.Text = "0.0"
        '            .txtPensWNPerc.Text = "0.0"
        '            .txtVastBedragPF.Enabled = True
        '        Else
        '            .txtVastBedragPF.Text = "0.00"
        '            .txtVastBedragPF.Enabled = False
        '        End If
        '    End If
        'End With
    End Sub

    Private Sub txtVastBedragPF_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Dim currency As Decimal

        'Convert the current value to currency, with or without a currency symbol.
        If Not Decimal.TryParse(Me.txtVastBedragPF.Text,
                                Globalization.NumberStyles.Number,
                                Nothing,
                                currency) Then
            'Don't let the user leave the field if the value is invalid.
            With txtVastBedragPF
                .HideSelection = False
                .SelectAll()
                '  .Text = "0.00"
                MessageBox.Show(GetMessageString(1010, "Eng"), "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)

                .HideSelection = True
            End With

            e.Cancel = True
        End If
    End Sub

    Private Sub txtEmployeePicture_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtEmployeePicture.MaskInputRejected

    End Sub

    Private Sub CheckBoxSpaarfonds_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBoxSpaarfonds.CheckStateChanged
        'With Me
        '    If .txtSpaarFondsNaam.Text = "" Or IsDBNull(.txtSpaarFondsNaam) Then
        '        Exit Sub
        '    End If

        '    If .btnEdit.Enabled = True Then
        '        If CheckBoxSpaarfonds.CheckState = CheckState.Checked Then
        '            .txtSpaarFondsWGPerc.Enabled = False
        '            .txtSpaarFondsWNPerc.Enabled = False
        '            .txtVastBedragSpF.Enabled = True
        '        End If
        '    End If
        'End With
    End Sub

    Private Sub txtZOGPREMIE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtZOGPREMIE.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim Emp As New clsEmployee
            e.Handled = True

            If Convert.ToDouble(txtZOGPREMIE.Text) < 0 Then
                MessageBox.Show(GetMessageString(1008, "Eng"), "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtZOGPREMIE.Text = 0
                txtZOGPREMIE.Focus()
                Exit Sub
            End If

            txtZOGPREMIE.Text = Decimal.Parse(txtZOGPREMIE.Text).ToString("N")
            Me.Refresh()

            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)

        End If
    End Sub

    Private Sub txtZOGPREMIE_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtZOGPREMIE.Validated
        If Convert.ToDouble(txtZOGPREMIE.Text) < 0 Then
            MessageBox.Show(GetMessageString(1008, "Eng"), "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtZOGPREMIE.Text = 0
            txtZOGPREMIE.Focus()
            Exit Sub
        End If

        txtZOGPREMIE.Text = Decimal.Parse(txtZOGPREMIE.Text).ToString("N")
        Me.Refresh()
    End Sub

    Private Sub txtZOGPREMIE_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtZOGPREMIE.Validating
        Dim currency As Decimal

        'Convert the current value to currency, with or without a currency symbol.
        If Not Decimal.TryParse(Me.txtZOGPREMIE.Text,
                                Globalization.NumberStyles.Number,
                                Nothing,
                                currency) Then
            'Don't let the user leave the field if the value is invalid.
            With txtZOGPREMIE
                .HideSelection = False
                .SelectAll()
                '  .Text = "0.00"
                MessageBox.Show(GetMessageString(1010, "Eng"), "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)

                .HideSelection = True
            End With

            e.Cancel = True
        End If
    End Sub

    Private Sub txtBesInsp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBesInsp.KeyPress
        If Asc(e.KeyChar) = 13 Then

            e.Handled = True

            If Convert.ToDouble(txtBesInsp.Text) < 0 Then
                MessageBox.Show(GetMessageString(1008, "Eng"), "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtBesInsp.Text = 0
                txtBesInsp.Focus()
                Exit Sub
            End If

            txtBesInsp.Text = Decimal.Parse(txtBesInsp.Text).ToString("N")
            Me.Refresh()
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtOuderenToeslag_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOuderenToeslag.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim Emp As New clsEmployee
            e.Handled = True

            If Convert.ToDouble(txtOuderenToeslag.Text) < 0 Then
                MessageBox.Show(GetMessageString(1008, "Eng"), "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtOuderenToeslag.Text = 0
                txtOuderenToeslag.Focus()
                Exit Sub
            End If

            txtOuderenToeslag.Text = Decimal.Parse(txtOuderenToeslag.Text).ToString("N")
            Me.Refresh()
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtCatWaarde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAutoZaak.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim Emp As New clsEmployee
            e.Handled = True

            If Convert.ToDouble(txtAutoZaak.Text) < 0 Then
                MessageBox.Show(GetMessageString(1008, "Eng"), "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAutoZaak.Text = 0
                txtAutoZaak.Focus()
                Exit Sub
            End If

            txtAutoZaak.Text = Decimal.Parse(txtAutoZaak.Text).ToString("N")
            Me.Refresh()
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub DataGridView1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DataGridMain.KeyPress
        Select Case Me.TabControl.SelectedIndex

            Case 0
                Load_Employee_Tab()
            Case 1
                LoadPartnerAndKids()
            Case 2
                LoadEmpBelasting()
            Case 3
                LoadVergoedingenTab()
            Case 4
                LoadSpaarTab()
            Case 5
                LoadNotities()
            Case 6
               ' LoadBerekeningTab()
            Case 7
                LoadComponentsTab()
        End Select
        MsgBox(Me.TabControl.SelectedIndex.ToString)
    End Sub

    Private Sub txtAlleenVerdienerT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAlleenVerdienerT.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim Emp As New clsEmployee
            e.Handled = True

            If Convert.ToDouble(txtAlleenVerdienerT.Text) < 0 Then
                MessageBox.Show(GetMessageString(1008, "Eng"), "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAlleenVerdienerT.Text = 0
                txtAlleenVerdienerT.Focus()
                Exit Sub
            End If

            txtAlleenVerdienerT.Text = Decimal.Parse(txtAlleenVerdienerT.Text).ToString("N")
            Me.Refresh()
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtAOVAWW_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAOVAWW_PERC.KeyPress

        If Asc(e.KeyChar) = 13 Then
            'If IsDBNull(txtAOVAWW.ValidateText) Or txtAOVAWW.Text = "" Then
            '    txtAOVAWW.Text = "0.0"
            'End If

            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)

        End If
    End Sub

    Private Sub txtAVBZ_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAVBZ_PERC.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'If IsDBNull(txtAVBZ.ValidateText) Or txtAVBZ.Text = "" Then
            '    txtAOVAWW.Text = "0.0"
            'End If

            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtAVBZ_MaskInputRejected(sender As System.Object, e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtAVBZ_PERC.MaskInputRejected

    End Sub

    Private Sub txtSVB_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtZV_PERC.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'If IsDBNull(txtSVB.ValidateText) Or txtSVB.Text = "" Then
            '    txtBVZ.Text = "0.0"
            'End If

            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtSVB_MaskInputRejected(sender As System.Object, e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtZV_PERC.MaskInputRejected

    End Sub

    Private Sub txtBVZ_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBVZ_PERC.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'If IsDBNull(txtSVB.ValidateText) Or txtSVB.Text = "" Then
            '    txtBVZ.Text = "0.0"
            'End If
            Me.txtBVZ_Amount.Text = Convert.ToDouble(Me.txtBVZ_PERC.Text) * Convert.ToDouble(Me.TXTSALARY.Text) * 0.01
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cmbSelectDepartment_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbSelectDepartment.SelectedIndexChanged
        txtDepartmentNr.Text = cmbSelectDepartment.SelectedIndex.ToString
        cmbSelectDepartment.Text = txtDepartmentNr.Text
        Refresh()
    End Sub

    Private Sub txtPartnerFirstname_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPartnerFirstname.KeyPress
        If Asc(e.KeyChar) = 13 Then

            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)

        End If
    End Sub

    Private Sub txtPartnerLastname_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPartnerLastname.KeyPress
        If Asc(e.KeyChar) = 13 Then

            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)

        End If
    End Sub

    Private Sub txtPartnerLastname_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPartnerLastname.TextChanged

    End Sub

    Private Sub txtPartnerMidname_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPartnerMidname.KeyPress
        If Asc(e.KeyChar) = 13 Then

            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)

        End If
    End Sub

    Private Sub DatePickerPartnerBirthdate_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DatePickerPartnerBirthdate.ValueChanged
        Me.txtPartnerBirthDate.Text = Strings.Right(Me.DatePickerPartnerBirthdate.Text, 4) & Strings.Mid(Me.DatePickerPartnerBirthdate.Text, 4, 2) & Strings.Left(Me.DatePickerPartnerBirthdate.Text, 2)
        Me.DatePickerPartnerBirthdate.Visible = False
        Me.txtPartnerBirthDate.Visible = True
    End Sub

    Private Sub txtPartnerBelInkomen_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPartnerBelInkomen.Validating

    End Sub

    Private Sub txtSpaarFondsWGPerc_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtSpaarFondsWGPerc.KeyPress
        If Asc(e.KeyChar) = 13 Then

            With Me
                If Not .txtBVZ_Amount.Text = "0.0" Then
                    .txtBVZ_Amount.Text = "0.00"
                    .txtBVZ_Amount.Enabled = False
                End If

            End With
        End If
    End Sub

    Private Sub CheckBoxSpaarfonds_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBoxSpaarfonds.CheckedChanged
        'With Me
        '    If CheckBoxSpaarfonds.CheckState = CheckState.Checked Then

        '        .txtSpaarFondsWGPerc.Text = "0.0"
        '        .txtSpaarFondsWNPerc.Text = "0.0"
        '    Else
        '        '.txtSpaarFondsWGPerc.Enabled = True
        '        '.txtSpaarFondsWNPerc.Enabled = True
        '        '.txtSpaarFondsWGPerc.Text = "0.0"
        '        '.txtSpaarFondsWNPerc.Text = "0.0"
        '        '.txtVastBedragSpF.Enabled = False

        '    End If
        '    Me.Refresh()
        'End With
    End Sub

    Private Sub txtSpaarFondsWNPerc_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtSpaarFondsWNPerc.KeyPress
        If Asc(e.KeyChar) = 13 Then

            With Me
                If Convert.ToDouble(.txtBVZ_Amount.Text) = 0 Then
                    .txtBVZ_Amount.Text = "0.00"
                    .txtBVZ_Amount.Enabled = False
                End If

            End With
        End If
    End Sub

    Private Sub txtPensWNPerc_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPensWNPerc.KeyPress
        If Asc(e.KeyChar) = 13 Then

            With Me
                If Convert.ToDouble(.txtBVZ_Amount.Text) = 0 Then
                    .txtPensWNPerc.Text = "0.0"

                End If

            End With
        End If
    End Sub

    Private Sub txtPensWNPerc_MaskInputRejected(sender As System.Object, e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtPensWNPerc.MaskInputRejected

    End Sub

    Private Sub txtZOG_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtZOG_PERC.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtVastBedragPF_Validated(sender As Object, e As System.EventArgs)
        'If Convert.ToDouble(txtVastBedragPF.Text) < 0 Then
        '    MsgBox("Salaris moet groter of gelijk zijn dan 0 !", vbOK, "SALFORCE")
        '    txtVastBedragPF.Text = 0
        '    txtVastBedragPF.Focus()
        'End If

    End Sub

    Private Sub txtVastBedragSpF_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtVastBedragSpF.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Try

                txtVastBedragSpF.Text = FormatNumber(txtVastBedragSpF.Text, 2, , , TriState.True)
                Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            Catch ex As Exception

                txtVastBedragSpF.Clear()
                txtVastBedragSpF.Focus()
                txtVastBedragSpF.Text = "0.00"
            End Try
        End If

    End Sub

    Private Sub txtVastBedragPF_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtVastBedragPF.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Try

                txtVastBedragPF.Text = FormatNumber(txtVastBedragPF.Text, 2, , , TriState.True)
                Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
                CheckBoxPensioen.Checked = False
            Catch ex As Exception

                txtVastBedragPF.Clear()
                txtVastBedragPF.Focus()
                txtVastBedragPF.Text = "0.00"
            End Try
        End If

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs)
        Process.Start("C:\SalForce\SalforceBel\SalforceBel\bin\Debug\SalforceBel.exe")
    End Sub

    Private Sub txtPartnerFirstname_MouseClick(sender As Object, e As MouseEventArgs) Handles txtPartnerFirstname.MouseClick

    End Sub

    Private Sub cmbCompanySelection_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmbCompanySelection.DropDownItemClicked
        LoadEmployeeDataGrid(Strings.Left(e.ClickedItem.Text, 4))

    End Sub

    Private Sub DataGridMain_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridMain.CellContentClick

    End Sub

    Private Sub txtEmpNotities_TextChanged(sender As Object, e As EventArgs) Handles txtEmpNotities.TextChanged

    End Sub

    Private Sub txtEmpNotities_TabIndexChanged(sender As Object, e As EventArgs) Handles txtEmpNotities.TabIndexChanged

    End Sub

    Private Sub TabControl_MouseClick(sender As Object, e As MouseEventArgs) Handles TabControl.MouseClick

        Select Case TabControl.SelectedIndex
            Case 0
                SetLanguage("English", 0)
            Case 1
                SetLanguage("English", 1)
            Case 2
                SetLanguage("English", 2)
            Case 3
                SetLanguage("English", 3)
            Case 4
                SetLanguage("English", 4)
            Case 5
                SetLanguage("English", 5)
            Case 6
        End Select

    End Sub

    Private Sub TAB04_Click(sender As Object, e As EventArgs) Handles TAB04.Click

    End Sub

    Private Sub pctLogo_Click(sender As Object, e As EventArgs) Handles pctLogo.Click

    End Sub

    Private Sub DataGridMain_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridMain.CellMouseDoubleClick

    End Sub

    Private Sub ToolStripProgressBar1_Click(sender As Object, e As EventArgs) Handles ToolStripProgressBar1.Click

    End Sub

End Class