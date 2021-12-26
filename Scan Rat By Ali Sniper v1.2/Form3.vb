Imports System.IO
Imports Microsoft.Win32
Public Class Form3

    Private Sub FlatLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatLabel1.Click
        Me.Close()
    End Sub

    Private Sub FormSkin1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click
        Try
            ListBox1.Items.Clear()  'حذف جميع الأيتيمات إن كانت موجودة

            Dim Mi As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup) 'جلب مسار الستارتب
            For Each s As String In Directory.GetFiles(Mi) ' جلب جميع الملفات الموجودة بالستارتب 
                ListBox1.Items.Add(s) '  إضافة الملف إلى اللست فيو
            Next
        Catch : End Try
        ProgressBar1.Value = 100
    End Sub

    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click
        Try
            For Each x As String In ListBox1.Items  '  من أجل كل عنصر في اللست فيو إفعل التالي
                Try
                    IO.File.Delete(x) ' إحذف الملف 
                Catch ex As Exception
                End Try
            Next
            MsgBox("Done", MsgBoxStyle.Information)
            ListBox1.Items.Clear() ' حذف الايتيمات
        Catch : End Try
    End Sub

    Private Sub FlatButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton3.Click
        ListBox1.Items.Clear()
    End Sub
End Class