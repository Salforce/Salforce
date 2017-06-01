Module Tabs_Enabling

    Function EnableSpaarTab()
        With frmEmployee
            .txtPensioenfondsNaam.Enabled = True
            .txtPensWGPerc.Enabled = True
            .txtPensWNPerc.Enabled = True
            .CheckBoxSpaarfonds.Enabled = True
            .txtSpaarFondsNaam.Enabled = True
            .txtSpaarFondsWGPerc.Enabled = True
            .txtSpaarFondsWNPerc.Enabled = True
            .btnSave.Enabled = True
            .CheckBoxPensioen.Enabled = True
            .txtVastBedragPF.Enabled = True
            .txtVastBedragSpF.Enabled = True
        End With
        Return (0)
    End Function

    Function EnableVergoedingenTAB()
        With frmEmployee
            .DGVergoedingen.Enabled = True
            .DGVergoedingenB.Enabled = True
            .btnSave.Enabled = True
        End With

        Return (0)
    End Function

    Function DisableVergoedingenTab()
        With frmEmployee
            .DGVergoedingen.Enabled = False
            .DGVergoedingenB.Enabled = False
        End With
        Return (0)
    End Function

    Function EnableBelastingTab()
        With frmEmployee
            ' .txtPeriode2.Text = .cmbPeriod.Items(.cmbPeriod.SelectedIndex).ToString
            .TXTSALARY.Enabled = True
            '.txtPensioenfonds.Enabled = True
            .txtAOVAWW_PERC.Enabled = True
            '.txtKindToeslag.Enabled = True     'this value is calculated on a hidden textbox on the family Tab
            .txtOuderenToeslag.Enabled = True
            '.txtPensioenfonds.Enabled = True
            .cmbvaluta.Visible = True
            .cmbvaluta.Enabled = True
            .txtValuta.Visible = False
            .txtZV_PERC.Enabled = True
            .txtAVBZ_PERC.Enabled = True
            .txtAnderloon.Enabled = True
            .txtBesInsp.Enabled = True
            .txtAutoZaak.Enabled = True
            .txtAlleenVerdienerT.Enabled = True
            .txtAnderloon.Enabled = True
            .txtZOGPREMIE.Enabled = True
            .txtUrenPerDag.Enabled = True
            .txtDagenPerWeek.Enabled = True
            .cmbPeriod.Visible = True
            .txtBVZ_PERC.Enabled = True
            .txtZOG_PERC.Enabled = True
            If .cmbPeriod.Text = "" Then
                .cmbPeriod.Text = .txtPeriode.Text
            End If
            .txtPeriode.Visible = False

            .btnSave.Enabled = True
            .CheckBoxSpaarfonds.Enabled = True
            .CheckBoxPensioen.Enabled = True
        End With
        Return (0)
    End Function

    Function DisableBelastingtab()
        With frmEmployee

            .txtDepartmentNr.Enabled = False
            .cmbSelectDepartment.Visible = False
            .txtDepartmentNr.Visible = True

            .TXTSALARY.Enabled = False
            .txtUrenPerDag.Enabled = False
            .txtPensioenfonds.Enabled = False
            .txtAOVAWW_PERC.Enabled = False
            .txtKindToeslag.Enabled = False
            .txtOuderenToeslag.Enabled = False
            .txtPensioenfonds.Enabled = False
            .cmbvaluta.Visible = False
            .txtValuta.Visible = True
            .txtValuta.Enabled = False
            .txtZV_PERC.Enabled = False
            .txtAVBZ_PERC.Enabled = False
            .txtAnderloon.Enabled = False
            .txtBesInsp.Enabled = False
            .txtAutoZaak.Enabled = False
            .txtAlleenVerdienerT.Enabled = False
            .txtZOGPREMIE.Enabled = False
            .txtDagenPerWeek.Enabled = False
            .cmbPeriod.Visible = False
            .txtPeriode.Enabled = False
            .txtPeriode.Visible = True
            .txtBVZ_PERC.Enabled = False
            .btnSave.Enabled = False
            .txtOnkostenVergoeding.Enabled = False
            .txtVastBedragSpF.Enabled = False
            .txtVastBedragPF.Enabled = False
            .CheckBoxSpaarfonds.Enabled = False
            .CheckBoxPensioen.Enabled = False
            .txtZOG_PERC.Enabled = False
        End With
        Return (0)
    End Function

    Function EnablePartnerTab()
        With frmEmployee

            .txtPartnerFirstname.Enabled = True
            .txtPartnerLastname.Enabled = True
            .txtPartnerMidname.Enabled = True

            .DatePickerPartnerBirthdate.Visible = True
            .DatePickerPartnerBirthdate.Enabled = True
            .txtPartnerBirthDate.Visible = False
            .txtPartnerEmployer.Enabled = True
            .txtPartnerBelInkomen.Enabled = True
            .btnSave.Enabled = True
            .btnClear.Enabled = True
            .DataGridView2.Visible = True
            .DataGridView2.Enabled = True
        End With
        Return (0)
    End Function

    Function EnableEmployeeTab()
        LoadCompanyCombo()
        With frmEmployee

            '-------------------------COMPANY---------------------
            '.cmbSelectCompany.Visible = True
            '.txtCompanyNr.Visible = False
            '-------------------------COMPANY---------------------

            '-------------------------DEPARTMENT---------------------
            .cmbSelectDepartment.Enabled = True
            .txtDepartmentNr.Visible = False
            .cmbSelectDepartment.Visible = True
            .cmbSelectDepartment.Text = .txtDepartmentNr.Text
            '-------------------------DEPARTMENT---------------------

            '-------------------------BIRTHDATE---------------------
            .CalendarPickerBirthdate.Visible = True
            .CalendarPickerBirthdate.Enabled = True
            .txtBirthdate.Visible = False
            '-------------------------BIRTHDATE---------------------

            '-------------------------ISLAND---------------------
            .cmbIsland.Enabled = True
            .cmbIsland.Items.Add("CUR")
            .cmbIsland.Items.Add("BES")
            '-------------------------ISLAND---------------------

            '-------------------------DATE BEGIN---------------------
            .calEmployeeDateBegin.Visible = True
            .calEmployeeDateBegin.Enabled = True
            .txtDateBegin.Visible = False
            If .txtDateBegin.Text = "" Then
                .calEmployeeDateBegin.Text = ""
            Else
                .calEmployeeDateBegin.Value = Mid(.txtDateBegin.Text, 5, 2) & "-" & Right(.txtDateBegin.Text, 2) & "-" & Left(.txtDateBegin.Text, 4)
            End If

            '-------------------------DATE BEGIN---------------------

            '-------------------------DATE END---------------------
            .calEmployeeDateEnd.Visible = True
            .calEmployeeDateEnd.Enabled = True
            .txtDateEnd.Visible = False
            If .txtDateEnd.Text = "" Then
                .calEmployeeDateEnd.Text = ""
            Else
                .calEmployeeDateEnd.Value = Mid(.txtDateEnd.Text, 5, 2) & "-" & Right(.txtDateEnd.Text, 2) & "-" & Left(.txtDateEnd.Text, 4)
            End If
            '-------------------------DATE END---------------------

            .txtEmployeeStatus.Enabled = True
            .txtemployeeAddress.Enabled = True
            .txtEmployeeCedulaNr.Enabled = True

            .txtEmployeeEmail1.Enabled = True
            .txtEmployeeEmail2.Enabled = True
            .txtEmployeefunction.Enabled = True
            .txtemployeeLastName.Enabled = True
            .txtEmployeeFirstName.Enabled = True
            .txtEmployeeMobile.Enabled = True
            .txtEmployeeHomePhone.Enabled = True

            .txtEmployeeMAN.Enabled = True
            .txtEmployeeVRW.Enabled = True

            .txtEmployeePicture.Enabled = True

            .btnSave.Enabled = True
            .btnClear.Enabled = True
            .TAB01.Refresh()
        End With

        Return (0)
    End Function

    Function DisableEmployeeTab()
        With frmEmployee
            .cmbSelectCompany.Visible = False
            .txtCompanyNr.Visible = True
            .txtCompanyNr.Enabled = False
            .cmbSelectDepartment.Visible = False
            .txtDepartmentNr.Visible = True
            .txtDepartmentNr.Enabled = False

            .txtEmployeeStatus.Enabled = False
            .txtemployeeAddress.Enabled = False
            .txtEmployeeCedulaNr.Enabled = False
            .txtEmployeeNr.Enabled = False

            .txtEmployeeEmail1.Enabled = False
            .txtEmployeeEmail2.Enabled = False
            .txtEmployeefunction.Enabled = False
            .txtemployeeLastName.Enabled = False
            .txtEmployeeFirstName.Enabled = False
            .txtEmployeeMobile.Enabled = False
            .txtEmployeeHomePhone.Enabled = False
            .DatePickerPartnerBirthdate.Visible = False
            .txtPartnerBirthDate.Visible = True

            .txtDateBegin.Visible = True
            .txtDateEnd.Enabled = False
            .txtDateEnd.Visible = True
            .calEmployeeDateBegin.Visible = False
            .calEmployeeDateEnd.Visible = False
            .CalendarPickerBirthdate.Enabled = False

            .CalendarPickerBirthdate.Visible = False

            .txtBirthdate.Visible = True
            .btnClear.Enabled = False
            .cmbPeriod.Visible = False
            .txtPeriode.Visible = True
            .txtPeriode.Enabled = False
            .cmbIsland.Enabled = False
            .txtEmployeeMAN.Enabled = False
            .txtEmployeeVRW.Enabled = False
            .txtEmployeePicture.Enabled = False
        End With

        Return (0)
    End Function

    Function DisableSpaarTab()
        With frmEmployee

            .txtBVZ_Amount.Enabled = False
            .txtSpaarFondsWGPerc.Enabled = False
            .txtSpaarFondsWNPerc.Enabled = False
            .txtSpaarFondsNaam.Enabled = False

            .txtPensioenfondsNaam.Enabled = False
            .txtPensWGPerc.Enabled = False
            .txtPensWNPerc.Enabled = False
            .txtPensioenfonds.Enabled = False

            .txtVastBedragPF.Enabled = False
            .txtVastBedragSpF.Enabled = False

            .CheckBoxPensioen.Enabled = False
            .CheckBoxSpaarfonds.Enabled = False

        End With
    End Function

    Function DisablePartnerTab()
        With frmEmployee

            .DatePickerPartnerBirthdate.Visible = False
            .txtPartnerBirthDate.Visible = True
            .txtPartnerBirthDate.Enabled = False
            .txtPartnerFirstname.Enabled = False
            .txtPartnerLastname.Enabled = False
            .txtPartnerMidname.Enabled = False

            .txtPartnerEmployer.Enabled = False

            .txtPartnerBelInkomen.Enabled = False
            .btnSave.Enabled = False
            .btnClear.Enabled = False

        End With
        Return (0)
    End Function

    Function EnableNotitiesTab()
        With frmEmployee
            .txtEmpNotities.Enabled = True
            .btnSave.Enabled = True
        End With
        Return (0)
    End Function

    Function DisableNotitiesTab()
        With frmEmployee
            .txtEmpNotities.Enabled = False
            .btnSave.Enabled = False
        End With
        Return (0)
    End Function

End Module