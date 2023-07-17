Public Class Form2

    Public Sub ChBxOcultReper_CheckedChanged(sender As Object, e As EventArgs) Handles CBOcultReper.CheckedChanged
        If CBOcultReper.Checked = True Then
            Form1.lblenuso.Hide()
            Form1.LbLtituloletrasusada.Hide()
        Else
            Form1.lblenuso.Show()
            Form1.LbLtituloletrasusada.Show()
        End If

    End Sub

    Private Sub CLBNivelErradas_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CLBNivelErradas.ItemCheck
        If e.NewValue = CheckState.Checked Then
            For i As Integer = 0 To Me.CLBNivelErradas.Items.Count - 1 Step 1
                If i <> e.Index Then
                    Me.CLBNivelErradas.SetItemChecked(i, False)
                End If
            Next i
        End If
    End Sub

    Private Sub CLBNivelErradas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CLBNivelErradas.SelectedIndexChanged
        If CLBNivelErradas.GetItemChecked(1) = True Then
            Form1.contadorfalse = 2
            Form1.contadorfalse2 = 2
        ElseIf CLBNivelErradas.GetItemChecked(2) = True Then
            Form1.contadorfalse = 4
            Form1.contadorfalse2 = 4
        ElseIf CLBNivelErradas.GetItemChecked(0) = True Then
            Form1.contadorfalse = 0
            Form1.contadorfalse2 = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Form1.Show()
        Form1.TBplabra.Focus()

    End Sub


End Class