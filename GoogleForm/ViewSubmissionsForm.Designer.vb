<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        BtnEditSubmission = New Button()
        BtnDeleteSubmission = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("STZhongsong", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(207, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(525, 23)
        Label1.TabIndex = 0
        Label1.Text = "Hargun Singh, Slidely Task 2 - View Submission"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("STZhongsong", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(276, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 17)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("STZhongsong", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(276, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 17)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("STZhongsong", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(259, 217)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 17)
        Label4.TabIndex = 3
        Label4.Text = "Phone num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("STZhongsong", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(217, 261)
        Label5.Name = "Label5"
        Label5.Size = New Size(182, 17)
        Label5.TabIndex = 4
        Label5.Text = "GitHub Link for Task 2 "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("STZhongsong", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(239, 310)
        Label6.Name = "Label6"
        Label6.Size = New Size(128, 17)
        Label6.TabIndex = 5
        Label6.Text = "Stopwatch time "
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.White
        txtName.Location = New Point(419, 128)
        txtName.Name = "txtName"
        txtName.Size = New Size(239, 27)
        txtName.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(419, 169)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(239, 27)
        txtEmail.TabIndex = 7
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(419, 214)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(239, 27)
        txtPhone.TabIndex = 8
        ' 
        ' txtGithub
        ' 
        txtGithub.Location = New Point(419, 256)
        txtGithub.Name = "txtGithub"
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
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Button1.Font = New Font("STZhongsong", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(217, 385)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(2)
        Button1.Size = New Size(184, 29)
        Button1.TabIndex = 11
        Button1.Text = "PREVIOUS (CTRL + P)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Button2.Font = New Font("STZhongsong", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(538, 385)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(2)
        Button2.Size = New Size(172, 29)
        Button2.TabIndex = 12
        Button2.Text = "NEXT (CTRL + N)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' BtnEditSubmission
        ' 
        BtnEditSubmission.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BtnEditSubmission.Font = New Font("STZhongsong", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnEditSubmission.Location = New Point(217, 438)
        BtnEditSubmission.Name = "BtnEditSubmission"
        BtnEditSubmission.Size = New Size(184, 29)
        BtnEditSubmission.TabIndex = 13
        BtnEditSubmission.Text = "UPDATE (CTRL + U)"
        BtnEditSubmission.UseVisualStyleBackColor = False
        ' 
        ' BtnDeleteSubmission
        ' 
        BtnDeleteSubmission.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        BtnDeleteSubmission.Font = New Font("STZhongsong", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnDeleteSubmission.Location = New Point(538, 438)
        BtnDeleteSubmission.Name = "BtnDeleteSubmission"
        BtnDeleteSubmission.Size = New Size(172, 29)
        BtnDeleteSubmission.TabIndex = 14
        BtnDeleteSubmission.Text = "DELETE (CTRL + D)"
        BtnDeleteSubmission.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1105, 546)
        Controls.Add(BtnDeleteSubmission)
        Controls.Add(BtnEditSubmission)
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
    Friend WithEvents BtnEditSubmission As Button
    Friend WithEvents BtnDeleteSubmission As Button
End Class
