' EZIERA YVANNE V. GABRIEL
' BSCpE 5-2
' 2016

Public Class WhatIsPigLatin

    Private Sub WhatIsPigLatin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then     ' form will close
            Me.Close()                      ' when "Esc" is pressed
        End If
    End Sub

End Class