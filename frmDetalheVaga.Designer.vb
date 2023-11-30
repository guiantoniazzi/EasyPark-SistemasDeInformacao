<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalheVaga
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalheVaga))
        Me.lblVaga = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEstacionar = New System.Windows.Forms.Button()
        Me.lblPlaca = New System.Windows.Forms.Label()
        Me.lblHorarioEntrada = New System.Windows.Forms.Label()
        Me.lblDiaEntrada = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblVisualPontoDiaSaida = New System.Windows.Forms.Label()
        Me.lblVisualDiaSaida = New System.Windows.Forms.Label()
        Me.lblVisualPontoHorarioSaida = New System.Windows.Forms.Label()
        Me.lblVisualHorarioSaida = New System.Windows.Forms.Label()
        Me.btnRetirar = New System.Windows.Forms.Button()
        Me.dtpDiaEntrada = New System.Windows.Forms.DateTimePicker()
        Me.dtpHorarioEntrada = New System.Windows.Forms.DateTimePicker()
        Me.dtpDiaSaida = New System.Windows.Forms.DateTimePicker()
        Me.dtpHorarioSaida = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lblVaga
        '
        Me.lblVaga.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVaga.BackColor = System.Drawing.Color.Transparent
        Me.lblVaga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVaga.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVaga.Location = New System.Drawing.Point(13, 82)
        Me.lblVaga.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVaga.Name = "lblVaga"
        Me.lblVaga.Size = New System.Drawing.Size(124, 116)
        Me.lblVaga.TabIndex = 0
        Me.lblVaga.Text = "VAGA"
        Me.lblVaga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(164, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(395, 26)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Placa do Carro ..............................."
        '
        'txtPlaca
        '
        Me.txtPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaca.Location = New System.Drawing.Point(560, 85)
        Me.txtPlaca.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(208, 26)
        Me.txtPlaca.TabIndex = 16
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.Color.Transparent
        Me.btnVoltar.BackgroundImage = CType(resources.GetObject("btnVoltar.BackgroundImage"), System.Drawing.Image)
        Me.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVoltar.FlatAppearance.BorderSize = 0
        Me.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltar.ForeColor = System.Drawing.Color.Transparent
        Me.btnVoltar.Location = New System.Drawing.Point(9, 9)
        Me.btnVoltar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(48, 50)
        Me.btnVoltar.TabIndex = 19
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(164, 133)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(392, 26)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Dia da entrada ..............................."
        '
        'btnEstacionar
        '
        Me.btnEstacionar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnEstacionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEstacionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnEstacionar.FlatAppearance.BorderSize = 2
        Me.btnEstacionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnEstacionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnEstacionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEstacionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEstacionar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnEstacionar.Location = New System.Drawing.Point(261, 392)
        Me.btnEstacionar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEstacionar.Name = "btnEstacionar"
        Me.btnEstacionar.Size = New System.Drawing.Size(382, 50)
        Me.btnEstacionar.TabIndex = 26
        Me.btnEstacionar.Text = "ESTACIONAR CARRO"
        Me.btnEstacionar.UseVisualStyleBackColor = False
        '
        'lblPlaca
        '
        Me.lblPlaca.AutoSize = True
        Me.lblPlaca.BackColor = System.Drawing.Color.Transparent
        Me.lblPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.lblPlaca.Location = New System.Drawing.Point(555, 82)
        Me.lblPlaca.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPlaca.Name = "lblPlaca"
        Me.lblPlaca.Size = New System.Drawing.Size(171, 26)
        Me.lblPlaca.TabIndex = 27
        Me.lblPlaca.Text = "Placa do Carro"
        '
        'lblHorarioEntrada
        '
        Me.lblHorarioEntrada.AutoSize = True
        Me.lblHorarioEntrada.BackColor = System.Drawing.Color.Transparent
        Me.lblHorarioEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorarioEntrada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.lblHorarioEntrada.Location = New System.Drawing.Point(555, 181)
        Me.lblHorarioEntrada.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHorarioEntrada.Name = "lblHorarioEntrada"
        Me.lblHorarioEntrada.Size = New System.Drawing.Size(171, 26)
        Me.lblHorarioEntrada.TabIndex = 28
        Me.lblHorarioEntrada.Text = "Placa do Carro"
        '
        'lblDiaEntrada
        '
        Me.lblDiaEntrada.AutoSize = True
        Me.lblDiaEntrada.BackColor = System.Drawing.Color.Transparent
        Me.lblDiaEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiaEntrada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.lblDiaEntrada.Location = New System.Drawing.Point(555, 133)
        Me.lblDiaEntrada.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDiaEntrada.Name = "lblDiaEntrada"
        Me.lblDiaEntrada.Size = New System.Drawing.Size(138, 26)
        Me.lblDiaEntrada.TabIndex = 32
        Me.lblDiaEntrada.Text = "Dia Entrada"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(164, 181)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(392, 26)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Horário de entrada ........................."
        '
        'lblVisualPontoDiaSaida
        '
        Me.lblVisualPontoDiaSaida.AutoSize = True
        Me.lblVisualPontoDiaSaida.BackColor = System.Drawing.Color.Transparent
        Me.lblVisualPontoDiaSaida.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisualPontoDiaSaida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.lblVisualPontoDiaSaida.Location = New System.Drawing.Point(330, 245)
        Me.lblVisualPontoDiaSaida.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVisualPontoDiaSaida.Name = "lblVisualPontoDiaSaida"
        Me.lblVisualPontoDiaSaida.Size = New System.Drawing.Size(298, 13)
        Me.lblVisualPontoDiaSaida.TabIndex = 35
        Me.lblVisualPontoDiaSaida.Text = "................................................................................." &
    "................"
        '
        'lblVisualDiaSaida
        '
        Me.lblVisualDiaSaida.AutoSize = True
        Me.lblVisualDiaSaida.BackColor = System.Drawing.Color.Transparent
        Me.lblVisualDiaSaida.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisualDiaSaida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.lblVisualDiaSaida.Location = New System.Drawing.Point(164, 234)
        Me.lblVisualDiaSaida.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVisualDiaSaida.Name = "lblVisualDiaSaida"
        Me.lblVisualDiaSaida.Size = New System.Drawing.Size(145, 26)
        Me.lblVisualDiaSaida.TabIndex = 34
        Me.lblVisualDiaSaida.Text = "Dia da saída"
        '
        'lblVisualPontoHorarioSaida
        '
        Me.lblVisualPontoHorarioSaida.AutoSize = True
        Me.lblVisualPontoHorarioSaida.BackColor = System.Drawing.Color.Transparent
        Me.lblVisualPontoHorarioSaida.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisualPontoHorarioSaida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.lblVisualPontoHorarioSaida.Location = New System.Drawing.Point(370, 289)
        Me.lblVisualPontoHorarioSaida.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVisualPontoHorarioSaida.Name = "lblVisualPontoHorarioSaida"
        Me.lblVisualPontoHorarioSaida.Size = New System.Drawing.Size(244, 13)
        Me.lblVisualPontoHorarioSaida.TabIndex = 38
        Me.lblVisualPontoHorarioSaida.Text = "..............................................................................."
        '
        'lblVisualHorarioSaida
        '
        Me.lblVisualHorarioSaida.AutoSize = True
        Me.lblVisualHorarioSaida.BackColor = System.Drawing.Color.Transparent
        Me.lblVisualHorarioSaida.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisualHorarioSaida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.lblVisualHorarioSaida.Location = New System.Drawing.Point(164, 281)
        Me.lblVisualHorarioSaida.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVisualHorarioSaida.Name = "lblVisualHorarioSaida"
        Me.lblVisualHorarioSaida.Size = New System.Drawing.Size(187, 26)
        Me.lblVisualHorarioSaida.TabIndex = 37
        Me.lblVisualHorarioSaida.Text = "Horário de saída"
        '
        'btnRetirar
        '
        Me.btnRetirar.BackColor = System.Drawing.Color.Transparent
        Me.btnRetirar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRetirar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnRetirar.FlatAppearance.BorderSize = 2
        Me.btnRetirar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnRetirar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnRetirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetirar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetirar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnRetirar.Location = New System.Drawing.Point(261, 392)
        Me.btnRetirar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(382, 50)
        Me.btnRetirar.TabIndex = 40
        Me.btnRetirar.Text = "RETIRAR CARRO"
        Me.btnRetirar.UseVisualStyleBackColor = False
        '
        'dtpDiaEntrada
        '
        Me.dtpDiaEntrada.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDiaEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDiaEntrada.Location = New System.Drawing.Point(560, 132)
        Me.dtpDiaEntrada.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDiaEntrada.Name = "dtpDiaEntrada"
        Me.dtpDiaEntrada.Size = New System.Drawing.Size(210, 26)
        Me.dtpDiaEntrada.TabIndex = 41
        '
        'dtpHorarioEntrada
        '
        Me.dtpHorarioEntrada.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHorarioEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHorarioEntrada.Location = New System.Drawing.Point(558, 183)
        Me.dtpHorarioEntrada.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpHorarioEntrada.Name = "dtpHorarioEntrada"
        Me.dtpHorarioEntrada.Size = New System.Drawing.Size(210, 26)
        Me.dtpHorarioEntrada.TabIndex = 42
        '
        'dtpDiaSaida
        '
        Me.dtpDiaSaida.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDiaSaida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDiaSaida.Location = New System.Drawing.Point(558, 235)
        Me.dtpDiaSaida.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDiaSaida.Name = "dtpDiaSaida"
        Me.dtpDiaSaida.Size = New System.Drawing.Size(210, 26)
        Me.dtpDiaSaida.TabIndex = 43
        '
        'dtpHorarioSaida
        '
        Me.dtpHorarioSaida.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHorarioSaida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHorarioSaida.Location = New System.Drawing.Point(558, 279)
        Me.dtpHorarioSaida.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpHorarioSaida.Name = "dtpHorarioSaida"
        Me.dtpHorarioSaida.Size = New System.Drawing.Size(210, 26)
        Me.dtpHorarioSaida.TabIndex = 44
        '
        'frmDetalheVaga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(854, 481)
        Me.Controls.Add(Me.dtpHorarioSaida)
        Me.Controls.Add(Me.dtpDiaSaida)
        Me.Controls.Add(Me.btnRetirar)
        Me.Controls.Add(Me.lblVisualPontoHorarioSaida)
        Me.Controls.Add(Me.lblVisualHorarioSaida)
        Me.Controls.Add(Me.lblVisualPontoDiaSaida)
        Me.Controls.Add(Me.lblVisualDiaSaida)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblPlaca)
        Me.Controls.Add(Me.btnEstacionar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPlaca)
        Me.Controls.Add(Me.lblVaga)
        Me.Controls.Add(Me.dtpDiaEntrada)
        Me.Controls.Add(Me.dtpHorarioEntrada)
        Me.Controls.Add(Me.lblDiaEntrada)
        Me.Controls.Add(Me.lblHorarioEntrada)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmDetalheVaga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalheVaga"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVaga As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPlaca As TextBox
    Friend WithEvents btnVoltar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEstacionar As Button
    Friend WithEvents lblPlaca As Label
    Friend WithEvents lblHorarioEntrada As Label
    Friend WithEvents lblDiaEntrada As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblVisualPontoDiaSaida As Label
    Friend WithEvents lblVisualDiaSaida As Label
    Friend WithEvents lblVisualPontoHorarioSaida As Label
    Friend WithEvents lblVisualHorarioSaida As Label
    Friend WithEvents btnRetirar As Button
    Friend WithEvents dtpDiaEntrada As DateTimePicker
    Friend WithEvents dtpHorarioEntrada As DateTimePicker
    Friend WithEvents dtpDiaSaida As DateTimePicker
    Friend WithEvents dtpHorarioSaida As DateTimePicker
End Class
