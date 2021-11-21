<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPorteiros
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PainelBoth = New System.Windows.Forms.Panel()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.PainelTop = New System.Windows.Forms.Panel()
        Me.txtBuscaCPF = New System.Windows.Forms.MaskedTextBox()
        Me.Buscar = New System.Windows.Forms.Label()
        Me.rbCPF = New System.Windows.Forms.RadioButton()
        Me.rbNome = New System.Windows.Forms.RadioButton()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtBuscaNome = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Nome = New System.Windows.Forms.Label()
        Me.Telefone = New System.Windows.Forms.Label()
        Me.CPF = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.DGViewPorteiros = New System.Windows.Forms.DataGridView()
        Me.Senha = New System.Windows.Forms.Label()
        Me.Usuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.RG = New System.Windows.Forms.Label()
        Me.Celular = New System.Windows.Forms.Label()
        Me.txtRG = New System.Windows.Forms.MaskedTextBox()
        Me.txtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.Nascimento = New System.Windows.Forms.Label()
        Me.txtNascimento = New System.Windows.Forms.MaskedTextBox()
        Me.Endereco = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Condominio = New System.Windows.Forms.Label()
        Me.txtCondominio = New System.Windows.Forms.TextBox()
        Me.PainelBoth.SuspendLayout()
        Me.PainelTop.SuspendLayout()
        CType(Me.DGViewPorteiros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PainelBoth
        '
        Me.PainelBoth.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PainelBoth.BackColor = System.Drawing.Color.GhostWhite
        Me.PainelBoth.Controls.Add(Me.btnDeletar)
        Me.PainelBoth.Controls.Add(Me.btnEditar)
        Me.PainelBoth.Controls.Add(Me.btnSalvar)
        Me.PainelBoth.Controls.Add(Me.btnNovo)
        Me.PainelBoth.Location = New System.Drawing.Point(1, 725)
        Me.PainelBoth.Name = "PainelBoth"
        Me.PainelBoth.Size = New System.Drawing.Size(1349, 193)
        Me.PainelBoth.TabIndex = 0
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
        Me.btnDeletar.TabIndex = 16
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
        Me.btnEditar.TabIndex = 15
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
        Me.btnSalvar.TabIndex = 14
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
        Me.btnNovo.TabIndex = 13
        Me.btnNovo.UseVisualStyleBackColor = True
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
        Me.PainelTop.Location = New System.Drawing.Point(-8, 13)
        Me.PainelTop.Name = "PainelTop"
        Me.PainelTop.Size = New System.Drawing.Size(1349, 100)
        Me.PainelTop.TabIndex = 1
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
        Me.txtNome.Location = New System.Drawing.Point(187, 141)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(226, 38)
        Me.txtNome.TabIndex = 4
        '
        'Nome
        '
        Me.Nome.AutoSize = True
        Me.Nome.BackColor = System.Drawing.Color.Transparent
        Me.Nome.Location = New System.Drawing.Point(50, 147)
        Me.Nome.Name = "Nome"
        Me.Nome.Size = New System.Drawing.Size(98, 32)
        Me.Nome.TabIndex = 3
        Me.Nome.Text = "Nome:"
        '
        'Telefone
        '
        Me.Telefone.AutoSize = True
        Me.Telefone.BackColor = System.Drawing.Color.Transparent
        Me.Telefone.Location = New System.Drawing.Point(50, 221)
        Me.Telefone.Name = "Telefone"
        Me.Telefone.Size = New System.Drawing.Size(135, 32)
        Me.Telefone.TabIndex = 4
        Me.Telefone.Text = "Telefone:"
        '
        'CPF
        '
        Me.CPF.AutoSize = True
        Me.CPF.BackColor = System.Drawing.Color.Transparent
        Me.CPF.Location = New System.Drawing.Point(855, 147)
        Me.CPF.Name = "CPF"
        Me.CPF.Size = New System.Drawing.Size(79, 32)
        Me.CPF.TabIndex = 5
        Me.CPF.Text = "CPF:"
        '
        'txtTelefone
        '
        Me.txtTelefone.Enabled = False
        Me.txtTelefone.Location = New System.Drawing.Point(202, 217)
        Me.txtTelefone.Mask = "(99) 9999-9999"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(211, 38)
        Me.txtTelefone.TabIndex = 7
        '
        'txtCPF
        '
        Me.txtCPF.Enabled = False
        Me.txtCPF.Location = New System.Drawing.Point(944, 141)
        Me.txtCPF.Mask = "999.999.999-99"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(215, 38)
        Me.txtCPF.TabIndex = 6
        '
        'DGViewPorteiros
        '
        Me.DGViewPorteiros.AllowUserToAddRows = False
        Me.DGViewPorteiros.AllowUserToDeleteRows = False
        Me.DGViewPorteiros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGViewPorteiros.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.DGViewPorteiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGViewPorteiros.Location = New System.Drawing.Point(56, 438)
        Me.DGViewPorteiros.Name = "DGViewPorteiros"
        Me.DGViewPorteiros.ReadOnly = True
        Me.DGViewPorteiros.RowTemplate.Height = 40
        Me.DGViewPorteiros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGViewPorteiros.Size = New System.Drawing.Size(1093, 245)
        Me.DGViewPorteiros.TabIndex = 17
        '
        'Senha
        '
        Me.Senha.AutoSize = True
        Me.Senha.BackColor = System.Drawing.Color.Transparent
        Me.Senha.Location = New System.Drawing.Point(842, 294)
        Me.Senha.Name = "Senha"
        Me.Senha.Size = New System.Drawing.Size(106, 32)
        Me.Senha.TabIndex = 9
        Me.Senha.Text = "Senha:"
        '
        'Usuario
        '
        Me.Usuario.AutoSize = True
        Me.Usuario.BackColor = System.Drawing.Color.Transparent
        Me.Usuario.Location = New System.Drawing.Point(445, 294)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(121, 32)
        Me.Usuario.TabIndex = 10
        Me.Usuario.Text = "Usuario:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(572, 291)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(226, 38)
        Me.txtUsuario.TabIndex = 11
        '
        'txtSenha
        '
        Me.txtSenha.Enabled = False
        Me.txtSenha.Location = New System.Drawing.Point(964, 294)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(195, 38)
        Me.txtSenha.TabIndex = 12
        '
        'RG
        '
        Me.RG.AutoSize = True
        Me.RG.Location = New System.Drawing.Point(452, 147)
        Me.RG.Name = "RG"
        Me.RG.Size = New System.Drawing.Size(65, 32)
        Me.RG.TabIndex = 11
        Me.RG.Text = "RG:"
        '
        'Celular
        '
        Me.Celular.AutoSize = True
        Me.Celular.Location = New System.Drawing.Point(452, 221)
        Me.Celular.Name = "Celular"
        Me.Celular.Size = New System.Drawing.Size(114, 32)
        Me.Celular.TabIndex = 12
        Me.Celular.Text = "Celular:"
        '
        'txtRG
        '
        Me.txtRG.Location = New System.Drawing.Point(579, 141)
        Me.txtRG.Mask = "99.999.999-9"
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(226, 38)
        Me.txtRG.TabIndex = 5
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(586, 221)
        Me.txtCelular.Mask = "(99) 9 9999-9999"
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(219, 38)
        Me.txtCelular.TabIndex = 8
        '
        'Nascimento
        '
        Me.Nascimento.AutoSize = True
        Me.Nascimento.Location = New System.Drawing.Point(842, 221)
        Me.Nascimento.Name = "Nascimento"
        Me.Nascimento.Size = New System.Drawing.Size(165, 32)
        Me.Nascimento.TabIndex = 15
        Me.Nascimento.Text = "Nascimento"
        '
        'txtNascimento
        '
        Me.txtNascimento.Location = New System.Drawing.Point(1026, 221)
        Me.txtNascimento.Mask = "00/00/0000"
        Me.txtNascimento.Name = "txtNascimento"
        Me.txtNascimento.Size = New System.Drawing.Size(133, 38)
        Me.txtNascimento.TabIndex = 9
        Me.txtNascimento.ValidatingType = GetType(Date)
        '
        'Endereco
        '
        Me.Endereco.AutoSize = True
        Me.Endereco.Location = New System.Drawing.Point(50, 297)
        Me.Endereco.Name = "Endereco"
        Me.Endereco.Size = New System.Drawing.Size(145, 32)
        Me.Endereco.TabIndex = 17
        Me.Endereco.Text = "Endereço:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(209, 291)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(197, 38)
        Me.txtEndereco.TabIndex = 10
        '
        'Condominio
        '
        Me.Condominio.AutoSize = True
        Me.Condominio.Location = New System.Drawing.Point(50, 362)
        Me.Condominio.Name = "Condominio"
        Me.Condominio.Size = New System.Drawing.Size(176, 32)
        Me.Condominio.TabIndex = 19
        Me.Condominio.Text = "Condomínio:"
        '
        'txtCondominio
        '
        Me.txtCondominio.Location = New System.Drawing.Point(268, 359)
        Me.txtCondominio.Name = "txtCondominio"
        Me.txtCondominio.Size = New System.Drawing.Size(891, 38)
        Me.txtCondominio.TabIndex = 13
        '
        'frmPorteiros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1342, 946)
        Me.Controls.Add(Me.txtCondominio)
        Me.Controls.Add(Me.Condominio)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.Endereco)
        Me.Controls.Add(Me.txtNascimento)
        Me.Controls.Add(Me.Nascimento)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.txtRG)
        Me.Controls.Add(Me.Celular)
        Me.Controls.Add(Me.RG)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.Senha)
        Me.Controls.Add(Me.DGViewPorteiros)
        Me.Controls.Add(Me.txtCPF)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.CPF)
        Me.Controls.Add(Me.Telefone)
        Me.Controls.Add(Me.Nome)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.PainelTop)
        Me.Controls.Add(Me.PainelBoth)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPorteiros"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Porteiros"
        Me.PainelBoth.ResumeLayout(False)
        Me.PainelTop.ResumeLayout(False)
        Me.PainelTop.PerformLayout()
        CType(Me.DGViewPorteiros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PainelBoth As Panel
    Friend WithEvents PainelTop As Panel
    Friend WithEvents txtBuscaNome As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Nome As Label
    Friend WithEvents Telefone As Label
    Friend WithEvents CPF As Label
    Friend WithEvents txtTelefone As MaskedTextBox
    Friend WithEvents txtCPF As MaskedTextBox
    Friend WithEvents DGViewPorteiros As DataGridView
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnDeletar As Button
    Friend WithEvents Senha As Label
    Friend WithEvents Usuario As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents rbCPF As RadioButton
    Friend WithEvents rbNome As RadioButton
    Friend WithEvents Buscar As Label
    Friend WithEvents txtBuscaCPF As MaskedTextBox
    Friend WithEvents RG As Label
    Friend WithEvents Celular As Label
    Friend WithEvents txtRG As MaskedTextBox
    Friend WithEvents txtCelular As MaskedTextBox
    Friend WithEvents Nascimento As Label
    Friend WithEvents txtNascimento As MaskedTextBox
    Friend WithEvents Endereco As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Condominio As Label
    Friend WithEvents txtCondominio As TextBox
End Class
