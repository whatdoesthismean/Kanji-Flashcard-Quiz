<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.txtNewKanji = New System.Windows.Forms.TextBox()
        Me.txtNewKana = New System.Windows.Forms.TextBox()
        Me.txtNewEng = New System.Windows.Forms.TextBox()
        Me.btnAddToList = New System.Windows.Forms.Button()
        Me.lblPlease = New System.Windows.Forms.Label()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.lblSaved = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNewKanji
        '
        Me.txtNewKanji.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewKanji.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtNewKanji.Location = New System.Drawing.Point(52, 69)
        Me.txtNewKanji.Name = "txtNewKanji"
        Me.txtNewKanji.Size = New System.Drawing.Size(100, 26)
        Me.txtNewKanji.TabIndex = 0
        '
        'txtNewKana
        '
        Me.txtNewKana.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewKana.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtNewKana.Location = New System.Drawing.Point(52, 132)
        Me.txtNewKana.Name = "txtNewKana"
        Me.txtNewKana.Size = New System.Drawing.Size(100, 26)
        Me.txtNewKana.TabIndex = 1
        '
        'txtNewEng
        '
        Me.txtNewEng.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewEng.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtNewEng.Location = New System.Drawing.Point(52, 198)
        Me.txtNewEng.Name = "txtNewEng"
        Me.txtNewEng.Size = New System.Drawing.Size(100, 26)
        Me.txtNewEng.TabIndex = 2
        '
        'btnAddToList
        '
        Me.btnAddToList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToList.Location = New System.Drawing.Point(65, 344)
        Me.btnAddToList.Name = "btnAddToList"
        Me.btnAddToList.Size = New System.Drawing.Size(75, 37)
        Me.btnAddToList.TabIndex = 3
        Me.btnAddToList.Text = "Add"
        Me.btnAddToList.UseVisualStyleBackColor = True
        '
        'lblPlease
        '
        Me.lblPlease.BackColor = System.Drawing.Color.Red
        Me.lblPlease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlease.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlease.ForeColor = System.Drawing.Color.White
        Me.lblPlease.Location = New System.Drawing.Point(31, 292)
        Me.lblPlease.Name = "lblPlease"
        Me.lblPlease.Size = New System.Drawing.Size(143, 49)
        Me.lblPlease.TabIndex = 5
        Me.lblPlease.Text = "Please Complete All Fields"
        Me.lblPlease.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPlease.Visible = False
        '
        'btnFinish
        '
        Me.btnFinish.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinish.Location = New System.Drawing.Point(45, 387)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(114, 51)
        Me.btnFinish.TabIndex = 4
        Me.btnFinish.Text = "Load Updated List"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'lblSaved
        '
        Me.lblSaved.AutoSize = True
        Me.lblSaved.BackColor = System.Drawing.Color.Green
        Me.lblSaved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSaved.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaved.ForeColor = System.Drawing.Color.White
        Me.lblSaved.Location = New System.Drawing.Point(45, 306)
        Me.lblSaved.Name = "lblSaved"
        Me.lblSaved.Size = New System.Drawing.Size(114, 22)
        Me.lblSaved.TabIndex = 6
        Me.lblSaved.Text = "List Updated"
        Me.lblSaved.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Enter New Kanji:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Enter New Kana:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Enter New English:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(205, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSaved)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.lblPlease)
        Me.Controls.Add(Me.btnAddToList)
        Me.Controls.Add(Me.txtNewEng)
        Me.Controls.Add(Me.txtNewKana)
        Me.Controls.Add(Me.txtNewKanji)
        Me.Name = "Form2"
        Me.Text = "Add Kanji"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNewKanji As TextBox
    Friend WithEvents txtNewKana As TextBox
    Friend WithEvents txtNewEng As TextBox
    Friend WithEvents btnAddToList As Button
    Friend WithEvents lblPlease As Label
    Friend WithEvents btnFinish As Button
    Friend WithEvents lblSaved As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
