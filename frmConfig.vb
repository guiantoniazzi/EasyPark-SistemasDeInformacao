Imports MySql.Data.MySqlClient
Public Class frmConfig
    Private Sub frmConfig_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        fecharForm(Me.Name)
    End Sub


    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim retorno As MySqlDataReader = operaBd("SELECT * FROM tb_configuracoes")

        Try
            If retorno.Read = True Then
                txtVagas.Text = retorno(1)
                txtPrimeiraHora.Text = retorno(2)
                txtDemaisHoras.Text = retorno(3)
                txtDiaria.Text = retorno(4)
            Else
                txtVagas.Text = 0
                txtPrimeiraHora.Text = 0
                txtDemaisHoras.Text = 0
                txtDiaria.Text = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim inforsis As MySqlDataReader = operaBd("SELECT * FROM tb_configuracoes")
        Try
            If inforsis.Read = True Then
                query = "UPDATE tb_configuracoes SET nmrVagas = " & txtVagas.Text _
                    & ", vlPrimeiraHora = " & limpaVirgula(txtPrimeiraHora.Text) _
                    & ", vlHrsExtras = " & limpaVirgula(txtDemaisHoras.Text) _
                    & ", vlDiaria = " & limpaVirgula(txtDiaria.Text) _
                    & " WHERE id = " & inforsis(0)
            Else
                query = "INSERT INTO tb_configuracoes (nmrVagas, vlPrimeiraHora, vlHrsExtras, vlDiaria) VALUES (" & txtVagas.Text & ", " & limpaVirgula(txtPrimeiraHora.Text) & ", " & limpaVirgula(txtDemaisHoras.Text) & ", " & limpaVirgula(txtDiaria.Text) & ")"
            End If
            operaBd(query)
            MsgBox("Configurações salvas com sucesso")
            frmMenu.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class