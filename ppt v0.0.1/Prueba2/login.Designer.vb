<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_login_user = New System.Windows.Forms.TextBox()
        Me.txt_login_passwd = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_register = New System.Windows.Forms.Button()
        Me.btn_seescores = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inicio de Sesión"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(15, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(15, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña"
        '
        'txt_login_user
        '
        Me.txt_login_user.Location = New System.Drawing.Point(98, 52)
        Me.txt_login_user.Name = "txt_login_user"
        Me.txt_login_user.Size = New System.Drawing.Size(100, 20)
        Me.txt_login_user.TabIndex = 3
        '
        'txt_login_passwd
        '
        Me.txt_login_passwd.Location = New System.Drawing.Point(98, 81)
        Me.txt_login_passwd.Name = "txt_login_passwd"
        Me.txt_login_passwd.Size = New System.Drawing.Size(100, 20)
        Me.txt_login_passwd.TabIndex = 4
        Me.txt_login_passwd.UseSystemPasswordChar = True
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.Blue
        Me.btn_login.Location = New System.Drawing.Point(18, 107)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(180, 33)
        Me.btn_login.TabIndex = 5
        Me.btn_login.Text = "Iniciar Sesión"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'btn_register
        '
        Me.btn_register.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_register.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_register.ForeColor = System.Drawing.Color.Blue
        Me.btn_register.Location = New System.Drawing.Point(18, 146)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(180, 31)
        Me.btn_register.TabIndex = 6
        Me.btn_register.Text = "Registrate aquí"
        Me.btn_register.UseVisualStyleBackColor = False
        '
        'btn_seescores
        '
        Me.btn_seescores.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_seescores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_seescores.ForeColor = System.Drawing.Color.Blue
        Me.btn_seescores.Location = New System.Drawing.Point(18, 183)
        Me.btn_seescores.Name = "btn_seescores"
        Me.btn_seescores.Size = New System.Drawing.Size(180, 43)
        Me.btn_seescores.TabIndex = 7
        Me.btn_seescores.Text = "Ver histórico de puntuaciones"
        Me.btn_seescores.UseVisualStyleBackColor = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(219, 238)
        Me.Controls.Add(Me.btn_seescores)
        Me.Controls.Add(Me.btn_register)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_login_passwd)
        Me.Controls.Add(Me.txt_login_user)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "login"
        Me.ShowIcon = False
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_login_user As TextBox
    Friend WithEvents txt_login_passwd As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_register As Button
    Friend WithEvents btn_seescores As Button
End Class
