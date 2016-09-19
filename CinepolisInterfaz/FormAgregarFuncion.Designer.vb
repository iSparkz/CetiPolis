<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgregarFuncion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAgregarFuncion))
        Me.btnAgregarFuncion = New System.Windows.Forms.Button()
        Me.txtNombreFuncion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSala = New System.Windows.Forms.TextBox()
        Me.lblSala = New System.Windows.Forms.Label()
        Me.dtpHoraFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFecha2 = New System.Windows.Forms.Label()
        Me.lblFecha1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblHora2 = New System.Windows.Forms.Label()
        Me.lblHora1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAgregarFuncion
        '
        Me.btnAgregarFuncion.BackColor = System.Drawing.SystemColors.Window
        Me.btnAgregarFuncion.Location = New System.Drawing.Point(96, 237)
        Me.btnAgregarFuncion.Name = "btnAgregarFuncion"
        Me.btnAgregarFuncion.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarFuncion.TabIndex = 6
        Me.btnAgregarFuncion.Text = "Añadir"
        Me.btnAgregarFuncion.UseVisualStyleBackColor = False
        '
        'txtNombreFuncion
        '
        Me.txtNombreFuncion.Location = New System.Drawing.Point(27, 36)
        Me.txtNombreFuncion.Name = "txtNombreFuncion"
        Me.txtNombreFuncion.Size = New System.Drawing.Size(217, 20)
        Me.txtNombreFuncion.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(24, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre de la pelicula"
        '
        'txtSala
        '
        Me.txtSala.Location = New System.Drawing.Point(27, 91)
        Me.txtSala.Name = "txtSala"
        Me.txtSala.Size = New System.Drawing.Size(216, 20)
        Me.txtSala.TabIndex = 1
        '
        'lblSala
        '
        Me.lblSala.AutoSize = True
        Me.lblSala.BackColor = System.Drawing.Color.Transparent
        Me.lblSala.ForeColor = System.Drawing.SystemColors.Window
        Me.lblSala.Location = New System.Drawing.Point(27, 75)
        Me.lblSala.Name = "lblSala"
        Me.lblSala.Size = New System.Drawing.Size(28, 13)
        Me.lblSala.TabIndex = 4
        Me.lblSala.Text = "Sala"
        '
        'dtpHoraFinal
        '
        Me.dtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraFinal.Location = New System.Drawing.Point(153, 203)
        Me.dtpHoraFinal.Name = "dtpHoraFinal"
        Me.dtpHoraFinal.ShowUpDown = True
        Me.dtpHoraFinal.Size = New System.Drawing.Size(90, 20)
        Me.dtpHoraFinal.TabIndex = 5
        Me.dtpHoraFinal.Value = New Date(2016, 9, 13, 12, 1, 0, 0)
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.CustomFormat = ""
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraInicio.Location = New System.Drawing.Point(27, 203)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.ShowUpDown = True
        Me.dtpHoraInicio.Size = New System.Drawing.Size(90, 20)
        Me.dtpHoraInicio.TabIndex = 4
        Me.dtpHoraInicio.Value = New Date(2016, 9, 13, 12, 0, 0, 0)
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(153, 150)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(90, 20)
        Me.dtpFechaFinal.TabIndex = 3
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(27, 150)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(90, 20)
        Me.dtpFechaInicio.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(129, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "-"
        '
        'lblFecha2
        '
        Me.lblFecha2.AutoSize = True
        Me.lblFecha2.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha2.ForeColor = System.Drawing.SystemColors.Window
        Me.lblFecha2.Location = New System.Drawing.Point(141, 127)
        Me.lblFecha2.Name = "lblFecha2"
        Me.lblFecha2.Size = New System.Drawing.Size(107, 13)
        Me.lblFecha2.TabIndex = 38
        Me.lblFecha2.Text = "Fecha de finalización"
        '
        'lblFecha1
        '
        Me.lblFecha1.AutoSize = True
        Me.lblFecha1.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha1.ForeColor = System.Drawing.SystemColors.Window
        Me.lblFecha1.Location = New System.Drawing.Point(24, 127)
        Me.lblFecha1.Name = "lblFecha1"
        Me.lblFecha1.Size = New System.Drawing.Size(79, 13)
        Me.lblFecha1.TabIndex = 37
        Me.lblFecha1.Text = "Fecha de inicio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(129, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "-"
        '
        'lblHora2
        '
        Me.lblHora2.AutoSize = True
        Me.lblHora2.BackColor = System.Drawing.Color.Transparent
        Me.lblHora2.ForeColor = System.Drawing.SystemColors.Window
        Me.lblHora2.Location = New System.Drawing.Point(141, 184)
        Me.lblHora2.Name = "lblHora2"
        Me.lblHora2.Size = New System.Drawing.Size(103, 13)
        Me.lblHora2.TabIndex = 35
        Me.lblHora2.Text = "Hora de Finalización"
        '
        'lblHora1
        '
        Me.lblHora1.AutoSize = True
        Me.lblHora1.BackColor = System.Drawing.Color.Transparent
        Me.lblHora1.ForeColor = System.Drawing.SystemColors.Window
        Me.lblHora1.Location = New System.Drawing.Point(24, 184)
        Me.lblHora1.Name = "lblHora1"
        Me.lblHora1.Size = New System.Drawing.Size(72, 13)
        Me.lblHora1.TabIndex = 34
        Me.lblHora1.Text = "Hora de inicio"
        '
        'FormAgregarFuncion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(274, 301)
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
        Me.Controls.Add(Me.txtNombreFuncion)
        Me.Controls.Add(Me.btnAgregarFuncion)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(290, 340)
        Me.MinimumSize = New System.Drawing.Size(290, 340)
        Me.Name = "FormAgregarFuncion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Función"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregarFuncion As System.Windows.Forms.Button
    Friend WithEvents txtNombreFuncion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSala As System.Windows.Forms.TextBox
    Friend WithEvents lblSala As System.Windows.Forms.Label
    Friend WithEvents dtpHoraFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHoraInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFecha2 As System.Windows.Forms.Label
    Friend WithEvents lblFecha1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblHora2 As System.Windows.Forms.Label
    Friend WithEvents lblHora1 As System.Windows.Forms.Label
End Class
