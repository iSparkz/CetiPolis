Imports System.Data.SqlClient
Public Class FormInicioSesion
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private da As SqlDataAdapter
    Private dt As DataTable
    Private dr As DataRow
    Private ConnectionString As String

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        ConnectionString = "Server=localhost\SQLExpress;Database=db_Cetipolis;Trusted_Connection=True;"
        Dim myConn As New SqlConnection(ConnectionString)
        myConn.Open()
        Dim sqlQuery As String
        Dim Username As String
        Dim Password As String
        Dim Name As String
        Username = txtUsuario.Text
        Password = txtPassword.Text
        sqlQuery = "SELECT password,username,name,lastName FROM employees WHERE username LIKE'" + Username + "' and password ='" + Password + "'"
        myCmd = New SqlCommand(sqlQuery, myConn)
        myReader = myCmd.ExecuteReader
        If myReader IsNot Nothing Then
                MessageBox.Show("Bienvenido " + myCmd.ExecuteScalar().ToString())
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
End Class

