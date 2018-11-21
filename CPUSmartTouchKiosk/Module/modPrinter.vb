'Imports Microsoft.
'Imports System.Data.SqlClient


'Module modPrinter
'    'Dim oPrinter As POSPrinter

'    Public Sub printGrade(idStudent As Integer, idperiod As Integer)

'        Try
'            Dim displayString As String
'            Dim ESC As String = Chr(&H1B)

'            displayString = ESC + "!" + Chr(1) + ESC + "|cA" + "Central Philippine University " + ESC + "1lF"
'            displayString += ESC + "|cA" + "Lopez Jaena St., Jaro, Iloilo City Philippines" + ESC + "|1lF"
'            displayString += ESC + "|2C" + ESC + "|cA" + ESC + "|bC" + "View Grades" + "|1lf" + ESC + "|1lf"
'            displayString += ESC + "|N" + ESC + "|" + Chr(1) + " Requested by: " + vbTab.ToString + "Jepoy Dizon" + ESC + "|1lF"

'            displayString += "Date: " + Date.Today() + vbTab.ToString() + "Time: "
'            displayString += DateTime.Now().ToLongTimeString() + ESC + "|1lf" + ESC + "|1lf" + ESC + "|1lf"

'            displayString += ESC + "|2UC" + " Item         Description              Quanity" + ESC + "|N" + ESC + "!" + Chr(1) + ESC + "|1lf" + ESC + "|1lf" + " "

'            Dim objRp As Object = 

'        Catch ex As Exception

'        End Try
'        'If Not bPrinterClaimed Then
'        '    bPrinterClaimed = claimPrinter(sORPrinter)
'        'End If

'        'If Not bPrinterClaimed Then Return

'        'If oPrinter Then

'    End Sub


'End Module
