Public Class ModeloPersona
    Inherits Modelo

    Public Sub New(username As String, password As String)
        MyBase.New(username, password)

    End Sub
    Public Id As String
    Public Nombre As String
    Public Apellido As String
    Public Mail As String

    Public Function Contar()
        Me.Comando.CommandText = "SELECT COUNT(*) FROM persona"
        Return Me.Comando.ExecuteScalar().ToString()
    End Function

    Public Sub Guardar()
        Comando.CommandText = "INSERT INTO persona VALUES(" + Me.Id + ",'" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Mail + "')"
        Comando.ExecuteNonQuery()
    End Sub

    Public Function Listar()
        Comando.CommandText = "SELECT * FROM persona"
        Reader = Comando.ExecuteReader()
        Return Reader
    End Function

    Public Sub Borrar()
        Comando.CommandText = "DELETE FROM persona WHERE id = " + Me.Id
        Comando.ExecuteNonQuery()

    End Sub

    Public Sub Modificar()
        Comando.CommandText = "UPDATE persona SET nombre = '" + Me.Nombre + "', apellido = '" + Me.Apellido + "', email = '" + Me.Mail + "' WHERE id = " + Me.Id
        Comando.ExecuteNonQuery()

    End Sub
End Class
