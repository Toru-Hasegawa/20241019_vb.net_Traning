<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        lblCount = New Label()
        Label3 = New Label()
        lblQuestion = New Label()
        lblAnswer = New Label()
        lblGood = New Label()
        btnAnswer = New Button()
        btnBefore = New Button()
        btnNext = New Button()
        txtAnswer = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI", 15F)
        Label1.Location = New Point(23, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 41)
        Label1.TabIndex = 0
        Label1.Text = "第"
        ' 
        ' lblCount
        ' 
        lblCount.AutoSize = True
        lblCount.Font = New Font("Yu Gothic UI", 15F)
        lblCount.Location = New Point(77, 32)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(131, 41)
        lblCount.TabIndex = 1
        lblCount.Text = "lblCount"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic UI", 15F)
        Label3.Location = New Point(117, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 41)
        Label3.TabIndex = 2
        Label3.Text = "問"
        ' 
        ' lblQuestion
        ' 
        lblQuestion.AutoSize = True
        lblQuestion.Location = New Point(115, 99)
        lblQuestion.Name = "lblQuestion"
        lblQuestion.Size = New Size(103, 25)
        lblQuestion.TabIndex = 3
        lblQuestion.Text = "lblQuestion"
        ' 
        ' lblAnswer
        ' 
        lblAnswer.AutoSize = True
        lblAnswer.Location = New Point(340, 200)
        lblAnswer.Name = "lblAnswer"
        lblAnswer.Size = New Size(89, 25)
        lblAnswer.TabIndex = 4
        lblAnswer.Text = "lblAnswer"
        ' 
        ' lblGood
        ' 
        lblGood.AutoSize = True
        lblGood.Location = New Point(527, 198)
        lblGood.Name = "lblGood"
        lblGood.Size = New Size(76, 25)
        lblGood.TabIndex = 5
        lblGood.Text = "lblGood"
        ' 
        ' btnAnswer
        ' 
        btnAnswer.Location = New Point(117, 193)
        btnAnswer.Name = "btnAnswer"
        btnAnswer.Size = New Size(112, 34)
        btnAnswer.TabIndex = 6
        btnAnswer.Text = "答え"
        btnAnswer.UseVisualStyleBackColor = True
        ' 
        ' btnBefore
        ' 
        btnBefore.Location = New Point(169, 342)
        btnBefore.Name = "btnBefore"
        btnBefore.Size = New Size(112, 34)
        btnBefore.TabIndex = 7
        btnBefore.Text = "前の問題"
        btnBefore.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(514, 346)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(112, 34)
        btnNext.TabIndex = 8
        btnNext.Text = "次の問題"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' txtAnswer
        ' 
        txtAnswer.Location = New Point(305, 96)
        txtAnswer.Name = "txtAnswer"
        txtAnswer.Size = New Size(150, 31)
        txtAnswer.TabIndex = 9
        txtAnswer.Text = "txtAnswer"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtAnswer)
        Controls.Add(btnNext)
        Controls.Add(btnBefore)
        Controls.Add(btnAnswer)
        Controls.Add(lblGood)
        Controls.Add(lblAnswer)
        Controls.Add(lblQuestion)
        Controls.Add(Label3)
        Controls.Add(lblCount)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblQuestion As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents lblGood As Label
    Friend WithEvents btnAnswer As Button
    Friend WithEvents btnBefore As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtAnswer As TextBox
End Class
