Imports MySql.Data.MySqlClient


Public Class frmCargo


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    Dim cargo As String
    Dim usu As String

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '

    Private Sub frmCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InativarBotoes()
        Listar()
        rbCargo.Checked = True

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
            sql = "SELECT * FROM tblCargos order by cargo asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DGViewCargos.DataSource = dt

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

        DGViewCargos.Columns(0).Visible = False

        DGViewCargos.Columns(0).HeaderText = "ID do Cargo"
        DGViewCargos.Columns(1).HeaderText = "Cargo"

        DGViewCargos.Width = 350

    End Sub

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    'Btn Novo
    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        txtCargo.Focus()
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
        txtCargo.Enabled = True
    End Sub

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '

    'Dasabilita os campos
    Private Sub DesabilitarCampos()
        txtCargo.Enabled = True
    End Sub

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    'Limpa

    Private Sub Limpar()
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
        If txtCargo.Text <> "" Then
            Try
                'Verificar se o CNPJ do condomínio já está cadastrado
                Abrir()
                Dim cmdCargo As MySqlCommand
                Dim sqlCargo As String
                Dim readerCargo As MySqlDataReader 'devolve o que foi exeutado
                sqlCargo = "SELECT * FROM tblCargos where cargo = '" & txtCargo.Text & "' "
                cmdCargo = New MySqlCommand(sqlCargo, con)
                readerCargo = cmdCargo.ExecuteReader()


                If readerCargo.Read = True Then
                    readerCargo.Close() 'Tem que fechar pois fica gravado na memória
                    MsgBox("Cargo já cadastrado, por favor verifique.")
                    txtCargo.Text = ""
                    txtCargo.Focus()
                    Exit Sub

                End If
                readerCargo.Close()




                Abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "INSERT INTO  tblCargos (cargo) VALUES ('" & txtCargo.Text & "') "
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

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    'Botão Editar
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtCargo.Text <> "" Then
            Try
                'Verificar se o Cargo já está cadastrado
                Abrir()
                Dim cmdCargo As MySqlCommand
                Dim sqlCargo As String
                Dim readerCargo As MySqlDataReader 'devolve o que foi exeutado
                sqlCargo = "SELECT * FROM tblCargos where cnpj = '" & txtCargo.Text & "' "
                cmdCargo = New MySqlCommand(sqlCargo, con)
                readerCargo = cmdCargo.ExecuteReader()


                If readerCargo.Read = True Then
                    readerCargo.Close() 'Tem que fechar pois fica gravado na memória
                    MsgBox("Cargo já cadastrado, por favor verifique.")
                    txtCargo.Text = ""
                    txtCargo.Focus()
                    Exit Sub

                End If
                readerCargo.Close()




                Abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "UPDATE tblCargo SET nome =  '" & txtCargo.Text & "' "
                cmd = New MySqlCommand(sqlCargo, con)
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
                sql = "DELETE * FROM tblCargos where id = '" & txtID.Text & "' "
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
    Sub buscarCargo()
        Try
            Abrir()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter

            Dim sql As String
            sql = "SELECT * FROM tblCargos where nome LIKE '" & txtBusca.Text & "%' order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DGViewCargos.DataSource = dt

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