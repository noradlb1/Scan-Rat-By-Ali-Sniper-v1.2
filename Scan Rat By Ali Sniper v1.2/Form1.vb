Imports Microsoft.Win32
Imports System.Environment
Imports System.IO
'طبعا الأداه ليست اداتي الحقوق محفوظه للأخ علي سنايبر
Public Class Form1

    Private Sub FlatButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton6.Click
        Form2.Show()

    End Sub

    Private Sub FlatButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton7.Click
        Form3.Show()

    End Sub

    Private Sub FlatButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton8.Click
        Form4.Show()

    End Sub

    Private Sub FormSkin1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub FlatButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton5.Click

        Dim x As Control
        For Each x In Controls
            If TypeOf x Is RichTextBox Then
                x.Text = ""
            End If
        Next

        Dim startup As String = GetFolderPath(SpecialFolder.Startup)

        ''''''''''''''''''''''''''''''temp  folder :)


        Dim ooo As String
        Dim oo As String
        Dim strFileSize As String = ""
        Dim di As New IO.DirectoryInfo(My.Computer.FileSystem.SpecialDirectories.Temp)
        Dim aryFi As IO.FileInfo() = di.GetFiles("*.exe.tmp")
        Dim fi As IO.FileInfo


        For Each fi In aryFi
            strFileSize = (Math.Round(fi.Length / 1024)).ToString()
            ooo = fi.Name.Remove(fi.Name.Length - 4)
            oo = fi.FullName.Remove(fi.FullName.Length - 4)
            RichTextBox1.Text += Environment.NewLine + "server Name     : " & ooo
            RichTextBox1.Text += Environment.NewLine + "keyloger file      : " & fi.Name
            RichTextBox1.Text += Environment.NewLine + "Full path            : " & oo
            RichTextBox1.Text += Environment.NewLine + "Last Accessed   : " & fi.LastAccessTime
            RichTextBox1.Text += Environment.NewLine + " "

        Next


        ''''''''''''''''''''''''''''''appdata  folder :)


        Dim app As String = GetFolderPath(SpecialFolder.ApplicationData)


        Dim ooo1 As String
        Dim oo1 As String
        Dim strFileSize1 As String = ""
        Dim di1 As New IO.DirectoryInfo(app)
        Dim aryFi1 As IO.FileInfo() = di1.GetFiles("*.exe.tmp")
        Dim fi1 As IO.FileInfo


        For Each fi1 In aryFi1
            strFileSize1 = (Math.Round(fi1.Length / 1024)).ToString()
            ooo1 = fi1.Name.Remove(fi1.Name.Length - 4)
            oo1 = fi1.FullName.Remove(fi1.FullName.Length - 4)
            RichTextBox1.Text += Environment.NewLine + "server Name     : " & ooo1
            RichTextBox1.Text += Environment.NewLine + "keyloger file      : " & fi1.Name
            RichTextBox1.Text += Environment.NewLine + "Full path            : " & oo1
            RichTextBox1.Text += Environment.NewLine + "Last Accessed   : " & fi1.LastAccessTime
            RichTextBox1.Text += Environment.NewLine + " "

        Next

        ''''''''''''''''''''''''''
        Dim userr As String = Environment.GetEnvironmentVariable("UserProfile")

        Dim ooo2 As String
        Dim oo2 As String
        Dim strFileSize2 As String = ""
        Dim di2 As New IO.DirectoryInfo(userr)
        Dim aryFi2 As IO.FileInfo() = di2.GetFiles("*.exe.tmp")
        Dim fi2 As IO.FileInfo


        For Each fi2 In aryFi2
            strFileSize2 = (Math.Round(fi2.Length / 1024)).ToString()
            ooo2 = fi2.Name.Remove(fi2.Name.Length - 4)
            oo2 = fi2.FullName.Remove(fi2.FullName.Length - 4)
            RichTextBox1.Text += Environment.NewLine + "server Name     : " & ooo2
            RichTextBox1.Text += Environment.NewLine + "keyloger file      : " & fi2.Name
            RichTextBox1.Text += Environment.NewLine + "Full path            : " & oo2
            RichTextBox1.Text += Environment.NewLine + "Last Accessed   : " & fi2.LastAccessTime
            RichTextBox1.Text += Environment.NewLine + " "

        Next



        ''''''''''''''''''''''''''''''  folder :)

        Dim prog As String = GetFolderPath(SpecialFolder.CommonApplicationData)

        Dim ooo3 As String
        Dim oo3 As String
        Dim strFileSize3 As String = ""
        Dim di3 As New IO.DirectoryInfo(prog)
        Dim aryFi3 As IO.FileInfo() = di3.GetFiles("*.exe.tmp")
        Dim fi3 As IO.FileInfo


        For Each fi3 In aryFi3
            strFileSize3 = (Math.Round(fi3.Length / 1024)).ToString()
            ooo3 = fi3.Name.Remove(fi3.Name.Length - 4)
            oo3 = fi3.FullName.Remove(fi3.FullName.Length - 4)
            RichTextBox1.Text += Environment.NewLine + "server Name     : " & ooo3
            RichTextBox1.Text += Environment.NewLine + "keyloger file      : " & fi3.Name
            RichTextBox1.Text += Environment.NewLine + "Full path            : " & oo3
            RichTextBox1.Text += Environment.NewLine + "Last Accessed   : " & fi3.LastAccessTime
            RichTextBox1.Text += Environment.NewLine + " "

        Next


        ''''''''''''''''''''''''''''''''''''''''''''''''''reg :)

        Dim keyName As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Run"
        Dim subkeyNames() As String
        Dim valueNames() As String
        valueNames = Registry.CurrentUser.OpenSubKey(keyName).GetValueNames
        subkeyNames = Registry.CurrentUser.OpenSubKey(keyName).GetSubKeyNames

        For Each value In valueNames

            Dim Where As String

            Where = InStr(Registry.CurrentUser.OpenSubKey(keyName).GetValue(value), "..")

            If Where Then
                RichTextBox1.Text += Environment.NewLine + " ::  key in registry  ::"
                RichTextBox1.Text += Environment.NewLine + "SOFTWARE\Microsoft\Windows\CurrentVersion\Run"
                RichTextBox1.Text += Environment.NewLine + value & " - " & Registry.CurrentUser.OpenSubKey(keyName).GetValue(value)
                RichTextBox1.Text += Environment.NewLine + " "
                RichTextBox1.Text += Environment.NewLine + " ::  startup folder  ::"
                RichTextBox1.Text += Environment.NewLine + startup & "\" & value & ".exe"
                RichTextBox1.Text += Environment.NewLine + " "
            End If
            '    MsgBox(value & " - " & Registry.LocalMachine.OpenSubKey(keyName).GetValue(value)) 'Gets all keys in the specified subKey
        Next

    End Sub

    Private Sub FlatButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton3.Click

        Dim x As Control
        For Each x In Controls
            If TypeOf x Is RichTextBox Then
                x.Text = ""
            End If
        Next

        Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)


        If System.IO.File.Exists(appData & "\logs.dat") = True Then

            RichTextBox1.Text += " "
            RichTextBox1.Text += Environment.NewLine + "Key logger File found "
            RichTextBox1.Text += " "
            RichTextBox1.Text += Environment.NewLine + appData & "\logs.dat"
            RichTextBox1.Text += Environment.NewLine + " "
            RichTextBox1.Text += Environment.NewLine + " "
            RichTextBox1.Text += Environment.NewLine + "please check  http://www.dev-point.com/vb/f154/ for new version of this program to be able to clear server "



        End If
    End Sub

    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click

        Dim x As Control
        For Each x In Controls
            If TypeOf x Is RichTextBox Then
                x.Text = ""
            End If
        Next

        Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)


        If System.IO.Directory.Exists(appData & "\dclogs\") = True Then
            RichTextBox1.Text += " "
            RichTextBox1.Text += Environment.NewLine + "Key logger File found "
            RichTextBox1.Text += " "
            RichTextBox1.Text += Environment.NewLine + appData & "\dclogs\"
            RichTextBox1.Text += Environment.NewLine + " "
            RichTextBox1.Text += Environment.NewLine + " "
            RichTextBox1.Text += Environment.NewLine + "please check  http://www.dev-point.com/vb/f154/ for new version of this program to be able to clear server "

            RichTextBox1.Text += Environment.NewLine + " "



        End If
    End Sub

    Private Sub FlatButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton4.Click
        Dim x As Control
        For Each x In Controls
            If TypeOf x Is RichTextBox Then
                x.Text = ""
            End If
        Next


        Dim keyName As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Run"
        Dim subkeyNames() As String
        Dim valueNames() As String
        valueNames = Registry.CurrentUser.OpenSubKey(keyName).GetValueNames
        subkeyNames = Registry.CurrentUser.OpenSubKey(keyName).GetSubKeyNames

        For Each value In valueNames

            Dim Where1 As String

            Where1 = InStr(value, "{")

            If Where1 Then
                RichTextBox1.Text += Environment.NewLine + " ::  key in registry win7 ::"
                RichTextBox1.Text += Environment.NewLine + "HKEY_CURRENT_USER\Software\Microsoft\Windows\Curre ntVersion\Run"
                RichTextBox1.Text += Environment.NewLine + value & " - " & Registry.CurrentUser.OpenSubKey(keyName).GetValue(value)
                RichTextBox1.Text += Environment.NewLine + " "

            End If

        Next
    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click
        Dim x As Control
        For Each x In Controls
            If TypeOf x Is RichTextBox Then
                x.Text = ""
            End If
        Next

        Dim app As String = GetFolderPath(SpecialFolder.ApplicationData)


        Dim ooo1 As String
        Dim oo1 As String
        Dim strFileSize1 As String = ""
        Dim di1 As New IO.DirectoryInfo(app & "\Microsoft\Windows\")
        Dim aryFi1 As IO.FileInfo() = di1.GetFiles("*.dat")
        Dim fi1 As IO.FileInfo


        For Each fi1 In aryFi1
            strFileSize1 = (Math.Round(fi1.Length / 1024)).ToString()
            ooo1 = fi1.Name.Remove(fi1.Name.Length - 4)
            oo1 = fi1.FullName.Remove(fi1.FullName.Length - 4)
            RichTextBox1.Text += Environment.NewLine + " Key logger File Found :( "
            RichTextBox1.Text += Environment.NewLine + "keyloger file      : " & fi1.Name
            RichTextBox1.Text += Environment.NewLine + "Full path            : " & app & "\Microsoft\Windows\"
            RichTextBox1.Text += Environment.NewLine + "Last Accessed   : " & fi1.LastAccessTime
            RichTextBox1.Text += Environment.NewLine + " "
            RichTextBox1.Text += Environment.NewLine + "please check  http://www.dev-point.com/vb/f154/ for new version of this program to be able to clear server "

        Next
    End Sub

    Private Sub FlatButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub FlatButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton9.Click
        form5.show()
    End Sub

    Private Sub FlatButton10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton10.Click
        End

    End Sub
End Class
