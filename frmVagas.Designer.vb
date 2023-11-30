<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVagas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVagas))
        Me.panel = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MenuLateral1 = New prjInterdisciplinar.menuLateral()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.AutoScroll = True
        Me.panel.BackColor = System.Drawing.Color.Transparent
        Me.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel.Location = New System.Drawing.Point(119, 71)
        Me.panel.Margin = New System.Windows.Forms.Padding(2)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(683, 348)
        Me.panel.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(392, 20)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 36)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "VAGAS"
        '
        'MenuLateral1
        '
        Me.MenuLateral1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.MenuLateral1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuLateral1.Location = New System.Drawing.Point(0, 0)
        Me.MenuLateral1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MenuLateral1.Name = "MenuLateral1"
        Me.MenuLateral1.Size = New System.Drawing.Size(71, 481)
        Me.MenuLateral1.TabIndex = 26
        '
        'frmVagas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(854, 481)
        Me.Controls.Add(Me.MenuLateral1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmVagas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmVagas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panel As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents MenuLateral1 As menuLateral
End Class
