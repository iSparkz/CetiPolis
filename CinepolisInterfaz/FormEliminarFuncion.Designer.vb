﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.cboNombreEliminar = New System.Windows.Forms.ComboBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboNombreEliminar
        '
        Me.cboNombreEliminar.FormattingEnabled = True
        Me.cboNombreEliminar.Location = New System.Drawing.Point(36, 41)
        Me.cboNombreEliminar.Name = "cboNombreEliminar"
        Me.cboNombreEliminar.Size = New System.Drawing.Size(200, 21)
        Me.cboNombreEliminar.TabIndex = 36
        Me.cboNombreEliminar.Text = "Elija una pelicula por favor..."
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(99, 110)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 37
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'FormEliminarFuncion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(274, 302)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.cboNombreEliminar)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(290, 340)
        Me.MinimumSize = New System.Drawing.Size(290, 340)
        Me.Name = "FormEliminarFuncion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar Función"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboNombreEliminar As System.Windows.Forms.ComboBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
End Class
