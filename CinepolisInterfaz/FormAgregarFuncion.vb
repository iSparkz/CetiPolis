Public Class FormAgregarFuncion

    Private Sub FormAgregarFuncion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormMenuInicial.Hide()
    End Sub

    Private Sub FormAgregarFuncion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormMenuInicial.Show()
    End Sub

    Private Sub btnAgregarFuncion_Click(sender As Object, e As EventArgs) Handles btnAgregarFuncion.Click
        Me.Close()
    End Sub

    Private Sub dtpFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicio.ValueChanged

    End Sub
End Class