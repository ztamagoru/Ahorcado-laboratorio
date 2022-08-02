<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.nombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listview = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(26, 19)
        Me.nombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(142, 21)
        Me.nombre.TabIndex = 20
        Me.nombre.Text = "Listado de palabras"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(270, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 21)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Cant: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'listview
        '
        Me.listview.BackColor = System.Drawing.Color.White
        Me.listview.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listview.ForeColor = System.Drawing.Color.Transparent
        Me.listview.HideSelection = False
        Me.listview.Location = New System.Drawing.Point(12, 59)
        Me.listview.Name = "listview"
        Me.listview.Size = New System.Drawing.Size(500, 435)
        Me.listview.TabIndex = 110
        Me.listview.UseCompatibleStateImageBehavior = False
        Me.listview.View = System.Windows.Forms.View.List
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 506)
        Me.Controls.Add(Me.listview)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nombre)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nombre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents listview As ListView
End Class
