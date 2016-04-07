Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Web
Imports Tweetinvi
Imports Tweetinvi.Core
Imports Tweetinvi.Core.Enum

Public Class TweetCheat
    Private Const targetAPI As String = "https://dev.twitter.com/docs/api/1.1/get/statuses/sample"
    Private oauth_consumer_key As String = ""
    Private oauth_consumer_secret = ""
    Private oauth_access_key = ""
    Private oauth_access_secret = ""
    Private myStream As Interfaces.Streaminvi.ISampleStream
    Private myStats As TweetStats
    Delegate Sub processDelegate(pTweet As Interfaces.ITweet)
    Delegate Sub updateDelegate()
    Delegate Sub streamDelegate()

#Region "Events"

    Private Sub TweetCheat_Load(sender As Object, e As EventArgs) Handles Me.Load
        Auth.SetUserCredentials(oauth_consumer_key, oauth_consumer_secret, oauth_access_key, oauth_access_secret)
        myStream = Tweetinvi.Stream.CreateSampleStream()
        myStream.AddTweetLanguageFilter(Language.English)
        AddHandler myStream.TweetReceived, AddressOf newTweet
    End Sub

    Private Sub newTweet(sender As Object, e As Events.EventArguments.TweetEventArgs)
        Dim pDel As processDelegate = AddressOf myStats.processTweet
        pDel.BeginInvoke(e.Tweet, New AsyncCallback(AddressOf returnInvoke), Nothing)
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        beginTracking()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Dim streamDel As New streamDelegate(AddressOf myStream.StopStream)
        streamDel.BeginInvoke(New AsyncCallback(AddressOf returnInvoke), Nothing)
        myStats.stopTime = Now
    End Sub

    Private Sub radAvg_Click(sender As Object, e As EventArgs) Handles radHour.Click, radMinute.Click, radSecond.Click
        factorAvg()
    End Sub

#End Region

#Region "Methods"

    ''' <summary>
    ''' initiates the tweet tracking process
    ''' </summary>
    Private Sub beginTracking()
        myStats = New TweetStats()
        updateScreen()
        Dim streamDel As New streamDelegate(AddressOf myStream.StartStream)
        streamDel.BeginInvoke(New AsyncCallback(AddressOf returnInvoke), Nothing)
    End Sub

    ''' <summary>
    ''' merging method for returning background threads
    ''' </summary>
    Private Sub returnInvoke()
        Dim updDel As New updateDelegate(AddressOf updateScreen)
        Me.BeginInvoke(updDel)
    End Sub

    ''' <summary>
    ''' UI updates
    ''' </summary>
    Private Sub updateScreen()
        If myStats IsNot Nothing Then
            SyncLock myStats
                lblTotalTweets.Text = String.Format("{0} Total Tweets", myStats.TotalTweets)
                factorAvg()
                setEmojiStats()
                setHashtagStats()
                setDomainStats()
                setPcts()
            End SyncLock
            Application.DoEvents()
        End If
    End Sub

    ''' <summary>
    ''' calculates and displays the average tweets per selected measure
    ''' </summary>
    Private Sub factorAvg()
        If myStats IsNot Nothing Then
            Select Case True
                Case radHour.Checked
                    lblAverage.Text = String.Format("{0} Tweets", myStats.getAvg(DateInterval.Hour))
                Case radMinute.Checked
                    lblAverage.Text = String.Format("{0} Tweets", myStats.getAvg(DateInterval.Minute))
                Case radSecond.Checked
                    lblAverage.Text = String.Format("{0} Tweets", myStats.getAvg(DateInterval.Second))
            End Select
        End If
    End Sub

    ''' <summary>
    ''' updates the screen with the emoji stats
    ''' </summary>
    Private Sub setEmojiStats()
        Dim lstTopEmoji As List(Of String) = myStats.getTop(TweetStats.tweetList.Emoji, 5)
        lbl1Emoji.Text = String.Format("#1 : {0}", lstTopEmoji(0))
        lbl2Emoji.Text = String.Format("#2 : {0}", lstTopEmoji(1))
        lbl3Emoji.Text = String.Format("#3 : {0}", lstTopEmoji(2))
        lbl4Emoji.Text = String.Format("#4 : {0}", lstTopEmoji(3))
        lbl5Emoji.Text = String.Format("#5 : {0}", lstTopEmoji(4))
    End Sub

    ''' <summary>
    ''' updates the screen with the hashtag stats
    ''' </summary>
    Private Sub setHashtagStats()
        Dim lstTopHash As List(Of String) = myStats.getTop(TweetStats.tweetList.Hashtag, 5)
        lbl1Hashtag.Text = String.Format("#1 : {0}", lstTopHash(0))
        lbl2Hashtag.Text = String.Format("#2 : {0}", lstTopHash(1))
        lbl3Hashtag.Text = String.Format("#3 : {0}", lstTopHash(2))
        lbl4Hashtag.Text = String.Format("#4 : {0}", lstTopHash(3))
        lbl5Hashtag.Text = String.Format("#5 : {0}", lstTopHash(4))
    End Sub

    ''' <summary>
    ''' updates the screen with the Domain stats
    ''' </summary>
    Private Sub setDomainStats()
        Dim lstTopDomain As List(Of String) = myStats.getTop(TweetStats.tweetList.Domain, 5)
        lbl1Domain.Text = String.Format("#1 : {0}", lstTopDomain(0))
        lbl2Domain.Text = String.Format("#2 : {0}", lstTopDomain(1))
        lbl3Domain.Text = String.Format("#3 : {0}", lstTopDomain(2))
        lbl4Domain.Text = String.Format("#4 : {0}", lstTopDomain(3))
        lbl5Domain.Text = String.Format("#5 : {0}", lstTopDomain(4))
    End Sub

    ''' <summary>
    ''' updates the screen with stat percentages
    ''' </summary>
    Private Sub setPcts()
        lblEmojiPct.Text = String.Format("{0}% of all Tweets Contain Emojis", myStats.EmojiPct)
        lblURLPct.Text = String.Format("{0}% of all Tweets Contain URLs", myStats.URLPct)
        lblPhotoPct.Text = String.Format("{0}% of all Tweets Contain Photos", myStats.PhotoPct)
        lblRetweetPct.Text = String.Format("{0}% of all Tweets are Retweets", myStats.RetweetPct)
    End Sub

#End Region

End Class
