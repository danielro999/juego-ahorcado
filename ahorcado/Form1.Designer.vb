<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TBplabra = New System.Windows.Forms.TextBox()
        Me.BTsalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBletra = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblenuso = New System.Windows.Forms.Label()
        Me.LbLtituloletrasusada = New System.Windows.Forms.Label()
        Me.TBplayer1 = New System.Windows.Forms.TextBox()
        Me.TBplayer2 = New System.Windows.Forms.TextBox()
        Me.LBtitulopuntos = New System.Windows.Forms.Label()
        Me.LBpuntos1 = New System.Windows.Forms.Label()
        Me.LBpuntos2 = New System.Windows.Forms.Label()
        Me.LBturno1 = New System.Windows.Forms.Label()
        Me.LBturno2 = New System.Windows.Forms.Label()
        Me.BtDificultad = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBplabra
        '
        Me.TBplabra.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TBplabra.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBplabra.Location = New System.Drawing.Point(213, 12)
        Me.TBplabra.Name = "TBplabra"
        Me.TBplabra.Size = New System.Drawing.Size(705, 62)
        Me.TBplabra.TabIndex = 0
        '
        'BTsalir
        '
        Me.BTsalir.Location = New System.Drawing.Point(38, 551)
        Me.BTsalir.Name = "BTsalir"
        Me.BTsalir.Size = New System.Drawing.Size(218, 60)
        Me.BTsalir.TabIndex = 1
        Me.BTsalir.Text = "salir"
        Me.BTsalir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(154, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 42)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Lb"
        Me.Label2.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(128, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Letras"
        '
        'TBletra
        '
        Me.TBletra.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TBletra.Font = New System.Drawing.Font("Microsoft JhengHei UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBletra.Location = New System.Drawing.Point(217, 104)
        Me.TBletra.MaxLength = 1
        Me.TBletra.Name = "TBletra"
        Me.TBletra.Size = New System.Drawing.Size(70, 89)
        Me.TBletra.TabIndex = 2
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "00.png")
        Me.ImageList1.Images.SetKeyName(1, "01.png")
        Me.ImageList1.Images.SetKeyName(2, "02.png")
        Me.ImageList1.Images.SetKeyName(3, "03.png")
        Me.ImageList1.Images.SetKeyName(4, "04.png")
        Me.ImageList1.Images.SetKeyName(5, "05.png")
        Me.ImageList1.Images.SetKeyName(6, "06.png")
        Me.ImageList1.Images.SetKeyName(7, "07.png")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(708, 166)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(237, 503)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Location = New System.Drawing.Point(996, 425)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(277, 257)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "00.png")
        Me.ImageList2.Images.SetKeyName(1, "desacierto.png")
        Me.ImageList2.Images.SetKeyName(2, "sorpresa.gif")
        Me.ImageList2.Images.SetKeyName(3, "desacierto2.png")
        Me.ImageList2.Images.SetKeyName(4, "asustado4.png")
        Me.ImageList2.Images.SetKeyName(5, "asustado3.png")
        Me.ImageList2.Images.SetKeyName(6, "asustado.png")
        Me.ImageList2.Images.SetKeyName(7, "asustado2.png")
        '
        'ImageList3
        '
        Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList3.Images.SetKeyName(0, "00.gif")
        Me.ImageList3.Images.SetKeyName(1, "victoria.png")
        Me.ImageList3.Images.SetKeyName(2, "victoria01.png")
        Me.ImageList3.Images.SetKeyName(3, "victoria03.png")
        Me.ImageList3.Images.SetKeyName(4, "victoria04.png")
        Me.ImageList3.Images.SetKeyName(5, "victoria05.png")
        Me.ImageList3.Images.SetKeyName(6, "victoria06.png")
        Me.ImageList3.Images.SetKeyName(7, "victoria07.png")
        Me.ImageList3.Images.SetKeyName(8, "victoria08.png")
        Me.ImageList3.Images.SetKeyName(9, "victoria09.png")
        Me.ImageList3.Images.SetKeyName(10, "sorpresa.gif")
        Me.ImageList3.Images.SetKeyName(11, "victoria01.png")
        Me.ImageList3.Images.SetKeyName(12, "victoria03.png")
        Me.ImageList3.Images.SetKeyName(13, "victoria04.png")
        Me.ImageList3.Images.SetKeyName(14, "victoria05.png")
        Me.ImageList3.Images.SetKeyName(15, "victoria06.png")
        Me.ImageList3.Images.SetKeyName(16, "victoria07.png")
        Me.ImageList3.Images.SetKeyName(17, "victoria09.png")
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1105, 43)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Reinicio"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Location = New System.Drawing.Point(432, 412)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(287, 270)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'lblenuso
        '
        Me.lblenuso.AutoSize = True
        Me.lblenuso.BackColor = System.Drawing.Color.Transparent
        Me.lblenuso.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblenuso.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblenuso.ForeColor = System.Drawing.Color.Black
        Me.lblenuso.Location = New System.Drawing.Point(334, 147)
        Me.lblenuso.Name = "lblenuso"
        Me.lblenuso.Size = New System.Drawing.Size(26, 39)
        Me.lblenuso.TabIndex = 13
        Me.lblenuso.Text = " "
        '
        'LbLtituloletrasusada
        '
        Me.LbLtituloletrasusada.AutoSize = True
        Me.LbLtituloletrasusada.BackColor = System.Drawing.Color.Transparent
        Me.LbLtituloletrasusada.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLtituloletrasusada.ForeColor = System.Drawing.Color.Black
        Me.LbLtituloletrasusada.Location = New System.Drawing.Point(334, 92)
        Me.LbLtituloletrasusada.Name = "LbLtituloletrasusada"
        Me.LbLtituloletrasusada.Size = New System.Drawing.Size(248, 39)
        Me.LbLtituloletrasusada.TabIndex = 14
        Me.LbLtituloletrasusada.Text = "Letras usadas"
        '
        'TBplayer1
        '
        Me.TBplayer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TBplayer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBplayer1.Location = New System.Drawing.Point(51, 363)
        Me.TBplayer1.Name = "TBplayer1"
        Me.TBplayer1.Size = New System.Drawing.Size(163, 29)
        Me.TBplayer1.TabIndex = 3
        Me.TBplayer1.Text = "Jugador 1"
        '
        'TBplayer2
        '
        Me.TBplayer2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TBplayer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBplayer2.Location = New System.Drawing.Point(304, 363)
        Me.TBplayer2.Name = "TBplayer2"
        Me.TBplayer2.Size = New System.Drawing.Size(163, 29)
        Me.TBplayer2.TabIndex = 4
        Me.TBplayer2.Text = "Jugador 2"
        '
        'LBtitulopuntos
        '
        Me.LBtitulopuntos.AutoSize = True
        Me.LBtitulopuntos.BackColor = System.Drawing.Color.Transparent
        Me.LBtitulopuntos.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBtitulopuntos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBtitulopuntos.Location = New System.Drawing.Point(168, 234)
        Me.LBtitulopuntos.Name = "LBtitulopuntos"
        Me.LBtitulopuntos.Size = New System.Drawing.Size(162, 60)
        Me.LBtitulopuntos.TabIndex = 19
        Me.LBtitulopuntos.Text = "Puntos"
        '
        'LBpuntos1
        '
        Me.LBpuntos1.AutoSize = True
        Me.LBpuntos1.BackColor = System.Drawing.Color.Transparent
        Me.LBpuntos1.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBpuntos1.ForeColor = System.Drawing.Color.Black
        Me.LBpuntos1.Location = New System.Drawing.Point(90, 218)
        Me.LBpuntos1.Name = "LBpuntos1"
        Me.LBpuntos1.Size = New System.Drawing.Size(68, 80)
        Me.LBpuntos1.TabIndex = 20
        Me.LBpuntos1.Text = "0"
        '
        'LBpuntos2
        '
        Me.LBpuntos2.AutoSize = True
        Me.LBpuntos2.BackColor = System.Drawing.Color.Transparent
        Me.LBpuntos2.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBpuntos2.ForeColor = System.Drawing.Color.Black
        Me.LBpuntos2.Location = New System.Drawing.Point(343, 218)
        Me.LBpuntos2.Name = "LBpuntos2"
        Me.LBpuntos2.Size = New System.Drawing.Size(68, 80)
        Me.LBpuntos2.TabIndex = 21
        Me.LBpuntos2.Text = "0"
        '
        'LBturno1
        '
        Me.LBturno1.AutoSize = True
        Me.LBturno1.BackColor = System.Drawing.Color.Transparent
        Me.LBturno1.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBturno1.ForeColor = System.Drawing.Color.Blue
        Me.LBturno1.Location = New System.Drawing.Point(32, 312)
        Me.LBturno1.Name = "LBturno1"
        Me.LBturno1.Size = New System.Drawing.Size(200, 34)
        Me.LBturno1.TabIndex = 22
        Me.LBturno1.Text = "Adivinar palabra"
        '
        'LBturno2
        '
        Me.LBturno2.AutoSize = True
        Me.LBturno2.BackColor = System.Drawing.Color.Transparent
        Me.LBturno2.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBturno2.ForeColor = System.Drawing.Color.Red
        Me.LBturno2.Location = New System.Drawing.Point(289, 312)
        Me.LBturno2.Name = "LBturno2"
        Me.LBturno2.Size = New System.Drawing.Size(192, 34)
        Me.LBturno2.TabIndex = 22
        Me.LBturno2.Text = "Escribir palabra"
        '
        'BtDificultad
        '
        Me.BtDificultad.Location = New System.Drawing.Point(38, 43)
        Me.BtDificultad.Name = "BtDificultad"
        Me.BtDificultad.Size = New System.Drawing.Size(75, 23)
        Me.BtDificultad.TabIndex = 23
        Me.BtDificultad.Text = "Dificultad"
        Me.BtDificultad.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtDificultad)
        Me.Controls.Add(Me.LBturno2)
        Me.Controls.Add(Me.LBturno1)
        Me.Controls.Add(Me.LBpuntos2)
        Me.Controls.Add(Me.LBpuntos1)
        Me.Controls.Add(Me.LBtitulopuntos)
        Me.Controls.Add(Me.TBplayer2)
        Me.Controls.Add(Me.TBplayer1)
        Me.Controls.Add(Me.LbLtituloletrasusada)
        Me.Controls.Add(Me.lblenuso)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TBletra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTsalir)
        Me.Controls.Add(Me.TBplabra)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.Text = "Ahorcado"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBplabra As TextBox
    Friend WithEvents BTsalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TBletra As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents ImageList3 As ImageList
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblenuso As Label
    Friend WithEvents LbLtituloletrasusada As Label
    Friend WithEvents TBplayer1 As TextBox
    Friend WithEvents TBplayer2 As TextBox
    Friend WithEvents LBtitulopuntos As Label
    Friend WithEvents LBpuntos1 As Label
    Friend WithEvents LBpuntos2 As Label
    Friend WithEvents LBturno1 As Label
    Friend WithEvents LBturno2 As Label
    Friend WithEvents BtDificultad As Button
End Class
