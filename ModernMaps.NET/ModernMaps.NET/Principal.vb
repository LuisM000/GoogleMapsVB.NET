Imports System.Xml

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

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Timer4.Enabled = True
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Timer2.Enabled = True
    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Timer3.Enabled = True
    End Sub
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Timer6.Enabled = True
    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        timer7.enabled = True
    End Sub
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        timer8.enabled = True
    End Sub
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Timer9.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Width > 2 Then
            Me.Opacity = Me.Opacity - 0.04
            Me.Width = Me.Width - 10
        Else
            Me.Hide()
            Me.Opacity = 1
            Me.Size = New Size(320, 474)
            Form1.Show()
            Timer1.Enabled = False
        End If
    End Sub


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Me.Width > 2 Then
            Me.Opacity = Me.Opacity - 0.04
            Me.Width = Me.Width - 10
        Else
            Me.Hide()
            Me.Opacity = 1
            Me.Size = New Size(320, 474)
            ISP.Show()
            Timer2.Enabled = False
        End If
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Me.Width > 2 Then
            Me.Opacity = Me.Opacity - 0.04
            Me.Width = Me.Width - 10
        Else
            Me.Hide()
            Me.Opacity = 1
            Me.Size = New Size(320, 474)
            latlong.Show()
            Timer3.Enabled = False
        End If
    End Sub
    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If Me.Width > 2 Then
            Me.Opacity = Me.Opacity - 0.04
            Me.Width = Me.Width - 10
        Else
            Me.Hide()
            Me.Opacity = 1
            Me.Size = New Size(320, 474)
            BuscarLatLong.Show()
            Timer4.Enabled = False
        End If
    End Sub

    
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Me.Close()
    End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Timer5.Enabled = True
    End Sub
   
    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        If Me.Width > 2 Then
            Me.Opacity = Me.Opacity - 0.04
            Me.Width = Me.Width - 10
        Else
            Me.Hide()
            Me.Opacity = 1
            Me.Size = New Size(320, 474)
            AcercaDe.Show()
            Timer5.Enabled = False
        End If
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        If Me.Width > 2 Then
            Me.Opacity = Me.Opacity - 0.04
            Me.Width = Me.Width - 10
        Else
            Me.Hide()
            Me.Opacity = 1
            Me.Size = New Size(320, 474)
            CodifiInversa.Show()
            Timer6.Enabled = False
        End If
    End Sub

 
    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        If Me.Width > 2 Then
            Me.Opacity = Me.Opacity - 0.04
            Me.Width = Me.Width - 10
        Else
            Me.Hide()
            Me.Opacity = 1
            Me.Size = New Size(320, 474)
            BuscarParaComer.Show()
            Timer7.Enabled = False
        End If
    End Sub

   
    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        If Me.Width > 2 Then
            Me.Opacity = Me.Opacity - 0.04
            Me.Width = Me.Width - 10
        Else
            Me.Hide()
            Me.Opacity = 1
            Me.Size = New Size(320, 474)
            GooglePlacesS.Show()
            Timer8.Enabled = False
        End If
    End Sub
    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        If Me.Width > 2 Then
            Me.Opacity = Me.Opacity - 0.04
            Me.Width = Me.Width - 10
        Else
            Me.Hide()
            Me.Opacity = 1
            Me.Size = New Size(320, 474)
            DistancElevacionRuta.Show()
            Timer9.Enabled = False
        End If
    End Sub

   
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        DistancElevacionRuta.Show()
    End Sub

    
   
End Class