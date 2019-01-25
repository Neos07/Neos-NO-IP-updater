Imports System.Net
Imports System.IO

Public Class MainForm

    Private Sub Form_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        If WindowState = FormWindowState.Minimized Then
            WindowState = FormWindowState.Minimized
            Visible = False
            NotifyIcon.Visible = True
        End If
    End Sub

    Private Sub NotifyIcon_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon.Click
        Visible = True
        WindowState = FormWindowState.Normal
        NotifyIcon.Visible = False
    End Sub

    Private Sub ConsoleWrite(ByVal Text As String, Optional ByVal icon As Integer = 0)
        ListBox.Items.Add(Text)
        ListBox.SelectedIndex = ListBox.Items.Count - 1
    End Sub

    Private CurrentIp As String
    Private LastIp As String

    Private Function GetIp()
        On Error Resume Next
        Dim SourceCode As String = New Net.WebClient().DownloadString("http://www.infosniper.net/")
        Dim Ip As String = Split(SourceCode, "<title>")(1)
        Ip = Split(Ip, "Locate IP Address Lookup Show on Map City of the IP ")(1)
        Ip = Split(Ip, "</title>")(0)
        Return Ip
    End Function

    Private Sub DefineResponse(ByVal response As String)
        Select Case response
            Case "good " & CurrentIp
                ConsoleWrite("Sucess, Ip Updated:" & " " & CurrentIp & ".", 2)
                LastIp = CurrentIp
            Case "nochg " & CurrentIp
                ConsoleWrite("No Update needed, same Ip:" & " " & CurrentIp & ".")
                LastIp = CurrentIp
            Case "badsys"
                ConsoleWrite("The system parameter is not valid.", 1)
            Case "badagent"
                ConsoleWrite("The user agent has been blocked.", 1)
            Case "badauth"
                ConsoleWrite("The username or password are incorrect.", 1)
            Case "!donator"
                ConsoleWrite("An option available only to credited users (such as offline URL) was specified, but the user is not a credited user.", 1)
            Case "notfqdn"
                ConsoleWrite("The hostname specified is not a fully-qualified domain name.", 1)
            Case "nohost"
                ConsoleWrite("The hostname specified does not exist.", 1)
            Case "!yours"
                ConsoleWrite("The hostname specified exists, but not under the username specified.", 1)
            Case "abuse"
                ConsoleWrite("The hostname specified is blocked for update abuse.", 1)
            Case "dnserr"
                ConsoleWrite("DNS error encountered.", 1)
            Case "911"
                ConsoleWrite("There is a serious problem on our side, such as a database or DNS server failure.", 1)
            Case Else
                ConsoleWrite("Unknown: " & response & ".", 1)
        End Select
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If UsernameTextBox.Text = Nothing Or PasswordTextBox.Text = Nothing Or HostTextBox.Text = Nothing Then
            ConsoleWrite("Please fill all the fields")
        Else
            Try
                ConsoleWrite("Accessing no-ip.")
                CurrentIp = GetIp()
                Dim Link2 As String = "http://" & Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(UsernameTextBox.Text & ":" & PasswordTextBox.Text)) & "@dynupdate.no-ip.com/nic/update?hostname=" & HostTextBox.Text & "&myip=" & CurrentIp & ""

                Dim request As HttpWebRequest = HttpWebRequest.Create(Link2)
                request.Method = "GET"
                request.Headers("Authorization") = "Basic " & Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(UsernameTextBox.Text & ":" & PasswordTextBox.Text))
                request.UserAgent = "Neos NO-IP Updater/1.0 neos07.simo@gmail.com"
                request.AllowAutoRedirect = False
                Dim response As HttpWebResponse = request.GetResponse()

                If response.StatusCode = HttpStatusCode.OK Then
                    Dim responseStream As IO.StreamReader = New IO.StreamReader(response.GetResponseStream())
                    DefineResponse(responseStream.ReadToEnd())
                End If
                response.Close()

            Catch ex As Exception
                If Not ex.Message.Contains("(401)") Then
                    ConsoleWrite(ex.Message.ToString, 1)
                    MsgBox("Error:" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Exclamation)
                Else : ConsoleWrite(ex.Message.ToString & vbNewLine & " Maybe, host, username or password specified are incorrect", 1)
                End If
            End Try
        End If
    End Sub

    Private Sub UpdateTimer_Tick(sender As System.Object, e As System.EventArgs) Handles UpdateTimer.Tick
        Try
            If Not GetIp() = LastIp Then UpdateButton_Click(sender, e)
        Catch ex As Exception
            AutoUpdateCheckBox.Checked = False
            MsgBox("Error:" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Exclamation, "Neos NO-IP Updater")
        End Try
    End Sub

    Private Sub AutoUpdateCheckBox_CheckedChanged(sender As Object) Handles AutoUpdateCheckBox.CheckedChanged
        If AutoUpdateCheckBox.Checked Then
            UpdateTimer.Start()
        Else : UpdateTimer.Stop()
        End If
    End Sub

End Class
