Module LANGUAGE
    Function SetTextonlabelsTAB01(ByVal Language As String)
        Select Case Language
            Case "DUTCH"
                With frmEmployeeProfileBackup
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
                End With
            Case "SPANISH"
                With frmEmployeeProfileBackup
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
                End With
        End Select
    End Function
End Module