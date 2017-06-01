Imports System.Data.SqlClient

Module Tabs_Updating

    Function UpdateSpaartab()
        With frmEmployee

            Dim SelectedCompany As Int16 = .DataGridMain.SelectedCells.Item(0).Value
            Dim selectedemployee As Int32 = .DataGridMain.SelectedCells.Item(1).Value

            Dim SPAARFNAME As String = UCase(Trim(.txtSpaarFondsNaam.Text))
            Dim SPWNPERC As String = Trim(.txtSpaarFondsWNPerc.Text)
            Dim SPWGPERC As String = Trim(.txtSpaarFondsWGPerc.Text)
            Dim SPVBEDRAG As String = Trim(.txtVastBedragSpF.Text)

            Dim PENSFNAME As String = UCase(Trim(.txtPensioenfondsNaam.Text))
            Dim PENSWNPERC As String = Trim(.txtPensWNPerc.Text)
            Dim PENSWGPERC As String = Trim(.txtPensWGPerc.Text)
            Dim PENSVBEDRAG As String = .txtVastBedragPF.Text

            Dim SalforceConnectionString As String
            SalforceConnectionString = My.Settings("NewSalForceConnection")
            Using Connection As New SqlConnection(SalforceConnectionString)
                If Connection.State = ConnectionState.Closed Then
                    Connection.Open()
                End If

                Dim EMP_UPDATECommand As SqlCommand
                Dim EMP_UPDATEREADER As SqlDataReader

                Dim EMP_UPDATESTRING As String = "UPDATE EMPTABLE SET " &
                "EMP_SPAARFNAME = '" & SPAARFNAME & "'," &
                "EMP_SPAARWNPERC = '" & SPWNPERC & "'," &
                "EMP_SPAARWGPERC = '" & SPWGPERC & "'," &
                "EMP_SPAARFIXED = '" & SPVBEDRAG & "'," &
                "EMP_PENSWGPERC = '" & PENSWGPERC & "'," &
                "EMP_PENSWNPERC = '" & PENSWNPERC & "'," &
                "EMP_PENSFIXED=  '" & PENSVBEDRAG & "'," &
                "EMP_PENSFNAME = '" & PENSFNAME & "'" &
                " WHERE EMP_COMPID = " & SelectedCompany & " AND EMP_EMPLOYEENR = " & selectedemployee

                EMP_UPDATECommand = New SqlCommand(EMP_UPDATESTRING, Connection)
                EMP_UPDATEREADER = EMP_UPDATECommand.ExecuteReader
            End Using
        End With

        MsgBox("spaar Tab Saved !", vbExclamation, "SALFORCE")

    End Function

    Function Update_Belasting_Tab()
        Dim Emp_Salaris, Emp_Valuta, Emp_AOVAWW_Perc, Emp_AVBZ_Perc, Emp_ZV_Perc, Emp_BVZ_Perc, EMP_ZOG_Perc,
              Emp_Period, Emp_BesInspectie, Emp_OuderenToeslag, Emp_AlleenVerdienerToeslag, Emp_KinderToeslag, Emp_UrenPerDag,
              Emp_Dagen_Per_Week, Emp_UurLoon, Emp_AutoZaak, Emp_AnderLoon, SelectedCompany, Selectedemployee As String

        Dim SalForceConnectionString As String
        SalForceConnectionString = My.Settings("NewSalForceConnection")
        Using Connection As New SqlConnection(SalForceConnectionString)
            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If
            With frmEmployee
                Emp_Salaris = Trim(.TXTSALARY.Text)
                Emp_Valuta = Trim(.txtValuta.Text)
                Emp_AOVAWW_Perc = Trim(.txtAOVAWW_PERC.Text)
                Emp_AVBZ_Perc = Trim(.txtAVBZ_PERC.Text)
                Emp_ZV_Perc = Trim(.txtZV_PERC.Text)
                Emp_BVZ_Perc = Trim(.txtBVZ_PERC.Text)
                EMP_ZOG_Perc = Trim(.txtZOG_PERC.Text)
                Emp_Period = Trim(.txtPeriode.Text)

                Emp_BesInspectie = Trim(.txtBesInsp.Text)
                Emp_OuderenToeslag = Trim(.txtOuderenToeslag.Text)
                Emp_AlleenVerdienerToeslag = Trim(.txtAlleenVerdienerT.Text)
                Emp_KinderToeslag = Trim(.txtKindToeslag.Text)
                Emp_UrenPerDag = Trim(.txtUrenPerDag.Text)
                Emp_Dagen_Per_Week = Trim(.txtDagenPerWeek.Text)
                Emp_AutoZaak = Trim(.txtAutoZaak.Text)
                Emp_AnderLoon = Trim(.txtAnderloon.Text)
                Emp_UurLoon = Trim(.txtUurloon.Text)

                Dim EMP_UPDATECommand As SqlCommand
                Dim EMP_UPDATEREADER As SqlDataReader

                SelectedCompany = .DataGridMain.SelectedCells.Item(0).Value.ToString
                Selectedemployee = .DataGridMain.SelectedCells.Item(1).Value

                Dim EMP_UPDATESTRING As String = "UPDATE EMPTABLE SET " &
                "EMP_SALARY = '" & Emp_Salaris & "'," &
                "EMP_VALUTA = '" & Emp_Valuta & "'," &
                "EMP_AOVAWW= '" & Emp_AOVAWW_Perc & "'," &
                "EMP_AVBZ = '" & Emp_AVBZ_Perc & "'," &
                "EMP_ZV = '" & Emp_ZV_Perc & "'," &
                "EMP_UURLOON = '" & Emp_UurLoon & "'," &
                "EMP_BVZ_PERC = '" & Emp_BVZ_Perc & "'," &
                "EMP_ZOGPERC = '" & EMP_ZOG_Perc & "'," &
                "EMP_PERIOD = '" & Emp_Period & "'," &
                "EMP_BESLUITINSPVAL = '" & Emp_BesInspectie & "'," &
                "EMP_OUDTOESLAGVAL = '" & Emp_OuderenToeslag & "'," &
                "EMP_ALLEENVERDT = '" & Emp_AlleenVerdienerToeslag & "'," &
                "EMP_UPD = '" & Emp_UrenPerDag & "'," &
                "EMP_DPW = '" & Emp_Dagen_Per_Week & "'," &
                "EMP_CARCATVALUE = '" & Emp_AutoZaak & "'," &
                "EMP_ANDERL = '" & Emp_AnderLoon & "'" &
                " WHERE EMP_COMPID = " & SelectedCompany & " AND EMP_EMPLOYEENR = " & Selectedemployee

                EMP_UPDATECommand = New SqlCommand(EMP_UPDATESTRING, Connection)
                EMP_UPDATEREADER = EMP_UPDATECommand.ExecuteReader
                MsgBox("Belasting Tab Saved !", vbExclamation, "SALFORCE")
                DisablePartnerTab()
                Connection.Close()
                Connection.Dispose()

            End With

        End Using
    End Function

    Function Update_Employee_Tab(EmployeeNr As Int16, CompanyId As Int16)
        With frmEmployee
            If IsDBNull(.txtEmployeeNr.Text) Or .txtEmployeeNr.Text = "" Then
                MsgBox("Employee Nr is verplicht!", vbInformation, Application.ProductName)
                .txtEmployeeNr.Focus()
                Return (0)
                Exit Function
            End If
        End With

        Dim SalforceConnectionString As String

        SalforceConnectionString = My.Settings("NewSalForceConnection")
        Using Connection As New SqlConnection(SalforceConnectionString)
            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim EMP_UPDATECommand As SqlCommand
            Dim EMP_UPDATEREADER As SqlDataReader

            With frmEmployee

                Dim EMPCOMPID As Integer = CType(.txtCompanyNr.Text, Integer)
                Dim EMPID As Integer = CType(.txtEmployeeNr.Text, Integer)
                Dim EMPDEPARTMENT As Int16 = Convert.ToInt16(.txtDepartmentNr.Text) + 1
                Dim EMPFIRSTNAME As String = UCase(.txtEmployeeFirstName.Text)
                Dim EMPLASTNAME As String = UCase(.txtemployeeLastName.Text)
                Dim EMPSEX As String = IIf(.txtEmployeeVRW.Checked, "V", "M")
                Dim EMPADDRESS As String = UCase(.txtemployeeAddress.Text)

                Dim EMPSTARTDATE As String
                If .calEmployeeDateBegin.Checked = True Then
                    EMPSTARTDATE = ConvertDateToSalforceDate(.calEmployeeDateBegin.Text)
                Else
                    EMPSTARTDATE = .txtDateBegin.Text
                End If

                Dim EMPENDDATE As String
                If .calEmployeeDateEnd.Checked = True Then
                    EMPENDDATE = ConvertDateToSalforceDate(.calEmployeeDateEnd.Text)
                Else
                    EMPENDDATE = .txtDateEnd.Text
                End If

                Dim EMPBIRTHDATE As String
                If .CalendarPickerBirthdate.Checked = True Then
                    EMPBIRTHDATE = ConvertDateToSalforceDate(.CalendarPickerBirthdate.Text)
                Else
                    EMPBIRTHDATE = .txtBirthdate.Text
                End If

                Dim EMPISLAND As String = .cmbIsland.Text
                Dim EMPHOMEPHONE As String = .txtEmployeeHomePhone.Text
                Dim EMPCELL As String = .txtEmployeeMobile.Text
                Dim EMPSTATUS As String = .txtEmployeeStatus.Text
                Dim EMPCEDULANR As String = .txtEmployeeCedulaNr.Text
                Dim EMPEMAIL1 As String = UCase(.txtEmployeeEmail1.Text)
                Dim EMPEMAIL2 As String = UCase(.txtEmployeeEmail1.Text)
                Dim EMPPICTURE As String = UCase(.txtEmployeePicture.Text)

                Dim EMP_UPDATESTRING As String = "UPDATE EMPTABLE SET " &
                "EMP_COMPID = " & EMPCOMPID & "," &
                "EMP_EMPLOYEENR = " & EMPID & "," &
                "EMP_STATUS = '" & EMPSTATUS & "'," &
                 "EMP_CEDULANR = '" & EMPCEDULANR & "'," &
                 "EMP_EMAIL1 = '" & EMPEMAIL1 & "'," &
                 "EMP_EMAIL2 = '" & EMPEMAIL2 & "'," &
                 "EMP_SEX ='" & EMPSEX & "'," &
                "EMP_FIRSTNAME='" & EMPFIRSTNAME & "'," &
                "EMP_LASTNAME ='" & EMPLASTNAME & "'," &
                "EMP_STARTDATE = '" & EMPSTARTDATE & "'," &
                 "EMP_ENDDATE = '" & EMPENDDATE & "'," &
                "EMP_HOMEPHONE ='" & EMPHOMEPHONE & "'," &
                 "EMP_ADDRESS ='" & EMPADDRESS & "'," &
                "EMP_PICTURE ='" & EMPPICTURE & "'," &
                 "EMP_CELL ='" & EMPCELL & "'," &
                 "EMP_BIRTHDATE ='" & EMPBIRTHDATE & "'," &
                 "EMP_ISLAND = '" & EMPISLAND & "'," &
                "EMP_DEPARTMENT = " & EMPDEPARTMENT &
                " WHERE EMP_COMPID = " & CompanyId & " AND EMP_EMPLOYEENR = " & EmployeeNr

                EMP_UPDATECommand = New SqlCommand(EMP_UPDATESTRING, Connection)
                EMP_UPDATEREADER = EMP_UPDATECommand.ExecuteReader
                MsgBox("Employee Tab Saved !", vbExclamation, "SALFORCE")

                .TAB01.Refresh()

                Connection.Close()
                Connection.Dispose()
            End With
        End Using
    End Function

End Module