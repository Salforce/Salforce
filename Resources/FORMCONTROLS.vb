Imports System.Data.SqlClient
Imports System.IO
Module FORMCONTROLS
    Public Class clsResizeComboBox

        '-------------this piece of code is to resize combo boxes height!-----------
        Public Const CB_SETITEMHEIGHT As Int32 = &H153

        Shared Property Button3 As Object

        Public Declare Auto Function SendMessage Lib "user32.dll" ( _
    ByVal hwnd As IntPtr, _
    ByVal wMsg As Int32, _
    ByVal wParam As Int32, _
    ByVal lParam As Int32 _
    ) As Int32
        '-------------this piece of code is to resize combo boxes height!-----------
        Public Sub SetComboEditHeight( _
            ByVal Control As ComboBox, _
            ByVal NewHeight As Int32 _
    )
            SendMessage(Control.Handle, CB_SETITEMHEIGHT, -1, NewHeight)
            Control.Refresh()
        End Sub
    End Class

    Private Property DBNull As Object

    Function AdjustComboHeights(ByVal Formname As String)
        Dim clscombo As New clsResizeComboBox
        ' Here we can modify the height of this Company comboBox
        clscombo.SetComboEditHeight(frmEmployeeProfileBackup.cmbSelectCompany, 12)
        clscombo.SetComboEditHeight(frmEmployeeProfileBackup.cmbSelectDepartment, 12)
        clscombo.SetComboEditHeight(frmEmployeeProfileBackup.cmbIsland, 12)
        Return (0)
    End Function

    Function LoadCompanyCombo()

        ' ----------------------Company Combobox already loaded, so we skip this-----------------------------
        With frmEmployeeProfileBackup
            If .cmbSelectCompany.Items.Count > 0 Then
                Exit Function
                Return (0)
            End If
        End With
        '--------------------------------------------------------------------------------------------------------------

        Dim COMPID As String
        'Try
        Dim SqlCompanyString As String = "Select COMP_ID, COMP_NAME, COMP_COUNTRY From COMPANYTABLE"
        Dim SalForceConnectionString = My.Settings("NewSalforceConnection")
        Dim Company_Retrievereader As SqlDataReader
        Dim Company_RetrieveCommand As SqlCommand

        Using connection As New SqlConnection(SalForceConnectionString)
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            '---------------------------------------------------------------------------------------

            Company_Retrievereader = Nothing

            'Executing the Queries-------------------------------------------------------------------
            Company_RetrieveCommand = New SqlCommand(SqlCompanyString, connection)
            '-----------------------------------------------------------------------------------------

            'The query results must be stored in a reader to get the data------------------------------
            Company_Retrievereader = Company_RetrieveCommand.ExecuteReader()
            If Not Company_Retrievereader.HasRows Then
                MsgBox("Geen Bedrijven aanwezig in het systeem!", vbAbort, "SALFORCE")
                connection.Close()
                connection.Dispose()
                Return -1
            End If
            With frmEmployeeProfileBackup
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

                    .cmbSelectCompany.Items.Add(UCase(COMPID + "    " + Company_Retrievereader.Item("COMP_NAME").ToString))
                    .ToolStripDropDownButton1.DropDownItems.Add(UCase(COMPID + "    " + Company_Retrievereader.Item("COMP_NAME").ToString))
                End While

                connection.Close()
                connection.Dispose()
                .ToolStripDropDownButton1.AutoSize = True
            End With
        End Using
        'Catch ex As Exception
        ' MsgBox("Fout opgetreden in FORMCONTROLS -> LoadCompanyCombo()" & "->" & Err.Number)

        'Finally

        'End Try
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
                FormName.Refresh()
        End Select

        Return (0)

    End Function
    Function CreateChildrenContextMenu()
        Dim ChildrencontextMenu As New ContextMenuStrip
        Dim StripItemToevoegen As New ToolStripMenuItem
        StripItemToevoegen.Text = "Toevoegen"
        StripItemToevoegen.Tag = "1"
        AddHandler StripItemToevoegen.Click, AddressOf StripItemKindToevoegen_Click
        ChildrencontextMenu.Items.Add(StripItemToevoegen)

        Dim StripItemVerwijder As New ToolStripMenuItem
        StripItemVerwijder.Text = "Verwijder"
        StripItemVerwijder.Tag = "2"
        AddHandler StripItemVerwijder.Click, AddressOf StripItemVerwijder_Click
        ChildrencontextMenu.Items.Add(StripItemVerwijder)

        Dim StripItemWijzigen As New ToolStripMenuItem
        StripItemWijzigen.Text = "Wijzigen"
        StripItemWijzigen.Tag = "3"
        AddHandler StripItemWijzigen.Click, AddressOf StripItemWijzigen_Click
        ChildrencontextMenu.Items.Add(StripItemWijzigen)

        Dim StripItemPrinten As New ToolStripMenuItem
        StripItemPrinten.Text = "Print"
        StripItemPrinten.Tag = "4"
        AddHandler StripItemPrinten.Click, AddressOf StripItemPrinten_Click
        ChildrencontextMenu.Items.Add(StripItemPrinten)

        ' Add a couple of children
        Dim StripItemVerwijderAlles As New ToolStripMenuItem
        StripItemVerwijderAlles.Text = "Verwijder Alles"
        StripItemVerwijderAlles.Tag = "5"
        AddHandler StripItemVerwijderAlles.Click, AddressOf StripItemVerwijderAlles_Click
        StripItemVerwijder.DropDownItems.Add(StripItemVerwijderAlles)

        ' Add a couple of children
        Dim StripItemVerwijderSelektie As New ToolStripMenuItem
        StripItemVerwijderSelektie.Text = "Verwijder Selektie"
        StripItemVerwijderSelektie.Tag = "6"
        AddHandler StripItemVerwijderSelektie.Click, AddressOf StripItemVerwijderSelektie_Click
        StripItemVerwijder.DropDownItems.Add(StripItemVerwijderSelektie)

        ChildrencontextMenu.BackColor = Color.Yellow
        frmEmployeeProfileBackup.DataGridView2.ContextMenuStrip = ChildrencontextMenu
        Return (0)
    End Function
    Private Sub StripItemKindToevoegen_Click(ByVal sender As Object, ByVal e As EventArgs)
        frmAddchild.Show()
    End Sub

    Private Sub StripItemVerwijder_Click(ByVal sender As Object, ByVal e As EventArgs)
        Throw New NotImplementedException
    End Sub

    Private Sub StripItemWijzigen_Click(ByVal sender As Object, ByVal e As EventArgs)
        Throw New NotImplementedException
    End Sub

    Private Sub StripItemPrinten_Click(ByVal sender As Object, ByVal e As EventArgs)
        Throw New NotImplementedException
    End Sub

    Private Sub StripItemVerwijderAlles_Click(ByVal sender As Object, ByVal e As EventArgs)
        'This sub removes all children from an employee from the database
        Dim SelectedCompany, SelectedEmployee As String
        Dim Child As New clsEmpChild
        With frmEmployeeProfileBackup
            SelectedCompany = .DataGridView1.SelectedCells.Item(0).Value.ToString
            SelectedEmployee = .DataGridView1.SelectedCells.Item(1).Value

            Child.RemoveAllEmployeeChild(SelectedCompany, SelectedEmployee)
            .DataGridView2.SelectAll()
            .DataGridView2.ClearSelection()
            .DataGridView2.Refresh()
            MsgBox(Child.DeleteAllEmployeeChildRecordsAffected.ToString & " Kind(eren) verwijderd!")
        End With
    End Sub

    Private Sub StripItemVerwijderSelektie_Click(ByVal sender As Object, ByVal e As EventArgs)
        With frmEmployeeProfileBackup.DataGridView2
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
    Function UpdateEmployeeGridAftersave()
        'This function updates the Employee Datagrid (datagridview1) after a save
        With frmEmployeeProfileBackup
            .DataGridView1.SelectedCells(2).Value = UCase(.txtEmployeeFirstName.Text)
            .txtEmployeeFirstName.Text = UCase(.txtEmployeeFirstName.Text)

            .DataGridView1.SelectedCells(3).Value = UCase(.txtemployeeLastName.Text)
            .txtemployeeLastName.Text = UCase(.txtemployeeLastName.Text)

            .DataGridView1.SelectedCells(4).Value = .txtDateBegin.Text
            .DataGridView1.SelectedCells(5).Value = .txtDateEnd.Text
            .DataGridView1.SelectedCells(7).Value = UCase(.txtEmployeefunction.Text)

            .DataGridView1.SelectedCells(8).Value = UCase(.txtEmployeeStatus.Text)
            .txtEmployeeStatus.Text = UCase(.txtEmployeeStatus.Text)

            .Refresh()
        End With
        Return (0)
    End Function
    Function LoadDepartmentcombo(ByVal CompanyNr As Integer)
        If frmEmployeeProfileBackup.cmbSelectDepartment.Items.Count > 0 Then
            Exit Function
        End If

        Dim DEP_RetrieveString, SalForceConnectionString As String
        Dim DEP_Retrievereader As SqlDataReader
        Dim DEP_RetrieveCommand As SqlCommand

        SalForceConnectionString = My.Settings("NewSalForceConnection")
        Using connection As New SqlConnection(SalForceConnectionString)
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            DEP_RetrieveString = "Select DEP_COMP,DEP_NR, DEPNAME From DEPARTMENTS WHERE DEP_COMP = " & CompanyNr
            DEP_Retrievereader = Nothing

            'Executing the Queries-------------------------------------------------------------------
            DEP_RetrieveCommand = New SqlCommand(DEP_RetrieveString, connection)
            '-----------------------------------------------------------------------------------------

            'The query results must be stored in a reader to get the data------------------------------
            DEP_Retrievereader = DEP_RetrieveCommand.ExecuteReader()
            '-----------------------------------------------------------------------------------------

            If DEP_Retrievereader.HasRows Then

                While DEP_Retrievereader.Read()
                    frmEmployeeProfileBackup.cmbSelectDepartment.Items.Add(UCase(DEP_Retrievereader("DEPNAME").ToString))
                End While
            End If
            connection.Close()
            connection.Dispose()

        End Using

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
    Function LoadPartnerAndKids()
        DisablePartnerTab()
        Dim EmployeeData As New EMPLOYEE
        Dim EmployeeStructure As EMPSTRUCTURE
        Dim EMPCOMP, EMPID As Integer

        'Here we are selecting the Employee of an existing Company to load
        With frmEmployeeProfileBackup.DataGridView1.SelectedCells
            EMPCOMP = Convert.ToInt16(.Item(0).Value)
            EMPID = Convert.ToInt16(.Item(1).Value)
            '---------------------------------------------------------------------
            EmployeeStructure = EmployeeData.Retrieve_Employee_Data(EMPCOMP, EMPID)

            With frmEmployeeProfileBackup
                .txtPartnerLastname.Text = ""
                .txtPartnerFirstname.Text = ""
                .txtPartnerMidname.Text = ""
                .txtPartnerBirthDate.Text = ""
                .txtPartnerBelInkomen.Text = ""

                .txtPartnerLastname.Text = UCase(EmployeeStructure.PartnerLastName)
                .txtPartnerFirstname.Text = UCase(EmployeeStructure.PartnerFirstname)
                .txtPartnerMidname.Text = UCase(EmployeeStructure.PartnerMidName)
                .txtPartnerBirthDate.Text = ConvertDateToSalforceDate(EmployeeStructure.PartnerBirthdate)

                If EmployeeStructure.PartnerBelInkomen = "" Then
                    .txtPartnerBelInkomen.Text = Format(0, "N")
                Else
                    .txtPartnerBelInkomen.Text = Format(Convert.ToDouble(EmployeeStructure.PartnerBelInkomen), "N")
                End If

                Dim Child As New CHILDREN
                Child.FillChildGrid(EMPCOMP, EMPID)

            End With

        End With
        CreateChildrenContextMenu()
    End Function

    

    Function LoadEmployeeDataGrid(ByVal SelectedCompany As Integer) 'This function load ALL Employees of the selected COMPANY in the DataGrid (DatagridView1)
        Dim CURRENTCOMPANY As Integer
        Dim SalForceConnectionString As String
        Dim Positie As Integer = 10

        If Len(CURRENTCOMPANY) = 0 Then
            Return (0)
            Exit Function
        End If

        With frmEmployeeProfileBackup
            .ToolStripProgressBar1.Visible = True
            .DataGridView1.RowCount = 0
            SalForceConnectionString = My.Settings("NewSalForceConnection")
            Using Connection As New SqlConnection(SalForceConnectionString)
                If Connection.State = ConnectionState.Closed Then
                    Connection.Open()
                End If

                Dim EMP_RetrieveCommand, EMP_CountCommand, Islandcommand As SqlCommand
                Dim EMP_RetrieveString, EMP_CountString, Islandstring As String

                Dim EMP_Retrievereader, IslandReader, EMP_CountReader As SqlDataReader
                Dim TotalRecords As Long = 0

                EMP_RetrieveString = "Select * From EMPTABLE WHERE EMP_COMPID =" & SelectedCompany & " ORDER BY EMP_COMPID, EMP_EMPLOYEENR"
                EMP_CountString = "Select Count(EMP_COMPID) As TotalEmployee From EMPTABLE WHERE EMP_COMPID =" & SelectedCompany
                Islandstring = "Select * from COMPANYTABLE where COMP_ID =" & SelectedCompany

                EMP_RetrieveCommand = New SqlCommand(EMP_RetrieveString, Connection)
                EMP_CountCommand = New SqlCommand(EMP_CountString, Connection)
                Islandcommand = New SqlCommand(Islandstring, Connection)

                IslandReader = Islandcommand.ExecuteReader
                IslandReader.Close()

                IslandReader = Islandcommand.ExecuteReader()

                If IslandReader.HasRows Then
                    IslandReader.Read()
                    .StatusLabel_COUNTRY.Text = Trim(IslandReader.Item("COMP_COUNTRY").ToString)
                    IslandReader.Close()
                Else
                    .StatusLabel_COUNTRY.Text = "NO DATA"
                    IslandReader.Close()
                    Connection.Dispose()
                    Connection.Close()
                    Return -1
                End If

                EMP_Retrievereader = EMP_RetrieveCommand.ExecuteReader()
                EMP_Retrievereader.Close()

                EMP_CountReader = EMP_CountCommand.ExecuteReader()
                EMP_CountReader.Read()
                If EMP_CountReader.HasRows Then
                    .ToolStripProgressBar1.Minimum = 0
                    .ToolStripProgressBar1.Maximum = CInt(EMP_CountReader(0).ToString)
                    EMP_CountReader.Close()
                Else
                    MsgBox("Geen Data voor employee")
                    EMP_CountReader.Close()
                    Connection.Dispose()
                    Connection.Close()
                    Return -1
                End If

                With .DataGridView1.Columns
                    .Add("COMPNR", "COMPNR")
                    .Add("EMPNR", "EMPNR")
                    .Add("NAAM", "NAAM")
                    .Add("ACHTERNAAM", "ACHTERNAAM")
                    .Add("START", "START")
                    .Add("EIND", "EIND")
                    .Add("DEPNR", "DEPNR")
                    .Add("FUNCTIE", "FUNCTIE")
                    .Add("STATUS", "STATUS")
                End With

                .ToolStripProgressBar1.Step = 1

                EMP_Retrievereader = EMP_RetrieveCommand.ExecuteReader()

                If EMP_Retrievereader.HasRows Then
                    Dim Rowcount As Integer = 0

                    While EMP_Retrievereader.Read() = True

                        With .DataGridView1
                            .Rows.Add()
                            .Rows(Rowcount).Cells("COMPNR").Value = EMP_Retrievereader.Item("EMP_COMPID").ToString()
                            .Rows(Rowcount).Cells("EMPNR").Value = EMP_Retrievereader.Item("EMP_EMployeeNr").ToString()
                            .Rows(Rowcount).Cells("NAAM").Value = EMP_Retrievereader.Item("EMP_FIRSTNAME").ToString()
                            .Rows(Rowcount).Cells("ACHTERNAAM").Value = EMP_Retrievereader.Item("EMP_LASTNAME").ToString()
                            .Rows(Rowcount).Cells("DEPNR").Value = EMP_Retrievereader.Item("EMP_DEPARTMENT").ToString()
                            .Rows(Rowcount).Cells("FUNCTIE").Value = EMP_Retrievereader.Item("EMP_POSITION").ToString()
                            .Rows(Rowcount).Cells("STATUS").Value = EMP_Retrievereader.Item("EMP_STATUS").ToString()
                            .Rows(Rowcount).Cells("START").Value = EMP_Retrievereader.Item("EMP_STARTDATE").ToString
                            .Rows(Rowcount).Cells("EIND").Value = EMP_Retrievereader.Item("EMP_ENDDATE").ToString

                            Rowcount = Rowcount + 1

                        End With

                        .ToolStripProgressBar1.Step = 1
                        .ToolStripProgressBar1.PerformStep()

                    End While
                    With .DataGridView1
                        .Columns(0).Width = 60
                        .Columns(1).Width = 60
                        .Columns(2).Width = 100
                        .Columns(3).Width = 150
                        .Columns(4).Width = 80
                        .Columns(5).Width = 80
                        .Columns(6).Width = 60
                        .Columns(7).Width = 180
                        .Columns(8).Width = 53
                        .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    End With
                End If

                Connection.Dispose()
                Connection.Close()
            End Using

            .btnEdit.Enabled = True
            .ToolStripProgressBar1.Value = 0
            .ToolStripProgressBar1.Visible = False
            LoadToolStrip()
            LoadDepartmentcombo(SelectedCompany)
        End With
    End Function
    Function LoadVergoedingenTAB()
        With frmEmployeeProfileBackup
            If .DGVergoedingen.ColumnCount = 0 Then
                .DGVergoedingen.Columns.Add("CODE", "CODE")
                .DGVergoedingen.Columns.Add("OMSCHRIJVING", "OMSCHRIJVING")
                .DGVergoedingen.Columns.Add("BEDRAG", "BEDRAG")
            End If

            If .DGVergoedingenB.ColumnCount = 0 Then
                .DGVergoedingenB.Columns.Add("CODE", "CODE")
                .DGVergoedingenB.Columns.Add("OMSCHRIJVING", "OMSCHRIJVING")
                .DGVergoedingenB.Columns.Add("BEDRAG", "BEDRAG")
            End If
            .DGVergoedingen.Columns(0).Width = 80
            .DGVergoedingen.Columns(1).Width = 240
            .DGVergoedingen.Columns(2).Width = 84

            .DGVergoedingenB.Columns(0).Width = 80
            .DGVergoedingenB.Columns(1).Width = 240
            .DGVergoedingenB.Columns(2).Width = 84

            .DGVergoedingen.Columns(2).DefaultCellStyle.Format = "0.00"
            .DGVergoedingen.Columns(2).ValueType = GetType(System.Decimal)

            .DGVergoedingenB.Columns(2).DefaultCellStyle.Format = "0.00"
            .DGVergoedingenB.Columns(2).ValueType = GetType(System.Decimal)

            For I = 1 To 8
                .DGVergoedingen.Rows.Add()
                .DGVergoedingenB.Rows.Add()
            Next I

            .DGVergoedingen.Columns("Bedrag").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .DGVergoedingenB.Columns("Bedrag").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .DGVergoedingen.Rows(7).Cells("OMSCHRIJVING").Value = "Totaal Onbelaste Onkostenvergoedingen"
            .DGVergoedingenB.Rows(7).Cells("OMSCHRIJVING").Value = "Totaal Belaste OnkostenVergoedingen"

            .DGVergoedingen.Rows(7).Cells("Omschrijving").ReadOnly = True
            .DGVergoedingenB.Rows(7).Cells("Omschrijving").ReadOnly = True

            .DGVergoedingen.Rows(7).Cells("Bedrag").ReadOnly = True
            .DGVergoedingenB.Rows(7).Cells("Bedrag").ReadOnly = True

            .DGVergoedingen.Rows(7).Cells("Code").ReadOnly = True
            .DGVergoedingenB.Rows(7).Cells("Code").ReadOnly = True
        End With
        Call LoadVergoedingen()
        Return (0)

    End Function

    Function LoadBerekeningTab()
        With frmEmployeeProfileBackup
            If .DGBerekening.ColumnCount = 0 Then

                .DGBerekening.Columns.Add("SalarisItem", "")
                .DGBerekening.Columns.Add("DED-1", "")
                .DGBerekening.Columns.Add("CRED-1", "")
                .DGBerekening.Columns.Add("SPC", "")
                .DGBerekening.Columns.Add("SalarisItem2", "")
                .DGBerekening.Columns.Add("DED-2", "")
                .DGBerekening.Columns.Add("CRED-2", "")

                For I = 1 To 10
                    .DGBerekening.Rows.Add()
                Next I
                .DGBerekening.Columns(0).Width = 240
                .DGBerekening.Columns(1).Width = 80
                .DGBerekening.Columns(2).Width = 84
                .DGBerekening.Columns(3).Width = 5

                .DGBerekening.Columns(4).Width = 240
                .DGBerekening.Columns(5).Width = 80
                .DGBerekening.Columns(6).Width = 86

                .DGBerekening.Columns("CRED-1").DefaultCellStyle.Format = "0.00"
                .DGBerekening.Columns("CRED-1").ValueType = GetType(System.Decimal)
                .DGBerekening.Columns("CRED-1").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight

                .DGBerekening.Columns("CRED-2").DefaultCellStyle.Format = "0.00"
                .DGBerekening.Columns("CRED-2").ValueType = GetType(System.Decimal)
                .DGBerekening.Columns("CRED-2").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight

                .DGBerekening.Columns("DED-1").DefaultCellStyle.Format = "0.00"
                .DGBerekening.Columns("DED-1").ValueType = GetType(System.Decimal)
                .DGBerekening.Columns("DED-1").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight

                .DGBerekening.Columns("DED-2").DefaultCellStyle.Format = "0.00"
                .DGBerekening.Columns("DED-2").ValueType = GetType(System.Decimal)
                .DGBerekening.Columns("DED-2").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight

                .DGBerekening.Rows(0).Cells("SalarisItem").Value = "Totaal Inkomen"
                .DGBerekening.Rows(1).Cells("SalarisItem").Value = "Verwervingskosten"
                .DGBerekening.Rows(2).Cells("SalarisItem").Value = "Pensioen Fonds"
                .DGBerekening.Rows(3).Cells("SalarisItem").Value = "Beschikking Insp"
                .DGBerekening.Rows(4).Cells("SalarisItem").Value = "ZOG Premie"
                .DGBerekening.Rows(5).Cells("SalarisItem").Value = "Grondslag AOV/AWW/AWBZ"
                .DGBerekening.Rows(6).Cells("SalarisItem").Value = "WN-Bijdrage AOV/AWW"
                .DGBerekening.Rows(7).Cells("SalarisItem").Value = "WN-Bijdrage AVBZ"
                .DGBerekening.Rows(8).Cells("SalarisItem").Value = "Basis Verzekering"
                .DGBerekening.Rows(9).Cells("SalarisItem").Value = "Grondslag LB voor Tabel"

                .DGBerekening.Rows(0).Cells("SalarisItem2").Value = "Loon Belasting"
                .DGBerekening.Rows(1).Cells("SalarisItem2").Value = "Basis Korting"
                .DGBerekening.Rows(2).Cells("SalarisItem2").Value = "Alleen Verdiener Toeslag"
                .DGBerekening.Rows(3).Cells("SalarisItem2").Value = "Kinderen Toeslag"
                .DGBerekening.Rows(4).Cells("SalarisItem2").Value = "Ouderen Toeslag"
                .DGBerekening.Rows(5).Cells("SalarisItem2").Value = "Overdraagbare Ouderen Toeslag"
                .DGBerekening.Rows(6).Cells("SalarisItem2").Value = "Te Betalen Belasting"
                .DGBerekening.Rows(8).Cells("SalarisItem2").Value = "SVB"

            End If

            Dim EmployeeData As New EMPLOYEE
            Dim EmployeeStructure As EMPSTRUCTURE

            Dim EMPID As Integer = Convert.ToInt16(frmEmployeeProfileBackup.txtEmployeeNr.Text)
            Dim EMPCOMP As Integer = Convert.ToInt16(frmEmployeeProfileBackup.txtCompanyNr.Text)

            EmployeeStructure = EmployeeData.Retrieve_Employee_Data(EMPCOMP, EMPID)

            Dim Employee As New EMPLOYEE
            Dim EmployeeID As Integer = Convert.ToInt16(.txtEmployeeNr.Text)
            Dim EMployeeCompany As Integer = Convert.ToInt16(.txtCompanyNr.Text)

            '-----------------------------------------------TOTAAL INKOMEN-----------------------------------------------
            .DGBerekening.Rows(0).Cells("CRED-1").Value = Format(EmployeeStructure.TotalYearIncome, "N")
            '----------------------------------------------TOTAAL INKOMEN------------------------------------------------

            '----------------------------------------------VERWERVINGSKOSTEN-----------------------------------------
            .DGBerekening.Rows(1).Cells("DED-1").Value = Format(-CONSTANT_VERWERVINGSKOSTEN, "N")
            '----------------------------------------------VERWERVINGSKOSTEN-------------------------------------------

            '----------------------------------------------PENSIOENFONDS----------------------------------------------------
            .DGBerekening.Rows(2).Cells("DED-1").Value = Format(-EmployeeStructure.PensionFonds, "N")
            '----------------------------------------------PENSIOENFONDS------------------------------------------------------

            '---------------------------------------------BESCHIKKING INSPECTIE-------------------------------------------
            .DGBerekening.Rows(3).Cells("DED-1").Value = Format(-EmployeeStructure.Beschikking, "N")
            '---------------------------------------------BESCHIKKING INSPECTIE-------------------------------------------

            '---------------------------------------------ZOG PREMIE-----------------------------------------------------------
            '            Premiebetaling()
            'Voor overheidsdienaren en daarmee gelijkgestelden zijn in het PB 1986 no: 165 drie onderverdelingen m.b.t. premiebetaling gemaakt:

            '• De overheidsdienaar of hiermee gelijkgestelde die maximaal NAf. 10.260,- per jaar verdient, heeft recht op vrije geneeskundige behandeling
            ' voor zich persoonlijk. Deze categorie betaalt in principe geen premie (schaal 0).
            '• De overheidsdienaar of hiermee gelijkgestelde die in schaal 1 t/m 5 valt of een brutoloon heeft van minder dan Naf 2.163,-
            'heeft voor zich persoonlijk recht op vrije geneeskundige behandeling. Deze categorie betaalt 1% premie over het brutoloon.
            '• De overheidsdienaar of hiermee gelijkgestelde die in schaal 6 en hoger valt of een brutoloon heeft die gelijk of hoger is dan NAf 2.163,-
            'heeft recht  op 90 procent vergoeding. Deze categorie betaalt afhankelijk van het brutoloon 1.05%, 1.15% of 1.25% premie hierover.

            Select Case EmployeeStructure.Year_Salary
                Case Is <= 10260 / CONSTANT_MONTHS_IN_YEAR
                    .DGBerekening.Rows(4).Cells("DED-1").Value = "0.00"

            End Select

            .DGBerekening.Rows(4).Cells("DED-1").Value = Format(EmployeeStructure.ZogPremie, "N")
            '---------------------------------------------ZOG PREMIE-----------------------------------------------------------

            '----------------------------------------------GRONDSLAG AOVAWW-----------------------------------------------
            .DGBerekening.Rows(5).Cells("CRED-1").Value = Format(EmployeeStructure.GrondslagAOVAWWAVBZ, "N")
            '----------------------------------------------GRONDSLAG AOVAWW------------------------------------------------

            '----------------------------------------------EMPLOYEE AOVAWW--------------------------------------------------
            .DGBerekening.Rows(6).Cells("DED-1").Value = Format(-EmployeeStructure.AOV_Amount, "N")
            .DGBerekening.Rows(6).Cells("CRED-1").Value = Format(EmployeeStructure.AOV_Amount, "N")
            .DGBerekening.Rows(6).Cells("SalarisItem").Value = "WN-Bijdrage AOV/AWW" & "    " & EmployeeStructure.AOV_Percentage_Employee & "%"
            '----------------------------------------------EMPLOYEE AOVAWW--------------------------------------------------

            '----------------------------------------------EMPLOYEE AVBZ----------------------------------------------------------
            .DGBerekening.Rows(7).Cells("DED-1").Value = Format(-EmployeeStructure.AVBZ_Amount, "N")
            .DGBerekening.Rows(7).Cells("DED-1").Value = Format(EmployeeStructure.AVBZ_Amount, "N")
            .DGBerekening.Rows(7).Cells("SalarisItem").Value = "WN-Bijdrage AVBZ        " & "    " & EmployeeStructure.AVBZ_Percentage & "%"
            '---------------------------------------------EMPLOYEE AVBZ------------------------------------------------------------

            '---------------------------------------------EMPLOYEE BASIS VERZEKERING---------------------------------------------------------
            .DGBerekening.Rows(8).Cells("DED-1").Value = Format(-EmployeeStructure.BasisVerzekering_Amount, "N")
            .DGBerekening.Rows(8).Cells("SalarisItem").Value = "Basis Verzekering           " & "    " & EmployeeStructure.BasisVerzekering_Percentage & "%"
            '--------------------------------------------EMPLOYEE BASIS VERZEKERING------------------------------------------------------------

            '-------------------------------GRONDSLAG VOOR LB---------------------------------

            .DGBerekening.Rows(9).Cells("CRED-1").Value = Format(EmployeeStructure.GrondslagLoonBelasting, "N")
            '-------------------------------GRONDSLAG VOOR LB---------------------------------

            '-------------------------------LOONBELASTING---------------------------------
            .DGBerekening.Rows(0).Cells("CRED-2").Value = Format(EmployeeStructure.LoonBelasting, "N")
            '-------------------------------LOONBELASTING---------------------------------

            ''-------------------------------BASISKORTING---------------------------------
            .DGBerekening.Rows(1).Cells("DED-2").Value = -CONSTANT_BASIS_KORTING
            ''-------------------------------BASISKORTING---------------------------------

            '-------------------------------ALLEEN VERDIENNER TOESLAG---------------------------------
            .DGBerekening.Rows(2).Cells("DED-2").Value = Format(EmployeeStructure.AlleenVerdienerToeslag, "N")
            '-------------------------------ALLEEN VERDIENNER TOESLAG---------------------------------

            '-------------------------------KINDERTOESLAG---------------------------------
            .DGBerekening.Rows(3).Cells("DED-2").Value = Format(EmployeeStructure.KinderToeslag, "N")
            '-------------------------------KINDERTOESLAG---------------------------------

            '-------------------------------OUDEREN TOESLAG---------------------------------
            .DGBerekening.Rows(4).Cells("DED-2").Value = Format(EmployeeStructure.OuderenToeslag, "N")
            '-------------------------------OUDEREN TOESLAG---------------------------------

            '-------------------------------OVERDRAGBAAR OUDEREN TOESLAG---------------------------------
            .DGBerekening.Rows(5).Cells("DED-2").Value = 0
            '-------------------------------OVERDRAGBAAR OUDEREN TOESLAG---------------------------------

            '-------------------------------TE BETALEN BELASTING---------------------------------
            .DGBerekening.Rows(6).Cells("CRED-2").Value = Format(EmployeeStructure.TeBetalenBelasting, "N")
            '-------------------------------TE BETALEN BELASTING---------------------------------

            ''-------------------------------SVB PREMIE---------------------------------
            'Dim SVB As String = .txtSVB_Amount.Text
            '.DGBerekening.Rows(8).Cells("DED-2").Value = -SVB
            ''-------------------------------SVB PREMIE---------------------------------

            .DGBerekening.RefreshEdit()
        End With
        Return (0)
    End Function
    Function SaveBelastingVariabelenToFile()
        'This function save the Belasting Variabelen tab to a file

        'Lets get the dimension of the grid

        Dim TotalRows As Byte = frmEmployeeProfileBackup.DGBelVariabelen.RowCount
        Dim TotalColumns As Byte = frmEmployeeProfileBackup.DGBelVariabelen.ColumnCount

        Dim fs As New FileStream("SALFBELDATA.BIN", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim bw As New BinaryWriter(fs)

        'Lets define the array to hold the whole grid
        Dim GridArray(TotalRows, TotalColumns) As String
        Dim RowCounter As Byte = 0
        Dim ColumnCounter As Byte = 0

        While RowCounter <= TotalRows
            ColumnCounter = 0
            While ColumnCounter <= TotalColumns
                If IsNothing(frmEmployeeProfileBackup.DGBelVariabelen.Rows(RowCounter).Cells(ColumnCounter).Value) Then
                    frmEmployeeProfileBackup.DGBelVariabelen.Rows(RowCounter).Cells(ColumnCounter).Value = ""
                End If

                GridArray(RowCounter, ColumnCounter) = frmEmployeeProfileBackup.DGBelVariabelen.Rows(RowCounter).Cells(ColumnCounter).Value
                ColumnCounter = ColumnCounter + 1
            End While
            RowCounter = RowCounter + 1
        End While

        'bw.Write(GridArray(TotalRows, TotalColumns))
        MsgBox("Ready")
        bw.Close()
        fs.Close()
        Return (0)

    End Function
    Function LoadBelvariabelentab()

        If frmEmployeeProfileBackup.DGBelVariabelen.ColumnCount = 0 Then
            With frmEmployeeProfileBackup.DGBelVariabelen
                .Columns.Add("BELASTING", "")
                .Columns.Add("WAARDE", "")
                .Columns.Add("SPC", "")
                .Columns.Add("BELASTING2", "")
                .Columns.Add("WAARDE2", "")
                .Columns.Add("SPC2", "")
                .Columns.Add("BELASTING3", "")
                .Columns.Add("WAARDE3", "")
                .Columns.Add("SPC3", "")
                .Columns.Add("BELASTING4", "")

                For I = 1 To 10
                    .Rows.Add()
                Next I

                .Columns(0).Width = 100
                .Columns(1).Width = 80
                .Columns(2).Width = 10
                .Columns(3).Width = 118
                .Columns(4).Width = 80
                .Columns(5).Width = 10
                .Columns(6).Width = 130
                .Columns(7).Width = 80
                .Columns(8).Width = 10
                .Columns(9).Width = 100

                .Columns("WAARDE").DefaultCellStyle.Format = "N"
                .Columns("WAARDE").ValueType = GetType(System.Decimal)
                .Columns("WAARDE").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight

                .Columns("WAARDE2").DefaultCellStyle.Format = "N"
                .Columns("WAARDE2").ValueType = GetType(System.Decimal)
                .Columns("WAARDE2").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight

                .Columns("WAARDE3").DefaultCellStyle.Format = "N"
                .Columns("WAARDE3").ValueType = GetType(System.Decimal)
                .Columns("WAARDE3").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight

                .Rows(0).Cells("BELASTING").Value = "AOV"
                .Rows(1).Cells("BELASTING").Value = "Werkgever % "
                .Rows(2).Cells("BELASTING").Value = "Werknemer %"
                .Rows(3).Cells("BELASTING").Value = "Inkomengrens "
                .Rows(4).Cells("BELASTING").Value = "Kortings %"

                .Rows(6).Cells("BELASTING").Value = "AWW "
                .Rows(7).Cells("BELASTING").Value = "Werkgever % "
                .Rows(8).Cells("BELASTING").Value = "Werknemer % "

                .Rows(1).Cells("WAARDE").Value = 7
                .Rows(2).Cells("WAARDE").Value = 6
                .Rows(3).Cells("WAARDE").Value = 93000
                .Rows(4).Cells("WAARDE").Value = 33.8

                .Rows(7).Cells("WAARDE").Value = 0.5
                .Rows(8).Cells("WAArDE").Value = 0.5

                .Rows(0).Cells("BELASTING2").Value = "SVB (ZV)"
                .Rows(1).Cells("BELASTING2").Value = "Werkgever % "
                .Rows(2).Cells("BELASTING2").Value = "Werknemer %"
                .Rows(3).Cells("BELASTING2").Value = "Loongrens"

                .Rows(1).Cells("WAARDE2").Value = 8.3
                .Rows(2).Cells("WAARDE2").Value = 2.1
                .Rows(3).Cells("WAARDE2").Value = 59654.4

                .Rows(0).Cells("BELASTING3").Value = "BVZ"
                .Rows(1).Cells("BELASTING3").Value = "Werkgever % "
                .Rows(2).Cells("BELASTING3").Value = "Werknemer % "
                .Rows(3).Cells("BELASTING3").Value = "Vrijstelling Inkomen <"
                .Rows(4).Cells("BELASTING3").Value = "Nominale Premie p/j"

                .Rows(1).Cells("WAARDE3").Value = 9.0
                .Rows(2).Cells("WAARDE3").Value = 3.0
                .Rows(3).Cells("WAARDE3").Value = 1000
                .Rows(4).Cells("WAARDE3").Value = 82

                .Rows(1).Cells("WAARDE").Style.BackColor = Color.Beige

                Dim BelastingData(5, 3) As Double
                BelastingData = ReadXMLData_BelastingTabel("Curacao", "2012")

                ' .Rows(1).Cells("WERKNEMER").Value = BelastingData(1, 1)
                '.Rows(2).Cells("SalarisItem").Value = "Pensioen Fonds"
                '.Rows(3).Cells("SalarisItem").Value = "Beschikking Insp"
                '.Rows(4).Cells("SalarisItem").Value = "ZOG Premie"
                '.Rows(5).Cells("SalarisItem").Value = "Grondslag AOV/AWW/AWBZ"
                '.Rows(6).Cells("SalarisItem").Value = "WN-Bijdrage AOV/AWW"
                '.Rows(7).Cells("SalarisItem").Value = "WN-Bijdrage AVBZ"
                '.Rows(8).Cells("SalarisItem").Value = "ZV SVB"
                '.Rows(9).Cells("SalarisItem").Value = "Grondslag LB voor Tabel"

                '.Rows(0).Cells("SalarisItem2").Value = "Loon Belasting"
                '.Rows(1).Cells("SalarisItem2").Value = "Basis Korting"
                '.Rows(2).Cells("SalarisItem2").Value = "Alleen Verdiener Toeslag"
                '.Rows(3).Cells("SalarisItem2").Value = "Kinderen Toeslag"
                '.Rows(4).Cells("SalarisItem2").Value = "Ouderen Toeslag"
                '.Rows(5).Cells("SalarisItem2").Value = "Overdraagbare Ouderen Toeslag"
                '.Rows(6).Cells("SalarisItem2").Value = "Te Betalen Belasting"
                '.Rows(8).Cells("SalarisItem2").Value = "SVB"
            End With
        End If
    End Function
    Function LoadEmpBelasting()
        ' DisableBelastingtab()
        Dim EmployeeData As New EMPLOYEE
        Dim SelectedCompany, SelectedEmployee As Integer
        Dim EmployeeStructure As EMPSTRUCTURE

        'Here we are selecting the Employee of an existing Company to load
        With frmEmployeeProfileBackup
            SelectedCompany = .DataGridView1.SelectedCells.Item(0).Value
            SelectedEmployee = .DataGridView1.SelectedCells.Item(1).Value
            '---------------------------------------------------------------------

            With .cmbPeriod
                '--------------------------------------------------------------------------LOAD PERIOD COMBO WITH VALUES --------------------------------------------------
                If .Items.Count = 0 Then
                    .Items.Add("Jaar")
                    .Items.Add("Maand")
                    .Items.Add("Kwartaal")
                    .Items.Add("Week")
                    .Items.Add("Dag")
                    .Items.Add("Halve dag")
                End If
                '--------------------------------------------------------------------------LOAD PERIOD COMBO WITH VALUES --------------------------------------------------
            End With

            '---------------------------------------------------------------LOAD FORM TEXTFIELDS -----------------------------------------------------------------------------------

            EmployeeStructure = EmployeeData.Retrieve_Employee_Data(SelectedCompany, SelectedEmployee)

            Select Case EmployeeStructure.Salary_Pay_Period
                Case 0
                    .txtAOVAWW_PERC.Text = EmployeeStructure.AOV_Percentage_Employee
                    .txtAOV_AWW.Text = Format(EmployeeStructure.AOV_Amount, "N")

                    .txtBVZ_PERC.Text = EmployeeStructure.BasisVerzekering_Percentage
                    .txtBVZ_Amount.Text = Format(EmployeeStructure.BasisVerzekering_Percentage * EmployeeStructure.BasisVerzekering_Amount, "N")

                    .txtAVBZ_PERC.Text = EmployeeStructure.AVBZ_Percentage
                    .txtAVBZ_AMOUNT.Text = Format(EmployeeStructure.AVBZ_Amount, "N")
                    .txtZV_PERC.Text = EmployeeStructure.ZV_Percentage
                    .txtZV_Amount.Text = Format(EmployeeStructure.ZV_Amount, "N")

                Case 1
                    .txtAOVAWW_PERC.Text = EmployeeStructure.AOV_Percentage_Employee
                    .txtAOV_AWW.Text = Format(EmployeeStructure.AOV_Amount / CONSTANT_QUARTS_IN_YEAR, "N")

                    .txtBVZ_PERC.Text = EmployeeStructure.BasisVerzekering_Percentage
                    .txtBVZ_Amount.Text = Format((EmployeeStructure.BasisVerzekering_Percentage * EmployeeStructure.BasisVerzekering_Amount) / CONSTANT_QUARTS_IN_YEAR, "N")

                    .txtAVBZ_PERC.Text = EmployeeStructure.AVBZ_Percentage
                    .txtAVBZ_AMOUNT.Text = Format(EmployeeStructure.AVBZ_Amount / CONSTANT_QUARTS_IN_YEAR, "N")

                    .txtZV_PERC.Text = EmployeeStructure.ZV_Percentage
                    .txtZV_Amount.Text = Format(EmployeeStructure.ZV_Amount / CONSTANT_QUARTS_IN_YEAR, "N")
                Case 2
                    .txtAOVAWW_PERC.Text = EmployeeStructure.AOV_Percentage_Employee
                    .txtAOV_AWW.Text = Format(EmployeeStructure.AOV_Amount / CONSTANT_MONTHS_IN_YEAR, "N")

                    .txtBVZ_PERC.Text = EmployeeStructure.BasisVerzekering_Percentage
                    .txtBVZ_Amount.Text = Format((EmployeeStructure.BasisVerzekering_Percentage * EmployeeStructure.BasisVerzekering_Amount) / CONSTANT_MONTHS_IN_YEAR, "N")

                    .txtAVBZ_PERC.Text = EmployeeStructure.AVBZ_Percentage
                    .txtAVBZ_AMOUNT.Text = Format(EmployeeStructure.AVBZ_Amount / CONSTANT_MONTHS_IN_YEAR, "N")

                    .txtZV_PERC.Text = EmployeeStructure.ZV_Percentage
                    .txtZV_Amount.Text = Format(EmployeeStructure.ZV_Amount / CONSTANT_MONTHS_IN_YEAR, "N")
                Case 3
                    .txtAOVAWW_PERC.Text = EmployeeStructure.AOV_Percentage_Employee
                    .txtAOV_AWW.Text = Format(EmployeeStructure.AOV_Amount / CONSTANT_WEEKS_IN_YEAR, "N")

                    .txtBVZ_PERC.Text = EmployeeStructure.BasisVerzekering_Percentage
                    .txtBVZ_Amount.Text = Format((EmployeeStructure.BasisVerzekering_Percentage * EmployeeStructure.BasisVerzekering_Amount) / CONSTANT_WEEKS_IN_YEAR, "N")

                    .txtAVBZ_PERC.Text = EmployeeStructure.AVBZ_Percentage
                    .txtAVBZ_AMOUNT.Text = Format(EmployeeStructure.AVBZ_Amount / CONSTANT_WEEKS_IN_YEAR, "N")

                    .txtZV_PERC.Text = EmployeeStructure.ZV_Percentage
                    .txtZV_Amount.Text = Format(EmployeeStructure.ZV_Amount / CONSTANT_WEEKS_IN_YEAR, "N")
                Case 4
                    .txtAOVAWW_PERC.Text = EmployeeStructure.AOV_Percentage_Employee
                    .txtAOV_AWW.Text = Format(EmployeeStructure.AOV_Amount / CONSTANT_DAYS_IN_YEAR, "N")

                    .txtBVZ_PERC.Text = EmployeeStructure.BasisVerzekering_Percentage
                    .txtBVZ_Amount.Text = Format((EmployeeStructure.BasisVerzekering_Percentage * EmployeeStructure.BasisVerzekering_Amount) / CONSTANT_DAYS_IN_YEAR, "N")

                    .txtAVBZ_PERC.Text = EmployeeStructure.AVBZ_Percentage
                    .txtAVBZ_AMOUNT.Text = Format(EmployeeStructure.AVBZ_Amount / CONSTANT_DAYS_IN_YEAR, "N")

                    .txtZV_PERC.Text = EmployeeStructure.ZV_Percentage
                    .txtZV_Amount.Text = Format(EmployeeStructure.ZV_Amount / CONSTANT_DAYS_IN_YEAR, "N")
            End Select

            .txtPeriode2.Text = EmployeeStructure.Salary_Pay_Period
            .TXTSALARY.Text = Format(EmployeeStructure.Month_Salary, "N")
            .txtLeeftijd1jan.Text = EmployeeStructure.Age_On_First_January
            .txtUurloon.Text = Format(EmployeeStructure.Hour_Salary, "N")

            .txtAutoZaak.Text = Format(EmployeeStructure.CarcatologValue, "N")
            .txtAlleenVerdienerT.Text = Format(EmployeeStructure.AlleenVerdienerToeslag, "N")
            .txtBesInsp.Text = Format(EmployeeStructure.Beschikking, "N")
            .txtOuderenToeslag.Text = Format(EmployeeStructure.OuderenToeslag, "N")

            .txtZOG_PERC.Text = EmployeeStructure.ZOG_Percentage
            .txtValuta.Text = EmployeeStructure.EmployeeValuta
            .cmbvaluta.Text = EmployeeStructure.EmployeeValuta
            '.txtAnderloon.Text = EmployeeStructure.Anderloon

            .txtUrenPerDag.Text = EmployeeStructure.Empoyee_Uren_Per_Dag
            .txtDagenPerWeek.Text = EmployeeStructure.Employee_Dagen_PerWeek

            .txtZOGPREMIE.Text = Format(EmployeeStructure.ZogPremie, "N")

            '---------------------------------------------------------------LOAD FORM TEXTFIELDS -----------------------------------------------------------------------------------

        End With

        Return (0)
    End Function
    Public Function Calculate_Grondslag_AOVAWW(ByVal TotalIncome As Double, ByVal Verwervingskosten As Double, ByVal Pensioenfonds As Double, ByVal Beschikking As Double, ByVal ZogPremie As Double)
        Dim Grondslag_Jaar_Basis As Double
        Grondslag_Jaar_Basis = TotalIncome - CONSTANT_VERWERVINGSKOSTEN - Pensioenfonds - Beschikking - ZogPremie
        Return Grondslag_Jaar_Basis
    End Function
    Public Function BerekenSVB(ByVal TotalIncome As Double, ByVal Percentage As Double)
        If TotalIncome = 0 Then
            Return (0)
            Exit Function
        End If
        Dim Amount As Double
        Amount = Convert.ToDouble(Percentage) / 100 * TotalIncome

        Return (Amount.ToString("N"))
    End Function

    Function LoadVergoedingen()
        'Dim CURRENTCOMPANY As Integer
        'Dim SalForceConnectionString As String
        'With frmEmployeeProfileBackup
        '    CURRENTCOMPANY = Convert.ToInt16(.txtCompanyNr.Text)
        '    If Len(CURRENTCOMPANY) = 0 Then
        '        Return (0)
        '        Exit Function
        '    End If
        'End With
        'Try
        '    SalForceConnectionString = My.Settings("NewSalForceConnection")
        '    Using Connection As New SqlConnection(SalForceConnectionString)
        '        If Connection.State = ConnectionState.Closed Then
        '            Connection.Open()
        '        End If

        '        Dim EMP_RetrieveCommand As SqlCommand
        '        Dim EMP_Retrievereader As SqlDataReader
        '        Dim SelectedCompany, selectedemployee As Integer
        '        'Here we are selecting the Employee of an existing Cmpany to load
        '        With frmEmployeeProfileBackup
        '            .txtEmpNotities.Text = ""
        '            SelectedCompany = .DataGridView1.SelectedCells.Item(0).Value.ToString
        '            selectedemployee = .DataGridView1.SelectedCells.Item(1).Value
        '            '---------------------------------------------------------------------

        '            'Create the Query to retrieve the Employee from the database
        '            Dim EMP_RetrieveString = "SELECT * FROM EMPTABLE WHERE EMP_EMPLOYEENR =" & selectedemployee & " AND EMP_COMPID = " & SelectedCompany

        '            EMP_RetrieveCommand = New SqlCommand(EMP_RetrieveString, Connection)

        '            EMP_Retrievereader = EMP_RetrieveCommand.ExecuteReader()
        '            EMP_Retrievereader.Read()

        '            For I = 0 To 6
        '                .DGVergoedingen.Rows(I).Cells("BEDRAG").Value = 0
        '                .DGVergoedingen.Rows(I).Cells("CODE").Value = ""
        '                .DGVergoedingen.Rows(I).Cells("OMSCHRIJVING").Value = ""
        '                .DGVergoedingenB.Rows(I).Cells("BEDRAG").Value = 0
        '                .DGVergoedingenB.Rows(I).Cells("CODE").Value = ""
        '                .DGVergoedingenB.Rows(I).Cells("OMSCHRIJVING").Value = ""
        '            Next

        '            .DGVergoedingen.Rows(0).Cells("CODE").Value = EMP_Retrievereader("EMP_VERGCODE0")
        '            .DGVergoedingen.Rows(1).Cells("CODE").Value = EMP_Retrievereader("EMP_VERGCODE1")
        '            .DGVergoedingen.Rows(2).Cells("CODE").Value = EMP_Retrievereader("EMP_VERGCODE2")
        '            .DGVergoedingen.Rows(3).Cells("CODE").Value = EMP_Retrievereader("EMP_VERGCODE3")
        '            .DGVergoedingen.Rows(4).Cells("CODE").Value = EMP_Retrievereader("EMP_VERGCODE4")
        '            .DGVergoedingen.Rows(5).Cells("CODE").Value = EMP_Retrievereader("EMP_VERGCODE5")
        '            .DGVergoedingen.Rows(6).Cells("CODE").Value = EMP_Retrievereader("EMP_VERGCODE6")

        '            .DGVergoedingen.Rows(0).Cells("OMSCHRIJVING").Value = EMP_Retrievereader("EMP_VERGOMSCHR0")
        '            .DGVergoedingen.Rows(1).Cells("OMSCHRIJVING").Value = EMP_Retrievereader("EMP_VERGOMSCHR1")
        '            .DGVergoedingen.Rows(2).Cells("OMSCHRIJVING").Value = EMP_Retrievereader("EMP_VERGOMSCHR2")
        '            .DGVergoedingen.Rows(3).Cells("OMSCHRIJVING").Value = EMP_Retrievereader("EMP_VERGOMSCHR3")
        '            .DGVergoedingen.Rows(4).Cells("OMSCHRIJVING").Value = EMP_Retrievereader("EMP_VERGOMSCHR4")
        '            .DGVergoedingen.Rows(5).Cells("OMSCHRIJVING").Value = EMP_Retrievereader("EMP_VERGOMSCHR5")
        '            .DGVergoedingen.Rows(6).Cells("OMSCHRIJVING").Value = EMP_Retrievereader("EMP_VERGOMSCHR6")

        '            .DGVergoedingen.Rows(0).Cells("BEDRAG").Value = EMP_Retrievereader("EMP_VERGBDRG0")
        '            .DGVergoedingen.Rows(1).Cells("BEDRAG").Value = EMP_Retrievereader("EMP_VERGBDRG1")
        '            .DGVergoedingen.Rows(2).Cells("BEDRAG").Value = EMP_Retrievereader("EMP_VERGBDRG2")
        '            .DGVergoedingen.Rows(3).Cells("BEDRAG").Value = EMP_Retrievereader("EMP_VERGBDRG3")
        '            .DGVergoedingen.Rows(4).Cells("BEDRAG").Value = EMP_Retrievereader("EMP_VERGBDRG4")
        '            .DGVergoedingen.Rows(5).Cells("BEDRAG").Value = EMP_Retrievereader("EMP_VERGBDRG5")
        '            .DGVergoedingen.Rows(6).Cells("BEDRAG").Value = EMP_Retrievereader("EMP_VERGBDRG6")

        '            .DGVergoedingenB.Rows(0).Cells("CODE").Value = EMP_Retrievereader("EMP_BVERGCODE0")
        '            .DGVergoedingenB.Rows(1).Cells("CODE").Value = EMP_Retrievereader("EMP_BVERGCODE1")
        '            .DGVergoedingenB.Rows(2).Cells("CODE").Value = EMP_Retrievereader("EMP_BVERGCODE2")
        '            .DGVergoedingenB.Rows(3).Cells("CODE").Value = EMP_Retrievereader("EMP_BVERGCODE3")
        '            .DGVergoedingenB.Rows(4).Cells("CODE").Value = EMP_Retrievereader("EMP_BVERGCODE4")
        '            .DGVergoedingenB.Rows(5).Cells("CODE").Value = EMP_Retrievereader("EMP_BVERGCODE5")
        '            .DGVergoedingenB.Rows(6).Cells("CODE").Value = EMP_Retrievereader("EMP_BVERGCODE6")

        '            .DGVergoedingenB.Rows(0).Cells("OMSCHRIJVING").Value = EMP_Retrievereader("EMP_BVERGOMSCHR0")
        '            .DGVergoedingenB.Rows(1).Cells("OMSCHRIJVING").Value = EMP_Retrievereader("EMP_BVERGOMSCHR1")
        '            .DGVergoedingenB.Rows(2).Cells("OMSCHRIJVING").Value = EMP_Retrievereader("EMP_BVERGOMSCHR2")
        '            .DGVergoedingenB.Rows(3).Cells("OMSCHRIJVING").Value = EMP_Retrievereader("EMP_BVERGOMSCHR3")
        '            .DGVergoedingenB.Rows(4).Cells("OMSCHRIJVING").Value = EMP_Retrievereader("EMP_BVERGOMSCHR4")
        '            .DGVergoedingenB.Rows(5).Cells("OMSCHRIJVING").Value = EMP_Retrievereader("EMP_BVERGOMSCHR5")
        '            .DGVergoedingenB.Rows(6).Cells("OMSCHRIJVING").Value = EMP_Retrievereader("EMP_BVERGOMSCHR6")

        '            .DGVergoedingenB.Rows(0).Cells("BEDRAG").Value = EMP_Retrievereader("EMP_BVERGBDRG0")
        '            .DGVergoedingenB.Rows(1).Cells("BEDRAG").Value = EMP_Retrievereader("EMP_BVERGBDRG1")
        '            .DGVergoedingenB.Rows(2).Cells("BEDRAG").Value = EMP_Retrievereader("EMP_BVERGBDRG2")
        '            .DGVergoedingenB.Rows(3).Cells("BEDRAG").Value = EMP_Retrievereader("EMP_BVERGBDRG3")
        '            .DGVergoedingenB.Rows(4).Cells("BEDRAG").Value = EMP_Retrievereader("EMP_BVERGBDRG4")
        '            .DGVergoedingenB.Rows(5).Cells("BEDRAG").Value = EMP_Retrievereader("EMP_BVERGBDRG5")
        '            .DGVergoedingenB.Rows(6).Cells("BEDRAG").Value = EMP_Retrievereader("EMP_BVERGBDRG6")

        '            Dim BedragTotaal, BedragTotaalB As Double
        '            BedragTotaal = 0
        '            BedragTotaalB = 0

        '            For i = 0 To 6
        '                If IsDBNull(.DGVergoedingen.Rows(i).Cells("BEDRAG").Value) Then
        '                    .DGVergoedingen.Rows(i).Cells("BEDRAG").Value = 0

        '                End If
        '                If IsDBNull(.DGVergoedingenB.Rows(i).Cells("BEDRAG").Value) Then
        '                    .DGVergoedingenB.Rows(i).Cells("BEDRAG").Value = 0
        '                End If

        '                BedragTotaal = BedragTotaal + Convert.ToDouble(.DGVergoedingen.Rows(i).Cells("BEDRAG").Value)
        '                BedragTotaalB = BedragTotaalB + Convert.ToDouble(.DGVergoedingenB.Rows(i).Cells("BEDRAG").Value)
        '            Next i

        '            .DGVergoedingen.Rows(7).Cells("BEDRAG").Value = BedragTotaal
        '            .DGVergoedingenB.Rows(7).Cells("BEDRAG").Value = BedragTotaalB
        '            .txtTotalIncome.Text = CalculateTotalIncome()
        '            .DGVergoedingen.Refresh()
        '            .DGVergoedingenB.Refresh()
        '        End With
        '        EMP_Retrievereader.Close()
        '        Connection.Dispose()
        '        Connection.Close()
        '    End Using

        'Catch Ex As Exception
        '    MsgBox(Ex.Source)
        '    Return (-1)
        'End Try

        'Return (0)
    End Function

    Function LoadSpaarTab()
        DisablePartnerTab()
        Dim EmployeeData As New EMPLOYEE
        Dim EmployeeStructure As EMPSTRUCTURE
        Dim EMPCOMP, EMPID As Integer

        'Here we are selecting the Employee of an existing Company to load
        With frmEmployeeProfileBackup
            EMPCOMP = Convert.ToInt16(.DataGridView1.SelectedCells.Item(0).Value)
            EMPID = Convert.ToInt16(.DataGridView1.SelectedCells.Item(0).Value)
            EmployeeStructure = EmployeeData.Retrieve_Employee_Data(EMPCOMP, EMPID)

            .txtSpaarFondsNaam.Text = EmployeeStructure.SpaarFondsNaam
            .txtPensioenfondsNaam.Text = EmployeeStructure.PensioenfondsNaam

            .txtSpaarFondsWGPerc.Text = EmployeeStructure.SpaarFondsWGPerc
            .txtSpaarFondsWNPerc.Text = EmployeeStructure.SpaarFondsWNPerc

            .txtPensWGPerc.Text = EmployeeStructure.PensWGPerc
            .txtPensWNPerc.Text = EmployeeStructure.PensWNPerc
        End With
        Return (0)
    End Function
    Function LoadNotities()
        Dim CURRENTCOMPANY As Integer
        Dim SalForceConnectionString As String
        With frmEmployeeProfileBackup
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
                Dim SelectedCompany, selectedemployee As Integer
                'Here we are selecting the Employee of an existing Cmpany to load
                With frmEmployeeProfileBackup
                    .txtEmpNotities.Text = ""
                    SelectedCompany = .DataGridView1.SelectedCells.Item(0).Value.ToString
                    selectedemployee = .DataGridView1.SelectedCells.Item(1).Value
                    '---------------------------------------------------------------------

                    'Create the Query to retrieve the Employee from the database
                    Dim EMP_RetrieveString = "SELECT * FROM EMPTABLE WHERE EMP_EMPLOYEENR =" & selectedemployee & " AND EMP_COMPID = " & SelectedCompany

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

    Function LoadToolStrip()
        With frmEmployeeProfileBackup
            .ToolStripUserName.Text = UCase(My.User.Name.ToString)
            .ToolStripStatusLabel1.Text = "BEDRIJF:" & frmEmployeeProfileBackup.ToolStripDropDownButton1.Selected.ToString
            .Refresh()
        End With
        Return (0)
    End Function
    Function EditButton()
        With frmEmployeeProfileBackup
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
                    EnableNotitiesTab()     'NOTITESTAB IS ACTIVE
                Case 4
                    EnableSpaarTab()     'Spaar & Pensioen IS ACTIVE
            End Select
        End With

        Return (0)
    End Function

    Function SkinForm()

        For Each ThisControl As System.Windows.Forms.Control In frmEmployeeProfileBackup.Controls
            Skin(ThisControl)
        Next ThisControl
        For Each ThisControl As System.Windows.Forms.Control In frmEmployeeProfileBackup.TAB01.Controls
            Skin(ThisControl)
        Next ThisControl
        For Each ThisControl As System.Windows.Forms.Control In frmEmployeeProfileBackup.TAB02.Controls
            Skin(ThisControl)
        Next ThisControl
        For Each ThisControl As System.Windows.Forms.Control In frmEmployeeProfileBackup.TAB03.Controls
            Skin(ThisControl)
        Next ThisControl
        For Each ThisControl As System.Windows.Forms.Control In frmEmployeeProfileBackup.TAB04.Controls
            Skin(ThisControl)
        Next ThisControl
        For Each ThisControl As System.Windows.Forms.Control In frmEmployeeProfileBackup.TAB05.Controls
            Skin(ThisControl)
        Next ThisControl

    End Function

    Function ClearEmployeeDataEntry()
        With frmEmployeeProfileBackup
            .cmbSelectCompany.Text = ""
            .txtCompanyNr.Text = ""
            .txtEmployeeNr.Text = ""
            .txtEmployeeFirstName.Text = ""
            .txtemployeeLastName.Text = ""
            .txtemployeeAddress.Text = ""
            .CalendarPickerBirthdate.Text = ""
            .cmbSelectDepartment.Text = ""
            .calEmployeeDateBegin.Text = ""
            .txtDateBegin.Text = ""
            .calEmployeeDateEnd.Text = ""
            .txtDateEnd.Text = ""
            .txtEmployeefunction.Text = ""
            .txtEmployeeCedulaNr.Text = ""
            .txtEmployeeHomePhone.Text = ""
            .txtEmployeeMobile.Text = ""
            .txtEmployeeEmail1.Text = ""
            .txtEmployeeEmail2.Text = ""
            .txtEmployeePicture.Text = ""
            .txtPartnerFirstname.Text = ""
            .txtPartnerLastname.Text = ""
            .DatePickerPartnerBirthdate.Value = Now()
            .txtPartnerBirthDate.Text = ""
            .txtPartnerMidname.Text = ""
            .btnEdit.Enabled = False
            For Counter = 0 To .DataGridView2.RowCount - 1
                .DataGridView2.Rows.Clear()
            Next Counter
            .Refresh()
        End With
        Return (0)

    End Function
    Function EnableSpaarTab()
        With frmEmployeeProfileBackup
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
        With frmEmployeeProfileBackup
            .DGVergoedingen.Enabled = True
            .DGVergoedingenB.Enabled = True
            .btnSave.Enabled = True
        End With

        Return (0)
    End Function
    Function DisableVergoedingenTab()
        With frmEmployeeProfileBackup
            .DGVergoedingen.Enabled = False
            .DGVergoedingenB.Enabled = False
        End With
        Return (0)
    End Function

    Function EnableBelastingTab()
        With frmEmployeeProfileBackup
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
                .cmbPeriod.Text = .txtPeriode2.Text
            End If
            .txtPeriode2.Visible = False

            .btnSave.Enabled = True
            .CheckBoxSpaarfonds.Enabled = True
            .CheckBoxPensioen.Enabled = True
        End With
        Return (0)
    End Function
    Function DisableBelastingtab()
        With frmEmployeeProfileBackup

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
            .txtPeriode2.Enabled = False
            .txtPeriode2.Visible = True
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
        With frmEmployeeProfileBackup

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
        With frmEmployeeProfileBackup

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
        With frmEmployeeProfileBackup
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
            .txtPeriode2.Visible = True
            .txtPeriode2.Enabled = False
            .cmbIsland.Enabled = False
            .txtEmployeeMAN.Enabled = False
            .txtEmployeeVRW.Enabled = False
            .txtEmployeePicture.Enabled = False
        End With

        Return (0)
    End Function
    Function DisableSpaarTab()
        With frmEmployeeProfileBackup

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
        With frmEmployeeProfileBackup

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
        With frmEmployeeProfileBackup
            .txtEmpNotities.Enabled = True
            .btnSave.Enabled = True
        End With
        Return (0)
    End Function
    Function DisableNotitiesTab()
        With frmEmployeeProfileBackup
            .txtEmpNotities.Enabled = False
            .btnSave.Enabled = False
        End With
        Return (0)
    End Function
    Function CALCULATE_EMPLOYEE_AOV(ByVal Premie_Inkomen As Double, ByVal Premie_Voet As Double, ByVal WN_Percentage As Double, ByVal Premie_Grens As Double, ByVal Discount_Percentage As Double, ByVal Salaris_Periode As Short)
        Dim Calculated_Tax, Tax_Discount As Double

        Premie_Voet = 9340.0
        If Premie_Inkomen < Premie_Voet Then
            Return 0
        End If

        Select Case CShort(Salaris_Periode)
            Case CONSTANT_PERIOD_YEAR
                If Premie_Inkomen > Premie_Grens Then
                    Premie_Inkomen = Premie_Grens
                End If
                Calculated_Tax = WN_Percentage * Premie_Inkomen
                Tax_Discount = (Premie_Voet - (Discount_Percentage * Premie_Inkomen)) * WN_Percentage / 100
                Return (Calculated_Tax - Tax_Discount)
            Case CONSTANT_PERIOD_QUART
                Premie_Inkomen = Premie_Inkomen * CONSTANT_QUARTS_IN_YEAR
                If Premie_Inkomen > Premie_Grens Then
                    Premie_Inkomen = Premie_Grens
                End If
                Calculated_Tax = WN_Percentage * Premie_Inkomen
                Tax_Discount = (Premie_Voet - (Discount_Percentage * Premie_Inkomen)) * (WN_Percentage / 100)
                Return (Calculated_Tax - Tax_Discount) / CONSTANT_QUARTS_IN_YEAR
            Case CONSTANT_PERIOD_MONTH
                Premie_Inkomen = Premie_Inkomen * CONSTANT_MONTHS_IN_YEAR
                If Premie_Inkomen > Premie_Grens Then
                    Premie_Inkomen = Premie_Grens
                End If
                Calculated_Tax = (WN_Percentage / 100) * Premie_Inkomen
                Tax_Discount = (Premie_Voet - (Discount_Percentage * Premie_Inkomen)) * (WN_Percentage / 100)
                Return (Calculated_Tax - Tax_Discount) / CONSTANT_MONTHS_IN_YEAR
            Case CONSTANT_PERIOD_WEEK
                Premie_Inkomen = Premie_Inkomen * CONSTANT_WEEKS_IN_YEAR
                If Premie_Inkomen > Premie_Grens Then
                    Premie_Inkomen = Premie_Grens
                End If
                Calculated_Tax = WN_Percentage * Premie_Inkomen
                Tax_Discount = (Premie_Voet - (Discount_Percentage * Premie_Inkomen)) * (WN_Percentage / 100)
                Return (Calculated_Tax - Tax_Discount) / CONSTANT_WEEKS_IN_YEAR
            Case CONSTANT_PERIOD_DAY
                Premie_Inkomen = Premie_Inkomen * CONSTANT_DAYS_IN_YEAR
                If Premie_Inkomen > Premie_Grens Then
                    Premie_Inkomen = Premie_Grens
                End If
                Calculated_Tax = WN_Percentage * Premie_Inkomen
                Tax_Discount = (Premie_Voet - (Discount_Percentage * Premie_Inkomen)) * (WN_Percentage / 100)
                Return (Calculated_Tax - Tax_Discount) / CONSTANT_DAYS_IN_YEAR
            Case CONSTANT_PERIOD_HALFDAY
                Premie_Inkomen = Premie_Inkomen * CONSTANT_HALF_DAYS_IN_YEAR
                If Premie_Inkomen > Premie_Grens Then
                    Premie_Inkomen = Premie_Grens
                End If
                Calculated_Tax = WN_Percentage * Premie_Inkomen
                Tax_Discount = (Premie_Voet - (Discount_Percentage * Premie_Inkomen)) * (WN_Percentage / 100)
                Return (Calculated_Tax - Tax_Discount) / CONSTANT_HALF_DAYS_IN_YEAR
        End Select
    End Function
    Function CalculateOnkostenVergoeding(ByVal OnkostenType As Single)
        'Onkostentype 1 = Belastbare Onkosten vergoedingen
        'Onkostentype 2 = Onbelastbare Onkosten vergoedingen
        Dim Total As Double
        Select Case OnkostenType
            Case 1
                With frmEmployeeProfileBackup.DGVergoedingenB
                    Total = 0
                    For i = 0 To 6
                        Total = Total + .Rows(i).Cells("Bedrag").Value
                    Next
                End With
            Case 2
                With frmEmployeeProfileBackup.DGVergoedingen
                    For i = 0 To 6
                        Total = Total + .Rows(i).Cells("Bedrag").Value
                    Next
                End With
        End Select

        Return Total.ToString("N")
    End Function

    Function CalculateTotalIncome() As String
        Dim TotalIncome, Salary, OnkostenVergoeding, AnderLoon, AutoVergoeding As Double
        TotalIncome = 0
        With frmEmployeeProfileBackup
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

    Function CalculateTax(ByVal Grondslag As Double, ByVal TaxYear As String, ByVal Island As String)
        Dim YearIncome, Tax As Double
        Dim XMLTable_Return(5, 3) As Double
        XMLTable_Return = ReadXMLData_BelastingTabel(UCase(Island), "2012")
        YearIncome = Grondslag * 12
        Select Case YearIncome
            Case Is < CDbl(XMLTable_Return(0, 1))
                Dim Basis, Difference As Double
                Basis = XMLTable_Return(0, 0)
                Difference = YearIncome - XMLTable_Return(0, 0)
                Tax = (Basis + (Difference * XMLTable_Return(0, 3) / 100))
            Case CDbl(XMLTable_Return(1, 0)) To CDbl(XMLTable_Return(1, 1))
                Dim Basis, Difference As Double
                Basis = XMLTable_Return(1, 2)
                Difference = YearIncome - XMLTable_Return(1, 0)
                Tax = (Basis + (Difference * XMLTable_Return(1, 3) / 100))
            Case CDbl(XMLTable_Return(2, 0)) To CDbl(XMLTable_Return(2, 1))
                Dim Basis, Difference As Double
                Basis = XMLTable_Return(2, 2)
                Difference = YearIncome - XMLTable_Return(2, 0)
                Tax = Basis + (Difference * (XMLTable_Return(2, 3) / 100))
            Case CDbl(XMLTable_Return(3, 0)) To CDbl(XMLTable_Return(3, 1))
                Dim Basis, Difference As Double
                Basis = XMLTable_Return(3, 2)
                Difference = YearIncome - XMLTable_Return(3, 0)
                Tax = (Basis + (Difference * XMLTable_Return(3, 3) / 100))
            Case CDbl(XMLTable_Return(4, 0)) To CDbl(XMLTable_Return(4, 1))
                Dim Basis, Difference As Double
                Basis = XMLTable_Return(4, 2)
                Difference = YearIncome - XMLTable_Return(4, 0)
                Tax = (Basis + (Difference * XMLTable_Return(4, 3) / 100))
            Case Is >= CDbl(XMLTable_Return(5, 0))
                Dim Basis, Difference As Double
                Basis = XMLTable_Return(5, 2)
                Difference = YearIncome - XMLTable_Return(5, 0)
                Tax = (Basis + (Difference * XMLTable_Return(5, 3) / 100))
        End Select
        Return (Format(Tax / 12, "0.00"))
    End Function

End Module