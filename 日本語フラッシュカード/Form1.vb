Public Class Form1
    Dim R As IO.StreamReader
    Dim intSub As Integer

    Private Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click

        R = New IO.StreamReader("C:\Users\pesky\Downloads\CS115\KanjiList.txt")
        While (R.Peek() > -1)
            lbxKanji.Items.Add(R.ReadLine)
        End While
        R.Close()

        R = New IO.StreamReader("C:\Users\pesky\Downloads\CS115\KanaList.txt")
        While (R.Peek() > -1)
            lbxKana.Items.Add(R.ReadLine)
        End While
        R.Close()

        R = New IO.StreamReader("C:\Users\pesky\Downloads\CS115\EngList.txt")
        While (R.Peek() > -1)
            lbxEng.Items.Add(R.ReadLine)
        End While
        R.Close()

        lblKanji.Text = lbxKanji.Items(intSub).ToString
        lblKana.Text = lbxKana.Items(intSub).ToString
        lblEng.Text = lbxEng.Items(intSub).ToString

        btnBegin.Visible = False
        btnNext.Visible = True
        btnPrevious.Visible = True
        btnTestKana.Visible = True
        btnTestEng.Visible = True
        btnShowKana.Visible = True
        btnShowEng.Visible = True

        lblIntro1.Visible = False
        lblIntro2.Visible = False
        lblIntro3.Visible = False
        lblIntro4.Visible = False
        lblIntro5.Visible = False
        lblKanji.Visible = True
        lblTestKana.Visible = True
        lblTestEng.Visible = True

        txtKana.Visible = True
        txtEng.Visible = True

        txtKana.Focus()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click



        txtKana.Text = ""
        txtEng.Text = ""
        lblTestKanaYes.Visible = False
        lblTestEngYes.Visible = False
        lblTestKanaNo.Visible = False
        lblTestEngNo.Visible = False

        If intSub < lbxKanji.Items.Count - 1 Then
            intSub += 1
        Else
            intSub = 0
        End If

        lblKanji.Text = lbxKanji.Items(intSub).ToString
        lblKana.Text = lbxKana.Items(intSub).ToString
        lblEng.Text = lbxEng.Items(intSub).ToString

        lblKana.Visible = False
        lblEng.Visible = False

        txtKana.Focus()
    End Sub

    Private Sub btnTestKana_Click(sender As Object, e As EventArgs) Handles btnTestKana.Click

        lblKana.Visible = False
        lblTestKanaYes.Visible = False
        lblTestKanaNo.Visible = False

        If lblEng.Visible = False Then
            If txtKana.Text = lblKana.Text Then
                lblKana.Visible = True
                lblTestKanaYes.Visible = True
                lblTestKanaNo.Visible = False
                txtEng.Focus()
            Else
                lblKana.Visible = False
                lblTestKanaNo.Visible = True
                lblTestKanaYes.Visible = False
                txtKana.Text = ""
                txtKana.Focus()
            End If
        Else
            If txtKana.Text = lblKana.Text Then
                lblKana.Visible = True
                lblTestKanaYes.Visible = True
                lblTestKanaNo.Visible = False
                btnNext.Focus()
            Else
                lblKana.Visible = False
                lblTestKanaNo.Visible = True
                lblTestKanaYes.Visible = False
                txtKana.Text = ""
                txtKana.Focus()
            End If
        End If

    End Sub

    Private Sub txtNihongo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKana.KeyDown

        If e.KeyCode = Keys.Enter Then

            btnTestKana.PerformClick()
            e.Handled = True
            e.SuppressKeyPress = True

        End If

    End Sub

    Private Sub btnTestEng_Click(sender As Object, e As EventArgs) Handles btnTestEng.Click

        lblEng.Visible = False
        lblTestEngYes.Visible = False
        lblTestEngNo.Visible = False

        If lblKana.Visible = True Then
            If txtEng.Text = lblEng.Text Then
                lblEng.Visible = True
                lblTestEngYes.Visible = True
                lblTestEngNo.Visible = False
                btnNext.Focus()
            Else
                lblEng.Visible = False
                lblTestEngNo.Visible = True
                lblTestEngYes.Visible = False
                txtEng.Text = ""
                txtEng.Focus()
            End If
        Else
            If txtEng.Text = lblEng.Text Then
                lblEng.Visible = True
                lblTestEngYes.Visible = True
                lblTestEngNo.Visible = False
                txtKana.Focus()
            Else
                lblEng.Visible = False
                lblTestEngNo.Visible = True
                lblTestEngYes.Visible = False
                txtEng.Text = ""
                txtEng.Focus()
            End If
        End If

    End Sub

    Private Sub txtEigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEng.KeyDown

        If e.KeyCode = Keys.Enter Then

            btnTestEng.PerformClick()
            e.Handled = True
            e.SuppressKeyPress = True

        End If

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click

        txtKana.Text = ""
        txtEng.Text = ""
        lblTestKanaYes.Visible = False
        lblTestEngYes.Visible = False
        lblTestKanaNo.Visible = False
        lblTestEngNo.Visible = False

        If intSub > 0 Then
            intSub -= 1
            lblKanji.Text = lbxKanji.Items(intSub).ToString
            lblKana.Text = lbxKana.Items(intSub).ToString
            lblEng.Text = lbxEng.Items(intSub).ToString
        Else
            intSub = lbxKanji.Items.Count - 1
            lblKanji.Text = lbxKanji.Items(intSub).ToString
            lblKana.Text = lbxKana.Items(intSub).ToString
            lblEng.Text = lbxEng.Items(intSub).ToString
        End If

        lblKana.Visible = False
        lblEng.Visible = False

        txtKana.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnShowKana_Click(sender As Object, e As EventArgs) Handles btnShowKana.Click

        If lblKana.Visible = False Then
            lblKana.Visible = True
            lblTestKanaNo.Visible = False
            lblTestKanaYes.Visible = False
        Else
            lblKana.Visible = False
            lblTestKanaNo.Visible = False
            lblTestKanaYes.Visible = False
        End If


    End Sub

    Private Sub btnShowEng_Click(sender As Object, e As EventArgs) Handles btnShowEng.Click

        If lblEng.Visible = False Then
            lblEng.Visible = True
            lblTestEngNo.Visible = False
            lblTestEngYes.Visible = False
        Else
            lblEng.Visible = False
            lblTestEngNo.Visible = False
            lblTestEngYes.Visible = False
        End If

    End Sub

    Private Sub btnAddKanji_Click(sender As Object, e As EventArgs) Handles btnAddKanji.Click

        lbxKanji.Items.Clear()
        lbxKana.Items.Clear()
        lbxEng.Items.Clear()

        R = New IO.StreamReader("C:\Users\pesky\Downloads\CS115\KanjiList.txt")
        While (R.Peek() > -1)
            lbxKanji.Items.Add(R.ReadLine)
        End While
        R.Close()

        R = New IO.StreamReader("C:\Users\pesky\Downloads\CS115\KanaList.txt")
        While (R.Peek() > -1)
            lbxKana.Items.Add(R.ReadLine)
        End While
        R.Close()

        R = New IO.StreamReader("C:\Users\pesky\Downloads\CS115\EngList.txt")
        While (R.Peek() > -1)
            lbxEng.Items.Add(R.ReadLine)
        End While
        R.Close()


        Form2.Show()
    End Sub
End Class