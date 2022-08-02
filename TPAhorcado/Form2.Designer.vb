<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerPalabrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComenzarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReiniciarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MejoresTiemposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.letras = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.piernaDer = New System.Windows.Forms.Label()
        Me.brazoDer = New System.Windows.Forms.Label()
        Me.piernaIzq = New System.Windows.Forms.Label()
        Me.Cuerpo = New System.Windows.Forms.Label()
        Me.brazoIzq = New System.Windows.Forms.Label()
        Me.cabeza = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tiempo = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.base = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.PartidaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(462, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerPalabrasToolStripMenuItem, Me.AñadirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.ArchivoToolStripMenuItem.Text = "Palabras"
        '
        'VerPalabrasToolStripMenuItem
        '
        Me.VerPalabrasToolStripMenuItem.Name = "VerPalabrasToolStripMenuItem"
        Me.VerPalabrasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VerPalabrasToolStripMenuItem.Text = "Ver listado"
        '
        'AñadirToolStripMenuItem
        '
        Me.AñadirToolStripMenuItem.Name = "AñadirToolStripMenuItem"
        Me.AñadirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AñadirToolStripMenuItem.Text = "Añadir"
        '
        'PartidaToolStripMenuItem
        '
        Me.PartidaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComenzarToolStripMenuItem, Me.ReiniciarToolStripMenuItem, Me.MejoresTiemposToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.PartidaToolStripMenuItem.Name = "PartidaToolStripMenuItem"
        Me.PartidaToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.PartidaToolStripMenuItem.Text = "Partida"
        '
        'ComenzarToolStripMenuItem
        '
        Me.ComenzarToolStripMenuItem.Name = "ComenzarToolStripMenuItem"
        Me.ComenzarToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ComenzarToolStripMenuItem.Text = "Comenzar"
        '
        'ReiniciarToolStripMenuItem
        '
        Me.ReiniciarToolStripMenuItem.Enabled = False
        Me.ReiniciarToolStripMenuItem.Name = "ReiniciarToolStripMenuItem"
        Me.ReiniciarToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ReiniciarToolStripMenuItem.Text = "Reiniciar"
        '
        'MejoresTiemposToolStripMenuItem
        '
        Me.MejoresTiemposToolStripMenuItem.Name = "MejoresTiemposToolStripMenuItem"
        Me.MejoresTiemposToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MejoresTiemposToolStripMenuItem.Text = "Mejores tiempos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Enabled = False
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'letras
        '
        Me.letras.AutoSize = True
        Me.letras.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letras.Location = New System.Drawing.Point(52, 188)
        Me.letras.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.letras.Name = "letras"
        Me.letras.Size = New System.Drawing.Size(47, 21)
        Me.letras.TabIndex = 31
        Me.letras.Text = "letras"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(52, 157)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 21)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Errores"
        '
        'piernaDer
        '
        Me.piernaDer.AutoSize = True
        Me.piernaDer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.piernaDer.Location = New System.Drawing.Point(375, 138)
        Me.piernaDer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.piernaDer.Name = "piernaDer"
        Me.piernaDer.Size = New System.Drawing.Size(13, 20)
        Me.piernaDer.TabIndex = 29
        Me.piernaDer.Text = "\"
        '
        'brazoDer
        '
        Me.brazoDer.AutoSize = True
        Me.brazoDer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brazoDer.Location = New System.Drawing.Point(378, 116)
        Me.brazoDer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.brazoDer.Name = "brazoDer"
        Me.brazoDer.Size = New System.Drawing.Size(13, 20)
        Me.brazoDer.TabIndex = 28
        Me.brazoDer.Text = "\"
        '
        'piernaIzq
        '
        Me.piernaIzq.AutoSize = True
        Me.piernaIzq.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.piernaIzq.Location = New System.Drawing.Point(363, 138)
        Me.piernaIzq.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.piernaIzq.Name = "piernaIzq"
        Me.piernaIzq.Size = New System.Drawing.Size(13, 20)
        Me.piernaIzq.TabIndex = 27
        Me.piernaIzq.Text = "/"
        '
        'Cuerpo
        '
        Me.Cuerpo.AutoSize = True
        Me.Cuerpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cuerpo.Location = New System.Drawing.Point(368, 114)
        Me.Cuerpo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Cuerpo.Name = "Cuerpo"
        Me.Cuerpo.Size = New System.Drawing.Size(14, 20)
        Me.Cuerpo.TabIndex = 26
        Me.Cuerpo.Text = "|"
        '
        'brazoIzq
        '
        Me.brazoIzq.AutoSize = True
        Me.brazoIzq.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brazoIzq.Location = New System.Drawing.Point(358, 116)
        Me.brazoIzq.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.brazoIzq.Name = "brazoIzq"
        Me.brazoIzq.Size = New System.Drawing.Size(13, 20)
        Me.brazoIzq.TabIndex = 25
        Me.brazoIzq.Text = "/"
        '
        'cabeza
        '
        Me.cabeza.AutoSize = True
        Me.cabeza.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cabeza.Location = New System.Drawing.Point(364, 96)
        Me.cabeza.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cabeza.Name = "cabeza"
        Me.cabeza.Size = New System.Drawing.Size(25, 20)
        Me.cabeza.TabIndex = 24
        Me.cabeza.Text = "〇"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(162, 300)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(51, 26)
        Me.TextBox1.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(223, 298)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 28)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 261)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(313, 28)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "palabra a descubrir"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tiempo
        '
        Me.tiempo.AutoSize = True
        Me.tiempo.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tiempo.Location = New System.Drawing.Point(79, 121)
        Me.tiempo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.tiempo.Name = "tiempo"
        Me.tiempo.Size = New System.Drawing.Size(18, 21)
        Me.tiempo.TabIndex = 20
        Me.tiempo.Text = "0"
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(18, 39)
        Me.nombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(63, 21)
        Me.nombre.TabIndex = 19
        Me.nombre.Text = "nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 21)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Tiempo"
        '
        'base
        '
        Me.base.AutoSize = True
        Me.base.Location = New System.Drawing.Point(298, 78)
        Me.base.Name = "base"
        Me.base.Size = New System.Drawing.Size(83, 104)
        Me.base.TabIndex = 32
        Me.base.Text = "ㅤㅤ┌─────┐" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ㅤㅤ│" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ㅤㅤ│" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ㅤㅤ│" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ㅤㅤ│" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ㅤㅤ│" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ㅤㅤ│" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "▒▒▒▒▒" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 367)
        Me.Controls.Add(Me.letras)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.piernaDer)
        Me.Controls.Add(Me.brazoDer)
        Me.Controls.Add(Me.piernaIzq)
        Me.Controls.Add(Me.Cuerpo)
        Me.Controls.Add(Me.brazoIzq)
        Me.Controls.Add(Me.cabeza)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tiempo)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.base)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerPalabrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PartidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReiniciarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MejoresTiemposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents letras As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents piernaDer As Label
    Friend WithEvents brazoDer As Label
    Friend WithEvents piernaIzq As Label
    Friend WithEvents Cuerpo As Label
    Friend WithEvents brazoIzq As Label
    Friend WithEvents cabeza As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tiempo As Label
    Friend WithEvents nombre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents base As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ComenzarToolStripMenuItem As ToolStripMenuItem
End Class
