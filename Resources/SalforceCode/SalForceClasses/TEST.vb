Imports System.Data.SqlClient

Public Class clsTest2

    Public Function Name(CompanyNr As Integer, EmployeeNr As Integer) As String
        Dim SalForceConnectionstring As String = My.Settings.NewSalforceConnection
        Dim EmployeeFirstName As String

        Using Connection As New SqlConnection(SalForceConnectionstring)

            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim cmdSQL As New SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "SALF9000", .Connection = Connection}
            cmdSQL.Parameters.Add("@Param1", SqlDbType.SmallInt)
            cmdSQL.Parameters.Add("@Param2", SqlDbType.Int)
            cmdSQL.Parameters("@Param1").Value = CompanyNr
            cmdSQL.Parameters("@Param2").Value = EmployeeNr
            Dim Reader As SqlDataReader = cmdSQL.ExecuteReader()
            Reader.Read()
            EmployeeFirstName = Reader("EMP_FIRSTNAME").ToString

        End Using

        Return (EmployeeFirstName)
    End Function

End Class