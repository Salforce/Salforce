Imports System.Data.SqlClient

Module Tabs_Loading

    Function Load_Employee_Tab()

        SetLanguage(My.Settings.SalforceLanguage.ToString, 0)
        Dim EmployeeData As New clsEmployee

        Dim SelectedCompany, SelectedEmployee As Integer

        'Here we are selecting the Employee of an existing Company to load
        With frmEmployee.DataGridMain.SelectedCells

            SelectedCompany = .Item(0).Value
            SelectedEmployee = .Item(1).Value

            EmployeeData.Retrieve_Employee_Data(SelectedCompany, SelectedEmployee)
            With frmEmployee
                .txtCompanyNr.Text = SelectedCompany
                .cmbSelectCompany.Text = EmployeeData.CompanyNr
                .txtEmployeeNr.Text = EmployeeData.EmployeeNr.ToString
                .txtEmployeeFirstName.Text = EmployeeData.FirstName.ToString
                .txtemployeeLastName.Text = EmployeeData.LastName.ToString
                .txtemployeeAddress.Text = EmployeeData.Address.ToString
                .txtDepartmentNr.Text = EmployeeData.Department.ToString
                .txtDateBegin.Text = EmployeeData.StartDate.ToString
                .txtDateEnd.Text = EmployeeData.EndDate.ToString
                .txtBirthdate.Text = EmployeeData.BirthDate.ToString

                .txtEmployeeCedulaNr.Text = EmployeeData.CedulaNr.ToString
                .txtEmployeeStatus.Text = EmployeeData.Status.ToString
                .txtEmployeeEmail1.Text = EmployeeData.Email1.ToString
                .txtEmployeeEmail2.Text = EmployeeData.Email2.ToString
                .txtEmployeefunction.Text = EmployeeData.Position.ToString
                .txtEmployeeHomePhone.Text = EmployeeData.HomePhone.ToString
                .txtEmployeeMobile.Text = EmployeeData.CellNr.ToString
                '   .cmbIsland.Text = EmployeeData.
                .txtEmployeeMAN.Checked = IIf(EmployeeData.EmployeeSex = "M", 1, 0)
                .txtEmployeeVRW.Checked = IIf(EmployeeData.EmployeeSex = "V", 1, 0)
                .txtEmployeePicture.Text = EmployeeData.Picture.ToString

            End With

        End With

        Return (0)
    End Function

    Function LoadPartnerAndKids()

        DisablePartnerTab()
        Dim EmployeeData As New clsEmployee
        Dim SelectedCompany, SelectedEmployee As Integer

        'Here we are selecting the Employee of an existing Company to load
        With frmEmployee.DataGridMain.SelectedCells

            SelectedCompany = .Item(0).Value
            SelectedEmployee = .Item(1).Value
            '---------------------------------------------------------------------
            EmployeeData.Retrieve_Employee_Data(SelectedCompany, SelectedEmployee)

            With frmEmployee
                .txtPartnerLastname.Clear()
                .txtPartnerFirstname.Clear()
                .txtPartnerMidname.Clear()
                .txtPartnerBirthDate.Clear()
                .txtPartnerBelInkomen.Clear()

                .txtPartnerLastname.Text = UCase(Trim(EmployeeData.PartnerLastName))
                .txtPartnerFirstname.Text = UCase(Trim(EmployeeData.PartnerFirstName))

                .txtPartnerBirthDate.Text = ConvertDateToSalforceDate(EmployeeData.PartnerBirthDate)

                If EmployeeData.PartnerBelInkomen = "" Then
                    .txtPartnerBelInkomen.Text = Format(0, "N")
                Else
                    .txtPartnerBelInkomen.Text = Format(Convert.ToDouble(EmployeeData.PartnerBelInkomen), "N")
                End If

                Dim Child As New clsChildren
                Child.FillChildGrid(SelectedCompany, SelectedEmployee)

            End With

        End With
        CreateChildrenContextMenu()
    End Function

    Function LoadEmpBelasting()

        ' DisableBelastingtab()
        Dim EmployeeData As New clsEmployee
        Dim SelectedCompany, SelectedEmployee As Integer

        'Here we are selecting the Employee of an existing Company to load
        With frmEmployee
            SelectedCompany = .DataGridMain.SelectedCells.Item(0).Value
            SelectedEmployee = .DataGridMain.SelectedCells.Item(1).Value
            '---------------------------------------------------------------------

            With .cmbPeriod
                '--------------------------------------------------------------------------LOAD PERIOD COMBO WITH VALUES --------------------------------------------------
                If .Items.Count = 0 Then
                    .Items.Add("Jaar")
                    .Items.Add("Kwartaal")
                    .Items.Add("Maand")
                    .Items.Add("Week")
                    .Items.Add("Dag")
                    .Items.Add("Halve dag")
                End If
                '--------------------------------------------------------------------------LOAD PERIOD COMBO WITH VALUES --------------------------------------------------
            End With

            '---------------------------------------------------------------LOAD FORM TEXTFIELDS -----------------------------------------------------------------------------------

            '        EmployeeData.Retrieve_Employee_Data(SelectedCompany, SelectedEmployee)

            '        'Select Case EmployeeData.PayPeriod
            '        '    Case 0
            '        '        .txtAOVAWW_PERC.Text = EmployeeData.AOV_Percentage.ToString
            '        '        .txtAOV_AWW.Text = Format(EmployeeData.AOV_Percentage, "N2")

            '        '        .txtBVZ_PERC.Text = EmployeeStructure.BasisVerzekering_Percentage
            '        '        '  .txtBVZ_Amount.Text = Format(EmployeeStructure.BasisVerzekering_Percentage * EmployeeStructure.BasisVerzekering_Amount, "N2")

            '        '        .txtAVBZ_PERC.Text = EmployeeStructure.AVBZ_Percentage
            '        '        .txtAVBZ_AMOUNT.Text = Format(EmployeeStructure.AVBZ_Amount, "N2")
            '        '        .txtZV_PERC.Text = EmployeeStructure.ZV_Percentage
            '        '        .txtZV_Amount.Text = Format(EmployeeStructure.ZV_Amount, "N2")
            '        .cmbPeriod.Text = .cmbPeriod.Items(0).ToString
            '            Case 1
            '                .txtAOVAWW_PERC.Text = EmployeeStructure.AOV_Percentage_Employee
            '                .txtAOV_AWW.Text = Format(EmployeeStructure.AOV_Amount / CONSTANT_QUARTS_IN_YEAR, "N2")

            '                .txtBVZ_PERC.Text = EmployeeStructure.BasisVerzekering_Percentage
            '                .txtBVZ_Amount.Text = Format((EmployeeStructure.BasisVerzekering_Percentage * EmployeeStructure.BasisVerzekering_Amount) / CONSTANT_QUARTS_IN_YEAR, "N2")

            '                .txtAVBZ_PERC.Text = EmployeeStructure.AVBZ_Percentage
            '                .txtAVBZ_AMOUNT.Text = Format(EmployeeStructure.AVBZ_Amount / CONSTANT_QUARTS_IN_YEAR, "N2")

            '                .txtZV_PERC.Text = EmployeeStructure.ZV_Percentage
            '                .txtZV_Amount.Text = Format(EmployeeStructure.ZV_Amount / CONSTANT_QUARTS_IN_YEAR, "N2")
            '                .cmbPeriod.Text = .cmbPeriod.Items(1).ToString
            '            Case 2
            '                .txtAOVAWW_PERC.Text = EmployeeStructure.AOV_Percentage_Employee
            '                .txtAOV_AWW.Text = Format(EmployeeStructure.AOV_Amount / CONSTANT_MONTHS_IN_YEAR, "N2")

            '                .txtBVZ_PERC.Text = EmployeeStructure.BasisVerzekering_Percentage
            '                .txtBVZ_Amount.Text = Format((EmployeeStructure.BasisVerzekering_Percentage * EmployeeStructure.BasisVerzekering_Amount) / CONSTANT_MONTHS_IN_YEAR, "N2")

            '                .txtAVBZ_PERC.Text = EmployeeStructure.AVBZ_Percentage
            '                .txtAVBZ_AMOUNT.Text = Format(EmployeeStructure.AVBZ_Amount / CONSTANT_MONTHS_IN_YEAR, "N2")

            '                .txtZV_PERC.Text = EmployeeStructure.ZV_Percentage
            '                .txtZV_Amount.Text = Format(EmployeeStructure.ZV_Amount / CONSTANT_MONTHS_IN_YEAR, "N2")
            '                .cmbPeriod.Text = .cmbPeriod.Items(2).ToString
            '            Case 3
            '                .txtAOVAWW_PERC.Text = EmployeeStructure.AOV_Percentage_Employee
            '                .txtAOV_AWW.Text = Format(EmployeeStructure.AOV_Amount / CONSTANT_WEEKS_IN_YEAR, "N2")

            '                .txtBVZ_PERC.Text = EmployeeStructure.BasisVerzekering_Percentage
            '                .txtBVZ_Amount.Text = Format((EmployeeStructure.BasisVerzekering_Percentage * EmployeeStructure.BasisVerzekering_Amount) / CONSTANT_WEEKS_IN_YEAR, "N2")

            '                .txtAVBZ_PERC.Text = EmployeeStructure.AVBZ_Percentage
            '                .txtAVBZ_AMOUNT.Text = Format(EmployeeStructure.AVBZ_Amount / CONSTANT_WEEKS_IN_YEAR, "N2")

            '                .txtZV_PERC.Text = EmployeeStructure.ZV_Percentage
            '                .txtZV_Amount.Text = Format(EmployeeStructure.ZV_Amount / CONSTANT_WEEKS_IN_YEAR, "N2")
            '                .cmbPeriod.Text = .cmbPeriod.Items(3).ToString
            '            Case 4
            '                .txtAOVAWW_PERC.Text = EmployeeStructure.AOV_Percentage_Employee
            '                .txtAOV_AWW.Text = Format(EmployeeStructure.AOV_Amount / CONSTANT_DAYS_IN_YEAR, "N2")

            '                .txtBVZ_PERC.Text = EmployeeStructure.BasisVerzekering_Percentage
            '                If EmployeeStructure.Year_Salary < 12000.0 Then
            '                    .txtBVZ_Amount.Text = "0.00"
            '                Else
            '                    .txtBVZ_Amount.Text = Format((EmployeeStructure.BasisVerzekering_Percentage * EmployeeStructure.BasisVerzekering_Amount) / CONSTANT_DAYS_IN_YEAR, "N2")
            '                End If
            '                .txtAVBZ_PERC.Text = EmployeeStructure.AVBZ_Percentage
            '                .txtAVBZ_AMOUNT.Text = Format(EmployeeStructure.AVBZ_Amount / CONSTANT_DAYS_IN_YEAR, "N2")

            '                .txtZV_PERC.Text = EmployeeStructure.ZV_Percentage
            '                .txtZV_Amount.Text = Format(EmployeeStructure.ZV_Amount / CONSTANT_DAYS_IN_YEAR, "N2")
            '        End Select

            '        .txtPeriode.Text = EmployeeStructure.Salary_Pay_Period
            '        .TXTSALARY.Text = Format(EmployeeStructure.Month_Salary, "N2")
            '        .txtLeeftijd1jan.Text = EmployeeStructure.Age_On_First_January
            '        .txtUurloon.Text = Format(EmployeeStructure.Hour_Salary, "N2")

            '        .txtAutoZaak.Text = Format(EmployeeStructure.CarcatologValue, "N2")
            '        .txtAlleenVerdienerT.Text = Format(EmployeeStructure.AlleenVerdienerToeslag, "N2")
            '        .txtBesInsp.Text = Format(EmployeeStructure.Beschikking, "N2")
            '        .txtOuderenToeslag.Text = Format(EmployeeStructure.OuderenToeslag, "N2")

            '        .txtZOG_PERC.Text = EmployeeStructure.ZOG_Percentage
            '        .txtValuta.Text = EmployeeStructure.EmployeeValuta
            '        .cmbvaluta.Text = EmployeeStructure.EmployeeValuta
            '        '.txtAnderloon.Text = EmployeeStructure.Anderloon

            '        .txtUrenPerDag.Text = EmployeeStructure.Employee_Uren_Per_Dag
            '        .txtDagenPerWeek.Text = EmployeeStructure.Employee_Dagen_PerWeek

            '        .txtZOGPREMIE.Text = Format(EmployeeStructure.ZogPremie, "N2")
            '        .txtVerwervingskosten.Text = EmployeeStructure.VerwervingsKosten.ToString
            '        '---------------------------------------------------------------LOAD FORM TEXTFIELDS -----------------------------------------------------------------------------------

        End With

        '    Return (0)
    End Function

    Function LoadSpaarTab()

        Dim EmployeeData As New clsEmployee

        Dim SelectedEmployee As Int32
        Dim SelectedCompany As Int16

        'Here we are selecting the Employee of an existing Company to load

        With frmEmployee.DataGridMain.SelectedCells

            SelectedCompany = .Item(0).Value
            SelectedEmployee = .Item(1).Value

            EmployeeData.Retrieve_Employee_Data(SelectedCompany, SelectedEmployee)

            '.txtSpaarFondsNaam.Text = EmployeeData.SpaarFondsName
            '.txtPensioenfondsNaam.Text = EmployeeStructure.PensioenfondsNaam

            '.txtSpaarFondsWGPerc.Text = EmployeeStructure.SpaarFondsWGPerc
            '.txtSpaarFondsWNPerc.Text = EmployeeStructure.SpaarFondsWNPerc

            '.txtPensWGPerc.Text = EmployeeStructure.PensWGPerc
            '.txtPensWNPerc.Text = EmployeeStructure.PensWNPerc

            '.txtVastBedragPF.Text = EmployeeStructure.VastBedragPF.ToString("N2")
            '.txtVastBedragSpF.Text = EmployeeStructure.VastBedragSpF.ToString("N2")

            'If .txtVastBedragPF.Text = "0.00" Then
            '    .CheckBoxPensioen.Checked = False
            'Else
            '    .CheckBoxPensioen.Checked = True
            'End If
            'If .txtVastBedragSpF.Text = "0.00" Then
            '    .CheckBoxSpaarfonds.Checked = False
            'Else
            '    .CheckBoxSpaarfonds.Checked = True
            'End If

        End With
        Return (0)
    End Function

    Function LoadNotities()
        Dim CURRENTCOMPANY As Integer
        Dim SalForceConnectionString As String
        With frmEmployee
            CURRENTCOMPANY = CType(.txtCompanyNr.Text, Integer)
            If Len(CURRENTCOMPANY) = 0 Then
                Return (0)
                Exit Function
            End If
        End With

        Try
            SalForceConnectionString = My.Settings("NewSalForceConnection")
            Using Connection As New SqlConnection(SalForceConnectionString)
                If Connection.State = ConnectionState.Closed Then
                    Connection.Open()
                End If

                Dim EMP_RetrieveCommand As SqlCommand
                Dim EMP_Retrievereader As SqlDataReader

                'Here we are selecting the Employee of an existing Cmpany to load
                With frmEmployee
                    .txtEmpNotities.Text = ""
                    Dim SelectedCompany As Integer = .DataGridMain.SelectedCells.Item(0).Value.ToString
                    Dim SelectedEmployee As Integer = .DataGridMain.SelectedCells.Item(1).Value

                    'Create the Query to retrieve the Employee from the database
                    Dim EMP_RetrieveString = String.Format("Select * FROM EMPTABLE WHERE EMP_EMPLOYEENR ={0} And EMP_COMPID = {1}", SelectedEmployee, SelectedCompany)

                    EMP_RetrieveCommand = New SqlCommand(EMP_RetrieveString, Connection)

                    EMP_Retrievereader = EMP_RetrieveCommand.ExecuteReader()
                    EMP_Retrievereader.Read()

                    .txtEmpNotities.Text = EMP_Retrievereader("EMP_NOTITIES").ToString
                End With
                EMP_Retrievereader.Close()
                Connection.Dispose()
                Connection.Close()
            End Using
        Catch Ex As Exception
            MsgBox(Ex.Source)
            Return (-1)
        End Try

        Return (0)
    End Function

    Public Function LoadComponentsTab()

        With frmEmployee
            .DGEmpDeductions.Rows.Clear()
            If .DGEmpDeductions.Columns.Count = 0 Then
                With frmEmployee
                    With .DGEmpDeductions
                        Select Case My.Settings.SalforceLanguage
                            Case "Dutch"
                                .Columns.Add("Col0", "Jaar")
                                .Columns.Add("Periode", "Col1")
                                .Columns.Add("SEQ", "Col2")
                                .Columns.Add("LC_Nr", "Col3")
                                .Columns.Add("OMS", "Col4")
                                .Columns.Add("P/B", "Col5")
                                .Columns.Add("Aantal", "Col6")
                                .Columns.Add("D/C", "Col7")
                                .Columns.Add("Bedrag", "Col8")
                                .Columns.Add("YTD", "Col9")
                                .Columns.Add("Max", "Col10")
                            Case "English"
                                .Columns.Add("Year", "Year")
                                .Columns.Add("Period", "Period")
                                .Columns.Add("Seq", "Seq")
                                .Columns.Add("Code", "Code")
                                .Columns.Add("Description", "Description")
                                .Columns.Add("DC", "D/C")
                                .Columns.Add("PA", "Perc./Amount")
                                .Columns.Add("Qty", "Qty")
                                .Columns.Add("Amount", "Amount")
                                .Columns.Add("Max", "Max")
                                .Columns.Add("YTD", "YTD")
                            Case "Spanish"
                                .Columns.Add("Año", "Col0")
                                .Columns.Add("Periodo", "Col1")
                                .Columns.Add("Seq", "Col2")
                                .Columns.Add("Código", "Col3")
                                .Columns.Add("Desc", "Col4")
                                .Columns.Add("P/M", "Col5")
                                .Columns.Add("Cantidad", "Col6")
                                .Columns.Add("D/C", "Col7")
                                .Columns.Add("Monto", "Col8")
                                .Columns.Add("AHF", "Col9")
                                .Columns.Add("Max", "Col10")

                        End Select

                        .Columns(0).Width = 50
                        .Columns(1).Width = 50
                        .Columns(2).Width = 40
                        .Columns(3).Width = 50
                        .Columns(4).Width = 220
                        .Columns(5).Width = 50
                        .Columns(6).Width = 80
                        .Columns(7).Width = 50
                        .Columns(8).Width = 100
                        .Columns(9).Width = 100

                        .Columns("CODE").ValueType = GetType(System.Int32)
                        .Columns("YTD").DefaultCellStyle.Format = "0.00"
                        .Columns("Amount").DefaultCellStyle.Format = "0.00"
                        .Columns("PA").DefaultCellStyle.Format = "0.00"
                        .Columns("Max").DefaultCellStyle.Format = "0.00"

                        .Columns("Amount").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight
                        .Columns("Max").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight
                        .Columns("Qty").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight
                        .Columns("PA").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight

                    End With

                End With

            End If

            Dim SalForceConnectionString As String = My.Settings("NewSalForceConnection")
            Using Connection As New SqlConnection(SalForceConnectionString)
                If Connection.State = ConnectionState.Closed Then
                    Connection.Open()
                End If

                Dim EMP_RetrieveCommandC As SqlCommand
                Dim EMP_RetrievereaderC As SqlDataReader

                Dim EMP_RetrieveCommandD As SqlCommand
                Dim EMP_RetrievereaderD As SqlDataReader

                Dim SelectedCompany, SelectedEmployee As Integer
                'Here we are selecting the Employee of an existing Company to load

                SelectedCompany = .DataGridMain.SelectedCells.Item(0).Value
                SelectedEmployee = .DataGridMain.SelectedCells.Item(1).Value
                '---------------------------------------------------------------------

                'Create the Query to retrieve the Employee from the database

                Dim EMP_RetrieveStringC = String.Format("Select DDNR, CompanyNr, EmpNr, Jaar, Period, Component_ID, Description, Sequence, DEBCRED, Percentage, Aantal, Amount from dbo.DEDUCTIONS, dbo.EMPDEDUCTIONS
                WHERE (EMPDEDUCTIONS.DDNR = dbo.DEDUCTIONS.DD_recordNr)  And (CompanyNR = {0})  And (EmpNr = {1})  And (DEBCRED = 'C') Order By dbo.DEDUCTIONS.Sequence", SelectedCompany, SelectedEmployee)

                EMP_RetrieveCommandC = New SqlCommand(EMP_RetrieveStringC, Connection)
                EMP_RetrievereaderC = EMP_RetrieveCommandC.ExecuteReader()

                Dim EMP_RetrieveStringD = String.Format("Select CompanyNr, EmpNr, Jaar, Period,  Component_ID, Description, Sequence,DEBCRED, Percentage, Aantal, Amount from dbo.DEDUCTIONS, dbo.EMPDEDUCTIONS
                WHERE (EMPDEDUCTIONS.DDNR = dbo.DEDUCTIONS.DD_recordNr)  And (CompanyNR = {0})  And (EmpNr = {1})  And (DEBCRED = 'D') Order By dbo.DEDUCTIONS.Sequence", SelectedCompany, SelectedEmployee)

                Dim EmployeeData As New clsEmployee
                EmployeeData.Retrieve_Employee_Data(SelectedCompany, SelectedEmployee)

                With frmEmployee

                    .txtHourWage.Text = EmployeeData.Salary_Per_Hour.ToString
                End With
                If EMP_RetrievereaderC.HasRows Then

                    With .DGEmpDeductions
                        EMP_RetrievereaderC.Read()
                        frmEmployee.DGEmpDeductions.Rows.Add()
                        frmEmployee.DGEmpDeductions.Rows(0).Cells("Code").Value = EMP_RetrievereaderC("Component_ID").ToString
                        frmEmployee.DGEmpDeductions.Rows(0).Cells("Description").Value = EMP_RetrievereaderC("Description").ToString
                        frmEmployee.DGEmpDeductions.Rows(0).Cells("Amount").Value = EmployeeData.Salary_Per_Month.ToString
                    End With

                    Dim Counter As Integer = 1
                    Dim TotalIncome As Double
                    While EMP_RetrievereaderC.Read

                        With .DGEmpDeductions

                            .Rows.Add()
                            .Rows(Counter).Cells(0).Value = EMP_RetrievereaderC("Jaar").ToString
                            .Rows(Counter).Cells(1).Value = EMP_RetrievereaderC("Period").ToString
                            .Rows(Counter).Cells(2).Value = EMP_RetrievereaderC("Sequence").ToString
                            .Rows(Counter).Cells(3).Value = EMP_RetrievereaderC("Component_ID").ToString
                            .Rows(Counter).Cells(4).Value = EMP_RetrievereaderC("Description").ToString
                            .Rows(Counter).Cells(5).Value = EMP_RetrievereaderC("DEBCRED").ToString
                            .Rows(Counter).Cells(6).Value = Format(EMP_RetrievereaderC("Percentage"), "N2").ToString
                            .Rows(Counter).Cells("Qty").Value = EMP_RetrievereaderC("Aantal")

                            If Not IsDBNull(.Rows(Counter).Cells("amount").Value) Then

                                Select Case EMP_RetrievereaderC("DDNR")
                                    Case 2, 3

                                        If IsDBNull(EMP_RetrievereaderC("Percentage")) Then
                                            .Rows(Counter).Cells("Amount").Value = EMP_RetrievereaderC("Percentage").ToString
                                        Else
                                            .Rows(Counter).Cells("Amount").Value = .Rows(Counter).Cells("PA").Value / 100 * Format(EmployeeData.Salary_Per_Month, "N2") * .Rows(Counter).Cells("QTY").Value
                                        End If

                                    Case Else
                                        If IsDBNull(EMP_RetrievereaderC("Percentage")) Then
                                            .Rows(Counter).Cells("Amount").Value = EMP_RetrievereaderC("Percentage").ToString
                                        Else
                                            .Rows(Counter).Cells("Amount").Value = EMP_RetrievereaderC("Percentage") * EmployeeData.Salary_Per_Month / 100 * .Rows(Counter).Cells("QTY").Value
                                        End If
                                End Select

                            End If

                            Counter += 1

                        End With

                    End While

                    For I = 0 To .DGEmpDeductions.RowCount - 1
                        TotalIncome = TotalIncome + .DGEmpDeductions.Rows(I).Cells(8).Value
                    Next

                    .DGEmpDeductions.Rows.Add()
                    .DGEmpDeductions.Rows(Counter).Cells("Description").Value = "TotalIncome"

                    .DGEmpDeductions.Rows(Counter).Cells("Amount").Value = TotalIncome
                    EMP_RetrievereaderC.Close()

                    EMP_RetrieveCommandD = New SqlCommand(EMP_RetrieveStringD, Connection)
                    EMP_RetrievereaderD = EMP_RetrieveCommandD.ExecuteReader()

                    Counter += 1

                    While EMP_RetrievereaderD.Read
                        With .DGEmpDeductions
                            .Rows.Add()
                            .Rows(Counter).Cells(0).Value = EMP_RetrievereaderD("Jaar").ToString
                            .Rows(Counter).Cells(1).Value = EMP_RetrievereaderD("Period").ToString
                            .Rows(Counter).Cells(2).Value = EMP_RetrievereaderD("Sequence").ToString
                            .Rows(Counter).Cells(3).Value = EMP_RetrievereaderD("Component_ID").ToString
                            .Rows(Counter).Cells(4).Value = EMP_RetrievereaderD("Description").ToString
                            .Rows(Counter).Cells(5).Value = EMP_RetrievereaderD("DEBCRED").ToString
                            .Rows(Counter).Cells(6).Value = EMP_RetrievereaderD("Percentage")
                            .Rows(Counter).Cells("Qty").Value = EMP_RetrievereaderD("Aantal")

                            If IsDBNull(EMP_RetrievereaderD("Percentage")) Or EMP_RetrievereaderD("Percentage") = 0 Then
                                .Rows(Counter).Cells("Amount").Value = -1 * Format(EMP_RetrievereaderD("AMount"), "N2").ToString
                            Else
                                .Rows(Counter).Cells("Amount").Value = .Rows(Counter).Cells("PA").Value / 100 * Format(EmployeeData.Salary_Per_Hour, "N2") * .Rows(Counter).Cells("QTY").Value * -1
                            End If

                            .Rows(Counter).Cells("Amount").Value = -1 * .Rows(Counter).Cells("PA").Value * EmployeeData.Salary_Per_Month / 100 * CDbl(.Rows(Counter).Cells("QTY").Value)
                            Counter += 1

                        End With

                    End While

                End If

                EMP_RetrievereaderC.Close()
                Connection.Dispose()
                Connection.Close()
            End Using

        End With
    End Function

End Module