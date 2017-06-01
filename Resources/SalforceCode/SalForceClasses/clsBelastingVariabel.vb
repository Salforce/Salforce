Imports System.IO

Public Class clsBelastingVariabel
    Public BelastingJaar As String
    Public Eiland As String
    Public AOVAWW_WKG, AOVAWW_WKN, AOVAWW_InkomenGrens, AOVAWW_Ondergrens, AOVAWW_TweedePremieSchijf As String
    Public AVBZ_WKG, AVBZ_WKN, AVBX, AVBZ_NominalePremie As String
    Public BVZ_WKN, BVZ_WKG, BVZ_InkomenGrens, BVZ_NominalePremie As String
    Public LoonGrensZVOV_6, LoonGrensZVOV_5, LoonGrensZVOV_W, LoonGrensZVOV_M, LoonGrensZVOV_J As String
    Public OuderToeslag_M, OuderToeslag_V, AlleenVerdToeslag As String
    Public KindToeslag_1, KindToeslag_2, KindToeslag_3, KindToeslag_4 As String
    Public Zogschaal_0, Zogschaal_0PCT, ZogSchaal1_5, ZogSchaal1_5PCT, ZogSchaal_6, Zogschaal_6PCT As String
    Public SchijvenTabel(5, 3) As String

    Public Function GetSchijvenTarieftabel()

        Dim br As BinaryReader = New BinaryReader(New FileStream("C:\SalForce\salforceBel\SalforceBel\bin\Debug\SF_BELDATA.DAT", FileMode.Open))

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
        AVBZ_NominalePremie = br.ReadString

        LoonGrensZVOV_6 = br.ReadString
        LoonGrensZVOV_5 = br.ReadString
        LoonGrensZVOV_W = br.ReadString
        LoonGrensZVOV_M = br.ReadString
        LoonGrensZVOV_J = br.ReadString

        OuderToeslag_M = br.ReadString
        OuderToeslag_M = br.ReadString
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
        br.Dispose()
        Return (SchijvenTabel)
    End Function

End Class