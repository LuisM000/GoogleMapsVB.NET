Public Class MapsNet

    Public Function ObtenerURLdesdeDireccion(ByVal direccion As String)
        Dim urlMaps As String 'Creamos variable para almacenar la url
        urlMaps = "http://maps.google.es/maps?q=" & direccion & "&output=embed" 'Concatenamos la dirección con la dirección del mapa
        Return urlMaps
    End Function
End Class
