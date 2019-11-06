Imports System
Imports System.IO
Imports System.Reflection
Imports System.Threading
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Imports Discord
Imports Discord.API
Imports Discord.Analyzers
Imports Discord.Audio
Imports Discord.Commands
Imports Discord.Net
Imports Discord.Rest
Imports Discord.Webhook
Imports Discord.WebSocket

Imports Microsoft.Extensions.Configuration

Imports Newtonsoft
Imports Newtonsoft.Json
Public Class Form1
    Private discord As DiscordSocketClient
    Private discordCommands As CommandService
    Private discordConfig As DiscordConfig
    Private discordExt As DiscordClientExtensions
    Private discordSClient As DiscordShardedClient
    Dim wClient As New System.Net.WebClient
    Dim trigger As String = "!"
    Dim uptime As Integer = 0
    Dim admins() As String = {"Admin 1", "Admin 2)", "Admin 3"}
    Dim singles() As String = {"help", "info"}
    Dim doubles() As String = {"test1", "test2"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MessageBoxInfos.Visible = False
        Me.StatueImageDiscordServers.Image = Nothing
        Me.Timer1.Start()
        Me.Button3.Visible = False
        Me.Button2.Visible = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.StartBot()
    End Sub 'Start button

    Public Async Sub StartBot()
        Me.TextBox2.AppendText(vbCrLf & "[" & Date.Now & "] " & "> Starting the bot...")
        Try
            Me.StatueImageDiscordServers.Image = My.Resources.loading

            discord = New DiscordSocketClient(New DiscordSocketConfig With {
                                            .WebSocketProvider = Providers.WS4Net.WS4NetProvider.Instance,
                                            .UdpSocketProvider = Udp.DefaultUdpSocketProvider.Instance,
                                            .MessageCacheSize = 50
            })

            Await discord.LoginAsync(TokenType.Bot, "TOKEN HERE")
            Await discord.StartAsync()
            Await Task.Delay(500)
            Me.TextBox2.AppendText(vbCrLf & "[" & Date.Now & "] " & "Connected to Discord !")
            Me.RichTextBox1.SelectionColor = System.Drawing.Color.Gray
            Me.RichTextBox1.SelectionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.RichTextBox1.AppendText(vbCrLf & "[" & Date.Now & "] " & "* Connected to Discord.")
            Me.RichTextBox1.SelectionColor = System.Drawing.Color.Black
            Me.RichTextBox1.SelectionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.StatueImageDiscordServers.Image = My.Resources.ok
            Me.Button2.Visible = False
            Me.Button3.Visible = True
        Catch ex As Exception
            Me.TextBox2.AppendText(vbCrLf & "[" & Date.Now & "] " & "> ERROR ! Exception catched. (" & ex.Message & ")")
            Me.TextBox2.AppendText(vbCrLf & "[" & Date.Now & "] " & "> Starting stopped.")
            Me.StatueImageDiscordServers.Image = My.Resources.notok
        End Try

    End Sub
    Private Async Function Onmsg(message As SocketMessage) As Task
        If message.Source = MessageSource.Bot Then
            Me.RichTextBox1.AppendText(vbCrLf & "[" & Date.Now & "] " & "* Jaina speak.")
        Else
            Me.RichTextBox1.AppendText(vbCrLf & "[" & Date.Now & "] " & "* An user speak.")
            Dim userMessage As String = message.Content.ToString()
            Dim senderMessage As String = message.Author.Username.ToLower()
            Me.RichTextBox1.AppendText(vbCrLf & message.Author.Username & " say : " & userMessage)

            If userMessage.StartsWith(trigger) Then 'If it's an command
                If userMessage.Contains(" ") Then
                    Dim cmd As String = userMessage.Split(trigger)(1).Split(" ")(0)
                    Dim arg As String = userMessage.Split(" ")(1)
                    If singles.Contains(cmd) Then 'If the command don't need an value
                        Await message.Channel.SendMessageAsync("This command don't need value.")
                    Else
                        Select Case cmd.ToLower
                            Case "ping"
                                Dim result As String = "pong !"
                                Await message.Channel.SendMessageAsync(result)
                                Await Task.Delay(1000)
                            Case "kick"
                                Await DirectCast(message.Author, SocketGuildUser).KickAsync()
                            Case "ban"
                                Await DirectCast(message.Channel, IGuildChannel).Guild.AddBanAsync(message.MentionedUsers.FirstOrDefault)
                        Case "joke"
                                Me.RichTextBox1.SelectionColor = System.Drawing.Color.Gray
                                Me.RichTextBox1.SelectionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                                Me.RichTextBox1.AppendText(vbCrLf & "[" & Date.Now & "] " & "#" & message.Channel.Name & " | " & "* Getting the joke...")
                                Me.RichTextBox1.SelectionColor = System.Drawing.Color.Black
                                Me.RichTextBox1.SelectionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                                Dim result As String = wClient.DownloadString("http://chez-simon.io/elements/bot/joke.php") 'Source of the joke (Randome joke in PHP)
                                Await message.Channel.SendMessageAsync(result)
                                Await Task.Delay(1000)
                        End Select
                    End If
                End If
            Else 'If it's not an command
                ' « BOB ! DO SOMETHING »
            End If
        End If
    End Function

    Private Sub SendMessage()

    End Sub

#Region "AppDesign"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
    #End Region 'App design

#Region "AppWorking"
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Me.TextBox2.ScrollToCaret()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
    Me.TextBox2.AppendText(vbCrLf & "[" & Date.Now & "] " & "> Disconnection of the bot...")
            discord.StopAsync()
            Me.Button2.Visible = True
            Me.Button3.Visible = False
    Me.TextBox2.AppendText(vbCrLf & "[" & Date.Now & "] " & "Bot disconnected!")
        Catch ex As Exception
    Me.TextBox2.AppendText(vbCrLf & "[" & Date.Now & "] " & "> ERROR ! An exception happend. (" & ex.Message & ")")
    Me.TextBox2.AppendText(vbCrLf & "[" & Date.Now & "] " & "> Impossible to disconnect the bot.")
        End Try
        Me.Timer1.Stop()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SendMessage()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.SendMessage()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
    Me.TextBox2.AppendText(vbCrLf & "[" & Date.Now & "] " & "> Disconnecting the bot...")
            discord.StopAsync()
            Me.Button2.Visible = True
            Me.Button3.Visible = False
    Me.TextBox2.AppendText(vbCrLf & "[" & Date.Now & "] " & "Bot disconnected !")
        Catch ex As Exception
    Me.TextBox2.AppendText(vbCrLf & "[" & Date.Now & "] " & "> ERROR ! An exception happend. (" & ex.Message & ")")
    Me.TextBox2.AppendText(vbCrLf & "[" & Date.Now & "] " & "> Impossible to disconnect the bot.")
        End Try
    End Sub
#End Region 'App Working (Without Network)

End Class
