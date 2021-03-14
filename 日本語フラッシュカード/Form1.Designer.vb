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
        Me.lblKanji = New System.Windows.Forms.Label()
        Me.lblKana = New System.Windows.Forms.Label()
        Me.btnFlipNihongo = New System.Windows.Forms.Button()
        Me.btnFlipEigo = New System.Windows.Forms.Button()
        Me.lblEigo = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtNihongo = New System.Windows.Forms.TextBox()
        Me.txtEigo = New System.Windows.Forms.TextBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.lblYes1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblYes2 = New System.Windows.Forms.Label()
        Me.lblNo1 = New System.Windows.Forms.Label()
        Me.lblNo2 = New System.Windows.Forms.Label()
        Me.lbxKanji = New System.Windows.Forms.ListBox()
        Me.lbxKana = New System.Windows.Forms.ListBox()
        Me.lbxEng = New System.Windows.Forms.ListBox()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.btnBegin = New System.Windows.Forms.Button()
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
        'btnFlipNihongo
        '
        Me.btnFlipNihongo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFlipNihongo.Location = New System.Drawing.Point(70, 205)
        Me.btnFlipNihongo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFlipNihongo.Name = "btnFlipNihongo"
        Me.btnFlipNihongo.Size = New System.Drawing.Size(108, 28)
        Me.btnFlipNihongo.TabIndex = 1
        Me.btnFlipNihongo.Text = "Flip Hiragana"
        Me.btnFlipNihongo.UseVisualStyleBackColor = True
        '
        'btnFlipEigo
        '
        Me.btnFlipEigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFlipEigo.Location = New System.Drawing.Point(70, 376)
        Me.btnFlipEigo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFlipEigo.Name = "btnFlipEigo"
        Me.btnFlipEigo.Size = New System.Drawing.Size(108, 28)
        Me.btnFlipEigo.TabIndex = 3
        Me.btnFlipEigo.Text = "Flip"
        Me.btnFlipEigo.UseVisualStyleBackColor = True
        '
        'lblEigo
        '
        Me.lblEigo.BackColor = System.Drawing.Color.Transparent
        Me.lblEigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEigo.Location = New System.Drawing.Point(11, 417)
        Me.lblEigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEigo.Name = "lblEigo"
        Me.lblEigo.Size = New System.Drawing.Size(227, 44)
        Me.lblEigo.TabIndex = 4
        Me.lblEigo.Text = "one"
        Me.lblEigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEigo.Visible = False
        '
        'btnNext
        '
        Me.btnNext.Enabled = False
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
        Me.btnExit.Location = New System.Drawing.Point(83, 520)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 30)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtNihongo
        '
        Me.txtNihongo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNihongo.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtNihongo.Location = New System.Drawing.Point(67, 171)
        Me.txtNihongo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNihongo.Name = "txtNihongo"
        Me.txtNihongo.Size = New System.Drawing.Size(114, 26)
        Me.txtNihongo.TabIndex = 0
        '
        'txtEigo
        '
        Me.txtEigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEigo.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtEigo.Location = New System.Drawing.Point(67, 343)
        Me.txtEigo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEigo.Name = "txtEigo"
        Me.txtEigo.Size = New System.Drawing.Size(114, 26)
        Me.txtEigo.TabIndex = 2
        '
        'btnPrevious
        '
        Me.btnPrevious.Enabled = False
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
        'lblYes1
        '
        Me.lblYes1.BackColor = System.Drawing.Color.Transparent
        Me.lblYes1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYes1.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblYes1.Location = New System.Drawing.Point(131, 148)
        Me.lblYes1.Name = "lblYes1"
        Me.lblYes1.Size = New System.Drawing.Size(109, 19)
        Me.lblYes1.TabIndex = 10
        Me.lblYes1.Text = "Yes!"
        Me.lblYes1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblYes1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Test Kana:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(34, 322)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Test English:"
        '
        'lblYes2
        '
        Me.lblYes2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYes2.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblYes2.Location = New System.Drawing.Point(131, 319)
        Me.lblYes2.Name = "lblYes2"
        Me.lblYes2.Size = New System.Drawing.Size(109, 19)
        Me.lblYes2.TabIndex = 13
        Me.lblYes2.Text = "Yes!"
        Me.lblYes2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblYes2.Visible = False
        '
        'lblNo1
        '
        Me.lblNo1.BackColor = System.Drawing.Color.Transparent
        Me.lblNo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo1.ForeColor = System.Drawing.Color.Red
        Me.lblNo1.Location = New System.Drawing.Point(131, 145)
        Me.lblNo1.Name = "lblNo1"
        Me.lblNo1.Size = New System.Drawing.Size(113, 25)
        Me.lblNo1.TabIndex = 14
        Me.lblNo1.Text = "Try again!"
        Me.lblNo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblNo1.Visible = False
        '
        'lblNo2
        '
        Me.lblNo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo2.ForeColor = System.Drawing.Color.Red
        Me.lblNo2.Location = New System.Drawing.Point(131, 316)
        Me.lblNo2.Name = "lblNo2"
        Me.lblNo2.Size = New System.Drawing.Size(113, 26)
        Me.lblNo2.TabIndex = 15
        Me.lblNo2.Text = "Try again!"
        Me.lblNo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblNo2.Visible = False
        '
        'lbxKanji
        '
        Me.lbxKanji.FormattingEnabled = True
        Me.lbxKanji.Items.AddRange(New Object() {"一", "二", "三", "四", "五", "六", "七", "八", "九", "十"})
        Me.lbxKanji.Location = New System.Drawing.Point(203, 0)
        Me.lbxKanji.Name = "lbxKanji"
        Me.lbxKanji.Size = New System.Drawing.Size(244, 134)
        Me.lbxKanji.TabIndex = 16
        Me.lbxKanji.Visible = False
        '
        'lbxKana
        '
        Me.lbxKana.FormattingEnabled = True
        Me.lbxKana.Items.AddRange(New Object() {"いち", "に", "さん", "よん", "ご", "ろく", "なな", "はち", "きゅう", "じゅう"})
        Me.lbxKana.Location = New System.Drawing.Point(203, 137)
        Me.lbxKana.Name = "lbxKana"
        Me.lbxKana.Size = New System.Drawing.Size(244, 134)
        Me.lbxKana.TabIndex = 17
        Me.lbxKana.Visible = False
        '
        'lbxEng
        '
        Me.lbxEng.FormattingEnabled = True
        Me.lbxEng.Items.AddRange(New Object() {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"})
        Me.lbxEng.Location = New System.Drawing.Point(203, 277)
        Me.lbxEng.Name = "lbxEng"
        Me.lbxEng.Size = New System.Drawing.Size(244, 134)
        Me.lbxEng.TabIndex = 21
        Me.lbxEng.Visible = False
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(249, 561)
        Me.Controls.Add(Me.btnBegin)
        Me.Controls.Add(Me.lblSub)
        Me.Controls.Add(Me.lbxEng)
        Me.Controls.Add(Me.lbxKana)
        Me.Controls.Add(Me.lbxKanji)
        Me.Controls.Add(Me.lblNo2)
        Me.Controls.Add(Me.lblNo1)
        Me.Controls.Add(Me.lblYes2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblYes1)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.txtEigo)
        Me.Controls.Add(Me.txtNihongo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblEigo)
        Me.Controls.Add(Me.btnFlipEigo)
        Me.Controls.Add(Me.btnFlipNihongo)
        Me.Controls.Add(Me.lblKana)
        Me.Controls.Add(Me.lblKanji)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "フラッシュカード"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblKanji As Label
    Friend WithEvents lblKana As Label
    Friend WithEvents btnFlipNihongo As Button
    Friend WithEvents btnFlipEigo As Button
    Friend WithEvents lblEigo As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtNihongo As TextBox
    Friend WithEvents txtEigo As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents lblYes1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblYes2 As Label
    Friend WithEvents lblNo1 As Label
    Friend WithEvents lblNo2 As Label
    Friend WithEvents lbxKanji As ListBox
    Friend WithEvents lbxKana As ListBox
    Friend WithEvents lbxEng As ListBox
    Friend WithEvents lblSub As Label
    Friend WithEvents btnBegin As Button
End Class
