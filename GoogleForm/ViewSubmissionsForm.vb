Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Imports GoogleForm.Submission
Public Class ViewSubmissionsForm

    Private currentIndex As Integer = 0
    Private ReadOnly client As HttpClient

    Public Sub New()
        InitializeComponent()
        client = New HttpClient()
        client.BaseAddress = New Uri("http://localhost:3000/")
        client.DefaultRequestHeaders.Accept.Clear()
        client.DefaultRequestHeaders.Accept.Add(New Headers.MediaTypeWithQualityHeaderValue("application/json"))
    End Sub


    Private Async Function LoadSubmission(index As Integer) As Task(Of Submission)
        Dim response As HttpResponseMessage = Await client.GetAsync($"api/read?index={index}")
        If response.IsSuccessStatusCode Then
            Dim responseData As String = Await response.Content.ReadAsStringAsync()
            Return JsonConvert.DeserializeObject(Of Submission)(responseData)
        Else
            MessageBox.Show("Failed to load submission: " & response.ReasonPhrase)
            Return Nothing
        End If
    End Function

    Private Async Function DisplayCurrentSubmission() As Task
        Dim submission As Submission = Await LoadSubmission(currentIndex)
        If submission IsNot Nothing Then
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
    End Function

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, MyBase.Click

        If currentIndex > 0 Then
            currentIndex -= 1
            Await DisplayCurrentSubmission()
        End If
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, MyBase.Click
        currentIndex += 1
        Await DisplayCurrentSubmission()
    End Sub

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Me.Text = "John Doe, Slidely Task 2 - View Submissions"
        Await DisplayCurrentSubmission()
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            Button1.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            Button2.PerformClick()
        End If
    End Sub


End Class
