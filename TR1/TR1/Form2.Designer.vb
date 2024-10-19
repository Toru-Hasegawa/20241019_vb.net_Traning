<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label2 = New Label()
        Button1 = New Button()
        Label3 = New Label()
        Answer = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI", 15F)
        Label1.Location = New Point(242, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(299, 41)
        Label1.TabIndex = 0
        Label1.Text = "実践編  for文の使い方"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic UI", 15F)
        Label2.Location = New Point(95, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(628, 41)
        Label2.TabIndex = 1
        Label2.Text = "1から100までの数字を足した結果を表示してください"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Yu Gothic UI", 15F)
        Button1.Location = New Point(287, 219)
        Button1.Name = "Button1"
        Button1.Size = New Size(170, 61)
        Button1.TabIndex = 2
        Button1.Text = "実行"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic UI", 15F)
        Label3.Location = New Point(172, 347)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 41)
        Label3.TabIndex = 3
        Label3.Text = "答え"
        ' 
        ' Answer
        ' 
        Answer.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Answer.Font = New Font("Yu Gothic UI", 15F)
        Answer.Location = New Point(287, 347)
        Answer.Name = "Answer"
        Answer.RightToLeft = RightToLeft.Yes
        Answer.Size = New Size(150, 47)
        Answer.TabIndex = 4
        Answer.Text = "０"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Yu Gothic UI", 15F)
        Label4.Location = New Point(95, 145)
        Label4.Name = "Label4"
        Label4.Size = New Size(415, 41)
        Label4.TabIndex = 5
        Label4.Text = "ただし80以降は足さないでください"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Answer)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Answer As TextBox
    Friend WithEvents Label4 As Label
End Class
