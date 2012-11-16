Module VariablesGlobales
    'Reviews
    Public time As New ArrayList()
    Public autor As New ArrayList()
    Public URLautor As New ArrayList()
    Public textoReview As New ArrayList()
    'Rutas
    Public copyRuta As New ArrayList()
    Public ordenRuta As New ArrayList()
    Public rutaID As New ArrayList()
    Public DuraciTotal As New ArrayList()
    Public DistanciaTotal As New ArrayList()
    Public TiempoSegundos As New ArrayList()
    Public Polilineas As New ArrayList()
    '-------
    Public statusRuta As String
    '--------
    'Elevación
    Public resolucion As New ArrayList()

    'Seguimiento de solicitudes HTTP
    Public URLseguimiento As New ArrayList
    Public numeroInstancia As Long

    'Hilo
    Public hiloImagenes As Threading.Thread
    Public hiloMapas As Threading.Thread

    'Mapas completos (importar xml)
    Public rutaArchivoimportar As String

    'Autocompletar
    Public listaAutocompletar As New ArrayList 'La lista con los datos
    Public MySource As New AutoCompleteStringCollection()

End Module
