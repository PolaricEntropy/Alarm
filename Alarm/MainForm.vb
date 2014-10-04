Public Class MainForm

    Private m_UserHitButton As Boolean
    Friend TimeInitiated As Date
    Friend URLPath As String

    Private Event AlarmIsSounding()

    Public Property UserHitButton() As Boolean
        Get
            Return m_UserHitButton
        End Get
        Set(ByVal value As Boolean)
            m_UserHitButton = value
            'Audio-file.
            If cmbMethodOfWaking.SelectedIndex = 1 Then
                AxWindowsMediaPlayer1.Ctlcontrols.stop()
            End If
        End Set
    End Property

    Private Sub btnSetAlarm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetAlarm.Click
        Try
            'Set the clock and save the time when this was done. Center the clock also since it has a different with than before.
            AlarmTimeClock.SetClock(Date.Parse(txtAlarmTime.Text).Hour, Date.Parse(txtAlarmTime.Text).Minute, Date.Parse(txtAlarmTime.Text).Second)
            TimeInitiated = Date.Now
            CenterControlHorizontally(AlarmTimeClock, Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Set the clock to null and center it. Load the localization and select the first method of waking so that atleast a method is selected.
        AlarmTimeClock.SetNull()
        CenterControlHorizontally(AlarmTimeClock, Me)
        LoadLocalization()
        cmbMethodOfWaking.SelectedIndex = 0
    End Sub

    Private Sub LoadLocalization()
        lblCurrentTime.Text = GetCorrectLanguageFromFile("[MainForm]", "lblCurrentTime")
        lblAlarmTime.Text = GetCorrectLanguageFromFile("[MainForm]", "lblAlarmTime")
        lblMethodOfWaking.Text = GetCorrectLanguageFromFile("[MainForm]", "lblMethodOfWaking")
        lblEnterTime.Text = GetCorrectLanguageFromFile("[MainForm]", "lblEnterTime")
        lblSnoozeTime.Text = GetCorrectLanguageFromFile("[MainForm]", "lblSnoozeTime")
        btnSetAlarm.Text = GetCorrectLanguageFromFile("[MainForm]", "btnSetAlarm")
        btnTest.Text = GetCorrectLanguageFromFile("[MainForm]", "btnTest")
        Me.Text = GetCorrectLanguageFromFile("[MainForm]", "Title")

        cmbMethodOfWaking.Items.Clear()
        cmbMethodOfWaking.Items.Add(GetCorrectLanguageFromFile("[MainForm]", "cmbMethodOfWaking[0]"))
        cmbMethodOfWaking.Items.Add(GetCorrectLanguageFromFile("[MainForm]", "cmbMethodOfWaking[1]"))
        cmbMethodOfWaking.Items.Add(GetCorrectLanguageFromFile("[MainForm]", "cmbMethodOfWaking[2]"))

        CenterControlHorizontally(lblCurrentTime, Me)
        CenterControlHorizontally(lblAlarmTime, Me)
        CenterControlHorizontally(lblMethodOfWaking, Me)
    End Sub

    Private Sub SoundAlarm() Handles Me.AlarmIsSounding
        Dim newAlertForm As New AlertForm
        newAlertForm.Show()

        Select Case cmbMethodOfWaking.SelectedIndex
            Case 0
                AlarmThread.RunWorkerAsync()
            Case 1

                If My.Computer.FileSystem.FileExists(URLPath) Then
                    AxWindowsMediaPlayer1.settings.volume = 100
                    AxWindowsMediaPlayer1.URL = URLPath
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                Else
                    AlarmThread.RunWorkerAsync()
                End If
            Case 2
                Diagnostics.Process.Start(URLPath)
        End Select
    End Sub

    Private Sub AlarmThread_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles AlarmThread.DoWork
        Do Until UserHitButton
            Console.Beep()
            Threading.Thread.Sleep(1000)
        Loop
    End Sub

    Private Sub AlarmTimeClock_AlarmTimeReached() Handles AlarmTimeClock.AlarmTimeReached
        RaiseEvent AlarmIsSounding()
    End Sub

    Private Sub cmbMethodOfWaking_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMethodOfWaking.SelectedIndexChanged
        Select Case cmbMethodOfWaking.SelectedIndex
            Case 1
                Dim OpenFiles As New OpenFileDialog
                OpenFiles.Filter = GetCorrectLanguageFromFile("[MainForm]", "AudioFilter")
                OpenFiles.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyMusic
                If OpenFiles.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    URLPath = OpenFiles.FileName
                End If
            Case 2
                Dim fEnterForm As New EnterURLForm
                fEnterForm.ShowDialog()
                URLPath = fEnterForm.TextBox1.Text
        End Select
    End Sub

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        RaiseEvent AlarmIsSounding()
    End Sub
End Class
