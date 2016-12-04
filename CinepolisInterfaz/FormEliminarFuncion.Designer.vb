<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEliminarFuncion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEliminarFuncion))
        Me.cboNombre = New System.Windows.Forms.ComboBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lblComplejo = New System.Windows.Forms.Label()
        Me.cboComplejo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboNombre
        '
        Me.cboNombre.FormattingEnabled = True
        Me.cboNombre.Location = New System.Drawing.Point(34, 83)
        Me.cboNombre.Name = "cboNombre"
        Me.cboNombre.Size = New System.Drawing.Size(200, 21)
        Me.cboNombre.TabIndex = 36
        Me.cboNombre.Text = "Elija una pelicula por favor..."
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(97, 121)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 37
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'lblComplejo
        '
        Me.lblComplejo.AutoSize = True
        Me.lblComplejo.BackColor = System.Drawing.Color.Transparent
        Me.lblComplejo.ForeColor = System.Drawing.SystemColors.Window
        Me.lblComplejo.Location = New System.Drawing.Point(31, 11)
        Me.lblComplejo.Name = "lblComplejo"
        Me.lblComplejo.Size = New System.Drawing.Size(53, 13)
        Me.lblComplejo.TabIndex = 50
        Me.lblComplejo.Text = "Complejo:"
        '
        'cboComplejo
        '
        Me.cboComplejo.FormattingEnabled = True
        Me.cboComplejo.Location = New System.Drawing.Point(34, 27)
        Me.cboComplejo.Name = "cboComplejo"
        Me.cboComplejo.Size = New System.Drawing.Size(200, 21)
        Me.cboComplejo.TabIndex = 49
        Me.cboComplejo.Text = "Selecciona un complejo..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(31, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Nombre de la pelicula"
        '
        'FormEliminarFuncion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(274, 302)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblComplejo)
        Me.Controls.Add(Me.cboComplejo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.cboNombre)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(290, 340)
        Me.MinimumSize = New System.Drawing.Size(290, 340)
        Me.Name = "FormEliminarFuncion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar Función"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboNombre As System.Windows.Forms.ComboBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents lblComplejo As Label
    Friend WithEvents cboComplejo As ComboBox
    Friend WithEvents Label1 As Label
End Class
