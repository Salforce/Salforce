Imports System.Data.SqlClient

Public Class frmSelectDD

    Private Sub frmSelectDD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me

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

                SelectedCompany = frmEmployee.DataGridMain.SelectedCells.Item(0).Value.ToString
                SelectedEmployee = frmEmployee.DataGridMain.SelectedCells.Item(1).Value
                '---------------------------------------------------------------------

                'Create the Query to retrieve the Employee from the database
                ' Dim EMP_RetrieveString = String.Format("SELECT DISTINCT * FROM VIEW_1 WHERE EMP_EMPLOYEENR ={0} AND EMP_COMPID = {1}", SelectedEmployee, SelectedCompany)
                Dim EMP_RetrieveString = String.Format("Select component_id, description from DEDUCTIONS where DD_RECORDNR Not In (Select DDNR from EMPDEDUCTIONS where EMPNR ={0} and COMPANYNR = {1})", SelectedEmployee, SelectedCompany)

                EMP_RetrieveCommand = New SqlCommand(EMP_RetrieveString, Connection)

                EMP_Retrievereader = EMP_RetrieveCommand.ExecuteReader()
                Dim Counter As Integer = 0

                ' Dim EmployeeStructure As EMPSTRUCTURE

                ' Dim EmployeeData As New clsEmployee
                ' EmployeeStructure = EmployeeData.Retrieve_Employee_Data(SelectedCompany, SelectedEmployee)

                Dim strComponent As String
                If EMP_Retrievereader.HasRows Then

                    While EMP_Retrievereader.Read

                        Counter = Counter + 1

                        strComponent = EMP_Retrievereader("Component_Id").ToString.Trim
                        If Len(strComponent) < 6 Then
                            strComponent = strComponent.PadRight(6, Chr(32))
                            cmbDDList.Items.Add(strComponent + "  " + EMP_Retrievereader("Description").ToString.Trim)
                        End If

                    End While
                End If

                EMP_Retrievereader.Close()
                Connection.Dispose()
                Connection.Close()
            End Using

            Me.CheckBox1.Text = "Vast Bedrag"
            Me.CheckBox2.Text = "Percentage"
            Me.GroupBox1.Text = "Selecteer type Deductie"
            Me.Label1.Text = "Selekteer Item"

        End With
    End Sub

    Private Sub CheckBox2_Click(sender As Object, e As EventArgs) Handles CheckBox2.Click
        CheckBox2.Checked = True
        If CheckBox1.Checked = True Then
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        CheckBox1.Checked = True
        If CheckBox2.Checked = True Then
            CheckBox2.Checked = False
        End If
    End Sub

End Class