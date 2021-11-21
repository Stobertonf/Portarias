<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncionarios
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
        Me.Condominio = New System.Windows.Forms.Label()
        Me.CPF = New System.Windows.Forms.Label()
        Me.PainelBoth = New System.Windows.Forms.Panel()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.txtCondominio = New System.Windows.Forms.TextBox()
        Me.PainelTop = New System.Windows.Forms.Panel()
        Me.txtBuscaCPF = New System.Windows.Forms.MaskedTextBox()
        Me.Buscar = New System.Windows.Forms.Label()
        Me.rbCPF = New System.Windows.Forms.RadioButton()
        Me.rbNome = New System.Windows.Forms.RadioButton()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtBuscaNome = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.Telefone = New System.Windows.Forms.Label()
        Me.Cargo = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.txtRG = New System.Windows.Forms.MaskedTextBox()
        Me.Celular = New System.Windows.Forms.Label()
        Me.RG = New System.Windows.Forms.Label()
        Me.DGViewFuncionarios = New System.Windows.Forms.DataGridView()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.Nome = New System.Windows.Forms.Label()
        Me.Endereco = New System.Windows.Forms.Label()
        Me.txtCargo = New System.Windows.Forms.ComboBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtCracha = New System.Windows.Forms.Label()
        Me.PainelBoth.SuspendLayout()
        Me.PainelTop.SuspendLayout()
        CType(Me.DGViewFuncionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Condominio
        '
        Me.Condominio.AutoSize = True
        Me.Condominio.Location = New System.Drawing.Point(61, 365)
        Me.Condominio.Name = "Condominio"
        Me.Condominio.Size = New System.Drawing.Size(176, 32)
        Me.Condominio.TabIndex = 61
        Me.Condominio.Text = "Condomínio:"
        '
        'CPF
        '
        Me.CPF.AutoSize = True
        Me.CPF.BackColor = System.Drawing.Color.Transparent
        Me.CPF.Location = New System.Drawing.Point(827, 150)
        Me.CPF.Name = "CPF"
        Me.CPF.Size = New System.Drawing.Size(79, 32)
        Me.CPF.TabIndex = 51
        Me.CPF.Text = "CPF:"
        '
        'PainelBoth
        '
        Me.PainelBoth.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PainelBoth.BackColor = System.Drawing.Color.GhostWhite
        Me.PainelBoth.Controls.Add(Me.btnDeletar)
        Me.PainelBoth.Controls.Add(Me.btnEditar)
        Me.PainelBoth.Controls.Add(Me.btnSalvar)
        Me.PainelBoth.Controls.Add(Me.btnNovo)
        Me.PainelBoth.Location = New System.Drawing.Point(-5, 690)
        Me.PainelBoth.Name = "PainelBoth"
        Me.PainelBoth.Size = New System.Drawing.Size(1304, 214)
        Me.PainelBoth.TabIndex = 45
        '
        'btnDeletar
        '
        Me.btnDeletar.BackgroundImage = Global.Portarias.My.Resources.Resources.btnDeletarUser
        Me.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeletar.Enabled = False
        Me.btnDeletar.FlatAppearance.BorderSize = 0
        Me.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletar.Location = New System.Drawing.Point(914, 4)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(180, 149)
        Me.btnDeletar.TabIndex = 12
        Me.btnDeletar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = Global.Portarias.My.Resources.Resources.btnEditar
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Enabled = False
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Location = New System.Drawing.Point(709, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(170, 149)
        Me.btnEditar.TabIndex = 11
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.Portarias.My.Resources.Resources.btnSalvar
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.Enabled = False
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Location = New System.Drawing.Point(500, 3)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(166, 149)
        Me.btnSalvar.TabIndex = 10
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.BackgroundImage = Global.Portarias.My.Resources.Resources.btnNovo
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Location = New System.Drawing.Point(290, 1)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(174, 152)
        Me.btnNovo.TabIndex = 9
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'txtCondominio
        '
        Me.txtCondominio.Location = New System.Drawing.Point(279, 362)
        Me.txtCondominio.Name = "txtCondominio"
        Me.txtCondominio.Size = New System.Drawing.Size(894, 38)
        Me.txtCondominio.TabIndex = 60
        '
        'PainelTop
        '
        Me.PainelTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PainelTop.BackColor = System.Drawing.Color.GhostWhite
        Me.PainelTop.Controls.Add(Me.txtBuscaCPF)
        Me.PainelTop.Controls.Add(Me.Buscar)
        Me.PainelTop.Controls.Add(Me.rbCPF)
        Me.PainelTop.Controls.Add(Me.rbNome)
        Me.PainelTop.Controls.Add(Me.txtID)
        Me.PainelTop.Controls.Add(Me.txtBuscaNome)
        Me.PainelTop.Location = New System.Drawing.Point(-5, 12)
        Me.PainelTop.Name = "PainelTop"
        Me.PainelTop.Size = New System.Drawing.Size(1304, 100)
        Me.PainelTop.TabIndex = 46
        '
        'txtBuscaCPF
        '
        Me.txtBuscaCPF.Location = New System.Drawing.Point(780, 26)
        Me.txtBuscaCPF.Mask = "000.000.000-00"
        Me.txtBuscaCPF.Name = "txtBuscaCPF"
        Me.txtBuscaCPF.Size = New System.Drawing.Size(240, 38)
        Me.txtBuscaCPF.TabIndex = 3
        '
        'Buscar
        '
        Me.Buscar.AutoSize = True
        Me.Buscar.Location = New System.Drawing.Point(303, 30)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(111, 32)
        Me.Buscar.TabIndex = 9
        Me.Buscar.Text = "Buscar:"
        '
        'rbCPF
        '
        Me.rbCPF.AutoSize = True
        Me.rbCPF.Location = New System.Drawing.Point(653, 27)
        Me.rbCPF.Name = "rbCPF"
        Me.rbCPF.Size = New System.Drawing.Size(108, 36)
        Me.rbCPF.TabIndex = 2
        Me.rbCPF.TabStop = True
        Me.rbCPF.Text = "CPF"
        Me.rbCPF.UseVisualStyleBackColor = True
        '
        'rbNome
        '
        Me.rbNome.AutoSize = True
        Me.rbNome.Location = New System.Drawing.Point(472, 26)
        Me.rbNome.Name = "rbNome"
        Me.rbNome.Size = New System.Drawing.Size(127, 36)
        Me.rbNome.TabIndex = 1
        Me.rbNome.TabStop = True
        Me.rbNome.Text = "Nome"
        Me.rbNome.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(27, 24)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(60, 38)
        Me.txtID.TabIndex = 0
        '
        'txtBuscaNome
        '
        Me.txtBuscaNome.Location = New System.Drawing.Point(780, 27)
        Me.txtBuscaNome.Name = "txtBuscaNome"
        Me.txtBuscaNome.Size = New System.Drawing.Size(240, 38)
        Me.txtBuscaNome.TabIndex = 0
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(179, 144)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(226, 38)
        Me.txtNome.TabIndex = 48
        '
        'txtTelefone
        '
        Me.txtTelefone.Enabled = False
        Me.txtTelefone.Location = New System.Drawing.Point(213, 218)
        Me.txtTelefone.Mask = "(99) 9999-9999"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(211, 38)
        Me.txtTelefone.TabIndex = 53
        '
        'Telefone
        '
        Me.Telefone.AutoSize = True
        Me.Telefone.BackColor = System.Drawing.Color.Transparent
        Me.Telefone.Location = New System.Drawing.Point(61, 224)
        Me.Telefone.Name = "Telefone"
        Me.Telefone.Size = New System.Drawing.Size(135, 32)
        Me.Telefone.TabIndex = 49
        Me.Telefone.Text = "Telefone:"
        '
        'Cargo
        '
        Me.Cargo.AutoSize = True
        Me.Cargo.Location = New System.Drawing.Point(698, 302)
        Me.Cargo.Name = "Cargo"
        Me.Cargo.Size = New System.Drawing.Size(100, 32)
        Me.Cargo.TabIndex = 59
        Me.Cargo.Text = "Cargo:"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(582, 218)
        Me.txtCelular.Mask = "(99) 9 9999-9999"
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(219, 38)
        Me.txtCelular.TabIndex = 54
        '
        'txtRG
        '
        Me.txtRG.Location = New System.Drawing.Point(561, 144)
        Me.txtRG.Mask = "99.999.999-9"
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(226, 38)
        Me.txtRG.TabIndex = 50
        '
        'Celular
        '
        Me.Celular.AutoSize = True
        Me.Celular.Location = New System.Drawing.Point(453, 222)
        Me.Celular.Name = "Celular"
        Me.Celular.Size = New System.Drawing.Size(114, 32)
        Me.Celular.TabIndex = 57
        Me.Celular.Text = "Celular:"
        '
        'RG
        '
        Me.RG.AutoSize = True
        Me.RG.Location = New System.Drawing.Point(434, 150)
        Me.RG.Name = "RG"
        Me.RG.Size = New System.Drawing.Size(65, 32)
        Me.RG.TabIndex = 56
        Me.RG.Text = "RG:"
        '
        'DGViewFuncionarios
        '
        Me.DGViewFuncionarios.AllowUserToAddRows = False
        Me.DGViewFuncionarios.AllowUserToDeleteRows = False
        Me.DGViewFuncionarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGViewFuncionarios.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.DGViewFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGViewFuncionarios.Location = New System.Drawing.Point(67, 455)
        Me.DGViewFuncionarios.Name = "DGViewFuncionarios"
        Me.DGViewFuncionarios.ReadOnly = True
        Me.DGViewFuncionarios.RowTemplate.Height = 40
        Me.DGViewFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGViewFuncionarios.Size = New System.Drawing.Size(1106, 163)
        Me.DGViewFuncionarios.TabIndex = 55
        '
        'txtCPF
        '
        Me.txtCPF.Enabled = False
        Me.txtCPF.Location = New System.Drawing.Point(926, 144)
        Me.txtCPF.Mask = "999.999.999-99"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(247, 38)
        Me.txtCPF.TabIndex = 52
        '
        'Nome
        '
        Me.Nome.AutoSize = True
        Me.Nome.BackColor = System.Drawing.Color.Transparent
        Me.Nome.Location = New System.Drawing.Point(61, 147)
        Me.Nome.Name = "Nome"
        Me.Nome.Size = New System.Drawing.Size(98, 32)
        Me.Nome.TabIndex = 47
        Me.Nome.Text = "Nome:"
        '
        'Endereco
        '
        Me.Endereco.AutoSize = True
        Me.Endereco.Location = New System.Drawing.Point(61, 302)
        Me.Endereco.Name = "Endereco"
        Me.Endereco.Size = New System.Drawing.Size(145, 32)
        Me.Endereco.TabIndex = 62
        Me.Endereco.Text = "Endereço:"
        '
        'txtCargo
        '
        Me.txtCargo.FormattingEnabled = True
        Me.txtCargo.Items.AddRange(New Object() {"Faxineiro", "Jardineiro", "Manobrista", "Segurança", "Síndico", "Zelador"})
        Me.txtCargo.Location = New System.Drawing.Point(881, 299)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(292, 39)
        Me.txtCargo.TabIndex = 63
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(224, 295)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(370, 38)
        Me.txtEndereco.TabIndex = 64
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(966, 218)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 38)
        Me.TextBox1.TabIndex = 65
        '
        'txtCracha
        '
        Me.txtCracha.AutoSize = True
        Me.txtCracha.Location = New System.Drawing.Point(833, 221)
        Me.txtCracha.Name = "txtCracha"
        Me.txtCracha.Size = New System.Drawing.Size(114, 32)
        Me.txtCracha.TabIndex = 66
        Me.txtCracha.Text = "Crachá:"
        '
        'frmFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1299, 1083)
        Me.Controls.Add(Me.txtCracha)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.txtCargo)
        Me.Controls.Add(Me.Endereco)
        Me.Controls.Add(Me.Condominio)
        Me.Controls.Add(Me.CPF)
        Me.Controls.Add(Me.PainelBoth)
        Me.Controls.Add(Me.txtCondominio)
        Me.Controls.Add(Me.PainelTop)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.Telefone)
        Me.Controls.Add(Me.Cargo)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.txtRG)
        Me.Controls.Add(Me.Celular)
        Me.Controls.Add(Me.RG)
        Me.Controls.Add(Me.DGViewFuncionarios)
        Me.Controls.Add(Me.txtCPF)
        Me.Controls.Add(Me.Nome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmFuncionarios"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Funcionários"
        Me.PainelBoth.ResumeLayout(False)
        Me.PainelTop.ResumeLayout(False)
        Me.PainelTop.PerformLayout()
        CType(Me.DGViewFuncionarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Condominio As Label
    Friend WithEvents CPF As Label
    Friend WithEvents PainelBoth As Panel
    Friend WithEvents btnDeletar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents txtCondominio As TextBox
    Friend WithEvents PainelTop As Panel
    Friend WithEvents txtBuscaCPF As MaskedTextBox
    Friend WithEvents Buscar As Label
    Friend WithEvents rbCPF As RadioButton
    Friend WithEvents rbNome As RadioButton
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtBuscaNome As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtTelefone As MaskedTextBox
    Friend WithEvents Telefone As Label
    Friend WithEvents Cargo As Label
    Friend WithEvents txtCelular As MaskedTextBox
    Friend WithEvents txtRG As MaskedTextBox
    Friend WithEvents Celular As Label
    Friend WithEvents RG As Label
    Friend WithEvents DGViewFuncionarios As DataGridView
    Friend WithEvents txtCPF As MaskedTextBox
    Friend WithEvents Nome As Label
    Friend WithEvents Endereco As Label
    Friend WithEvents txtCargo As ComboBox
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtCracha As Label
End Class
