Imports System.Text.RegularExpressions
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Dim direccion As New Uri(" http://maps.google.es/maps?q=España&output=embed")
        WebBrowser1.Url = direccion
        Me.Size = New Size(0, 333)
        txtpoblacion.Focus()
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
        Timer5.Interval = 1000
        Timer5.Enabled = True
    End Sub

    Private Sub conFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = Color.AliceBlue
    End Sub


    Private Sub sinFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = Color.White
    End Sub

    Private Sub Buscar(ByVal sender As Object, ByVal e As System.EventArgs)
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub


    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.ImageLocation = "imagenes/white/back.png"
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.ImageLocation = "imagenes/black/back.png"
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Timer3.Enabled = True
        Timer4.Enabled = True
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Width < 980 Then
            Me.Width = Me.Width + 10
            Me.Location = New Point(Me.Location.X - 5, Me.Location.Y)
        Else
            Timer1.Enabled = False
            Dim objetoMaps As New GoogleMaps
            Dim direccionAux As String
            direccionAux = objetoMaps.ObtenerURLDireccionMaps(txtpoblacion.Text, txtcp.Text, txtcalle.Text, txtprovincia.Text, txtcomunidad.Text, txtpais.Text)
            Dim direccion As New Uri(direccionAux)
            If direccionAux <> "http://maps.google.es/maps?q=      &output=embed" Then
                WebBrowser1.Url = direccion
            End If
        End If
    End Sub


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Me.Height < 700 Then
            Me.Height = Me.Height + 10
            Me.Location = New Point(Me.Location.X, Me.Location.Y - 5)
        Else
            Timer2.Enabled = False
        End If
    End Sub


  

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Me.Width > 2 Then
            Me.Width = Me.Width - 10
            If Me.Width > 470 Then
                Me.Location = New Point(Me.Location.X + 5, Me.Location.Y)
            Else
                Me.Opacity = Me.Opacity - 0.023
            End If
        Else
            Timer3.Enabled = False
            Me.Close()
            Principal.Show()
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If Me.Height > 333 Then
            Me.Height = Me.Height - 10

            Me.Location = New Point(Me.Location.X, Me.Location.Y + 5)

        Else
            Timer4.Enabled = False
        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        If Me.Width < 470 Then
            Timer5.Interval = 1
            Me.Opacity = Me.Opacity + 0.025
            Me.Width = Me.Width + 10
        Else
            Timer5.Enabled = False
        End If
    End Sub
End Class
