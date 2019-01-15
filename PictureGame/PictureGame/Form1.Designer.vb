<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DifficultyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EasyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Medium = New System.Windows.Forms.ToolStripMenuItem()
        Me.HardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpossibleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.picDoggo = New System.Windows.Forms.PictureBox()
        Me.tmrMove = New System.Windows.Forms.Timer(Me.components)
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picDoggo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DifficultyToolStripMenuItem, Me.HelpToolStripMenuItem, Me.CloseToolStripMenuItem, Me.StopToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(620, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DifficultyToolStripMenuItem
        '
        Me.DifficultyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EasyToolStripMenuItem, Me.Medium, Me.HardToolStripMenuItem, Me.ImpossibleToolStripMenuItem})
        Me.DifficultyToolStripMenuItem.Name = "DifficultyToolStripMenuItem"
        Me.DifficultyToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.DifficultyToolStripMenuItem.Text = "Difficulty"
        '
        'EasyToolStripMenuItem
        '
        Me.EasyToolStripMenuItem.Name = "EasyToolStripMenuItem"
        Me.EasyToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.EasyToolStripMenuItem.Text = "Easy"
        '
        'Medium
        '
        Me.Medium.Name = "Medium"
        Me.Medium.Size = New System.Drawing.Size(131, 22)
        Me.Medium.Text = "Medium"
        '
        'HardToolStripMenuItem
        '
        Me.HardToolStripMenuItem.Name = "HardToolStripMenuItem"
        Me.HardToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.HardToolStripMenuItem.Text = "Hard"
        '
        'ImpossibleToolStripMenuItem
        '
        Me.ImpossibleToolStripMenuItem.Name = "ImpossibleToolStripMenuItem"
        Me.ImpossibleToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ImpossibleToolStripMenuItem.Text = "Impossible"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 27)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(172, 42)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start Game"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblTimer
        '
        Me.lblTimer.Location = New System.Drawing.Point(266, 27)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(120, 42)
        Me.lblTimer.TabIndex = 2
        Me.lblTimer.Text = "Time Left: 30 Seconds"
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblScore
        '
        Me.lblScore.Location = New System.Drawing.Point(496, 27)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(100, 42)
        Me.lblScore.TabIndex = 3
        Me.lblScore.Text = "Score: 0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picDoggo
        '
        Me.picDoggo.Image = Global.PictureGame.My.Resources.Resources.Doggo
        Me.picDoggo.Location = New System.Drawing.Point(266, 329)
        Me.picDoggo.Name = "picDoggo"
        Me.picDoggo.Size = New System.Drawing.Size(120, 100)
        Me.picDoggo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDoggo.TabIndex = 4
        Me.picDoggo.TabStop = False
        '
        'tmrMove
        '
        Me.tmrMove.Interval = 50
        '
        'tmrClock
        '
        Me.tmrClock.Interval = 50
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 692)
        Me.Controls.Add(Me.picDoggo)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Picture Game"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picDoggo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DifficultyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EasyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Medium As ToolStripMenuItem
    Friend WithEvents HardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpossibleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnStart As Button
    Friend WithEvents lblTimer As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents picDoggo As PictureBox
    Friend WithEvents tmrMove As Timer
    Friend WithEvents tmrClock As Timer
    Friend WithEvents StopToolStripMenuItem As ToolStripMenuItem
End Class
