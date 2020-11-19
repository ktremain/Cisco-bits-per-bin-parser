Public Class Form2

    Dim iClick As Integer


    Private Sub Form2_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        Application.DoEvents()

        Debug.Print(CStr(ProgressBar1.Step))

        ProgressBar1.PerformStep()
        Application.DoEvents()
        Threading.Thread.Sleep(250)
        Application.DoEvents()
        ProgressBar1.PerformStep()
        Application.DoEvents()
        Threading.Thread.Sleep(250)
        Application.DoEvents()
        ProgressBar1.PerformStep()
        Application.DoEvents()
        Threading.Thread.Sleep(250)
        Application.DoEvents()
        ProgressBar1.PerformStep()
        Application.DoEvents()
        Threading.Thread.Sleep(250)
        Application.DoEvents()
        ProgressBar1.PerformStep()
        Application.DoEvents()
        Threading.Thread.Sleep(250)
        Application.DoEvents()
        ProgressBar1.PerformStep()
        Application.DoEvents()
        Threading.Thread.Sleep(250)
        Application.DoEvents()
        ProgressBar1.PerformStep()
        Application.DoEvents()
        Threading.Thread.Sleep(250)
        Application.DoEvents()
        ProgressBar1.PerformStep()
        Application.DoEvents()
        Threading.Thread.Sleep(250)
        Application.DoEvents()
        ProgressBar1.PerformStep()
        Application.DoEvents()
        Threading.Thread.Sleep(250)
        Application.DoEvents()
        ProgressBar1.PerformStep()
        Application.DoEvents()


    End Sub


    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'Throw New DivideByZeroException
        End

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Button1.Location = New Point(CInt(Rnd() * 250), CInt(Rnd() * 250))
        iClick = iClick + 1

        If iClick = 2 Then Application.SetSuspendState(PowerState.Suspend, True, False)

    End Sub

End Class