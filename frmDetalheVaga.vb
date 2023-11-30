Imports System.Globalization
Imports System.Runtime.Remoting.Messaging
Imports MySql.Data.MySqlClient
Public Class frmDetalheVaga

    Public idVaga, idEstacionada As Integer
    Private Sub frmDetalheVaga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vaga As MySqlDataReader = operaBd("SELECT placaCarro, dataEntrada, horaEntrada, nmrVaga, idEstacionada FROM tb_vagas WHERE nmrVaga = " & idVaga & " AND dataSaida IS NULL")

        Dim nome = idVaga + 1

        'Busca os dados da vaga no bd
        If vaga.Read() Then
            idEstacionada = vaga(4)
            lblVaga.Text = nome
            lblVaga.BackColor = Color.Red

            dtpDiaSaida.CustomFormat = "dd/MM/yyyy"
            dtpDiaSaida.Format = DateTimePickerFormat.Custom
            dtpDiaSaida.ShowUpDown = True

            dtpHorarioSaida.CustomFormat = "HH:mm"
            dtpHorarioSaida.Format = DateTimePickerFormat.Custom
            dtpHorarioSaida.ShowUpDown = True

            txtPlaca.Visible = False
            dtpDiaEntrada.Visible = False
            dtpHorarioEntrada.Visible = False

            btnEstacionar.Visible = False

            lblPlaca.Text = vaga(0)
            lblDiaEntrada.Text = CType(vaga(1), DateTime).ToShortDateString()
            lblHorarioEntrada.Text = vaga(2).ToString()
        Else
            lblVaga.Text = nome
            lblVaga.BackColor = Color.WhiteSmoke

            dtpDiaEntrada.CustomFormat = "dd/MM/yyyy"
            dtpDiaEntrada.Format = DateTimePickerFormat.Custom
            dtpDiaEntrada.ShowUpDown = True

            dtpHorarioEntrada.CustomFormat = "HH:mm"
            dtpHorarioEntrada.Format = DateTimePickerFormat.Custom
            dtpHorarioEntrada.ShowUpDown = True

            lblPlaca.Visible = False
            lblDiaEntrada.Visible = False
            lblHorarioEntrada.Visible = False
            lblVisualDiaSaida.Visible = False
            lblVisualPontoDiaSaida.Visible = False
            dtpDiaSaida.Visible = False
            lblVisualHorarioSaida.Visible = False
            lblVisualPontoHorarioSaida.Visible = False
            dtpHorarioSaida.Visible = False

            btnRetirar.Visible = False
        End If
        vaga.Close()
    End Sub

    Private Sub frmDetalheVaga_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        fecharForm(Me.Name)
    End Sub

    Private Sub btnVoltar_Click_1(sender As Object, e As EventArgs) Handles btnVoltar.Click
        frmVagas.Show()
    End Sub

    Private Function calculaValorEstacionada()

        Dim inforSis As MySqlDataReader = operaBd("SELECT vlPrimeiraHora, vlHrsExtras, vlDiaria FROM tb_configuracoes;")

        inforSis.Read()

        Dim primeiraHora = inforSis(0)
        Dim demaisHoras = inforSis(1)
        Dim vlDiaria = inforSis(2)

        Dim horaEntrada = lblHorarioEntrada.Text
        Dim diaEntrada = lblDiaEntrada.Text

        Dim horaSaida = dtpHorarioSaida.Text
        Dim diaSaida = dtpDiaSaida.Text

        Dim dateTimeEntrada As Date = Convert.ToDateTime(diaEntrada + " " + horaEntrada)
        Dim dateTimeSaida As Date = Convert.ToDateTime(diaSaida + " " + horaSaida)

        Dim horasEstacionadas = DateDiff(DateInterval.Hour, dateTimeEntrada, dateTimeSaida)

        Dim qtdDias = Convert.ToInt32(horasEstacionadas / 24)

        Dim qtdHoras = horasEstacionadas Mod 24

        Dim valorTotal = (qtdDias * vlDiaria) + ((qtdHoras - 1) * primeiraHora) + primeiraHora

        valorTotal = valorTotal.ToString().Replace(".", ",")
        valorTotal = valorTotal.replace(",", ".")

        Return valorTotal
    End Function

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        operaBd("UPDATE tb_vagas SET dataSaida = '" & converterData(dtpDiaSaida.Text) & "', horaSaida = '" & dtpHorarioSaida.Text & "' WHERE nmrVaga = " & idVaga & " AND dataSaida IS NULL;")
        operaBd("INSERT INTO tb_transacoes (idEstacionada, valorTotal, dataHora) VALUES (" & idEstacionada & ", " & calculaValorEstacionada() & ", '" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "')")
        MessageBox.Show("Carro retirado - Valor R$" & calculaValorEstacionada())
        frmVagas.Show()
    End Sub

    Private Sub btnEstacionar_Click(sender As Object, e As EventArgs) Handles btnEstacionar.Click
        operaBd("INSERT INTO tb_vagas (nmrVaga, idFunc, placaCarro, dataEntrada, horaEntrada) VALUES (" &
                idVaga & ", " &
                usuario.id & ", '" &
                txtPlaca.Text & "', '" &
                converterData(dtpDiaEntrada.Text) & "', '" &
                dtpHorarioEntrada.Text & "');")

        MsgBox("Carro Estacionado")
        frmVagas.Show()
    End Sub
End Class