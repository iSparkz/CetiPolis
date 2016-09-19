Public Class FormEliminarFuncion

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.Close()
    End Sub

    Private Sub FormEliminarFuncion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormMenuInicial.Hide()
    End Sub

    Private Sub FormEliminarFuncion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormMenuInicial.Show()
    End Sub
End Class