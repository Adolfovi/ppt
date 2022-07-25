Public Class game
    Dim number As Integer
    Dim score As Integer
    Dim idpuntuacion As Integer

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        number = CInt(Int((3 * Rnd())))
        If number = 0 Then
            Label1.Text = "Rival sacó: piedra, Jugador sacó: piedra"
            Label2.Text = "EMPATE"
        End If
        If number = 1 Then
            Label1.Text = "Rival sacó: papel, Jugador sacó: piedra"
            Label2.Text = "PERDISTES"
            score = score - 1
            txt_score.Text = score
        End If
        If number = 2 Then
            Label1.Text = "Rival sacó: tijeras, Jugador sacó: piedra"
            Label2.Text = "GANASTES"
            score = score + 2
            txt_score.Text = score
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        number = CInt(Int((3 * Rnd())))
        If number = 0 Then
            Label1.Text = "Rival sacó: piedra, Jugador sacó: papel"
            Label2.Text = "GANASTES"
            score = score + 2
            txt_score.Text = score
        End If
        If number = 1 Then
            Label1.Text = "Rival sacó: papel, Jugador sacó: papel"
            Label2.Text = "EMPATE"
        End If
        If number = 2 Then
            Label1.Text = "Rival sacó: tijeras, Jugador sacó: papel"
            Label2.Text = "PERDISTES"
            score = score - 1
            txt_score.Text = score
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Asigna un integer aleatorio a la variable number
        number = CInt(Int((3 * Rnd())))
        If number = 0 Then
            Label1.Text = "Rival sacó: piedra, Jugador sacó: tijeras"
            Label2.Text = "PERDISTES"
            score = score - 1
            txt_score.Text = score
        End If
        If number = 1 Then
            Label1.Text = "Rival sacó: papel, Jugador sacó: tijeras"
            Label2.Text = "GANASTES"
            score = score + 2
            txt_score.Text = score
        End If
        If number = 2 Then
            Label1.Text = "Rival sacó: tijeras, Jugador sacó: tijeras"
            Label2.Text = "EMPATE"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Arranca la funcion para randomizar
        Randomize()
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = String.Format("Elije una opción:")
        Button0.Text = "piedra"
        Button1.Text = "papel"
        Button2.Text = "tijeras"
        btn_savepoints.Text = "Registrar puntuación"
        lbl_username.Text = UsuarioActual.nombreUsuario

        'Cargar puntuacion
    End Sub

    Private Sub btn_savepoints_Click(sender As Object, e As EventArgs) Handles btn_savepoints.Click
        If idpuntuacion = 0 Then 'No hay registro de puntuacion para el usuario
            If guardarpuntuacion(UsuarioActual.idUsuario, txt_score.Text) = True Then
                MsgBox("Puntuación guardada con éxito!!!!")
                Exit Sub
            End If
        Else
            'ActualizarPuntuacion
        End If
    End Sub
End Class
