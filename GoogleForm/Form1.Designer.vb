<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        BtnViewSubmissions = New Button()
        BtnCreateSubmission = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(337, 189)
        Label1.Name = "Label1"
        Label1.Size = New Size(265, 20)
        Label1.TabIndex = 0
        Label1.Text = "Hello Hargun, This is the Google Form "
        ' 
        ' BtnViewSubmissions
        ' 
        BtnViewSubmissions.Location = New Point(286, 246)
        BtnViewSubmissions.Name = "BtnViewSubmissions"
        BtnViewSubmissions.Size = New Size(353, 29)
        BtnViewSubmissions.TabIndex = 1
        BtnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + V)"
        BtnViewSubmissions.UseVisualStyleBackColor = True
        ' 
        ' BtnCreateSubmission
        ' 
        BtnCreateSubmission.Location = New Point(286, 301)
        BtnCreateSubmission.Name = "BtnCreateSubmission"
        BtnCreateSubmission.Size = New Size(353, 29)
        BtnCreateSubmission.TabIndex = 2
        BtnCreateSubmission.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        BtnCreateSubmission.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(935, 623)
        Controls.Add(BtnCreateSubmission)
        Controls.Add(BtnViewSubmissions)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnViewSubmissions As Button
    Friend WithEvents BtnCreateSubmission As Button

End Class
