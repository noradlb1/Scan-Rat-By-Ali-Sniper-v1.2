Imports System.IO
Imports Microsoft.Win32
Public Class Form2

    Private Sub FlatLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatLabel1.Click
        Me.Close()

    End Sub

    Private Sub FormSkin1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click
        Try
            ListBox2.Items.Clear()  'حذف جميع الأيتيمات إن كانت موجودة

            Dim Mi As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup) 'جلب مسار الستارتب
            For Each s As String In Directory.GetFiles(Mi) ' جلب جميع الملفات الموجودة بالستارتب 
                ListBox2.Items.Add(s) '  إضافة الملف إلى اللست فيو
            Next
        Catch : End Try
        ProgressBar2.Value = 100
    End Sub

    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click

        Dim Mimo_Path As String = "Software\Microsoft\Windows\CurrentVersion\Run"
        Try
            For Each x In ListBox2.Items
                Registry.CurrentUser.OpenSubKey(Mimo_Path, True).DeleteValue(x, True)
                MessageBox.Show("Done", "[Mimo]", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Next
            ListBox2.Items.Clear()


        Catch : End Try
    End Sub

    Private Sub FlatButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton3.Click
        ListBox2.Items.Clear()
    End Sub
End Class