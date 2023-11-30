Imports MySql.Data.MySqlClient
Public Class frmLogin
    Dim funcoes As New funcoes()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim login As MySqlDataReader = operaBd("SELECT idFunc, cpf, usuario, cargo FROM tb_usuarios WHERE usuario = '" & txtUsuario.Text & "' AND senha = '" & txtSenha.Text & "' AND ativo = 1")

        If login.Read() Then
            usuario.id = login(0)
            usuario.cpf = login(1)
            usuario.usuario = login(2)
            usuario.cargo = login(3)

            frmMenu.Show()
        Else
            MsgBox("Usuário ou senha incorretos")
        End If
    End Sub

    Private Sub frmLogin_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If (Me.Visible) Then
            txtUsuario.Text = ""
            txtSenha.Text = ""
            funcoes.fecharForm(Me.Name)
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

