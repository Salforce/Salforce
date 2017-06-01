Imports System.Data.SqlClient
Imports System.IO

Module Tabs

    Private Property DBNull As Object

    Function AdjustComboHeights(ByVal Formname As String)
        Dim clscombo As New clsResizeComboBox
        ' Here we can modify the height of this Company comboBox

        With clscombo
            .SetComboEditHeight(frmEmployee.cmbSelectCompany, 12)
            .SetComboEditHeight(frmEmployee.cmbSelectDepartment, 12)
            .SetComboEditHeight(frmEmployee.cmbIsland, 12)
        End With
        Return (0)
    End Function

    Function CalculateTotalIncome() As String
        Dim TotalIncome, Salary, OnkostenVergoeding, AnderLoon, AutoVergoeding As Double
        TotalIncome = Nothing
        With frmEmployee
            If .TXTSALARY.Text = "" Or IsDBNull(.TXTSALARY.Text) Then
                Salary = 0
            Else
                Salary = Convert.ToDouble(.TXTSALARY.Text)
            End If

            If .txtOnkostenVergoeding.Text = "" Or IsDBNull(.txtOnkostenVergoeding.Text) Or IsNothing(.txtOnkostenVergoeding.Text) Then
                OnkostenVergoeding = 0
            Else
                OnkostenVergoeding = Convert.ToDouble(.txtOnkostenVergoeding.Text)
            End If

            If .txtAnderloon.Text = "" Or IsDBNull(.txtAnderloon.Text) Then
                AnderLoon = 0
            Else
                AnderLoon = Convert.ToDouble(.txtAnderloon.Text)
            End If

            If .txtAutoZaak.Text = "" Or IsDBNull(.txtAutoZaak.Text) Then
                .txtAutoZaak.Text = 0
            Else
                AutoVergoeding = Convert.ToDouble(.txtAutoZaak.Text)
            End If
            TotalIncome = Salary + OnkostenVergoeding + AnderLoon + AutoVergoeding

        End With

        Return (TotalIncome.ToString("N"))

    End Function

    Function ClearEmployeeDataEntry()
        With frmEmployee
            .cmbSelectCompany.Text = Nothing
            .txtCompanyNr.Text = Nothing
            .txtEmployeeNr.Text = Nothing
            .txtEmployeeFirstName.Text = Nothing
            .txtemployeeLastName.Text = Nothing
            .txtemployeeAddress.Text = Nothing
            .CalendarPickerBirthdate.Text = Nothing
            .cmbSelectDepartment.Text = Nothing
            .calEmployeeDateBegin.Text = Nothing
            .txtDateBegin.Text = Nothing
            .calEmployeeDateEnd.Text = Nothing
            .txtDateEnd.Text = Nothing
            .txtEmployeefunction.Text = Nothing
            .txtEmployeeCedulaNr.Text = Nothing
            .txtEmployeeHomePhone.Text = Nothing
            .txtEmployeeMobile.Text = Nothing
            .txtEmployeeEmail1.Text = Nothing
            .txtEmployeeEmail2.Text = Nothing
            .txtEmployeePicture.Text = Nothing
            .txtPartnerFirstname.Text = Nothing
            .txtPartnerLastname.Text = Nothing
            .DatePickerPartnerBirthdate.Value = Now()
            .txtPartnerBirthDate.Text = Nothing
            .txtPartnerMidname.Text = Nothing
            .btnEdit.Enabled = False
            For Counter = 0 To .DataGridView2.RowCount - 1
                .DataGridView2.Rows.Clear()
            Next Counter
            .Refresh()
        End With
        Return (0)

    End Function

    Function CreateChildrenContextMenu()
        Dim ChildrencontextMenu As New ContextMenuStrip
        Dim StripItem As New ToolStripMenuItem()

        Select Case My.Settings.SalforceLanguage.ToString
            Case "English"
                Dim AddChild As String = "Add Child"
                Dim DeleteChild As String = "Delete Child"
                Dim ModifyChild As String = "Modify Child"
                Dim PrintChild As String = "Print Out"
                Dim VerwijderAlles As String = "Delete All"
            Case "Dutch"
                Dim AddChild As String = "Kind Toevoegen"
                Dim DeleteChild As String = "Kind Verwijderen"
                Dim ModifyChild As String = "Kind wijzigen"
                Dim PrintChild As String = "Uitprinten"
                Dim VerwijderAlles As String = "Alles Verwijderen"
            Case "Spanish"
                Dim AddChild As String = "Anadir Hijo(a)"
                Dim DeleteChild As String = "Borrar Hijo(a)"
                Dim ModifyChild As String = "Modificar Hijo(a)"
                Dim PrintChild As String = "Emprimir "
                Dim VerwijderAlles As String = "Borrar Todo"
        End Select

        Dim StripItemToevoegen As New ToolStripMenuItem() With {.Text = "Verwijder", .Tag = "1"}
        AddHandler StripItemToevoegen.Click, AddressOf StripItemKindToevoegen_Click
        ChildrencontextMenu.Items.Add(StripItemToevoegen)

        Dim StripItemVerwijder As New ToolStripMenuItem() With {.Text = "Verwijder", .Tag = "2"}
        AddHandler StripItemVerwijder.Click, AddressOf StripItemVerwijder_Click
        ChildrencontextMenu.Items.Add(StripItemVerwijder)

        Dim StripItemWijzigen As New ToolStripMenuItem() With {.Text = "Wijzigen", .Tag = "3"}
        AddHandler StripItemWijzigen.Click, AddressOf StripItemWijzigen_Click
        ChildrencontextMenu.Items.Add(StripItemWijzigen)

        Dim StripItemPrinten As New ToolStripMenuItem() With {.Text = "Print", .Tag = "4"}
        AddHandler StripItemPrinten.Click, AddressOf StripItemPrinten_Click
        ChildrencontextMenu.Items.Add(StripItemPrinten)

        ' Add a couple of children
        Dim StripItemVerwijderAlles As New ToolStripMenuItem
        StripItemVerwijderAlles.Text = "Verwijder Alles"
        StripItemVerwijderAlles.Tag = "5"
        AddHandler StripItemVerwijderAlles.Click, AddressOf StripItemVerwijderAlles_Click
        StripItemVerwijder.DropDownItems.Add(StripItemVerwijderAlles)

        ' Add a couple of children
        Dim StripItemVerwijderSelektie As New ToolStripMenuItem() With {.Text = "Verwijder Selektie", .Tag = "6"}
        AddHandler StripItemVerwijderSelektie.Click, AddressOf StripItemVerwijderSelektie_Click
        StripItemVerwijder.DropDownItems.Add(StripItemVerwijderSelektie)

        ChildrencontextMenu.BackColor = Color.BlanchedAlmond
        frmEmployee.DataGridView2.ContextMenuStrip = ChildrencontextMenu
        Return (0)
    End Function

    Function EditButton()
        With frmEmployee
            Select Case .TabControl.SelectedIndex
                Case 0
                    EnableEmployeeTab()     'EMPLOYEE TAB IS ACTIVE
                Case 1
                    EnablePartnerTab()       'FAMILY TAB IS ACTIVE
                Case 2
                    EnableBelastingTab()    'BELASTING TAB IS ACTIVE
                Case 3
                    EnableVergoedingenTAB()
                Case 5
                    EnableNotitiesTab()     'NOTITIES TAB IS ACTIVE
                Case 4
                    EnableSpaarTab()     'Spaar & Pensioen IS ACTIVE
            End Select
        End With

        Return (0)
    End Function

    Function ImageExist(ImageName As String) As Boolean
        If File.Exists(Application.StartupPath & "\EMPPICTS\" & ImageName & ".JPG") Then
            Return True
        Else
            Return False
        End If
    End Function

    Function IsValidImage(filename As String) As Boolean
        If ImageExist(filename) Then
            Try
                Dim img As System.Drawing.Image = System.Drawing.Image.FromFile(filename)
            Catch generatedExceptionName As OutOfMemoryException
                ' Image.FromFile throws an OutOfMemoryException
                ' if the file does not have a valid image format or
                ' GDI+ does not support the pixel format of the file.
                '
                Return True
            End Try
        End If
        Return False
    End Function

    Function LoadAllowance()

        Dim CompanyNr As Int16
        Dim EmployeeNr As Int32

        Dim SalForceConnectionString As String

        With frmEmployee
            For K = 0 To .DGVergoedingen.RowCount - 1
                'frmEmployee.DGVergoedingen.Rows(K).Cells("Column4").Value = ""
                'frmEmployee.DGVergoedingenB.Rows(K).Cells("Column4").Value = ""
                '  .DGVergoedingen.Rows(K).Cells("Column4").Value = ""
                ' .DGVergoedingenB.Rows(K).Cells("Column4").Value = ""

            Next

        End With

        With frmEmployee.DataGridMain
            CompanyNr = .SelectedCells.Item(0).Value
            EmployeeNr = .SelectedCells.Item(1).Value

            If Len(CompanyNr) = 0 Then
                Return (0)
                Exit Function
            End If

        End With
        ' Try
        SalForceConnectionString = My.Settings("NewSalForceConnection")
        Using Connection As New SqlConnection(SalForceConnectionString)
            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim cmdSQL As New SqlCommand

            With cmdSQL
                .CommandType = CommandType.StoredProcedure
                .CommandText = "SALF2000"
                .Connection = Connection
                .Parameters.Add("@Param1", SqlDbType.SmallInt)
                .Parameters.Add("@Param2", SqlDbType.Int)
                .Parameters("@Param1").Value = CompanyNr
                .Parameters("@Param2").Value = EmployeeNr
            End With

            Dim Reader As SqlDataReader = Nothing
            Reader = cmdSQL.ExecuteReader()

            If Reader.HasRows = False Then

                Exit Function
            End If

            'Here we are selecting the Employee of an existing Company to load

            Dim ColumnATotal As Double = 0
            Dim ColumnBTotal As Double = 0
            Dim RecordCounterA As Integer = 0
            Dim RecordCounterB As Integer = 0

            While Reader.Read
                With frmEmployee

                    If Reader.Item("Type") = "O" Then
                        .DGVergoedingen.Rows(RecordCounterA).Cells("Column0").Value = Reader.Item("Year").ToString
                        .DGVergoedingen.Rows(RecordCounterA).Cells("Column1").Value = Reader.Item("Period").ToString
                        .DGVergoedingen.Rows(RecordCounterA).Cells("Column2").Value = Reader.Item("Code").ToString
                        .DGVergoedingen.Rows(RecordCounterA).Cells("Column3").Value = Reader.Item("Description").ToString
                        .DGVergoedingen.Rows(RecordCounterA).Cells("Column4").Value = Reader.Item("Amount")

                        ColumnATotal = ColumnATotal + .DGVergoedingen.Rows(RecordCounterA).Cells("Column4").Value
                        RecordCounterA += 1
                    Else
                        .DGVergoedingenB.Rows(RecordCounterB).Cells("Column0").Value = Reader.Item("Year").ToString
                        .DGVergoedingenB.Rows(RecordCounterB).Cells("Column1").Value = Reader.Item("Period").ToString
                        .DGVergoedingenB.Rows(RecordCounterB).Cells("Column2").Value = Reader.Item("Code").ToString
                        .DGVergoedingenB.Rows(RecordCounterB).Cells("Column3").Value = Reader.Item("Description").ToString
                        .DGVergoedingenB.Rows(RecordCounterB).Cells("Column4").Value = Reader.Item("Amount")

                        ColumnBTotal = ColumnBTotal + .DGVergoedingenB.Rows(RecordCounterB).Cells("Column4").Value
                        RecordCounterB += 1
                    End If

                    .DGVergoedingen.Rows(.DGVergoedingenB.RowCount - 1).Cells("Column4").Value = ColumnATotal
                    .DGVergoedingenB.Rows(.DGVergoedingenB.RowCount - 1).Cells("Column4").Value = ColumnBTotal

                End With

            End While

            Select Case My.Settings.SalforceLanguage.ToString

                Case "English"
                    With frmEmployee
                        .DGVergoedingen.Rows(.DGVergoedingen.RowCount - 1).Cells("Column3").Value = "Total Untaxable Allowanace"
                        .DGVergoedingenB.Rows(.DGVergoedingenB.RowCount - 1).Cells("Column3").Value = "Total Untaxable Allowance"
                    End With
                Case "Dutch"
                    With frmEmployee
                        .DGVergoedingen.Rows(.DGVergoedingen.RowCount - 1).Cells("Column3").Value = "Totaal Onbelaste Vergoeding:"
                        .DGVergoedingenB.Rows(.DGVergoedingenB.RowCount - 1).Cells("Column3").Value = "Totaal Belaste Vergoeding:"
                    End With
                Case "Spanish"
                    With frmEmployee
                        .DGVergoedingen.Rows(.DGVergoedingen.RowCount - 1).Cells("Column3").Value = "Total Compensacion Libre de Impuestos"
                        .DGVergoedingenB.Rows(.DGVergoedingenB.RowCount - 1).Cells("Column3").Value = "Total Compensacion Libre de Impuestos"
                    End With
            End Select

            Reader.Close()
            Connection.Dispose()
            Connection.Close()
        End Using

        Return (0)
    End Function

    Function LoadCompanyCombo()

        ' ----------------------Company Combobox already loaded, so we skip this-----------------------------
        With frmEmployee
            If .cmbSelectCompany.Items.Count > 0 Then
                Exit Function
                Return (0)
            End If
        End With
        '--------------------------------------------------------------------------------------------------------------

        Dim COMPID As String = Nothing

        Dim SqlCompanyString As String = "Select COMP_ID, COMP_NAME, COMP_COUNTRY From COMPANYTABLE"

        Dim Company_Retrievereader As SqlDataReader = Nothing
        Dim Company_RetrieveCommand As SqlCommand
        Dim ConnectionString As String = My.Settings("NewSalforceConnection")
        Using connection As New SqlConnection(ConnectionString)
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            'Executing the Queries-------------------------------------------------------------------
            Company_RetrieveCommand = New SqlCommand(SqlCompanyString, connection)
            '-----------------------------------------------------------------------------------------

            'The query results must be stored in a reader to get the data------------------------------
            Company_Retrievereader = Company_RetrieveCommand.ExecuteReader()
            If Not Company_Retrievereader.HasRows Then
                MsgBox(GetMessageString(1000, "Ned"), vbAbort, "SALFORCE")
                connection.Close()
                connection.Dispose()
                Return (-1)
            End If
            With frmEmployee
                While Company_Retrievereader.Read
                    COMPID = Company_Retrievereader.Item("COMP_ID").ToString
                    Select Case Len(COMPID)
                        Case 1
                            COMPID = "000" + COMPID
                        Case 2
                            COMPID = "00" + COMPID
                        Case 3
                            COMPID = "0" + COMPID
                    End Select

                    .cmbSelectCompany.Items.Add(UCase(String.Format("{0}    {1}", COMPID, Company_Retrievereader.Item("COMP_NAME"))))
                    .cmbCompanySelection.DropDownItems.Add(UCase(String.Format("{0}    {1}", COMPID, Company_Retrievereader.Item("COMP_NAME"))))
                End While

                connection.Close()
                connection.Dispose()
                .cmbCompanySelection.AutoSize = True
            End With
        End Using

        Return (0)
    End Function

    Function LoadDepartmentcombo(ByVal CompanyNr As Integer)
        If frmEmployee.cmbSelectDepartment.Items.Count > 0 Then
            Exit Function
        End If

        Dim DEP_RetrieveString As String
        Dim DEP_Retrievereader As SqlDataReader
        Dim DEP_RetrieveCommand As SqlCommand

        Using connection As New SqlConnection(My.Settings("NewSalForceConnection"))
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            DEP_RetrieveString = String.Format("Select DEP_COMP,DEP_NR, DEPNAME From DEPARTMENTS WHERE DEP_COMP = {0}", CompanyNr)
            DEP_Retrievereader = Nothing

            'Executing the Queries-------------------------------------------------------------------
            DEP_RetrieveCommand = New SqlCommand(DEP_RetrieveString, connection)
            '-----------------------------------------------------------------------------------------

            'The query results must be stored in a reader to get the data------------------------------
            DEP_Retrievereader = DEP_RetrieveCommand.ExecuteReader()
            '-----------------------------------------------------------------------------------------

            If DEP_Retrievereader.HasRows Then

                While DEP_Retrievereader.Read()
                    frmEmployee.cmbSelectDepartment.Items.Add(UCase(DEP_Retrievereader("DEPNAME").ToString))
                End While
            Else
                MsgBox("No departments available")
            End If
            connection.Close()
            connection.Dispose()

        End Using
        Return (0)
    End Function

    Function LoadEmployeeDataGrid(ByVal SelectedCompany As Integer) 'This function load ALL Employees of the selected COMPANY in the DataGrid (DatagridView1)

        Dim Positie As Integer = 10

        If Len(SelectedCompany) = 0 Then
            Return (0)
            MsgBox("No Company Selected")
            Exit Function
        End If

        With frmEmployee
            .ToolStripProgressBar1.Visible = True
            .DataGridMain.RowCount = 0

            Using Connection As New SqlConnection(My.Settings("NewSalForceConnection"))

                Dim EMP_RetrieveCommand, EMP_CountCommand As New SqlCommand
                EMP_RetrieveCommand.CommandType = CommandType.StoredProcedure
                EMP_RetrieveCommand.CommandText = "SALF1000"
                EMP_RetrieveCommand.Connection = Connection

                EMP_RetrieveCommand.Parameters.Add("@Param1", SqlDbType.SmallInt)
                EMP_RetrieveCommand.Parameters("@Param1").Value = SelectedCompany
                If Connection.State = ConnectionState.Closed Then
                    Connection.Open()
                End If

                Dim EMP_Retrievereader As SqlDataReader
                Dim RowCount As Integer

                EMP_Retrievereader = EMP_RetrieveCommand.ExecuteReader()

                RowCount = 0

                .ToolStripProgressBar1.Minimum = 0
                .ToolStripProgressBar1.Maximum = GetTableTotalRows("EMPTABLE", SelectedCompany)
                .ToolStripProgressBar1.Step = 1
                With .DataGridMain.Columns

                    .Add("COMPNR", "COMPNR")
                    .Add("EMPNR", "EMPNR")
                    .Add("NAAM", "NAME")
                    .Add("ACHTERNAAM", "LASTNAME")
                    .Add("START", "START")
                    .Add("EIND", "TERMINATE")
                    .Add("DEPNR", "DEPNR")
                    .Add("DEPNAME", "AFDELING")
                    .Add("FUNCTIE", "JOB TITLE")
                    .Add("STATUS", "STATUS")
                End With

                With .DataGridMain

                    .Columns("COMPNR").Width = 60
                    .Columns("EMPNR").Width = 60
                    .Columns("NAAM").Width = 100
                    .Columns("ACHTERNAAM").Width = 150
                    .Columns("DEPNR").Width = 40
                    .Columns("DEPNAME").Width = 150
                    .Columns("FUNCTIE").Width = 180
                    .Columns("STATUS").Width = 60
                    .Columns("START").Width = 70
                    .Columns("EIND").Width = 70

                    .Columns("STATUS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns("EMPNR").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns("DEPNR").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End With

                While EMP_Retrievereader.Read() = True

                    With .DataGridMain
                        .Rows.Add()
                        .Rows(RowCount).Cells("COMPNR").Value = EMP_Retrievereader.Item("EMP_COMPID").ToString()
                        .Rows(RowCount).Cells("EMPNR").Value = EMP_Retrievereader.Item("EMP_EMPLOYEENR")
                        .Rows(RowCount).Cells("NAAM").Value = EMP_Retrievereader.Item("EMP_FIRSTNAME").ToString()
                        .Rows(RowCount).Cells("ACHTERNAAM").Value = EMP_Retrievereader.Item("EMP_LASTNAME").ToString()
                        .Rows(RowCount).Cells("DEPNR").Value = EMP_Retrievereader.Item("EMP_DEPARTMENT").ToString()
                        .Rows(RowCount).Cells("DEPNAME").Value = EMP_Retrievereader.Item("DEPNAME").ToString()
                        .Rows(RowCount).Cells("FUNCTIE").Value = EMP_Retrievereader.Item("EMP_POSITION").ToString()
                        .Rows(RowCount).Cells("STATUS").Value = EMP_Retrievereader.Item("EMP_STATUS").ToString()
                        .Rows(RowCount).Cells("START").Value = EMP_Retrievereader.Item("EMP_STARTDATE").ToString
                        .Rows(RowCount).Cells("EIND").Value = EMP_Retrievereader.Item("EMP_ENDDATE").ToString
                    End With

                    RowCount += 1
                    .ToolStripProgressBar1.Step = 1
                    .ToolStripProgressBar1.PerformStep()
                End While
                .ToolStripStatusLabel1.Text = String.Format("COMPANY: {0}", SelectedCompany)
                Connection.Dispose()
                Connection.Close()

            End Using

            .btnEdit.Enabled = True
            .ToolStripProgressBar1.Value = 0
            .ToolStripProgressBar1.Visible = False
            LoadToolStrip()
            'LoadDepartmentcombo(SelectedCompany)
        End With

        Return (0)
    End Function

    Function LoadToolStrip()
        With frmEmployee
            .ToolStripUserName.Text = UCase(My.User.Name.ToString)
            .ToolStripStatusLabel1.Text = "COMPANY:" & frmEmployee.cmbCompanySelection.Selected.ToString
            .Refresh()
        End With
        Return (0)
    End Function

    Function LoadVergoedingenTab()
        With frmEmployee
            Dim Selectedlanguage = My.Settings.SalforceLanguage.ToString

            Select Case Selectedlanguage
                Case "English"
                    If .DGVergoedingen.ColumnCount = 0 Then
                        .DGVergoedingen.Columns.Add("Column0", "YEAR")
                        .DGVergoedingen.Columns.Add("Column1", "PERIOD")
                        .DGVergoedingen.Columns.Add("Column2", "CODE")
                        .DGVergoedingen.Columns.Add("Column3", "DESCRIPTION")
                        .DGVergoedingen.Columns.Add("Column4", "AMOUNT")

                    End If

                    If .DGVergoedingenB.ColumnCount = 0 Then
                        .DGVergoedingenB.Columns.Add("Column0", "YEAR")
                        .DGVergoedingenB.Columns.Add("Column1", "PERIOD")
                        .DGVergoedingenB.Columns.Add("Column2", "CODE")
                        .DGVergoedingenB.Columns.Add("Column3", "DESCRIPTION")
                        .DGVergoedingenB.Columns.Add("Column4", "AMOUNT")

                    End If

                Case "Spanish"
                    If .DGVergoedingen.ColumnCount = 0 Then
                        .DGVergoedingen.Columns.Add("Column0", "ANO")
                        .DGVergoedingen.Columns.Add("Column1", "PERIODO")
                        .DGVergoedingen.Columns.Add("Column2", "CODIGO")
                        .DGVergoedingen.Columns.Add("Column3", "DESCRIPCION")
                        .DGVergoedingen.Columns.Add("Column4", "MONTANTE")

                    End If

                    If .DGVergoedingenB.ColumnCount = 0 Then
                        .DGVergoedingenB.Columns.Add("Column0", "Ano")
                        .DGVergoedingenB.Columns.Add("Column1", "PERIODO")
                        .DGVergoedingenB.Columns.Add("Column2", "CODIGO")
                        .DGVergoedingenB.Columns.Add("Column3", "DESCRIPCION")
                        .DGVergoedingenB.Columns.Add("Column4", "MONTANTE")

                    End If
                   ' .DGVergoedingen.Rows(7).Cells("Column3").Value = "Total No Taxatable"
                Case "Dutch"
                    If .DGVergoedingen.ColumnCount = 0 Then
                        .DGVergoedingen.Columns.Add("Column0", "JAAR")
                        .DGVergoedingen.Columns.Add("Column1", "PERIODE")
                        .DGVergoedingen.Columns.Add("Column2", "CODE")
                        .DGVergoedingen.Columns.Add("Column3", "OMSCHRIJVING")
                        .DGVergoedingen.Columns.Add("Column4", "BEDRAG")

                    End If

                    If .DGVergoedingenB.ColumnCount = 0 Then
                        .DGVergoedingenB.Columns.Add("Column0", "JAAR")
                        .DGVergoedingenB.Columns.Add("Column1", "PERIODE")
                        .DGVergoedingenB.Columns.Add("Column2", "CODE")
                        .DGVergoedingenB.Columns.Add("Column3", "OMSCHRIJVING")
                        .DGVergoedingenB.Columns.Add("Column4", "BEDRAG")

                    End If

            End Select

            .DGVergoedingen.Columns("Column0").Width = 40 'Year
            .DGVergoedingen.Columns("Column1").Width = 50 'Period
            .DGVergoedingen.Columns("Column2").Width = 80 'Code
            .DGVergoedingen.Columns("Column3").Width = 230 'Description
            .DGVergoedingen.Columns("Column4").Width = 60 'Amount

            .DGVergoedingenB.Columns("Column0").Width = 40
            .DGVergoedingenB.Columns("Column1").Width = 50
            .DGVergoedingenB.Columns("Column2").Width = 80
            .DGVergoedingenB.Columns("Column3").Width = 230
            .DGVergoedingenB.Columns("Column4").Width = 60

            .DGVergoedingen.Columns("Column4").DefaultCellStyle.Format = "0.00"
            .DGVergoedingenB.Columns("Column4").DefaultCellStyle.Format = "0.00"

            For I = 1 To 9
                .DGVergoedingen.Rows.Add()
                .DGVergoedingenB.Rows.Add()

            Next I

            .DGVergoedingen.Columns("Column4").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .DGVergoedingenB.Columns("Column4").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .DGVergoedingen.Width = .TabControl.Width / 2
            .DGVergoedingenB.Width = .DGVergoedingen.Width
        End With
        Call LoadAllowance()
        Return (0)

    End Function

    Function SetInitialButtonStates(ByVal FormName As Object)
        Select Case FormName.ToString
            Case "frmEmployeeProfile-Backup"
                If FormName.DataGridView1.RowCount = 0 Then
                    FormName.Button5.Enabled = False
                    FormName.btnDelete.Enabled = False
                    FormName.Button9.Enabled = False
                Else
                    FormName.Button5.Enabled = True
                    FormName.btnDelete.Enabled = False
                End If
        End Select
        Return (0)
    End Function

    Function SkinForm(ByVal FormName As Object)
        Select Case FormName
            Case "frmEmployeeProfileBackup"
                '  Skin("frmEmployeeProfileBackup")
                For Each Control In FormName.Controls
                    Skin(FormName.Control)
                Next

                For Each Control In FormName.TAB01.Controls
                    Skin(FormName.Control)
                Next
                For Each Control In FormName.Tab02.Controls
                    Skin(FormName.Control)
                Next
                For Each Control In FormName.Tab03.Controls
                    Skin(FormName.Control)
                Next
                For Each Control In FormName.Tab04.Controls
                    Skin(FormName.Control)
                Next
                For Each Control In FormName.Tab05.Controls
                    Skin(FormName.Control)
                Next
                For Each Control In FormName.Tab06.Controls
                    Skin(FormName.Control)
                Next
                For Each Control In FormName.Tab07.Controls
                    Skin(FormName.Control)
                Next

                FormName.Refresh()
        End Select

        Return (0)

    End Function

    Function SkinForm()

        For Each ThisControl As System.Windows.Forms.Control In frmEmployee.Controls
            Skin(ThisControl)
        Next ThisControl
        For Each ThisControl As System.Windows.Forms.Control In frmEmployee.TAB01.Controls
            Skin(ThisControl)
        Next ThisControl
        For Each ThisControl As System.Windows.Forms.Control In frmEmployee.TAB02.Controls
            Skin(ThisControl)
        Next ThisControl
        For Each ThisControl As System.Windows.Forms.Control In frmEmployee.TAB03.Controls
            Skin(ThisControl)
        Next ThisControl
        For Each ThisControl As System.Windows.Forms.Control In frmEmployee.TAB04.Controls
            Skin(ThisControl)
        Next ThisControl
        For Each ThisControl As System.Windows.Forms.Control In frmEmployee.TAB05.Controls
            Skin(ThisControl)
        Next ThisControl

    End Function

    Function UpdateEmployeeGridAftersave()
        'This function updates the Employee Datagrid (datagridview1) after a save
        With frmEmployee
            .DataGridMain.SelectedCells(2).Value = UCase(.txtEmployeeFirstName.Text)
            .txtEmployeeFirstName.Text = UCase(.txtEmployeeFirstName.Text)

            .DataGridMain.SelectedCells(3).Value = UCase(.txtemployeeLastName.Text)
            .txtemployeeLastName.Text = UCase(.txtemployeeLastName.Text)

            .DataGridMain.SelectedCells(4).Value = .txtDateBegin.Text
            .DataGridMain.SelectedCells(5).Value = .txtDateEnd.Text
            .DataGridMain.SelectedCells(7).Value = UCase(.txtEmployeefunction.Text)

            .DataGridMain.SelectedCells(8).Value = UCase(.txtEmployeeStatus.Text)
            .txtEmployeeStatus.Text = UCase(.txtEmployeeStatus.Text)

            .Refresh()
        End With
        Return (0)
    End Function

    Private Sub StripItemKindToevoegen_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub

    Private Sub StripItemPrinten_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub

    Private Sub StripItemVerwijder_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub

    Private Sub StripItemVerwijderAlles_Click(ByVal sender As Object, ByVal e As EventArgs)
        'This sub removes all children from an employee from the database
        Dim SelectedCompany, SelectedEmployee As String
        Dim Child As New clsEmpChild
        Dim RecordsRemoved As Integer
        With frmEmployee
            SelectedCompany = .DataGridMain.SelectedCells.Item(0).Value
            SelectedEmployee = .DataGridMain.SelectedCells.Item(1).Value

            Child.RemoveAllEmployeeChild(SelectedCompany, SelectedEmployee)
            .DataGridView2.SelectAll()
            .DataGridView2.ClearSelection()
            .DataGridView2.Refresh()
            RecordsRemoved = Child.DeleteAllEmployeeChildRecordsAffected.ToString
            MsgBox(GetMessageString(1016, "Engish") + RecordsRemoved, vbAbort, Application.ProductName.ToString)
        End With
    End Sub

    Private Sub StripItemVerwijderSelektie_Click(ByVal sender As Object, ByVal e As EventArgs)
        With frmEmployee.DataGridView2
            .ReadOnly = False
            .EditMode = DataGridViewEditMode.EditProgrammatically

            Dim Child As New clsEmpChild
            .ReadOnly = False
            .EditMode = DataGridViewEditMode.EditProgrammatically
            Child.RemoveChild(.SelectedCells(0).Value)
            .Rows.Remove(.CurrentRow)
            'TotalKtoeslag.Text = TotalGridKToeslag()
            .ReadOnly = True
        End With

    End Sub

    Private Sub StripItemWijzigen_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub

    Public Class clsResizeComboBox

        '-------------this piece of code is to resize combo boxes height!-----------
        Public Const CB_SETITEMHEIGHT As Int32 = &H153

        Shared Property Button3 As Object

        Public Declare Auto Function SendMessage Lib "user32.dll" (
    ByVal hwnd As IntPtr,
    ByVal wMsg As Int32,
    ByVal wParam As Int32,
    ByVal lParam As Int32
    ) As Int32

        '-------------this piece of code is to resize combo boxes height!-----------
        Public Sub SetComboEditHeight(
            ByVal Control As ComboBox,
            ByVal NewHeight As Int32
    )
            SendMessage(Control.Handle, CB_SETITEMHEIGHT, -1, NewHeight)
            Control.Refresh()
        End Sub

    End Class

    '  Function CalculateOnkostenVergoeding(ByVal OnkostenType As Single)
    'Onkostentype 1 = Belastbare Onkosten vergoedingen
    'Onkostentype 2 = Onbelastbare Onkosten vergoedingen
    'Dim Total As Double
    'Select Case OnkostenType
    'Case 1
    'With frmEmployee.DGVergoedingenB
    'Total = 0
    'For i = 0 To 6
    'Total = Total + .Rows(i).Cells("Bedrag").Value
    'Next
    'End With
    'Case 2
    'With frmEmployee.DGVergoedingen
    'For i = 0 To 6
    'Total = Total + .Rows(i).Cells("Bedrag").Value
    'Next
    'End With
    'End Select

    'Return Total.ToString("N")
    ' End Function
End Module