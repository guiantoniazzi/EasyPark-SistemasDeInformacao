Imports MySql.Data.MySqlClient
Public Class frmCaixa
    Private Sub frmCaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim transacoes As MySqlDataReader = operaBd("SELECT tb_vagas.nmrVaga, tb_transacoes.valorTotal, tb_transacoes.dataHora FROM tb_transacoes LEFT JOIN tb_vagas ON tb_transacoes.idEstacionada = tb_vagas.idEstacionada")

        While transacoes.Read()
            dgvFuncionarios.Rows.Add({transacoes(0), transacoes(1), transacoes(2)})
            lblTotal.Text = CInt(lblTotal.Text) + transacoes(1)
        End While
        lblTotal.Text = "TOTAL: R$" & lblTotal.Text
    End Sub

    Private Sub frmCaixa_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        fecharForm(Me.Name)
    End Sub

    Private Sub dgvFuncionarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFuncionarios.CellContentClick

    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class