<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.CurrentTimeClock = New Clock.ClockControl
        Me.lblCurrentTime = New System.Windows.Forms.Label
        Me.lblAlarmTime = New System.Windows.Forms.Label
        Me.AlarmTimeClock = New Clock.ClockControl
        Me.txtAlarmTime = New System.Windows.Forms.TextBox
        Me.lblEnterTime = New System.Windows.Forms.Label
        Me.btnSetAlarm = New System.Windows.Forms.Button
        Me.AlarmThread = New System.ComponentModel.BackgroundWorker
        Me.lblMethodOfWaking = New System.Windows.Forms.Label
        Me.cmbMethodOfWaking = New System.Windows.Forms.ComboBox
        Me.lblSnoozeTime = New System.Windows.Forms.Label
        Me.txtSnooze = New System.Windows.Forms.TextBox
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer
        Me.btnTest = New System.Windows.Forms.Button
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CurrentTimeClock
        '
        Me.CurrentTimeClock.AutoSize = True
        Me.CurrentTimeClock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CurrentTimeClock.ClockMode = Clock.ClockControl.e_ClockMode.Clock
        Me.CurrentTimeClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentTimeClock.ForeColor = System.Drawing.Color.White
        Me.CurrentTimeClock.Location = New System.Drawing.Point(23, 36)
        Me.CurrentTimeClock.Name = "CurrentTimeClock"
        Me.CurrentTimeClock.NrOfMillisecondsDigits = CType(0, Short)
        Me.CurrentTimeClock.Size = New System.Drawing.Size(238, 63)
        Me.CurrentTimeClock.TabIndex = 0
        '
        'lblCurrentTime
        '
        Me.lblCurrentTime.AutoSize = True
        Me.lblCurrentTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTime.ForeColor = System.Drawing.Color.White
        Me.lblCurrentTime.Location = New System.Drawing.Point(69, 9)
        Me.lblCurrentTime.Name = "lblCurrentTime"
        Me.lblCurrentTime.Size = New System.Drawing.Size(140, 24)
        Me.lblCurrentTime.TabIndex = 1
        Me.lblCurrentTime.Text = "Nuvarande tid"
        '
        'lblAlarmTime
        '
        Me.lblAlarmTime.AutoSize = True
        Me.lblAlarmTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlarmTime.ForeColor = System.Drawing.Color.White
        Me.lblAlarmTime.Location = New System.Drawing.Point(96, 111)
        Me.lblAlarmTime.Name = "lblAlarmTime"
        Me.lblAlarmTime.Size = New System.Drawing.Size(86, 24)
        Me.lblAlarmTime.TabIndex = 2
        Me.lblAlarmTime.Text = "Alarmtid"
        '
        'AlarmTimeClock
        '
        Me.AlarmTimeClock.AutoSize = True
        Me.AlarmTimeClock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AlarmTimeClock.ClockMode = Clock.ClockControl.e_ClockMode.Alarm
        Me.AlarmTimeClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmTimeClock.ForeColor = System.Drawing.Color.White
        Me.AlarmTimeClock.Location = New System.Drawing.Point(23, 138)
        Me.AlarmTimeClock.Name = "AlarmTimeClock"
        Me.AlarmTimeClock.NrOfMillisecondsDigits = CType(0, Short)
        Me.AlarmTimeClock.Size = New System.Drawing.Size(238, 63)
        Me.AlarmTimeClock.TabIndex = 3
        '
        'txtAlarmTime
        '
        Me.txtAlarmTime.BackColor = System.Drawing.Color.Black
        Me.txtAlarmTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlarmTime.ForeColor = System.Drawing.Color.White
        Me.txtAlarmTime.Location = New System.Drawing.Point(23, 329)
        Me.txtAlarmTime.Name = "txtAlarmTime"
        Me.txtAlarmTime.Size = New System.Drawing.Size(75, 20)
        Me.txtAlarmTime.TabIndex = 4
        '
        'lblEnterTime
        '
        Me.lblEnterTime.AutoSize = True
        Me.lblEnterTime.ForeColor = System.Drawing.Color.White
        Me.lblEnterTime.Location = New System.Drawing.Point(12, 301)
        Me.lblEnterTime.Name = "lblEnterTime"
        Me.lblEnterTime.Size = New System.Drawing.Size(111, 13)
        Me.lblEnterTime.TabIndex = 5
        Me.lblEnterTime.Text = "Alarm time: (hh:mm:ss)"
        '
        'btnSetAlarm
        '
        Me.btnSetAlarm.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSetAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetAlarm.ForeColor = System.Drawing.Color.White
        Me.btnSetAlarm.Location = New System.Drawing.Point(105, 374)
        Me.btnSetAlarm.Name = "btnSetAlarm"
        Me.btnSetAlarm.Size = New System.Drawing.Size(75, 23)
        Me.btnSetAlarm.TabIndex = 6
        Me.btnSetAlarm.Text = "Sätt alarm"
        Me.btnSetAlarm.UseVisualStyleBackColor = True
        '
        'AlarmThread
        '
        '
        'lblMethodOfWaking
        '
        Me.lblMethodOfWaking.AutoSize = True
        Me.lblMethodOfWaking.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMethodOfWaking.ForeColor = System.Drawing.Color.White
        Me.lblMethodOfWaking.Location = New System.Drawing.Point(55, 217)
        Me.lblMethodOfWaking.Name = "lblMethodOfWaking"
        Me.lblMethodOfWaking.Size = New System.Drawing.Size(174, 24)
        Me.lblMethodOfWaking.TabIndex = 7
        Me.lblMethodOfWaking.Text = "Method of waking"
        '
        'cmbMethodOfWaking
        '
        Me.cmbMethodOfWaking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMethodOfWaking.FormattingEnabled = True
        Me.cmbMethodOfWaking.Location = New System.Drawing.Point(54, 245)
        Me.cmbMethodOfWaking.Name = "cmbMethodOfWaking"
        Me.cmbMethodOfWaking.Size = New System.Drawing.Size(176, 21)
        Me.cmbMethodOfWaking.TabIndex = 8
        '
        'lblSnoozeTime
        '
        Me.lblSnoozeTime.AutoSize = True
        Me.lblSnoozeTime.ForeColor = System.Drawing.Color.White
        Me.lblSnoozeTime.Location = New System.Drawing.Point(151, 301)
        Me.lblSnoozeTime.Name = "lblSnoozeTime"
        Me.lblSnoozeTime.Size = New System.Drawing.Size(121, 13)
        Me.lblSnoozeTime.TabIndex = 9
        Me.lblSnoozeTime.Text = "Snooze time: (hh:mm:ss)"
        '
        'txtSnooze
        '
        Me.txtSnooze.BackColor = System.Drawing.Color.Black
        Me.txtSnooze.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSnooze.ForeColor = System.Drawing.Color.White
        Me.txtSnooze.Location = New System.Drawing.Point(174, 329)
        Me.txtSnooze.Name = "txtSnooze"
        Me.txtSnooze.Size = New System.Drawing.Size(75, 20)
        Me.txtSnooze.TabIndex = 10
        Me.txtSnooze.Text = "00:09:00"
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(186, 374)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(75, 23)
        Me.AxWindowsMediaPlayer1.TabIndex = 11
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'btnTest
        '
        Me.btnTest.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTest.ForeColor = System.Drawing.Color.White
        Me.btnTest.Location = New System.Drawing.Point(23, 374)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 23)
        Me.btnTest.TabIndex = 12
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.btnSetAlarm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(284, 409)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.txtSnooze)
        Me.Controls.Add(Me.lblSnoozeTime)
        Me.Controls.Add(Me.cmbMethodOfWaking)
        Me.Controls.Add(Me.lblMethodOfWaking)
        Me.Controls.Add(Me.btnSetAlarm)
        Me.Controls.Add(Me.lblEnterTime)
        Me.Controls.Add(Me.txtAlarmTime)
        Me.Controls.Add(Me.AlarmTimeClock)
        Me.Controls.Add(Me.lblAlarmTime)
        Me.Controls.Add(Me.lblCurrentTime)
        Me.Controls.Add(Me.CurrentTimeClock)
        Me.Name = "MainForm"
        Me.Text = "Alarm system"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CurrentTimeClock As Clock.ClockControl
    Friend WithEvents lblCurrentTime As System.Windows.Forms.Label
    Friend WithEvents lblAlarmTime As System.Windows.Forms.Label
    Friend WithEvents AlarmTimeClock As Clock.ClockControl
    Friend WithEvents txtAlarmTime As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterTime As System.Windows.Forms.Label
    Friend WithEvents btnSetAlarm As System.Windows.Forms.Button
    Friend WithEvents AlarmThread As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblMethodOfWaking As System.Windows.Forms.Label
    Friend WithEvents cmbMethodOfWaking As System.Windows.Forms.ComboBox
    Friend WithEvents lblSnoozeTime As System.Windows.Forms.Label
    Friend WithEvents txtSnooze As System.Windows.Forms.TextBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnTest As System.Windows.Forms.Button

End Class
