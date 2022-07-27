Imports System.Data.SqlClient
Public Class scores
    Private Sub scores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LocalpptDataSet.puntuacion' Puede moverla o quitarla según sea necesario.
        Me.PuntuacionTableAdapter.Fill(Me.LocalpptDataSet.puntuacion)
        cargarpuntuacion()
    End Sub
    Private Sub cargarpuntuacion()
        Try
            Dim conection As New SqlConnection
            conection.ConnectionString = Prueba2.My.Settings.localppt
            conection.Open()
            Dim querysql As String
            querysql = "SELECT usuarios.usuario, COUNT(*) AS TotalPartidas, SUM(puntuacion.puntuacion) AS TotalPuntuacion, AVG(puntuacion.puntuacion) AS Media, MAX(puntuacion.puntuacion) AS highscore, MAX(puntuacion.fechaPuntuacion) AS UltimaPartida FROM puntuacion INNER JOIN  usuarios ON puntuacion.Id_usuario = usuarios.IdUsuario GROUP BY usuarios.usuario ORDER BY highscore DESC"
            Dim cmd As New SqlCommand(querysql, conection)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader()
            While dr.Read()
                Dim indice As Integer = DataGridView1.Rows.Add
                Dim row As DataGridViewRow = DataGridView1.Rows(indice)
                row.Cells("username").Value = dr("usuario").ToString()
                row.Cells("TotalPartidas").Value = CInt(dr("TotalPartidas"))
                row.Cells("TotalPuntuacion").Value = CInt(dr("TotalPuntuacion"))
                row.Cells("Media").Value = CInt(dr("Media"))
                row.Cells("highscore").Value = CInt(dr("highscore"))
                row.Cells("UltimaPartida").Value = CDate(dr("UltimaPartida"))
                'DataGridView1
            End While
        Catch ex As Exception
            MsgBox("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.PuntuacionTableAdapter.FillBy(Me.LocalpptDataSet.puntuacion)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class