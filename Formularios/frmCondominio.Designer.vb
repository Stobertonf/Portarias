<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCondominio
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
        Me.txtBuscaCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbCNJP = New System.Windows.Forms.RadioButton()
        Me.rbNome = New System.Windows.Forms.RadioButton()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Busca = New System.Windows.Forms.TextBox()
        Me.PainelBoth = New System.Windows.Forms.Panel()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Usuario = New System.Windows.Forms.Label()
        Me.txtCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.CNPJ = New System.Windows.Forms.Label()
        Me.Telefone = New System.Windows.Forms.Label()
        Me.Nome = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.DGViewCondominios = New System.Windows.Forms.DataGridView()
        Me.PainelTop.SuspendLayout()
        Me.PainelBoth.SuspendLayout()
        CType(Me.DGViewCondominios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PainelTop
        '
        Me.PainelTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PainelTop.BackColor = System.Drawing.Color.GhostWhite
        Me.PainelTop.Controls.Add(Me.txtBuscaCNPJ)
        Me.PainelTop.Controls.Add(Me.Label1)
        Me.PainelTop.Controls.Add(Me.rbCNJP)
        Me.PainelTop.Controls.Add(Me.rbNome)
        Me.PainelTop.Controls.Add(Me.txtID)
        Me.PainelTop.Controls.Add(Me.Busca)
        Me.PainelTop.Location = New System.Drawing.Point(1, 12)
        Me.PainelTop.Name = "PainelTop"
        Me.PainelTop.Size = New System.Drawing.Size(1342, 100)
        Me.PainelTop.TabIndex = 2
        '
        'txtBuscaCNPJ
        '
        Me.txtBuscaCNPJ.Location = New System.Drawing.Point(808, 27)
        Me.txtBuscaCNPJ.Mask = "00.000.000/0000-00"
        Me.txtBuscaCNPJ.Name = "txtBuscaCNPJ"
        Me.txtBuscaCNPJ.Size = New System.Drawing.Size(240, 38)
        Me.txtBuscaCNPJ.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(303, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 32)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Buscar:"
        '
        'rbCNJP
        '
        Me.rbCNJP.AutoSize = True
        Me.rbCNJP.Location = New System.Drawing.Point(653, 27)
        Me.rbCNJP.Name = "rbCNJP"
        Me.rbCNJP.Size = New System.Drawing.Size(125, 36)
        Me.rbCNJP.TabIndex = 2
        Me.rbCNJP.TabStop = True
        Me.rbCNJP.Text = "CNPJ"
        Me.rbCNJP.UseVisualStyleBackColor = True
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
        'Busca
        '
        Me.Busca.Location = New System.Drawing.Point(808, 27)
        Me.Busca.Name = "Busca"
        Me.Busca.Size = New System.Drawing.Size(240, 38)
        Me.Busca.TabIndex = 0
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
        Me.PainelBoth.Location = New System.Drawing.Point(1, 663)
        Me.PainelBoth.Name = "PainelBoth"
        Me.PainelBoth.Size = New System.Drawing.Size(1349, 172)
        Me.PainelBoth.TabIndex = 3
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
        Me.btnDeletar.TabIndex = 11
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
        Me.btnEditar.TabIndex = 10
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
        Me.btnSalvar.TabIndex = 9
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
        Me.btnNovo.TabIndex = 8
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'txtEndereco
        '
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.Location = New System.Drawing.Point(834, 151)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(215, 38)
        Me.txtEndereco.TabIndex = 4
        '
        'Usuario
        '
        Me.Usuario.AutoSize = True
        Me.Usuario.BackColor = System.Drawing.Color.Transparent
        Me.Usuario.Location = New System.Drawing.Point(662, 154)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(145, 32)
        Me.Usuario.TabIndex = 20
        Me.Usuario.Text = "Endereço:"
        '
        'txtCNPJ
        '
        Me.txtCNPJ.Enabled = False
        Me.txtCNPJ.Location = New System.Drawing.Point(834, 235)
        Me.txtCNPJ.Mask = "999.999.999-99"
        Me.txtCNPJ.Name = "txtCNPJ"
        Me.txtCNPJ.Size = New System.Drawing.Size(215, 38)
        Me.txtCNPJ.TabIndex = 6
        '
        'txtTelefone
        '
        Me.txtTelefone.Enabled = False
        Me.txtTelefone.Location = New System.Drawing.Point(289, 235)
        Me.txtTelefone.Mask = "(99) 9999-9999"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(211, 38)
        Me.txtTelefone.TabIndex = 5
        '
        'CNPJ
        '
        Me.CNPJ.AutoSize = True
        Me.CNPJ.BackColor = System.Drawing.Color.Transparent
        Me.CNPJ.Location = New System.Drawing.Point(662, 235)
        Me.CNPJ.Name = "CNPJ"
        Me.CNPJ.Size = New System.Drawing.Size(96, 32)
        Me.CNPJ.TabIndex = 16
        Me.CNPJ.Text = "CNPJ:"
        '
        'Telefone
        '
        Me.Telefone.AutoSize = True
        Me.Telefone.BackColor = System.Drawing.Color.Transparent
        Me.Telefone.Location = New System.Drawing.Point(134, 238)
        Me.Telefone.Name = "Telefone"
        Me.Telefone.Size = New System.Drawing.Size(135, 32)
        Me.Telefone.TabIndex = 14
        Me.Telefone.Text = "Telefone:"
        '
        'Nome
        '
        Me.Nome.AutoSize = True
        Me.Nome.BackColor = System.Drawing.Color.Transparent
        Me.Nome.Location = New System.Drawing.Point(134, 154)
        Me.Nome.Name = "Nome"
        Me.Nome.Size = New System.Drawing.Size(98, 32)
        Me.Nome.TabIndex = 11
        Me.Nome.Text = "Nome:"
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(289, 148)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(211, 38)
        Me.txtNome.TabIndex = 3
        '
        'DGViewCondominios
        '
        Me.DGViewCondominios.AllowUserToAddRows = False
        Me.DGViewCondominios.AllowUserToDeleteRows = False
        Me.DGViewCondominios.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.DGViewCondominios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGViewCondominios.Location = New System.Drawing.Point(140, 353)
        Me.DGViewCondominios.Name = "DGViewCondominios"
        Me.DGViewCondominios.ReadOnly = True
        Me.DGViewCondominios.RowTemplate.Height = 40
        Me.DGViewCondominios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGViewCondominios.Size = New System.Drawing.Size(909, 245)
        Me.DGViewCondominios.TabIndex = 7
        '
        'FrmCondominio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1342, 884)
        Me.Controls.Add(Me.DGViewCondominios)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.txtCNPJ)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.CNPJ)
        Me.Controls.Add(Me.Telefone)
        Me.Controls.Add(Me.Nome)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.PainelBoth)
        Me.Controls.Add(Me.PainelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmCondominio"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Condomínios"
        Me.PainelTop.ResumeLayout(False)
        Me.PainelTop.PerformLayout()
        Me.PainelBoth.ResumeLayout(False)
        CType(Me.DGViewCondominios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PainelTop As Panel
    Friend WithEvents txtBuscaCNPJ As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rbCNJP As RadioButton
    Friend WithEvents rbNome As RadioButton
    Friend WithEvents txtID As TextBox
    Friend WithEvents Busca As TextBox
    Friend WithEvents PainelBoth As Panel
    Friend WithEvents btnDeletar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Usuario As Label
    Friend WithEvents txtCNPJ As MaskedTextBox
    Friend WithEvents txtTelefone As MaskedTextBox
    Friend WithEvents CNPJ As Label
    Friend WithEvents Telefone As Label
    Friend WithEvents Nome As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents DGViewCondominios As DataGridView
End Class
