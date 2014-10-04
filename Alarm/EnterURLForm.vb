Public Class EnterURLForm

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    Private Sub EnterForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadLocalization()
    End Sub

    Private Sub LoadLocalization()
        lblInfo.Text = GetCorrectLanguageFromFile("[EnterURLForm]", "lblInfo")
        btnOk.Text = GetCorrectLanguageFromFile("[EnterURLForm]", "btnOk")
    End Sub
End Class