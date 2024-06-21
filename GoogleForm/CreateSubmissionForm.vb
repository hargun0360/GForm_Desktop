Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports System.Diagnostics
Imports System.Text.RegularExpressions

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
        Dim name = Controls("txtName").Text.Trim()
        Dim email = Controls("txtEmail").Text.Trim()
        Dim phone = Controls("txtPhone").Text.Trim()
        Dim github = Controls("txtGithub").Text.Trim()


        If name.Length <= 3 Then
            MessageBox.Show("Name must be greater than 3 characters.")
            Return
        End If

        Dim emailRegex As New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        If Not emailRegex.IsMatch(email) Then
            MessageBox.Show("Please enter a valid email address.")
            Return
        End If

        Dim phoneRegex As New Regex("^\d{10}$")
        If Not phoneRegex.IsMatch(phone) Then
            MessageBox.Show("Please enter a valid 10-digit Indian mobile number.")
            Return
        End If

        Dim githubRegex As New Regex("^https:\/\/github\.com\/[A-Za-z0-9._%+-]+\/?$")
        If Not githubRegex.IsMatch(github) Then
            MessageBox.Show("Please enter a valid GitHub URL.")
            Return
        End If

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
