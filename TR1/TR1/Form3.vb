Public Class Form3

    Dim question As String() = {"リンゴ", "学校", "鉛筆", "机", "鞄"}
    Dim answer As String() = {"apple", "school", "pencil", "desk", "bag"}

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim count As Integer = 1

        '初期値
        lblCount.Text = count.ToString
        lblQuestion.Text = question(count - 1)
        txtAnswer.Text = ""
        lblAnswer.Text = answer(count - 1)
        lblGood.Text = ""

        '表示 非表示
        lblAnswer.Visible = False
        lblGood.Visible = False

        '使用可否
        If count = 1 Then
            btnBefore.Enabled = False
        Else
            btnBefore.Enabled = True
        End If

        If count = 10 Then
            btnNext.Enabled = False
        Else
            btnNext.Enabled = True
        End If


    End Sub

    Private Sub BtnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click

        lblGood.ForeColor = Color.Red

        '正解判定
        If txtAnswer.Text = lblAnswer.Text Then
            lblGood.Text = "〇"
        Else
            lblGood.Text = "×"
        End If

        '表示 非表示
        lblAnswer.Visible = True
        lblGood.Visible = True

    End Sub

    Private Sub BtnBefore_Click(sender As Object, e As EventArgs) Handles btnBefore.Click

        Dim count As Integer = CInt(lblCount.Text) - 1

        '初期値
        lblCount.Text = count.ToString
        lblQuestion.Text = question(count - 1)
        txtAnswer.Text = ""
        lblAnswer.Text = answer(count - 1)
        lblGood.Text = ""

        '表示 非表示
        lblAnswer.Visible = False
        lblGood.Visible = False

        '使用可否
        If count = 1 Then
            btnBefore.Enabled = False
        Else
            btnBefore.Enabled = True
        End If

        If count = 5 Then
            btnNext.Enabled = False
        Else
            btnNext.Enabled = True
        End If


    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        Dim count As Integer = CInt(lblCount.Text) + 1

        '初期値
        lblCount.Text = count.ToString
        lblQuestion.Text = question(count - 1)
        txtAnswer.Text = ""
        lblAnswer.Text = answer(count - 1)
        lblGood.Text = ""

        '表示 非表示
        lblAnswer.Visible = False
        lblGood.Visible = False

        '使用可否
        If count = 1 Then
            btnBefore.Enabled = False
        Else
            btnBefore.Enabled = True
        End If

        If count = 5 Then
            btnNext.Enabled = False
        Else
            btnNext.Enabled = True
        End If


    End Sub

End Class