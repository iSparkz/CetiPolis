Imports System.Xml
Imports System.Data.SqlClient
Imports System.Data.Linq.DataContext
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf

Public Class FormMenuInicial

    Public Shared Function ResizeImage(ByVal InputImage As Image, Size1 As Integer, Size2 As Integer) As Image
        Return New Bitmap(InputImage, New Size(Size1, Size2))
    End Function

    Private Sub DrawImage(ByVal gfx As XGraphics, ByVal pdfPage As PdfPage)


        Dim Image As XImage = XImage.FromFile("Logo.png")
        Dim x As Double = (250 - Image.PixelWidth * 72 / Image.HorizontalResolution) / 2
        gfx.DrawImage(Image, (pdfPage.Width.Value / 2) - 200, (pdfPage.Height.Value / 2) - 100)


    End Sub

    Dim database As New LinqToSqlDataContext("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\db_Cetipolis.mdf;" &
            "Integrated Security=True;Connect Timeout=30")

    Private Sub createNode(ByVal pID As String, ByVal pNombre As String, ByVal pPrecio As String, ByVal pSala As String, ByVal pDescripcion As String, ByVal writer As XmlTextWriter)
        writer.WriteStartElement("Pelicula")
        writer.WriteStartElement("id_Pelicula")
        writer.WriteString(pID)
        writer.WriteEndElement()
        writer.WriteStartElement("Nombre_Pelicula")
        writer.WriteString(pNombre)
        writer.WriteEndElement()
        writer.WriteStartElement("Precio")
        writer.WriteString(pPrecio)
        writer.WriteEndElement()
        writer.WriteStartElement("Sala")
        writer.WriteString(pSala)
        writer.WriteEndElement()
        writer.WriteStartElement("Descripcion")
        writer.WriteString(pDescripcion)
        writer.WriteEndElement()
        writer.WriteEndElement()
    End Sub

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

    Private Sub btnConsultarXML_Click(sender As Object, e As EventArgs) Handles btnConsultarXML.Click


        If sfdGuardarXML.ShowDialog = DialogResult.OK Then
            Dim writer As New XmlTextWriter(sfdGuardarXML.FileName, System.Text.Encoding.UTF8)
            writer.WriteStartDocument(True)
            writer.Formatting = Formatting.Indented
            writer.Indentation = 4
            writer.WriteStartElement("Catalogo")

            Dim moviesQuery =
            From movie In database.movies
            Select movie.movieName, movie.Price, movie.id_movie, movie.Description, movie.id_room

            For Each movie In moviesQuery
                createNode(movie.id_movie, movie.movieName, movie.Price, movie.id_room, movie.Description, writer)
            Next

            writer.WriteEndElement()
            writer.WriteEndDocument()
            writer.Close()
        End If






    End Sub

    Private Sub btnGenerarBoletos_Click(sender As Object, e As EventArgs) Handles btnGenerarBoletos.Click
        Dim ticketsQuery = _
            From movie In database.movies
            Join ticket In database.tickets On movie.id_movie Equals ticket.id_movie
            Join cinema In database.cinemas On movie.id_cinema Equals cinema.id_cinema
            Select movie.movieName, movie.Price, movie.id_movie, movie.Description, movie.id_room, movie.startTime, movie.finishTime, ticket.seat, cinema.name


        Dim pdf As PdfDocument = New PdfDocument
        pdf.Info.Title = "tickets"
        For Each ticket In ticketsQuery

            Dim pdfPage As PdfPage = pdf.AddPage
            Dim graph As XGraphics = XGraphics.FromPdfPage(pdfPage)
            Dim font As XFont = New XFont("Myriad Pro", 24, XFontStyle.Bold)
            DrawImage(graph, pdfPage)

            graph.DrawString(ticket.name, font, XBrushes.White,
            New XRect(0, -60, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center)

            font = New XFont("Myriad Pro", 16, XFontStyle.Bold)
            graph.DrawString(ticket.movieName, font, XBrushes.White,
            New XRect(-100, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center)

            graph.DrawString("Sala " & ticket.id_room, font, XBrushes.White,
            New XRect(50, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center)

            graph.DrawString("$" & ticket.Price, font, XBrushes.White,
            New XRect(-100, 16, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center)

            graph.DrawString("Asiento " & ticket.seat, font, XBrushes.White,
            New XRect(-100, 32, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center)

            Dim output As String = Nothing
            output += ticket.startTime.ToString
            graph.DrawString(output, font, XBrushes.White,
            New XRect(-100, 48, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center)

            font = New XFont("Myriad Pro", 10, XFontStyle.Bold)
            graph.DrawString("Todos los derechos reservados, Aplican restricciones.", font, XBrushes.White,
            New XRect(0, 100, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center)
            graph.DrawString("Si nota algún comportamiento extraño durante la funcion", font, XBrushes.White,
            New XRect(0, 110, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center)
            graph.DrawString("favor de reportarlo a las autoridades", font, XBrushes.White,
            New XRect(0, 120, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center)


        Next

        If sfdGuardarPDF.ShowDialog = DialogResult.OK Then
            Dim pdfFilename As String = sfdGuardarPDF.FileName
            pdf.Save(pdfFilename)
        End If



    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        Process.Start("CETIPolis.chm")
    End Sub


End Class