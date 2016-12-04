Public Class FormModificarFuncion

    Private myReader As SqlClient.SqlDataReader
    Private myCmd As SqlClient.SqlCommand
    Private id_cinema, id_movie As Integer
    Private fileName As String
    Private myImage As New PictureBox

    Private Sub FormModificarFuncion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormMenuInicial.Show()
    End Sub

    Private Sub FormModificarFuncion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormMenuInicial.Hide()
        Dim FormAux As New FormInicioSesion
        Dim Query As String
        Dim ConnectionString As String
        Dim Ciudad As String
        ConnectionString = "Server=localhost\SQLExpress4;Database=db_Cetipolis;Trusted_Connection=True;"
        FormAux.myConn = New SqlClient.SqlConnection(ConnectionString)
        FormAux.myConn.Open()

        Query = "Select city,username From employees where username='" & FormInicioSesion.globalUsername & "'"
        myCmd = New SqlClient.SqlCommand(Query, FormAux.myConn)
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        Ciudad = myReader("city")
        myReader.Close()
        Query = "select cinemas.city,cinemas.name,employees.city FROM employees INNER JOIN cinemas ON cinemas.city = employees.city WHERE cinemas.city ='Guadalajara'"
        myCmd = New SqlClient.SqlCommand(Query, FormAux.myConn)
        myReader = myCmd.ExecuteReader()
        While (myReader.Read())
            cboComplejo.Items.Add(myReader("name"))
        End While
        myReader.Close()
        FormAux.myConn.Close()
        cboNombre.Enabled = False
    End Sub

    Private Sub btnModificarFuncion_Click(sender As Object, e As EventArgs) Handles btnModificarFuncion.Click
        Dim FormAux As New FormInicioSesion
        Dim Query As String
        Dim ConnectionString As String
        ConnectionString = "Server=localhost\SQLExpress4;Database=db_Cetipolis;Trusted_Connection=True;"
        FormAux.myConn = New SqlClient.SqlConnection(ConnectionString)
        FormAux.myConn.Open()
        Query = "UPDATE Movies SET id_room ='" & txtSala.Text & "',startDate = @startDate,finishDate = @finishDate,startTime = @startTime" &
                ",finishTime = @finishTime,Price=" & txtPrecio.Text & ",Description ='" & rtbDescripcion.Text & "',id_cinema =" & id_cinema & "WHERE id_movie =" & id_movie
        myCmd = New SqlClient.SqlCommand(Query, FormAux.myConn)
        myCmd.Parameters.Add(New SqlClient.SqlParameter("@startDate", dtpFechaInicio.Value.Date))
        myCmd.Parameters.Add(New SqlClient.SqlParameter("@finishDate", dtpFechaFinal.Value.Date))
        myCmd.Parameters.Add(New SqlClient.SqlParameter("@startTime", dtpHoraInicio.Value.TimeOfDay))
        myCmd.Parameters.Add(New SqlClient.SqlParameter("@finishTime", dtpHoraFinal.Value.TimeOfDay))
        myReader = myCmd.ExecuteReader()
        myReader.Close()
        If myImage.Image Is pbImagen.Image Then
        Else
            Query = "Update Movies SET movieImage = (SELECT BulkColumn FROM OPENROWSET(BULK  N'" & fileName &
                    "', SINGLE_BLOB) movieImage) WHERE movieName = '" & cboNombre.Text & "'"
            myCmd = New SqlClient.SqlCommand(Query, FormAux.myConn)
            myReader = myCmd.ExecuteReader()

        End If

        FormAux.myConn.Close()
        Me.Close()
    End Sub

    Private Sub cboNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombre.SelectedIndexChanged

        Dim FormAux As New FormInicioSesion
        Dim Query As String
        Dim ConnectionString As String
        ConnectionString = "Server=localhost\SQLExpress4;Database=db_Cetipolis;Trusted_Connection=True;"
        FormAux.myConn = New SqlClient.SqlConnection(ConnectionString)
        FormAux.myConn.Open()
        Query = "Select * From Movies Where movieName ='" & cboNombre.Text & "'"
        myCmd = New SqlClient.SqlCommand(Query, FormAux.myConn)
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        id_cinema = myReader("id_cinema")
        id_movie = myReader("id_movie")
        txtSala.Text = myReader("id_room")
        dtpHoraInicio.Value = DateTime.Parse("12:00:00 AM")
        dtpHoraFinal.Value = DateTime.Parse("12:00:00 AM")
        dtpFechaInicio.Value = myReader("startDate")
        dtpFechaFinal.Value = myReader("finishDate")
        dtpHoraInicio.Value += myReader("startTime")
        dtpHoraFinal.Value += myReader("finishTime")
        txtPrecio.Text = myReader("Price")
        rtbDescripcion.Text = myReader("Description")
        myReader.Close()
        Query = "Select movieImage From Movies Where movieName ='" & cboNombre.Text & "'"
        myCmd = New SqlClient.SqlCommand(Query, FormAux.myConn)
        Dim ImgStream As New IO.MemoryStream(CType(myCmd.ExecuteScalar, Byte()))
        pbImagen.Image = Image.FromStream(ImgStream)
        pbImagen.Image = FormMenuInicial.ResizeImage(pbImagen.Image, 250, 350)
        ImgStream.Dispose()
        myImage.Image = pbImagen.Image
        FormAux.myConn.Close()
    End Sub

    Private Sub cboComplejo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboComplejo.SelectedIndexChanged
        cboNombre.Text = "Elija una pelicula por favor..."
        txtPrecio.Clear()
        txtSala.Clear()
        dtpFechaFinal.ResetText()
        dtpFechaInicio.ResetText()
        dtpHoraFinal.ResetText()
        dtpHoraInicio.ResetText()
        rtbDescripcion.ResetText()
        pbImagen.Image = Nothing
        cboNombre.Items.Clear()
        cboNombre.Enabled = True
        Dim Query As String
        Dim FormAux As New FormInicioSesion
        Dim ConnectionString As String
        ConnectionString = "Server=localhost\SQLExpress4;Database=db_Cetipolis;Trusted_Connection=True;"
        FormAux.myConn = New SqlClient.SqlConnection(ConnectionString)
        FormAux.myConn.Open()
        Query = "Select * From Movies INNER JOIN cinemas ON cinemas.id_cinema = movies.id_cinema Where cinemas.name ='" & cboComplejo.Text & "'"
        myCmd = New SqlClient.SqlCommand(Query, FormAux.myConn)
        myReader = myCmd.ExecuteReader()
        While (myReader.Read())
            cboNombre.Items.Add(myReader("movieName"))
        End While
        myReader.Close()
        FormAux.myConn.Close()
    End Sub

    Private Sub btnImagen_Click(sender As Object, e As EventArgs) Handles btnImagen.Click
        If opfAbrir.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            fileName = opfAbrir.FileName()
        End If
        If System.IO.File.Exists(fileName) Then
            pbImagen.Image = Image.FromFile(fileName)
            pbImagen.Image = FormMenuInicial.ResizeImage(pbImagen.Image, 250, 350)
        End If
    End Sub
End Class