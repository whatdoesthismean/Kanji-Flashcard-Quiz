Public Class Form2
    Dim W As IO.StreamWriter
    Dim R As IO.StreamReader
    Private Sub btnAddToList_Click(sender As Object, e As EventArgs) Handles btnAddToList.Click

        Dim I As Integer


        If Not String.IsNullOrEmpty(txtNewKanji.Text) And Not String.IsNullOrEmpty(txtNewKana.Text) And Not String.IsNullOrEmpty(txtNewEng.Text) Then

            lblPlease.Visible = False

            Form1.lbxKanji.Items.Add(txtNewKanji.Text)
            Form1.lbxKana.Items.Add(txtNewKana.Text)
            Form1.lbxEng.Items.Add(txtNewEng.Text)

            txtNewKanji.Text = ""
            txtNewKana.Text = ""
            txtNewEng.Text = ""

            W = New IO.StreamWriter("C:\Users\pesky\Downloads\CS115\KanjiList.txt")
            For I = 0 To Form1.lbxKanji.Items.Count - 1
                W.WriteLine(Form1.lbxKanji.Items.Item(I))
            Next
            W.Close()

            W = New IO.StreamWriter("C:\Users\pesky\Downloads\CS115\KanaList.txt")
            For I = 0 To Form1.lbxKanji.Items.Count - 1
                W.WriteLine(Form1.lbxKana.Items.Item(I))
            Next
            W.Close()

            W = New IO.StreamWriter("C:\Users\pesky\Downloads\CS115\EngList.txt")
            For I = 0 To Form1.lbxKanji.Items.Count - 1
                W.WriteLine(Form1.lbxEng.Items.Item(I))
            Next
            W.Close()

            txtNewKanji.Focus()

        Else

            lblPlease.Visible = True
            lblSaved.Visible = False

        End If

    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click

        R = New IO.StreamReader("C:\Users\pesky\Downloads\CS115\KanjiList.txt")
        While (R.Peek() > -1)
            Form1.lbxKanji.Items.Add(R.ReadLine)
        End While
        R.Close()

        R = New IO.StreamReader("C:\Users\pesky\Downloads\CS115\KanaList.txt")
        While (R.Peek() > -1)
            Form1.lbxKana.Items.Add(R.ReadLine)
        End While
        R.Close()

        R = New IO.StreamReader("C:\Users\pesky\Downloads\CS115\EngList.txt")
        While (R.Peek() > -1)
            Form1.lbxEng.Items.Add(R.ReadLine)
        End While
        R.Close()

        Me.Close()

    End Sub

    Private Sub txtNewKanji_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNewKanji.KeyDown

        If e.KeyCode = Keys.Enter Then

            txtNewKana.Focus()
            e.Handled = True
            e.SuppressKeyPress = True

        End If

    End Sub

    Private Sub txtNewKana_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNewKana.KeyDown

        If e.KeyCode = Keys.Enter Then

            txtNewEng.Focus()
            e.Handled = True
            e.SuppressKeyPress = True

        End If

    End Sub

    Private Sub txtNewEng_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNewEng.KeyDown

        If e.KeyCode = Keys.Enter Then

            btnAddToList.Focus()
            e.Handled = True
            e.SuppressKeyPress = True

        End If

    End Sub

    Private Sub txtNewKanji_TextChanged(sender As Object, e As EventArgs) Handles txtNewKanji.TextChanged

        lblSaved.Visible = False
        lblPlease.Visible = False

    End Sub

    Private Sub txtNewKana_TextChanged(sender As Object, e As EventArgs) Handles txtNewKana.TextChanged

        lblSaved.Visible = False
        lblPlease.Visible = False

    End Sub

    Private Sub txtNewEng_TextChanged(sender As Object, e As EventArgs) Handles txtNewEng.TextChanged

        lblSaved.Visible = False
        lblPlease.Visible = False

    End Sub


End Class