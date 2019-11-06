<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MessageBoxInfos = New System.Windows.Forms.Panel()
        Me.InfoMessageBoxBackground = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.InfoMessageBoxText = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatueImageDiscordServers = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MessageBoxInfos.SuspendLayout()
        Me.InfoMessageBoxBackground.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.StatueImageDiscordServers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 543)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(854, 24)
        Me.Panel1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(154, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(633, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Location = New System.Drawing.Point(787, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 20)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.DimGray
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(154, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Black
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Lime
        Me.TextBox2.Location = New System.Drawing.Point(3, 3)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(509, 511)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = resources.GetString("TextBox2.Text")
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(331, 543)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.MessageBoxInfos)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(329, 541)
        Me.Panel3.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 383)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 122)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Actions"
        '
        'MessageBoxInfos
        '
        Me.MessageBoxInfos.Controls.Add(Me.InfoMessageBoxBackground)
        Me.MessageBoxInfos.Dock = System.Windows.Forms.DockStyle.Top
        Me.MessageBoxInfos.Location = New System.Drawing.Point(0, 0)
        Me.MessageBoxInfos.Name = "MessageBoxInfos"
        Me.MessageBoxInfos.Padding = New System.Windows.Forms.Padding(3)
        Me.MessageBoxInfos.Size = New System.Drawing.Size(327, 67)
        Me.MessageBoxInfos.TabIndex = 4
        '
        'InfoMessageBoxBackground
        '
        Me.InfoMessageBoxBackground.BackColor = System.Drawing.Color.IndianRed
        Me.InfoMessageBoxBackground.Controls.Add(Me.Panel7)
        Me.InfoMessageBoxBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoMessageBoxBackground.ForeColor = System.Drawing.Color.White
        Me.InfoMessageBoxBackground.Location = New System.Drawing.Point(3, 3)
        Me.InfoMessageBoxBackground.Name = "InfoMessageBoxBackground"
        Me.InfoMessageBoxBackground.Padding = New System.Windows.Forms.Padding(2)
        Me.InfoMessageBoxBackground.Size = New System.Drawing.Size(321, 61)
        Me.InfoMessageBoxBackground.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.PictureBox2)
        Me.Panel7.Controls.Add(Me.InfoMessageBoxText)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.ForeColor = System.Drawing.Color.IndianRed
        Me.Panel7.Location = New System.Drawing.Point(2, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(317, 57)
        Me.Panel7.TabIndex = 0
        '
        'InfoMessageBoxText
        '
        Me.InfoMessageBoxText.Dock = System.Windows.Forms.DockStyle.Right
        Me.InfoMessageBoxText.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoMessageBoxText.Location = New System.Drawing.Point(55, 0)
        Me.InfoMessageBoxText.Name = "InfoMessageBoxText"
        Me.InfoMessageBoxText.Size = New System.Drawing.Size(262, 57)
        Me.InfoMessageBoxText.TabIndex = 0
        Me.InfoMessageBoxText.Text = "{ERROR_CODE}"
        Me.InfoMessageBoxText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(205, 511)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Start"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TabControl1.Location = New System.Drawing.Point(331, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(523, 543)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(515, 517)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Console"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RichTextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(515, 517)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Users activity"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(509, 511)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.StatueImageDiscordServers)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 304)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Services"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(31, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Discord server"
        '
        'StatueImageDiscordServers
        '
        Me.StatueImageDiscordServers.Image = Global.DiscordBot.My.Resources.Resources.loading
        Me.StatueImageDiscordServers.Location = New System.Drawing.Point(9, 19)
        Me.StatueImageDiscordServers.Name = "StatueImageDiscordServers"
        Me.StatueImageDiscordServers.Size = New System.Drawing.Size(16, 16)
        Me.StatueImageDiscordServers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StatueImageDiscordServers.TabIndex = 1
        Me.StatueImageDiscordServers.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.DiscordBot.My.Resources.Resources.system_error_icon
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Padding = New System.Windows.Forms.Padding(5)
        Me.PictureBox2.Size = New System.Drawing.Size(55, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.IndianRed
        Me.Button3.Location = New System.Drawing.Point(205, 511)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Stop"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(854, 567)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(870, 606)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DiscordBot"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MessageBoxInfos.ResumeLayout(False)
        Me.InfoMessageBoxBackground.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.StatueImageDiscordServers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents MessageBoxInfos As Panel
    Friend WithEvents InfoMessageBoxBackground As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents InfoMessageBoxText As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents StatueImageDiscordServers As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
End Class
