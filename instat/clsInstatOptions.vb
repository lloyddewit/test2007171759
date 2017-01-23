﻿Imports System.Threading
Imports System.Globalization
Imports unvell.ReoGrid
Imports RDotNet

'Serializable allows the class to be exported as a file
<Serializable()> Public Class InstatOptions
    Public bIncludeRDefaultParameters As Boolean
    Public fntOutput, fntScript, fntComment, fntEditor As Font
    Public clrOutput, clrScript, clrComment, clrEditor As Color
    Public strComment, strLanguageCultureCode As String
    Public strWorkingDirectory As String
    ' Nullable allows us to have integers and booleans with value = Nothing
    ' Needed so we can check if variable has been specified, not just has default value
    Public iPreviewRows As Nullable(Of Integer)
    Public iMaxRows As Nullable(Of Integer)
    Public lstColourPalette As List(Of Color)
    Public strGraphDisplayOption As String
    Public bCommandsinOutput As Nullable(Of Boolean)
    Public bIncludeCommentDefault As Nullable(Of Boolean) 'sets the default for comments on the dialog
    Public iDigits As Nullable(Of Integer)
    Public bShowSignifStars As Nullable(Of Boolean)

    'Factory defaults
    Private DEFAULTbIncludeRDefaultParameters As Boolean = False
    Private DEFAULTbCommandsinOutput As Boolean = True
    Private DEFAULTbIncludeCommentDefault As Boolean = True
    Private DEFAULTfntOutput As Font = New Font(FontFamily.GenericMonospace, 11, FontStyle.Regular)
    Private DEFAULTclrOutput As Color = Color.Blue
    Private DEFAULTfntComment As Font = New Font(FontFamily.GenericSansSerif, 11, FontStyle.Regular)
    Private DEFAULTclrComment As Color = Color.Green
    Private DEFAULTfntScript As Font = New Font(FontFamily.GenericSansSerif, 11, FontStyle.Regular)
    Private DEFAULTclrScript As Color = Color.Black
    Private DEFAULTfntEditor As Font = New Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular)
    Private DEFAULTclrEditor As Color = Color.Black
    Private DEFAULTiPreviewRows As Integer = 10
    Private DEFAULTiMaxRows As Integer = 1000
    Private DEFAULTstrComment As String = "code generated by the dialog"
    Private DEFAULTstrGraphDisplayOption As String = "view_output_window"
    'TODO is this sensible?
    Private DEFAULTstrLanguageCultureCode As String = Thread.CurrentThread.CurrentCulture.Name
    Private DEFAULTstrWorkingDirectory As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Private DEFAULTlstColourPalette As List(Of Color) = ({Color.Aqua, Color.Gray, Color.LightGreen, Color.AliceBlue, Color.Maroon, Color.Green, Color.LightPink, Color.LightSkyBlue, Color.Brown, Color.MediumPurple, Color.White}).ToList
    Private DEFAULTiDigits As Integer = 4
    Private DEFAULTbShowSignifStars As Boolean = False

    Public Sub New(Optional bSetOptions As Boolean = True)
        'TODO Is this sensible to do in constructor?
        bIncludeRDefaultParameters = DEFAULTbIncludeRDefaultParameters
        bCommandsinOutput = DEFAULTbCommandsinOutput
        bIncludeCommentDefault = DEFAULTbIncludeCommentDefault
        fntOutput = DEFAULTfntOutput
        clrOutput = DEFAULTclrOutput
        fntComment = DEFAULTfntComment
        clrComment = DEFAULTclrComment
        fntScript = DEFAULTfntScript
        clrScript = DEFAULTclrScript
        fntEditor = DEFAULTfntEditor
        clrEditor = DEFAULTclrEditor
        iPreviewRows = DEFAULTiPreviewRows
        iMaxRows = DEFAULTiMaxRows
        strComment = DEFAULTstrComment
        strGraphDisplayOption = DEFAULTstrGraphDisplayOption
        'TODO is this sensible?
        strLanguageCultureCode = DEFAULTstrLanguageCultureCode
        strWorkingDirectory = DEFAULTstrWorkingDirectory
        SetColorPalette(DEFAULTlstColourPalette)
        iDigits = DEFAULTiDigits
        bShowSignifStars = DEFAULTbShowSignifStars
        If bSetOptions Then
            SetOptions()
        End If
    End Sub

    Public Sub SetOptions()
        If fntOutput IsNot Nothing AndAlso clrOutput <> Color.Empty Then
            SetFormatOutput(fntOutput, clrOutput)
        Else
            SetFormatOutput(DEFAULTfntOutput, DEFAULTclrOutput)
        End If

        If fntComment IsNot Nothing AndAlso clrComment <> Color.Empty Then
            SetFormatComment(fntComment, clrComment)
        Else
            SetFormatComment(DEFAULTfntComment, DEFAULTclrComment)
        End If

        If fntScript IsNot Nothing AndAlso clrScript <> Color.Empty Then
            SetFormatScript(fntScript, clrScript)
        Else
            SetFormatScript(DEFAULTfntScript, DEFAULTclrScript)
        End If

        If fntEditor IsNot Nothing AndAlso clrEditor <> Color.Empty Then
            SetFormatEditor(fntEditor, clrEditor)
        Else
            SetFormatEditor(DEFAULTfntEditor, DEFAULTclrEditor)
        End If

        If iPreviewRows.HasValue Then
            SetPreviewRows(iPreviewRows)
        Else
            SetPreviewRows(DEFAULTiPreviewRows)
        End If

        If iMaxRows.HasValue Then
            SetMaxRows(iMaxRows)
        Else
            SetMaxRows(DEFAULTiMaxRows)
        End If

        If bCommandsinOutput.HasValue Then
            SetCommandInOutpt(bCommandsinOutput)
        Else
            SetCommandInOutpt(DEFAULTbCommandsinOutput)
        End If

        If strComment IsNot Nothing Then
            SetComment(strComment)
        Else
            SetComment(DEFAULTstrComment)
        End If

        If strGraphDisplayOption IsNot Nothing Then
            SetGraphDisplayOption(strGraphDisplayOption)
        Else
            SetGraphDisplayOption(DEFAULTstrGraphDisplayOption)
        End If

        If strLanguageCultureCode IsNot Nothing Then
            SetLanguageCultureCode(strLanguageCultureCode)
        Else
            SetLanguageCultureCode(DEFAULTstrLanguageCultureCode)
        End If

        If strWorkingDirectory IsNot Nothing Then
            SetWorkingDirectory(strWorkingDirectory)
        Else
            SetWorkingDirectory(DEFAULTstrWorkingDirectory)
        End If

        If iDigits.HasValue Then
            SetDigits(iDigits)
        Else
            SetDigits(DEFAULTiDigits)
        End If

        If bShowSignifStars.HasValue Then
            SetSignifStars(bShowSignifStars)
        Else
            SetSignifStars(DEFAULTbShowSignifStars)
        End If
    End Sub

    Public Sub SetMaxRows(iRows As Integer)
        If iRows <> iMaxRows Then
            iMaxRows = iRows
            frmMain.clsGrids.SetMaxRows(iMaxRows)
        End If
    End Sub

    Public Sub SetFormatOutput(fntNew As Font, clrNew As Color)
        fntOutput = fntNew
        clrOutput = clrNew
        frmMain.clsRLink.setFormatOutput(fntOutput, clrOutput)
    End Sub

    Public Sub SetFormatScript(fntNew As Font, clrNew As Color)
        fntScript = fntNew
        clrScript = clrNew
        frmMain.clsRLink.setFormatScript(fntScript, clrScript)
    End Sub

    Public Sub SetFormatComment(fntNew As Font, clrNew As Color)
        fntComment = fntNew
        clrComment = clrNew
        frmMain.clsRLink.setFormatComment(fntComment, clrComment)
    End Sub

    Public Sub SetFormatEditor(fntNew As Font, clrNew As Color)
        fntEditor = fntNew
        clrEditor = clrNew
        frmMain.clsGrids.SetFormatDataView(fntEditor, clrEditor)
    End Sub

    Public Sub SetPreviewRows(intlines As Integer)
        iPreviewRows = intlines
        dlgImportDataset.setLinesToRead(iPreviewRows)
    End Sub

    Public Sub SetComment(strText As String)
        strComment = strText
    End Sub

    Public Sub SetLanguageCultureCode(strLanguage As String)
        strLanguageCultureCode = strLanguage
        Select Case strLanguageCultureCode
            Case "en-GB"
                Thread.CurrentThread.CurrentCulture = New CultureInfo("en-GB")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-GB")
            Case "fr-FR"
                Thread.CurrentThread.CurrentCulture = New CultureInfo("fr-FR")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("fr-FR")
            Case "sw-KE"
                Thread.CurrentThread.CurrentCulture = New CultureInfo("sw-KE")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("sw-KE")
            Case "es-ES"
                Thread.CurrentThread.CurrentCulture = New CultureInfo("es-ES")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("es-ES")
            Case Else
                Thread.CurrentThread.CurrentCulture = New CultureInfo("en-GB")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-GB")
        End Select
    End Sub

    Public Sub SetWorkingDirectory(strWD As String)
        Dim clsSetwdFunction As New RFunction

        clsSetwdFunction.SetRCommand("setwd")
        clsSetwdFunction.AddParameter("dir", Chr(34) & strWorkingDirectory & Chr(34))
        strWorkingDirectory = strWD
        'This is done in R link setup. Need to rethink how this is done.
        'Commented out for now to not repeat.
        'frmMain.clsRLink.RunScript(clsSetwdFunction.ToScript(), strComment:="Option: Setting working directory")
    End Sub

    Public Sub SetColorPalette(lstColours As List(Of Color))
        lstColourPalette = lstColours
    End Sub

    Public Sub SetGraphDisplayOption(strGraphOption As String)
        strGraphDisplayOption = strGraphOption
        'setting the string for graphs display
        frmMain.clsRLink.strGraphDisplayOption = strGraphDisplayOption
    End Sub

    Public Sub SetCommandInOutpt(bCommand As Boolean)
        bCommandsinOutput = bCommand
        frmMain.clsRLink.bShowCommands = bCommandsinOutput
    End Sub

    Public Sub SetCommentsInOutput(bComment As Boolean)
        bCommandsinOutput = bComment
    End Sub

    Public Sub SetDigits(iNewDigits As Integer)
        Dim clsOptionsFunction As New RFunction
        Dim clsGetOptionFunction As New RFunction

        If iNewDigits > 22 OrElse iNewDigits < 0 Then
            MsgBox("Cannot set digits to: " & iNewDigits & ". Digits must be an integer between 0 and 22.", MsgBoxStyle.Critical, "Error setting digits")
        Else
            iDigits = iNewDigits
            clsGetOptionFunction.SetRCommand("getOption")
            clsGetOptionFunction.AddParameter("x", Chr(34) & "digits" & Chr(34))
            If frmMain.clsRLink.RunInternalScriptGetValue(clsGetOptionFunction.ToScript()).AsInteger(0) <> iDigits Then
                clsOptionsFunction.SetRCommand("options")
                clsOptionsFunction.AddParameter("digits", iDigits)
                frmMain.clsRLink.RunScript(clsOptionsFunction.ToScript(), strComment:="Option: Number of digits to display")
            End If
        End If
    End Sub

    Public Sub SetSignifStars(bShowStars As Boolean)
        Dim clsOptionsFunction As New RFunction
        Dim clsGetOptionsFunction As New RFunction

        bShowSignifStars = bShowStars
        clsGetOptionsFunction.SetRCommand("getOption")
        clsGetOptionsFunction.AddParameter("x", Chr(34) & "show.signif.stars" & Chr(34))
        clsOptionsFunction.SetRCommand("options")
        If frmMain.clsRLink.RunInternalScriptGetValue(clsGetOptionsFunction.ToScript()).AsLogical(0) <> bShowSignifStars Then
            If bShowSignifStars Then
                clsOptionsFunction.AddParameter("show.signif.stars", "TRUE")
            Else
                clsOptionsFunction.AddParameter("show.signif.stars", "FALSE")
            End If
            frmMain.clsRLink.RunScript(clsOptionsFunction.ToScript(), strComment:="Option: Show stars on summary tables of coefficients")
        End If
    End Sub
End Class