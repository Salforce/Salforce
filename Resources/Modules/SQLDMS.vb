Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Module SQLDMS

    Function CheckIfDataBaseExist(ByVal DatabName As String) As Boolean
        Dim exists As Byte = 0

        Dim SqlConnectionString As String =
              "Server=(local)\sqlexpress;" &
              "DataBase=;" &
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

    Function test2()

        Dim BelastingJaar As String
        Dim Eiland As String
        Dim AOVAWW_WKG, AOVAWW_WKN, AOVAWW_InkomenGrens, AOVAWW_Ondergrens, AOVAWW_TweedePremieSchijf As String
        Dim AVBZ_WKG, AVBZ_WKN, AVBX As String
        Dim BVZ_WKN, BVZ_WKG, BVZ_InkomenGrens, BVZ_NominalePremie As String
        Dim LoonGrensZVOV_6, LoonGrensZVOV_5, LoonGrensZVOV_W, LoonGrensZVOV_M, LoonGrensZVOV_J As String
        Dim OuderToeslag_M, OuderToeslag_V, AlleenVerdToeslag As String
        Dim KindToeslag_1, KindToeslag_2, KindToeslag_3, KindToeslag_4 As String
        Dim Zogschaal_0, Zogschaal_0PCT, ZogSchaal1_5, ZogSchaal1_5PCT, ZogSchaal_6, Zogschaal_6PCT As String
        Dim SchijvenTabel(5, 3) As String
        Dim br As BinaryReader = New BinaryReader(New FileStream(Application.StartupPath & "\SF_BELDATA.DAT", FileMode.Open))

        BelastingJaar = br.ReadString
        Eiland = br.ReadString

        AOVAWW_WKG = br.ReadString
        AOVAWW_WKN = br.ReadString

        AVBZ_WKG = br.ReadString
        AVBZ_WKN = br.ReadString

        AOVAWW_TweedePremieSchijf = br.ReadString
        AOVAWW_Ondergrens = br.ReadString
        BVZ_WKG = br.ReadString
        BVZ_WKN = br.ReadString

        AOVAWW_InkomenGrens = br.ReadString
        BVZ_InkomenGrens = br.ReadString
        AVBX = br.ReadString
        BVZ_NominalePremie = br.ReadString

        LoonGrensZVOV_6 = br.ReadString
        LoonGrensZVOV_5 = br.ReadString
        LoonGrensZVOV_W = br.ReadString
        LoonGrensZVOV_M = br.ReadString
        LoonGrensZVOV_J = br.ReadString

        OuderToeslag_M = br.ReadString
        OuderToeslag_V = br.ReadString
        AlleenVerdToeslag = br.ReadString
        KindToeslag_1 = br.ReadString
        KindToeslag_2 = br.ReadString
        KindToeslag_3 = br.ReadString
        KindToeslag_4 = br.ReadString

        Zogschaal_0 = br.ReadString
        Zogschaal_0PCT = br.ReadString
        ZogSchaal1_5 = br.ReadString
        ZogSchaal1_5PCT = br.ReadString
        ZogSchaal_6 = br.ReadString
        Zogschaal_6PCT = br.ReadString
        For Counter = 0 To 5
            For Colcount = 0 To 3
                SchijvenTabel(Counter, Colcount) = br.ReadString
            Next

        Next

        br.Close()
        Return SchijvenTabel
    End Function

    Function CreateSalforceSystem()
        Dim TableList As New ArrayList
        Dim SalforceConnection As SqlConnection = Nothing
        ' Dim cmd As SqlCommand = Nothing
        TableList.Add("One")
        TableList.Add("Two")
        TableList.Add("Three")
        Dim SqlConnectionString As String =
            "Server=(local)\sqlexpress;" &
            "DataBase=;" &
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

            SQLString = "Insert into COMPANYTABLE (" &
                "COMP_NAME," &
                "COMP_ADDRESS," &
                "COMP_KVK," &
                "COMP_CRIBNR," &
                "COMP_DAZ)" &
                "VALUES ('" &
                Companyname & "','" &
                CompanyAddress & "','" &
                CompanyKVK & "','" &
                CompanyCribNr & "','" &
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

                SQLString = "Insert into DEPTABLE (" &
               "DEP_NR," &
                "DEP_NAME)" &
                " VALUES (" &
                 DEPNR & ",'" &
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

    Public Function GetMessageString(MsgNr As Integer, Language As String) As String
        Dim SalForceConnectionString = My.Settings("NewSalForceConnection")
        Using Connection As New SqlConnection(SalForceConnectionString)
            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim EMP_RetrieveCommand As SqlCommand
            Dim Message_Retrievereader As SqlDataReader

            '---------------------------------------------------------------------

            'Create the Query to retrieve the Employee from the database

            Select Case Language
                Case "English"
                    Dim MessageString = String.Format("SELECT Eng FROM MESSAGES WHERE MsgNr ={0} ", MsgNr)
                    EMP_RetrieveCommand = New SqlCommand(MessageString, Connection)
                Case "Dutch"
                    Dim MessageString = String.Format("SELECT Ned FROM MESSAGES WHERE MsgNr ={0} ", MsgNr)
                    EMP_RetrieveCommand = New SqlCommand(MessageString, Connection)
                Case "Spanish"
                    Dim MessageString = String.Format("SELECT Spa FROM MESSAGES WHERE MsgNr ={0} ", MsgNr)
                    EMP_RetrieveCommand = New SqlCommand(MessageString, Connection)
            End Select

            Message_Retrievereader = EMP_RetrieveCommand.ExecuteReader()
            Message_Retrievereader.Read()

            Return (Message_Retrievereader.Item(0).ToString)
            Message_Retrievereader.Close()
            Connection.Dispose()
            Connection.Close()

        End Using

    End Function

End Module