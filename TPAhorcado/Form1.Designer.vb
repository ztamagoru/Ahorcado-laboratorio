<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerPalabrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComenzarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReiniciarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MejoresTiemposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 206)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Cerrar"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(115, 135)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(90, 20)
        Me.TextBox1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 138)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(97, 169)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 32)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Comenzar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 82)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 28)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ahorcado"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.PartidaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(279, 24)
        Me.MenuStrip1.TabIndex = 11
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
        Me.ComenzarToolStripMenuItem.CheckOnClick = True
        Me.ComenzarToolStripMenuItem.Enabled = False
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
        Me.MejoresTiemposToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.MejoresTiemposToolStripMenuItem.Text = "Mejores tiempos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Enabled = False
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 269)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerPalabrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PartidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReiniciarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MejoresTiemposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComenzarToolStripMenuItem As ToolStripMenuItem
End Class
