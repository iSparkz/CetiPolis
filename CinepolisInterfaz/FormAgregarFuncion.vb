Public Class FormAgregarFuncion

    Private myCmd As SqlClient.SqlCommand
    Private myReader As SqlClient.SqlDataReader
    Private fileName As String
    Private id_cinema As Integer
    Private Complejo As String

    Private Sub FormAgregarFuncion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormMenuInicial.Hide()
        Dim FormAux As New FormInicioSesion
        Dim Query As String
        Dim ConnectionString As String
        Dim Ciudad As String
        ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\db_Cetipolis.mdf;" &
            "Integrated Security=True;Connect Timeout=30"
        FormAux.myConn = New SqlClient.SqlConnection(ConnectionString)
        FormAux.myConn.Open()
        Query = "Select city,username From employees where username='" & FormInicioSesion.globalUsername & "'"
        myCmd = New SqlClient.SqlCommand(Query, FormAux.myConn)
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        Ciudad = myReader("city")
        myReader.Close()
        Query = "select cinemas.city,cinemas.name,employees.city FROM employees INNER JOIN cinemas ON cinemas.city = employees.city WHERE cinemas.city ='" & Ciudad & "'"
        myCmd = New SqlClient.SqlCommand(Query, FormAux.myConn)
        myReader = myCmd.ExecuteReader()
        While (myReader.Read())
            cboComplejo.Items.Add(myReader("name"))
        End While
        myReader.Close()
        FormAux.myConn.Close()


    End Sub

    Private Sub FormAgregarFuncion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormMenuInicial.Show()
    End Sub

    Private Sub btnAgregarFuncion_Click(sender As Object, e As EventArgs) Handles btnAgregarFuncion.Click
        Dim FormAux As New FormInicioSesion
        Dim Query As String
        Dim ConnectionString As String
        ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\db_Cetipolis.mdf;" &
            "Integrated Security=True;Connect Timeout=30"
        FormAux.myConn = New SqlClient.SqlConnection(ConnectionString)
        FormAux.myConn.Open()
        Query = "Insert into Movies(movieName,id_room,startDate,finishDate,startTime,finishTime,Price,movieImage,Description,id_cinema)" _
                & "values('" & txtNombreFuncion.Text & "'," & txtSala.Text & "," & "@startDate" &
                "," & "@finishDate" & "," & "@startTime" & "," & "@finishTime" &
                "," & txtPrecio.Text & ",0x8950,'" & rtbDescripcion.Text & "'," & id_cinema & ")"
        myCmd = New SqlClient.SqlCommand(Query, FormAux.myConn)
        myCmd.Parameters.Add(New SqlClient.SqlParameter("@startDate", dtpFechaInicio.Value.Date))
        myCmd.Parameters.Add(New SqlClient.SqlParameter("@finishDate", dtpFechaFinal.Value.Date))
        myCmd.Parameters.Add(New SqlClient.SqlParameter("@startTime", dtpHoraInicio.Value.TimeOfDay))
        myCmd.Parameters.Add(New SqlClient.SqlParameter("@finishTime", dtpHoraFinal.Value.TimeOfDay))
        myReader = myCmd.ExecuteReader()
        myReader.Close()
        Query = "Update Movies SET movieImage = (SELECT BulkColumn FROM OPENROWSET(BULK  N'" & fileName &
                "', SINGLE_BLOB) movieImage) WHERE movieName = '" & txtNombreFuncion.Text & "'"
        myCmd = New SqlClient.SqlCommand(Query, FormAux.myConn)
        myReader = myCmd.ExecuteReader()
        FormAux.myConn.Close()
        Me.Close()
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboComplejo.SelectedIndexChanged
        Dim FormAux As New FormInicioSesion
        Dim Query As String
        Dim ConnectionString As String
        ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\db_Cetipolis.mdf;" &
            "Integrated Security=True;Connect Timeout=30"
        FormAux.myConn = New SqlClient.SqlConnection(ConnectionString)
        FormAux.myConn.Open()
        Query = "select id_cinema,name From cinemas WHERE name ='" & cboComplejo.Text & "'"
        myCmd = New SqlClient.SqlCommand(Query, FormAux.myConn)
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        id_cinema = myReader("id_cinema")
        myReader.Close()
        FormAux.myConn.Close()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        Process.Start("CETIPolis.chm")
    End Sub
End Class