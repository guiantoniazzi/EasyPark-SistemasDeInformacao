<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuLateral
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuLateral))
        Me.btnCaixa = New System.Windows.Forms.Button()
        Me.btnCadastro = New System.Windows.Forms.Button()
        Me.btnVagas = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCaixa
        '
        Me.btnCaixa.BackgroundImage = CType(resources.GetObject("btnCaixa.BackgroundImage"), System.Drawing.Image)
        Me.btnCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCaixa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCaixa.ForeColor = System.Drawing.Color.Transparent
        Me.btnCaixa.Location = New System.Drawing.Point(15, 161)
        Me.btnCaixa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCaixa.Name = "btnCaixa"
        Me.btnCaixa.Size = New System.Drawing.Size(64, 62)
        Me.btnCaixa.TabIndex = 11
        Me.btnCaixa.UseVisualStyleBackColor = True
        '
        'btnCadastro
        '
        Me.btnCadastro.BackgroundImage = CType(resources.GetObject("btnCadastro.BackgroundImage"), System.Drawing.Image)
        Me.btnCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCadastro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastro.ForeColor = System.Drawing.Color.Transparent
        Me.btnCadastro.Location = New System.Drawing.Point(15, 274)
        Me.btnCadastro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCadastro.Name = "btnCadastro"
        Me.btnCadastro.Size = New System.Drawing.Size(64, 62)
        Me.btnCadastro.TabIndex = 10
        Me.btnCadastro.UseVisualStyleBackColor = True
        '
        'btnVagas
        '
        Me.btnVagas.BackgroundImage = CType(resources.GetObject("btnVagas.BackgroundImage"), System.Drawing.Image)
        Me.btnVagas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVagas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVagas.ForeColor = System.Drawing.Color.Transparent
        Me.btnVagas.Location = New System.Drawing.Point(15, 54)
        Me.btnVagas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnVagas.Name = "btnVagas"
        Me.btnVagas.Size = New System.Drawing.Size(64, 62)
        Me.btnVagas.TabIndex = 9
        Me.btnVagas.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.BackgroundImage = CType(resources.GetObject("btnSair.BackgroundImage"), System.Drawing.Image)
        Me.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.ForeColor = System.Drawing.Color.Transparent
        Me.btnSair.Location = New System.Drawing.Point(15, 510)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(64, 62)
        Me.btnSair.TabIndex = 8
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnConfig
        '
        Me.btnConfig.BackgroundImage = CType(resources.GetObject("btnConfig.BackgroundImage"), System.Drawing.Image)
        Me.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfig.ForeColor = System.Drawing.Color.Transparent
        Me.btnConfig.Location = New System.Drawing.Point(15, 389)
        Me.btnConfig.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(64, 62)
        Me.btnConfig.TabIndex = 7
        Me.btnConfig.UseVisualStyleBackColor = True
        '
        'menuLateral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Controls.Add(Me.btnCaixa)
        Me.Controls.Add(Me.btnCadastro)
        Me.Controls.Add(Me.btnVagas)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnConfig)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "menuLateral"
        Me.Size = New System.Drawing.Size(95, 634)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCaixa As Button
    Friend WithEvents btnCadastro As Button
    Friend WithEvents btnVagas As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents btnConfig As Button
End Class
