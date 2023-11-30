Imports MySql.Data.MySqlClient
Public Class frmCadastrar
    Public alteracao, idFuncionario
    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        frmFuncionarios.Show()
    End Sub

    Private Sub frmCadastrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If idFuncionario IsNot Nothing Then
            Dim funcionario As MySqlDataReader = operaBd("SELECT cpf, usuario, senha, cargo FROM tb_usuarios WHERE idFunc = " & idFuncionario)

            If funcionario.Read() Then
                alteracao = True

                txtCpf.Text = funcionario(0)
                txtUsuario.Text = funcionario(1)
                txtSenha.Text = funcionario(2)
                cmbCargo.SelectedItem = funcionario(3)
            End If
        Else
            alteracao = False
            btnExcluir.Visible = False
        End If

    End Sub

    Private Sub frmCadastrar_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        fecharForm(Me.Name)
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If cmbCargo.SelectedItem = "" Then
            MsgBox("Preencha o cargo corretamente com as opções fornecidas")
        Else
            If alteracao Then
                operaBd("UPDATE tb_usuarios SET cpf = '" & txtCpf.Text & "', usuario = '" & txtUsuario.Text & "', senha = '" & txtSenha.Text & "', cargo = '" & cmbCargo.SelectedItem & "' WHERE idFunc = " & idFuncionario)
                MsgBox("Dados alterados com sucesso")
            Else
                operaBd("INSERT INTO tb_usuarios (cpf, usuario, senha, cargo, ativo) VALUES ('" & txtCpf.Text & "', '" & txtUsuario.Text & "', '" & txtSenha.Text & "', '" & cmbCargo.SelectedItem & "', 1)")
                MsgBox("Usuário inserido com sucesso")
            End If
            frmFuncionarios.Show()
        End If

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        operaBd("UPDATE tb_usuarios SET ativo = 0 WHERE idFunc = " & idFuncionario)
        MsgBox("Usuário excluído com sucesso")

        frmFuncionarios.Show()
    End Sub
End Class