Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Module module_JSON

    Public Function JSON_GET(url As String)
        frmMain.UseWaitCursor = True
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        Try

            'url = "https://api.mintpal.com/v1/market/stats/PND/LTC"

            request = DirectCast(WebRequest.Create(url), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())

            Dim rawresp As String
            rawresp = reader.ReadToEnd()
            'Console.WriteLine(rawresp)
            Return rawresp
        Catch ex As Exception
            Console.WriteLine("Something is wrong with connection, auto refresh is disabled..." & vbCrLf & ex.Message)
            frmMain.tmrGetTicker.Enabled = False
            MsgBox("Something is wrong with connection, auto refresh is disabled..." & vbCrLf & ex.Message, MsgBoxStyle.SystemModal + vbCritical)


        Finally
            If Not response Is Nothing Then response.Close()
            Console.WriteLine("Finally")
            frmMain.UseWaitCursor = False
        End Try

    End Function

    Public Function RepairTicker(tmpResponseFromServer As String)
        tmpResponseFromServer = Replace(tmpResponseFromServer, "24h_avg", "avg_24h")
        Return tmpResponseFromServer
    End Function
End Module


