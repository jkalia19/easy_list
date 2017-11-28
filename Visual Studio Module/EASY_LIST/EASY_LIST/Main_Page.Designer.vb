<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Page
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
        Me.RichTextBox_EL = New System.Windows.Forms.RichTextBox()
        Me.Butto_Reset = New System.Windows.Forms.Button()
        Me.Button_Sync = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox_EL
        '
        Me.RichTextBox_EL.Location = New System.Drawing.Point(54, 186)
        Me.RichTextBox_EL.Name = "RichTextBox_EL"
        Me.RichTextBox_EL.Size = New System.Drawing.Size(286, 315)
        Me.RichTextBox_EL.TabIndex = 7
        Me.RichTextBox_EL.Text = ""
        '
        'Butto_Reset
        '
        Me.Butto_Reset.Location = New System.Drawing.Point(466, 398)
        Me.Butto_Reset.Name = "Butto_Reset"
        Me.Butto_Reset.Size = New System.Drawing.Size(142, 58)
        Me.Butto_Reset.TabIndex = 6
        Me.Butto_Reset.Text = "Reset"
        Me.Butto_Reset.UseVisualStyleBackColor = True
        '
        'Button_Sync
        '
        Me.Button_Sync.BackColor = System.Drawing.Color.Lime
        Me.Button_Sync.Location = New System.Drawing.Point(466, 265)
        Me.Button_Sync.Name = "Button_Sync"
        Me.Button_Sync.Size = New System.Drawing.Size(142, 71)
        Me.Button_Sync.TabIndex = 5
        Me.Button_Sync.Text = "Sync"
        Me.Button_Sync.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EASY_LIST.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(240, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(265, 109)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Main_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EASY_LIST.My.Resources.Resources.ss
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(700, 533)
        Me.Controls.Add(Me.RichTextBox_EL)
        Me.Controls.Add(Me.Butto_Reset)
        Me.Controls.Add(Me.Button_Sync)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Main_Page"
        Me.Text = "List To Write"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox_EL As System.Windows.Forms.RichTextBox
    Friend WithEvents Butto_Reset As System.Windows.Forms.Button
    Friend WithEvents Button_Sync As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
