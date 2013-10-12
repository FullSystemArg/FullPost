<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DD_Servidor = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_Servidor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_Puerto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_Email = New System.Windows.Forms.TextBox()
        Me.DD_Email = New System.Windows.Forms.ComboBox()
        Me.TB_Contraseña = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_Mascara = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_Respuesta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DD_Destino = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TB_Asunto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TB_Cuerpo = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.EdiciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DD_Servidor
        '
        Me.DD_Servidor.FormattingEnabled = True
        Me.DD_Servidor.Items.AddRange(New Object() {"Hotmail", "Gmail", "Yahoo"})
        Me.DD_Servidor.Location = New System.Drawing.Point(64, 47)
        Me.DD_Servidor.Name = "DD_Servidor"
        Me.DD_Servidor.Size = New System.Drawing.Size(135, 21)
        Me.DD_Servidor.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EdiciónToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(476, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Servidor"
        '
        'TB_Servidor
        '
        Me.TB_Servidor.Location = New System.Drawing.Point(205, 48)
        Me.TB_Servidor.Name = "TB_Servidor"
        Me.TB_Servidor.Size = New System.Drawing.Size(163, 20)
        Me.TB_Servidor.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(374, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Puerto"
        '
        'TB_Puerto
        '
        Me.TB_Puerto.Location = New System.Drawing.Point(418, 48)
        Me.TB_Puerto.Name = "TB_Puerto"
        Me.TB_Puerto.Size = New System.Drawing.Size(44, 20)
        Me.TB_Puerto.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Email"
        '
        'TB_Email
        '
        Me.TB_Email.Location = New System.Drawing.Point(263, 85)
        Me.TB_Email.Name = "TB_Email"
        Me.TB_Email.Size = New System.Drawing.Size(199, 20)
        Me.TB_Email.TabIndex = 8
        '
        'DD_Email
        '
        Me.DD_Email.FormattingEnabled = True
        Me.DD_Email.Items.AddRange(New Object() {"Remitente.1@fullentregas.com.ar", "Remitente.2@fullentregas.com.ar", "Remitente.3@fullentregas.com.ar", "Remitente.4@fullentregas.com.ar", "Remitente.5@fullentregas.com.ar", "Remitente.6@fullentregas.com.ar", "Remitente.7@fullentregas.com.ar", "Remitente.8@fullentregas.com.ar", "Remitente.9@fullentregas.com.ar", "Remitente.10@fullentregas.com.ar", "Remitente.11@fullentregas.com.ar", "Remitente.12@fullentregas.com.ar", "Remitente.13@fullentregas.com.ar", "Remitente.14@fullentregas.com.ar", "Remitente.15@fullentregas.com.ar"})
        Me.DD_Email.Location = New System.Drawing.Point(64, 84)
        Me.DD_Email.Name = "DD_Email"
        Me.DD_Email.Size = New System.Drawing.Size(193, 21)
        Me.DD_Email.TabIndex = 7
        '
        'TB_Contraseña
        '
        Me.TB_Contraseña.Location = New System.Drawing.Point(264, 116)
        Me.TB_Contraseña.Name = "TB_Contraseña"
        Me.TB_Contraseña.Size = New System.Drawing.Size(197, 20)
        Me.TB_Contraseña.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(199, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Contraseña"
        '
        'TB_Mascara
        '
        Me.TB_Mascara.Location = New System.Drawing.Point(64, 150)
        Me.TB_Mascara.Name = "TB_Mascara"
        Me.TB_Mascara.Size = New System.Drawing.Size(129, 20)
        Me.TB_Mascara.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Máscara"
        '
        'TB_Respuesta
        '
        Me.TB_Respuesta.Location = New System.Drawing.Point(263, 150)
        Me.TB_Respuesta.Name = "TB_Respuesta"
        Me.TB_Respuesta.Size = New System.Drawing.Size(198, 20)
        Me.TB_Respuesta.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(199, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Respuesta"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.TB_Cuerpo)
        Me.Panel1.Controls.Add(Me.TB_Asunto)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.DD_Destino)
        Me.Panel1.Location = New System.Drawing.Point(12, 196)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(449, 342)
        Me.Panel1.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Destinatarios"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(50, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Email Destino"
        '
        'DD_Destino
        '
        Me.DD_Destino.FormattingEnabled = True
        Me.DD_Destino.Location = New System.Drawing.Point(125, 24)
        Me.DD_Destino.Name = "DD_Destino"
        Me.DD_Destino.Size = New System.Drawing.Size(150, 21)
        Me.DD_Destino.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(280, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Importar Listado"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TB_Asunto
        '
        Me.TB_Asunto.Location = New System.Drawing.Point(96, 58)
        Me.TB_Asunto.Name = "TB_Asunto"
        Me.TB_Asunto.Size = New System.Drawing.Size(179, 20)
        Me.TB_Asunto.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(50, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Asunto"
        '
        'TB_Cuerpo
        '
        Me.TB_Cuerpo.Location = New System.Drawing.Point(50, 104)
        Me.TB_Cuerpo.Multiline = True
        Me.TB_Cuerpo.Name = "TB_Cuerpo"
        Me.TB_Cuerpo.Size = New System.Drawing.Size(349, 190)
        Me.TB_Cuerpo.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(324, 304)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Enviar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'EdiciónToolStripMenuItem
        '
        Me.EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        Me.EdiciónToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.EdiciónToolStripMenuItem.Text = "Edición"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 550)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TB_Respuesta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TB_Mascara)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB_Contraseña)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_Email)
        Me.Controls.Add(Me.DD_Email)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_Puerto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_Servidor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DD_Servidor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "FullPost"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DD_Servidor As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_Servidor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_Puerto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TB_Email As System.Windows.Forms.TextBox
    Friend WithEvents DD_Email As System.Windows.Forms.ComboBox
    Friend WithEvents TB_Contraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TB_Mascara As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TB_Respuesta As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DD_Destino As System.Windows.Forms.ComboBox
    Friend WithEvents TB_Asunto As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TB_Cuerpo As System.Windows.Forms.TextBox
    Friend WithEvents EdiciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
