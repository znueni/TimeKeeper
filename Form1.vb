Public Class Form1
    Private SizeAdd As Integer = 0
    Private Target As DateTime = Date.MinValue
    Private DurationMinutes As Integer = 10
    Private ForeColor As Color = Color.Black

    Private Sub Form1_Resize() Handles MyBase.Resize
        Dim sz As Single = (Me.Width * 0.189) + SizeAdd
        lbl.Font = New Font(lbl.Font.FontFamily, sz, GraphicsUnit.Point)
    End Sub

    Private Sub RestartTimer() Handles RestartTimerToolStripMenuItem.Click
        Target = Date.Now.AddMinutes(DurationMinutes)
        RefreshTick()
    End Sub

    Private Sub NewTimer_Click(sender As Object, e As EventArgs) Handles ResetTimerDurationToolStripMenuItem.Click, lbl.MouseDoubleClick
        Dim inp As String = InputBox("Set the timer to how many minutes?", "Time keeper", DurationMinutes.ToString())
        If inp > "" And IsNumeric(inp) Then
            DurationMinutes = Integer.Parse(inp)
            RestartTimer()
        End If
    End Sub

    Private Sub MaximizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaximizeToolStripMenuItem.Click
        If WindowState = FormWindowState.Maximized Then WindowState = FormWindowState.Normal Else WindowState = FormWindowState.Maximized
        Form1_Resize()
    End Sub

    Private Sub HideFormBorderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideFormBorderToolStripMenuItem.Click
        If FormBorderStyle = FormBorderStyle.None Then FormBorderStyle = FormBorderStyle.Sizable Else FormBorderStyle = FormBorderStyle.None
        Form1_Resize()
    End Sub

    Private Sub IncreaseTextSizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncreaseTextSizeToolStripMenuItem.Click
        SizeAdd += 10
        Form1_Resize()
    End Sub

    Private Sub DecreaseTextSizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecreaseTextSizeToolStripMenuItem.Click
        SizeAdd -= 10
        Form1_Resize()
    End Sub

    Private Sub AlwaysStayOnTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlwaysStayOnTopToolStripMenuItem.Click
        Me.TopMost = Not Me.TopMost
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        AlwaysStayOnTopToolStripMenuItem.Checked = TopMost
        MaximizeToolStripMenuItem.Checked = (Me.WindowState = FormWindowState.Maximized)
        HideFormBorderToolStripMenuItem.Checked = (Me.FormBorderStyle = FormBorderStyle.None)
        InvertColorsToolStripMenuItem.Checked = (lbl.BackColor = Color.Black)
    End Sub

    Private Sub RefreshTick() Handles Timer1.Tick
        If Target = Date.MinValue Then Exit Sub

        Dim ts As TimeSpan = Target.Subtract(Date.Now)
        Dim txt As String
        If ts.TotalHours > 1 Then
            txt = ts.ToString("H\:mm\:ss")
            lbl.Font = New Font(lbl.Font, FontStyle.Regular)
        Else
            txt = ts.ToString("mm\:ss")
            lbl.Font = New Font(lbl.Font, FontStyle.Bold)
        End If
        If Target < Date.Now Then
            txt = "-" & txt
            lbl.ForeColor = Color.Red
        Else : lbl.ForeColor = ForeColor
        End If
        If lbl.Text <> txt Then lbl.Text = txt
    End Sub

    Private Sub InvertColorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvertColorsToolStripMenuItem.Click
        If lbl.BackColor = Color.Black Then
            ForeColor = Color.Black
            lbl.BackColor = Color.White
        Else
            lbl.BackColor = Color.Black
            ForeColor = Color.White
        End If
        lbl.ForeColor = ForeColor
    End Sub
End Class
