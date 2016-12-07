<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModificarFuncion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormModificarFuncion))
        Me.btnModificarFuncion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSala = New System.Windows.Forms.TextBox()
        Me.lblSala = New System.Windows.Forms.Label()
        Me.lblHora1 = New System.Windows.Forms.Label()
        Me.lblHora2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFecha1 = New System.Windows.Forms.Label()
        Me.lblFecha2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraFinal = New System.Windows.Forms.DateTimePicker()
        Me.cboNombre = New System.Windows.Forms.ComboBox()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.rtbDescripcion = New System.Windows.Forms.RichTextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblImagen = New System.Windows.Forms.Label()
        Me.btnImagen = New System.Windows.Forms.Button()
        Me.lblComplejo = New System.Windows.Forms.Label()
        Me.cboComplejo = New System.Windows.Forms.ComboBox()
        Me.opfAbrir = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnModificarFuncion
        '
        Me.btnModificarFuncion.BackColor = System.Drawing.SystemColors.Window
        Me.btnModificarFuncion.Location = New System.Drawing.Point(332, 535)
        Me.btnModificarFuncion.Name = "btnModificarFuncion"
        Me.btnModificarFuncion.Size = New System.Drawing.Size(75, 23)
        Me.btnModificarFuncion.TabIndex = 6
        Me.btnModificarFuncion.Text = "Modificar"
        Me.btnModificarFuncion.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(28, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nombre de la pelicula"
        '
        'txtSala
        '
        Me.txtSala.Location = New System.Drawing.Point(31, 150)
        Me.txtSala.Name = "txtSala"
        Me.txtSala.Size = New System.Drawing.Size(218, 20)
        Me.txtSala.TabIndex = 1
        '
        'lblSala
        '
        Me.lblSala.AutoSize = True
        Me.lblSala.BackColor = System.Drawing.Color.Transparent
        Me.lblSala.ForeColor = System.Drawing.SystemColors.Window
        Me.lblSala.Location = New System.Drawing.Point(31, 134)
        Me.lblSala.Name = "lblSala"
        Me.lblSala.Size = New System.Drawing.Size(28, 13)
        Me.lblSala.TabIndex = 19
        Me.lblSala.Text = "Sala"
        '
        'lblHora1
        '
        Me.lblHora1.AutoSize = True
        Me.lblHora1.BackColor = System.Drawing.Color.Transparent
        Me.lblHora1.ForeColor = System.Drawing.SystemColors.Window
        Me.lblHora1.Location = New System.Drawing.Point(26, 243)
        Me.lblHora1.Name = "lblHora1"
        Me.lblHora1.Size = New System.Drawing.Size(72, 13)
        Me.lblHora1.TabIndex = 21
        Me.lblHora1.Text = "Hora de inicio"
        '
        'lblHora2
        '
        Me.lblHora2.AutoSize = True
        Me.lblHora2.BackColor = System.Drawing.Color.Transparent
        Me.lblHora2.ForeColor = System.Drawing.SystemColors.Window
        Me.lblHora2.Location = New System.Drawing.Point(142, 243)
        Me.lblHora2.Name = "lblHora2"
        Me.lblHora2.Size = New System.Drawing.Size(103, 13)
        Me.lblHora2.TabIndex = 22
        Me.lblHora2.Text = "Hora de Finalización"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(126, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "-"
        '
        'lblFecha1
        '
        Me.lblFecha1.AutoSize = True
        Me.lblFecha1.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha1.ForeColor = System.Drawing.SystemColors.Window
        Me.lblFecha1.Location = New System.Drawing.Point(28, 186)
        Me.lblFecha1.Name = "lblFecha1"
        Me.lblFecha1.Size = New System.Drawing.Size(79, 13)
        Me.lblFecha1.TabIndex = 26
        Me.lblFecha1.Text = "Fecha de inicio"
        '
        'lblFecha2
        '
        Me.lblFecha2.AutoSize = True
        Me.lblFecha2.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha2.ForeColor = System.Drawing.SystemColors.Window
        Me.lblFecha2.Location = New System.Drawing.Point(142, 186)
        Me.lblFecha2.Name = "lblFecha2"
        Me.lblFecha2.Size = New System.Drawing.Size(107, 13)
        Me.lblFecha2.TabIndex = 28
        Me.lblFecha2.Text = "Fecha de finalización"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(126, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "-"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(29, 209)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(85, 20)
        Me.dtpFechaInicio.TabIndex = 2
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(147, 209)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(85, 20)
        Me.dtpFechaFinal.TabIndex = 3
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraInicio.Location = New System.Drawing.Point(29, 262)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.ShowUpDown = True
        Me.dtpHoraInicio.Size = New System.Drawing.Size(85, 20)
        Me.dtpHoraInicio.TabIndex = 4
        Me.dtpHoraInicio.Value = New Date(2016, 9, 13, 0, 0, 0, 0)
        '
        'dtpHoraFinal
        '
        Me.dtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraFinal.Location = New System.Drawing.Point(147, 262)
        Me.dtpHoraFinal.Name = "dtpHoraFinal"
        Me.dtpHoraFinal.ShowUpDown = True
        Me.dtpHoraFinal.Size = New System.Drawing.Size(85, 20)
        Me.dtpHoraFinal.TabIndex = 5
        Me.dtpHoraFinal.Value = New Date(2016, 9, 13, 0, 0, 0, 0)
        '
        'cboNombre
        '
        Me.cboNombre.FormattingEnabled = True
        Me.cboNombre.Location = New System.Drawing.Point(29, 95)
        Me.cboNombre.Name = "cboNombre"
        Me.cboNombre.Size = New System.Drawing.Size(220, 21)
        Me.cboNombre.TabIndex = 0
        Me.cboNombre.Text = "Elija una pelicula por favor..."
        '
        'pbImagen
        '
        Me.pbImagen.Location = New System.Drawing.Point(439, 44)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(250, 350)
        Me.pbImagen.TabIndex = 30
        Me.pbImagen.TabStop = False
        '
        'rtbDescripcion
        '
        Me.rtbDescripcion.Location = New System.Drawing.Point(29, 433)
        Me.rtbDescripcion.Name = "rtbDescripcion"
        Me.rtbDescripcion.Size = New System.Drawing.Size(660, 96)
        Me.rtbDescripcion.TabIndex = 31
        Me.rtbDescripcion.Text = ""
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(29, 312)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(85, 20)
        Me.txtPrecio.TabIndex = 32
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecio.ForeColor = System.Drawing.SystemColors.Window
        Me.lblPrecio.Location = New System.Drawing.Point(26, 296)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(40, 13)
        Me.lblPrecio.TabIndex = 33
        Me.lblPrecio.Text = "Precio:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.lblDescripcion.ForeColor = System.Drawing.SystemColors.Window
        Me.lblDescripcion.Location = New System.Drawing.Point(29, 414)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 34
        Me.lblDescripcion.Text = "Descripcion"
        '
        'lblImagen
        '
        Me.lblImagen.AutoSize = True
        Me.lblImagen.BackColor = System.Drawing.Color.Transparent
        Me.lblImagen.ForeColor = System.Drawing.SystemColors.Window
        Me.lblImagen.Location = New System.Drawing.Point(436, 28)
        Me.lblImagen.Name = "lblImagen"
        Me.lblImagen.Size = New System.Drawing.Size(113, 13)
        Me.lblImagen.TabIndex = 45
        Me.lblImagen.Text = "Imagen(250px*350px):"
        '
        'btnImagen
        '
        Me.btnImagen.BackColor = System.Drawing.SystemColors.Window
        Me.btnImagen.Location = New System.Drawing.Point(500, 400)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Size = New System.Drawing.Size(125, 23)
        Me.btnImagen.TabIndex = 47
        Me.btnImagen.Text = "Seleccionar imagen..."
        Me.btnImagen.UseVisualStyleBackColor = False
        '
        'lblComplejo
        '
        Me.lblComplejo.AutoSize = True
        Me.lblComplejo.BackColor = System.Drawing.Color.Transparent
        Me.lblComplejo.ForeColor = System.Drawing.SystemColors.Window
        Me.lblComplejo.Location = New System.Drawing.Point(26, 28)
        Me.lblComplejo.Name = "lblComplejo"
        Me.lblComplejo.Size = New System.Drawing.Size(53, 13)
        Me.lblComplejo.TabIndex = 50
        Me.lblComplejo.Text = "Complejo:"
        '
        'cboComplejo
        '
        Me.cboComplejo.FormattingEnabled = True
        Me.cboComplejo.Location = New System.Drawing.Point(29, 44)
        Me.cboComplejo.Name = "cboComplejo"
        Me.cboComplejo.Size = New System.Drawing.Size(216, 21)
        Me.cboComplejo.TabIndex = 49
        Me.cboComplejo.Text = "Selecciona un complejo..."
        '
        'opfAbrir
        '
        Me.opfAbrir.FileName = "Selecciona una imagen"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(734, 24)
        Me.MenuStrip1.TabIndex = 51
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'FormModificarFuncion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 562)
        Me.Controls.Add(Me.lblComplejo)
        Me.Controls.Add(Me.cboComplejo)
        Me.Controls.Add(Me.btnImagen)
        Me.Controls.Add(Me.lblImagen)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.rtbDescripcion)
        Me.Controls.Add(Me.pbImagen)
        Me.Controls.Add(Me.cboNombre)
        Me.Controls.Add(Me.dtpHoraFinal)
        Me.Controls.Add(Me.dtpHoraInicio)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFecha2)
        Me.Controls.Add(Me.lblFecha1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblHora2)
        Me.Controls.Add(Me.lblHora1)
        Me.Controls.Add(Me.lblSala)
        Me.Controls.Add(Me.txtSala)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnModificarFuncion)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(750, 600)
        Me.MinimumSize = New System.Drawing.Size(750, 600)
        Me.Name = "FormModificarFuncion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Función"
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnModificarFuncion As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSala As TextBox
    Friend WithEvents lblSala As Label
    Friend WithEvents lblHora1 As Label
    Friend WithEvents lblHora2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblFecha1 As Label
    Friend WithEvents lblFecha2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents dtpHoraInicio As DateTimePicker
    Friend WithEvents dtpHoraFinal As DateTimePicker
    Friend WithEvents cboNombre As ComboBox
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents rtbDescripcion As RichTextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblImagen As Label
    Friend WithEvents btnImagen As Button
    Friend WithEvents lblComplejo As Label
    Friend WithEvents cboComplejo As ComboBox
    Friend WithEvents opfAbrir As OpenFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
End Class
