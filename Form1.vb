Public Class Form1

    Dim dinheiro As Double = 10
    Dim pacoca As Integer = 0
    Dim valorinflacao As Double = 1.1

    Dim pacocavalor As Integer = 0.7



    Function UpdateValue() As String
        money.ForeColor = Color.Black
        money.Text = "$" & dinheiro
        '                       |_>$1

        Labelpacoca.Text = "$" & pacoca

        valorinflacao *= 1.1
        BuyPacoca.Text = "Comprar paçoca
(-R$" & pacocavalor + valorinflacao & ")"
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'nada d+

        UpdateValue()
        ' coloquei isso no começo por que ele não mudava pra 0
        'no começo do jogo, só mostrava o valor padrão "money"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles VenderPacoca.Click
        'VENDER PAÇOCA
        dinheiro += 1 - valorinflacao
        pacoca -= 1
        UpdateValue()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BuyPacoca.Click
        'COMPRAR PAÇOCA
        If dinheiro >= pacocavalor + valorinflacao Then 'maior ou igual
            dinheiro -= (pacocavalor + valorinflacao)
            pacoca += 1
            UpdateValue()
        Else 'caso ao contrário
            MessageBox.Show("Sem dinheiro :(")
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles inflacao.Click
        MessageBox.Show("Inflação atual, infelizmente vai te atrapalhar em sua jornada...")
    End Sub
End Class
