Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.Strings
Imports System.IO
Imports System.Windows.Forms
Imports System.Data

Public Module Databasefunctions

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

    Function ExistCompany(ByVal CNumber As String) As Boolean
        Dim connectionstring, CheckSQLString As String

        connectionstring = My.Settings.NewSalforceConnection

        Using connection As New SqlConnection(connectionstring)
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            CheckSQLString = Format("Select * FROM COMPANYTABLE WHERE COMP_ID = {0}", CNumber)

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
        Dim SelectedLanguage As String = My.Settings.SalforceLanguage.ToString

        If Len(CedulaNr) < 8 Then
            MsgBox(GetMessageString(1012, SelectedLanguage), vbAbort, Application.ProductName.ToString)

            Return (Nothing)
        End If
        If CInt(Month) > 12 Or CInt(Month) <= 0 Then
            MsgBox(GetMessageString(1012, SelectedLanguage), vbAbort, Application.ProductName.ToString)
            Return (Nothing)
        End If

        If CInt(Day) > 31 Or CInt(Day) <= 0 Then
            MsgBox(GetMessageString(1012, SelectedLanguage), vbAbort, Application.ProductName.ToString)
            Return (Nothing)
        End If

        LeapYear = Date.IsLeapYear(Year)
        If (LeapYear = True) And (CInt(Month) = 2) Then
            If CInt(Day) > 30 Or CInt(Day) <= 0 Then
                MsgBox(GetMessageString(1012, SelectedLanguage), vbAbort, Application.ProductName.ToString)
                Return (Nothing)
            End If
        End If

        CedulaDate = CDate(Year & "/" & Month & "/" & Day)
        Return (CedulaDate)
    End Function

    Function ExistEmployeeIncompany(ByVal CompanyNr As Integer, ByVal EmployeeNr As Integer) As Boolean
        Dim CheckSQLString, SalForceConnectionString As String

        SalForceConnectionString = My.Settings.NewSalforceConnection
        Using connection As New SqlConnection(SalForceConnectionString)
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            CheckSQLString = String.Format("Select EMP_EMPLOYEENR, EMP_COMPID FROM EMPTABLE WHERE EMP_COMPID = {0}  AND  EMP_EMPLOYEENR = ", EmployeeNr, CompanyNr)

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
        SqlString = String.Format("Select RecordNr From EMPTABLE WHERE EMP_COMPID = {0} AND  EMP_EMPLOYEENR = {1}", EmployeeNr, CompanyNr)

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

    Function GetTableTotalRows(TableName As String, CompanyNr As Integer) As Integer

        Dim SqlString, SalForceConnectionString As String
        SqlString = String.Format("Select count (*) From {0} where EMP_COMPID ={1}  ", TableName, CompanyNr)

        SalForceConnectionString = My.Settings.NewSalforceConnection
        Using connection As New SqlConnection(SalForceConnectionString)
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim command As New SqlCommand(SqlString, connection)
            Dim SQLRetrieveReader As SqlDataReader = command.ExecuteReader()
            SQLRetrieveReader.Read()

            If SQLRetrieveReader.HasRows Then
                Return (SQLRetrieveReader.Item(0))
            Else
                Return (0)
            End If
            connection.Close()
            connection.Dispose()
        End Using

    End Function

End Module