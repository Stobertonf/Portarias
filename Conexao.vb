Imports MySql.Data.MySqlClient
Module Conexao

    '   Public con As New MySqlConnection("server=localhost; userid=root; password=3f49215c; database=portarias; port=3306;")
    Public con As New MySqlConnection("server=localhost; userid=root; password=3f49215c; database=portarias; port=3306;")


    Public nomeUsuario
    Public nomePorteiro

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    Sub Abrir()
        If con.State = 0 Then
            con.Open()
        End If


    End Sub

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    Sub Fechar()
        If con.State = 1 Then
            con.Close()
        End If


    End Sub

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '



    'VARIAVEIS PARA PASSAGEM DE PARAMETROS
    Public nomeFuncionario
    Public cpfFuncionario
    Public cargoFuncionario
    Public funcionarioVerificar

    Public nomeVisitante
    Public cpfVisitante
    Public ocupacaoVisitante

End Module
