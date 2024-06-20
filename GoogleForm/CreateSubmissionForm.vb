Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports System.Diagnostics

Imports GoogleForm.Submission

Public Class CreateSubmissionForm
    Private stopwatch As Stopwatch = New Stopwatch()
    Private ReadOnly client As HttpClient
    Private WithEvents timer As Timer

    Public Sub New()
        InitializeComponent()
        timer = New Timer()
        timer.Interval = 1000
        client = New HttpClient()
        client.BaseAddress = New Uri("http://localhost:3000/")
        client.DefaultRequestHeaders.Accept.Clear()
        client.DefaultRequestHeaders.Accept.Add(New Headers.MediaTypeWithQualityHeaderValue("application/json"))
    End Sub

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Me.Text = "John Doe, Slidely Task 2 - Create Submission"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click, MyBase.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            timer.Stop()
            Button3.Text = "Resume"
        Else
            stopwatch.Start()
            timer.Start()
            Button3.Text = "Pause"
        End If
        Controls("txtStopwatch").Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        txtStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, MyBase.Click
        Dim name = Controls("txtName").Text
        Dim email = Controls("txtEmail").Text
        Dim phone = Controls("txtPhone").Text
        Dim github = Controls("txtGithub").Text
        Dim stopwatchTime = stopwatch.Elapsed.ToString("hh\:mm\:ss")

        Dim submission As New Submission(name, email, phone, github, stopwatchTime)
        Dim jsonData = JsonConvert.SerializeObject(submission)

        Dim content As New StringContent(jsonData, Encoding.UTF8, "application/json")
        Dim response = Await client.PostAsync("api/submit", content)
        If response.IsSuccessStatusCode Then
            MessageBox.Show("Submission saved!")
            Close()
        Else
            MessageBox.Show("Failed to save submission: " & response.ReasonPhrase)
        End If
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            Button2.PerformClick()
        End If
    End Sub
End Class
