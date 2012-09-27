Imports System.Text.RegularExpressions
Imports System.IO

Public Class Rutas

    Private Sub Rutas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mas As New MapsNet
        Dim hitos As New ArrayList
        hitos.Add("Toledo")
        hitos.Add("león")
        Dim ss = mas.Rutas("monasterio de carracedo, ponferrada", "madrid", 0, hitos, True, 0, , )
        For i = 0 To UBound(ss) - 1 Step 5
            RichTextBox1.Text = RichTextBox1.Text & ss(i) & "||| "
            RichTextBox1.Text = RichTextBox1.Text & ss(i + 1) & "||| "
            RichTextBox1.Text = RichTextBox1.Text & ss(i + 2) & "||| "
            RichTextBox1.Text = RichTextBox1.Text & ss(i + 3) & "||| "
            RichTextBox1.Text = RichTextBox1.Text & ss(i + 4) & "||| " & vbCrLf
        Next


       
        RichTextBox1.Text = QuitarEtiqueta(RichTextBox1.Text)

    End Sub
    Private Function QuitarEtiqueta(ByVal str As String) As String 'Eliminamos etiquetas HTML y ponemos en mayúsculas
        Dim RegExp As String = "<b[^>]*>[^<]*</b>"
        Dim RegExp2 As String = "<div[^>]*>[^<]*</div>"
        Dim R As New Regex(RegExp)
        Dim R2 As New Regex(RegExp2)

        Dim mc As MatchCollection = R.Matches(str)
        If mc.Count > 0 Then
            For Each m In mc
                Dim cadena = ((m.Result("$0").ToString))
                str = str.Replace(cadena, cadena.ToString.ToUpper)
            Next
        End If

        Dim mc2 As MatchCollection = R2.Matches(str)
        If mc.Count > 0 Then
            For Each m In mc2
                Dim cadena = ((m.Result("$0").ToString))
                str = str.Replace(cadena, cadena.ToString.ToUpper)
            Next
        End If
        str = str.Replace("<B>", "").Replace("</B>", "").Replace("<DIV STYLE=""FONT-SIZE:0.9EM"">", " ").Replace("</DIV>", "")
        Return str
    End Function

   
End Class