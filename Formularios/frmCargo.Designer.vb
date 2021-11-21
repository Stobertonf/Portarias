<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PainelTop = New System.Windows.Forms.Panel()
        Me.txtBusca = New System.Windows.Forms.TextBox()
        Me.Buscar = New System.Windows.Forms.Label()
        Me.rbCargo = New System.Windows.Forms.RadioButton()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.PainelBoth = New System.Windows.Forms.Panel()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.DGViewCargos = New System.Windows.Forms.DataGridView()
        Me.CargoProfissional = New System.Windows.Forms.Label()
        Me.PainelTop.SuspendLayout()
        Me.PainelBoth.SuspendLayout()
        CType(Me.DGViewCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PainelTop
        '
        Me.PainelTop.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PainelTop.BackColor = System.Drawing.Color.GhostWhite
        Me.PainelTop.Controls.Add(Me.txtBusca)
        Me.PainelTop.Controls.Add(Me.Buscar)
        Me.PainelTop.Controls.Add(Me.rbCargo)
        Me.PainelTop.Controls.Add(Me.txtID)
        Me.PainelTop.Location = New System.Drawing.Point(0, 12)
        Me.PainelTop.Name = "PainelTop"
        Me.PainelTop.Size = New System.Drawing.Size(1284, 100)
        Me.PainelTop.TabIndex = 12
        '
        'txtBusca
        '
        Me.txtBusca.Location = New System.Drawing.Point(484, 21)
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(240, 38)
        Me.txtBusca.TabIndex = 2
        '
        'Buscar
        '
        Me.Buscar.AutoSize = True
        Me.Buscar.Location = New System.Drawing.Point(152, 27)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(111, 32)
        Me.Buscar.TabIndex = 9
        Me.Buscar.Text = "Buscar:"
        '
        'rbCargo
        '
        Me.rbCargo.AutoSize = True
        Me.rbCargo.Location = New System.Drawing.Point(308, 24)
        Me.rbCargo.Name = "rbCargo"
        Me.rbCargo.Size = New System.Drawing.Size(129, 36)
        Me.rbCargo.TabIndex = 1
        Me.rbCargo.TabStop = True
        Me.rbCargo.Text = "Cargo"
        Me.rbCargo.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(27, 24)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(60, 38)
        Me.txtID.TabIndex = 0
        '
        'PainelBoth
        '
        Me.PainelBoth.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PainelBoth.BackColor = System.Drawing.Color.GhostWhite
        Me.PainelBoth.Controls.Add(Me.btnDeletar)
        Me.PainelBoth.Controls.Add(Me.btnEditar)
        Me.PainelBoth.Controls.Add(Me.btnSalvar)
        Me.PainelBoth.Controls.Add(Me.btnNovo)
        Me.PainelBoth.Location = New System.Drawing.Point(0, 648)
        Me.PainelBoth.Name = "PainelBoth"
        Me.PainelBoth.Size = New System.Drawing.Size(1284, 172)
        Me.PainelBoth.TabIndex = 15
        '
        'btnDeletar
        '
        Me.btnDeletar.BackgroundImage = Global.Portarias.My.Resources.Resources.btnDeletarUser
        Me.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeletar.Enabled = False
        Me.btnDeletar.FlatAppearance.BorderSize = 0
        Me.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletar.Location = New System.Drawing.Point(815, 3)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(180, 149)
        Me.btnDeletar.TabIndex = 7
        Me.btnDeletar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = Global.Portarias.My.Resources.Resources.btnEditar
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Enabled = False
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Location = New System.Drawing.Point(610, 3)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(170, 149)
        Me.btnEditar.TabIndex = 6
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.Portarias.My.Resources.Resources.btnSalvar
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.Enabled = False
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Location = New System.Drawing.Point(401, 2)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(166, 149)
        Me.btnSalvar.TabIndex = 5
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.BackgroundImage = Global.Portarias.My.Resources.Resources.btnNovo
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Location = New System.Drawing.Point(191, 0)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(174, 152)
        Me.btnNovo.TabIndex = 4
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(279, 176)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(788, 38)
        Me.txtCargo.TabIndex = 3
        '
        'DGViewCargos
        '
        Me.DGViewCargos.AllowUserToAddRows = False
        Me.DGViewCargos.AllowUserToDeleteRows = False
        Me.DGViewCargos.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.DGViewCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGViewCargos.Location = New System.Drawing.Point(158, 290)
        Me.DGViewCargos.Name = "DGViewCargos"
        Me.DGViewCargos.ReadOnly = True
        Me.DGViewCargos.RowTemplate.Height = 40
        Me.DGViewCargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGViewCargos.Size = New System.Drawing.Size(909, 245)
        Me.DGViewCargos.TabIndex = 14
        '
        'CargoProfissional
        '
        Me.CargoProfissional.AutoSize = True
        Me.CargoProfissional.Location = New System.Drawing.Point(152, 182)
        Me.CargoProfissional.Name = "CargoProfissional"
        Me.CargoProfissional.Size = New System.Drawing.Size(100, 32)
        Me.CargoProfissional.TabIndex = 16
        Me.CargoProfissional.Text = "Cargo:"
        '
        'frmCargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1282, 865)
        Me.Controls.Add(Me.CargoProfissional)
        Me.Controls.Add(Me.PainelBoth)
        Me.Controls.Add(Me.DGViewCargos)
        Me.Controls.Add(Me.txtCargo)
        Me.Controls.Add(Me.PainelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCargo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Cargo"
        Me.PainelTop.ResumeLayout(False)
        Me.PainelTop.PerformLayout()
        Me.PainelBoth.ResumeLayout(False)
        CType(Me.DGViewCargos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PainelTop As Panel
    Friend WithEvents Buscar As Label
    Friend WithEvents rbCargo As RadioButton
    Friend WithEvents txtID As TextBox
    Friend WithEvents PainelBoth As Panel
    Friend WithEvents btnDeletar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents txtBusca As TextBox
    Friend WithEvents txtCargo As TextBox
    Friend WithEvents DGViewCargos As DataGridView
    Friend WithEvents CargoProfissional As Label
End Class
