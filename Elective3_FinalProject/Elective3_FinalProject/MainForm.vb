' EZIERA YVANNE V. GABRIEL
' BSCpE 5-2
' 2016

Public Class MainForm

    Dim pigLatinWord As String  ' String where the input and output word will be stored
    Dim vowels() As Char    ' Char array where vowels are stored

    Dim prefixLength As Integer ' Integer where number of consonants in the beginning of the word will be stored
    Dim suffixString As String  ' String where suffixes "yay" and "ay" are stored. Value will depend on the value of prefixLength

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        button_Main.BackColor = Color.PaleVioletRed ' changes button_Main's color to PaleVioletRed after mainForm loads
        button_Clear.BackColor = Color.PeachPuff    ' changes button_Clear's color to PeachPuff after mainForm loads

        PlayBackground()    ' at line 66, plays theme.wav audio after MainForm loads

    End Sub

    Public Sub button_Main_Click(sender As Object, e As EventArgs) Handles button_Main.Click

        If textbox_Word.Text = "" Then  ' if textbox is empty

            textbox_Word.Text = ""      ' it will remain empty as well as label_PigLatinWord
            textbox_Word.Focus()        ' focus is still on textbox for faster input of next word
            PlayErrorSound()            ' at Line 71, will play your system's error sound

        Else                            ' else, if textbox is not empty (which means you input a word)

            pigLatinWord = textbox_Word.Text    ' contents of the textbox will be stored in String variable pigLatinWord
            vowels = "AEIOU".ToCharArray()    ' a string of vowels and numbers is converted to Char array and stored to "vowels" Array
            prefixLength = pigLatinWord.ToUpper().IndexOfAny(vowels)    ' ToUpper() = pigLatinWord will be converted to uppercase letters
            ' ...                                                       ' IndexOfAny() = reports the zero-based index of the first occurence of character that belongs in the "vowels" array.
            ' ...                                                       ' store the index to prefixLength variable

            ' For example a word "latin" was entered.
            ' Public function IndexOfAny() (with "vowels" array as its parameter), will return the index of the first "vowels" character it detected in the string "latin".
            ' In this case, 'a' is the first "vowels" character to appear and 'a' has the index of 1 (zero-based). Therefore, the prefixLength variable will have a value of 1.
            ' Somehow in this program, IndexOfAny function counts the number of consonants there are in the beginning of pigLatinWord to detect if the word begins with a vowel or with a consonant.
            ' If the word is "eat", IndexOfAny() will return a value of 0 because a "vowels" character, e, appeared in the beginning of the word, therefore there are 0 consonants in the beginning of the word.

            If (prefixLength = 0) Then  ' if prefixLength is 0, it means that the word begins with a vowel
                suffixString = "yay"    ' accourding to the rules of Pig Latin, if the word starts with a vowel, the suffix will be "yay"
            Else                        ' else, if prefixLength has a value other than 0, (starts with a consonant)
                suffixString = "ay"     ' the suffix will be "ay"
            End If

            pigLatinWord = pigLatinWord.Substring(prefixLength).ToLower() & pigLatinWord.Substring(0, prefixLength).ToLower() & suffixString
            ' First Substring() = pigLatinWord will be displayed starting from the Substring parameter prefixLength. If prefixLength has a value, pigLatinWord will be cut and the second half will be taken.
            ' Second Substring() = after displaying the second half of the word, the first half will be displayed after it. Remember, Pig Latin is an encryption game used to hide the original words.
            ' ... It jumbles the letters of the words in a consistent manner.
            ' suffixString will be added in the end after the words are jumbled
            ' the jumbled word will be stored to pigLatinWord variable and will be its new value

            label_PigLatinWord.Text = pigLatinWord  ' the new pigLatinWord will be displayed in the label as the encrypted word

        End If
    End Sub

    Private Sub button_Clear_Click(sender As Object, e As EventArgs) Handles button_Clear.Click
        textbox_Word.Text = ""          ' clears fields
        label_PigLatinWord.Text = ""    ' when button is clicked
    End Sub

    Private Sub HowToPlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhatIsPigLatinStripMenuItem.Click
        Dim WhatIsPigLatin As New WhatIsPigLatin    ' show WhatIsPigLatin form
        WhatIsPigLatin.Show()                       ' when What Is Pig Latin menu is clicked

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim About As New About  ' show About form
        About.Show()            ' when About menu is clicked
    End Sub

    Private Sub textbox_Word_KeyDown(sender As Object, e As KeyEventArgs) Handles textbox_Word.KeyDown
        If e.KeyCode = Keys.Space Then  ' space is not allowed
            e.SuppressKeyPress = True   ' to be typed in the textbox
        End If
    End Sub

    Private Sub textbox_Word_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textbox_Word.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"       ' accepts only letters, and;
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then   ' rejects numbers and special characters
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Sub PlayBackground()    ' plays the theme.wav resource as the form's background music
        My.Computer.Audio.Play(My.Resources.theme, _
                               AudioPlayMode.Background)
    End Sub

    Sub PlayErrorSound()    ' plays the system's Asterisk sound as an error sound
        My.Computer.Audio.PlaySystemSound( _
            System.Media.SystemSounds.Asterisk)
    End Sub

End Class
