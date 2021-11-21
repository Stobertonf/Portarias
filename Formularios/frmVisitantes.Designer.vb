<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisitantes
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
        Me.txtCargoID = New System.Windows.Forms.TextBox()
        Me.Ocupacao = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.txtRG = New System.Windows.Forms.MaskedTextBox()
        Me.Celular = New System.Windows.Forms.Label()
        Me.RG = New System.Windows.Forms.Label()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.Telefone = New System.Windows.Forms.Label()
        Me.Nome = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtBuscaCPF = New System.Windows.Forms.MaskedTextBox()
        Me.Buscar = New System.Windows.Forms.Label()
        Me.rbCPF = New System.Windows.Forms.RadioButton()
        Me.rbNome = New System.Windows.Forms.RadioButton()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtBuscaNome = New System.Windows.Forms.TextBox()
        Me.PainelTop = New System.Windows.Forms.Panel()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.CPF = New System.Windows.Forms.Label()
        Me.PainelBoth = New System.Windows.Forms.Panel()
        Me.txtCondominio = New System.Windows.Forms.TextBox()
        Me.Condominio = New System.Windows.Forms.Label()
        Me.DGViewVisitantes = New System.Windows.Forms.DataGridView()
        Me.btnImagem = New System.Windows.Forms.Button()
        Me.txtImagem = New System.Windows.Forms.PictureBox()
        Me.PainelTop.SuspendLayout()
        Me.PainelBoth.SuspendLayout()
        CType(Me.DGViewVisitantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCargoID
        '
        Me.txtCargoID.Location = New System.Drawing.Point(268, 290)
        Me.txtCargoID.Name = "txtCargoID"
        Me.txtCargoID.Size = New System.Drawing.Size(527, 38)
        Me.txtCargoID.TabIndex = 39
        '
        'Ocupacao
        '
        Me.Ocupacao.AutoSize = True
        Me.Ocupacao.Location = New System.Drawing.Point(50, 296)
        Me.Ocupacao.Name = "Ocupacao"
        Me.Ocupacao.Size = New System.Drawing.Size(100, 32)
        Me.Ocupacao.TabIndex = 42
        Me.Ocupacao.Text = "Cargo:"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(576, 222)
        Me.txtCelular.Mask = "(99) 9 9999-9999"
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(219, 38)
        Me.txtCelular.TabIndex = 29
        '
        'txtRG
        '
        Me.txtRG.Location = New System.Drawing.Point(550, 144)
        Me.txtRG.Mask = "99.99.999-9"
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(226, 38)
        Me.txtRG.TabIndex = 25
        '
        'Celular
        '
        Me.Celular.AutoSize = True
        Me.Celular.Location = New System.Drawing.Point(442, 222)
        Me.Celular.Name = "Celular"
        Me.Celular.Size = New System.Drawing.Size(114, 32)
        Me.Celular.TabIndex = 37
        Me.Celular.Text = "Celular:"
        '
        'RG
        '
        Me.RG.AutoSize = True
        Me.RG.Location = New System.Drawing.Point(423, 150)
        Me.RG.Name = "RG"
        Me.RG.Size = New System.Drawing.Size(65, 32)
        Me.RG.TabIndex = 36
        Me.RG.Text = "RG:"
        '
        'txtCPF
        '
        Me.txtCPF.Enabled = False
        Me.txtCPF.Location = New System.Drawing.Point(915, 144)
        Me.txtCPF.Mask = "999.999.999-99"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(215, 38)
        Me.txtCPF.TabIndex = 27
        '
        'txtTelefone
        '
        Me.txtTelefone.Enabled = False
        Me.txtTelefone.Location = New System.Drawing.Point(202, 218)
        Me.txtTelefone.Mask = "(99) 9999-9999"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(211, 38)
        Me.txtTelefone.TabIndex = 28
        '
        'Telefone
        '
        Me.Telefone.AutoSize = True
        Me.Telefone.BackColor = System.Drawing.Color.Transparent
        Me.Telefone.Location = New System.Drawing.Point(50, 222)
        Me.Telefone.Name = "Telefone"
        Me.Telefone.Size = New System.Drawing.Size(135, 32)
        Me.Telefone.TabIndex = 24
        Me.Telefone.Text = "Telefone:"
        '
        'Nome
        '
        Me.Nome.AutoSize = True
        Me.Nome.BackColor = System.Drawing.Color.Transparent
        Me.Nome.Location = New System.Drawing.Point(50, 147)
        Me.Nome.Name = "Nome"
        Me.Nome.Size = New System.Drawing.Size(98, 32)
        Me.Nome.TabIndex = 22
        Me.Nome.Text = "Nome:"
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(168, 144)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(226, 38)
        Me.txtNome.TabIndex = 23
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
        Me.PainelTop.Location = New System.Drawing.Point(1, 12)
        Me.PainelTop.Name = "PainelTop"
        Me.PainelTop.Size = New System.Drawing.Size(1338, 100)
        Me.PainelTop.TabIndex = 21
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
        'CPF
        '
        Me.CPF.AutoSize = True
        Me.CPF.BackColor = System.Drawing.Color.Transparent
        Me.CPF.Location = New System.Drawing.Point(816, 150)
        Me.CPF.Name = "CPF"
        Me.CPF.Size = New System.Drawing.Size(79, 32)
        Me.CPF.TabIndex = 26
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
        Me.PainelBoth.Location = New System.Drawing.Point(1, 711)
        Me.PainelBoth.Name = "PainelBoth"
        Me.PainelBoth.Size = New System.Drawing.Size(1338, 214)
        Me.PainelBoth.TabIndex = 20
        '
        'txtCondominio
        '
        Me.txtCondominio.Location = New System.Drawing.Point(268, 362)
        Me.txtCondominio.Name = "txtCondominio"
        Me.txtCondominio.Size = New System.Drawing.Size(527, 38)
        Me.txtCondominio.TabIndex = 43
        '
        'Condominio
        '
        Me.Condominio.AutoSize = True
        Me.Condominio.Location = New System.Drawing.Point(50, 365)
        Me.Condominio.Name = "Condominio"
        Me.Condominio.Size = New System.Drawing.Size(176, 32)
        Me.Condominio.TabIndex = 44
        Me.Condominio.Text = "Condomínio:"
        '
        'DGViewVisitantes
        '
        Me.DGViewVisitantes.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.DGViewVisitantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGViewVisitantes.Location = New System.Drawing.Point(56, 465)
        Me.DGViewVisitantes.Name = "DGViewVisitantes"
        Me.DGViewVisitantes.RowTemplate.Height = 40
        Me.DGViewVisitantes.Size = New System.Drawing.Size(1141, 196)
        Me.DGViewVisitantes.TabIndex = 45
        '
        'btnImagem
        '
        Me.btnImagem.Location = New System.Drawing.Point(822, 222)
        Me.btnImagem.Name = "btnImagem"
        Me.btnImagem.Size = New System.Drawing.Size(161, 65)
        Me.btnImagem.TabIndex = 46
        Me.btnImagem.Text = "Imagem:"
        Me.btnImagem.UseVisualStyleBackColor = True
        '
        'txtImagem
        '
        Me.txtImagem.Location = New System.Drawing.Point(1014, 222)
        Me.txtImagem.Name = "txtImagem"
        Me.txtImagem.Size = New System.Drawing.Size(183, 178)
        Me.txtImagem.TabIndex = 47
        Me.txtImagem.TabStop = False
        '
        'frmVisitantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1342, 1092)
        Me.Controls.Add(Me.txtImagem)
        Me.Controls.Add(Me.btnImagem)
        Me.Controls.Add(Me.DGViewVisitantes)
        Me.Controls.Add(Me.Condominio)
        Me.Controls.Add(Me.txtCondominio)
        Me.Controls.Add(Me.txtCargoID)
        Me.Controls.Add(Me.Ocupacao)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.txtRG)
        Me.Controls.Add(Me.Celular)
        Me.Controls.Add(Me.RG)
        Me.Controls.Add(Me.txtCPF)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.Telefone)
        Me.Controls.Add(Me.Nome)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.PainelTop)
        Me.Controls.Add(Me.CPF)
        Me.Controls.Add(Me.PainelBoth)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmVisitantes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Visitantes"
        Me.PainelTop.ResumeLayout(False)
        Me.PainelTop.PerformLayout()
        Me.PainelBoth.ResumeLayout(False)
        CType(Me.DGViewVisitantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCargoID As TextBox
    Friend WithEvents Ocupacao As Label
    Friend WithEvents txtCelular As MaskedTextBox
    Friend WithEvents txtRG As MaskedTextBox
    Friend WithEvents Celular As Label
    Friend WithEvents RG As Label
    Friend WithEvents txtCPF As MaskedTextBox
    Friend WithEvents txtTelefone As MaskedTextBox
    Friend WithEvents Telefone As Label
    Friend WithEvents Nome As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtBuscaCPF As MaskedTextBox
    Friend WithEvents Buscar As Label
    Friend WithEvents rbCPF As RadioButton
    Friend WithEvents rbNome As RadioButton
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtBuscaNome As TextBox
    Friend WithEvents PainelTop As Panel
    Friend WithEvents btnDeletar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents CPF As Label
    Friend WithEvents PainelBoth As Panel
    Friend WithEvents txtCondominio As TextBox
    Friend WithEvents Condominio As Label
    Friend WithEvents DGViewVisitantes As DataGridView
    Friend WithEvents btnImagem As Button
    Friend WithEvents txtImagem As PictureBox
End Class
