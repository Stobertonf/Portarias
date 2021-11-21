Imports MySql.Data.MySqlClient


Public Class FrmCondominio

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    Dim cnpjcondominio As String
    Dim usu As String

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '

    Private Sub FrmCondominio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            sql = "SELECT * FROM tblCondominios order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DGViewCondominios.DataSource = dt

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




    Private Sub FormatarDG()

        DGViewCondominios.Columns(0).Visible = False

        DGViewCondominios.Columns(0).HeaderText = "ID do Condomínio"
        DGViewCondominios.Columns(1).HeaderText = "Nome"
        DGViewCondominios.Columns(2).HeaderText = "Endereço"
        DGViewCondominios.Columns(3).HeaderText = "Telefone"
        DGViewCondominios.Columns(4).HeaderText = "CNPJ"


        'DGViewCondominios.Width = 150

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
    'Habilita os botões
    Private Sub HabilitarCampos()
        txtNome.Enabled = True
        txtEndereco.Enabled = True
        txtTelefone.Enabled = True
        txtCNPJ.Enabled = True

    End Sub

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '

    'Dasabilita os campos
    Private Sub DesabilitarCampos()
        txtNome.Enabled = True
        txtEndereco.Enabled = True
        txtTelefone.Enabled = True
        txtCNPJ.Enabled = True

    End Sub

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    'Limpa

    Private Sub Limpar()
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtTelefone.Text = ""
        txtCNPJ.Text = ""
    End Sub

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    ' Botão Salvar
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtNome.Text <> "" Or txtCNPJ.Text <> "" Then
            Try
                'Verificar se o CNPJ do condomínio já está cadastrado
                Abrir()
                Dim cmdCNPJ As MySqlCommand
                Dim sqlCNPJ As String
                Dim readerCNPJ As MySqlDataReader 'devolve o que foi exeutado
                sqlCNPJ = "SELECT * FROM tblcondominios where cnpj = '" & txtCNPJ.Text & "' "
                cmdCNPJ = New MySqlCommand(sqlCNPJ, con)
                readerCNPJ = cmdCNPJ.ExecuteReader()


                If readerCNPJ.Read = True Then
                    readerCNPJ.Close() 'Tem que fechar pois fica gravado na memória
                    MsgBox("CNPJ já cadastrado, por favor verifique.")
                    txtCNPJ.Text = ""
                    txtCNPJ.Focus()
                    Exit Sub

                End If
                readerCNPJ.Close()




                Abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "INSERT INTO  tblCondominios (nome, endereco, telefone, cnpj) VALUES ('" & txtNome.Text & "', '" & txtEndereco.Text & "', '" & txtTelefone.Text & "', '" & txtCNPJ.Text & "') "
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
        If txtNome.Text <> "" Or txtCNPJ.Text <> "" Then
            Try
                'Verificar se o CPF do porteiro já está cadastrado
                Abrir()
                Dim cmdCNPJ As MySqlCommand
                Dim sqlCNPJ As String
                Dim readerCNPJ As MySqlDataReader 'devolve o que foi exeutado
                sqlCNPJ = "SELECT * FROM tblCondominios where cnpj = '" & txtCNPJ.Text & "' "
                cmdCNPJ = New MySqlCommand(sqlCNPJ, con)
                readerCNPJ = cmdCNPJ.ExecuteReader()


                If readerCNPJ.Read = True And txtCNPJ.Text <> cnpjcondominio Then
                    readerCNPJ.Close() 'Tem que fechar pois fica gravado na memória
                    MsgBox("CNPJ já cadastrado, por favor verifique.")
                    txtCNPJ.Text = ""
                    txtCNPJ.Focus()
                    Exit Sub

                End If
                readerCNPJ.Close()




                Abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "UPDATE tblCondominios SET nome =  '" & txtNome.Text & "', endereco =  '" & txtEndereco.Text & "', telefone =  '" & txtTelefone.Text & "',   cnpj =  '" & txtCNPJ.Text & "' where idcondominio =   '" & txtID.Text & "'"
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
End Class