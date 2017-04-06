﻿' Instat+R
' Copyright (C) 2015
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations

Public Class ucrButtons
    Public clsRsyntax As RSyntax
    Public iHelpTopicID As Integer
    Public bFirstLoad As Boolean
    Public strComment As String


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        clsRsyntax = New RSyntax
        iHelpTopicID = -1
        bFirstLoad = True
        strComment = "code generated by the dialog"
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.ParentForm.Hide()
    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        SetDefaults()
        RaiseEvent ClickReset(sender, e)
    End Sub

    Public Event BeforeClickOk(sender As Object, e As EventArgs)
    Public Event ClickOk(sender As Object, e As EventArgs)
    Public Event ClickReset(sender As Object, e As EventArgs)

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        Dim strComments As String = ""
        Dim bIsAssigned As Boolean
        Dim bToBeAssigned As Boolean
        Dim strAssignTo As String
        Dim lstCurrentEnabled As New List(Of Boolean)
        Dim ctrTempControl As Control
        Dim i As Integer

        For Each ctrTempControl In ParentForm.Controls
            lstCurrentEnabled.Add(ctrTempControl.Enabled)
            ctrTempControl.Enabled = False
        Next
        ParentForm.Cursor = Cursors.WaitCursor

        RaiseEvent BeforeClickOk(sender, e)

        If chkComment.Checked Then
            strComments = txtComment.Text
        End If
        bIsAssigned = clsRsyntax.GetbIsAssigned()
        bToBeAssigned = clsRsyntax.GetbToBeAssigned()
        strAssignTo = clsRsyntax.GetstrAssignTo()
        'Also need to be getting strAssignToColumn, strAssignToDataFrame etc. maybe one method to get all as a list
        frmMain.clsRLink.RunScript(clsRsyntax.GetScript(), clsRsyntax.iCallType, bHtmlOutput:=clsRsyntax.bHTMLOutput, strComment:=strComments)

        'This clears the script after it has been run, but leave the function and parameters in the base function
        'so that it can be run exactly the same when reopened.
        clsRsyntax.strScript = ""

        RaiseEvent ClickOk(sender, e)
        clsRsyntax.SetbIsAssigned(bIsAssigned)
        clsRsyntax.SetbToBeAssigned(bToBeAssigned)
        clsRsyntax.SetstrAssignTo(strAssignTo)
        'Need to be resetting other AssignTo values as well, maybe through single method

        'Warning: these reinitializing processes of the RSyntax parameters should probably be integrated at the end of GetScript. 
        'However, for the moment, RSyntax is not playing it's role of capturing the whole set of R-commands that the user wants to run when OK is Cklicked. 
        'Indeed, the events BeforeClickOk and ClickOk enables for the moment to insert R-commands before and after the Base R-command handle. 
        'In the process, we want the RSyntax parameters to be set as at the end of GetScript. Hence the reset needs to come after.
        'Eventually, all this should be more neatly incorporated in the RSyntax machinery...
        ParentForm.Hide()
        i = 0
        For Each ctrTempControl In ParentForm.Controls
            ctrTempControl.Enabled = lstCurrentEnabled(i)
            i = i + 1
        Next
        ParentForm.Cursor = Cursors.Default

    End Sub

    Public Sub OKEnabled(bEnabled As Boolean)
        cmdOk.Enabled = bEnabled
        cmdPaste.Enabled = bEnabled
    End Sub

    Private Sub ucrButtons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.clsRecentItems.addToMenu(Me.Parent)
        translateEach(Controls)
        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Private Sub SetDefaults()
        If frmMain.clsInstatOptions IsNot Nothing Then
            chkComment.Checked = frmMain.clsInstatOptions.bIncludeCommentDefault
        Else
            chkComment.Checked = True
        End If
        SetCommentEditable()
        'TODO default text should be translatable
        'This is needed only so that the designer displays correctly in VS
        If frmMain.clsInstatOptions IsNot Nothing Then
            txtComment.Text = ParentForm.Name & " " & frmMain.clsInstatOptions.strComment & " " & ParentForm.Text
        Else
            txtComment.Text = ParentForm.Name & " " & ParentForm.Text
        End If
    End Sub

    Private Sub cmdPaste_Click(sender As Object, e As EventArgs) Handles cmdPaste.Click
        'here we getscript but we don't reinitialise the AssignTo etc. for when pressing OK button ? ...
        frmMain.AddToScriptWindow("# " & txtComment.Text & vbCrLf & clsRsyntax.GetScript())
    End Sub

    Private Sub chkComment_CheckedChanged(sender As Object, e As EventArgs) Handles chkComment.CheckedChanged
        SetCommentEditable()
    End Sub

    Private Sub SetCommentEditable()
        txtComment.Enabled = chkComment.Checked
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        HelpContent()
    End Sub

    Private Sub HelpContent()
        ' (1) Use HelpNDoc's Help Context number. Not dependent on HelpNDoc.
        If iHelpTopicID > 0 Then
            Help.ShowHelp(Me.Parent, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, iHelpTopicID.ToString())
        Else
            Help.ShowHelp(Me.Parent, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TableOfContents)
        End If

        ' (2) Use HelpNDoc's Help ID. Dependent on how HelpNDoc complies .htm files using the Help ID
        'Help.ShowHelp(Me, strHelpFilePath, HelpNavigator.Topic, "Maths.htm")

        ' (3) Use constants or enums automatically generated by HelpNDoc (but needing manual
        '     covertion from .bas) to refer to the Help Context numbers.
        'Help.ShowHelp(Me, strHelpFilePath, HelpNavigator.TopicId, mHelpConstants.HELP_Maths.ToString)
    End Sub
    Private Sub chkComment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chkComment.KeyPress
        If e.KeyChar = vbCr And chkComment.Checked = True Then
            chkComment.Checked = False
        ElseIf e.KeyChar = vbCr And chkComment.Checked = False Then
            chkComment.Checked = True
        End If
    End Sub
End Class