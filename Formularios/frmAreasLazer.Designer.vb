<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAreasLazer
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
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtCondominio = New System.Windows.Forms.TextBox()
        Me.Condominio = New System.Windows.Forms.Label()
        Me.PainelTop = New System.Windows.Forms.Panel()
        Me.Buscar = New System.Windows.Forms.Label()
        Me.rbDescricao = New System.Windows.Forms.RadioButton()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtBuscaDescricao = New System.Windows.Forms.TextBox()
        Me.DGViewAreasLazer = New System.Windows.Forms.DataGridView()
        Me.PainelBoth = New System.Windows.Forms.Panel()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.DescricaoAreaLazer = New System.Windows.Forms.Label()
        Me.PainelTop.SuspendLayout()
        CType(Me.DGViewAreasLazer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PainelBoth.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(187, 132)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(414, 38)
        Me.txtDescricao.TabIndex = 1
        '
        'txtCondominio
        '
        Me.txtCondominio.Location = New System.Drawing.Point(853, 132)
        Me.txtCondominio.Name = "txtCondominio"
        Me.txtCondominio.Size = New System.Drawing.Size(414, 38)
        Me.txtCondominio.TabIndex = 20
        '
        'Condominio
        '
        Me.Condominio.AutoSize = True
        Me.Condominio.Location = New System.Drawing.Point(635, 135)
        Me.Condominio.Name = "Condominio"
        Me.Condominio.Size = New System.Drawing.Size(176, 32)
        Me.Condominio.TabIndex = 21
        Me.Condominio.Text = "Condomínio:"
        '
        'PainelTop
        '
        Me.PainelTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PainelTop.BackColor = System.Drawing.Color.GhostWhite
        Me.PainelTop.Controls.Add(Me.Buscar)
        Me.PainelTop.Controls.Add(Me.rbDescricao)
        Me.PainelTop.Controls.Add(Me.txtID)
        Me.PainelTop.Controls.Add(Me.txtBuscaDescricao)
        Me.PainelTop.Location = New System.Drawing.Point(1, 1)
        Me.PainelTop.Name = "PainelTop"
        Me.PainelTop.Size = New System.Drawing.Size(1323, 100)
        Me.PainelTop.TabIndex = 22
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
        'rbDescricao
        '
        Me.rbDescricao.AutoSize = True
        Me.rbDescricao.Location = New System.Drawing.Point(472, 26)
        Me.rbDescricao.Name = "rbDescricao"
        Me.rbDescricao.Size = New System.Drawing.Size(178, 36)
        Me.rbDescricao.TabIndex = 1
        Me.rbDescricao.TabStop = True
        Me.rbDescricao.Text = "Descrição"
        Me.rbDescricao.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(27, 24)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(60, 38)
        Me.txtID.TabIndex = 0
        '
        'txtBuscaDescricao
        '
        Me.txtBuscaDescricao.Location = New System.Drawing.Point(676, 24)
        Me.txtBuscaDescricao.Name = "txtBuscaDescricao"
        Me.txtBuscaDescricao.Size = New System.Drawing.Size(590, 38)
        Me.txtBuscaDescricao.TabIndex = 0
        '
        'DGViewAreasLazer
        '
        Me.DGViewAreasLazer.AllowUserToAddRows = False
        Me.DGViewAreasLazer.AllowUserToDeleteRows = False
        Me.DGViewAreasLazer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGViewAreasLazer.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.DGViewAreasLazer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGViewAreasLazer.Location = New System.Drawing.Point(18, 208)
        Me.DGViewAreasLazer.Name = "DGViewAreasLazer"
        Me.DGViewAreasLazer.ReadOnly = True
        Me.DGViewAreasLazer.RowTemplate.Height = 40
        Me.DGViewAreasLazer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGViewAreasLazer.Size = New System.Drawing.Size(1249, 245)
        Me.DGViewAreasLazer.TabIndex = 23
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
        Me.PainelBoth.Location = New System.Drawing.Point(1, 517)
        Me.PainelBoth.Name = "PainelBoth"
        Me.PainelBoth.Size = New System.Drawing.Size(1323, 193)
        Me.PainelBoth.TabIndex = 24
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
        'DescricaoAreaLazer
        '
        Me.DescricaoAreaLazer.AutoSize = True
        Me.DescricaoAreaLazer.Location = New System.Drawing.Point(22, 135)
        Me.DescricaoAreaLazer.Name = "DescricaoAreaLazer"
        Me.DescricaoAreaLazer.Size = New System.Drawing.Size(149, 32)
        Me.DescricaoAreaLazer.TabIndex = 25
        Me.DescricaoAreaLazer.Text = "Descrição:"
        '
        'frmAreasLazer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1322, 757)
        Me.Controls.Add(Me.DescricaoAreaLazer)
        Me.Controls.Add(Me.PainelBoth)
        Me.Controls.Add(Me.DGViewAreasLazer)
        Me.Controls.Add(Me.PainelTop)
        Me.Controls.Add(Me.txtCondominio)
        Me.Controls.Add(Me.Condominio)
        Me.Controls.Add(Me.txtDescricao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAreasLazer"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Areas de Lazer"
        Me.PainelTop.ResumeLayout(False)
        Me.PainelTop.PerformLayout()
        CType(Me.DGViewAreasLazer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PainelBoth.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Descricao As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents txtCondominio As TextBox
    Friend WithEvents Condominio As Label
    Friend WithEvents PainelTop As Panel
    Friend WithEvents Buscar As Label
    Friend WithEvents rbDescricao As RadioButton
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtBuscaDescricao As TextBox
    Friend WithEvents DGViewAreasLazer As DataGridView
    Friend WithEvents PainelBoth As Panel
    Friend WithEvents btnDeletar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents DescricaoAreaLazer As Label
End Class
