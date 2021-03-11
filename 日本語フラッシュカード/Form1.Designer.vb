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
        Me.lblHiragana = New System.Windows.Forms.Label()
        Me.btnFlipNihongo = New System.Windows.Forms.Button()
        Me.btnFlipEigo = New System.Windows.Forms.Button()
        Me.lblEigo = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtNihongo = New System.Windows.Forms.TextBox()
        Me.txtEigo = New System.Windows.Forms.TextBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblKanji
        '
        Me.lblKanji.AutoSize = True
        Me.lblKanji.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKanji.Location = New System.Drawing.Point(62, 28)
        Me.lblKanji.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKanji.Name = "lblKanji"
        Me.lblKanji.Size = New System.Drawing.Size(141, 108)
        Me.lblKanji.TabIndex = 0
        Me.lblKanji.Text = "私"
        '
        'lblHiragana
        '
        Me.lblHiragana.AutoSize = True
        Me.lblHiragana.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHiragana.Location = New System.Drawing.Point(71, 271)
        Me.lblHiragana.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHiragana.Name = "lblHiragana"
        Me.lblHiragana.Size = New System.Drawing.Size(109, 44)
        Me.lblHiragana.TabIndex = 1
        Me.lblHiragana.Text = "わたし"
        '
        'btnFlipNihongo
        '
        Me.btnFlipNihongo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFlipNihongo.Location = New System.Drawing.Point(75, 157)
        Me.btnFlipNihongo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnFlipNihongo.Name = "btnFlipNihongo"
        Me.btnFlipNihongo.Size = New System.Drawing.Size(108, 28)
        Me.btnFlipNihongo.TabIndex = 2
        Me.btnFlipNihongo.Text = "Flip Hiragana"
        Me.btnFlipNihongo.UseVisualStyleBackColor = True
        '
        'btnFlipEigo
        '
        Me.btnFlipEigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFlipEigo.Location = New System.Drawing.Point(75, 330)
        Me.btnFlipEigo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnFlipEigo.Name = "btnFlipEigo"
        Me.btnFlipEigo.Size = New System.Drawing.Size(108, 28)
        Me.btnFlipEigo.TabIndex = 3
        Me.btnFlipEigo.Text = "Flip English"
        Me.btnFlipEigo.UseVisualStyleBackColor = True
        '
        'lblEigo
        '
        Me.lblEigo.AutoSize = True
        Me.lblEigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEigo.Location = New System.Drawing.Point(112, 417)
        Me.lblEigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEigo.Name = "lblEigo"
        Me.lblEigo.Size = New System.Drawing.Size(30, 44)
        Me.lblEigo.TabIndex = 4
        Me.lblEigo.Text = "I"
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(9, 490)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 24)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(87, 528)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 24)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtNihongo
        '
        Me.txtNihongo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNihongo.Location = New System.Drawing.Point(70, 221)
        Me.txtNihongo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNihongo.Name = "txtNihongo"
        Me.txtNihongo.Size = New System.Drawing.Size(114, 26)
        Me.txtNihongo.TabIndex = 7
        '
        'txtEigo
        '
        Me.txtEigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEigo.Location = New System.Drawing.Point(70, 379)
        Me.txtEigo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEigo.Name = "txtEigo"
        Me.txtEigo.Size = New System.Drawing.Size(114, 26)
        Me.txtEigo.TabIndex = 8
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(165, 490)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 24)
        Me.btnPrevious.TabIndex = 9
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 561)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.txtEigo)
        Me.Controls.Add(Me.txtNihongo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblEigo)
        Me.Controls.Add(Me.btnFlipEigo)
        Me.Controls.Add(Me.btnFlipNihongo)
        Me.Controls.Add(Me.lblHiragana)
        Me.Controls.Add(Me.lblKanji)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "フラッシュカード"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblKanji As Label
    Friend WithEvents lblHiragana As Label
    Friend WithEvents btnFlipNihongo As Button
    Friend WithEvents btnFlipEigo As Button
    Friend WithEvents lblEigo As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtNihongo As TextBox
    Friend WithEvents txtEigo As TextBox
    Friend WithEvents btnPrevious As Button
End Class
