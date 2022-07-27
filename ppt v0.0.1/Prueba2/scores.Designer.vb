<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class scores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_score_title = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PuntuacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalpptDataSet = New Prueba2.localpptDataSet()
        Me.PuntuacionTableAdapter = New Prueba2.localpptDataSetTableAdapters.puntuacionTableAdapter()
        Me.IdPuntuacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPartidas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPuntuacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Media = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.highscore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimaPartida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuntuacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalpptDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_score_title
        '
        Me.txt_score_title.AutoSize = True
        Me.txt_score_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_score_title.ForeColor = System.Drawing.Color.Blue
        Me.txt_score_title.Location = New System.Drawing.Point(12, 9)
        Me.txt_score_title.Name = "txt_score_title"
        Me.txt_score_title.Size = New System.Drawing.Size(261, 25)
        Me.txt_score_title.TabIndex = 0
        Me.txt_score_title.Text = "Histórico de puntuaciones"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPuntuacion, Me.username, Me.TotalPartidas, Me.TotalPuntuacion, Me.Media, Me.highscore, Me.UltimaPartida})
        Me.DataGridView1.Location = New System.Drawing.Point(17, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(643, 354)
        Me.DataGridView1.TabIndex = 1
        '
        'PuntuacionBindingSource
        '
        Me.PuntuacionBindingSource.DataMember = "puntuacion"
        Me.PuntuacionBindingSource.DataSource = Me.LocalpptDataSet
        '
        'LocalpptDataSet
        '
        Me.LocalpptDataSet.DataSetName = "localpptDataSet"
        Me.LocalpptDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PuntuacionTableAdapter
        '
        Me.PuntuacionTableAdapter.ClearBeforeFill = True
        '
        'IdPuntuacion
        '
        Me.IdPuntuacion.HeaderText = "IdPuntuacion"
        Me.IdPuntuacion.MaxInputLength = 10
        Me.IdPuntuacion.Name = "IdPuntuacion"
        Me.IdPuntuacion.ReadOnly = True
        Me.IdPuntuacion.Visible = False
        '
        'username
        '
        Me.username.HeaderText = "username"
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        '
        'TotalPartidas
        '
        Me.TotalPartidas.HeaderText = "TotalPartidas"
        Me.TotalPartidas.Name = "TotalPartidas"
        Me.TotalPartidas.ReadOnly = True
        '
        'TotalPuntuacion
        '
        Me.TotalPuntuacion.HeaderText = "TotalPuntuacion"
        Me.TotalPuntuacion.Name = "TotalPuntuacion"
        Me.TotalPuntuacion.ReadOnly = True
        '
        'Media
        '
        Me.Media.HeaderText = "Media"
        Me.Media.Name = "Media"
        Me.Media.ReadOnly = True
        '
        'highscore
        '
        Me.highscore.HeaderText = "highscore"
        Me.highscore.Name = "highscore"
        Me.highscore.ReadOnly = True
        '
        'UltimaPartida
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.UltimaPartida.DefaultCellStyle = DataGridViewCellStyle3
        Me.UltimaPartida.HeaderText = "UltimaPartida"
        Me.UltimaPartida.Name = "UltimaPartida"
        Me.UltimaPartida.ReadOnly = True
        '
        'scores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 403)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_score_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "scores"
        Me.ShowIcon = False
        Me.Text = "Histórico de puntuaciones"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuntuacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalpptDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_score_title As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LocalpptDataSet As localpptDataSet
    Friend WithEvents PuntuacionBindingSource As BindingSource
    Friend WithEvents PuntuacionTableAdapter As localpptDataSetTableAdapters.puntuacionTableAdapter
    Friend WithEvents IdPuntuacion As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents TotalPartidas As DataGridViewTextBoxColumn
    Friend WithEvents TotalPuntuacion As DataGridViewTextBoxColumn
    Friend WithEvents Media As DataGridViewTextBoxColumn
    Friend WithEvents highscore As DataGridViewTextBoxColumn
    Friend WithEvents UltimaPartida As DataGridViewTextBoxColumn
End Class
