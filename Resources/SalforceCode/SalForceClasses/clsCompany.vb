Imports System.Data.SqlClient

Public Class clsCompany
    Dim connectionString, SQLString, CheckSQLString As String

    Public CompanyNr As Integer
    Public CompanyName As String
    Public CompanyAddress As String
    Public CompanyKvk As String
    Public CompanyCribNr As String
    Public CompanySVBNr As String
    Public CompanyDAZ As String
    Public CompanyCreatedSuccess As Boolean
    Public CompanyDeletedSuccess As Boolean
    Public CompanyRiscPerc As Double
    Public CompanyCreatedDate As Date
    Public CompanyEmployeesCount As String
    Public CompanyCountry As String

    Sub AddCompany(ByVal CompanyData As stcCompany)
        Dim SqlConnectionString, InsertSqlString As String
        Dim InsertCommand As SqlCommand
        Dim CompanyDataReader As SqlDataReader = Nothing

        CompanyNr = CompanyData.CompNr
        CompanyName = CompanyData.CompName
        CompanyAddress = CompanyData.CompAddress
        CompanyKvk = CompanyData.CompKvk
        CompanyDAZ = CompanyData.CompDAZ
        CompanyCribNr = CompanyData.CompCribNr
        CompanyRiscPerc = CompanyData.CompRiscPerc / 100
        CompanyCreatedDate = CompanyData.CompCreatedDate
        CompanySVBNr = CompanyData.CompSVBNr
        CompanyCountry = CompanyData.CompCountry

        SqlConnectionString = My.Settings("SalForceconnectionString")
        Using connection As New SqlConnection(SqlConnectionString)
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            InsertSqlString = "Insert into COMPANYTABLE (" &
                    "COMP_ID,COMP_NAME,COMP_ADDRESS,COMP_COUNTRY,COMP_KVK,COMP_CRIBNR, COMP_DAZ,COMP_CREATEDDATE,COMP_SVBNR, COMP_RISCPERC)" &
                    " VALUES (" &
                    CompanyNr & ",'" &
                    CompanyName & "','" &
                    CompanyAddress & "','" &
                    CompanyCountry & "','" &
                    CompanyKvk & "','" &
                    CompanyCribNr & "','" &
                    CompanyDAZ & "','" &
                    CompanyCreatedDate & "','" &
                    CompanySVBNr & "','" &
                    CompanyRiscPerc & "')"

            Try
                InsertCommand = New SqlCommand(InsertSqlString, connection)
                CompanyDataReader = InsertCommand.ExecuteReader()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
            Finally
                If CompanyDataReader.RecordsAffected >= 1 Then
                    CompanyCreatedSuccess = True
                Else
                    CompanyCreatedSuccess = False
                End If
            End Try
            connection.Dispose()
            connection.Close()
        End Using

    End Sub

    Sub Remove(ByVal COMP_NR As Integer)
        Dim SqlDeleteString, SQLConnection As String
        Dim DeleteCommand As SqlCommand = Nothing
        Dim DeleteReader As SqlDataReader = Nothing

        CompanyNr = COMP_NR
        CompanyDeletedSuccess = False

        SQLConnection = My.Settings("SalForceConnectionString")
        Using connection As New SqlConnection(SQLConnection)
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            SqlDeleteString = "DELETE FROM COMPANYTABLE WHERE COMP_ID = " & CompanyNr
            Try
                DeleteCommand = New SqlCommand(SqlDeleteString, connection)
                DeleteReader = DeleteCommand.ExecuteReader()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If DeleteReader.RecordsAffected = 1 Then
                    CompanyDeletedSuccess = True
                Else
                    CompanyDeletedSuccess = False
                End If
            End Try
            connection.Dispose()
            connection.Close()
        End Using

    End Sub

    Sub EmployeeCount(ByVal COMP_NR As Integer)
        connectionString = "Server=.\SQL2008;AttachDbFilename=d:\sqlexpress2008\mssql10.sql2008\mssql\data\salforce.mdf;Database=salforce; Trusted_Connection=Yes;"
        Using connection As New SqlConnection(connectionString)
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            CheckSQLString = "Select COUNT(*) FROM EMPTABLE WHERE EMP_COMPID = " & COMP_NR

            Dim command As New SqlCommand(CheckSQLString, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()
            reader.Read()
            CompanyEmployeesCount = reader.Item(0).ToString
            connection.Close()
        End Using
    End Sub

    Sub UpdateEmployeeCount()
        Dim UpdateString, SalforceConnectionString As String
        Dim EmployeeCompany As New clsCompany
        Dim Updatereader As SqlDataReader

        SalforceConnectionString = My.Settings("SalforceConnectionString")
        Using connection As New SqlConnection(SalforceConnectionString)
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            UpdateString = "UPDATE COMPANYTABLE SET COMP_EMPCOUNT = (SELECT COUNT(*) FROM EMPTABLE WHERE (EMP_COMPID = COMPANYTABLE.COMP_ID))"

            Dim UpdateCommand = New SqlCommand(UpdateString, connection)
            Updatereader = UpdateCommand.ExecuteReader()

            Updatereader.Close()
            connection.Close()
        End Using
        MsgBox("Count emp done")
    End Sub

End Class