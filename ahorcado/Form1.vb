Public Class Form1

    Dim cantletras As Integer
    Dim cantletrasfalsas As Integer
    Dim Repetidas As String
    Dim Repetida As String
    Dim contadorTrue As Integer = 0
    Public Property contadorfalse As Integer = 0
    Public Property contadorfalse2 As Integer = 0
    Dim letra As String
    Dim palabra As String
    Dim letras As String
    Dim palabracontrol As String
    Dim relleno As String = "----------------------------------------------------------------------"
    Dim cambiojugador As Boolean = True

    Private Sub TBplabra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBplabra.KeyPress, TBplayer2.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            Call Jugar()
        End If

    End Sub

    Private Sub Jugar()
        palabra = TBplabra.Text
        cantletras = Len(palabra)
        Label2.Show()
        Label4.Show()
        Label2.Text = cantletras

        For x = 1 To cantletras
            palabracontrol = Mid(relleno, 1, x)
        Next
        TBplabra.Text = palabracontrol
        TBletra.Show()
        TBletra.Focus()
    End Sub



    Private Sub TBletra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBletra.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            If TBletra.Text = "" Then
                MsgBox("ingrese una letra")
            Else
                e.Handled = True
                letra = TBletra.Text
                Call Controla()
            End If
        End If
        '  MsgBox("" & cambiojugador & "")
    End Sub

    Sub sonidoacierto()
        My.Computer.Audio.Play(My.Resources.acierto,
        AudioPlayMode.Background)
    End Sub
    Sub sonifofalla()
        My.Computer.Audio.Play(My.Resources.falla,
        AudioPlayMode.Background)
    End Sub

    Private Sub Controla()
        Dim acierto As Boolean

        For x = 1 To cantletras
            Repetidas = Mid(TBplabra.Text, x, 1) ' recorre las letras repetida de las ingresadas
            letras = Mid(palabra, x, 1) 'recorre las letras de la palabra incognita
            If Asc(letra) = Asc(Repetidas) Then 'busca repetidas en las letras acertadas
                MsgBox("nop! letra repetida")
                x = cantletras
                acierto = True
                If Form2.CBPenalidad.Checked Then
                    contadorfalse += 1

                    PictureBox1.Image = ImageList1.Images(contadorfalse)
                    PictureBox2.Image = ImageList2.Images(contadorfalse)
                    PictureBox2.Show()
                    PictureBox3.Hide()
                    Call sonifofalla()
                Else

                End If
            Else
                If Asc(letra) = Asc(letras) Then 'ingresa letra acertada no repetida
                    Mid(TBplabra.Text, x, 1) = letra
                    acierto = True
                    contadorTrue += 1
                    Call sonidoacierto()
                Else
                End If
            End If
        Next

        If acierto Then
            PictureBox3.Image = ImageList3.Images(contadorTrue)
            PictureBox3.Show()
            PictureBox2.Hide()

        Else
            cantletrasfalsas = Len(lblenuso.Text)
            Repetida = InStr(lblenuso.Text, letra)
            For i = 1 To cantletrasfalsas
                If Repetida = i Then 'letra falsa repetida
                    MsgBox("LETRA REPETIDA1")
                    i = cantletrasfalsas
                    If Form2.CBPenalidad.Checked Then
                        contadorfalse += 1
                        Call sonifofalla()
                    Else
                    End If
                ElseIf i = cantletrasfalsas Then 'cuando llega al final de catidad de letras falsas, significa que no encontro repetidas, entonces puede agregarla a letrasusadas
                    lblenuso.Text = lblenuso.Text + letra
                    i = cantletrasfalsas  'exit for
                    contadorfalse += 1
                    Call sonifofalla()
                Else 'nesesario para que haga el cliclo(sin activar nada) mientras no sucesa los if anteriores, sino repertiria letras o carteles.

                End If
            Next
            PictureBox1.Image = ImageList1.Images(contadorfalse)
            PictureBox2.Image = ImageList2.Images(contadorfalse)
            PictureBox2.Show()
            PictureBox3.Hide()
        End If

        If contadorfalse = 7 Then
            If cambiojugador = True Then
                MsgBox("Perdiste!!! la palabra era " + Chr(13) + Chr(10) + "" & palabra & "" + Chr(13) + Chr(10) + "Turno de adivinar " & TBplayer2.Text & "")
                LBturno1.ForeColor = Color.Red
                LBturno2.ForeColor = Color.Blue
                LBturno1.Text = "Escribir palabra"
                LBturno2.Text = "Adivinar palabra"
            Else
                MsgBox("Perdiste!!! la palabra era " + Chr(13) + Chr(10) + "" & palabra & "" + Chr(13) + Chr(10) + "Turno de adivinar " & TBplayer1.Text & "")
                LBturno1.ForeColor = Color.Blue
                LBturno2.ForeColor = Color.Red
                LBturno1.Text = "Adivinar palabra"
                LBturno2.Text = "Escribir palabra"
            End If
            'MsgBox("looser!!!!la palabra era= " & palabra & "")
            TBplabra.Text = ""
            Label2.Text = ""
            lblenuso.Text = " "
            TBletra.Text = ""
            contadorTrue = 0
            contadorfalse = contadorfalse2
            PictureBox1.Image = ImageList1.Images(0)
            PictureBox2.Image = ImageList2.Images(0)
            PictureBox3.Image = ImageList2.Images(0)
            TBplabra.Focus()
            If cambiojugador Then
                cambiojugador = False
            Else
                cambiojugador = True
            End If

        ElseIf cantletras = contadorTrue Then
            'MsgBox("Sos un winner papa!")
            If cambiojugador Then
                MsgBox("Ganaste!!! turno de adivinar " & TBplayer2.Text & "")
                LBturno1.ForeColor = Color.Red
                LBturno2.ForeColor = Color.Blue
                LBturno1.Text = "Escribir palabra"
                LBturno2.Text = "Adivinar palabra"
            Else
                MsgBox("Ganaste!!! turno de adivinar " & TBplayer1.Text & "")
                LBturno1.ForeColor = Color.Blue
                LBturno2.ForeColor = Color.Red
                LBturno1.Text = "Adivinar palabra"
                LBturno2.Text = "Escribir palabra"
            End If
            If cambiojugador Then
                LBpuntos1.Text += 1
            Else
                LBpuntos2.Text += 1
            End If
            TBplabra.Text = ""
            Label2.Text = ""
            lblenuso.Text = " "
            TBletra.Text = ""
            contadorTrue = 0
            contadorfalse = contadorfalse2
            PictureBox1.Image = ImageList1.Images(0)
            PictureBox2.Image = ImageList2.Images(0)
            PictureBox3.Image = ImageList2.Images(0)
            TBplabra.Focus()
            If cambiojugador = True Then
                cambiojugador = False
            Else
                cambiojugador = True
            End If

        End If

        TBletra.Text = ""

        Return

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TBplabra.Text = ""
        Label2.Text = ""
        lblenuso.Text = " "
        contadorTrue = 0
        contadorfalse = 0
        PictureBox1.Image = ImageList1.Images(0)
        PictureBox2.Image = ImageList2.Images(0)
        PictureBox3.Image = ImageList2.Images(0)
        TBplabra.Focus()
        LBpuntos1.Text = 0
        LBpuntos2.Text = 0
        TBplayer1.Text = "Jugador 1"
        TBplayer2.Text = "Jugador 2"
        LBturno1.Text = "Adivinar palabra"
        LBturno2.Text = "Escribir palabra"
        cambiojugador = True
    End Sub

    Private Sub BtDificultad_Click(sender As Object, e As EventArgs) Handles BtDificultad.Click
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTsalir.Click
        End
    End Sub

End Class
