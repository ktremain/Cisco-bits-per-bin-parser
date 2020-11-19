Public Class Form1


    Dim boolBoxCleared As Boolean


    Private Sub btnParseData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParseData.Click

        Dim araDataArray() As String
        Dim i As Integer
        Dim inew As Integer
        Dim txtTempBits As String
        Dim iLen As Integer


        ' Copy Text field into temporary buffer
        txtTempBits = txtData.Text


        ' Trims any/all CrLf off end
        Do While Strings.Right(txtTempBits, 2) = vbCrLf
            txtTempBits = Strings.Left(txtTempBits, txtTempBits.Length - 2)
        Loop


        ' Splits the textbox into an array, one line per index
        araDataArray = Split(txtTempBits, vbCrLf)


        ' Searches for the first line containing ADSL data
        For i = 0 To araDataArray.Length - 1
            If InStr(araDataArray(i), "0 0 0 0 0") > 0 Then Exit For
        Next


        ' Error trapping if no valid data
        If i = araDataArray.Length Then
            txtResult.Text = "No ADSL data Parsed"
            Exit Sub
        End If


        ' now i equals the first valid ADSL line, discard anything before it
        While i > 0
            For inew = i To araDataArray.Length - 1
                araDataArray(inew - 1) = araDataArray(inew)
            Next
            ReDim Preserve araDataArray(araDataArray.Length - 2)
            i = i - 1
        End While


        ' Strip the first 5 chars, and put the array back into one long string
        txtTempBits = ""
        'For i = 0 To araDataArray.Length - 1
        For Each Str As String In araDataArray
            If Str.Contains(":") Then
                iLen = Len(Str)
                txtTempBits = txtTempBits & Strings.Right(Str, iLen - 5)
                txtTempBits = txtTempBits & ","
            Else
                txtTempBits = txtTempBits & Str
                txtTempBits = txtTempBits & ","
            End If
        Next


        ' Replaces hex values with decimal equivelents
        txtTempBits = Replace(txtTempBits, "A", "10", , , CompareMethod.Text)
        txtTempBits = Replace(txtTempBits, "B", "11", , , CompareMethod.Text)
        txtTempBits = Replace(txtTempBits, "C", "12", , , CompareMethod.Text)
        txtTempBits = Replace(txtTempBits, "D", "13", , , CompareMethod.Text)
        txtTempBits = Replace(txtTempBits, "E", "14", , , CompareMethod.Text)
        txtTempBits = Replace(txtTempBits, "F", "15", , , CompareMethod.Text)


        ' Strip off a trailing comma
        If Strings.Right(txtTempBits,1) = "," then txtTempBits = Strings.Left(txtTempBits, txtTempBits.Length - 1)

        ' convert from space to comma delimited
        txtTempBits = Replace(txtTempBits, " ", ",")

        ' Copy completed parsing into results box
        txtResult.Text = txtTempBits

        Application.DoEvents()

        btnCopyToClipboard.Select()

    End Sub


    Private Sub btnCopyToClipboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyToClipboard.Click

        Clipboard.SetText(txtResult.Text)
        MsgBox("Copied")
        'btnCopyToClipboard.BackColor = Color.Green

    End Sub


    Private Sub txtData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtData.Click

        If Not boolBoxCleared Then txtData.Clear()
        boolBoxCleared = CBool(1)

    End Sub


    Private Sub txtData_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtData.KeyPress

        If Not boolBoxCleared Then txtData.Clear()
        boolBoxCleared = CBool(1)

    End Sub


    Private Sub btnBigRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBigRed.Click

        Call Form2.Show()

    End Sub


End Class
