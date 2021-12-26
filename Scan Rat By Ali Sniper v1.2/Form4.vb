Public Class Form4

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click

        ListView1.Items.Clear()
        Dim alkhal() As Diagnostics.Process = System.Diagnostics.Process.GetProcesses
        For Each l In alkhal
            ListView1.Items.Add(l.ProcessName)
        Next
        Me.Text = alkhal.Length
    End Sub

    Private Sub FormSkin1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormSkin1.Click

        ListView1.Items.Clear()
        Dim alkhal() As Diagnostics.Process = System.Diagnostics.Process.GetProcesses
        For Each i In alkhal
            ListView1.Items.Add(i.ProcessName)

        Next
        Me.Text = alkhal.Length


    End Sub

    Private Sub FlatLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatLabel1.Click
        Me.Close()

    End Sub
End Class