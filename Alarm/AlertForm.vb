Public Class AlertForm

    Private Sub AlertForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadLocalization()
        ColorTimer.Start()
        lblAlarmInitiated.Text = String.Format(lblAlarmInitiated.Text, MainForm.TimeInitiated)
        CenterControlHorizontally(lblAlarmInitiated, Me)
        Me.Focus()
        Me.TopMost = True
        Me.SetTopLevel(True)
    End Sub

    Private Sub LoadLocalization()
        lblWarning.Text = GetCorrectLanguageFromFile("[AlertForm]", "lblWarning")
        lblAlarmInitiated.Text = GetCorrectLanguageFromFile("[AlertForm]", "lblAlarmInitiated")
        btnShutdown.Text = GetCorrectLanguageFromFile("[AlertForm]", "btnShutdown")
        btnSnooze.Text = GetCorrectLanguageFromFile("[AlertForm]", "btnSnooze")
    End Sub

    Private Sub ColorTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorTimer.Tick

        Select Case lblWarning.ForeColor
            Case Color.Red
                lblWarning.ForeColor = Color.White
            Case Color.White
                lblWarning.ForeColor = Color.Red
        End Select

        Select Case lblAlarmInitiated.ForeColor
            Case Color.Red
                lblAlarmInitiated.ForeColor = Color.White
            Case Color.White
                lblAlarmInitiated.ForeColor = Color.Red
        End Select

        Select Case btnShutdown.ForeColor
            Case Color.Red
                btnShutdown.ForeColor = Color.White
            Case Color.White
                btnShutdown.ForeColor = Color.Red
        End Select

        Select Case btnSnooze.ForeColor
            Case Color.Red
                btnSnooze.ForeColor = Color.White
            Case Color.White
                btnSnooze.ForeColor = Color.Red
        End Select

    End Sub

    Private Sub btnSnooze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSnooze.Click
        MainForm.UserHitButton = True
        MainForm.AlarmTimeClock.SetClock(TimeSpan.Parse(MainForm.txtSnooze.Text) + MainForm.AlarmTimeClock.Time)
        Me.Close()
    End Sub

    Private Sub btnShutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShutdown.Click
        MainForm.UserHitButton = True
        Me.Close()
    End Sub

End Class