Public Class Principal

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each c As Object In Me.Controls
            If c.GetType Is GetType(Label) Then
                AddHandler DirectCast(c, Label).MouseEnter, AddressOf conFoco
                AddHandler DirectCast(c, Label).MouseLeave, AddressOf sinFoco
            End If
        Next
    End Sub

    Private Sub conFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, Label).ForeColor = Color.White
        Me.Cursor = Cursors.Hand
    End Sub


    Private Sub sinFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, Label).ForeColor = Color.Black
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Width > 2 Then
            Me.Opacity = Me.Opacity - 0.04
            Me.Width = Me.Width - 10
        Else
            Me.Hide()
            Me.Opacity = 1
            Me.Size = New Size(320, 266)
            Form1.Show()
            Timer1.Enabled = False
        End If
    End Sub

   

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub
End Class