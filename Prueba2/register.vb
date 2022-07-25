Public Class register
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Validar() = False Then
            Exit Sub
        End If
        If crearusuario_(txt_user.Text, txt_passwd.Text) = True Then
            MsgBox("El usuario se ha creado correctamente!")
            Me.Close()
        End If
    End Sub
    Private Function Validar() As Boolean
        If Trim(txt_user.Text) = "" Then
            MsgBox("Complete datos de usuario")
            Return False
        ElseIf Trim(txt_passwd.Text) = "" Then
            MsgBox("Complete campos de contraseña")
            Return False
        ElseIf Trim(txt_passwd.Text).Length > 8 Then
            MsgBox("La contraseña no puede tener más de 8 caracteres")
            Return False
        ElseIf Trim(txt_passwd.Text).Length <= 4 Then
            MsgBox("La contraseña no puede tener menos de 4 caracteres")
            Return False
        ElseIf txt_passwd.Text <> txt_repeatpasswd.Text Then
            MsgBox("Las contraseñas no coinciden")
            Return False
        ElseIf existeusuario(txt_user.Text) = True Then
            MsgBox("El usuario ya existe")
        End If
        Return True
    End Function

End Class