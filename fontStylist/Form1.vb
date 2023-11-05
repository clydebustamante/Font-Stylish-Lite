Public Class Form1
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtWriteText.Font = New Font("Microsoft JhengHei", 11)
        txtWriteText.Text = ""
        txtWriteText.ForeColor = Color.SlateGray

        chkBoxBold.Checked = False
        chkBoxItalic.Checked = False
        chkBoxUnderline.Checked = False
        btnFont1.Checked = False
        btnFont2.Checked = False
        btnFont3.Checked = False
        btnFont4.Checked = False
        btnFont5.Checked = False
        btnFont6.Checked = False
        btnFont7.Checked = False
        btnFont8.Checked = False
        btnFont9.Checked = False
        txtWriteText.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub chkBoxBold_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxBold.CheckedChanged
        If chkBoxBold.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Bold)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Bold)

        End If
    End Sub

    Private Sub chkBoxItalic_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxItalic.CheckedChanged
        If chkBoxItalic.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Italic)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Italic)
        End If
    End Sub

    Private Sub chkBoxUnderline_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxUnderline.CheckedChanged
        If chkBoxUnderline.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Underline)

        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Underline)
        End If
    End Sub

    Private Sub btnColor1_Click(sender As Object, e As EventArgs) Handles btnColor1.Click
        txtWriteText.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub btnColor2_Click(sender As Object, e As EventArgs) Handles btnColor2.Click
        txtWriteText.ForeColor = Color.RoyalBlue
    End Sub

    Private Sub btnColor3_Click(sender As Object, e As EventArgs) Handles btnColor3.Click
        txtWriteText.ForeColor = Color.Crimson
    End Sub

    Private Sub btnColor4_Click(sender As Object, e As EventArgs) Handles btnColor4.Click
        txtWriteText.ForeColor = Color.Orange
    End Sub

    Private Sub btnColor5_Click(sender As Object, e As EventArgs) Handles btnColor5.Click
        txtWriteText.ForeColor = Color.Gold
    End Sub

    Private Sub btnColor6_Click(sender As Object, e As EventArgs) Handles btnColor6.Click
        txtWriteText.ForeColor = Color.ForestGreen
    End Sub

    Private Sub btnColor7_Click(sender As Object, e As EventArgs) Handles btnColor7.Click
        txtWriteText.ForeColor = Color.Purple
    End Sub

    Private Sub btnColor8_Click(sender As Object, e As EventArgs) Handles btnColor8.Click
        txtWriteText.ForeColor = Color.Tomato
    End Sub

    Private Sub btnColor9_Click(sender As Object, e As EventArgs) Handles btnColor9.Click
        txtWriteText.ForeColor = Color.DarkCyan
    End Sub

    Private Sub btnColor10_Click(sender As Object, e As EventArgs) Handles btnColor10.Click
        txtWriteText.ForeColor = Color.Black
    End Sub

    Private Sub btnFont2_Click(sender As Object, e As EventArgs) Handles btnFont2.Click
        txtWriteText.Font = New Font("Broadway", 11)
        If chkBoxUnderline.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Underline)

        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Underline)
        End If

        If chkBoxItalic.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Italic)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Italic)
        End If

        If chkBoxBold.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Bold)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Bold)
        End If

        If chkBoxStrikeout.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Strikeout)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Strikeout)
        End If
    End Sub

    Private Sub btnFont1_Click(sender As Object, e As EventArgs) Handles btnFont1.Click
        txtWriteText.Font = New Font("Algerian", 11)
        If chkBoxUnderline.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Underline)

        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Underline)
        End If

        If chkBoxItalic.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Italic)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Italic)
        End If

        If chkBoxBold.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Bold)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Bold)
        End If

        If chkBoxStrikeout.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Strikeout)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Strikeout)
        End If
    End Sub

    Private Sub btnFont3_Click(sender As Object, e As EventArgs) Handles btnFont3.Click
        txtWriteText.Font = New Font("Consolas", 11)
        If chkBoxUnderline.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Underline)

        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Underline)
        End If

        If chkBoxItalic.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Italic)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Italic)
        End If

        If chkBoxBold.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Bold)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Bold)
        End If

        If chkBoxStrikeout.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Strikeout)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Strikeout)
        End If
    End Sub

    Private Sub btnFont4_Click(sender As Object, e As EventArgs) Handles btnFont4.Click
        txtWriteText.Font = New Font("Eras Demi ITC", 11)
        If chkBoxUnderline.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Underline)

        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Underline)
        End If

        If chkBoxItalic.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Italic)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Italic)
        End If

        If chkBoxBold.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Bold)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Bold)
        End If

        If chkBoxStrikeout.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Strikeout)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Strikeout)
        End If
    End Sub

    Private Sub btnFont5_Click(sender As Object, e As EventArgs) Handles btnFont5.Click
        txtWriteText.Font = New Font("Forte", 11)
        If chkBoxUnderline.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Underline)

        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Underline)
        End If

        If chkBoxItalic.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Italic)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Italic)
        End If

        If chkBoxBold.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Bold)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Bold)
        End If

        If chkBoxStrikeout.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Strikeout)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Strikeout)
        End If
    End Sub

    Private Sub btnFont6_Click(sender As Object, e As EventArgs) Handles btnFont6.Click
        txtWriteText.Font = New Font("Gigi", 11)
        If chkBoxUnderline.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Underline)

        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Underline)
        End If

        If chkBoxItalic.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Italic)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Italic)
        End If

        If chkBoxBold.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Bold)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Bold)
        End If

        If chkBoxStrikeout.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Strikeout)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Strikeout)
        End If
    End Sub

    Private Sub btnFont7_Click(sender As Object, e As EventArgs) Handles btnFont7.Click
        txtWriteText.Font = New Font("Harrington", 11)
        If chkBoxUnderline.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Underline)

        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Underline)
        End If

        If chkBoxItalic.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Italic)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Italic)
        End If

        If chkBoxBold.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Bold)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Bold)
        End If

        If chkBoxStrikeout.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Strikeout)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Strikeout)
        End If
    End Sub

    Private Sub btnFont8_Click(sender As Object, e As EventArgs) Handles btnFont8.Click
        txtWriteText.Font = New Font("Ink Free", 11)
        If chkBoxUnderline.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Underline)

        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Underline)
        End If

        If chkBoxItalic.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Italic)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Italic)
        End If

        If chkBoxBold.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Bold)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Bold)
        End If

        If chkBoxStrikeout.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Strikeout)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Strikeout)
        End If
    End Sub

    Private Sub btnFont9_Click(sender As Object, e As EventArgs) Handles btnFont9.Click
        txtWriteText.Font = New Font("Jokerman", 11)
        If chkBoxUnderline.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Underline)

        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Underline)
        End If

        If chkBoxItalic.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Italic)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Italic)
        End If

        If chkBoxBold.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Bold)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Bold)
        End If

        If chkBoxStrikeout.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Strikeout)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Strikeout)
        End If
    End Sub

    Private Sub chkBoxStrikeout_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxStrikeout.CheckedChanged
        If chkBoxStrikeout.Checked Then
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style Or FontStyle.Strikeout)
        Else
            txtWriteText.Font = New Font(txtWriteText.Font, txtWriteText.Font.Style And Not FontStyle.Strikeout)
        End If
    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
