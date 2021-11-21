Imports MySql.Data.MySqlClient


Public Class frmFuncionarios

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '

    Dim usu As String
    Dim cpffuncionario As String

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    Private Sub frmFuncionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InativarBotoes()
        Listar()
        rbNome.Checked = True
        rbCPF.Checked = True

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
            sql = "SELECT * FROM tblFuncionarios order by Nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DGViewFuncionarios.DataSource = dt

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

        DGViewFuncionarios.Columns(0).Visible = False

        DGViewFuncionarios.Columns(0).HeaderText = "ID do Funcionário"
        DGViewFuncionarios.Columns(1).HeaderText = "Nome"
        DGViewFuncionarios.Columns(2).HeaderText = "CPF"
        DGViewFuncionarios.Columns(3).HeaderText = "RG"
        DGViewFuncionarios.Columns(4).HeaderText = "Telefone"
        DGViewFuncionarios.Columns(5).HeaderText = "Celular"
        DGViewFuncionarios.Columns(6).HeaderText = "Endereço"
        DGViewFuncionarios.Columns(7).HeaderText = "Crachá"
        DGViewFuncionarios.Columns(8).HeaderText = "Condomínio"
        DGViewFuncionarios.Columns(9).HeaderText = "Cargo"


        DGViewFuncionarios.Width = 350

    End Sub

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    'Btn Novo
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
    'Habilita os Campos
    Private Sub HabilitarCampos()
        txtNome.Enabled = True
        txtCPF.Enabled = True
        txtRG.Enabled = True
        txtTelefone.Enabled = True
        txtCelular.Enabled = True
        txtEndereco.Enabled = True
        txtCracha.Enabled = True
        txtCondominio.Enabled = True
        txtCargo.Enabled = True
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
        txtEndereco.Enabled = False
        txtCracha.Enabled = False
        txtCondominio.Enabled = False
        txtCargo.Enabled = False
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
        txtCelular.Text = ""
        txtEndereco.Text = ""
        txtCracha.Text = ""
        txtCondominio.Text = ""
        txtCargo.Text = ""
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
                'Verificar se o CPF do Funcionario já está cadastrado
                Abrir()
                Dim cmdCPF As MySqlCommand
                Dim sqlCPF As String
                Dim readerCPF As MySqlDataReader 'devolve o que foi exeutado
                sqlCPF = "SELECT * FROM tblFuncionarios where cpf = '" & txtCPF.Text & "' "
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

                'Verificar se o RG do Funcionario já está cadastrado
                Abrir()
                Dim cmdRG As MySqlCommand
                Dim sqlRG As String
                Dim readerRG As MySqlDataReader 'devolve o que foi exeutado
                sqlRG = "SELECT * FROM tblporteiros where rg = '" & txtRG.Text & "' "
                cmdRG = New MySqlCommand(sqlRG, con)
                readerRG = cmdRG.ExecuteReader()


                If readerRG.Read = True Then
                    readerRG.Close() 'Tem que fechar pois fica gravado na memória
                    MsgBox("RG já cadastrado, por favor verifique.")
                    txtRG.Text = ""
                    txtRG.Focus()
                    Exit Sub

                End If
                readerRG.Close()


                'Verificar se o Celular do Funcionario já está cadastrado
                Abrir()
                Dim cmdCelular As MySqlCommand
                Dim sqlCelular As String
                Dim readerCelular As MySqlDataReader 'devolve o que foi exeutado
                sqlCelular = "SELECT * FROM tblFuncionarios where celular = '" & txtCelular.Text & "' "
                cmdCelular = New MySqlCommand(sqlCelular, con)
                readerCelular = cmdCelular.ExecuteReader()


                If readerCelular.Read = True Then
                    readerCelular.Close() 'Tem que fechar pois fica gravado na memória
                    MsgBox("Celular já cadastrado, por favor verifique.")
                    txtCelular.Text = ""
                    txtCelular.Focus()
                    Exit Sub

                End If
                readerCelular.Close()

                ''Verificar se o Crachá do Funcionario já está cadastrado
                'Abrir()
                'Dim cmdCracha As MySqlCommand
                'Dim sqlCracha As String
                'Dim readerCracha As MySqlDataReader 'devolve o que foi exeutado
                'sqlCelular = "SELECT * FROM tblFuncionarios where cracha = '" & txtCracha.Text & "' "
                'cmdCelular = New MySqlCommand(sqlCracha, con)
                'readerCracha = cmdCracha.ExecuteReader()


                'If readerCracha.Read = True Then
                '    readerCracha.Close() 'Tem que fechar pois fica gravado na memória
                '    MsgBox("Crachá já cadastrado, por favor verifique.")
                '    txtCracha.Text = ""
                '    txtCracha.Focus()
                '    Exit Sub

                'End If
                'readerCracha.Close()


                Abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "INSERT INTO  tblfuncionarios (nome, cpf, rg, telefone, celular, endereco, cracha,  condominioID, cargoID) VALUES ('" & txtNome.Text & "', '" & txtCPF.Text & "', '" & txtRG.Text & "', '" & txtTelefone.Text & "', '" & txtCelular.Text & "', '" & txtEndereco.Text & "', '" & txtCracha.Text & "',  '" & txtCondominio.Text & "', '" & txtCargo.Text & "') "
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


                If readerCPF.Read = True And txtCPF.Text <> cpffuncionario Then
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
                sqlRG = "SELECT * FROM tblFuncionario where rg = '" & txtRG.Text & "' "
                cmdRG = New MySqlCommand(sqlRG, con)
                readerRG = cmdRG.ExecuteReader()


                If readerRG.Read = True And txtRG.Text <> usu Then
                    readerRG.Close() 'Tem que fechar pois fica gravado na memória
                    MsgBox("RG já cadastrado, por favor verifique.")
                    txtRG.Text = ""
                    txtRG.Focus()
                    Exit Sub

                End If
                readerRG.Close()

                'Verificar se o Celular do funcionario já está cadastrado
                Abrir()
                Dim cmdCelular As MySqlCommand
                Dim sqlCelular As String
                Dim readerCelular As MySqlDataReader 'devolve o que foi exeutado
                sqlCelular = "SELECT * FROM tblFuncionario where usuario = '" & txtCelular.Text & "' "
                cmdCelular = New MySqlCommand(sqlCelular, con)
                readerCelular = cmdCelular.ExecuteReader()


                If readerCelular.Read = True And txtCelular.Text <> usu Then
                    readerCelular.Close() 'Tem que fechar pois fica gravado na memória
                    MsgBox("Celular já cadastrado, por favor verifique.")
                    txtCelular.Text = ""
                    txtCelular.Focus()
                    Exit Sub

                End If
                readerCelular.Close()


                Abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "UPDATE tblfuncionarios SET nome =  '" & txtNome.Text & "', cpf =  '" & txtCPF.Text & "', rg =  '" & txtRG.Text & "', telefone =  '" & txtTelefone.Text & "', celular =  '" & txtCelular.Text & "', endereco =  '" & txtEndereco.Text & "', cracha =  '" & txtCracha.Text & "', condominio =  '" & txtCondominio.Text & "', cracha =  '" & txtCracha.Text & "' where idfuncionario =   '" & txtID.Text & "'"
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
                sql = "DELETE * FROM tblfuncionarios where id = '" & txtID.Text & "' "
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
            sql = "SELECT * FROM tblFuncionarios where nome LIKE '" & txtBuscaNome.Text & "%' order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DGViewFuncionarios.DataSource = dt

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
            sql = "SELECT * FROM tblFuncionarios where cpf = '" & txtBuscaCPF.Text & "' order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DGViewFuncionarios.DataSource = dt

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