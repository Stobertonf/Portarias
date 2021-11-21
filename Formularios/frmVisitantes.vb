
Imports MySql.Data.MySqlClient

Public Class frmVisitantes

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    Dim cpfvisitante As String
    Dim rgvisitante As String
    Dim celularvisitante As String

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    Private Sub FrmVisitantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            sql = "Select IDVisitante as ID, VSTT.Nome, VSTT.RG, VSTT.CPF, VSTT.Telefone,
				          VSTT.Celular, VSTT.Imagem, CG.Cargo, CDMN.Nome
                   From tblVisitantes VSTT
					      Inner Join tblCargos CG on VSTT.CargoID = CG.IDCargo
                          Inner Join tblCondominios CDMN On VSTT.CondominioID = CDMN.IDCondominio "

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            'DGViewVisitantes.DataSource = dt

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

        DGViewVisitantes.Columns(0).Visible = False

        DGViewVisitantes.Columns(0).HeaderText = "ID do Visitante"
        DGViewVisitantes.Columns(1).HeaderText = "Nome"
        DGViewVisitantes.Columns(2).HeaderText = "RG"
        DGViewVisitantes.Columns(3).HeaderText = "CPF"
        DGViewVisitantes.Columns(4).HeaderText = "Telefone"
        DGViewVisitantes.Columns(5).HeaderText = "Celular"
        DGViewVisitantes.Columns(6).HeaderText = "Ocupação"
        DGViewVisitantes.Columns(7).HeaderText = "Cargo"
        DGViewVisitantes.Columns(8).HeaderText = "Condominio"

        DGViewVisitantes.Width = 150

    End Sub

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
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
        txtCelular.Enabled = True
        txtCargoID.Enabled = True
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
        txtCargoID.Enabled = False
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
        txtCelular.Text = ""
        txtCargoID.Text = ""
        txtCondominio.Text = ""
    End Sub

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    ' Botão Salvar
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtNome.Text <> "" Or txtCPF.Text <> "" Or txtRG.Text <> "" Then
            Try
                'Verificar se o CPF do porteiro já está cadastrado
                Abrir()
                Dim cmdCPF As MySqlCommand
                Dim sqlCPF As String
                Dim readerCPF As MySqlDataReader 'devolve o que foi exeutado
                sqlCPF = "SELECT * FROM tblvisitantes where cpf = '" & txtCPF.Text & "' "
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

                'Verificar se o rg do visitanet já está cadastrado
                Abrir()
                Dim cmdRG As MySqlCommand
                Dim sqlRG As String
                Dim readerRG As MySqlDataReader 'devolve o que foi exeutado
                sqlRG = "SELECT * FROM tblvisitantes where rg = '" & txtRG.Text & "' "
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

                'Verificar se o celular do Visitatnte já está cadastrado
                Abrir()
                Dim cmdCel As MySqlCommand
                Dim sqlCel As String
                Dim readerCel As MySqlDataReader 'devolve o que foi exeutado
                sqlCel = "SELECT * FROM tblvisitantes where celular = '" & txtCelular.Text & "' "
                cmdCel = New MySqlCommand(sqlCel, con)
                readerCel = cmdCel.ExecuteReader()


                If readerCel.Read = True Then
                    readerCel.Close() 'Tem que fechar pois fica gravado na memória
                    MsgBox("Celular já cadastrado, por favor verifique.")
                    txtCargoID.Text = ""
                    txtCargoID.Focus()
                    Exit Sub

                End If
                readerCel.Close()


                Abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "INSERT INTO  tblVisitantes (nome, rg, cpf, telefone, celular, imagem, cargoid, condominioid) VALUES ('" & txtNome.Text & "','" & txtRG.Text & "', '" & txtCPF.Text & "',  '" & txtTelefone.Text & "', '" & txtCelular.Text & "', '" & txtImagem.Text & "' , '" & txtCargoID.Text & "', '" & txtCondominio.Text & "') "

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
                sqlCPF = "SELECT * FROM tblvisitantes where cpf = '" & txtCPF.Text & "' "
                cmdCPF = New MySqlCommand(sqlCPF, con)
                readerCPF = cmdCPF.ExecuteReader()


                If readerCPF.Read = True And txtCPF.Text <> cpfvisitante Then
                    readerCPF.Close() 'Tem que fechar pois fica gravado na memória
                    MsgBox("CPF já cadastrado, por favor verifique.")
                    txtCPF.Text = ""
                    txtCPF.Focus()
                    Exit Sub

                End If
                readerCPF.Close()

                'Verificar se o RG do Visitante já está cadastrado
                Abrir()
                Dim cmdRG As MySqlCommand
                Dim sqlRG As String
                Dim readerRG As MySqlDataReader 'devolve o que foi exeutado
                sqlRG = "SELECT * FROM tblporteiros where rg = '" & txtRG.Text & "' "
                cmdRG = New MySqlCommand(sqlRG, con)
                readerRG = cmdRG.ExecuteReader()


                If readerRG.Read = True And txtRG.Text <> rgvisitante Then
                    readerRG.Close() 'Tem que fechar pois fica gravado na memória
                    MsgBox("RG já cadastrado, por favor verifique.")
                    txtRG.Text = ""
                    txtRG.Focus()
                    Exit Sub

                End If
                readerRG.Close()




                Abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "UPDATE tblVisitantes SET nome =  '" & txtNome.Text & "', rg = '" & txtRG.Text & "', cpf =  '" & txtCPF.Text & "',  telefone =  '" & txtTelefone.Text & "', celular =  '" & txtCelular.Text & "', ocupacao =  '" & txtCargoID.Text & "', condominioid =  '" & txtCondominio.Text & "',  ' where idvisitante =   '" & txtID.Text & "'"
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
                sql = "DELETE * FROM tblvisitantes where id = '" & txtID.Text & "' "
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
            sql = "SELECT * FROM tblVisiantes where nome LIKE '" & txtBuscaNome.Text & "%' order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            'DGViewVisitantes.DataSource = dt

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
            sql = "SELECT * FROM tblvisitantes where cpf = '" & txtBuscaCPF.Text & "' order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            'DGViewVisitantes.DataSource = dt

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