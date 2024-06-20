<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        Button2 = New Button()
        txtStopwatch = New TextBox()
        txtGithub = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        txtName = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(212, 430)
        Button2.Name = "Button2"
        Button2.Size = New Size(453, 29)
        Button2.TabIndex = 25
        Button2.Text = "SUBMIT (CTRL + S)"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.Location = New Point(457, 345)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(208, 27)
        txtStopwatch.TabIndex = 23
        ' 
        ' txtGithub
        ' 
        txtGithub.Location = New Point(426, 301)
        txtGithub.Name = "txtGithub"
        txtGithub.Size = New Size(239, 27)
        txtGithub.TabIndex = 22
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(426, 259)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(239, 27)
        txtPhone.TabIndex = 21
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(426, 214)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(239, 27)
        txtEmail.TabIndex = 20
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.ButtonHighlight
        txtName.Location = New Point(426, 169)
        txtName.Name = "txtName"
        txtName.Size = New Size(239, 27)
        txtName.TabIndex = 19
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(217, 352)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 20)
        Label6.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(237, 301)
        Label5.Name = "Label5"
        Label5.Size = New Size(156, 20)
        Label5.TabIndex = 17
        Label5.Text = "GitHub Link for Task 2 "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(266, 262)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 20)
        Label4.TabIndex = 16
        Label4.Text = "Phone num"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(283, 221)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 15
        Label3.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(283, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 14
        Label2.Text = "Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(303, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(333, 20)
        Label1.TabIndex = 13
        Label1.Text = "Hargun Singh, Slidely Task 2 - Create Submission "
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(198, 345)
        Button3.Name = "Button3"
        Button3.Size = New Size(241, 29)
        Button3.TabIndex = 26
        Button3.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(942, 626)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(txtStopwatch)
        Controls.Add(txtGithub)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "CreateSubmissionForm"
        Text = "j"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
End Class
