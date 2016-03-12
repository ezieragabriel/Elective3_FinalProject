' EZIERA YVANNE V. GABRIEL
' BSCpE 5-2
' 2016

Public Class TitleScreen

    Private Sub button_Start_Click(sender As Object, e As EventArgs) Handles button_Start.Click
        Dim MainForm As New MainForm    ' opens the MainForm form
        MainForm.Show()                 ' and closes the TitleScreen form
        Me.Close()                      ' when button_Start is clicked
    End Sub

    Private Sub TitleScreen_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close() ' closes the TitleScreen form when "Esc" is pressed
    End Sub

    Private Sub TitleScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        button_Start.BackColor = Color.PaleGoldenrod    ' turns button_Start to PaleGoldenrod color
        PlayBackground()                                ' at Line 18, plays theme.wav audio after TitleScreen loads
    End Sub

    Sub PlayBackground()    ' plays the theme.wav resource as the form's background music
        My.Computer.Audio.Play(My.Resources.theme, _
                               AudioPlayMode.Background)
    End Sub
End Class