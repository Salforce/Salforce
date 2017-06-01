Imports System.Data
Imports System.Data.SqlClient

Module SQLDMS
    Function CheckIfDataBaseExist(ByVal DatabName As String) As Boolean
        Dim exists As Byte = 0

        Dim SqlConnectionString As String = _
              "Server=(local)\sqlexpress;" & _
              "DataBase=;" & _
              "Integrated Security=SSPI"
        Dim SalForceTestconnection As SqlConnection = New SqlConnection(SqlConnectionString)
        If SalForceTestconnection.State = ConnectionState.Closed Then
            SalForceTestconnection.Open()
        End If

        Dim cmd As SqlCommand = New SqlCommand("SELECT case when exists (select 1 from sys.Databases where Name = @DbName) then 1 else 0 end as DbExists", SalForceTestconnection)

        cmd.Parameters.AddWithValue("@DbName", DatabName)

        exists = CByte(cmd.ExecuteScalar())

        SalForceTestconnection.Dispose()
        SalForceTestconnection.Close()

        Return CBool(exists)

    End Function
    Function CreateSalforceSystem()
        Dim TableList As New ArrayList
        Dim SalforceConnection As SqlConnection = Nothing
        ' Dim cmd As SqlCommand = Nothing
        TableList.Add("One")
        TableList.Add("Two")
        TableList.Add("Three")
        Dim SqlConnectionString As String = _
            "Server=(local)\sqlexpress;" & _
            "DataBase=;" & _
            "Integrated Security=SSPI"
        Dim sqlStatement As String = "CREATE DATABASE SALFORCETEST"

        Dim SalForceTestconnection As New SqlConnection(SqlConnectionString)

        If SalForceTestconnection.State = ConnectionState.Closed Then
            SalForceTestconnection.Open()
        End If
        ' A SqlCommand object is used to execute the SQL commands.
        Dim cmd As New SqlCommand(sqlStatement, SalForceTestconnection)

        Try
            cmd.ExecuteNonQuery()
        Catch ae As SqlException
            MessageBox.Show(ae.Message.ToString())
        End Try

        MsgBox("ready")
        Return (0)
    End Function
    Function CreateCompany(ByVal Companyname As String, ByVal CompanyAddress As String, ByVal CompanyKVK As String, ByVal CompanyCribNr As String, ByVal CompanyDaz As String)
        Dim connectionString, SQLString As String
        connectionString = "Server=.\SQL2008;AttachDbFilename=d:\sqlexpress2008\mssql10.sql2008\mssql\data\salforce.mdf;Database=salforce; Trusted_Connection=Yes;"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            SQLString = "Insert into COMPANYTABLE (" & _
                "COMP_NAME," & _
                "COMP_ADDRESS," & _
                "COMP_KVK," & _
                "COMP_CRIBNR," & _
                "COMP_DAZ)" & _
                "VALUES ('" & _
                Companyname & "','" & _
                CompanyAddress & "','" & _
                CompanyKVK & "','" & _
                CompanyCribNr & "','" & _
                CompanyDaz & "')"
            Dim command As New SqlCommand(SQLString, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()

        End Using
        Return (0)
    End Function

    Public Function DoesTableExist(ByVal tblName As String) As Boolean
        ' For Access Connection String,
        ' use "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        ' accessFilePathAndName

        ' Open connection to the database
        Dim SalforceConnectionString As String
        SalforceConnectionString = My.Settings.NewSalforceConnection
        Using connection As New SqlConnection(SalforceConnectionString)
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim restrictions(3) As String
            restrictions(2) = tblName
            Dim dbTbl As DataTable = connection.GetSchema("Tables", restrictions)

            If dbTbl.Rows.Count = 0 Then
                'Table does not exist
                DoesTableExist = False
            Else
                'Table exists
                DoesTableExist = True
            End If

            connection.Dispose()
            connection.Close()
        End Using
        Return DoesTableExist
    End Function

    Function CreateDep(ByVal DEPNR As Integer, ByVal DEPNAME As String)
        Dim connectionString, CheckSQLString, SQLString As String
        connectionString = "Server=.\SQL2008;AttachDbFilename=d:\sqlexpress2008\mssql10.sql2008\mssql\data\salforce.mdf;Database=salforce; Trusted_Connection=Yes;"
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            CheckSQLString = "Select DEP_NR From DEPTABLE where DEP_NR = '" & DEPNR & "'"
            ' This Sql Command serves to see if there already exist a Deparmnet number with this given number.

            Dim command As New SqlCommand(CheckSQLString, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows = False Then
                reader.Close()

                SQLString = "Insert into DEPTABLE (" & _
               "DEP_NR," & _
                "DEP_NAME)" & _
                " VALUES (" & _
                 DEPNR & ",'" & _
                 DEPNAME & "')"

                Dim command2 As New SqlCommand(SQLString, connection)
                Dim reader2 As SqlDataReader = command2.ExecuteReader()
                reader2.Close()
                connection.Close()
            Else
                'Return false if no Department has been created and exit the function.
                Return ("False")
                connection.Close()
                Exit Function
            End If
        End Using

        Return (0)
    End Function
    Function LoadChildrenGrid()
        'Dim CHD_Retrievereader As SqlDataReader
        'Dim CHD_RetrieveCommand As New SqlCommand
        'Dim CHD_Retrievestring, SalForceConnectionString As String
        'Dim SelectedEmployee As Integer
        'Try
        '    SalForceConnectionString = My.Settings("NewSalForceConnection")
        '    Using connection As New SqlConnection(SalForceConnectionString)
        '        If connection.State = ConnectionState.Closed Then
        '            connection.Open()
        '        End If

        '        SelectedEmployee = frmEmployeeProfileBackup.DataGridView1.SelectedCells.Item(1).Value
        '        CHD_Retrievestring = "SELECT * FROM CHILDTABLE WHERE CHD_EMPLOYEENR = " & SelectedEmployee

        '        '-------------------------------------Familie TAb Data-----------------------------------------

        '        CHD_Retrievereader = Nothing

        '        CHD_RetrieveCommand = New SqlCommand(CHD_Retrievestring, connection)
        '        CHD_Retrievereader = CHD_RetrieveCommand.ExecuteReader()

        '        '-------------------------------------Lets clear the children grid first----------------------
        '        frmEmployeeProfileBackup.DataGridView2.Rows.Clear()
        '        '------------------------------------------------------------------------------------------------
        '        With frmEmployeeProfileBackup.DataGridView2
        '            If CHD_Retrievereader.HasRows = True Then
        '                Dim RowCount As Byte = 0
        '                Dim TotalKindToeslag As Double = 0.0
        '                frmEmployeeProfileBackup.DataGridView2.ReadOnly = False
        '                While (CHD_Retrievereader.Read())
        '                    .Rows.Add()
        '                    .Rows(RowCount).Cells("ChildNr").Value = CHD_Retrievereader.Item("CHD_ChildNr")
        '                    .Rows(RowCount).Cells("ChildName").Value = UCase(CHD_Retrievereader.Item("CHD_ChildName").ToString)
        '                    .Rows(RowCount).Cells("LastName").Value = UCase(CHD_Retrievereader.Item("CHD_ChildLastName").ToString)
        '                    .Rows(RowCount).Cells("BirthDate").Value = ConvertDateToSalforceDate(CHD_Retrievereader.Item("CHD_ChildBirthDate").ToString)
        '                    .Rows(RowCount).Cells("School").Value = UCase(CHD_Retrievereader.Item("CHD_ChildSchool").ToString)
        '                    .Rows(RowCount).Cells("Category").Value = UCase(CHD_Retrievereader.Item("CHD_ChildCategory").ToString)
        '                    .Rows(RowCount).Cells("Ktoeslag").Value = FormatNumber(CHD_Retrievereader.Item("CHD_ChildToeslag"), 2)
        '                    TotalKindToeslag = TotalKindToeslag + CHD_Retrievereader.Item("CHD_ChildToeslag")
        '                    RowCount += 1
        '                End While
        '                frmEmployeeProfileBackup.TotalKtoeslag.Text = TotalKindToeslag.ToString("0.00")
        '                frmEmployeeProfileBackup.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        '                frmEmployeeProfileBackup.txtChildrowcount.Text = RowCount.ToString
        '            End If

        '            connection.Dispose()
        '            connection.Close()
        '        End With
        '    End Using
        'Catch ex As Exception
        '    MsgBox(ex.Source)
        '    Return (-1)
        'End Try
        'frmEmployeeProfileBackup.Refresh()
        ''---------------------------------------------------------------------------------------------
        'CHD_Retrievereader.Close()

        'Return (0)
    End Function
    Function DeleteChild(ByVal ParentNr As Integer, ByVal CompanyNr As Integer)
        Dim CHD_Retrievereader As SqlDataReader
        Dim CHD_RetrieveCommand As New SqlCommand
        Dim CHD_Retrievestring, SalForceConnectionString As String

        SalForceConnectionString = My.Settings("NewSalForceConnection")
        Using connection As New SqlConnection(SalForceConnectionString)
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' SelectedEmployee = frmEmployeeProfileBackup.DataGridView1.SelectedCells.Item(1).Value
            CHD_Retrievestring = "DELETE FROM CHILDTABLE WHERE CHD_PARENTNR = " & ParentNr

            '-------------------------------------Familie TAb Data-----------------------------------------

            CHD_Retrievereader = Nothing

            CHD_RetrieveCommand = New SqlCommand(CHD_Retrievestring, connection)
            CHD_Retrievereader = CHD_RetrieveCommand.ExecuteReader()
        End Using
        MsgBox("Child deleted")
    End Function
    Public Function AVBZ_Amount(ByVal GrondslagAOV_AWW_AVBZ As Double, ByVal ZuiverInkomen_Grens As Double, ByRef EmployersPart As Double, ByRef ProcentTotal As Double)
        '  AVBZ amount to pay = 0.5% of the zuiverInkomen. Employer =1.5%
        '  If Employee is married and zuiverinkomen < 5900,- ABVZ amount = 1% of zuiverinkomen
        '  If Employee is unmarried and zuiverinkomen < 5200,- ABVZ amount = 1% of zuiverinkomen

        Dim Verwervingskosten As Double = 500 / 12

        If GrondslagAOV_AWW_AVBZ > ZuiverInkomen_Grens Then
            GrondslagAOV_AWW_AVBZ = ZuiverInkomen_Grens
        End If

        AVBZ_Amount = 0.01 * (GrondslagAOV_AWW_AVBZ - Verwervingskosten) * (ProcentTotal - EmployersPart)
        Return (AVBZ_Amount)

    End Function
End Module