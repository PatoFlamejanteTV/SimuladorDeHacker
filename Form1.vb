Public Class Form1

    Dim dinheiro As Double = 10 'começa no zero
    Dim pacoca As Integer = 0 'começa no zero


    Function UpdateValue() As String
        money.ForeColor = Color.Black
        money.Text = "$" & dinheiro
        '                       |_>$1

        Labelpacoca.Text = "$" & pacoca
    End Function

    Function SemDinheiro() As String
        Dim oldcolor As Color
        oldcolor = money.ForeColor '"backup"
        money.ForeColor = Color.Crimson
        money.ForeColor = oldcolor
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'nada d+

        UpdateValue()
        ' coloquei isso no começo por que ele não mudava pra 0
        'no começo do jogo, só mostrava o valor padrão "money"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles VenderPacoca.Click
        'VENDER PAÇOCA
        dinheiro += 1
        pacoca -= 1
        UpdateValue()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BuyPacoca.Click
        'COMPRAR PAÇOCA
        If dinheiro >= 0.7 Then 'maior ou igual
            dinheiro -= 0.7
            pacoca += 1
            UpdateValue()
        Else 'caso ao contrário
            'MessageBox.Show("Sem dinheiro :(")
            SemDinheiro() 'animação que deixa no dinheiro vermelho
        End If

    End Sub
End Class
