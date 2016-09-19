Public Class FormModificarFuncion

    Private Sub FormModificarFuncion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormMenuInicial.Show()
    End Sub

    Private Sub FormModificarFuncion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormMenuInicial.Hide()
    End Sub

    Private Sub btnModificarFuncion_Click(sender As Object, e As EventArgs) Handles btnModificarFuncion.Click
        Me.Close()
    End Sub
End Class