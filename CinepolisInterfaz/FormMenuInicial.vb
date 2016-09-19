Public Class FormMenuInicial

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
End Class