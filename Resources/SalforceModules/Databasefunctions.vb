Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO
Imports System.Windows.Forms
Imports System.Data

Public Module Databasefunctions

    Structure stcEmployee
        Public CompID As Integer
        Public EmpID As Integer
        Public FirstName As String
        Public LastName As String
        Public Address As String
        Public BirthDate As String
        Public Department As String
        Public StartDate As Date
        Public EndDate As Date
        Public Salary As String
        Public Status As String
        Public Position As String
        Public Sex As String
        Public CedulaNr As String
        Public EMAIL1 As String
        Public EMAIL2 As String
        Public PictureID As String
        Public MobileNr As String
        Public HomePhone As String
        Public SpouseName As String
        Public SpouseLastName As String
        Public SpouseMiddenName As String
        Public SpouseEmployer As String
        Public SpouseBirthDate As String
        Public EmpEnddate As Date
        Public Empaddress As String
        Public EmpPosition As String
        Public EmpPict As String
        Public EmpAOVAWW As String
        Public EmpZV As String
        Public EmpAVBZ As String
        Public EmpCar As String
        Public EmpOudtoeslag As String
        Public EmpHuisBesch As String
        Public EmpOV As String
        Public EmpOudtoeslagval As String
        Public EmpAlleenVerdT As String
        Public EmpKindTValue As String
        Public EmpBesluitInsp As String
        Public EmpBESLUITINSPVAL As String
        Public EmpCarCatValue As String
        Public EmpPensioenfonds As String
        Public EmpValuta As String
        Public EmpAnderL As String
        Public EmpBelPlichtig As String
        Public EmpDagenPerWeek As String
        Public EmpUrenPerDag As String
        Public EmpPeriod As String
        Public EmpMarried As String
        Public EmpNotities As String
        Public EmpOnkosten As String
        Public EmpBelInkomenVrouw As String
        Public EmpZOGPREMIE As String
        Public EmpVergCode_0 As String
        Public EmpVergCode_1 As String
        Public EmpVergCode_2 As String
        Public EmpVergCode_3 As String
        Public EmpVergCode_4 As String
        Public EmpVergCode_5 As String
        Public EmpVergCode_6 As String

        Public EmpVergOms_0 As String
        Public EmpVergOms_1 As String
        Public EmpVergOms_2 As String
        Public EmpVergOms_3 As String
        Public EmpVergOms_4 As String
        Public EmpVergOms_5 As String
        Public EmpVergOms_6 As String

        Public EmpVergBedr_0 As String
        Public EmpVergBedr_1 As String
        Public EmpVergBedr_2 As String
        Public EmpVergBedr_3 As String
        Public EmpVergBedr_4 As String
        Public EmpVergBedr_5 As String
        Public EmpVergBedr_6 As String

        Public EmpVergCodeB_0 As String
        Public EmpVergCodeB_1 As String
        Public EmpVergCodeB_2 As String
        Public EmpVergCodeB_3 As String
        Public EmpVergCodeB_4 As String
        Public EmpVergCodeB_5 As String
        Public EmpVergCodeB_6 As String

        Public EmpVergOmsB_0 As String
        Public EmpVergOmsB_1 As String
        Public EmpVergOmsB_2 As String
        Public EmpVergOmsB_3 As String
        Public EmpVergOmsB_4 As String
        Public EmpVergOmsB_5 As String
        Public EmpVergOmsB_6 As String

        Public EmpVergBedrB_0 As String
        Public EmpVergBedrB_1 As String
        Public EmpVergBedrB_2 As String
        Public EmpVergBedrB_3 As String
        Public EmpVergBedrB_4 As String
        Public EmpVergBedrB_5 As String
        Public EmpVergBedrB_6 As String

        Public EmpPensFName As String
        Public EmpPensWNPerc As String
        Public EmpPensWGPerc As String
        Public EmpPensfixed As String

        Public EmpSpaarFName As String
        Public EmpSpaarWNPerc As String
        Public EMpSpaarWGPerc As String
        Public EmpSpaarFixed As String

    End Structure

    Structure Taxparameters
        Public AOVAWWTotalPercentage As String
        Public AOVAWWEmployeePart As String
        Public ZVTotalPercentage As String
        Public ZVEmployeePart As String

    End Structure

    Public Structure stcEmployeeChild
        Public ParentNr As Integer
        Public CompanyNr As Integer
        Public EmployeeNr As Integer
        Public Name As String
        Public LastName As String
        Public Category As String
        Public School As String
        Public ChildBirthDate As String
        Public KToeslag As Double
    End Structure

    Public Structure stcCompany
        Public CompNr As Integer
        Public CompName As String
        Public CompAddress As String
        Public CompKvk As String
        Public CompCribNr As String
        Public CompSVBNr As String
        Public CompDAZ As String
        Public CompCreatedSuccess As Boolean
        Public CompDeletedSuccess As Boolean
        Public CompRiscPerc As Double
        Public CompCreatedDate As Date
        Public CompEmployeesCount As String
        Public CompCountry As String
    End Structure
    Public Structure stcAOVAWW_Parameter
        Public Premie_Inkomen As Double
        Public Premie_Voet As Double
        Public WN_Percentage As Double
        Public Premie_Grens As Double
        Public Discount_Percentage As Double
        Public Salaris_Periode As SByte
        Public Kortingtoepassen As SByte
        Public BookYear As String
        Public Evenredigheidsfactor As Double
    End Structure

    Function ExistCompany(ByVal CNumber As String) As Boolean
        Dim connectionstring, CheckSQLString As String

        connectionstring = "Server=.\SQL2008;AttachDbFilename=d:\sqlexpress2008\mssql10.sql2008\mssql\data\salforce.mdf;Database=salforce; Trusted_Connection=Yes;"

        Using connection As New SqlConnection(connectionstring)
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            CheckSQLString = "Select * FROM COMPANYTABLE WHERE COMP_ID = '" & CNumber & "'"

            Dim command As New SqlCommand(CheckSQLString, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows = True Then
                connection.Close()
                reader.Close()
                Return (True)
            Else
                Return (0)

            End If
        End Using
    End Function
    ' Public Class MainClass
    Public Function IsSQLServerOnline(ByVal ServerAddress As String) As Boolean
        Try
            Dim objIPHost As New System.Net.IPHostEntry()
            objIPHost = System.Net.Dns.GetHostEntry(ServerAddress)
            Dim objAddress As System.Net.IPAddress
            objAddress = objIPHost.AddressList(0)
            Dim objTCP As System.Net.Sockets.TcpClient = New System.Net.Sockets.TcpClient()
            objTCP.Connect(objAddress, 1433)
            objTCP.Close()
            objTCP = Nothing
            objAddress = Nothing
            objIPHost = Nothing
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Function TruncateCedulaToDate(ByVal CedulaNr As String) As Date
        Dim Year, Month, Day As String
        Dim CedulaDate As Date
        Dim LeapYear As Boolean

        Year = Left(CedulaNr, 4)
        Month = Mid(CedulaNr, 5, 2)
        Day = Mid(CedulaNr, 7, 2)

        If Len(CedulaNr) < 8 Then
            MsgBox("Verkeerd Cedula Nr aangegeven!", vbInformation, Application.ProductName)
            Return (Nothing)
        End If
        If CInt(Month) > 12 Or CInt(Month) <= 0 Then
            MsgBox("Verkeerd Cedula Nr aangegeven!", vbInformation, Application.ProductName)
            Return (Nothing)
        End If

        If CInt(Day) > 31 Or CInt(Day) <= 0 Then
            MsgBox("Verkeerd Cedula Nr aangegeven!", vbInformation, Application.ProductName)
            Return (Nothing)
        End If

        LeapYear = Date.IsLeapYear(Year)
        If (LeapYear = True) And (CInt(Month) = 2) Then
            If CInt(Day) > 30 Or CInt(Day) <= 0 Then
                MsgBox("Verkeerd Cedula Nr aangegeven!", vbInformation, Application.ProductName)
                Return (Nothing)
            End If
        End If

        CedulaDate = CDate(Year & "/" & Month & "/" & Day)
        Return (CedulaDate)
    End Function

    Function ExistEmployeeIncompany(ByVal companyNr As Integer, ByVal EmployeeNr As Integer) As Boolean
        Dim CheckSQLString, SalForceConnectionString As String

        '    connectionstring = "Server=.\SQL2008;AttachDbFilename=d:\sqlexpress2008\mssql10.sql2008\mssql\data\salforce.mdf;Database=salforce; Trusted_Connection=Yes;"
        SalForceConnectionString = My.Settings.NewSalforceConnection
        Using connection As New SqlConnection(SalForceConnectionString)
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            CheckSQLString = "Select EMP_EMPLOYEENR, EMP_COMPID FROM EMPTABLE WHERE EMP_COMPID = " & companyNr & " AND  EMP_EMPLOYEENR = " & EmployeeNr

            Dim command As New SqlCommand(CheckSQLString, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows = True Then
                connection.Close()
                reader.Close()
                Return (True)
            Else
                Return (False)

            End If
        End Using
    End Function

    Function RetrieveKinderToeslagAmount(ByVal Category As String) As String
        Select Case Category
            Case "CAT-1"
                Return ("50.00")
            Case "CAT-2"
                Return ("60.00")
            Case "CAT-3"
                Return ("70.00")
            Case "CAT-4"
                Return ("80.00")
        End Select
        Return (0)
    End Function

    Function GetEmployeeRecordNr(ByVal CompanyNr As Integer, ByVal EmployeeNr As Integer) As Integer

        Dim SqlString, SalForceConnectionString As String
        SqlString = "Select RecordNr From EMPTABLE WHERE EMP_COMPID = " & CompanyNr & " AND  EMP_EMPLOYEENR = " & EmployeeNr

        SalForceConnectionString = My.Settings.NewSalforceConnection
        Using connection As New SqlConnection(SalForceConnectionString)
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim command As New SqlCommand(SqlString, connection)
            Dim SQLRetrieveReader As SqlDataReader = command.ExecuteReader()
            SQLRetrieveReader.Read()
            If SQLRetrieveReader.HasRows Then
                Return (SQLRetrieveReader.Item("RecordNr"))
            Else
                Return (0)
            End If
            connection.Close()
        End Using
    End Function
    Function ReadXMLData_BelastingTabel(ByVal IslandName As String, ByVal YearParameter As String)
        Dim xmldoc As New XmlDocument
        Dim YearNodeList, RowNodeList As XmlNodeList
        Dim DataNode As XmlNode
        Dim TaxTable(5, 3) As Double

        Dim Yearcount As Integer

        Dim Docpath As String = CurDir() & "/DATABASE"

        If File.Exists(Docpath & "/Loonbelasting.xml") = False Then
            MsgBox("XML file not found", vbCritical, "SALFORCE")
            Return (TaxTable)
        End If
        Dim fs As New FileStream(Docpath & "/Loonbelasting.xml", FileMode.Open, FileAccess.Read)

        xmldoc.Load(fs)

        YearNodeList = xmldoc.GetElementsByTagName(UCase(IslandName))

        If YearNodeList.Count > 0 Then
            Yearcount = 0
            While Yearcount < YearNodeList.Count - 1
                DataNode = YearNodeList(Yearcount).ChildNodes(0)
                If DataNode.InnerText.Trim() = YearParameter Then
                    RowNodeList = xmldoc.GetElementsByTagName("row")
                    With RowNodeList
                        For Counter = 0 To RowNodeList.Count - 1
                            If .Item(Counter).ParentNode.LocalName = IslandName Then
                                TaxTable(Counter, 0) = .ItemOf(Counter).ChildNodes(0).InnerText.Trim()
                                TaxTable(Counter, 1) = .ItemOf(Counter).ChildNodes(1).InnerText.Trim()
                                TaxTable(Counter, 2) = .ItemOf(Counter).ChildNodes(2).InnerText.Trim()
                                TaxTable(Counter, 3) = .ItemOf(Counter).ChildNodes(3).InnerText.Trim()

                            End If
                        Next
                    End With
                End If

                Yearcount += 1

            End While
        Else
            Return -1
        End If
        fs.Close()
        Return TaxTable
    End Function
    Function ReadXMLDATA_AOVAWW(ByVal ISLANDNAME As String, ByVal Taxyear As String)
        Dim xmldoc As New XmlDocument
        Dim YearNodeList, RowNodeList As XmlNodeList
        Dim DataNode As XmlNode
        Dim AOVTable(1) As String
        AOVTable = New String(3) {}

        Dim Yearcount As Integer

        Dim Docpath As String = CurDir() & "/DATABASE"

        If File.Exists(Docpath & "/Loonbelasting.xml") = False Then
            Return (-1)
        End If
        Dim fs As New FileStream(Docpath & "/Loonbelasting.xml", FileMode.Open, FileAccess.Read)

        xmldoc.Load(fs)

        YearNodeList = xmldoc.GetElementsByTagName(ISLANDNAME)

        If YearNodeList.Count > 0 Then
            Yearcount = 0
            While Yearcount <= YearNodeList.Count - 1
                DataNode = YearNodeList(Yearcount).ChildNodes(0)
                If DataNode.InnerText.Trim() = Taxyear Then
                    RowNodeList = xmldoc.GetElementsByTagName("AOV")
                    With RowNodeList

                        If .Item(0).ParentNode.LocalName = ISLANDNAME Then
                            AOVTable(0) = .ItemOf(0).ChildNodes(0).InnerText.Trim() 'werkgeversdeel
                            AOVTable(1) = .ItemOf(0).ChildNodes(1).InnerText.Trim() 'werknemersdeel
                            AOVTable(2) = .ItemOf(0).ChildNodes(2).InnerText.Trim() 'aww werknemers = aww werkgever
                            AOVTable(3) = .ItemOf(0).ChildNodes(3).InnerText.Trim()
                        End If

                    End With
                End If

                Yearcount += 1

            End While
        Else
            Return -1
        End If
        fs.Close()
        Return AOVTable
    End Function
    Function UpdateEmployeeTab()

    End Function
    Function UpdateSpaartab()
        With frmEmployeeProfileBackup
            Dim EMPCOMPID As Integer = CType(.txtCompanyNr.Text, Integer)
            Dim EMPID As Integer = CType(.txtEmployeeNr.Text, Integer)

            Dim SPAARFNAME As String = UCase(Trim(.txtSpaarFondsNaam.Text))
            Dim SPWNPERC As String = Trim(.txtSpaarFondsWNPerc.Text)
            Dim SPWGPERC As String = Trim(.txtSpaarFondsWGPerc.Text)
            Dim SPVBEDRAG As String = Trim(.txtVastBedragSpF.Text)

            Dim PENSFNAME As String = UCase(Trim(.txtPensioenfondsNaam.Text))
            Dim PENSWNPERC As String = Trim(.txtPensWNPerc.Text)
            Dim PENSWGPERC As String = Trim(.txtPensWGPerc.Text)
            Dim PENSVBEDRAG As String = Trim(.txtVastBedragPF.Text)

            Dim SalforceConnectionString As String
            SalforceConnectionString = My.Settings("NewSalForceConnection")
            Using Connection As New SqlConnection(SalforceConnectionString)
                If Connection.State = ConnectionState.Closed Then
                    Connection.Open()
                End If

                Dim EMP_UPDATECommand As SqlCommand
                Dim EMP_UPDATEREADER As SqlDataReader

                Dim EMP_UPDATESTRING As String = "UPDATE EMPTABLE SET " & _
                "EMP_SPAARFNAME = '" & SPAARFNAME & "'," & _
                "EMP_SPAARWNPERC = '" & SPWNPERC & "'," & _
                "EMP_SPAARWGPERC = '" & SPWGPERC & "'," & _
                "EMP_SPAARFIXED = '" & SPVBEDRAG & "'," & _
                "EMP_PENSWGPERC = '" & PENSWGPERC & "'," & _
                "EMP_PENSWNPERC = '" & PENSWNPERC & "'," & _
                "EMP_PENSFIXED=  '" & PENSVBEDRAG & "'," & _
                "EMP_PENSFNAME = '" & PENSFNAME & "'" & _
                " WHERE EMP_COMPID = " & EMPCOMPID & " AND EMP_EMPLOYEENR = " & EMPID

                EMP_UPDATECommand = New SqlCommand(EMP_UPDATESTRING, Connection)
                EMP_UPDATEREADER = EMP_UPDATECommand.ExecuteReader
            End Using
        End With

        MsgBox("spaart Tab Saved !", vbExclamation, "SALFORCE")

    End Function
    Function UpdatePartnerTab()

    End Function
    Function UpdateBelastingTab()
        Dim BelastingTabUpdate As New clsEmployee
        Dim Selectedcompany, SelectedEmployee As Int16
        With frmEmployeeProfileBackup
            Selectedcompany = .DataGridView1.SelectedCells.Item(0).Value
            SelectedEmployee = .DataGridView1.SelectedCells.Item(1).Value
            BelastingTabUpdate.Update_Belasting_Tab(SelectedEmployee, Selectedcompany)
        End With
    End Function

    Private Function Day(ByVal CurrentDate As Date) As Object
        Throw New NotImplementedException
    End Function

    Function EmployeeHourwage(ByVal EmpData As stcEmployee)

        Select Case EmpData.EmpPeriod  'Loontijdvak
            Case CONSTANT_PERIOD_YEAR 'Year
                Dim JaarLoon As Double = EmpData.Salary
                Dim WeekLoon As Double = JaarLoon / 52
                Dim DagLoon As Double = WeekLoon / EmpData.EmpDagenPerWeek
                Dim UurLoon As Double = DagLoon / EmpData.EmpUrenPerDag
                Return UurLoon.ToString("0.00")
            Case CONSTANT_PERIOD_MONTH  'Month
                Dim JaarLoon As Double = EmpData.Salary * CONSTANT_MONTHS_IN_YEAR
                Dim WeekLoon As Double = JaarLoon / CONSTANT_WEEKS_IN_YEAR
                Dim DagLoon As Double = WeekLoon / EmpData.EmpDagenPerWeek
                Dim UurLoon As Double = DagLoon / EmpData.EmpUrenPerDag
                Return UurLoon.ToString("0.00")
            Case CONSTANT_PERIOD_QUART 'kwartaal
                Dim JaarLoon As Double = EmpData.Salary * CONSTANT_QUARTS_IN_YEAR
                Dim WeekLoon As Double = JaarLoon / CONSTANT_WEEKS_IN_YEAR
                Dim DagLoon As Double = WeekLoon / EmpData.EmpDagenPerWeek
                Dim UurLoon As Double = DagLoon / EmpData.EmpUrenPerDag
                Return UurLoon.ToString("0.00")
            Case CONSTANT_PERIOD_WEEK 'Week
                Dim JaarLoon As Double = EmpData.Salary * CONSTANT_WEEKS_IN_YEAR
                Dim WeekLoon As Double = JaarLoon / CONSTANT_WEEKS_IN_YEAR
                Dim DagLoon As Double = WeekLoon / EmpData.EmpDagenPerWeek
                Dim UurLoon As Double = DagLoon / EmpData.EmpUrenPerDag
                Return UurLoon.ToString("0.00")
            Case CONSTANT_PERIOD_DAY 'Day
                Dim JaarLoon As Double = EmpData.Salary * CONSTANT_DAYS_IN_YEAR
                Dim WeekLoon As Double = JaarLoon / CONSTANT_WEEKS_IN_YEAR
                Dim DagLoon As Double = WeekLoon / EmpData.EmpDagenPerWeek
                Dim UurLoon As Double = DagLoon / EmpData.EmpUrenPerDag
                Return UurLoon.ToString("0.00")
            Case CONSTANT_PERIOD_HALFDAY 'Half Day
                Dim JaarLoon As Double = EmpData.Salary * CONSTANT_HALF_DAYS_IN_YEAR
                Dim WeekLoon As Double = JaarLoon / CONSTANT_WEEKS_IN_YEAR
                Dim DagLoon As Double = WeekLoon / EmpData.EmpDagenPerWeek
                Dim UurLoon As Double = DagLoon / EmpData.EmpUrenPerDag
                Return UurLoon.ToString("0.00")
        End Select

    End Function

End Module