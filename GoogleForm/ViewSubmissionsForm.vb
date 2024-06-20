Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Public Class ViewSubmissionsForm

    Private submissions As List(Of Submission) = New List(Of Submission)()
    Private currentIndex As Integer = 0
    Private ReadOnly client As HttpClient

    Public Sub New()
        InitializeComponent()
        client = New HttpClient()
        client.BaseAddress = New Uri("http://localhost:3000/")
        client.DefaultRequestHeaders.Accept.Clear()
        client.DefaultRequestHeaders.Accept.Add(New Headers.MediaTypeWithQualityHeaderValue("application/json"))
    End Sub

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Me.Text = "John Doe, Slidely Task 2 - View Submissions"

        Await LoadSubmissions()
        DisplayCurrentSubmission()
    End Sub

    Private Async Function LoadSubmissions() As Task
        Dim response As HttpResponseMessage = Await client.GetAsync("api/read")
        If response.IsSuccessStatusCode Then
            Dim responseData As String = Await response.Content.ReadAsStringAsync()
            submissions = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of Submission))(responseData)
        Else
            MessageBox.Show("Failed to load submissions: " & response.ReasonPhrase)
        End If
    End Function

    Private Sub DisplayCurrentSubmission()
        If submissions.Count > 0 Then
            Dim submission = submissions(currentIndex)
            Me.Controls("txtName").Text = submission.Name
            Me.Controls("txtEmail").Text = submission.Email
            Me.Controls("txtPhone").Text = submission.Phone
            Me.Controls("txtGithub").Text = submission.GithubLink
            Me.Controls("txtStopwatch").Text = submission.StopwatchTime
        Else
            Me.Controls("txtName").Text = ""
            Me.Controls("txtEmail").Text = ""
            Me.Controls("txtPhone").Text = ""
            Me.Controls("txtGithub").Text = ""
            Me.Controls("txtStopwatch").Text = ""
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplayCurrentSubmission()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplayCurrentSubmission()
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            Button1.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            Button2.PerformClick()
        End If
    End Sub


End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GithubLink As String
    Public Property StopwatchTime As String

    Public Sub New(name As String, email As String, phone As String, githubLink As String, stopwatchTime As String)
        Me.Name = name
        Me.Email = email
        Me.Phone = phone
        Me.GithubLink = githubLink
        Me.StopwatchTime = stopwatchTime
    End Sub
End Class