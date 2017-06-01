Imports System.Xml
Imports System.Net
Imports System.IO
Imports System.Globalization

Module SalForceUtilities

    Private _font As Object

    Private Property None As Object
    Private Const CB_SETITEMHEIGHT As Int32 = &H153

    Private Property Font(ByVal p1 As Object, ByVal fontStyle As FontStyle) As Object
        Get
            Return _font
        End Get
        Set(ByVal value As Object)
            _font = value
        End Set
    End Property
    Function ConvertDateToSalforceDate(ByVal InputDate As String)
        Dim Salforcedate, YearNumber, MonthNumber, DayNumber As String

        If InputDate = Nothing Then
            Salforcedate = ""
            Return Salforcedate
            Exit Function
        End If

        If Len(InputDate) = 8 Then
            Salforcedate = InputDate
            Return Salforcedate
            Exit Function
        End If

        YearNumber = Right(InputDate, 4)
        MonthNumber = Mid(InputDate, 4, 2)
        DayNumber = Left(InputDate, 2)

        Salforcedate = YearNumber & MonthNumber & DayNumber

        Return Salforcedate
    End Function
    Function Skin(ByVal SalforceObject As System.Object)
        With SalforceObject
            Select Case True
                Case TypeOf SalforceObject Is TextBox
                    .backcolor = Color.White
                    .BorderStyle = BorderStyle.FixedSingle
                    .MultiLine = False
                    .Font = New Font("Tahoma", 8.25, FontStyle.Bold, GraphicsUnit.Point)
                    .Height = 21
                    '-------------------------------------------------------------------------------------------

                Case TypeOf SalforceObject Is Windows.Forms.Label

                    .Autosize = False
                    .Width = 112
                    .Height = 21
                    .BackColor = Color.Chocolate
                    .BorderStyle = BorderStyle.FixedSingle
                    .Font = New Font("Tahoma", 8.25, FontStyle.Bold, GraphicsUnit.Point)
                    .ForeColor = Color.White
                    '-------------------------------------------------------------------------------------------
                Case TypeOf SalforceObject Is PowerPacks.LineShape
                    .BorderColor = Color.Orange

                Case TypeOf SalforceObject Is DateTimePicker
                    .width = 87
                    .height = 21
                    .Font = New Font("Tahoma", 8.25, FontStyle.Bold, GraphicsUnit.Point)
                    '-------------------------------------------------------------------------------------------

                Case TypeOf SalforceObject Is MaskedTextBox
                    .backcolor = Color.White
                    .BorderStyle = BorderStyle.FixedSingle
                    .MultiLine = False
                    .Font = New Font("Tahoma", 8.25, FontStyle.Bold, GraphicsUnit.Point)
                    .Height = 21
                    '-------------------------------------------------------------------------------------------

                Case TypeOf SalforceObject Is Form
                    .backColor = Color.Maroon

                    '-------------------------------------------------------------------------------------------

                Case TypeOf SalforceObject Is PictureBox
                    If SalforceObject.name = "pctLogo" Then
                        .Width = 710
                        .Height = 60
                    End If
                    '-------------------------------------------------------------------------------------------

                Case TypeOf SalforceObject Is Button

                    If SalforceObject.text <> "++" Then
                        .Width = 90
                        .Height = 23
                        .BackColor = Color.Silver
                        .Font = New Font("Tahoma", 8.25, FontStyle.Regular, GraphicsUnit.Point)
                    End If
                    '-------------------------------------------------------------------------------------------

                Case TypeOf SalforceObject Is System.Windows.Forms.DataGridView

                    .BorderStyle = BorderStyle.None
                    .AllowUserToAddRows = False
                    .AllowUserToDeleteRows = False
                    .AllowUserToOrderColumns = False
                    .AllowUserToResizeColumns = False
                    .ReadOnly = False
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .MultiSelect = False
                    .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                    .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                    .AllowUserToResizeRows = False
                    .ColumnHeadersHeight = 18
                    .BackgroundColor = Color.Maroon
                    .RowHeadersDefaultCellStyle.SelectionBackColor = Color.OrangeRed
                    .ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 8.25, FontStyle.Regular, GraphicsUnit.Point)
                    .RowsDefaultCellStyle.BackColor = Color.BurlyWood
                    .RowsDefaultCellStyle.SelectionBackColor = Color.OrangeRed
                    .RowsDefaultCellStyle.Font = New Font("Tahoma", 8.25, FontStyle.Bold, GraphicsUnit.Point)
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.Tan
            End Select
        End With
        Return (0)
    End Function
    Function GetMyIpAddress() As String
        Dim wc As New WebClient
        Return (wc.DownloadString("http://www.whatismyip.com/automation/n09230945.asp").ToString())
    End Function

End Module