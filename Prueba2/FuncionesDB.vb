Imports System.Data.SqlClient
Module FuncionesDB
    Public Function existeusuario(user As String) As Boolean
        Dim conection As New SqlConnection
        conection.ConnectionString = Prueba2.My.Settings.localppt
        conection.Open()
        Dim querysql As String
        querysql = "SELECT IdUsuario FROM usuarios WHERE usuario = '" + user + "'"
        Dim cmd As New SqlCommand(querysql, conection)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function comprobarcredenciales(user As String, password As String) As Boolean
        Try

            Dim conection As New SqlConnection
            conection.ConnectionString = Prueba2.My.Settings.localppt
            conection.Open()
            Dim querysql As String
            querysql = "SELECT * FROM usuarios WHERE usuario = @usuario"

            'Crear parametros
            Dim cmd As New SqlCommand(querysql, conection)
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50)
            cmd.Parameters("@usuario").Value = user

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader()
            While dr.Read()
                If dr("contraseña").ToString() = password Then
                    'Cargar datos en variable global
                    UsuarioActual.idUsuario = dr("idUsuario").ToString
                    UsuarioActual.nombreUsuario = dr("usuario").ToString
                    Return True
                Else
                    Return False
                End If
            End While

        Catch ex As Exception
            MsgBox("Error al comprobar usuario y contraseña: " & ex.Message)
            Return False
        End Try
    End Function



    'funcion sin parametros
    Public Function crearusuario(user As String, password As String) As Boolean
        Try
            Dim conection As New SqlConnection
            conection.ConnectionString = Prueba2.My.Settings.localppt
            conection.Open()
            Dim querysql As String
            querysql = "INSERT INTO usuarios(usuario,contraseña) VALUES('" + user + "','" + password + "')"
            Dim cmd As New SqlCommand(querysql, conection)
            cmd.ExecuteNonQuery()

            'Cerramos conexion y vaciar objetos
            conection.Close()
            cmd.Dispose()
            conection.Dispose()

            Return True
        Catch ex As Exception
            MsgBox("Error al insertar usuario: " & ex.Message)
            Return False
        End Try
    End Function

    'funcion con parametros
    Public Function crearusuario_(user As String, password As String) As Boolean
        Try

            Dim conection As New SqlConnection
            conection.ConnectionString = Prueba2.My.Settings.localppt
            conection.Open()
            Dim querysql As String
            querysql = "INSERT INTO usuarios(usuario,contraseña,activo, fechaRegistro) VALUES(@usuario,@contraseña,1, @fecharegistro)"
            Dim cmd As New SqlCommand(querysql, conection)
            cmd.Parameters.Clear()
            'Crear parametros
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50)
            cmd.Parameters.Add("@contraseña", SqlDbType.VarChar, 50)
            cmd.Parameters.Add("@fecharegistro", SqlDbType.DateTime)

            'Valores parametros
            cmd.Parameters("@usuario").Value = user
            cmd.Parameters("@contraseña").Value = password
            cmd.Parameters("@fecharegistro").Value = DateTime.Now

            cmd.ExecuteNonQuery()
            'Cerramos conexion
            conection.Close()
            cmd.Dispose()
            conection.Dispose()

            MsgBox("El usuario ha sido registrado")
        Catch ex As Exception
            MsgBox("Error al insertar usuario: " & ex.Message)
        End Try
    End Function

    Public Function guardarpuntuacion(iduser As Integer, points As Integer) As Boolean
        Try
            Dim conection As New SqlConnection
            conection.ConnectionString = Prueba2.My.Settings.localppt
            conection.Open()
            Dim querysql As String
            querysql = "INSERT INTO puntuacion(Id_usuario,puntuacion) VALUES(" & iduser & "," & points & ")"
            Dim cmd As New SqlCommand(querysql, conection)
            cmd.ExecuteNonQuery()
            'Cerramos conexion y vaciar objetos
            conection.Close()
            cmd.Dispose()
            conection.Dispose()
            Return True
        Catch ex As Exception
            MsgBox("Error al insertar usuario: " & ex.Message)
            Return False
        End Try
    End Function

End Module
