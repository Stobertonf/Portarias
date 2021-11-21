Public Class frmPrincipal



    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '

    Private Sub lblNome_Click(sender As Object, e As EventArgs) Handles lblNome.Click
        lblNome = nomePorteiro
        Me.BackColor = Color.FromArgb(224, 233, 240)
    End Sub
    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    Private Sub frmPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim form = New FrmLogin
        Me.Hide()
        form.ShowDialog()
    End Sub




    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    'Chamando os Formulários pelos botões

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '

    Private Sub FuncionaiorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionariosToolStripMenuItem.Click
        Dim form = New frmFuncionarios()
        form.ShowDialog()
    End Sub

    Private Sub PorteirosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorteirosToolStripMenuItem.Click
        Dim form = New frmPorteiros()
        form.ShowDialog()
    End Sub

    Private Sub VisitantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisitantesToolStripMenuItem.Click
        Dim form = New frmVisitantes()
        form.ShowDialog()
    End Sub
    Private Sub CargoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargoToolStripMenuItem.Click
        Dim form = New frmCargo()
        form.ShowDialog()
    End Sub

    Private Sub CondomínioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CondomínioToolStripMenuItem1.Click
        Dim form = New FrmCondominio()
        form.ShowDialog()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Dim form = New frmLogin_Old
        Me.Hide()
        form.ShowDialog()
    End Sub
    Private Sub AréasDeLazerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AréasDeLazerToolStripMenuItem.Click
        Dim fomr = New frmAreasLazer()
        fomr.ShowDialog()
    End Sub

    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    'Chamando os utilitários
    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '
    Private Sub BlocoDeNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlocoDeNotasToolStripMenuItem.Click
        System.Diagnostics.Process.Start("notepad.exe")
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        System.Diagnostics.Process.Start("calc.exe")
    End Sub

    Private Sub ExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcelToolStripMenuItem.Click
        System.Diagnostics.Process.Start("excel.exe")
    End Sub

    Private Sub MapaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MapaToolStripMenuItem.Click
        Dim form = New frmMapa()
        form.ShowDialog()
    End Sub

    Private Sub WordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordToolStripMenuItem.Click
        System.Diagnostics.Process.Start("winword.exe")
    End Sub

    'Private Sub TesteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TesteToolStripMenuItem.Click
    '    Dim form = New frmTeste()
    '    form.ShowDialog()
    'End Sub












    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '


    '
    '       -----------       -----------       -----------       -----------       -----------       -----------
    '



End Class