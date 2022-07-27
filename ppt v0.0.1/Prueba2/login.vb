Public Class login
    Public username As String
    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        Dim register As New register
        register.Show()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If validarusuario() = False Then
            Exit Sub
        End If

        Dim juego As New game
        juego.Show()
    End Sub

    Public Function validarusuario()
        If Trim(txt_login_user.Text) = "" Then
            MsgBox("Por favor, rellene el campo de usuario")
            Return False
        End If
        If existeusuario(txt_login_user.Text) = True Then
            If comprobarcredenciales(txt_login_user.Text, txt_login_passwd.Text) = False Then
                MsgBox("El usuario y la contraseña no coinciden")
                Return False
            End If
        Else
            MsgBox("El usuario no existe")
            Return False
        End If
        Return True
    End Function

    Private Sub btn_seescores_Click(sender As Object, e As EventArgs) Handles btn_seescores.Click
        Dim score As New scores
        score.Show()
    End Sub
End Class