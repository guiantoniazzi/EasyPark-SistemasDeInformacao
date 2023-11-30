Imports System.Reflection
Imports MySql.Data.MySqlClient
Public Class frmVagas
    Public Sub abreVaga(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)

        frmDetalheVaga.idVaga = CInt(btn.Name.Substring(7))
        frmDetalheVaga.Show()
    End Sub
    Private Sub frmVagas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fecharForm(Me.Name)
        Dim inforsis As MySqlDataReader = operaBd("SELECT * FROM tb_configuracoes")
        Try
            If inforsis.Read = False Then
                MsgBox("Para acessar essa tela, são necessárias configurações")
                frmConfig.Show()
            Else
                Dim posicaoAlt, posicaoLat As Integer

                Dim nmrVagas = inforsis(1)
                Dim largura = 110
                Dim altura = 60

                Dim latInicial = 17.5
                Dim altInicial = 45

                Dim espacamento = 15

                For i = 0 To nmrVagas - 1
                    'Variáveis padrões
                    Dim cor As Color = Color.WhiteSmoke
                    Dim placa As String = ""
                    Dim nome As String = i
                    Dim corHover As Color = Color.Silver
                    Dim fonte As Color = Color.Black

                    Dim infoVaga As MySqlDataReader = operaBd("SELECT idEstacionada, placaCarro FROM tb_vagas WHERE nmrVaga = " & i & " AND dataSaida IS NULL")

                    If infoVaga.Read() = True Then
                        'Variáveis se tiver carro estacionado
                        cor = Color.Red
                        fonte = Color.White
                        corHover = Color.IndianRed
                        placa = Environment.NewLine & infoVaga(1)
                        'nome = infoVaga(0)
                    End If

                    If i Mod 5 = 0 Then
                        If i = 0 Then
                            posicaoAlt = altInicial
                        Else
                            posicaoAlt = posicaoAlt + altura + espacamento
                        End If
                        posicaoLat = latInicial
                    End If
                    Dim btn As New Button
                    With btn
                        .Size = New Size(largura, altura)
                        .Location = New Point(posicaoLat, posicaoAlt)
                        .Text = i + 1 & placa
                        .Name = "btnVaga" & nome
                        .BackColor = cor
                        .FlatStyle = FlatStyle.Flat
                        .FlatAppearance.BorderColor = Color.Black
                        .FlatAppearance.MouseOverBackColor = corHover
                        .Cursor = Cursors.Hand
                        .ForeColor = fonte
                        .Font = New Font("Microsoft Sans Serif", 15)
                        AddHandler .Click, AddressOf abreVaga
                    End With
                    Me.panel.Controls.Add(btn)
                    posicaoLat = posicaoLat + largura + espacamento
                    infoVaga.Close()
                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        inforsis.Close()
    End Sub

    Private Sub panel_Paint(sender As Object, e As PaintEventArgs) Handles panel.Paint

    End Sub
End Class