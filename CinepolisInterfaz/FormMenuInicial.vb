Public Class FormMenuInicial

    Protected DatosForm1 As New FormInicioSesion()

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.Hide()
        FormAgregarFuncion.Show()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Me.Hide()
        FormModificarFuncion.Show()
    End Sub

    Private Sub FormMenuInicial_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormInicioSesion.Show()
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        FormInicioSesion.Show()
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.Hide()
        FormEliminarFuncion.Show()
    End Sub

    Private Sub FormMenuInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBienvenido.Text = "Bienvenido al sistema de gestión Cetipolis <" + FormInicioSesion.myReader(0) + ">"
    End Sub
End Class