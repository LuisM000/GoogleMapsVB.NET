Public Class InicioAPI

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim maps As New MapsNet
        maps.ClaveMaps = txtclave.Text
        My.Settings.ClaveMaps = txtclave.Text
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If BackgroundWorker1.IsBusy = False Then
            Button1.Text = "Comprobando"
            BackgroundWorker1.RunWorkerAsync()
        End If

    End Sub
    Dim Clave As Boolean
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim maps As New MapsNet
        If maps.ComprobarClaveAPI(txtclave.Text) = True Then
            Clave = True
        Else
            Clave = False
        End If

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Button1.Text = "Comprobar"
        If Clave = True Then
            PictureBox1.Image = My.Resources.check
            Dim maps As New MapsNet
            maps.ClaveMaps = txtclave.Text
        Else
            PictureBox1.Image = My.Resources.cancel
        End If
    End Sub

    Private Sub InicioAPI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.ClaveMaps <> "" Then 'Si ya hay clave guardada
            txtclave.Text = My.Settings.ClaveMaps
        End If
    End Sub
End Class
