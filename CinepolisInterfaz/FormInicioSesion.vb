Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography
Public Class FormInicioSesion
    Public myConn As SqlConnection
    Private myCmd As SqlCommand
    Public myReader As SqlDataReader
    Public globalUsername As String

    Private Function StringToHash(Input As String) As String
        Dim Sha256 As SHA256 = SHA256Managed.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(Input)
        Dim hash As Byte() = Sha256.ComputeHash(bytes)
        Dim StringBuilder As New StringBuilder()
        For i As Integer = 0 To hash.Length - 1
            StringBuilder.Append(hash(i).ToString("x2"))
        Next
        Return StringBuilder.ToString()
    End Function

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim ConnectionString As String
        ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\db_Cetipolis.mdf;" &
            "Integrated Security=True;Connect Timeout=30"
        Dim myConn As New SqlConnection(ConnectionString)
        myConn.Open()
        Dim sqlQuery As String
        Dim Username As String
        Dim Password As String
        Username = txtUsuario.Text
        Password = StringToHash(txtPassword.Text)
        sqlQuery = "SELECT username,password,name,lastName FROM employees WHERE username ='" + Username + "' and password ='" + Password + "'"
        myCmd = New SqlCommand(sqlQuery, myConn)
        myReader = myCmd.ExecuteReader()
        If myReader.HasRows Then
            txtPassword.Clear()
            myReader.Read()
            MessageBox.Show("Bienvenido " + myReader("Name") + " " + myReader("lastName"))
            globalUsername = myReader("username")
            FormMenuInicial.Show()
            Me.Hide()
        Else
            MessageBox.Show("No existe esa combinacion de usuario/contraseña en nuestro sistema")
        End If
        myConn.Close()
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        AcceptButton = btnIngresar
    End Sub

    Private Sub FormInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        Process.Start("CETIPolis.chm")
    End Sub
End Class

