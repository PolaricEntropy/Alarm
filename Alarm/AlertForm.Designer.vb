<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlertForm
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
        Me.components = New System.ComponentModel.Container
        Me.btnShutdown = New System.Windows.Forms.Button
        Me.lblWarning = New System.Windows.Forms.Label
        Me.ColorTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnSnooze = New System.Windows.Forms.Button
        Me.lblAlarmInitiated = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnShutdown
        '
        Me.btnShutdown.BackColor = System.Drawing.Color.Black
        Me.btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShutdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShutdown.ForeColor = System.Drawing.Color.White
        Me.btnShutdown.Location = New System.Drawing.Point(54, 209)
        Me.btnShutdown.Name = "btnShutdown"
        Me.btnShutdown.Size = New System.Drawing.Size(161, 81)
        Me.btnShutdown.TabIndex = 8
        Me.btnShutdown.Text = "Shutdown!"
        Me.btnShutdown.UseVisualStyleBackColor = False
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning.ForeColor = System.Drawing.Color.White
        Me.lblWarning.Location = New System.Drawing.Point(47, 43)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(362, 39)
        Me.lblWarning.TabIndex = 9
        Me.lblWarning.Text = "Warning: Alarm Active!"
        '
        'ColorTimer
        '
        Me.ColorTimer.Interval = 1000
        '
        'btnSnooze
        '
        Me.btnSnooze.BackColor = System.Drawing.Color.Black
        Me.btnSnooze.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSnooze.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSnooze.ForeColor = System.Drawing.Color.White
        Me.btnSnooze.Location = New System.Drawing.Point(248, 209)
        Me.btnSnooze.Name = "btnSnooze"
        Me.btnSnooze.Size = New System.Drawing.Size(161, 81)
        Me.btnSnooze.TabIndex = 11
        Me.btnSnooze.Text = "Snooze!"
        Me.btnSnooze.UseVisualStyleBackColor = False
        '
        'lblAlarmInitiated
        '
        Me.lblAlarmInitiated.AutoSize = True
        Me.lblAlarmInitiated.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlarmInitiated.ForeColor = System.Drawing.Color.White
        Me.lblAlarmInitiated.Location = New System.Drawing.Point(143, 108)
        Me.lblAlarmInitiated.Name = "lblAlarmInitiated"
        Me.lblAlarmInitiated.Size = New System.Drawing.Size(170, 25)
        Me.lblAlarmInitiated.TabIndex = 10
        Me.lblAlarmInitiated.Text = "Alarm initiated: {0}"
        '
        'AlertForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(456, 366)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSnooze)
        Me.Controls.Add(Me.lblAlarmInitiated)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.btnShutdown)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AlertForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShutdown As System.Windows.Forms.Button
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    Friend WithEvents ColorTimer As System.Windows.Forms.Timer
    Friend WithEvents btnSnooze As System.Windows.Forms.Button
    Friend WithEvents lblAlarmInitiated As System.Windows.Forms.Label
End Class
