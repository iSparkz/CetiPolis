<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuInicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuInicial))
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConsultarXML = New System.Windows.Forms.Button()
        Me.btnGenerarBoletos = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sfdGuardarPDF = New System.Windows.Forms.SaveFileDialog()
        Me.sfdGuardarXML = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.Window
        Me.btnAgregar.Location = New System.Drawing.Point(335, 112)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(127, 23)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar Funcion"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.Window
        Me.btnModificar.Location = New System.Drawing.Point(335, 151)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(127, 23)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar Funcion"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Window
        Me.btnEliminar.Location = New System.Drawing.Point(335, 190)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(127, 23)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar Funcion"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.SystemColors.Window
        Me.btnCerrarSesion.Location = New System.Drawing.Point(335, 229)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(127, 23)
        Me.btnCerrarSesion.TabIndex = 3
        Me.btnCerrarSesion.Text = "Cerrar Sesion"
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.BackColor = System.Drawing.Color.Transparent
        Me.lblBienvenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.lblBienvenido.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblBienvenido.Location = New System.Drawing.Point(35, 33)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(718, 36)
        Me.lblBienvenido.TabIndex = 4
        Me.lblBienvenido.Text = "Bienvenido al sistema de gestión Cetipolis <Usuario>"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(269, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "¿Qué desea hacer?"
        '
        'btnConsultarXML
        '
        Me.btnConsultarXML.BackColor = System.Drawing.SystemColors.Window
        Me.btnConsultarXML.Image = CType(resources.GetObject("btnConsultarXML.Image"), System.Drawing.Image)
        Me.btnConsultarXML.Location = New System.Drawing.Point(12, 374)
        Me.btnConsultarXML.Name = "btnConsultarXML"
        Me.btnConsultarXML.Size = New System.Drawing.Size(119, 76)
        Me.btnConsultarXML.TabIndex = 6
        Me.btnConsultarXML.UseVisualStyleBackColor = False
        '
        'btnGenerarBoletos
        '
        Me.btnGenerarBoletos.BackColor = System.Drawing.SystemColors.Window
        Me.btnGenerarBoletos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarBoletos.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnGenerarBoletos.Image = CType(resources.GetObject("btnGenerarBoletos.Image"), System.Drawing.Image)
        Me.btnGenerarBoletos.Location = New System.Drawing.Point(653, 374)
        Me.btnGenerarBoletos.Name = "btnGenerarBoletos"
        Me.btnGenerarBoletos.Size = New System.Drawing.Size(119, 76)
        Me.btnGenerarBoletos.TabIndex = 7
        Me.btnGenerarBoletos.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(649, 331)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 40)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Generar boletos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      vendidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(37, 331)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 40)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Exportar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Peliculas"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'sfdGuardarPDF
        '
        Me.sfdGuardarPDF.DefaultExt = "pdf"
        Me.sfdGuardarPDF.FileName = "Boletos"
        Me.sfdGuardarPDF.Filter = "Archivo PDF|*.pdf"
        '
        'sfdGuardarXML
        '
        Me.sfdGuardarXML.DefaultExt = "xml"
        Me.sfdGuardarXML.FileName = "Peliculas"
        Me.sfdGuardarXML.Filter = "Archivo XML|*.xml"
        '
        'FormMenuInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 462)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGenerarBoletos)
        Me.Controls.Add(Me.btnConsultarXML)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblBienvenido)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 500)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "FormMenuInicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Inicial"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnCerrarSesion As System.Windows.Forms.Button
    Friend WithEvents lblBienvenido As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConsultarXML As System.Windows.Forms.Button
    Friend WithEvents btnGenerarBoletos As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents sfdGuardarPDF As SaveFileDialog
    Friend WithEvents sfdGuardarXML As SaveFileDialog
End Class
