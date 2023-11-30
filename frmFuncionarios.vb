Imports MySql.Data.MySqlClient
Public Class frmFuncionarios

    Private Sub frmFuncionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim funcionarios As MySqlDataReader = operaBd("SELECT idFunc, usuario, cpf, cargo FROM tb_usuarios WHERE ativo = 1")

        While funcionarios.Read()

            dgvFuncionarios.Rows.Add({funcionarios(0), funcionarios(1), funcionarios(2), funcionarios(3)})
        End While
    End Sub

    Private Sub frmFuncionarios_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        fecharForm(Me.Name)
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        frmCadastrar.Show()
    End Sub

    Private Sub dgvFuncionarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFuncionarios.CellContentClick
        If e.ColumnIndex = 4 Then
            frmCadastrar.idFuncionario = dgvFuncionarios.Rows(e.RowIndex).Cells(0).Value
            frmCadastrar.Show()
        End If
    End Sub
End Class