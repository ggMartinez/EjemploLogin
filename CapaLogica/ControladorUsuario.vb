Imports CapaDeDatos


Public Module ControladorUsuario


    Public Function Autenticar(username As String, password As String)
        Dim u As New ModeloUsuario(username, password)
        Return u.GetRole()

    End Function

End Module
