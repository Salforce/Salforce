Imports System.Data.SqlClient

Namespace ERIC

    Public Class clsTest2

        Dim cmdSQL As New SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "SALF9000", .Connection = Connection()}

        Private Function Connection() As SqlConnection
            Throw New NotImplementedException()
        End Function

        Dim Reader As SqlDataReader = cmdSQL.ExecuteReader()
        Dim SalForceConnectionstring As String = My.Settings.NewSalforceConnection

        Public Function Name(CompanyNr As Integer, EmployeeNr As Integer) As String

            Using Connection As New SqlConnection(SalForceConnectionstring)

                If Connection.State = ConnectionState.Closed Then
                    Connection.Open()
                End If

                cmdSQL.Parameters.Add("@Param1", SqlDbType.SmallInt)
                cmdSQL.Parameters.Add("@Param2", SqlDbType.Int)
                cmdSQL.Parameters("@Param1").Value = CompanyNr
                cmdSQL.Parameters("@Param2").Value = EmployeeNr

                Reader.Read()
                Dim EmployeeFirstName = Reader("EMP_FIRSTNAME").ToString
                Dim EMployeeLastName = Reader("EMP_LASTNAME").ToString

                Return (0)
            End Using
        End Function

    End Class

End Namespace