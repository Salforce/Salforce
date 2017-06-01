Imports System.Data.SqlClient

Public Class clsSalaryPeriod
    Private PeriodNr As Integer
    Private Year As Integer
    Private Description As String
    Private Type As Byte
    Private RecodNr As Integer
    Public TotalRecordsSaved As Integer
    Public TotalRecordsUpdated As Integer

    Sub CreateYear(ByVal pmYear As Integer, ByVal Language As Byte, ByVal Periodtype As Byte)
        Dim SqlConnectionString, InsertSqlString As String
        Dim PeriodCounter As Byte
        Dim CreatePeiodsuccess As Boolean
        Dim UpdateCommand As SqlCommand
        Dim InsertDataReader As SqlDataReader = Nothing
        Dim MonthName(3, 12) As String 'row 1 = DUTCH   row 2 = English    row 3 = Spanish
        'Periodtype 1= Month   2=Quincena(14 Days)   3= Week

        '--------------------------------LANGUAGE = DUTCH-----------------------------------
        MonthName(1, 1) = "Januari" : MonthName(1, 2) = "Februari" : MonthName(1, 3) = "Maart" : MonthName(1, 4) = "April"
        MonthName(1, 5) = "Mei" : MonthName(1, 6) = "Juni" : MonthName(1, 7) = "July" : MonthName(1, 8) = "Augustus"
        MonthName(1, 9) = "September" : MonthName(1, 10) = "Oktober" : MonthName(1, 11) = "November" : MonthName(1, 12) = "December"

        '--------------------------------LANGUAGE = English-----------------------------------
        MonthName(2, 1) = "Januari" : MonthName(2, 2) = "Februari" : MonthName(2, 3) = "March" : MonthName(2, 4) = "April"
        MonthName(2, 5) = "May" : MonthName(2, 6) = "June" : MonthName(2, 7) = "July" : MonthName(2, 8) = "August"
        MonthName(2, 9) = "September" : MonthName(2, 10) = "October" : MonthName(2, 11) = "November" : MonthName(2, 12) = "December"

        '--------------------------------LANGUAGE = Spanish-----------------------------------
        MonthName(3, 1) = "Enero" : MonthName(3, 2) = "Febrero" : MonthName(3, 3) = "Marzo" : MonthName(3, 4) = "Abril"
        MonthName(3, 5) = "Marzo" : MonthName(3, 6) = "Junio" : MonthName(3, 7) = "Julio" : MonthName(3, 8) = "Agosto"
        MonthName(3, 9) = "Septiembre" : MonthName(3, 10) = "Octubre" : MonthName(3, 11) = "Noviembre" : MonthName(3, 12) = "Diciembre"

        SqlConnectionString = My.Settings("SalForceconnectionString")

        Using connection As New SqlConnection(SqlConnectionString)

            Try
                For PeriodCounter = 1 To 12
                    If connection.State = ConnectionState.Closed Then
                        connection.Open()
                    End If
                    Description = MonthName(Language, PeriodCounter).ToString
                    InsertSqlString = "INSERT INTO SALARYPERIODS (PRD_YEAR,PRD_PeriodNr,PRD_DESCRIPTION,PRD_TYPE) VALUES (" &
                    pmYear & ", " & PeriodCounter & ",' " & Description & "', " & Periodtype & ")"
                    UpdateCommand = New SqlCommand(InsertSqlString, connection)
                    InsertDataReader = UpdateCommand.ExecuteReader()
                    TotalRecordsSaved = InsertDataReader.RecordsAffected
                    connection.Close()
                Next PeriodCounter
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
            Finally
                If InsertDataReader.RecordsAffected >= 1 Then
                    CreatePeiodsuccess = True
                Else
                    CreatePeiodsuccess = False
                End If
            End Try
        End Using
    End Sub

    Sub Update(ByVal URecordNr As Integer, ByVal UDescription As String)
        Dim SqlConnectionString, UpdateSqlString As String
        Dim UpdateCommand As SqlCommand
        Dim UpdateDataReader As SqlDataReader = Nothing

        SqlConnectionString = My.Settings("SalForceconnectionString")
        UpdateSqlString = "Update SALARYPERIODS SET PRD_DESCRIPTION = '" & UDescription & "' WHERE PRD_RecordNr =" & URecordNr
        Using connection As New SqlConnection(SqlConnectionString)

            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            UpdateCommand = New SqlCommand(UpdateSqlString, connection)
            UpdateDataReader = UpdateCommand.ExecuteReader()
            TotalRecordsUpdated = UpdateDataReader.RecordsAffected
            connection.Close()
        End Using
    End Sub

End Class