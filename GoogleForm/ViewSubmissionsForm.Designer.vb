﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithub = New TextBox()
        txtStopwatch = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(296, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(322, 20)
        Label1.TabIndex = 0
        Label1.Text = "Hargun Singh, Slidely Task 2 - View Submission "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(276, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(276, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(259, 217)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 20)
        Label4.TabIndex = 3
        Label4.Text = "Phone num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(230, 256)
        Label5.Name = "Label5"
        Label5.Size = New Size(156, 20)
        Label5.TabIndex = 4
        Label5.Text = "GitHub Link for Task 2 "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(248, 303)
        Label6.Name = "Label6"
        Label6.Size = New Size(117, 20)
        Label6.TabIndex = 5
        Label6.Text = "Stopwatch time "
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.Control
        txtName.Location = New Point(419, 128)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(239, 27)
        txtName.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(419, 169)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(239, 27)
        txtEmail.TabIndex = 7
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(419, 214)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(239, 27)
        txtPhone.TabIndex = 8
        ' 
        ' txtGithub
        ' 
        txtGithub.Location = New Point(419, 256)
        txtGithub.Name = "txtGithub"
        txtGithub.ReadOnly = True
        txtGithub.Size = New Size(239, 27)
        txtGithub.TabIndex = 9
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.Location = New Point(419, 300)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(239, 27)
        txtStopwatch.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(248, 385)
        Button1.Name = "Button1"
        Button1.Size = New Size(184, 29)
        Button1.TabIndex = 11
        Button1.Text = "PREVIOUS (CTRL + P)"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(514, 385)
        Button2.Name = "Button2"
        Button2.Size = New Size(172, 29)
        Button2.TabIndex = 12
        Button2.Text = "NEXT (CTRL + N)"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(966, 650)
        Controls.Add(Button2)
        Controls.Add(Button1)
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
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
