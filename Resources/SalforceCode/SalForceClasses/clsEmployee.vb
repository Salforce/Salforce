Imports System.Data.SqlClient

Public Class clsEmployee

    Public EmployeeNr As Integer
    Public FirstName, LastName As String

    Public EmployeeSex As String

    Public Address As String
    Public BirthDate As String
    Public CedulaNr, Picture As String

    Public CompanyNr As Integer
    Public Department As String
    Public Salary_Per_Year As Double
    Public PayPeriod As Integer
    Public Salary_Per_Month As Double
    Public Salary_Per_Week As Double
    Public Salary_Per_Day As Double
    Public Salary_Per_Hour As Double
    Public Valuta As String

    Public StartDate As String
    Public EndDate As String
    Public AgeOnFirstJan As Byte
    Public Email1, Email2 As String
    Public Position As String
    Public HomePhone, CellNr As String

    Public HourWage As Double
    Public DaysPerWeek, HoursPerDay As Byte
    Public Status As Byte
    Public Verwervingskosten As Double

    Public PensioenFonds As String
    Public PartnerFirstName, PartnerLastName, PartnerBirthDate, PartnerEmployer, PartnerBelInkomen As String
    Public Beschikking As Double
    Public AOV_Percentage As Double
    Public SpaarfondsName As String

    Public Function Retrieve_Employee_Data(ByRef CompanyNr As Integer, ByRef EmployeeNr As Integer)

        Dim SalForceConnectionstring As String = My.Settings.NewSalforceConnection.ToString

        Using Connection As New SqlConnection(SalForceConnectionstring)

            '  Using Connection As New SqlConnection(WebConnectionString)
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

            '---------------------------------------------------------------JAAR SALARIS, MAAND, WEEK, DAG, LOONPERIODE en UUR SALARIS-------------------------------

            '---------------------------------------------------------------PAY PERIOD--------------------------------
            PayPeriod = 2
            '---------------------------------------------------------------PAY PERIOD--------------------------------

            Dim SelectedMultiplyer As Integer 'This is the choosen Multiplyer for the LOONPERIOD

            Select Case PayPeriod
                Case CONSTANT_PERIOD_YEAR
                    Salary_Per_Year = CDbl(Reader("EMP_SALARY"))
                    Salary_Per_Week = Salary_Per_Year / CONSTANT_WEEKS_IN_YEAR
                    Salary_Per_Day = Salary_Per_Day / Reader("EMP_DPW")
                    Salary_Per_Hour = Salary_Per_Hour / Reader("EMP_UPD")

                    SelectedMultiplyer = CONSTANT_WEEKS_IN_YEAR
                Case CONSTANT_PERIOD_QUART
                    Salary_Per_Year = CDbl(Reader("EMP_SALARY")) * CONSTANT_QUARTS_IN_YEAR
                    Salary_Per_Week = Salary_Per_Year / CONSTANT_WEEKS_IN_YEAR
                    Salary_Per_Day = Salary_Per_Day / Reader("EMP_DPW")
                    Salary_Per_Hour = Salary_Per_Hour / Reader("EMP_UPD")
                    SelectedMultiplyer = CONSTANT_QUARTS_IN_YEAR

                Case CONSTANT_PERIOD_MONTH
                    Dim Salary_Per_Year As Double = Reader("EMP_Salary") * CONSTANT_MONTHS_IN_YEAR
                    Salary_Per_Month = Reader("EMP_SALARY")
                    Salary_Per_Week = Salary_Per_Year / CONSTANT_WEEKS_IN_YEAR
                    Salary_Per_Day = Salary_Per_Week / Reader("EMP_DPW")

                    Salary_Per_Hour = Salary_Per_Day / Reader("EMP_UPD")

                    SelectedMultiplyer = CONSTANT_MONTHS_IN_YEAR
                Case CONSTANT_PERIOD_WEEK
                    Salary_Per_Year = CDbl(Reader("EMP_SALARY")) * CONSTANT_WEEKS_IN_YEAR
                    Salary_Per_Week = Salary_Per_Year / CONSTANT_WEEKS_IN_YEAR
                    Salary_Per_Day = Salary_Per_Day / Reader("EMP_DPW")

                    Salary_Per_Hour = Salary_Per_Hour / Reader("EMP_UPD")

                    SelectedMultiplyer = CONSTANT_WEEKS_IN_YEAR
                Case CONSTANT_PERIOD_DAY
                    Salary_Per_Year = Convert.ToDouble(Reader("EMP_SALARY")) * CONSTANT_DAYS_IN_YEAR
                    Salary_Per_Week = Salary_Per_Year / CONSTANT_WEEKS_IN_YEAR
                    Salary_Per_Day = Salary_Per_Day / Reader("EMP_UPD")
                    Salary_Per_Hour = Salary_Per_Hour / Reader("EMP_UPD")

                    SelectedMultiplyer = CONSTANT_DAYS_IN_YEAR
                Case CONSTANT_PERIOD_HALFDAY
                    Salary_Per_Year = CDbl(Reader("EMP_SALARY")) * CONSTANT_HALF_DAYS_IN_YEAR
                    Salary_Per_Week = Salary_Per_Year / CONSTANT_WEEKS_IN_YEAR
                    Salary_Per_Day = Salary_Per_Day / Reader("EMP_UPD")
                    Salary_Per_Hour = Salary_Per_Hour / Reader("EMP_UPD")

                    SelectedMultiplyer = CONSTANT_DAYS_IN_YEAR
            End Select
            '--------------------------------------------------------------- SALARIS, MAAND, WEEK, DAG en UUR SALARIS-------------------------------

            '--------------------------------------------------------------- EMPLOYEE DAGEN PER WEEK-------------------------------
            DaysPerWeek = CByte(Reader("EMP_DPW").ToString)
            '--------------------------------------------------------------- EMPLOYEE DAGEN PER WEEK-------------------------------

            '--------------------------------------------------------------- EMPLOYEE VALUTA-------------------------------
            Valuta = Reader("EMP_VALUTA").ToString
            '--------------------------------------------------------------- EMPLOYEE VALUTA-------------------------------

            '--------------------------------------------------------------- EMPLOYEE UREN PER DAG-------------------------------
            HoursPerDay = CByte(Reader("EMP_UPD").ToString)
            '--------------------------------------------------------------- EMPLOYEE UREN PER DAG-------------------------------

            '---------------------------------------------------------------AGE ON FIRST JANUARY--------------------------------
            BirthDate = Reader("EMP_BIRTHDATE").ToString

            If Len(BirthDate) = 0 Then
                AgeOnFirstJan = 0
            Else
                Dim BDMonth As String = Mid(Reader("EMP_BIRTHDATE"), 5, 2)
                Dim BDDay As String = Right(Reader("EMP_BIRTHDATE"), 2)
                Dim BDYear As String = Left(Reader("EMP_BIRTHDATE"), 4)

                BirthDate = Convert.ToDateTime(String.Format("{0}/{1}/{2}", BDMonth, BDDay, BDYear))

                Dim CurrentDate As System.DateTime = System.DateTime.Today
                Select Case CInt(BDMonth)
                    Case Is < Month(System.DateTime.Today)
                        AgeOnFirstJan = DateDiff("YYYY", BirthDate, Now())
                    Case Is = Month(CurrentDate)
                        Select Case BDDay
                            Case Is < DateAndTime.Day(CurrentDate)
                                BirthDate = CDate(String.Format("{0}/{1}/{2}", BDMonth, BDDay, BDYear))
                                AgeOnFirstJan = DateDiff("YYYY", BirthDate, Now())
                            Case Is = DateAndTime.Day(CurrentDate)
                                BirthDate = CDate(String.Format("{0}/{1}/{2}", BDMonth, BDDay, BDYear))
                                AgeOnFirstJan = DateDiff("YYYY", BirthDate, Now())
                            Case Is > DateAndTime.Day(CurrentDate)
                                BirthDate = CDate(String.Format("{0}/{1}/{2}", BDMonth, BDDay, BDYear))
                                AgeOnFirstJan = DateDiff("YYYY", BirthDate, Now()) - 1
                        End Select
                    Case Is > Month(CurrentDate)
                        BirthDate = CDate(String.Format("{0}/{1}/{2}", BDMonth, BDDay, BDYear))
                        AgeOnFirstJan = DateDiff("YYYY", BirthDate, Now()) - 1
                    Case Else
                        AgeOnFirstJan = 0
                End Select
            End If

            EmployeeNr = Reader("EMP_EMPLOYEENR").ToString
            Verwervingskosten = Reader("EMP_VERWKOSTEN").ToString
            CompanyNr = Reader("EMP_COMPID").ToString
            FirstName = Reader("EMP_FIRSTNAME").ToString
            LastName = Reader("EMP_LASTNAME").ToString
            StartDate = Reader("EMP_STARTDATE").ToString
            EndDate = IIf(IsDBNull(Reader("EMP_ENDDATE").ToString), "", Reader("EMP_ENDDATE").ToString)
            Picture = IIf(IsDBNull(Reader("EMP_PICTURE").ToString), "", Reader("EMP_PICTURE").ToString)
            CedulaNr = Reader("EMP_CEDULANR").ToString
            Address = Reader("EMP_ADDRESS").ToString
            Department = IIf(IsDBNull(Reader("EMP_DEPARTMENT")), "", Reader("EMP_DEPARTMENT"))
            BirthDate = Reader("EMP_BIRTHDATE").ToString
            Status = Convert.ToByte(Reader("EMP_STATUS").ToString)
            PartnerLastName = Reader("EMP_SPOUSELASTNAME").ToString
            PartnerFirstName = Reader("EMP_SPOUSENAME").ToString
            PartnerBirthDate = Reader("EMP_SPOUSEBIRTHDATE").ToString
            PartnerEmployer = Reader("EMP_SPOUSEEMPLOYER").ToString
            PartnerBelInkomen = Reader("EMP_BELINKOMENVROUW").ToString
            Email1 = Reader("EMP_Email1").ToString
            Email2 = Reader("EMP_Email2").ToString
            Position = Reader("EMP_POSITION").ToString
            HomePhone = Reader("EMP_HOMEPHONE").ToString
            CellNr = Reader("EMP_CELL").ToString
            Picture = Reader("EMP_PICTURE") & ".JPG"
            Beschikking = IIf(IsDBNull(Reader("EMP_BESLUITINSPVAL")), "0.00", Reader("EMP_BESLUITINSPVAL"))
            PensioenFonds = IIf(IsDBNull(Reader("EMP_PENSFIXED")), 0, Reader("EMP_PENSFIXED"))
            '  AOV_Percentage = Reader("EMPAOVAWW").ToString

            If Reader.Item("EMP_SEX").ToString = "M" Then
                EmployeeSex = "M"
            Else
                EmployeeSex = "V"
            End If

            If IsDBNull(Reader("EMP_BelInkomenVrouw").ToString) Or Reader("EMP_BelInkomenVrouw").ToString = "" Then
                PartnerBelInkomen = 0
            Else
                PartnerBelInkomen = Convert.ToDouble(Reader("EMP_BelInkomenVrouw"))
            End If

            '---------------------------------------------------------------AOV/AWW/AVBZ GRONDSLAG--------------------------------
            'GrondslagAOVAWWAVBZ = TotalYearIncome - CONSTANT_VERWERVINGSKOSTEN -
            'ReturnStructure.PensionFonds - Beschikking
            '---------------------------------------------------------------AOV/AWW/AVBZ GRONDSLAG--------------------------------

            '---------------------------------------------------------------AOV/AWW AMOUNT--------------------------------
            'De grondslag voor de berekening van de verschuldigde premies AOV/AWW/AVBZ is als volgt:
            'Het belastbaar inkomen - ontvangen uitkeringen AOV/AWW + afgetrokken werknemersdeel premies AOV/AWW.
            'De premie-inkomensgrens is in 2004 fl. 46.613,60 voor AOV/AWW en voor AVBZ fl. 344.276.
            Connection.Close()
            Connection.Dispose()

        End Using
    End Function

    'De premie bestaat uit 2 gedeelte: a) Een inkomensafhankelijk premie.  b) Een Nominale Premie van 82,-
    'De inkomensafhankelijke premie voor de basisverzekering wordt geheven over ten hoogste ANG 100.000 per jaar.
    'Ingeval het inkomen niet hoger is dan ANG 12.000 per jaar wordt geen inkomensafhankelijke premie geheven.

    '            Per 1 maart 2013 is door de overheid een nieuwe AOV-regeling in werking getreden.
    '
    '           1)      De premie voor de AOV/AWW wordt verhoogd van 14% naar 16%. De extra 2 procent komt ten laste van de werkgever.
    '                    De toeslag AOV/AWW van de werkgever wordt hiermee 9.5% en de werknemersbijdrage AOV/AWW blijft 6.5%.
    '           2)      De loongrens voor de AOV/AWW premie is verhoogd van Nafl 96,069 naar Nafl 100,000 per jaar.
    '           3)      Een 2e premieschijf voor de AOV/AWW is ingevoerd voor al het inkomen boven Nafl 100,000.
    '                    Het percentage voor deze schijf is 1% en komt geheel ten laste van de werknemer.

    '            De nominale premie bedraagt ANG()82: Deze'premie moet per verzekerde worden betaald. Ook hier geldt dat
    '            als het inkomen niet hoger is dan ANG 12.000, geen premie verschuldigd is. Ook'voor kinderen die bij aanvang van een jaar nog
    '            geen 18 jaar zijn behoeft voor dat jaar geen nominale premie te worden betaald.
    '            De nominale premie is uitsluitend verschuldigd door(verzekerden.Dit betekent dat iemand die niet verzekerd is voor de BVZ, bijvoorbeeld omdat men
    '            particulier verzekerd is, ook geen nominale premie verschuldigd is.

    '---------------------------------------------------------------AOV/AWW AMOUNT---------------------------------------------------------------------------

    '---------------------------------------------------------------ALLEEN VERDIENER TOESLAG------------------------------------------------------
    'De belastingplichtige heeft recht op de alleenverdienertoeslag ad fl. 750    '(exclusief opcenten) per jaar indien:
    '
    'hij het hele kalenderj'aar gehuwd is geweest;
    '
    'hij in de Nederlandse Antillen woont en
    '
    'het belastbaar inkomen van zijn echtgenoot
    'in het kalenderjaar nihil of negatief is.

    ' ReturnStructure.AlleenVerdienerToeslag = IIf(IsDBNull(Reader("EMP_AlleenVerdT")), "0.00", Reader("EMP_AlleenVerdT").ToString)
    'If ReturnStructure.AlleenVerdienerToeslag > clsBelVar.AlleenVerdToeslag Then
    ' ReturnStructure.AlleenVerdienerToeslag = clsBelVar.AlleenVerdToeslag
    ' End If
    '---------------------------------------------------------------ALLEEN VERDIENER TOESLAG------------------------------------------------------

    '---------------------------------------------------------------BASIS KORTING---------------------------------------------------------------------------
    'ReturnStructure.BasisKorting = CONSTANT_BASIS_KORTING
    '---------------------------------------------------------------BASIS KORTING---------------------------------------------------------------------------

    '---------------------------------------------------------------AVBZ ----------------------------------------------------
    ' ReturnStructure.AVBZ_Percentage = Convert.ToDouble(Reader("EMP_AVBZ").ToString)
    '---------------------------------------------------------------AVBZ------------------------------------------------------

    '---------------------------------------------------------------AVBZ AMOUNT ----------------------------------------------------
    '   De AVBZ is een volksverzekering die in hoofdlijnen aanspraak geeft op een tegemoetkoming in de kosten van medische behandeling en verpleging van chronische zieken. In de Landsverordening is opgenomen dat een fonds zal worden gevormd ter dekking van de te verzekeren kosten. Het fonds zal onder andere worden gevormd door het heffen van premie. Premieplichtigen zijn alle verzekerden van 15 jaar of ouder met inkomen.

    'Verzekerd is degene die:
    'Ingezetene is of
    'Geen ingezetene is, maar in de Nederlandse Antillen in dienstbetrekking arbeid verricht die aan loonbelasting is onderworpen.
    'Let op! De premieplicht eindigt niet bij het bereiken van de 60 jarige leeftijd. De premie is verschuldigd vanaf de eerste dag van de maand volgende op het bereiken van de vijftiende jarige leeftijd. De algemene premie bedraagt 2%. Voor pensioenen bedraagt de premie 1,5%. Voor premieplichtigen die een premie-inkomen genieten tot naf 15.758 (bedrag 2012) geldt een premie van 1%.

    'Voor die gevallen waarin de premie 2% bedraagt, komt 1,5% voor rekening van de werknemer en 0,5% voor rekening van de inhoudingsplichtige.
    'In het geval het percentage 1% bedraagt , komt 0,5% voor rekening van de inhoudingsplichtige en 0,5% voor rekening van de werknemer.
    'Voor gepensioneerden is het tarief 1,5% en komt geheel voor rekening van de gepensioneerde.

    'Als het in het kalenderjaar 2012 genoten zuiver inkomen meer dan Naf. 435.495,- bedraagt, is het over het meerdere geen premie verschuldigd.
    'Max. premie AVBZ voor het jaar 2012 is Naf. 8.709,90, de werkgeverdeel is Naf. 2.177,48 en de werknemersdeel is Naf. 6.532,44

    '            Tur hende den servisio pagá ta kontribuí den e fondo aki pagando un prima fo’i nan
    'entrada: 1,5% ta kore pa kuenta di e trahadó i 0,5% pa kuenta di dunadó di trabou. Prima
    'total ta 2%. Pa personanan den servisio pagá ta dunadó di trabou ta retené e prima aki i
    '            entreg() 'é na Ontvanger. Pa personanan ku ta kai bou di areglo di belasting riba entrada,
    'Inspektor di belasting ta kobra 2% riba entrada puru i kobradó sentral ta retené esaki.
    'Penshonado ta paga 1,5%. E máksimo ku un hende por paga na prima ta Naf. 8.709,90
    '(2012). Si den 2012 e entrada ta mas ku Naf. 435.495, no ta paga prima riba e montante
    'ku ta surpasá e suma aki.

    'ReturnStructure.AVBZ_Amount = (ReturnStructure.AVBZ_Percentage / 100) * ReturnStructure.GrondslagAOVAWWAVBZ
    '---------------------------------------------------------------AVBZ AMOUNT ------------------------------------------------------

    '---------------------------------------------------------------BASIS VERZEKERING----------------------------------------------------
    'ReturnStructure.BasisVerzekering_Percentage = Convert.ToDouble(Reader("EMP_BVZ_PERC").ToString)
    '---------------------------------------------------------------BASIS VERZEKERING------------------------------------------------------

    '---------------------------------------------------------------ZOG Percentage----------------------------------------------------
    '            Premiebetaling()
    'Voor overheidsdienaren en daarmee gelijkgestelden zijn in het PB 1986 no: 165 drie onderverdelingen m.b.t. premiebetaling gemaakt:

    '• De overheidsdienaar of hiermee gelijkgestelde die maximaal NAf. 10.260,- per jaar verdient, heeft recht op vrije geneeskundige behandeling
    ' voor zich persoonlijk. Deze categorie betaalt in principe geen premie (schaal 0).
    '• De overheidsdienaar of hiermee gelijkgestelde die in schaal 1 t/m 5 valt of een brutoloon heeft van minder dan Naf 2.163,-
    'heeft voor zich persoonlijk recht op vrije geneeskundige behandeling. Deze categorie betaalt 1% premie over het brutoloon.
    '• De overheidsdienaar of hiermee gelijkgestelde die in schaal 6 en hoger valt of een brutoloon heeft die gelijk of hoger is dan NAf 2.163,-
    'heeft recht  op 90 procent vergoeding. Deze categorie betaalt afhankelijk van het brutoloon 1.05%, 1.15% of 1.25% premie hierover.

    ' Select Case ReturnStructure.Salary
    'Case Is < 10260 / CONSTANT_MONTHS_IN_YEAR
    ' ReturnStructure.ZOG_Percentage = "0.0"
    ' Case Is >= (10260 / CONSTANT_MONTHS_IN_YEAR) And (ReturnStructure.Salary <= 2163)
    ' ReturnStructure.ZOG_Percentage = "1.0"
    'Case Is > 2163
    ' ReturnStructure.ZOG_Percentage = "1.05"
    ' End Select

    '  ReturnStructure.ZOG_Percentage = IIf(IsNothing(Reader("EMP_ZOGPERC")), "0.0", Reader("EMP_ZOGPERC"))
    '---------------------------------------------------------------ZOG Percentage------------------------------------------------------

    '---------------------------------------------------------------BASIS VOLKSVERZEKERING ----------------------------------------------------

    'Met ingang van 1 februari 2013: betalen(werkgevers) 9% BVZ premie over een inkomen tot ten hoogste ANG 100.000
    'voor werknemer s die onder de BVZ vallen en daarnaast 1,9% over het inkomen van werknemers die ten hoogste ANG 61.620 verdienen.
    'De premie voor werknemers is met ingang van 1  februari 2013:verhoogd van 2,1% naar 4% over ten hoogste ANG 150.000
    'Gebruik de gliding scale als jaarinkomen val tussen 12000 en 18000

    'If ReturnStructure.TotalYearIncome < 12000.0 Then
    'ReturnStructure.BasisVerzekering_Amount = 0
    ' Else
    'ReturnStructure.BasisVerzekering_Amount = (ReturnStructure.BasisVerzekering_Percentage / 100) * ReturnStructure.TotalYearIncome
    'End If

    '---------------------------------------------------------------BASIS VOLKSVERZEKERING------------------------------------------------------

    '---------------------------------------------------------------CAR CATOLOG VALUE----------------------------------------------------
    ' ReturnStructure.CarcatologValue = IIf(IsDBNull(Reader("EMP_CARCATVALUE")), "0.00", Reader("EMP_CARCATVALUE").ToString)
    '---------------------------------------------------------------CAR CATOLOG VALUE)------------------------------------------------------

    '---------------------------------------------------------------Grondslag Loonbelasting----------------------------------------------------
    'ReturnStructure.GrondslagLoonBelasting = ReturnStructure.GrondslagAOVAWWAVBZ - ReturnStructure.AOV_Amount - ReturnStructure.AVBZ_Amount _
    ' ReturnStructure.ZV_Amount - ReturnStructure.Beschikking
    '---------------------------------------------------------------Grondslag Loonbelasting------------------------------------------------------

    '---------------------------------------------------------------ZUIVER LOON------------------------------------------------------
    'Het zuiver loon is gelijk aan het totale bruto loon verminderd met:
    'verwervingskosten, werknemersdeel AOV/AWW, loonbeschikking, werknemersdeel pensioenpremie,
    ' werknemersdeel spaarfonds en werknemerspremie ZOG.
    '---------------------------------------------------------------ZUIVER LOON------------------------------------------------------

    '---------------------------------------------------------------SPAAR & PENSIOEN FONDS-----------------------------------------

    '  SpaarFondsNaam = IIf(IsDBNull(Reader.Item("EMP_SPAARFNAME")), "", UCase(Reader.Item("EMP_SPAARFNAME").ToString))
    '  ReturnStructure.SpaarFondsWGPerc = IIf(IsDBNull(Reader.Item("EMP_SPAARWGPERC")), "0.0", Reader.Item("EMP_SPAARWGPERC"))
    ' ReturnStructure.SpaarFondsWNPerc = IIf(IsDBNull(Reader.Item("EMP_SPAARWNPERC")), "0.0", Reader.Item("EMP_SPAARWNPERC"))

    ' ReturnStructure.PensioenfondsNaam = IIf(IsDBNull(Reader.Item("EMP_PENSFNAME")), "", Reader.Item("EMP_PENSFNAME").ToString)
    ' ReturnStructure.PensWNPerc = IIf(IsDBNull(Reader.Item("EMP_PENSWNPERC")), "0.0", Reader.Item("EMP_PENSWNPERC"))
    '  ReturnStructure.PensWGPerc = IIf(IsDBNull(Reader.Item("EMP_PENSWGPERC")), "0.0", Reader.Item("EMP_PENSWGPERC"))

    '  ReturnStructure.VastBedragPF = IIf(IsDBNull(Reader.Item("EMP_PENSFIXED")), "0.00", Reader.Item("EMP_PENSFIXED").ToString)
    '  ReturnStructure.VastBedragSpF = IIf(IsDBNull(Reader.Item("EMP_SPAARFIXED")), "0.00", Reader.Item("EMP_SPAARFIXED").ToString)

    '  ReturnStructure.Pensioenfondsstate = IIf(IsDBNull(Reader.Item("EMP_PENSFIXED")), False, True)
    '  ReturnStructure.SpaarfondsState = IIf(IsDBNull(Reader.Item("EMP_SPAARFIXED")), False, True)

    'End Using
    ' Reader.Close()

    '  Connection.Close()
    ' Connection.Dispose()

    ' End Function

    Public Function Save_Employee_Partner_Data(EmployeeNr As Int16, CompanyId As Int16)
        With frmEmployee
            Dim PARTNERFIRSTNAME As String = UCase(.txtPartnerFirstname.Text)
            Dim PARTNERLASTNAME As String = UCase(.txtPartnerLastname.Text)
            Dim PARTNEREMPLOYER As String = UCase(.txtPartnerEmployer.Text)
            Dim PARTNERMAIDENNAME As String = UCase(.txtPartnerMidname.Text)
            Dim PARTNERBELINKOMEN As String

            Dim Number As Double

            If Double.TryParse(.txtPartnerBelInkomen.Text, Number) = True Then
                .txtPartnerBelInkomen.Text = Format(Convert.ToDouble(.txtPartnerBelInkomen.Text), "N")
                .SelectNextControl(.ActiveControl, True, True, True, True)
            Else
                .txtPartnerBelInkomen.Text = Format(0, "N")
            End If

            Dim PARTNERBIRTHDATE As String
            If .DatePickerPartnerBirthdate.Checked = True Then
                PARTNERBIRTHDATE = ConvertDateToSalforceDate(.DatePickerPartnerBirthdate.Text)
            Else
                PARTNERBIRTHDATE = .txtPartnerBirthDate.Text
            End If

            Dim SalforceConnectionString As String = My.Settings("NewSalForceConnection")
            Using Connection As New SqlConnection(SalforceConnectionString)
                If Connection.State = ConnectionState.Closed Then
                    Connection.Open()
                End If

                Dim EMP_UPDATECommand As SqlCommand
                Dim EMP_UPDATEREADER As SqlDataReader

                Dim EMP_UPDATESTRING As String = "UPDATE EMPTABLE SET " &
                "EMP_SPOUSENAME = ' " & PARTNERFIRSTNAME & "'," &
                "EMP_SPOUSELASTNAME = ' " & PARTNERLASTNAME & "'," &
                "EMP_SPOUSEMIDDENNAME = '" & PARTNERMAIDENNAME & "'," &
                "EMP_SPOUSEEMPLOYER = '" & PARTNEREMPLOYER & "'," &
                "EMP_BELINKOMENVROUW = '" & PARTNERBELINKOMEN & "'," &
                "EMP_SPOUSEBIRTHDATE = '" & PARTNERBIRTHDATE & "'" &
                " WHERE EMP_COMPID = " & CompanyId & " AND EMP_EMPLOYEENR = " & EmployeeNr

                EMP_UPDATECommand = New SqlCommand(EMP_UPDATESTRING, Connection)
                EMP_UPDATEREADER = EMP_UPDATECommand.ExecuteReader
                MsgBox("PARTNER Tab Saved !", vbExclamation, "SALFORCE")
                DisablePartnerTab()
                Connection.Close()
                Connection.Dispose()

            End Using

        End With
    End Function

End Class