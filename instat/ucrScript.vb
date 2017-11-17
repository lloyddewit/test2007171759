﻿' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Public Class ucrScript
    Private strComment As String = "Code run from Script Window"

    Public Sub CopyText()
        txtScript.Copy()
    End Sub

    Public Sub SelectAllText()
        txtScript.SelectAll()
    End Sub

    Private Sub cmdRun_Click(sender As Object, e As EventArgs) Handles cmdRun.Click
        Dim strScript As String
        strScript = txtScript.Text
        frmMain.clsRLink.RunWindowScripts(strNewScript:=strScript, strNewComment:=strComment, INewCalltype:=0)
    End Sub

    Public Sub AppendText(strText As String)
        txtScript.Text = txtScript.Text & Environment.NewLine & strText
        txtScript.SelectionStart = txtScript.Text.Length
        txtScript.ScrollToCaret()
        txtScript.Refresh()
    End Sub

    Private Sub mnuRunWholeScript_Click(sender As Object, e As EventArgs) Handles mnuClearContents.Click
        Dim dlgResponse As DialogResult
        If txtScript.Text <> "" Then
            dlgResponse = MessageBox.Show("Are you sure you want to clear the " & Me.Text, "Clear " & Me.Text, MessageBoxButtons.YesNo)
            If dlgResponse = DialogResult.Yes Then
                txtScript.Clear()
            End If
        End If
    End Sub

    Private Sub mnuRunSelectedText_Click(sender As Object, e As EventArgs) Handles mnuRunSelectedText.Click
        Dim strSelectedScript As String

        If txtScript.SelectionLength > 0 AndAlso txtScript.SelectedText <> "" Then
            strSelectedScript = txtScript.SelectedText

            If MsgBox("This may give errors if a selection is incomplete or if the data has changed. Do you want to proceed?", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
                frmMain.clsRLink.RunWindowScripts(strNewScript:=strSelectedScript, strNewComment:=strComment, INewCalltype:=0)
            End If

        Else
            MsgBox("You need to select some text before running", vbOKOnly)
        End If
    End Sub
End Class
