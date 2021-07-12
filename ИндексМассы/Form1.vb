Public Class Form1

    Private Sub Txtheight_ValueChanged(sender As Object, e As EventArgs) Handles Txtheight.ValueChanged
        Dim w As Single
        Dim h As Single
        Dim ind As Single


        w = Val(Txtweight.Text)
        h = Val(Txtheight.Text)
        ind = w / (h / 100) ^ 2

        If h > 255 Then
            MsgBox("Введите реальные данные не более 255 кг")
        End If
        If w > 255 Then
            MsgBox("Введите реальные данные не более 255 см")
        End If

        lblindex.Text = "Индекс вашего тела: " & ind

        If ind > 18.5 And ind < 24.99 Then
            lblconformity.Text = "Ваш вес в норме"
            lblrecommend.Text = ""
        ElseIf ind > 24.99 And ind < 29.99 Then
            lblconformity.Text = "Избыточная масса тела (предожирение)"
            lblrecommend.Text = "Необходима консультация специалиста"
        ElseIf ind > 30 And ind < 34.99 Then
            lblconformity.Text = "Ожирение первой степени"
            lblrecommend.Text = "Необходима консультация специалиста"
        ElseIf ind > 35 And ind < 39.99 Then
            lblconformity.Text = "Ожирение второй степени"
            lblrecommend.Text = "Необходима консультация специалиста"
        ElseIf ind > 40 Then
            MsgBox("Ожирение третьей степени (морбидное)! Необходима срочная консультация специалиста!!!", vbCritical)

        ElseIf ind > 16 And ind < 18.49 Then
            lblconformity.Text = "Недостаточная (дефицит) масса тела"
            lblrecommend.Text = "Необходима консультация специалиста"

        ElseIf ind < 15.99 Then
            MsgBox("Выраженный дефицит массы тела! Необходима срочная консультация специалиста!", vbCritical)

        ElseIf w = 0 Or h = 0 Then
            MsgBox("Введите данные")
        End If
    End Sub


    'Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
    '    If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
    '        SendKeys.Send("{Tab}")
    '        Return True
    '    End If
    '    Return MyBase.ProcessCmdKey(msg, keyData)
    'End Function

End Class
