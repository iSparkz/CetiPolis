Public Class FormMenuInicial

    Public Shared Function ResizeImage(ByVal InputImage As Image, Size1 As Integer, Size2 As Integer) As Image
        Return New Bitmap(InputImage, New Size(Size1, Size2))
    End Function


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
        lblBienvenido.Text = "Bienvenido al sistema de gestión Cetipolis <" + FormInicioSesion.globalUsername + ">"

    End Sub
End Class