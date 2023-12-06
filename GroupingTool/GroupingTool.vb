Imports System.Text

Public Class GroupingTool
    Private dt_GroupData As New DataTable

    Private Sub GroupingTool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 初始化DataTable
        InitDataTable(dt_GroupData)
    End Sub

    ''' <summary>
    ''' 随机分组
    ''' </summary>
    Private Sub B_Group_Click(sender As Object, e As EventArgs) Handles B_Group.Click

        InitControls(False)
        ' 分组数
        Dim groupNum As Integer
        If Fn_InputCheck(groupNum) = False Then Exit Sub

        dt_GroupData.Clear()

        ' 将人名拆分为单个名字
        Dim names As String() = TB_InputName.Text.Replace(vbLf, " ").Split(" ", StringSplitOptions.RemoveEmptyEntries)

        ' 生成不重复随机数,生成不重复随机数,并将随机数与人名存入DataTable
        Fn_GetRandomSequence(names.Length, names.Length, names)

        dt_GroupData.DefaultView.Sort = "random ASC"
        dt_GroupData = dt_GroupData.DefaultView.ToTable

        Dim groupPeopleNum As Integer = If(Int(names.Length / groupNum) = 0, 1, Int(names.Length / groupNum)) '每组平均分配的人数
        Dim remainder As Integer = names.Length Mod groupNum '平均分配后的人数
        Dim groupIndex As Integer = 1
        Dim index As Integer = 1

        ' 随机平均分配人名给小组
        If remainder > 0 Then
            Dim randoms As Integer() = Fn_GetRandomSequence(groupNum, remainder)
            For i As Integer = 0 To remainder - 1
                dt_GroupData.Rows(i).Item("groupNum") = randoms(i)
            Next
        End If

        For i As Integer = 0 + remainder To names.Length - 1
            If index > groupPeopleNum Then
                groupIndex += 1
                index = 1
            End If
            dt_GroupData.Rows(i).Item("groupNum") = groupIndex
            index += 1
        Next

        ShowGroupData()

    End Sub

    Private Sub B_Clear_Click(sender As Object, e As EventArgs) Handles B_Clear.Click
        InitControls()
    End Sub

    ''' <summary>
    ''' 输入验证
    ''' </summary>
    ''' <returns>True:输入验证通过</returns>
    Private Function Fn_InputCheck(ByRef groupNum As Integer) As Boolean
        ' 分组数输入验证
        If TB_Num.Text = String.Empty OrElse Integer.TryParse(TB_Num.Text, groupNum) = False OrElse groupNum > 5 Then
            MessageBox.Show("分组数输入不正确，请重新输入。", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            TB_Num.Focus()
            TB_Num.SelectAll()
            Return False
        End If

        ' 分组的名字验证
        If TB_InputName.Text.Trim = String.Empty Then
            MessageBox.Show("没有输入需要分组的名字，请重新输入。", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            TB_InputName.Focus()
            TB_Num.SelectAll()
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' 生成不重复随机数,并将随机数与人名存入DataTable
    ''' </summary>
    ''' <param name="maxRandom">最大的随机数</param>
    ''' <param name="randomCount">需要生成几个随机数</param>
    ''' <param name="names">人名的List</param>
    ''' <returns></returns>
    Private Function Fn_GetRandomSequence(maxRandom As Integer, randomCount As Integer, Optional names As String() = Nothing) As Integer()

        Dim sequence As Integer() = New Integer(maxRandom - 1) {}
        Dim output As Integer() = New Integer(randomCount - 1) {}

        For i As Integer = 0 To maxRandom - 1
            sequence(i) = i
        Next

        Dim random As Random = New Random()
        Dim _End As Integer = maxRandom - 1
        Dim num As Integer

        Dim DtRow As DataRow
        '从N个数中随机取出一个数，与数组第N个数调换；
        '代码通过 _End-1，把生成过的数用最后一个数代替，省去删除移动的开销。
        For i As Integer = 0 To randomCount - 1
            num = random.[Next](1, _End + 1)

            If names IsNot Nothing Then
                DtRow = dt_GroupData.NewRow()
                DtRow("name") = names(i)
                DtRow("random") = sequence(num)
                dt_GroupData.Rows.Add(DtRow)
            Else
                output(i) = sequence(num)
            End If

            sequence(num) = sequence(_End)
            _End -= 1

        Next
        Return output
    End Function

    ''' <summary>
    ''' 初始化DataTable
    ''' </summary>
    ''' <param name="table">需要初始化的DataTable</param>
    Private Sub InitDataTable(table As DataTable)
        table.Columns.Add("groupNum", Type.GetType("System.Int32"))
        table.Columns.Add("name")
        table.Columns.Add("random", Type.GetType("System.Int32"))
    End Sub

    Private Sub ShowGroupData()
        Dim lableName As Label
        Dim richTextBoxName As RichTextBox
        Dim value As String = String.Empty

        Panel3.Visible = True
        For i As Integer = 1 To CInt(TB_Num.Text)
            lableName = Panel3.Controls("L_Group" & i.ToString)
            lableName.Visible = True
            richTextBoxName = Panel3.Controls("TB_Group" & i.ToString)
            richTextBoxName.Visible = True

            value = String.Empty
            For Each dr As DataRow In dt_GroupData.Select("groupNum = " & i)
                value += dr("name") & ","
            Next
            richTextBoxName.Text = value.TrimEnd(",")
        Next

    End Sub

    ''' <summary>
    ''' 部分控件隐藏，并清空部分控件的值
    ''' </summary>
    ''' <param name="isAllClear">True:清空所有控件的值</param>
    Private Sub InitControls(Optional isAllClear As Boolean = True)

        If isAllClear Then
            TB_Num.Text = String.Empty
            TB_InputName.Text = String.Empty
        End If

        Panel3.Visible = False

        TB_Group1.Text = String.Empty
        TB_Group1.Visible = False
        L_Group1.Visible = False

        TB_Group2.Text = String.Empty
        TB_Group2.Visible = False
        L_Group2.Visible = False

        TB_Group3.Text = String.Empty
        TB_Group3.Visible = False
        L_Group3.Visible = False

        TB_Group4.Text = String.Empty
        TB_Group4.Visible = False
        L_Group4.Visible = False

        TB_Group5.Text = String.Empty
        TB_Group5.Visible = False
        L_Group5.Visible = False
    End Sub

End Class
