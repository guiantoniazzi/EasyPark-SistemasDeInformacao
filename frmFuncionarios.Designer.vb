<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncionarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFuncionarios))
        Me.MenuLateral1 = New prjInterdisciplinar.menuLateral()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvFuncionarios = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        CType(Me.dgvFuncionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuLateral1
        '
        Me.MenuLateral1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.MenuLateral1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuLateral1.Location = New System.Drawing.Point(0, 0)
        Me.MenuLateral1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MenuLateral1.Name = "MenuLateral1"
        Me.MenuLateral1.Size = New System.Drawing.Size(71, 481)
        Me.MenuLateral1.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(336, 19)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(255, 36)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "FUNCIONÁRIOS"
        '
        'dgvFuncionarios
        '
        Me.dgvFuncionarios.AllowUserToAddRows = False
        Me.dgvFuncionarios.AllowUserToDeleteRows = False
        Me.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFuncionarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.usuario, Me.cpf, Me.cargo, Me.editar})
        Me.dgvFuncionarios.Location = New System.Drawing.Point(126, 83)
        Me.dgvFuncionarios.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvFuncionarios.Name = "dgvFuncionarios"
        Me.dgvFuncionarios.RowHeadersWidth = 51
        Me.dgvFuncionarios.RowTemplate.Height = 24
        Me.dgvFuncionarios.Size = New System.Drawing.Size(681, 262)
        Me.dgvFuncionarios.TabIndex = 29
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.Width = 125
        '
        'usuario
        '
        Me.usuario.HeaderText = "Usuário"
        Me.usuario.MinimumWidth = 6
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        Me.usuario.Width = 125
        '
        'cpf
        '
        Me.cpf.HeaderText = "Cpf"
        Me.cpf.MinimumWidth = 6
        Me.cpf.Name = "cpf"
        Me.cpf.ReadOnly = True
        Me.cpf.Width = 125
        '
        'cargo
        '
        Me.cargo.HeaderText = "Cargo"
        Me.cargo.MinimumWidth = 6
        Me.cargo.Name = "cargo"
        Me.cargo.ReadOnly = True
        Me.cargo.Width = 125
        '
        'editar
        '
        Me.editar.HeaderText = "editar"
        Me.editar.MinimumWidth = 6
        Me.editar.Name = "editar"
        Me.editar.Text = "EDITAR"
        Me.editar.UseColumnTextForButtonValue = True
        Me.editar.Width = 125
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackColor = System.Drawing.Color.Transparent
        Me.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnAdicionar.FlatAppearance.BorderSize = 2
        Me.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnAdicionar.Location = New System.Drawing.Point(278, 377)
        Me.btnAdicionar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(382, 50)
        Me.btnAdicionar.TabIndex = 41
        Me.btnAdicionar.Text = "ADICIONAR FUNCIONÁRIO"
        Me.btnAdicionar.UseVisualStyleBackColor = False
        '
        'frmFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(854, 481)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.dgvFuncionarios)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.MenuLateral1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmFuncionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFuncionarios"
        CType(Me.dgvFuncionarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuLateral1 As menuLateral
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvFuncionarios As DataGridView
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents usuario As DataGridViewTextBoxColumn
    Friend WithEvents cpf As DataGridViewTextBoxColumn
    Friend WithEvents cargo As DataGridViewTextBoxColumn
    Friend WithEvents editar As DataGridViewButtonColumn
End Class
