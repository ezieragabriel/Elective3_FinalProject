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
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhatIsPigLatinStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.textbox_Word = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label_PigLatinWord = New System.Windows.Forms.Label()
        Me.button_Main = New System.Windows.Forms.Button()
        Me.button_Clear = New System.Windows.Forms.Button()
        Me.label_note = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.menuStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(460, 24)
        Me.menuStrip.TabIndex = 0
        Me.menuStrip.Text = "Main Menu"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WhatIsPigLatinStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.MenuToolStripMenuItem.Text = "&Help"
        '
        'WhatIsPigLatinStripMenuItem
        '
        Me.WhatIsPigLatinStripMenuItem.Name = "WhatIsPigLatinStripMenuItem"
        Me.WhatIsPigLatinStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.WhatIsPigLatinStripMenuItem.Text = "&What is Pig Latin?"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'textbox_Word
        '
        Me.textbox_Word.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.textbox_Word.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_Word.Location = New System.Drawing.Point(122, 64)
        Me.textbox_Word.Name = "textbox_Word"
        Me.textbox_Word.Size = New System.Drawing.Size(200, 22)
        Me.textbox_Word.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter a word:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(171, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pig Latin-ed word:"
        '
        'label_PigLatinWord
        '
        Me.label_PigLatinWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label_PigLatinWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_PigLatinWord.Location = New System.Drawing.Point(122, 154)
        Me.label_PigLatinWord.Name = "label_PigLatinWord"
        Me.label_PigLatinWord.Size = New System.Drawing.Size(200, 41)
        Me.label_PigLatinWord.TabIndex = 4
        Me.label_PigLatinWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'button_Main
        '
        Me.button_Main.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_Main.Location = New System.Drawing.Point(328, 59)
        Me.button_Main.Name = "button_Main"
        Me.button_Main.Size = New System.Drawing.Size(104, 33)
        Me.button_Main.TabIndex = 5
        Me.button_Main.Text = "Translate It!"
        Me.button_Main.UseVisualStyleBackColor = True
        '
        'button_Clear
        '
        Me.button_Clear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_Clear.Location = New System.Drawing.Point(352, 98)
        Me.button_Clear.Name = "button_Clear"
        Me.button_Clear.Size = New System.Drawing.Size(62, 24)
        Me.button_Clear.TabIndex = 6
        Me.button_Clear.Text = "Clear"
        Me.button_Clear.UseVisualStyleBackColor = True
        '
        'label_note
        '
        Me.label_note.AutoSize = True
        Me.label_note.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_note.Location = New System.Drawing.Point(205, 258)
        Me.label_note.Name = "label_note"
        Me.label_note.Size = New System.Drawing.Size(243, 13)
        Me.label_note.TabIndex = 7
        Me.label_note.Text = "Press ""Enter"" to translate and ""Esc"" to clear fields"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Elective3_FinalProject.My.Resources.Resources.giphy
        Me.PictureBox1.Location = New System.Drawing.Point(12, 178)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AcceptButton = Me.button_Main
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CancelButton = Me.button_Clear
        Me.ClientSize = New System.Drawing.Size(460, 280)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.label_note)
        Me.Controls.Add(Me.button_Clear)
        Me.Controls.Add(Me.button_Main)
        Me.Controls.Add(Me.label_PigLatinWord)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textbox_Word)
        Me.Controls.Add(Me.menuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuStrip
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(476, 319)
        Me.MinimumSize = New System.Drawing.Size(476, 319)
        Me.Name = "MainForm"
        Me.Text = "Pig Latin"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WhatIsPigLatinStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents textbox_Word As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents label_PigLatinWord As System.Windows.Forms.Label
    Friend WithEvents button_Main As System.Windows.Forms.Button
    Friend WithEvents button_Clear As System.Windows.Forms.Button
    Friend WithEvents label_note As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
