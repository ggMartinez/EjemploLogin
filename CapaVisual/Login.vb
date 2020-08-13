Imports CapaLogica

Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Function autenticarUsuario(usuario, password)
        Return ControladorUsuario.Autenticar(usuario, password)
    End Function

    Private Sub setearSesion(usuario, password)
        Sesion.Username = usuario
        Sesion.Password = password
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            If (autenticarUsuario(UsernameTextBox.Text, PasswordTextBox.Text) = "gestor") Then
                setearSesion(UsernameTextBox.Text, PasswordTextBox.Text)

                Me.Hide()
                Form1.Show()

            Else
                MsgBox("Usuario Invalido")
            End If
        Catch ex As Exception
            MsgBox("Usuario invalido")
        End Try


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
