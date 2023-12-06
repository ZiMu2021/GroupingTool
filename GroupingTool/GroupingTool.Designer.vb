<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GroupingTool
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        B_Group = New Button()
        L_InputName = New Label()
        TB_InputName = New RichTextBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label2 = New Label()
        TB_Num = New TextBox()
        Label1 = New Label()
        B_Clear = New Button()
        Panel3 = New Panel()
        TB_Group5 = New RichTextBox()
        TB_Group4 = New RichTextBox()
        TB_Group3 = New RichTextBox()
        TB_Group2 = New RichTextBox()
        TB_Group1 = New RichTextBox()
        L_Group5 = New Label()
        L_Group4 = New Label()
        L_Group3 = New Label()
        L_Group2 = New Label()
        L_Group1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' B_Group
        ' 
        B_Group.FlatStyle = FlatStyle.Flat
        B_Group.Font = New Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point)
        B_Group.Location = New Point(1617, 390)
        B_Group.Margin = New Padding(5)
        B_Group.Name = "B_Group"
        B_Group.Size = New Size(200, 55)
        B_Group.TabIndex = 6
        B_Group.Text = "随机分组"
        B_Group.UseVisualStyleBackColor = True
        ' 
        ' L_InputName
        ' 
        L_InputName.AutoSize = True
        L_InputName.Font = New Font("微软雅黑", 10.5F, FontStyle.Regular, GraphicsUnit.Point)
        L_InputName.Location = New Point(40, 40)
        L_InputName.Margin = New Padding(5, 0, 5, 0)
        L_InputName.Name = "L_InputName"
        L_InputName.Size = New Size(390, 28)
        L_InputName.TabIndex = 1
        L_InputName.Text = "请在下面输入名字，并以空格进行分割。"
        ' 
        ' TB_InputName
        ' 
        TB_InputName.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TB_InputName.Location = New Point(40, 80)
        TB_InputName.Margin = New Padding(5)
        TB_InputName.Name = "TB_InputName"
        TB_InputName.Size = New Size(1780, 300)
        TB_InputName.TabIndex = 2
        TB_InputName.Text = ""
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel3)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1848, 1021)
        Panel1.TabIndex = 5
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(TB_Num)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(B_Group)
        Panel2.Controls.Add(L_InputName)
        Panel2.Controls.Add(TB_InputName)
        Panel2.Controls.Add(B_Clear)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1848, 458)
        Panel2.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(181, 405)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(192, 31)
        Label2.TabIndex = 5
        Label2.Text = "组    (最大输入5)"
        ' 
        ' TB_Num
        ' 
        TB_Num.Font = New Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TB_Num.ImeMode = ImeMode.Disable
        TB_Num.Location = New Point(125, 406)
        TB_Num.MaxLength = 1
        TB_Num.Name = "TB_Num"
        TB_Num.Size = New Size(48, 39)
        TB_Num.TabIndex = 4
        TB_Num.TextAlign = HorizontalAlignment.Center
        TB_Num.WordWrap = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(40, 405)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 31)
        Label1.TabIndex = 3
        Label1.Text = "想分为"
        ' 
        ' B_Clear
        ' 
        B_Clear.FlatStyle = FlatStyle.Flat
        B_Clear.Font = New Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point)
        B_Clear.Location = New Point(1617, 13)
        B_Clear.Margin = New Padding(5)
        B_Clear.Name = "B_Clear"
        B_Clear.Size = New Size(200, 55)
        B_Clear.TabIndex = 18
        B_Clear.Text = "清空数据"
        B_Clear.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(TB_Group5)
        Panel3.Controls.Add(TB_Group4)
        Panel3.Controls.Add(TB_Group3)
        Panel3.Controls.Add(TB_Group2)
        Panel3.Controls.Add(TB_Group1)
        Panel3.Controls.Add(L_Group5)
        Panel3.Controls.Add(L_Group4)
        Panel3.Controls.Add(L_Group3)
        Panel3.Controls.Add(L_Group2)
        Panel3.Controls.Add(L_Group1)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 458)
        Panel3.Margin = New Padding(5)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1848, 563)
        Panel3.TabIndex = 8
        Panel3.Visible = False
        ' 
        ' TB_Group5
        ' 
        TB_Group5.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Group5.Location = New Point(125, 380)
        TB_Group5.Margin = New Padding(5)
        TB_Group5.Name = "TB_Group5"
        TB_Group5.ReadOnly = True
        TB_Group5.Size = New Size(1698, 82)
        TB_Group5.TabIndex = 16
        TB_Group5.Text = ""
        TB_Group5.Visible = False
        ' 
        ' TB_Group4
        ' 
        TB_Group4.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Group4.Location = New Point(125, 290)
        TB_Group4.Margin = New Padding(5)
        TB_Group4.Name = "TB_Group4"
        TB_Group4.ReadOnly = True
        TB_Group4.Size = New Size(1698, 82)
        TB_Group4.TabIndex = 14
        TB_Group4.Text = ""
        TB_Group4.Visible = False
        ' 
        ' TB_Group3
        ' 
        TB_Group3.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Group3.Location = New Point(125, 200)
        TB_Group3.Margin = New Padding(5)
        TB_Group3.Name = "TB_Group3"
        TB_Group3.ReadOnly = True
        TB_Group3.Size = New Size(1698, 82)
        TB_Group3.TabIndex = 12
        TB_Group3.Text = ""
        TB_Group3.Visible = False
        ' 
        ' TB_Group2
        ' 
        TB_Group2.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Group2.Location = New Point(125, 110)
        TB_Group2.Margin = New Padding(5)
        TB_Group2.Name = "TB_Group2"
        TB_Group2.ReadOnly = True
        TB_Group2.Size = New Size(1698, 80)
        TB_Group2.TabIndex = 10
        TB_Group2.Text = ""
        TB_Group2.Visible = False
        ' 
        ' TB_Group1
        ' 
        TB_Group1.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Group1.Location = New Point(125, 20)
        TB_Group1.Margin = New Padding(5)
        TB_Group1.Name = "TB_Group1"
        TB_Group1.ReadOnly = True
        TB_Group1.Size = New Size(1698, 80)
        TB_Group1.TabIndex = 8
        TB_Group1.Text = ""
        TB_Group1.Visible = False
        ' 
        ' L_Group5
        ' 
        L_Group5.AutoSize = True
        L_Group5.Font = New Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point)
        L_Group5.Location = New Point(40, 380)
        L_Group5.Margin = New Padding(5, 0, 5, 0)
        L_Group5.Name = "L_Group5"
        L_Group5.Size = New Size(77, 31)
        L_Group5.TabIndex = 15
        L_Group5.Text = "第5组"
        L_Group5.Visible = False
        ' 
        ' L_Group4
        ' 
        L_Group4.AutoSize = True
        L_Group4.Font = New Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point)
        L_Group4.Location = New Point(40, 290)
        L_Group4.Margin = New Padding(5, 0, 5, 0)
        L_Group4.Name = "L_Group4"
        L_Group4.Size = New Size(77, 31)
        L_Group4.TabIndex = 13
        L_Group4.Text = "第4组"
        L_Group4.Visible = False
        ' 
        ' L_Group3
        ' 
        L_Group3.AutoSize = True
        L_Group3.Font = New Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point)
        L_Group3.Location = New Point(40, 200)
        L_Group3.Margin = New Padding(5, 0, 5, 0)
        L_Group3.Name = "L_Group3"
        L_Group3.Size = New Size(77, 31)
        L_Group3.TabIndex = 11
        L_Group3.Text = "第3组"
        L_Group3.Visible = False
        ' 
        ' L_Group2
        ' 
        L_Group2.AutoSize = True
        L_Group2.Font = New Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point)
        L_Group2.Location = New Point(40, 110)
        L_Group2.Margin = New Padding(5, 0, 5, 0)
        L_Group2.Name = "L_Group2"
        L_Group2.Size = New Size(77, 31)
        L_Group2.TabIndex = 9
        L_Group2.Text = "第2组"
        L_Group2.Visible = False
        ' 
        ' L_Group1
        ' 
        L_Group1.AutoSize = True
        L_Group1.Font = New Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point)
        L_Group1.Location = New Point(40, 20)
        L_Group1.Margin = New Padding(5, 0, 5, 0)
        L_Group1.Name = "L_Group1"
        L_Group1.Size = New Size(77, 31)
        L_Group1.TabIndex = 7
        L_Group1.Text = "第1组"
        L_Group1.Visible = False
        ' 
        ' GroupingTool
        ' 
        AutoScaleDimensions = New SizeF(11F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1848, 1021)
        Controls.Add(Panel1)
        Margin = New Padding(5)
        MaximizeBox = False
        Name = "GroupingTool"
        Text = "GroupingTool"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents B_Group As Button
    Friend WithEvents L_InputName As Label
    Friend WithEvents TB_InputName As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents B_Clear As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents L_Group5 As Label
    Friend WithEvents L_Group4 As Label
    Friend WithEvents L_Group3 As Label
    Friend WithEvents L_Group2 As Label
    Friend WithEvents L_Group1 As Label
    Friend WithEvents TB_Group1 As RichTextBox
    Friend WithEvents TB_Group4 As RichTextBox
    Friend WithEvents TB_Group3 As RichTextBox
    Friend WithEvents TB_Group2 As RichTextBox
    Friend WithEvents TB_Group5 As RichTextBox
    Friend WithEvents TB_Num As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
