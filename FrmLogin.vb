Imports MySql.Data.MySqlClient



Public Class FrmLogin

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.BackColor = Color.FromArgb(246, 250, 253)
        txtSenha.BackColor = Color.FromArgb(246, 250, 253)
        Login()
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
    End Sub

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    Private Sub txtSenha_TextChanged_1(sender As Object, e As EventArgs) Handles txtSenha.TextChanged
        Login()

    End Sub


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


End Class