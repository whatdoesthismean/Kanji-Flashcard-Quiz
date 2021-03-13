Public Class Form1
    Dim strKanji() As String = {"私", "日本", "円", "水", "火"}
    Dim strKana() As String = {"わたし", "にほん", "えん", "みず", "ひ"}
    Dim strEng() As String = {"I", "Japan", "yen", "water", "fire"}
    Dim intSub As Integer = 0

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        lblKanji.Text = strKanji(intSub).ToString
        lblKana.Text = strKana(intSub).ToString
        lblEigo.Text = strEng(intSub).ToString
        txtNihongo.Text = ""
        txtEigo.Text = ""
        lblYes1.Visible = False
        lblYes2.Visible = False
        lblNo1.Visible = False
        lblNo2.Visible = False

        If intSub < strKanji(intSub).Length + 3 Then
            intSub += 1
        Else
            intSub = 0
        End If

        lblKana.Visible = False
        lblEigo.Visible = False

        txtNihongo.Focus()
    End Sub

    Private Sub btnFlipNihongo_Click(sender As Object, e As EventArgs) Handles btnFlipNihongo.Click

        lblKana.Visible = False
        lblYes1.Visible = False
        lblNo1.Visible = False

        If lblEigo.Visible = False Then
            If txtNihongo.Text = lblKana.Text Then
                lblKana.Visible = True
                lblYes1.Visible = True
                lblNo1.Visible = False
                txtEigo.Focus()
            Else
                lblKana.Visible = False
                lblNo1.Visible = True
                lblYes1.Visible = False
                txtNihongo.Text = ""
                txtNihongo.Focus()
            End If
        Else
            If txtNihongo.Text = lblKana.Text Then
                lblKana.Visible = True
                lblYes1.Visible = True
                lblNo1.Visible = False
                btnNext.Focus()
            Else
                lblKana.Visible = False
                lblNo1.Visible = True
                lblYes1.Visible = False
                txtNihongo.Text = ""
                txtNihongo.Focus()
            End If
        End If

    End Sub

    Private Sub txtNihongo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNihongo.KeyDown

        If e.KeyCode = Keys.Enter Then

            btnFlipNihongo.PerformClick()
            e.Handled = True
            e.SuppressKeyPress = True

        End If

    End Sub

    Private Sub btnFlipEigo_Click(sender As Object, e As EventArgs) Handles btnFlipEigo.Click
        lblEigo.Visible = False
        lblYes2.Visible = False
        lblNo2.Visible = False

        If lblKana.Visible = True Then
            If txtEigo.Text = lblEigo.Text Then
                lblEigo.Visible = True
                lblYes2.Visible = True
                lblNo2.Visible = False
                btnNext.Focus()
            Else
                lblEigo.Visible = False
                lblNo2.Visible = True
                lblYes2.Visible = False
                txtEigo.Text = ""
                txtEigo.Focus()
            End If
        Else
            If txtEigo.Text = lblEigo.Text Then
                lblEigo.Visible = True
                lblYes2.Visible = True
                lblNo2.Visible = False
                txtNihongo.Focus()
            Else
                lblEigo.Visible = False
                lblNo2.Visible = True
                lblYes2.Visible = False
                txtEigo.Text = ""
                txtEigo.Focus()
            End If
        End If

    End Sub

    Private Sub txtEigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEigo.KeyDown

        If e.KeyCode = Keys.Enter Then

            btnFlipEigo.PerformClick()
            e.Handled = True
            e.SuppressKeyPress = True

        End If

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click

        txtNihongo.Text = ""
        txtEigo.Text = ""
        lblYes1.Visible = False
        lblYes2.Visible = False
        lblNo1.Visible = False
        lblNo2.Visible = False

        If intSub > 0 Then
            intSub -= 1
            lblKanji.Text = strKanji(intSub).ToString
            lblKana.Text = strKana(intSub).ToString
            lblEigo.Text = strEng(intSub).ToString
        Else
            intSub = strKanji(intSub).Length + 3
            lblKanji.Text = strKanji(intSub).ToString
            lblKana.Text = strKana(intSub).ToString
            lblEigo.Text = strEng(intSub).ToString
        End If

        lblKana.Visible = False
        lblEigo.Visible = False

        txtNihongo.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class