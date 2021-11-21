Imports MySql.Data.MySqlClient
Public Class frmLogin_Old
    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtUsuario.BackColor = Color.FromArgb(246, 250, 253)
        '  txtSenha.BackColor = Color.FromArgb(246, 250, 253)
        'Login()
    End Sub

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    Sub Login()

        'VERIFICAR SE O USUÁRIO EXISTE
        Abrir()
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader
        Dim sql As String
        sql = "SELECT * FROM tblporteiros where usuario = '" & txtUsuario.Text & "' and senha = '" & txtSenha.Text & "' "
        cmd = New MySqlCommand(sql, con)
        reader = cmd.ExecuteReader()


        If reader.Read = True Then

            Dim nomeUsu As String
            nomeUsu = reader(8) 'Recebe a informação da posição da coluna usuário no bd 

            Dim nomePort As String
            nomePort = reader(1) 'Recebe a informação da posição da coluna nome do porteiro no bd 

            nomePorteiro = nomePort
            nomeUsuario = nomeUsu

            reader.Close()
            MsgBox("Bem vindo ao sistema " + nomePorteiro)

            Dim form = New frmPrincipal
            Me.Hide()
            form.ShowDialog()

            Exit Sub

        End If
        reader.Close()



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
    Private Sub txtSenha_TextChanged(sender As Object, e As EventArgs)
        Login()
    End Sub

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs)
        Login()
    End Sub

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '



    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then


            'Verificar se o CPF do porteiro já está cadastrado
            Abrir()
            Dim cmdCPF As MySqlCommand
            Dim sqlCPF As String
            Dim readerCPF As MySqlDataReader 'devolve o que foi exeutado
            sqlCPF = "SELECT * FROM tblporteiros where cpf = '" & txtUsuario.Text & "' and senha = '" & txtSenha.Text & "'"
            cmdCPF = New MySqlCommand(sqlCPF, con)
            readerCPF = cmdCPF.ExecuteReader()


            If readerCPF.Read = True Then
                readerCPF.Close() 'Tem que fechar pois fica gravado na memória
                MsgBox("CPF já cadastrado, por favor verifique.")
                txtUsuario.Text = ""
                txtSenha.Focus()
                Exit Sub

            End If
            readerCPF.Close()

            Dim form = New frmPrincipal
            Me.Hide()
            form.ShowDialog()
        End If
    End Sub
    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '

End Class
