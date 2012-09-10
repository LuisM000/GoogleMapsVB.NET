Public Class AcercaDe


    Private Sub AcercaDe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Me.Size = New Size(0, 195)
        Timer1.Enabled = True
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Dim abrirWeb As New System.Diagnostics.Process
        abrirWeb.StartInfo.FileName = "http://www.algoimagen.blogspot.com.es/"
        abrirWeb.Start()
    End Sub

    Private Sub Label3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseEnter
        Label3.ForeColor = Color.White
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Label3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseLeave
        Label3.ForeColor = Color.Black
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
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

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Width < 385 Then
            Me.Width = Me.Width + 10
            Me.Opacity = Me.Opacity + 0.025
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Me.Width > 2 Then
            Me.Width = Me.Width - 10
            Me.Opacity = Me.Opacity - 0.023
        Else
            Timer2.Enabled = False
            Me.Close()
            Principal.Show()
        End If
    End Sub
End Class