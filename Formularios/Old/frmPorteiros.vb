Imports MySql.Data.MySqlClient
Public Class frmPorteiros




    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    Dim cpfporteiro As String
    Dim usu As String
    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    Private Sub FrmPorteiros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InativarBotoes()
        Listar()
        rbNome.Checked = True

        Me.BackColor = Color.FromArgb(224, 233, 240)

    End Sub

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    'Listando os registros
    Sub Listar()
        Try
            Abrir()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter

            Dim sql As String
            '  sql = "SELECT * FROM tblporteiros Inner Join tblCondominios on IDCondominio = tblPorteiros.CondominioID order by nome asc"
            sql = "Select IDPorteiro as ID, PTR.Nome, PTR.CPF, PTR.RG,
					 PTR.Telefone, PTR.Celular, PTR.Nascimento,
					 PTR.Endereco, PTR.Usuario, PTR.Senha,
                     CDMN.Nome as NomeCondominio
                   From tblPorteiros as PTR
					 Inner join tblCondominios CDMN  on PTR.CondominioID = CDMN.IDCondominio order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DGViewPorteiros.DataSource = dt

            FormatarDG()

        Catch ex As Exception
            MsgBox("Erro ao Listar" + ex.Message)
        End Try
    End Sub



    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    'Formata o DG
    Private Sub FormatarDG()

        DGViewPorteiros.Columns(0).Visible = False

        DGViewPorteiros.Columns(0).HeaderText = "ID do Porteiro"
        DGViewPorteiros.Columns(1).HeaderText = "Nome"
        DGViewPorteiros.Columns(2).HeaderText = "CPF"
        DGViewPorteiros.Columns(3).HeaderText = "RG"
        DGViewPorteiros.Columns(4).HeaderText = "Telefone"
        DGViewPorteiros.Columns(5).HeaderText = "Celular"
        DGViewPorteiros.Columns(6).HeaderText = "Nascimento"
        DGViewPorteiros.Columns(7).HeaderText = "Endereco"
        DGViewPorteiros.Columns(8).HeaderText = "Usuario"
        DGViewPorteiros.Columns(9).HeaderText = "Senha"
        DGViewPorteiros.Columns(10).HeaderText = "Condominio"

        DGViewPorteiros.Width = 420

    End Sub
    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    'btn Novo

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        txtNome.Focus()
        HabilitarCampos()
        Limpar()

        btnSalvar.Enabled = True
        btnSalvar.BackgroundImage = My.Resources.btnSalvar

        btnNovo.Enabled = False
        btnNovo.BackgroundImage = My.Resources.btnNovoInativo

    End Sub


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '

    'Inativando os botões
    Sub InativarBotoes()
        btnEditar.BackgroundImage = My.Resources.btnEditarInativo
        btnSalvar.BackgroundImage = My.Resources.btnSalvarInativo
        btnDeletar.BackgroundImage = My.Resources.btnDeletarUserInativo

        btnEditar.Enabled = False
        btnSalvar.Enabled = False
        btnDeletar.Enabled = False
    End Sub

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    'Habilita os botões
    Private Sub HabilitarCampos()
        txtNome.Enabled = True
        txtCPF.Enabled = True
        txtRG.Enabled = True
        txtTelefone.Enabled = True
        txtNascimento.Enabled = True
        txtEndereco.Enabled = True
        txtUsuario.Enabled = True
        txtSenha.Enabled = True
        txtCondominio.Enabled = True
    End Sub

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    'Desabilita os Campos

    Private Sub DesabilitarCampos()
        txtNome.Enabled = False
        txtCPF.Enabled = False
        txtRG.Enabled = False
        txtTelefone.Enabled = False
        txtCelular.Enabled = False
        txtNascimento.Enabled = False
        txtEndereco.Enabled = False
        txtUsuario.Enabled = False
        txtSenha.Enabled = False
        txtCondominio.Enabled = False
    End Sub

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '

    'Limpando os registros
    Private Sub Limpar()
        txtNome.Text = ""
        txtCPF.Text = ""
        txtRG.Text = ""
        txtTelefone.Text = ""
        txtNascimento.Text = ""
        txtEndereco.Text = ""
        txtUsuario.Text = ""
        txtSenha.Text = ""
        txtCondominio.Text = ""
    End Sub

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    ' Botão Salvar
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtNome.Text <> "" Or txtCPF.Text <> "" Then
            Try
                'Verificar se o CPF do porteiro já está cadastrado
                Abrir()
                Dim cmdCPF As MySqlCommand
                Dim sqlCPF As String
                Dim readerCPF As MySqlDataReader 'devolve o que foi exeutado
                sqlCPF = "SELECT * FROM tblporteiros where cpf = '" & txtCPF.Text & "' "
                cmdCPF = New MySqlCommand(sqlCPF, con)
                readerCPF = cmdCPF.ExecuteReader()


                If readerCPF.Read = True Then
                    readerCPF.Close() 'Tem que fechar pois fica gravado na memória
                    MsgBox("CPF já cadastrado, por favor verifique.")
                    txtCPF.Text = ""
                    txtCPF.Focus()
                    Exit Sub

                End If
                readerCPF.Close()

                'Verificar se o Usuario do porteiro já está cadastrado
                Abrir()
                Dim cmdUser As MySqlCommand
                Dim sqlUser As String
                Dim readerUser As MySqlDataReader 'devolve o que foi exeutado
                sqlUser = "SELECT * FROM tblporteiros where usuario = '" & txtUsuario.Text & "' "
                cmdUser = New MySqlCommand(sqlUser, con)
                readerUser = cmdUser.ExecuteReader()


                If readerUser.Read = True Then
                    readerUser.Close() 'Tem que fechar pois fica gravado na memória
                    MsgBox("Usuário já cadastrado, por favor verifique.")
                    txtUsuario.Text = ""
                    txtUsuario.Focus()
                    Exit Sub

                End If
                readerUser.Close()


                Abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "INSERT INTO  tblporteiros (nome, cpf, rg, telefone, celular, nascimento, endereco, usuario, senha, condominioID) VALUES ('" & txtNome.Text & "', '" & txtCPF.Text & "', '" & txtRG.Text & "', '" & txtTelefone.Text & "', '" & txtCelular.Text & "', '" & txtNascimento.Text & "', '" & txtEndereco.Text & "',  '" & txtUsuario.Text & "', '" & txtSenha.Text & "', '" & txtCondominio.Text & "') "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Salvo com sucesso!!")

                Listar()
                DesabilitarCampos()

                btnSalvar.Enabled = False
                btnSalvar.BackgroundImage = My.Resources.btnSalvarInativo

                btnNovo.Enabled = False
                btnNovo.BackgroundImage = My.Resources.btnNovo



            Catch ex As Exception
                MsgBox("Erro ao Salvar!!" + ex.Message)
            End Try
        Else
            MsgBox("Por favor Preencha os campos!!")
        End If
    End Sub

    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    'Botão Editar
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtNome.Text <> "" Or txtCPF.Text <> "" Then
            Try
                'Verificar se o CPF do porteiro já está cadastrado
                Abrir()
                Dim cmdCPF As MySqlCommand
                Dim sqlCPF As String
                Dim readerCPF As MySqlDataReader 'devolve o que foi exeutado
                sqlCPF = "SELECT * FROM tblporteiros where cpf = '" & txtCPF.Text & "' "
                cmdCPF = New MySqlCommand(sqlCPF, con)
                readerCPF = cmdCPF.ExecuteReader()


                If readerCPF.Read = True And txtCPF.Text <> cpfporteiro Then
                    readerCPF.Close() 'Tem que fechar pois fica gravado na memória
                    MsgBox("CPF já cadastrado, por favor verifique.")
                    txtCPF.Text = ""
                    txtCPF.Focus()
                    Exit Sub

                End If
                readerCPF.Close()

                'Verificar se o RG do porteiro já está cadastrado
                Abrir()
                Dim cmdRG As MySqlCommand
                Dim sqlRG As String
                Dim readerRG As MySqlDataReader 'devolve o que foi exeutado
                sqlRG = "SELECT * FROM tblporteiros where rg = '" & txtRG.Text & "' "
                cmdRG = New MySqlCommand(sqlRG, con)
                readerRG = cmdRG.ExecuteReader()


                If readerRG.Read = True And txtRG.Text <> usu Then
                    readerRG.Close() 'Tem que fechar pois fica gravado na memória
                    MsgBox("RG já cadastrado, por favor verifique.")
                    txtUsuario.Text = ""
                    txtUsuario.Focus()
                    Exit Sub

                End If
                readerRG.Close()

                'Verificar se o Usuario do porteiro já está cadastrado
                Abrir()
                Dim cmdUser As MySqlCommand
                Dim sqlUser As String
                Dim readerUser As MySqlDataReader 'devolve o que foi exeutado
                sqlUser = "SELECT * FROM tblporteiros where usuario = '" & txtUsuario.Text & "' "
                cmdUser = New MySqlCommand(sqlUser, con)
                readerUser = cmdUser.ExecuteReader()


                If readerUser.Read = True And txtUsuario.Text <> usu Then
                    readerUser.Close() 'Tem que fechar pois fica gravado na memória
                    MsgBox("Usuário já cadastrado, por favor verifique.")
                    txtUsuario.Text = ""
                    txtUsuario.Focus()
                    Exit Sub

                End If
                readerUser.Close()


                Abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "UPDATE tblporteiros SET nome =  '" & txtNome.Text & "', cpf =  '" & txtCPF.Text & "', rg =  '" & txtRG.Text & "', telefone =  '" & txtTelefone.Text & "', celular =  '" & txtCelular.Text & "', nascimento =  '" & txtNascimento.Text & "', endereco =  '" & txtEndereco.Text & "', usuario =  '" & txtUsuario.Text & "', senha =  '" & txtSenha.Text & "', condominio =  '" & txtCondominio.Text & "' where idporteiro =   '" & txtID.Text & "'"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Registro editado com sucesso!!")

                Listar()
                DesabilitarCampos()
                InativarBotoes()


                btnNovo.Enabled = False
                btnNovo.BackgroundImage = My.Resources.btnNovo



            Catch ex As Exception
                MsgBox("Erro ao Editar, por favor verifique!!" + ex.Message)
            End Try
        Else
            MsgBox("Preencha os campos!!")
        End If
    End Sub



    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '

    'Botão Excluir
    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        Try
            Dim resultado As DialogResult = MessageBox.Show("Deseja excluir o registro?", "Excluir Registro", MessageBoxButtons.YesNo)
            If resultado = vbYes Then
                Abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "DELETE * FROM tblporteiros where id = '" & txtID.Text & "' "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Registro excluído com sucesso!!")

                Listar()
                DesabilitarCampos()
                InativarBotoes()


                btnNovo.Enabled = False
                btnNovo.BackgroundImage = My.Resources.btnNovo

                Limpar()
            End If


        Catch ex As Exception
            MsgBox("Erro ao Editar, por favor verifique!!" + ex.Message)
        End Try
    End Sub


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    'Busca por Nome
    Sub buscarNome()
        Try
            Abrir()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter

            Dim sql As String
            sql = "SELECT * FROM tblporteiros where nome LIKE '" & txtBuscaNome.Text & "%' order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DGViewPorteiros.DataSource = dt

            FormatarDG()

        Catch ex As Exception
            MsgBox("Erro ao Listar" + ex.Message)
        End Try
    End Sub


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '

    'Busca por CPF
    Sub buscarCPF()

        Try
            Abrir()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter

            Dim sql As String
            sql = "SELECT * FROM tblporteiros where cpf = '" & txtBuscaCPF.Text & "' order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DGViewPorteiros.DataSource = dt

            FormatarDG()

        Catch ex As Exception
            MsgBox("Erro ao Listar" + ex.Message)
        End Try

    End Sub




    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '

End Class