Imports System.Data.SqlClient

Public Class clsChildren

    Public Function FillChildGrid(ByRef CompanyNr As Integer, ByRef EmployeeNr As Integer)

        Dim SelectChildString, SalForceConnectionstring As String

        SalForceConnectionstring = My.Settings.NewSalforceConnection
        Using Connection As New SqlConnection(SalForceConnectionstring)
            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If

            Dim cmdSQL As SqlCommand
            Dim Reader As SqlDataReader

            SelectChildString = String.Format("SELECT * FROM CHILDTABLE WHERE CHD_CompanyNr = {0} AND CHD_EmployeeNr = {1} ", CompanyNr, EmployeeNr)
            cmdSQL = New SqlCommand(SelectChildString, Connection)
            Reader = cmdSQL.ExecuteReader()

            With frmEmployee

                If .DataGridView2.RowCount > 0 Then
                    .DataGridView2.Rows.Clear()
                End If

                If Reader.HasRows Then

                    .DataGridView2.Columns("NAAM").Width = 180
                    .DataGridView2.Columns("ACHTERNAAM").Width = 200
                    .DataGridView2.Columns("GEB.DATUM").Width = 80
                    .DataGridView2.Columns("SCHOOL").Width = 260
                    .DataGridView2.Columns("CATEGORY").Width = 100
                    .DataGridView2.Columns("TOESLAG").Width = 100
                    .DataGridView2.Columns("TOESLAG").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .DataGridView2.Width = .DataGridMain.Width
                    .DataGridView2.Refresh()

                    Dim rowcount As Byte
                    Dim ChildBDate As String = Nothing
                    While Reader.Read
                        With .DataGridView2
                            .Rows.Add()
                            .Rows(rowcount).Cells("NAAM").Value = IIf(IsDBNull(Reader.Item("CHD_CHILDNAME")), Nothing, Reader.Item("CHD_CHILDNAME").ToString)
                            .Rows(rowcount).Cells("ACHTERNAAM").Value = IIf(IsDBNull(Reader.Item("CHD_CHILDLASTNAME")), Nothing, Reader.Item("CHD_CHILDLASTNAME").ToString)
                            .Rows(rowcount).Cells("GEB.DATUM").Value = IIf(IsDBNull(Reader.Item("CHD_CHILDBIRTHDATE")), Nothing, ConvertDateToSalforceDate(Reader.Item("CHD_CHILDBIRTHDATE").ToString))
                            .Rows(rowcount).Cells("SCHOOL").Value = IIf(IsDBNull(Reader.Item("CHD_CHILDSCHOOL")), Nothing, Reader.Item("CHD_CHILDSCHOOL").ToString)
                            .Rows(rowcount).Cells("CATEGORY").Value = IIf(IsDBNull(Reader.Item("CHD_CHILDCATEGORY")), Nothing, Reader.Item("CHD_CHILDCATEGORY").ToString)
                            .Rows(rowcount).Cells("TOESLAG").Value = IIf(IsDBNull(Reader.Item("CHD_CHILDTOESLAG")), Nothing, Reader.Item("CHD_CHILDTOESLAG").ToString)
                            rowcount += rowcount
                        End With
                    End While

                End If
            End With
            Connection.Close()
            Connection.Dispose()

        End Using
    End Function

End Class