Public Class FileBrowser
    Dim WorkingDir As String = Environment.GetEnvironmentVariable("USERPROFILE")
'    Dim cmdRepo As String = ""
'    Dim count, GitCommand As String  ' because the Worker doesn't support direct sub calling
'    Dim ExitWhenDone As Boolean = False
'    Dim LineIsOrigin, LineIsUpstream, notInserted As Boolean
'    Dim PSFiles() As String = {"CheckVersion.ps1", "GitPrompt.ps1", "GitTabExpansion.ps1", "GitUtils.ps1", "TortoiseGit.ps1", "Utils.ps1", "posh-git.psm1", "profile.example.ps1"}

'    Dim CmdStyle As AppWinStyle  ' window location of CMD
'    Dim Wait As Integer  ' Wait until cmd closes

    Sub FileBrowser(sender As Object, e As EventArgs) Handles MyBase.Load
'        If Not File.Exists("GitUpdater.bat") Then
'            Try
'                My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/Walkman100/GitUpdater/master/GitUpdater.bat", "GitUpdater.bat")
'            Catch
'                MsgBox("Could not automatically download the required file! Please download it manually. Click OK to open the download page.", MsgBoxStyle.Exclamation)
'                Try
'                    Process.Start("https://raw.githubusercontent.com/Walkman100/GitUpdater/master/GitUpdater.bat")
'                Catch
'                    If MsgBox("Unable to launch URL, copy to clipboard instead?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then Clipboard.SetText("https://raw.githubusercontent.com/Walkman100/GitUpdater/master/GitUpdater.bat")
'                End Try
'            End Try
'        End If
'        btnGitPullAll.Enabled = True
'        btnGitPushAll.Enabled = True
'        btnGitPullSelected.Enabled = True
'        btnGitPushSelected.Enabled = True
'        btnGitPullNotSelected.Enabled = True
'        btnGitPushNotSelected.Enabled = True
'        btnCD.Enabled = True
'        btnCancel.Enabled = False
        ' apply settings to where they are changed
'        txtUsername.Text = My.Settings.Username
'        txtPassword.Text = My.Settings.Password
'        chkNoWait.Checked = My.Settings.NoWait
'        chkDontClose.Checked = My.Settings.DontClose
'        chkDontShow.Checked = My.Settings.DontShow
'        chkRepeat.Checked = My.Settings.Repeat
'        chkLog.Checked = My.Settings.Log
'        txtLogPath.Text = My.Settings.LogPath
'        If txtLogPath.Text = "" Then txtLogPath.Text = Dir & "GitUpdater.log"
'        chkOpenLog.Checked = My.Settings.OpenLog
'        chkShowErrors.Checked = My.Settings.ShowErrors

        ' apply settings to where they affect
        If My.Settings.LastDir <> "" Then
            WorkingDir = My.Settings.LastDir
        End If
        RebuildRepoList()
'        If My.Settings.NoWait = True Then Wait = 1000 Else Wait = -1
'        If My.Settings.DontShow = True Then
'            CmdStyle = vbMinimizedNoFocus
'            If ShellWorker.IsBusy = True Then
'                Me.TopMost = False
'            End If
'        ElseIf My.Settings.DontShow = False Then
'            CmdStyle = vbNormalFocus
'            If ShellWorker.IsBusy = True Then
'                Me.TopMost = True
'            End If
'        End If
'
        ' command line args
        For Each s As String In My.Application.CommandLineArgs
            If s.ToLower.StartsWith("") Then
                
            End If
        Next
    End Sub

    ' to do with list of repos

    Sub RebuildRepoList() Handles btnRefresh.click
        btnRefresh.Enabled = False
        lstContents.Items.Clear()
        For Each Dir As String In Directory.GetDirectories(WorkingDir)
            lstContents.Items.Add(Mid(Dir, Len(WorkingDir) + 1))
        Next
        For Each Dir As String In Directory.GetFiles(WorkingDir)
            lstContents.Items.Add(Mid(Dir, Len(WorkingDir)+1))
        Next
        btnRefresh.Enabled = True
    End Sub

    Sub btnCD_Click(sender As Object, e As EventArgs) Handles btnCD.Click
        ' show file chooser dialog, set result as WorkingDir
        folderBrowserDialog.SelectedPath = WorkingDir
        folderBrowserDialog.ShowDialog()
        WorkingDir = folderBrowserDialog.SelectedPath & "\"
        My.Settings.LastDir = WorkingDir

        ' rebuild list automatically
        RebuildRepoList()
    End Sub

    Sub ContextMenuStripReposOpenInExplorer_Click(sender As Object, e As EventArgs) Handles ContextMenuStripReposOpenInExplorer.Click
        If lstContents.SelectedIndex <> -1 Then
            Process.Start(WorkingDir & lstContents.SelectedItem)
        Else
            Process.Start(WorkingDir)
        End If
    End Sub

    Sub ContextMenuStripReposOpenInCMD_Click(sender As Object, e As EventArgs) Handles ContextMenuStripReposOpenInCMD.Click
'        If lstRepos.SelectedIndex <> -1 Then
'            Process.Start("cmd.exe", "/k cd " & Dir & lstRepos.SelectedItem)
'        Else
'            Process.Start("cmd.exe", "/k cd " & Dir)
'        End If
    End Sub

    Sub ContextMenuStripReposOpenInPS_Click(sender As Object, e As EventArgs) Handles ContextMenuStripReposOpenInPS.Click
'        If Not File.Exists("PS\CheckVersion.ps1") Or Not File.Exists("PS\GitPrompt.ps1") Or Not File.Exists("PS\GitTabExpansion.ps1") Or Not File.Exists("PS\GitUtils.ps1") Or Not _
'         File.Exists("PS\TortoiseGit.ps1") Or Not File.Exists("PS\Utils.ps1") Or Not File.Exists("PS\posh-git.psm1") Or Not File.Exists("PS\profile.example.ps1") Or Not File.Exists("OpenRepoInPS.bat") Then
'
'            cmdRepo = "A file required to start a PowerShell CLI wasn't found! Missing File(s): " & vbNewLine
'            If Not File.Exists("PS\CheckVersion.ps1") Then cmdRepo = cmdRepo & "PS\CheckVersion.ps1" & vbNewLine
'            If Not File.Exists("PS\GitPrompt.ps1") Then cmdRepo = cmdRepo & "PS\GitPrompt.ps1" & vbNewLine
'            If Not File.Exists("PS\GitTabExpansion.ps1") Then cmdRepo = cmdRepo & "PS\GitTabExpansion.ps1" & vbNewLine
'            If Not File.Exists("PS\GitUtils.ps1") Then cmdRepo = cmdRepo & "PS\GitUtils.ps1" & vbNewLine
'            If Not File.Exists("PS\TortoiseGit.ps1") Then cmdRepo = cmdRepo & "PS\TortoiseGit.ps1" & vbNewLine
'            If Not File.Exists("PS\Utils.ps1") Then cmdRepo = cmdRepo & "PS\Utils.ps1" & vbNewLine
'            If Not File.Exists("PS\posh-git.psm1") Then cmdRepo = cmdRepo & "PS\posh-git.psm1" & vbNewLine
'            If Not File.Exists("PS\profile.example.ps1") Then cmdRepo = cmdRepo & "PS\profile.example.ps1" & vbNewLine
'            If Not File.Exists("OpenRepoInPS.bat") Then cmdRepo = cmdRepo & "OpenRepoInPS.bat" & vbNewLine
'            If MsgBox(cmdRepo & "Attempt to download missing files?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical) = MsgBoxResult.No Then
'                If MsgBox("Attempt to run script anyway?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then Exit Sub
'                If lstRepos.SelectedIndex <> -1 Then
'                    Process.Start("OpenRepoInPS.bat", """" & Dir & lstRepos.SelectedItem & """ " & Environment.CurrentDirectory)
'                Else
'                    Process.Start("OpenRepoInPS.bat", """" & Dir & """ " & Environment.CurrentDirectory)
'                End If
'                Exit Sub
'            End If
'            cmdRepo = ""
'
'            ' PS folder
'            For Each file In PSFiles
'                If Not IO.File.Exists("PS\" & file) Then
'                    Try
'                        My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/Walkman100/GitUpdater/master/PS/" & file, "PS\" & file)
'                    Catch
'                        MsgBox("Could not automatically download the file PS\" & file & "! Please download it manually. Click OK to open the download page.", MsgBoxStyle.Exclamation)
'                        Try
'                            Process.Start("https://raw.githubusercontent.com/Walkman100/GitUpdater/master/PS/" & file)
'                        Catch
'                            If MsgBox("Unable to launch URL, copy to clipboard instead?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then Clipboard.SetText("https://raw.githubusercontent.com/Walkman100/GitUpdater/master/PS/" & file)
'                        End Try
'                    End Try
'                End If
'            Next
'            ' Main Batfile
'            If Not File.Exists("OpenRepoInPS.bat") Then
'                Try
'                    My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/Walkman100/GitUpdater/master/OpenRepoInPS.bat", "OpenRepoInPS.bat")
'                    MsgBox("File OpenRepoInPS.bat downloaded succesfully!", MsgBoxStyle.Information)
'                Catch
'                    MsgBox("Could not automatically download the PowerShell batchfile! Please download it manually. Click OK to open the download page.", MsgBoxStyle.Exclamation)
'                    Try
'                        Process.Start("https://raw.githubusercontent.com/Walkman100/GitUpdater/master/OpenRepoInPS.bat")
'                    Catch
'                        If MsgBox("Unable to launch URL, copy to clipboard instead?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then Clipboard.SetText("https://raw.githubusercontent.com/Walkman100/GitUpdater/master/OpenRepoInPS.bat")
'                    End Try
'                End Try
'            End If
'            MsgBox("File download attempts complete! Please try your action again.", MsgBoxStyle.Information)
'        Else
'            If lstRepos.SelectedIndex <> -1 Then
'                Process.Start("OpenRepoInPS.bat", """" & Dir & lstRepos.SelectedItem & """ " & Environment.CurrentDirectory)
'            Else
'                Process.Start("OpenRepoInPS.bat", """" & Dir & """ " & Environment.CurrentDirectory)
'            End If
'        End If
    End Sub
    
    Sub ContextMenuStripReposOpenInBash_Click(sender As Object, e As EventArgs) Handles ContextMenuStripReposOpenInBash.Click
'        If lstRepos.SelectedIndex <> -1 Then
'            Process.Start("OpenRepoInBash.bat", """" & Dir & lstRepos.SelectedItem & """")
'        Else
'            Process.Start("OpenRepoInBash.bat", """" & Dir & """")
'        End If
    End Sub

    Sub ContextMenuStripReposOpenInGitHub_Click(sender As Object, e As EventArgs) Handles ContextMenuStripReposOpenInGitHub.Click
'        If lstRepos.SelectedIndex <> -1 Then
'            Try
'                Process.Start("github-windows://openRepo/" & Dir & lstRepos.SelectedItem)
'            Catch
'                MsgBox("GitHub for windows protocol not found!", MsgBoxStyle.Critical)
'            End Try
'        Else
'            Try
'                Process.Start("github-windows://openRepo/" & Dir)
'            Catch
'                MsgBox("GitHub for windows protocol not found!", MsgBoxStyle.Critical)
'            End Try
'        End If
'    End Sub
'
'    Sub ContextMenuStripReposOpenReadme_Click(sender As Object, e As EventArgs) Handles ContextMenuStripReposOpenReadme.Click
'        If lstRepos.SelectedIndex <> -1 Then
'            If lstRepos.SelectedItem.ToString.EndsWith(".wiki") Then
'                If File.Exists(Dir & lstRepos.SelectedItem & "\home.md") Then
'                    Process.Start(Dir & lstRepos.SelectedItem & "\home.md")
'                Else
'                    MsgBox("No file found in Wiki folder:" & vbNewLine & _
'                        """" & Dir & lstRepos.SelectedItem & """" & vbNewLine & _
'                        "With filename: home.md", MsgBoxStyle.Critical)
'                End If
'            ElseIf lstRepos.SelectedItem.ToString.EndsWith(".github.io") Or lstRepos.SelectedItem.ToString.EndsWith(".github.com") Then
'                If File.Exists(Dir & lstRepos.SelectedItem & "\index.html") Then
'                    Process.Start(Dir & lstRepos.SelectedItem & "\index.html")
'                Else
'                    MsgBox("No file found in Site folder:" & vbNewLine & _
'                        """" & Dir & lstRepos.SelectedItem & """" & vbNewLine & _
'                        "With filename: index.html", MsgBoxStyle.Critical)
'                End If
'            Else
'                If File.Exists(Dir & lstRepos.SelectedItem & "\readme.md") Then
'                    Process.Start(Dir & lstRepos.SelectedItem & "\readme.md")
'                ElseIf File.Exists(Dir & lstRepos.SelectedItem & "\readme.txt") Then
'                    Process.Start(Dir & lstRepos.SelectedItem & "\readme.txt")
'                ElseIf File.Exists(Dir & lstRepos.SelectedItem & "\readme.htm") Then
'                    Process.Start(Dir & lstRepos.SelectedItem & "\readme.htm")
'                ElseIf File.Exists(Dir & lstRepos.SelectedItem & "\readme.html") Then
'                    Process.Start(Dir & lstRepos.SelectedItem & "\readme.html")
'                ElseIf File.Exists(Dir & lstRepos.SelectedItem & "\readme.markdown") Then
'                    Process.Start(Dir & lstRepos.SelectedItem & "\readme.markdown")
'                ElseIf File.Exists(Dir & lstRepos.SelectedItem & "\readme.mkd") Then
'                    Process.Start(Dir & lstRepos.SelectedItem & "\readme.mkd")
'                ElseIf File.Exists(Dir & lstRepos.SelectedItem & "\readme") Then
'                    Process.Start(Dir & lstRepos.SelectedItem & "\readme")
'                Else
'                    MsgBox("No file found in repo:" & vbNewLine & _
'                        """" & Dir & lstRepos.SelectedItem & """" & vbNewLine & _
'                        "With filename: readme.md, readme.txt, readme.htm, readme.html, readme.markdown, readme.mkd, or readme.", MsgBoxStyle.Critical)
'                End If
'            End If
'        Else
'            If File.Exists(Dir & "readme.md") Then
'                Process.Start(Dir & "readme.md")
'            ElseIf File.Exists(Dir & "readme.txt") Then
'                Process.Start(Dir & "readme.txt")
'            ElseIf File.Exists(Dir & "readme.htm") Then
'                Process.Start(Dir & "readme.htm")
'            ElseIf File.Exists(Dir & "readme.html") Then
'                Process.Start(Dir & "readme.html")
'            ElseIf File.Exists(Dir & "readme.markdown") Then
'                Process.Start(Dir & "readme.markdown")
'            ElseIf File.Exists(Dir & "readme.mkd") Then
'                Process.Start(Dir & "readme.mkd")
'            ElseIf File.Exists(Dir & "readme") Then
'                Process.Start(Dir & "readme")
'            Else
'                MsgBox("No file found in folder:" & vbNewLine & _
'                    """" & Dir & """" & vbNewLine & _
'                    "With filename: readme.md, readme.txt, readme.htm, readme.html, readme.markdown, readme.mkd, or readme.", MsgBoxStyle.Critical)
'            End If
'        End If
    End Sub

    Sub ContextMenuStripReposOpenSLN_Click(sender As Object, e As EventArgs) Handles ContextMenuStripReposOpenSLN.Click
'        If lstRepos.SelectedIndex <> -1 Then
'            If File.Exists(Dir & lstRepos.SelectedItem & "\" & lstRepos.SelectedItem & ".sln") Then
'                Process.Start(Dir & lstRepos.SelectedItem & "\" & lstRepos.SelectedItem & ".sln")
'            ElseIf File.Exists(Dir & lstRepos.SelectedItem & "\" & lstRepos.SelectedItem & "\" & lstRepos.SelectedItem & ".sln") Then
'                Process.Start(Dir & lstRepos.SelectedItem & "\" & lstRepos.SelectedItem & "\" & lstRepos.SelectedItem & ".sln")
'                'ElseIf File.Exists(Dir & lstRepos.SelectedItem & "\" & lstRepos.SelectedItem & ".sln") Then
'                '     Process.Start(Dir & lstRepos.SelectedItem & "\" & lstRepos.SelectedItem & ".sln")
'            Else
'                MsgBox("No file found in locations:" & vbNewLine & _
'                    """" & Dir & lstRepos.SelectedItem & """" & vbNewLine & _
'                    """" & Dir & lstRepos.SelectedItem & "\" & lstRepos.SelectedItem & """" & vbNewLine & _
'                    "With filename: """ & lstRepos.SelectedItem & ".sln""", MsgBoxStyle.Critical)
'            End If
'        Else
'            If File.Exists(Dir & "GitHub.sln") Then
'                Process.Start(Dir & "GitHub.sln")
'            ElseIf File.Exists(Dir & ".sln") Then
'                Process.Start(Dir & ".sln")
'            Else
'                MsgBox("No file found in locations:" & vbNewLine & _
'                    """" & Dir & "GitHub.sln""" & vbNewLine & _
'                    """" & Dir & ".sln""", MsgBoxStyle.Critical)
'            End If
'        End If
    End Sub

    Private Sub ContextMenuStripReposOpenURL_Click(sender As Object, e As EventArgs) Handles ContextMenuStripReposOpenURL.Click
'        LineIsOrigin = False
'        LineIsUpstream = False
'
'        '[remote "origin"] 'Repo location
'        '	url = https://github.com/Walkman100/Dashy.git
'        '[remote "upstream"] '[Fork] repo that current one was forked from
'        '	url = https://github.com/deavmi/Dashy.git
'        '[submodule "YTVL"] 'submodule url in git format
'        '	url = git://github.com/Walkman100/YTVL.git/
'        '[submodule "github-watchers-button"] 'submodule url in https format
'        '	url = https://github.com/addyosmani/github-watchers-button.git
'        For Each line In File.ReadLines(Dir & lstRepos.SelectedItem & "\.git\config")
'            If LineIsOrigin Then
'                cmdRepo = line.Substring(line.IndexOf("https://")) ' cmdRepo just because it's a string that would be unused by this point
'                If cmdRepo.EndsWith(".git") Then cmdRepo = cmdRepo.Remove(cmdRepo.Length - 4)
'                Try
'                    Process.Start(cmdRepo)
'                Catch ex As Exception
'                    If MsgBox("Unable to launch URL, copy to clipboard instead?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then Clipboard.SetText(cmdRepo)
'                End Try
'                LineIsOrigin = False
'            End If
'            If line = "[remote ""origin""]" Then
'                LineIsOrigin = True
'            End If
'
'            If LineIsUpstream Then
'                If MsgBox("Fork detected, open fork origin too?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
'                    cmdRepo = line.Substring(line.IndexOf("https://"))
'                    If cmdRepo.EndsWith(".git") Then cmdRepo = cmdRepo.Remove(cmdRepo.Length - 4)
'                    Try
'                        Process.Start(cmdRepo)
'                    Catch ex As Exception
'                        If MsgBox("Unable to launch URL, copy to clipboard instead?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then Clipboard.SetText(cmdRepo)
'                    End Try
'                End If
'                LineIsUpstream = False
'            End If
'            If line = "[remote ""upstream""]" Then
'                LineIsUpstream = True
'            End If
'        Next
    End Sub

    Sub ContextMenuStripReposCopyRepoName_Click(sender As Object, e As EventArgs) Handles ContextMenuStripReposCopyRepoName.Click
'        If lstRepos.SelectedIndex <> -1 Then
'            Try
'                Clipboard.SetText(lstRepos.SelectedItem, TextDataFormat.UnicodeText)
'                MsgBox(lstRepos.SelectedItem & vbNewLine & "Succesfully copied!", MsgBoxStyle.Information, "Succesfully copied!")
'            Catch ex As Exception
'                MsgBox("Copy failed!" & vbNewLine & "Error: """ & ex.ToString, MsgBoxStyle.Critical & """", "Copy failed!")
'            End Try
'        Else
'            Try
'                Clipboard.SetText(Dir, TextDataFormat.UnicodeText)
'                MsgBox(Dir & vbNewLine & "Succesfully copied!", MsgBoxStyle.Information, "Succesfully copied!")
'            Catch ex As Exception
'                MsgBox("Copy failed!" & vbNewLine & "Error: """ & ex.ToString, MsgBoxStyle.Critical & """", "Copy failed!")
'            End Try
'        End If
    End Sub

    Sub ContextMenuStripReposCopyRepoPath_Click(sender As Object, e As EventArgs) Handles ContextMenuStripReposCopyRepoPath.Click
'        If lstRepos.SelectedIndex <> -1 Then
'            Try
'                Clipboard.SetText(Dir & lstRepos.SelectedItem, TextDataFormat.UnicodeText)
'                MsgBox(Dir & lstRepos.SelectedItem & vbNewLine & "Succesfully copied!", MsgBoxStyle.Information, "Succesfully copied!")
'            Catch ex As Exception
'                MsgBox("Copy failed!" & vbNewLine & "Error: """ & ex.ToString, MsgBoxStyle.Critical & """", "Copy failed!")
'            End Try
'        Else
'            Try
'                Clipboard.SetText(Dir, TextDataFormat.UnicodeText)
'                MsgBox(Dir & vbNewLine & "Succesfully copied!", MsgBoxStyle.Information, "Succesfully copied!")
'            Catch ex As Exception
'                MsgBox("Copy failed!" & vbNewLine & "Error: """ & ex.ToString, MsgBoxStyle.Critical & """", "Copy failed!")
'            End Try
'        End If
    End Sub

    Private Sub ContextMenuStripReposRemoveEntry_Click(sender As Object, e As EventArgs) Handles ContextMenuStripReposRemoveEntry.Click
'        If lstRepos.SelectedIndex <> -1 Then
'            lstRepos.Items.RemoveAt(lstRepos.SelectedIndex)
'        End If
    End Sub

    Sub lstContents_DoubleClick(sender As Object, e As EventArgs) Handles lstContents.DoubleClick
        If lstContents.SelectedIndex <> -1 Then
            WorkingDir = WorkingDir & lstContents.SelectedItem & "\"
            My.Settings.LastDir = WorkingDir
            RebuildRepoList()
        Else
            Try
                WorkingDir = WorkingDir.Remove(WorkingDir.Length - 1)
                WorkingDir = WorkingDir.Remove(WorkingDir.LastIndexOf("\"))
                WorkingDir = WorkingDir & "\"
                My.Settings.LastDir = WorkingDir
                RebuildRepoList()
            Catch ex As System.ArgumentOutOfRangeException
                If MsgBox("Cannot go higher than the root of a drive! Please use the change directory button to change drives." & vbNewLine & vbNewLine & "Open CD dialog now?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Trying to go up from a drive root") = vbYes Then
                    btnCD_Click(Nothing, Nothing)
                End If
            End Try
        End If
    End Sub
    
    Sub lstContents_MouseDown(sender As Object, e As MouseEventArgs) Handles lstContents.MouseDown
        If lstContents.SelectedIndex <> -1 Then
            If lstContents.SelectedItem.ToString.EndsWith(".wiki") Then
                ContextMenuStripReposOpenInExplorer.Text = "Open Wiki in Windows Explorer"
                ContextMenuStripReposOpenInCMD.Text = "Open Wiki in CMD"
                ContextMenuStripReposOpenInPS.Text = "Open Wiki in Windows PowerShell"
                ContextMenuStripReposOpenInBash.Text = "Open Wiki in Git Bash"
                ContextMenuStripReposOpenInGitHub.Text = "Open Wiki in GitHub for Windows"
                ContextMenuStripReposSeparator1.Visible = True
                ContextMenuStripReposOpenReadme.Visible = True
                ContextMenuStripReposOpenReadme.Text = "Open Wiki home.md"
                ContextMenuStripReposOpenSLN.Visible = False
                ContextMenuStripReposOpenURL.Text = "Open Wiki URL"
                ContextMenuStripReposSeparator2.Visible = True
                ContextMenuStripReposCopyRepoName.Visible = True
                ContextMenuStripReposCopyRepoName.Text = "Copy Wiki Name"
                ContextMenuStripReposCopyRepoPath.Visible = True
                ContextMenuStripReposCopyRepoPath.Text = "Copy Wiki Path"
                ContextMenuStripReposSeparator3.Visible = True
                ContextMenuStripReposRemoveEntry.Visible = True
                ContextMenuStripReposCDHere.Visible = True
                ContextMenuStripReposCDHere.Text = "CD Here..."
                ContextMenuStripReposSeparator4.Visible = True
                ContextMenuStripReposGitPullThis.Visible = True
                ContextMenuStripReposGitPushThis.Visible = True
            ElseIf lstContents.SelectedItem.ToString.EndsWith(".github.io") Or lstContents.SelectedItem.ToString.EndsWith(".github.com") Then
                ContextMenuStripReposOpenInExplorer.Text = "Open Site Folder in Windows Explorer"
                ContextMenuStripReposOpenInCMD.Text = "Open Site Folder in CMD"
                ContextMenuStripReposOpenInPS.Text = "Open Site Folder in Windows PowerShell"
                ContextMenuStripReposOpenInBash.Text = "Open Site Folder in Git Bash"
                ContextMenuStripReposOpenInGitHub.Text = "Open Site in GitHub for Windows"
                ContextMenuStripReposSeparator1.Visible = True
                ContextMenuStripReposOpenReadme.Visible = True
                ContextMenuStripReposOpenReadme.Text = "Open Site index.html"
                ContextMenuStripReposOpenSLN.Visible = False
                ContextMenuStripReposOpenURL.Text = "Open Site GitHub URL"
                ContextMenuStripReposSeparator2.Visible = True
                ContextMenuStripReposCopyRepoName.Visible = True
                ContextMenuStripReposCopyRepoName.Text = "Copy Site Name"
                ContextMenuStripReposCopyRepoPath.Visible = True
                ContextMenuStripReposCopyRepoPath.Text = "Copy Site Path"
                ContextMenuStripReposSeparator3.Visible = True
                ContextMenuStripReposRemoveEntry.Visible = True
                ContextMenuStripReposCDHere.Visible = True
                ContextMenuStripReposCDHere.Text = "CD Here..."
                ContextMenuStripReposSeparator4.Visible = True
                ContextMenuStripReposGitPullThis.Visible = True
                ContextMenuStripReposGitPushThis.Visible = True
            Else
                ContextMenuStripReposOpenInExplorer.Text = "Open Repo in Windows Explorer"
                ContextMenuStripReposOpenInCMD.Text = "Open Repo in CMD"
                ContextMenuStripReposOpenInPS.Text = "Open Repo in Windows PowerShell"
                ContextMenuStripReposOpenInBash.Text = "Open Repo in Git Bash"
                ContextMenuStripReposOpenInGitHub.Text = "Open Repo in GitHub for Windows"
                ContextMenuStripReposSeparator1.Visible = True
                ContextMenuStripReposOpenReadme.Visible = True
                ContextMenuStripReposOpenReadme.Text = "Open Repo Readme"
                ContextMenuStripReposOpenSLN.Visible = True
                ContextMenuStripReposOpenSLN.Text = "Open Repo SLN"
                ContextMenuStripReposOpenURL.Text = "Open Repo URL"
                ContextMenuStripReposSeparator2.Visible = True
                ContextMenuStripReposCopyRepoName.Visible = True
                ContextMenuStripReposCopyRepoName.Text = "Copy Repo Name"
                ContextMenuStripReposCopyRepoPath.Visible = True
                ContextMenuStripReposCopyRepoPath.Text = "Copy Repo Path"
                ContextMenuStripReposSeparator3.Visible = True
                ContextMenuStripReposRemoveEntry.Visible = True
                ContextMenuStripReposCDHere.Visible = True
                ContextMenuStripReposCDHere.Text = "CD Here..."
                ContextMenuStripReposSeparator4.Visible = True
                ContextMenuStripReposGitPullThis.Visible = True
                ContextMenuStripReposGitPushThis.Visible = True
            End If
        Else
            ContextMenuStripReposOpenInExplorer.Text = "Open Folder in Windows Explorer"
            ContextMenuStripReposOpenInCMD.Text = "Open Folder in CMD"
            ContextMenuStripReposOpenInPS.Text = "Open Folder in Windows PowerShell"
            ContextMenuStripReposOpenInBash.Text = "Open Folder in Git Bash"
            ContextMenuStripReposOpenInGitHub.Text = "Open Folder in GitHub for Windows"
            ContextMenuStripReposSeparator1.Visible = True
            ContextMenuStripReposOpenReadme.Visible = False
            ContextMenuStripReposOpenSLN.Visible = False
            ContextMenuStripReposOpenURL.Text = "Open Folder URL"
            ContextMenuStripReposSeparator2.Visible = False
            ContextMenuStripReposCopyRepoName.Visible = False
            ContextMenuStripReposCopyRepoPath.Visible = True
            ContextMenuStripReposCopyRepoPath.Text = "Copy Folder Path"
            ContextMenuStripReposSeparator3.Visible = False
            ContextMenuStripReposRemoveEntry.Visible = False
            ContextMenuStripReposCDHere.Visible = True
            ContextMenuStripReposCDHere.Text = "Up a level ↩"
            ContextMenuStripReposSeparator4.Visible = True
            ContextMenuStripReposGitPullThis.Visible = True
            ContextMenuStripReposGitPushThis.Visible = True
        End If
    End Sub
End Class
