Public Class ModeloUsuario
    Inherits Modelo

    Public Sub New(username As String, password As String)
        MyBase.New(username, password)

    End Sub

    Public Function GetRole()
        Comando.CommandText = "SELECT role FROM roles where username = '" + Me.DbUser + "'"
        Return Comando.ExecuteScalar.ToString

    End Function

End Class
