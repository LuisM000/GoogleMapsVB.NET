Public Class BuscarLatLong

    Private Sub BuscarLatLong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Dim direccion As New Uri(" http://maps.google.es/maps?q=España&output=embed")
        WebBrowser1.Url = direccion
        Me.Size = New Size(0, 162)
        For Each c As Object In Me.Controls
            If c.GetType Is GetType(TextBox) Then
                AddHandler DirectCast(c, TextBox).GotFocus, AddressOf conFoco
                AddHandler DirectCast(c, TextBox).LostFocus, AddressOf sinFoco
            End If
        Next
        For Each c As Object In Me.Controls
            If c.GetType Is GetType(TextBox) Then
                AddHandler DirectCast(c, TextBox).KeyDown, AddressOf Buscar
            End If
        Next
        txtlat.Focus()
        Timer1.Interval = 500
        Timer1.Enabled = True
    End Sub
    Private Sub conFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = Color.LightCyan
    End Sub

    Private Sub sinFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = Color.White
    End Sub
    Private Sub Buscar(ByVal sender As Object, ByVal e As System.EventArgs)
        'Timer1.Enabled = True
        'Timer2.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Width < 467 Then
            Timer1.Interval = 1
            Me.Opacity = Me.Opacity + 0.025
            Me.Width = Me.Width + 10
        Else
            Timer1.Enabled = False
        End If
    End Sub
End Class