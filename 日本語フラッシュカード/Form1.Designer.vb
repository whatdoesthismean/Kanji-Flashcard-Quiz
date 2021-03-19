<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblKanji = New System.Windows.Forms.Label()
        Me.lblKana = New System.Windows.Forms.Label()
        Me.btnTestKana = New System.Windows.Forms.Button()
        Me.btnTestEng = New System.Windows.Forms.Button()
        Me.lblEng = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtKana = New System.Windows.Forms.TextBox()
        Me.txtEng = New System.Windows.Forms.TextBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.lblTestKanaYes = New System.Windows.Forms.Label()
        Me.lblTestKana = New System.Windows.Forms.Label()
        Me.lblTestEng = New System.Windows.Forms.Label()
        Me.lblTestEngYes = New System.Windows.Forms.Label()
        Me.lblTestKanaNo = New System.Windows.Forms.Label()
        Me.lblTestEngNo = New System.Windows.Forms.Label()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnShowKana = New System.Windows.Forms.Button()
        Me.btnShowEng = New System.Windows.Forms.Button()
        Me.lblIntro1 = New System.Windows.Forms.Label()
        Me.lblIntro2 = New System.Windows.Forms.Label()
        Me.lblIntro3 = New System.Windows.Forms.Label()
        Me.lblIntro4 = New System.Windows.Forms.Label()
        Me.lblIntro5 = New System.Windows.Forms.Label()
        Me.lbxEng = New System.Windows.Forms.ListBox()
        Me.lbxKana = New System.Windows.Forms.ListBox()
        Me.lbxKanji = New System.Windows.Forms.ListBox()
        Me.btnAddKanji = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblKanji
        '
        Me.lblKanji.BackColor = System.Drawing.Color.Transparent
        Me.lblKanji.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKanji.Location = New System.Drawing.Point(11, 28)
        Me.lblKanji.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKanji.Name = "lblKanji"
        Me.lblKanji.Size = New System.Drawing.Size(229, 108)
        Me.lblKanji.TabIndex = 0
        Me.lblKanji.Text = "一"
        Me.lblKanji.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblKanji.Visible = False
        '
        'lblKana
        '
        Me.lblKana.BackColor = System.Drawing.Color.Transparent
        Me.lblKana.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKana.Location = New System.Drawing.Point(19, 253)
        Me.lblKana.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKana.Name = "lblKana"
        Me.lblKana.Size = New System.Drawing.Size(219, 44)
        Me.lblKana.TabIndex = 1
        Me.lblKana.Text = "いち"
        Me.lblKana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblKana.Visible = False
        '
        'btnTestKana
        '
        Me.btnTestKana.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestKana.Location = New System.Drawing.Point(11, 205)
        Me.btnTestKana.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTestKana.Name = "btnTestKana"
        Me.btnTestKana.Size = New System.Drawing.Size(108, 28)
        Me.btnTestKana.TabIndex = 1
        Me.btnTestKana.Text = "Test Kana"
        Me.btnTestKana.UseVisualStyleBackColor = True
        Me.btnTestKana.Visible = False
        '
        'btnTestEng
        '
        Me.btnTestEng.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestEng.Location = New System.Drawing.Point(11, 379)
        Me.btnTestEng.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTestEng.Name = "btnTestEng"
        Me.btnTestEng.Size = New System.Drawing.Size(108, 28)
        Me.btnTestEng.TabIndex = 3
        Me.btnTestEng.Text = "Test English"
        Me.btnTestEng.UseVisualStyleBackColor = True
        Me.btnTestEng.Visible = False
        '
        'lblEng
        '
        Me.lblEng.BackColor = System.Drawing.Color.Transparent
        Me.lblEng.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEng.Location = New System.Drawing.Point(11, 417)
        Me.lblEng.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEng.Name = "lblEng"
        Me.lblEng.Size = New System.Drawing.Size(227, 44)
        Me.lblEng.TabIndex = 4
        Me.lblEng.Text = "one"
        Me.lblEng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEng.Visible = False
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(9, 484)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(83, 30)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        Me.btnNext.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(9, 521)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 30)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtKana
        '
        Me.txtKana.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKana.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtKana.Location = New System.Drawing.Point(67, 171)
        Me.txtKana.Margin = New System.Windows.Forms.Padding(2)
        Me.txtKana.Name = "txtKana"
        Me.txtKana.Size = New System.Drawing.Size(114, 26)
        Me.txtKana.TabIndex = 0
        Me.txtKana.Visible = False
        '
        'txtEng
        '
        Me.txtEng.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEng.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtEng.Location = New System.Drawing.Point(67, 343)
        Me.txtEng.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEng.Name = "txtEng"
        Me.txtEng.Size = New System.Drawing.Size(114, 26)
        Me.txtEng.TabIndex = 2
        Me.txtEng.Visible = False
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(155, 484)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(83, 30)
        Me.btnPrevious.TabIndex = 5
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        Me.btnPrevious.Visible = False
        '
        'lblTestKanaYes
        '
        Me.lblTestKanaYes.BackColor = System.Drawing.Color.Transparent
        Me.lblTestKanaYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestKanaYes.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblTestKanaYes.Location = New System.Drawing.Point(131, 148)
        Me.lblTestKanaYes.Name = "lblTestKanaYes"
        Me.lblTestKanaYes.Size = New System.Drawing.Size(109, 19)
        Me.lblTestKanaYes.TabIndex = 10
        Me.lblTestKanaYes.Text = "Yes!"
        Me.lblTestKanaYes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTestKanaYes.Visible = False
        '
        'lblTestKana
        '
        Me.lblTestKana.AutoSize = True
        Me.lblTestKana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestKana.Location = New System.Drawing.Point(50, 150)
        Me.lblTestKana.Name = "lblTestKana"
        Me.lblTestKana.Size = New System.Drawing.Size(82, 16)
        Me.lblTestKana.TabIndex = 11
        Me.lblTestKana.Text = "Test Kana:"
        Me.lblTestKana.Visible = False
        '
        'lblTestEng
        '
        Me.lblTestEng.AutoSize = True
        Me.lblTestEng.BackColor = System.Drawing.Color.Transparent
        Me.lblTestEng.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestEng.ForeColor = System.Drawing.Color.Black
        Me.lblTestEng.Location = New System.Drawing.Point(34, 322)
        Me.lblTestEng.Name = "lblTestEng"
        Me.lblTestEng.Size = New System.Drawing.Size(98, 16)
        Me.lblTestEng.TabIndex = 12
        Me.lblTestEng.Text = "Test English:"
        Me.lblTestEng.Visible = False
        '
        'lblTestEngYes
        '
        Me.lblTestEngYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestEngYes.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblTestEngYes.Location = New System.Drawing.Point(131, 319)
        Me.lblTestEngYes.Name = "lblTestEngYes"
        Me.lblTestEngYes.Size = New System.Drawing.Size(109, 19)
        Me.lblTestEngYes.TabIndex = 13
        Me.lblTestEngYes.Text = "Yes!"
        Me.lblTestEngYes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTestEngYes.Visible = False
        '
        'lblTestKanaNo
        '
        Me.lblTestKanaNo.BackColor = System.Drawing.Color.Transparent
        Me.lblTestKanaNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestKanaNo.ForeColor = System.Drawing.Color.Red
        Me.lblTestKanaNo.Location = New System.Drawing.Point(131, 145)
        Me.lblTestKanaNo.Name = "lblTestKanaNo"
        Me.lblTestKanaNo.Size = New System.Drawing.Size(113, 25)
        Me.lblTestKanaNo.TabIndex = 14
        Me.lblTestKanaNo.Text = "Try again!"
        Me.lblTestKanaNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTestKanaNo.Visible = False
        '
        'lblTestEngNo
        '
        Me.lblTestEngNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestEngNo.ForeColor = System.Drawing.Color.Red
        Me.lblTestEngNo.Location = New System.Drawing.Point(131, 316)
        Me.lblTestEngNo.Name = "lblTestEngNo"
        Me.lblTestEngNo.Size = New System.Drawing.Size(113, 26)
        Me.lblTestEngNo.TabIndex = 15
        Me.lblTestEngNo.Text = "Try again!"
        Me.lblTestEngNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTestEngNo.Visible = False
        '
        'lblSub
        '
        Me.lblSub.AutoSize = True
        Me.lblSub.Location = New System.Drawing.Point(364, 474)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(0, 13)
        Me.lblSub.TabIndex = 19
        '
        'btnBegin
        '
        Me.btnBegin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBegin.Location = New System.Drawing.Point(83, 485)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(83, 30)
        Me.btnBegin.TabIndex = 20
        Me.btnBegin.Text = "Begin"
        Me.btnBegin.UseVisualStyleBackColor = True
        '
        'btnShowKana
        '
        Me.btnShowKana.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowKana.Location = New System.Drawing.Point(130, 205)
        Me.btnShowKana.Margin = New System.Windows.Forms.Padding(2)
        Me.btnShowKana.Name = "btnShowKana"
        Me.btnShowKana.Size = New System.Drawing.Size(108, 28)
        Me.btnShowKana.TabIndex = 22
        Me.btnShowKana.Text = "Flip Kana"
        Me.btnShowKana.UseVisualStyleBackColor = True
        Me.btnShowKana.Visible = False
        '
        'btnShowEng
        '
        Me.btnShowEng.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowEng.Location = New System.Drawing.Point(130, 379)
        Me.btnShowEng.Margin = New System.Windows.Forms.Padding(2)
        Me.btnShowEng.Name = "btnShowEng"
        Me.btnShowEng.Size = New System.Drawing.Size(108, 28)
        Me.btnShowEng.TabIndex = 23
        Me.btnShowEng.Text = "Flip English"
        Me.btnShowEng.UseVisualStyleBackColor = True
        Me.btnShowEng.Visible = False
        '
        'lblIntro1
        '
        Me.lblIntro1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntro1.Location = New System.Drawing.Point(12, 28)
        Me.lblIntro1.Name = "lblIntro1"
        Me.lblIntro1.Size = New System.Drawing.Size(225, 76)
        Me.lblIntro1.TabIndex = 24
        Me.lblIntro1.Text = "漢字"
        Me.lblIntro1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblIntro2
        '
        Me.lblIntro2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntro2.Location = New System.Drawing.Point(12, 9)
        Me.lblIntro2.Name = "lblIntro2"
        Me.lblIntro2.Size = New System.Drawing.Size(225, 26)
        Me.lblIntro2.TabIndex = 25
        Me.lblIntro2.Text = "かん　　　　じ"
        Me.lblIntro2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblIntro3
        '
        Me.lblIntro3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntro3.Location = New System.Drawing.Point(32, 104)
        Me.lblIntro3.Name = "lblIntro3"
        Me.lblIntro3.Size = New System.Drawing.Size(185, 66)
        Me.lblIntro3.TabIndex = 26
        Me.lblIntro3.Text = "フラッシュカード クイズ"
        Me.lblIntro3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblIntro4
        '
        Me.lblIntro4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntro4.Location = New System.Drawing.Point(12, 178)
        Me.lblIntro4.Name = "lblIntro4"
        Me.lblIntro4.Size = New System.Drawing.Size(225, 76)
        Me.lblIntro4.TabIndex = 27
        Me.lblIntro4.Text = "Use ""Test"" buttons to test your kanji knowledge."
        Me.lblIntro4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIntro5
        '
        Me.lblIntro5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntro5.Location = New System.Drawing.Point(12, 250)
        Me.lblIntro5.Name = "lblIntro5"
        Me.lblIntro5.Size = New System.Drawing.Size(225, 76)
        Me.lblIntro5.TabIndex = 28
        Me.lblIntro5.Text = "Use ""Flip"" buttons to study without testing."
        Me.lblIntro5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbxEng
        '
        Me.lbxEng.FormattingEnabled = True
        Me.lbxEng.Location = New System.Drawing.Point(276, 277)
        Me.lbxEng.Name = "lbxEng"
        Me.lbxEng.Size = New System.Drawing.Size(244, 134)
        Me.lbxEng.TabIndex = 21
        Me.lbxEng.Visible = False
        '
        'lbxKana
        '
        Me.lbxKana.FormattingEnabled = True
        Me.lbxKana.Location = New System.Drawing.Point(280, 137)
        Me.lbxKana.Name = "lbxKana"
        Me.lbxKana.Size = New System.Drawing.Size(244, 134)
        Me.lbxKana.TabIndex = 17
        Me.lbxKana.Visible = False
        '
        'lbxKanji
        '
        Me.lbxKanji.FormattingEnabled = True
        Me.lbxKanji.Location = New System.Drawing.Point(289, 2)
        Me.lbxKanji.Name = "lbxKanji"
        Me.lbxKanji.Size = New System.Drawing.Size(244, 134)
        Me.lbxKanji.TabIndex = 16
        Me.lbxKanji.Visible = False
        '
        'btnAddKanji
        '
        Me.btnAddKanji.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddKanji.Location = New System.Drawing.Point(155, 521)
        Me.btnAddKanji.Name = "btnAddKanji"
        Me.btnAddKanji.Size = New System.Drawing.Size(82, 30)
        Me.btnAddKanji.TabIndex = 29
        Me.btnAddKanji.Text = "Add Kanji"
        Me.btnAddKanji.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(249, 561)
        Me.Controls.Add(Me.btnAddKanji)
        Me.Controls.Add(Me.lblIntro5)
        Me.Controls.Add(Me.lblIntro4)
        Me.Controls.Add(Me.lblIntro3)
        Me.Controls.Add(Me.lblIntro2)
        Me.Controls.Add(Me.lblIntro1)
        Me.Controls.Add(Me.btnShowEng)
        Me.Controls.Add(Me.btnShowKana)
        Me.Controls.Add(Me.btnBegin)
        Me.Controls.Add(Me.lblSub)
        Me.Controls.Add(Me.lbxEng)
        Me.Controls.Add(Me.lbxKana)
        Me.Controls.Add(Me.lbxKanji)
        Me.Controls.Add(Me.lblTestEngNo)
        Me.Controls.Add(Me.lblTestKanaNo)
        Me.Controls.Add(Me.lblTestEngYes)
        Me.Controls.Add(Me.lblTestEng)
        Me.Controls.Add(Me.lblTestKana)
        Me.Controls.Add(Me.lblTestKanaYes)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.txtEng)
        Me.Controls.Add(Me.txtKana)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblEng)
        Me.Controls.Add(Me.btnTestEng)
        Me.Controls.Add(Me.btnTestKana)
        Me.Controls.Add(Me.lblKana)
        Me.Controls.Add(Me.lblKanji)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "フラッシュカードクイズ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblKanji As Label
    Friend WithEvents lblKana As Label
    Friend WithEvents btnTestKana As Button
    Friend WithEvents btnTestEng As Button
    Friend WithEvents lblEng As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtKana As TextBox
    Friend WithEvents txtEng As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents lblTestKanaYes As Label
    Friend WithEvents lblTestKana As Label
    Friend WithEvents lblTestEng As Label
    Friend WithEvents lblTestEngYes As Label
    Friend WithEvents lblTestKanaNo As Label
    Friend WithEvents lblTestEngNo As Label
    Friend WithEvents lblSub As Label
    Friend WithEvents btnBegin As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnShowKana As Button
    Friend WithEvents btnShowEng As Button
    Friend WithEvents lblIntro1 As Label
    Friend WithEvents lblIntro2 As Label
    Friend WithEvents lblIntro3 As Label
    Friend WithEvents lblIntro4 As Label
    Friend WithEvents lblIntro5 As Label
    Friend WithEvents lbxEng As ListBox
    Friend WithEvents lbxKana As ListBox
    Friend WithEvents lbxKanji As ListBox
    Friend WithEvents btnAddKanji As Button
End Class
