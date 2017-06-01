Module LANGUAGE

    Function SetLanguage(ByVal Language As String, TabIndex As Integer)
        Select Case TabIndex
            Case 0
                Language = My.Settings.SalforceLanguage.ToString
                Select Case Language
                    Case "DUTCH"

                        With frmEmployee

                            .lblEmployeeBedrijf.Text = "Bedrijf"
                            .lblEmployeeName.Text = "Naam"
                            .lblEmployeeAdres.Text = "Adres"
                            .lblEmployeeLastname.Text = "Achternaam"
                            .lblemployeeNr.Text = "Employee Nr"
                            .lblEmployeeMail.Text = "Email 1"
                            .lblEmployeeEmial2.Text = "Email 2"
                            .lblEmployeeCel.Text = "Mobile"
                            .lblEmployeeSex.Text = "Man/Vrouw"
                            .lblEmployeestartdate.Text = "Start Datum"
                            .lblEmployeeGebDatum.Text = "Geb.Datum"
                            .lblEmployeeDepartment.Text = "Afdeling Nr"
                            .lblEmployeeEnddate.Text = "Eind Datum"
                            .lblEmployeeFunction.Text = "Function"
                            .lblEmployeeStatus.Text = "Status"
                            .lblEmployeecedulaNr.Text = "Cedula Nr"
                            .lblEmployeePicture.Text = "Foto"
                            .lblEmployeeHomePhone.Text = "Tel.Thuis"
                            .btnEdit.Text = "Muteren"

                            With .DataGridMain.Columns
                                .Add("COMPNR", "COMPNR")
                                .Add("EMPNR", "EMPNR")
                                .Add("NAAM", "NAAM")
                                .Add("ACHTERNAAM", "ACHTERNAAM")
                                .Add("START", "START")
                                .Add("EIND", "EIND")
                                .Add("DEPNR", "DEPNR")
                                .Add("DEPNAME", "AFDELING")
                                .Add("FUNCTIE", "FUNCTIE")
                                .Add("STATUS", "STATUS")
                            End With

                        End With
                    Case "SPANISH"
                        With frmEmployee
                            .lblEmployeeBedrijf.Text = "Compania"
                            .lblEmployeeName.Text = "Nombre"
                            .lblEmployeeAdres.Text = "Direccion"
                            .lblEmployeeLastname.Text = "Appellidos"
                            .lblemployeeNr.Text = "Nr Empleado"
                            .lblEmployeeMail.Text = "Correo 1"
                            .lblEmployeeEmial2.Text = "Correo 2"
                            .lblEmployeeCel.Text = "Cellular"
                            .lblEmployeeSex.Text = "Sexo"
                            .lblEmployeestartdate.Text = "En Servicio"
                            .lblEmployeeGebDatum.Text = "Fecha Nacemiento"
                            .lblEmployeeDepartment.Text = "Nr Departamento"
                            .lblEmployeeEnddate.Text = "Final Servicio"
                            .lblEmployeeFunction.Text = "Funcion"
                            .lblEmployeeStatus.Text = "Status 1=Aktivo"
                            .lblEmployeecedulaNr.Text = "Nr Cedula"
                            .lblEmployeePicture.Text = "Foto"
                            .lblEmployeeHomePhone.Text = "Telf. Domicilio"
                            .btnEdit.Text = "Editar"

                            With .DataGridMain.Columns
                                .Add("COMPNR", "COMPNR")
                                .Add("EMPNR", "EMPNR")
                                .Add("NAAM", "NOMBRE")
                                .Add("ACHTERNAAM", "APELLIDO")
                                .Add("START", "INICIO")
                                .Add("EIND", "TERMINACION")
                                .Add("DEPNR", "DEPNR")
                                '.Add("DEPNAME", "AFDELING")
                                .Add("FUNCTIE", "FUNCION")
                                .Add("STATUS", "STATUS")
                            End With

                        End With
                    Case "English"
                        With frmEmployee
                            .lblEmployeeBedrijf.Text = "Company"
                            .lblEmployeeName.Text = "Name"
                            .lblEmployeeAdres.Text = "Address"
                            .lblEmployeeLastname.Text = "Last Name"
                            .lblemployeeNr.Text = "Employee Nr"
                            .lblEmployeeMail.Text = "Mail 1"
                            .lblEmployeeEmial2.Text = "Mail 2"
                            .lblEmployeeCel.Text = "Cell Nr"
                            .lblEmployeeSex.Text = "Sex"
                            .lblEmployeestartdate.Text = "Start"
                            .lblEmployeeGebDatum.Text = "Birth Dtate"
                            .lblEmployeeDepartment.Text = "Department"
                            .lblEmployeeEnddate.Text = "End Date"
                            .lblEmployeeFunction.Text = "Job Title"
                            .lblEmployeeStatus.Text = "Status 1=Aktive"
                            .lblEmployeecedulaNr.Text = "Id Nr"
                            .lblEmployeePicture.Text = "Picture"
                            .lblEmployeeHomePhone.Text = "Home Phone"
                            .btnEdit.Text = "Edit"

                        End With

                End Select
            Case 1 'TAB 01
                Select Case Language
                    Case "Dutch"
                    Case "Spanish"
                    Case "English"
                        With frmEmployee
                            .lblspouseName.Text = "Partner Name"
                            .lblPartnerLastName.Text = "Partner LastName"
                            .lblSpouseEmployer.Text = "Partner Employer"
                            .lblSpouseMiddenName.Text = "Partner MiddenName"
                            .lblSpouseBirthDate.Text = "Partner Birthdate"
                            .lblBelInkomen.Text = "Partner Taxable Wage"
                            With .DataGridView2
                                If .Columns.Count = 0 Then
                                    .Columns.Add("NAAM", "NAME")
                                    .Columns.Add("ACHTERNAAM", "LASTNAME")
                                    .Columns.Add("GEB.DATUM", "BIRTHDATE")
                                    .Columns.Add("SCHOOL", "SCHOOL")
                                    .Columns.Add("CATEGORY", "CATEGORY")
                                    .Columns.Add("TOESLAG", "ALLOWANCE")
                                End If

                            End With

                        End With
                End Select

        End Select
    End Function

    Function SetTextonlabelsTAB02(ByVal Language As String)

    End Function

End Module