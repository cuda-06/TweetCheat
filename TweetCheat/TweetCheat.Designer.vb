<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TweetCheat
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lblTotalTweets = New System.Windows.Forms.Label()
        Me.radHour = New System.Windows.Forms.RadioButton()
        Me.grpAverages = New System.Windows.Forms.GroupBox()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.radSecond = New System.Windows.Forms.RadioButton()
        Me.radMinute = New System.Windows.Forms.RadioButton()
        Me.grpTopEmojis = New System.Windows.Forms.GroupBox()
        Me.lbl3Emoji = New System.Windows.Forms.Label()
        Me.lbl2Emoji = New System.Windows.Forms.Label()
        Me.lbl1Emoji = New System.Windows.Forms.Label()
        Me.lblEmojiPct = New System.Windows.Forms.Label()
        Me.grpHashtags = New System.Windows.Forms.GroupBox()
        Me.lbl3Hashtag = New System.Windows.Forms.Label()
        Me.lbl2Hashtag = New System.Windows.Forms.Label()
        Me.lbl1Hashtag = New System.Windows.Forms.Label()
        Me.lblURLPct = New System.Windows.Forms.Label()
        Me.lblPhotoPct = New System.Windows.Forms.Label()
        Me.grpDomains = New System.Windows.Forms.GroupBox()
        Me.lbl3Domain = New System.Windows.Forms.Label()
        Me.lbl2Domain = New System.Windows.Forms.Label()
        Me.lbl1Domain = New System.Windows.Forms.Label()
        Me.lblRetweetPct = New System.Windows.Forms.Label()
        Me.dlgJsonFile = New System.Windows.Forms.OpenFileDialog()
        Me.lbl4Emoji = New System.Windows.Forms.Label()
        Me.lbl5Emoji = New System.Windows.Forms.Label()
        Me.lbl4Hashtag = New System.Windows.Forms.Label()
        Me.lbl5Hashtag = New System.Windows.Forms.Label()
        Me.lbl4Domain = New System.Windows.Forms.Label()
        Me.lbl5Domain = New System.Windows.Forms.Label()
        Me.grpAverages.SuspendLayout()
        Me.grpTopEmojis.SuspendLayout()
        Me.grpHashtags.SuspendLayout()
        Me.grpDomains.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(87, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start Tracking"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(12, 41)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(87, 23)
        Me.btnStop.TabIndex = 0
        Me.btnStop.Text = "Stop Tracking"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'lblTotalTweets
        '
        Me.lblTotalTweets.AutoSize = True
        Me.lblTotalTweets.Location = New System.Drawing.Point(170, 17)
        Me.lblTotalTweets.Name = "lblTotalTweets"
        Me.lblTotalTweets.Size = New System.Drawing.Size(69, 13)
        Me.lblTotalTweets.TabIndex = 1
        Me.lblTotalTweets.Text = "Total Tweets"
        '
        'radHour
        '
        Me.radHour.AutoSize = True
        Me.radHour.Location = New System.Drawing.Point(6, 19)
        Me.radHour.Name = "radHour"
        Me.radHour.Size = New System.Drawing.Size(67, 17)
        Me.radHour.TabIndex = 2
        Me.radHour.TabStop = True
        Me.radHour.Text = "Per Hour"
        Me.radHour.UseVisualStyleBackColor = True
        '
        'grpAverages
        '
        Me.grpAverages.Controls.Add(Me.lblAverage)
        Me.grpAverages.Controls.Add(Me.radSecond)
        Me.grpAverages.Controls.Add(Me.radMinute)
        Me.grpAverages.Controls.Add(Me.radHour)
        Me.grpAverages.Location = New System.Drawing.Point(314, 263)
        Me.grpAverages.Name = "grpAverages"
        Me.grpAverages.Size = New System.Drawing.Size(282, 141)
        Me.grpAverages.TabIndex = 3
        Me.grpAverages.TabStop = False
        Me.grpAverages.Text = "Averages"
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(133, 20)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(51, 13)
        Me.lblAverage.TabIndex = 3
        Me.lblAverage.Text = "0 Tweets"
        '
        'radSecond
        '
        Me.radSecond.AutoSize = True
        Me.radSecond.Checked = True
        Me.radSecond.Location = New System.Drawing.Point(6, 65)
        Me.radSecond.Name = "radSecond"
        Me.radSecond.Size = New System.Drawing.Size(81, 17)
        Me.radSecond.TabIndex = 2
        Me.radSecond.TabStop = True
        Me.radSecond.Text = "Per Second"
        Me.radSecond.UseVisualStyleBackColor = True
        '
        'radMinute
        '
        Me.radMinute.AutoSize = True
        Me.radMinute.Location = New System.Drawing.Point(6, 42)
        Me.radMinute.Name = "radMinute"
        Me.radMinute.Size = New System.Drawing.Size(76, 17)
        Me.radMinute.TabIndex = 2
        Me.radMinute.Text = "Per Minute"
        Me.radMinute.UseVisualStyleBackColor = True
        '
        'grpTopEmojis
        '
        Me.grpTopEmojis.Controls.Add(Me.lbl5Emoji)
        Me.grpTopEmojis.Controls.Add(Me.lbl4Emoji)
        Me.grpTopEmojis.Controls.Add(Me.lbl3Emoji)
        Me.grpTopEmojis.Controls.Add(Me.lbl2Emoji)
        Me.grpTopEmojis.Controls.Add(Me.lbl1Emoji)
        Me.grpTopEmojis.Location = New System.Drawing.Point(12, 116)
        Me.grpTopEmojis.Name = "grpTopEmojis"
        Me.grpTopEmojis.Size = New System.Drawing.Size(282, 141)
        Me.grpTopEmojis.TabIndex = 4
        Me.grpTopEmojis.TabStop = False
        Me.grpTopEmojis.Text = "Emojis"
        '
        'lbl3Emoji
        '
        Me.lbl3Emoji.AutoSize = True
        Me.lbl3Emoji.Location = New System.Drawing.Point(7, 75)
        Me.lbl3Emoji.Name = "lbl3Emoji"
        Me.lbl3Emoji.Size = New System.Drawing.Size(23, 13)
        Me.lbl3Emoji.TabIndex = 0
        Me.lbl3Emoji.Text = "# 3"
        '
        'lbl2Emoji
        '
        Me.lbl2Emoji.AutoSize = True
        Me.lbl2Emoji.Location = New System.Drawing.Point(7, 47)
        Me.lbl2Emoji.Name = "lbl2Emoji"
        Me.lbl2Emoji.Size = New System.Drawing.Size(23, 13)
        Me.lbl2Emoji.TabIndex = 0
        Me.lbl2Emoji.Text = "# 2"
        '
        'lbl1Emoji
        '
        Me.lbl1Emoji.AutoSize = True
        Me.lbl1Emoji.Location = New System.Drawing.Point(7, 20)
        Me.lbl1Emoji.Name = "lbl1Emoji"
        Me.lbl1Emoji.Size = New System.Drawing.Size(23, 13)
        Me.lbl1Emoji.TabIndex = 0
        Me.lbl1Emoji.Text = "# 1"
        '
        'lblEmojiPct
        '
        Me.lblEmojiPct.AutoSize = True
        Me.lblEmojiPct.Location = New System.Drawing.Point(311, 65)
        Me.lblEmojiPct.Name = "lblEmojiPct"
        Me.lblEmojiPct.Size = New System.Drawing.Size(150, 13)
        Me.lblEmojiPct.TabIndex = 1
        Me.lblEmojiPct.Text = "% of all Tweets Contain Emojis"
        '
        'grpHashtags
        '
        Me.grpHashtags.Controls.Add(Me.lbl5Hashtag)
        Me.grpHashtags.Controls.Add(Me.lbl4Hashtag)
        Me.grpHashtags.Controls.Add(Me.lbl3Hashtag)
        Me.grpHashtags.Controls.Add(Me.lbl2Hashtag)
        Me.grpHashtags.Controls.Add(Me.lbl1Hashtag)
        Me.grpHashtags.Location = New System.Drawing.Point(314, 116)
        Me.grpHashtags.Name = "grpHashtags"
        Me.grpHashtags.Size = New System.Drawing.Size(282, 141)
        Me.grpHashtags.TabIndex = 4
        Me.grpHashtags.TabStop = False
        Me.grpHashtags.Text = "Hashtags"
        '
        'lbl3Hashtag
        '
        Me.lbl3Hashtag.AutoSize = True
        Me.lbl3Hashtag.Location = New System.Drawing.Point(7, 75)
        Me.lbl3Hashtag.Name = "lbl3Hashtag"
        Me.lbl3Hashtag.Size = New System.Drawing.Size(23, 13)
        Me.lbl3Hashtag.TabIndex = 0
        Me.lbl3Hashtag.Text = "# 3"
        '
        'lbl2Hashtag
        '
        Me.lbl2Hashtag.AutoSize = True
        Me.lbl2Hashtag.Location = New System.Drawing.Point(7, 47)
        Me.lbl2Hashtag.Name = "lbl2Hashtag"
        Me.lbl2Hashtag.Size = New System.Drawing.Size(23, 13)
        Me.lbl2Hashtag.TabIndex = 0
        Me.lbl2Hashtag.Text = "# 2"
        '
        'lbl1Hashtag
        '
        Me.lbl1Hashtag.AutoSize = True
        Me.lbl1Hashtag.Location = New System.Drawing.Point(7, 20)
        Me.lbl1Hashtag.Name = "lbl1Hashtag"
        Me.lbl1Hashtag.Size = New System.Drawing.Size(23, 13)
        Me.lbl1Hashtag.TabIndex = 0
        Me.lbl1Hashtag.Text = "# 1"
        '
        'lblURLPct
        '
        Me.lblURLPct.AutoSize = True
        Me.lblURLPct.Location = New System.Drawing.Point(311, 17)
        Me.lblURLPct.Name = "lblURLPct"
        Me.lblURLPct.Size = New System.Drawing.Size(151, 13)
        Me.lblURLPct.TabIndex = 1
        Me.lblURLPct.Text = "% of all Tweets Contain a URL"
        '
        'lblPhotoPct
        '
        Me.lblPhotoPct.AutoSize = True
        Me.lblPhotoPct.Location = New System.Drawing.Point(311, 41)
        Me.lblPhotoPct.Name = "lblPhotoPct"
        Me.lblPhotoPct.Size = New System.Drawing.Size(182, 13)
        Me.lblPhotoPct.TabIndex = 1
        Me.lblPhotoPct.Text = "% of all Tweets Contain a Photo URL"
        '
        'grpDomains
        '
        Me.grpDomains.Controls.Add(Me.lbl5Domain)
        Me.grpDomains.Controls.Add(Me.lbl4Domain)
        Me.grpDomains.Controls.Add(Me.lbl3Domain)
        Me.grpDomains.Controls.Add(Me.lbl2Domain)
        Me.grpDomains.Controls.Add(Me.lbl1Domain)
        Me.grpDomains.Location = New System.Drawing.Point(12, 263)
        Me.grpDomains.Name = "grpDomains"
        Me.grpDomains.Size = New System.Drawing.Size(282, 141)
        Me.grpDomains.TabIndex = 4
        Me.grpDomains.TabStop = False
        Me.grpDomains.Text = "Domains"
        '
        'lbl3Domain
        '
        Me.lbl3Domain.AutoSize = True
        Me.lbl3Domain.Location = New System.Drawing.Point(7, 75)
        Me.lbl3Domain.Name = "lbl3Domain"
        Me.lbl3Domain.Size = New System.Drawing.Size(23, 13)
        Me.lbl3Domain.TabIndex = 0
        Me.lbl3Domain.Text = "# 3"
        '
        'lbl2Domain
        '
        Me.lbl2Domain.AutoSize = True
        Me.lbl2Domain.Location = New System.Drawing.Point(7, 47)
        Me.lbl2Domain.Name = "lbl2Domain"
        Me.lbl2Domain.Size = New System.Drawing.Size(23, 13)
        Me.lbl2Domain.TabIndex = 0
        Me.lbl2Domain.Text = "# 2"
        '
        'lbl1Domain
        '
        Me.lbl1Domain.AutoSize = True
        Me.lbl1Domain.Location = New System.Drawing.Point(7, 20)
        Me.lbl1Domain.Name = "lbl1Domain"
        Me.lbl1Domain.Size = New System.Drawing.Size(23, 13)
        Me.lbl1Domain.TabIndex = 0
        Me.lbl1Domain.Text = "# 1"
        '
        'lblRetweetPct
        '
        Me.lblRetweetPct.AutoSize = True
        Me.lblRetweetPct.Location = New System.Drawing.Point(311, 89)
        Me.lblRetweetPct.Name = "lblRetweetPct"
        Me.lblRetweetPct.Size = New System.Drawing.Size(144, 13)
        Me.lblRetweetPct.TabIndex = 1
        Me.lblRetweetPct.Text = "% of all Tweets are Retweets"
        '
        'dlgJsonFile
        '
        Me.dlgJsonFile.Filter = "JSON files|*.json"
        '
        'lbl4Emoji
        '
        Me.lbl4Emoji.AutoSize = True
        Me.lbl4Emoji.Location = New System.Drawing.Point(7, 101)
        Me.lbl4Emoji.Name = "lbl4Emoji"
        Me.lbl4Emoji.Size = New System.Drawing.Size(23, 13)
        Me.lbl4Emoji.TabIndex = 0
        Me.lbl4Emoji.Text = "# 4"
        '
        'lbl5Emoji
        '
        Me.lbl5Emoji.AutoSize = True
        Me.lbl5Emoji.Location = New System.Drawing.Point(7, 125)
        Me.lbl5Emoji.Name = "lbl5Emoji"
        Me.lbl5Emoji.Size = New System.Drawing.Size(23, 13)
        Me.lbl5Emoji.TabIndex = 0
        Me.lbl5Emoji.Text = "# 5"
        '
        'lbl4Hashtag
        '
        Me.lbl4Hashtag.AutoSize = True
        Me.lbl4Hashtag.Location = New System.Drawing.Point(7, 101)
        Me.lbl4Hashtag.Name = "lbl4Hashtag"
        Me.lbl4Hashtag.Size = New System.Drawing.Size(23, 13)
        Me.lbl4Hashtag.TabIndex = 0
        Me.lbl4Hashtag.Text = "# 4"
        '
        'lbl5Hashtag
        '
        Me.lbl5Hashtag.AutoSize = True
        Me.lbl5Hashtag.Location = New System.Drawing.Point(7, 125)
        Me.lbl5Hashtag.Name = "lbl5Hashtag"
        Me.lbl5Hashtag.Size = New System.Drawing.Size(23, 13)
        Me.lbl5Hashtag.TabIndex = 0
        Me.lbl5Hashtag.Text = "# 5"
        '
        'lbl4Domain
        '
        Me.lbl4Domain.AutoSize = True
        Me.lbl4Domain.Location = New System.Drawing.Point(7, 99)
        Me.lbl4Domain.Name = "lbl4Domain"
        Me.lbl4Domain.Size = New System.Drawing.Size(23, 13)
        Me.lbl4Domain.TabIndex = 0
        Me.lbl4Domain.Text = "# 4"
        '
        'lbl5Domain
        '
        Me.lbl5Domain.AutoSize = True
        Me.lbl5Domain.Location = New System.Drawing.Point(7, 123)
        Me.lbl5Domain.Name = "lbl5Domain"
        Me.lbl5Domain.Size = New System.Drawing.Size(23, 13)
        Me.lbl5Domain.TabIndex = 0
        Me.lbl5Domain.Text = "# 5"
        '
        'TweetCheat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 408)
        Me.Controls.Add(Me.lblRetweetPct)
        Me.Controls.Add(Me.lblEmojiPct)
        Me.Controls.Add(Me.lblPhotoPct)
        Me.Controls.Add(Me.lblURLPct)
        Me.Controls.Add(Me.grpDomains)
        Me.Controls.Add(Me.grpHashtags)
        Me.Controls.Add(Me.grpTopEmojis)
        Me.Controls.Add(Me.grpAverages)
        Me.Controls.Add(Me.lblTotalTweets)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "TweetCheat"
        Me.Text = "Tweet Cheat"
        Me.grpAverages.ResumeLayout(False)
        Me.grpAverages.PerformLayout()
        Me.grpTopEmojis.ResumeLayout(False)
        Me.grpTopEmojis.PerformLayout()
        Me.grpHashtags.ResumeLayout(False)
        Me.grpHashtags.PerformLayout()
        Me.grpDomains.ResumeLayout(False)
        Me.grpDomains.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents lblTotalTweets As Label
    Friend WithEvents radHour As RadioButton
    Friend WithEvents grpAverages As GroupBox
    Friend WithEvents lblAverage As Label
    Friend WithEvents radSecond As RadioButton
    Friend WithEvents radMinute As RadioButton
    Friend WithEvents grpTopEmojis As GroupBox
    Friend WithEvents lblEmojiPct As Label
    Friend WithEvents lbl3Emoji As Label
    Friend WithEvents lbl2Emoji As Label
    Friend WithEvents lbl1Emoji As Label
    Friend WithEvents grpHashtags As GroupBox
    Friend WithEvents lbl3Hashtag As Label
    Friend WithEvents lbl2Hashtag As Label
    Friend WithEvents lbl1Hashtag As Label
    Friend WithEvents lblURLPct As Label
    Friend WithEvents lblPhotoPct As Label
    Friend WithEvents grpDomains As GroupBox
    Friend WithEvents lbl3Domain As Label
    Friend WithEvents lbl2Domain As Label
    Friend WithEvents lbl1Domain As Label
    Friend WithEvents lblRetweetPct As Label
    Friend WithEvents dlgJsonFile As OpenFileDialog
    Friend WithEvents lbl5Emoji As Label
    Friend WithEvents lbl4Emoji As Label
    Friend WithEvents lbl5Hashtag As Label
    Friend WithEvents lbl4Hashtag As Label
    Friend WithEvents lbl5Domain As Label
    Friend WithEvents lbl4Domain As Label
End Class
