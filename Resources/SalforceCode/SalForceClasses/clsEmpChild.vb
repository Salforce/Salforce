Imports System.Data.SqlClient

Public Class clsEmpChild
    Public ChildUpdateSuccess As Boolean
    Public ChildAddSuccess As Boolean
    Public DeleteAllEmployeeChildRecordsAffected As Integer
    Public DeleteChildRecordsAffected As String

    Sub RemoveAllEmployeeChild(ByVal CompanyNr As Integer, ByVal EmployeeNr As Integer)
        Dim SqlDeleteAllEmployeeChild, SalForceConnectionString As String
        Dim DeleteAllChildReader As SqlDataReader = Nothing
        Dim DeleteAllEmployeeChildCommand As SqlCommand

        SalForceConnectionString = My.Settings.NewSalforceConnection
        Using connection As New SqlConnection(SalForceConnectionString)
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            SqlDeleteAllEmployeeChild = "Delete From CHILDTABLE where CHD_CompanyNr = " & CompanyNr & " And CHD_EmployeeNr = " & EmployeeNr

            Try
                DeleteAllEmployeeChildCommand = New SqlCommand(SqlDeleteAllEmployeeChild, connection)
                DeleteAllChildReader = DeleteAllEmployeeChildCommand.ExecuteReader()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally

                DeleteAllEmployeeChildRecordsAffected = DeleteAllChildReader.RecordsAffected
            End Try

        End Using

    End Sub

    Sub RemoveChild(ByRef ChildNr As Integer)
        Dim SqlDeleteChild, SalForceConnectionString As String
        Dim DeleteChildReader As SqlDataReader = Nothing
        Dim DeleteChildCommand As SqlCommand

        SalForceConnectionString = My.Settings.NewSalforceConnection
        Using connection As New SqlConnection(SalForceConnectionString)
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            SqlDeleteChild = String.Format("Delete From CHILDTABLE where CHD_ChildNr = {0}", ChildNr)

            Try
                DeleteChildCommand = New SqlCommand(SqlDeleteChild, connection)
                DeleteChildReader = DeleteChildCommand.ExecuteReader()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally

                DeleteChildRecordsAffected = DeleteChildReader.RecordsAffected.ToString
            End Try

        End Using
    End Sub

End Class