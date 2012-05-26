Public Class Informe_Ventas
    'Crea el comando para almacenara las consultas en la base de datos.
    Dim comando As New OleDb.OleDbCommand
    'Crea el lector para las consultas select...
    Dim miLector As OleDb.OleDbDataReader
    'Conjunto de datos donde se carga la base de datos --> dataset
    Dim conjuntoDatos As New DataSet
    'Crea el adaptador para conectarse con la base de datos..
    Dim adaptador As New OleDb.OleDbDataAdapter
    
    
    Private Sub Informe_Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comando.Connection = Form1.miConexion
    End Sub
End Class