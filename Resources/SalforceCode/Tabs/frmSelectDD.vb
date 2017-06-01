Public Class frmSelectDD
    Private Sub frmSelectDD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me

            If .DGSelectDD.ColumnCount = 0 Then
                .DGSelectDD.Columns.Add("Jaar", "Jaar")
                .DGSelectDD.Columns.Add("Periode", "Periode")
                .DGSelectDD.Columns.Add("LC_Nr", "Loon Code")
                .DGSelectDD.Columns.Add("OMS", "Omschrijving")
                .DGSelectDD.Columns.Add("PB", "Percentage / Bedrag")
                .DGSelectDD.Columns.Add("Aantal", "Aantal")
                .DGSelectDD.Columns.Add("D/C", "Debit")
                .DGSelectDD.Columns.Add("Bedrag", "Bedrag")
                .DGSelectDD.Columns.Add("YTD", "Year To Date")
                .DGSelectDD.Columns.Add("Max", "Maximum")

                .DGSelectDD.Columns("Jaar").Width = 50
                .DGSelectDD.Columns("Periode").Width = 50
                .DGSelectDD.Columns("LC_Nr").Width = 50
                .DGSelectDD.Columns("OMS").Width = 200
                .DGSelectDD.Columns("Aantal").Width = 50
                .DGSelectDD.Columns("PB").Width = 80
                .DGSelectDD.Columns("D/C").Width = 50
                .DGSelectDD.Columns("YTD").Width = 150
                .DGSelectDD.Columns("Max").Width = 150

                .DGSelectDD.Columns("LC_Nr").ValueType = GetType(System.Int32)
                .DGSelectDD.Columns("MAX").DefaultCellStyle.Format = "0.00"
                .DGSelectDD.Columns("PB").DefaultCellStyle.Format = "0.00"
                .DGSelectDD.Columns("YTD").DefaultCellStyle.Format = "0.00"
                .DGSelectDD.Columns("PB").DefaultCellStyle.Format = "0.00"
                .DGSelectDD.Columns("PB").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight
                .DGSelectDD.Columns("Bedrag").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight
                .DGSelectDD.Columns("Bedrag").DefaultCellStyle.Format = "0.00"
            End If

            Dim SalForceConnectionString As String

            SalForceConnectionString = My.Settings("NewSalForceConnection")
            Using Connection As New SqlConnection(SalForceConnectionString)
                If Connection.State = ConnectionState.Closed Then
                    Connection.Open()
                End If

                Dim EMP_RetrieveCommand As SqlCommand
                Dim EMP_Retrievereader As SqlDataReader
                Dim SelectedCompany, SelectedEmployee As Integer
                'Here we are selecting the Employee of an existing Company to load

                SelectedCompany = .DataGridView1.SelectedCells.Item(0).Value.ToString
                SelectedEmployee = .DataGridView1.SelectedCells.Item(1).Value
                '---------------------------------------------------------------------

                'Create the Query to retrieve the Employee from the database
                Dim EMP_RetrieveString = String.Format("SELECT DISTINCT * FROM VIEW_1 WHERE EMP_EMPLOYEENR ={0} AND EMP_COMPID = {1}", SelectedEmployee, SelectedCompany)

                EMP_RetrieveCommand = New SqlCommand(EMP_RetrieveString, Connection)

                EMP_Retrievereader = EMP_RetrieveCommand.ExecuteReader()
                Dim Counter As Integer = 0

                Dim EmployeeStructure As EMPSTRUCTURE

                Dim EmployeeData As New clsEmployee
                EmployeeStructure = EmployeeData.Retrieve_Employee_Data(SelectedCompany, SelectedEmployee)

                .DGSelectDD.Rows.Clear()

                If EMP_Retrievereader.HasRows Then

                    While EMP_Retrievereader.Read
                        .DGSelectDD.Rows.Add()
                        .DGSelectDD.Rows(Counter).Cells("Jaar").Value = EMP_Retrievereader("Jaar").ToString
                        .DGSelectDD.Rows(Counter).Cells("Periode").Value = EMP_Retrievereader("Period").ToString
                        .DGSelectDD.Rows(Counter).Cells("LC_Nr").Value = EMP_Retrievereader("DDNR").ToString
                        .DGSelectDD.Rows(Counter).Cells("OMS").Value = EMP_Retrievereader("Description").ToString
                        .DGSelectDD.Rows(Counter).Cells("D/C").Value = EMP_Retrievereader("DEBCRED").ToString
                        .DGSelectDD.Rows(Counter).Cells("PB").Value = EMP_Retrievereader("Bedrag")
                        .DGSelectDD.Rows(Counter).Cells("Aantal").Value = EMP_Retrievereader("Aantal")
                        .DGSelectDD.Rows(Counter).Cells("YTD").Value = EMP_Retrievereader("YearToDate")
                        .DGSelectDD.Rows(Counter).Cells("Bedrag").Value = EmployeeStructure.Hour_Salary * (1 + EMP_Retrievereader("Bedrag")) * .DGSelectDD.Rows(Counter).Cells("Aantal").Value
                        Counter = Counter + 1
                        '
                    End While
                End If
                EMP_Retrievereader.Close()
                Connection.Dispose()
                Connection.Close()
            End Using

        End With
    End Sub
End Class