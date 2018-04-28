<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileBrowserBasic
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileBrowserBasic))
        Me.ContextMenuStripRepos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStripReposOpenInExplorer = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposOpenInCMD = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposOpenInPS = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposOpenInBash = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposOpenInGitHub = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContextMenuStripReposOpenReadme = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposOpenSLN = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposOpenURL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContextMenuStripReposCopyRepoName = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposCopyRepoPath = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContextMenuStripReposRemoveEntry = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposCDHere = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContextMenuStripReposGitPullThis = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripReposGitPushThis = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstContents = New System.Windows.Forms.ListBox()
        Me.folderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnCD = New System.Windows.Forms.ToolStripButton()
        Me.statusStrip = New System.Windows.Forms.StatusStrip()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ContextMenuStripRepos.SuspendLayout
        Me.menuStrip.SuspendLayout
        Me.SuspendLayout
        '
        'ContextMenuStripRepos
        '
        Me.ContextMenuStripRepos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContextMenuStripReposOpenInExplorer, Me.ContextMenuStripReposOpenInCMD, Me.ContextMenuStripReposOpenInPS, Me.ContextMenuStripReposOpenInBash, Me.ContextMenuStripReposOpenInGitHub, Me.ContextMenuStripReposSeparator1, Me.ContextMenuStripReposOpenReadme, Me.ContextMenuStripReposOpenSLN, Me.ContextMenuStripReposOpenURL, Me.ContextMenuStripReposSeparator2, Me.ContextMenuStripReposCopyRepoName, Me.ContextMenuStripReposCopyRepoPath, Me.ContextMenuStripReposSeparator3, Me.ContextMenuStripReposRemoveEntry, Me.ContextMenuStripReposCDHere, Me.ContextMenuStripReposSeparator4, Me.ContextMenuStripReposGitPullThis, Me.ContextMenuStripReposGitPushThis})
        Me.ContextMenuStripRepos.Name = "contextMenuStripRepos"
        Me.ContextMenuStripRepos.Size = New System.Drawing.Size(273, 336)
        '
        'ContextMenuStripReposOpenInExplorer
        '
        Me.ContextMenuStripReposOpenInExplorer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ContextMenuStripReposOpenInExplorer.Name = "ContextMenuStripReposOpenInExplorer"
        Me.ContextMenuStripReposOpenInExplorer.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposOpenInExplorer.Text = "Open Repo in Windows Explorer"
        '
        'ContextMenuStripReposOpenInCMD
        '
        Me.ContextMenuStripReposOpenInCMD.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ContextMenuStripReposOpenInCMD.Name = "ContextMenuStripReposOpenInCMD"
        Me.ContextMenuStripReposOpenInCMD.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposOpenInCMD.Text = "Open Repo in CMD"
        '
        'ContextMenuStripReposOpenInPS
        '
        Me.ContextMenuStripReposOpenInPS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ContextMenuStripReposOpenInPS.Name = "ContextMenuStripReposOpenInPS"
        Me.ContextMenuStripReposOpenInPS.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposOpenInPS.Text = "Open Repo in Windows PowerShell"
        '
        'ContextMenuStripReposOpenInBash
        '
        Me.ContextMenuStripReposOpenInBash.Name = "ContextMenuStripReposOpenInBash"
        Me.ContextMenuStripReposOpenInBash.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposOpenInBash.Text = "Open Repo in Git Bash"
        '
        'ContextMenuStripReposOpenInGitHub
        '
        Me.ContextMenuStripReposOpenInGitHub.Name = "ContextMenuStripReposOpenInGitHub"
        Me.ContextMenuStripReposOpenInGitHub.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposOpenInGitHub.Text = "Open Repo in GitHub for Windows"
        '
        'ContextMenuStripReposSeparator1
        '
        Me.ContextMenuStripReposSeparator1.Name = "ContextMenuStripReposSeparator1"
        Me.ContextMenuStripReposSeparator1.Size = New System.Drawing.Size(269, 6)
        '
        'ContextMenuStripReposOpenReadme
        '
        Me.ContextMenuStripReposOpenReadme.Name = "ContextMenuStripReposOpenReadme"
        Me.ContextMenuStripReposOpenReadme.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposOpenReadme.Text = "Open Repo Readme"
        '
        'ContextMenuStripReposOpenSLN
        '
        Me.ContextMenuStripReposOpenSLN.Name = "ContextMenuStripReposOpenSLN"
        Me.ContextMenuStripReposOpenSLN.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposOpenSLN.Text = "Open Repo SLN"
        '
        'ContextMenuStripReposOpenURL
        '
        Me.ContextMenuStripReposOpenURL.Name = "ContextMenuStripReposOpenURL"
        Me.ContextMenuStripReposOpenURL.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposOpenURL.Text = "Open Repo URL"
        '
        'ContextMenuStripReposSeparator2
        '
        Me.ContextMenuStripReposSeparator2.Name = "ContextMenuStripReposSeparator2"
        Me.ContextMenuStripReposSeparator2.Size = New System.Drawing.Size(269, 6)
        '
        'ContextMenuStripReposCopyRepoName
        '
        Me.ContextMenuStripReposCopyRepoName.Name = "ContextMenuStripReposCopyRepoName"
        Me.ContextMenuStripReposCopyRepoName.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposCopyRepoName.Text = "Copy Repo Name"
        '
        'ContextMenuStripReposCopyRepoPath
        '
        Me.ContextMenuStripReposCopyRepoPath.Name = "ContextMenuStripReposCopyRepoPath"
        Me.ContextMenuStripReposCopyRepoPath.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposCopyRepoPath.Text = "Copy Repo Path"
        '
        'ContextMenuStripReposSeparator3
        '
        Me.ContextMenuStripReposSeparator3.Name = "ContextMenuStripReposSeparator3"
        Me.ContextMenuStripReposSeparator3.Size = New System.Drawing.Size(269, 6)
        '
        'ContextMenuStripReposRemoveEntry
        '
        Me.ContextMenuStripReposRemoveEntry.Name = "ContextMenuStripReposRemoveEntry"
        Me.ContextMenuStripReposRemoveEntry.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposRemoveEntry.Text = "Remove Entry"
        '
        'ContextMenuStripReposCDHere
        '
        Me.ContextMenuStripReposCDHere.Name = "ContextMenuStripReposCDHere"
        Me.ContextMenuStripReposCDHere.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposCDHere.Text = "CD Here..."
        '
        'ContextMenuStripReposSeparator4
        '
        Me.ContextMenuStripReposSeparator4.Name = "ContextMenuStripReposSeparator4"
        Me.ContextMenuStripReposSeparator4.Size = New System.Drawing.Size(269, 6)
        '
        'ContextMenuStripReposGitPullThis
        '
        Me.ContextMenuStripReposGitPullThis.Name = "ContextMenuStripReposGitPullThis"
        Me.ContextMenuStripReposGitPullThis.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposGitPullThis.Text = "Git Pull this"
        '
        'ContextMenuStripReposGitPushThis
        '
        Me.ContextMenuStripReposGitPushThis.Name = "ContextMenuStripReposGitPushThis"
        Me.ContextMenuStripReposGitPushThis.Size = New System.Drawing.Size(272, 22)
        Me.ContextMenuStripReposGitPushThis.Text = "Git Push this"
        '
        'lstContents
        '
        Me.lstContents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
                        Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lstContents.ContextMenuStrip = Me.ContextMenuStripRepos
        Me.lstContents.FormattingEnabled = true
        Me.lstContents.IntegralHeight = false
        Me.lstContents.Location = New System.Drawing.Point(12, 30)
        Me.lstContents.MultiColumn = true
        Me.lstContents.Name = "lstContents"
        Me.lstContents.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstContents.Size = New System.Drawing.Size(505, 618)
        Me.lstContents.TabIndex = 1
        '
        'folderBrowserDialog
        '
        Me.folderBrowserDialog.Description = "Select a folder to show files for..."
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRefresh, Me.btnCD})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(529, 27)
        Me.menuStrip.TabIndex = 2
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"),System.Drawing.Image)
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(71, 20)
        Me.btnRefresh.Text = "Refresh"
        '
        'btnCD
        '
        Me.btnCD.Image = CType(resources.GetObject("btnCD.Image"),System.Drawing.Image)
        Me.btnCD.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCD.Name = "btnCD"
        Me.btnCD.Size = New System.Drawing.Size(140, 20)
        Me.btnCD.Text = "Change Directory..."
        '
        'statusStrip
        '
        Me.statusStrip.Location = New System.Drawing.Point(0, 651)
        Me.statusStrip.Name = "statusStrip"
        Me.statusStrip.ShowItemToolTips = true
        Me.statusStrip.Size = New System.Drawing.Size(529, 22)
        Me.statusStrip.TabIndex = 3
        '
        'toolStrip1
        '
        Me.toolStrip1.AutoSize = false
        Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.toolStrip1.Location = New System.Drawing.Point(112, 648)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(317, 25)
        Me.toolStrip1.TabIndex = 4
        Me.toolStrip1.Text = "toolStrip1"
        '
        'FileBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 673)
        Me.Controls.Add(Me.toolStrip1)
        Me.Controls.Add(Me.lstContents)
        Me.Controls.Add(Me.statusStrip)
        Me.Controls.Add(Me.menuStrip)
        Me.HelpButton = true
        Me.MainMenuStrip = Me.menuStrip
        Me.Name = "FileBrowserBasic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FileBrowserBasic"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContextMenuStripRepos.ResumeLayout(false)
        Me.menuStrip.ResumeLayout(false)
        Me.menuStrip.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout
    End Sub
    Friend WithEvents btnCD As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents statusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents menuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents folderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lstContents As System.Windows.Forms.ListBox
    Friend WithEvents ContextMenuStripReposGitPushThis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposGitPullThis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuStripReposCDHere As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposRemoveEntry As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuStripReposCopyRepoPath As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposCopyRepoName As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuStripReposOpenURL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposOpenSLN As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposOpenReadme As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuStripReposOpenInGitHub As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposOpenInBash As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposOpenInPS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposOpenInCMD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripReposOpenInExplorer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripRepos As System.Windows.Forms.ContextMenuStrip

End Class
