Public Class FormEliminarFuncion

    Private myReader As SqlClient.SqlDataReader
    Private myCmd As SqlClient.SqlCommand
    Private id_Movie, id_Cinema As String

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim FormAux As New FormInicioSesion
        Dim Query As String
        Dim ConnectionString As String
        ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\db_Cetipolis.mdf;" &
            "Integrated Security=True;Connect Timeout=30"
        FormAux.myConn = New SqlClient.SqlConnection(ConnectionString)
        FormAux.myConn.Open()
        Query = "DELETE FROM tickets Where id_movie =" & id_Movie
        myCmd = New SqlClient.SqlCommand(Query, FormAux.myConn)
        myCmd.ExecuteNonQuery()
        myReader.Close()
        Query = "DELETE FROM movies Where id_movie =" & id_Movie
        myCmd = New SqlClient.SqlCommand(Query, FormAux.myConn)
        myCmd.ExecuteNonQuery()
        FormAux.myConn.Close()
        Me.Close()
    End Sub

    Private Sub FormEliminarFuncion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        cboNombre.Enabled = False
    End Sub

    Private Sub FormEliminarFuncion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormMenuInicial.Show()
    End Sub

    Private Sub cboComplejo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboComplejo.SelectedIndexChanged
        cboNombre.Text = "Elija una pelicula por favor..."
        cboNombre.Items.Clear()
        cboNombre.Enabled = True
        Dim Query As String
        Dim FormAux As New FormInicioSesion
        Dim ConnectionString As String
        ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\db_Cetipolis.mdf;" &
            "Integrated Security=True;Connect Timeout=30"
        FormAux.myConn = New SqlClient.SqlConnection(ConnectionString)
        FormAux.myConn.Open()
        Query = "Select * From Movies INNER JOIN cinemas ON cinemas.id_cinema = movies.id_cinema Where cinemas.name ='" & cboComplejo.Text & "'"
        myCmd = New SqlClient.SqlCommand(Query, FormAux.myConn)
        myReader = myCmd.ExecuteReader()
        While (myReader.Read())
            id_Cinema = myReader("id_cinema")
            cboNombre.Items.Add(myReader("movieName"))
        End While
        myReader.Close()
        FormAux.myConn.Close()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        Process.Start("CETIPolis.chm")
    End Sub

    Private Sub cboNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombre.SelectedIndexChanged
        Dim FormAux As New FormInicioSesion
        Dim Query As String
        Dim ConnectionString As String
        ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\db_Cetipolis.mdf;" &
            "Integrated Security=True;Connect Timeout=30"
        FormAux.myConn = New SqlClient.SqlConnection(ConnectionString)
        FormAux.myConn.Open()
        Query = "Select id_movie,movieName,id_cinema FROM movies Where id_cinema =" & id_Cinema & " and movieName='" & cboNombre.Text & "'"
        myCmd = New SqlClient.SqlCommand(Query, FormAux.myConn)
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        id_Movie = myReader("id_movie")
        FormAux.myConn.Close()
    End Sub
End Class