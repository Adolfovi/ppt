<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_score_title = New System.Windows.Forms.Label()
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
        'scores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(307, 305)
        Me.Controls.Add(Me.txt_score_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "scores"
        Me.ShowIcon = False
        Me.Text = "Histórico de puntuación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_score_title As Label
End Class
