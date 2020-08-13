Imports CapaDeDatos

Public Module ControladorPersona

    Public Function ObtenerCantidad()
        Dim p As New ModeloPersona("usuario", "1234")
        Return p.Contar()
    End Function


    Public Sub DarDeAlta(id As String, nombre As String, apellido As String, mail As String)
        Dim p As New ModeloPersona("usuario", "1234")

        p.Id = id
        p.Nombre = nombre
        p.Apellido = apellido
        p.Mail = mail

        p.Guardar()

    End Sub

    Public Function ListarTodo()
        Dim p As New ModeloPersona("usuario", "1234")
        Return p.Listar()
    End Function

    Public Sub Borrar(id As String)
        Dim p As New ModeloPersona("usuario", "1234")
        p.Id = id
        p.Borrar()

    End Sub

    Public Sub Modificar(id As String, nombre As String, apellido As String, mail As String)
        Dim p As New ModeloPersona("usuario", "1234")

        p.Id = id
        p.Nombre = nombre
        p.Apellido = apellido
        p.Mail = mail

        p.Modificar()
    End Sub
End Module
