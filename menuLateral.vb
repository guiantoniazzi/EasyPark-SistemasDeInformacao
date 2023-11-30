Public Class menuLateral
    Private Sub btnVagas_Click(sender As Object, e As EventArgs) Handles btnVagas.Click
        frmVagas.Show()
    End Sub

    Private Sub btnCaixa_Click(sender As Object, e As EventArgs) Handles btnCaixa.Click
        If (usuario.cargo = "Gerente") Then
            frmCaixa.Show()
        Else
            MessageBox.Show("Você não possui permissões para entrar.")
        End If
    End Sub

    Private Sub btnCadastro_Click(sender As Object, e As EventArgs) Handles btnCadastro.Click
        If (usuario.cargo = "Gerente") Then
            frmFuncionarios.Show()
        Else
            MessageBox.Show("Você não possui permissões para entrar.")
        End If
    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        frmConfig.Show()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        frmLogin.Show()
    End Sub
End Class
