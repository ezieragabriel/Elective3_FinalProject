<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WhatIsPigLatin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WhatIsPigLatin))
        Me.label_first = New System.Windows.Forms.Label()
        Me.label_second = New System.Windows.Forms.Label()
        Me.label_third = New System.Windows.Forms.Label()
        Me.label_fourth = New System.Windows.Forms.Label()
        Me.label_fifth = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'label_first
        '
        Me.label_first.AutoSize = True
        Me.label_first.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_first.Location = New System.Drawing.Point(26, 24)
        Me.label_first.Name = "label_first"
        Me.label_first.Size = New System.Drawing.Size(90, 24)
        Me.label_first.TabIndex = 0
        Me.label_first.Text = "Pig Latin"
        '
        'label_second
        '
        Me.label_second.AutoSize = True
        Me.label_second.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_second.Location = New System.Drawing.Point(118, 28)
        Me.label_second.Name = "label_second"
        Me.label_second.Size = New System.Drawing.Size(237, 18)
        Me.label_second.TabIndex = 1
        Me.label_second.Text = "is a language game in which words"
        '
        'label_third
        '
        Me.label_third.AutoSize = True
        Me.label_third.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_third.Location = New System.Drawing.Point(27, 49)
        Me.label_third.Name = "label_third"
        Me.label_third.Size = New System.Drawing.Size(331, 108)
        Me.label_third.TabIndex = 2
        Me.label_third.Text = resources.GetString("label_third.Text")
        '
        'label_fourth
        '
        Me.label_fourth.AutoSize = True
        Me.label_fourth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_fourth.Location = New System.Drawing.Point(27, 183)
        Me.label_fourth.Name = "label_fourth"
        Me.label_fourth.Size = New System.Drawing.Size(322, 90)
        Me.label_fourth.TabIndex = 3
        Me.label_fourth.Text = resources.GetString("label_fourth.Text")
        '
        'label_fifth
        '
        Me.label_fifth.AutoSize = True
        Me.label_fifth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_fifth.Location = New System.Drawing.Point(27, 289)
        Me.label_fifth.Name = "label_fifth"
        Me.label_fifth.Size = New System.Drawing.Size(336, 54)
        Me.label_fifth.TabIndex = 4
        Me.label_fifth.Text = "For words that begin with vowel sounds or a silent" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "letter, one just adds ""yay"" t" & _
    "o the end." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Example: ""eat"" -> ""eatyay"""
        '
        'WhatIsPigLatin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(377, 357)
        Me.Controls.Add(Me.label_fifth)
        Me.Controls.Add(Me.label_fourth)
        Me.Controls.Add(Me.label_third)
        Me.Controls.Add(Me.label_second)
        Me.Controls.Add(Me.label_first)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "WhatIsPigLatin"
        Me.Text = "What is Pig Latin?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label_first As System.Windows.Forms.Label
    Friend WithEvents label_second As System.Windows.Forms.Label
    Friend WithEvents label_third As System.Windows.Forms.Label
    Friend WithEvents label_fourth As System.Windows.Forms.Label
    Friend WithEvents label_fifth As System.Windows.Forms.Label
End Class
