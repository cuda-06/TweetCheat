Imports Tweetinvi.Core.Interfaces
Imports Tweetinvi.Core.Interfaces.Models.Entities
Imports System.IO
Imports System.Web.Script.Serialization
Imports System.Globalization

Public Class TweetStats

#Region "Properties"

    Public ReadOnly Property TotalTweets As Double
    Private ReadOnly Property TotalEmojis As Double
    Private ReadOnly Property TotalHashtags As Double
    Private ReadOnly Property TotalUrls As Double
    Private ReadOnly Property TotalPhotos As Double
    Private ReadOnly Property TotalRetweets As Double
    Public ReadOnly Property EmojiPct As Double
        Get
            Return getPct(TotalEmojis)
        End Get
    End Property
    Public ReadOnly Property URLPct As Double
        Get
            Return getPct(TotalUrls)
        End Get
    End Property
    Public ReadOnly Property PhotoPct As Double
        Get
            Return getPct(TotalPhotos)
        End Get
    End Property
    Public ReadOnly Property RetweetPct As Double
        Get
            Return getPct(TotalRetweets)
        End Get
    End Property
    Private lstEmojis As New List(Of KeyValuePair(Of String, Double))
    Private lstHashtags As New List(Of KeyValuePair(Of String, Double))
    Private lstDomains As New List(Of KeyValuePair(Of String, Double))
    Private startTime As DateTime
    Public Property stopTime As DateTime
    Public Enum tweetList
        Emoji
        Hashtag
        Domain
    End Enum

#End Region

#Region "Public Methods"

    Public Sub New()
        startTime = Now
    End Sub

    ''' <summary>
    ''' evaluates the supplied tweet for the required statistics
    ''' </summary>
    ''' <param name="currTweet"></param>
    Public Sub processTweet(currTweet As ITweet)
        _TotalTweets += 1
        For Each currHashtag As IHashtagEntity In currTweet.Hashtags
            _TotalHashtags += 1
            addHashItem(currHashtag.Text, lstHashtags)
        Next
        processEmojiText(currTweet.Text)
        For Each url As IUrlEntity In currTweet.Urls
            _TotalUrls += 1
            If url.ExpandedURL.Contains("pic.twitter.com") Or url.ExpandedURL.Contains("instagram.com") Then
                _TotalPhotos += 1
            End If
            Dim myUri As New Uri(url.ExpandedURL)
            Dim baseUri As String = myUri.GetLeftPart(UriPartial.Authority)
            addHashItem(baseUri, lstDomains)
        Next
        If currTweet.IsRetweet Then
            _TotalRetweets += 1
        End If
    End Sub

    ''' <summary>
    ''' returns the average number of tweets per supplied measure of time
    ''' </summary>
    ''' <param name="whichMeasure">Hour, Minute, or Second</param>
    ''' <returns></returns>
    Public Function getAvg(whichMeasure As DateInterval) As Double
        Dim ts As TimeSpan
        If Not stopTime > DateTime.MinValue Then
            ts = Now - startTime
        Else
            ts = stopTime - startTime
        End If
        Select Case whichMeasure
            Case DateInterval.Hour
                Return TotalTweets / ts.TotalHours
            Case DateInterval.Minute
                Return TotalTweets / ts.TotalMinutes
            Case Else
                Return TotalTweets / ts.TotalSeconds
        End Select
    End Function

    ''' <summary>
    ''' gets the top emoji or hashtag from the currently processed tweets
    ''' </summary>
    ''' <param name="listType">Domain, Emoji or Hashtag</param>
    ''' <param name="howMany">how many top items to retrieve</param>
    ''' <returns></returns>
    Public Function getTop(listType As tweetList, howMany As Integer) As List(Of String)
        Dim whichList As List(Of KeyValuePair(Of String, Double)) = Nothing
        Select Case listType
            Case tweetList.Emoji
                whichList = lstEmojis
            Case tweetList.Hashtag
                whichList = lstHashtags
            Case tweetList.Domain
                whichList = lstDomains
        End Select
        Dim lstTop As New List(Of String)
        If whichList IsNot Nothing AndAlso whichList.Count > 0 Then
            whichList.Sort(Function(kv1, kv2) kv1.Value.CompareTo(kv2.Value))
            whichList.Reverse()
        End If
        For i As Integer = 0 To howMany - 1 Step 1
            If whichList.Count > i Then
                If whichList(i).Value = 1 Then
                    lstTop.Add(String.Format("{0} - {1} occurence", whichList(i).Key, whichList(i).Value))
                Else
                    lstTop.Add(String.Format("{0} - {1} occurences", whichList(i).Key, whichList(i).Value))
                End If
            Else
                lstTop.Add("")
            End If
        Next
        Return lstTop
    End Function

#End Region

#Region "Private Methods"

    ''' <summary>
    ''' increases the hash counts with the supplied key string value
    ''' </summary>
    ''' <param name="itemText">the unique text which will be used as a key</param>
    ''' <param name="whichList">the keyvaluepairlist to modify</param>
    Private Sub addHashItem(itemText As String, whichList As List(Of KeyValuePair(Of String, Double)))
        itemText = itemText.Trim
        Dim itemIndex As Integer = whichList.FindIndex(Function(x) x.Key = itemText)
        If itemIndex > -1 Then
            Dim currPair As New KeyValuePair(Of String, Double)(itemText, whichList(itemIndex).Value + 1)
            whichList(itemIndex) = currPair
        Else
            Dim newPair As New KeyValuePair(Of String, Double)(itemText, 1)
            whichList.Add(newPair)
        End If
    End Sub

    ''' <summary>
    ''' gets the percentage of the overall tweets containing the supplied count type
    ''' </summary>
    ''' <param name="whichCount">the count for the statistical group to evaluate</param>
    ''' <returns></returns>
    Private Function getPct(whichCount As Double) As Double
        If whichCount > 0 Then
            Return (whichCount / TotalTweets) * 100
        Else
            Return 0
        End If
    End Function

    ''' <summary>
    ''' combs tweet text for emojis
    ''' </summary>
    ''' <param name="text">complete tweet text</param>
    Private Sub processEmojiText(text As String)
        Dim enumerator = StringInfo.GetTextElementEnumerator(text)
        While enumerator.MoveNext()
            Dim ele As String = enumerator.GetTextElement()
            If Char.IsSurrogatePair(ele, 0) Then
                _TotalEmojis += 1
                addHashItem(ele, lstEmojis)
            End If
        End While
    End Sub

#End Region
End Class
