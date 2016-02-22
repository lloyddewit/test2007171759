﻿' Instat-R
' Copyright (C) 2015

' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.

' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations

Public Class dlgSort

    'Define a boolean to check if the dialog is loading for the first time
    Public bFirstLoad As Boolean = True

    Private Sub dlgSort_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set the things that will always be constant for the dialog
        ' e.g. function name, selectors and receivers
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$sort_dataframe")
        ucrReceiverSort.Selector = ucrSelectorByDataFrameAddRemove
        ucrReceiverSort.SetMeAsReceiver()
        autoTranslate(Me)
        ucrBase.iHelpTopicID = 44

        'If this is the first load, set the defaults and then change bFirstLoad to False
        ' On future loads the dialog will keep previous values used
        ' and not reset to defaults.
        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If

        'Checks if Ok can be enabled.
        'Define this method for each dialog 
        'depending on what parameters are neccessary for the function to run.
        TestOKEnabled()

    End Sub

    ' Sub that runs only the first time the dialog loads
    Private Sub SetDefaults()
        rdoLast.Checked = True
        rdoAscending.Checked = True
        ucrReceiverSort.Clear()
        'Test ok enabled
        TestOKEnabled()
    End Sub

    'Sub that tests if the OK button can be enabled.
    'This runs on load and after anything is changed on the dialog.
    'No other place needs to set Ok enabled, always done through this sub
    Private Sub TestOKEnabled()
        If ucrReceiverSort.GetVariableNames() <> "" AndAlso (rdoAscending.Checked Or rdoDescending.Checked) AndAlso (rdoFirst.Checked Or rdoLast.Checked) Then
            ucrBase.cmdOk.Enabled = True
        Else
            ucrBase.cmdOk.Enabled = False
        End If
    End Sub

    Private Sub ucrReceiverSort_Leave(sender As Object, e As EventArgs) Handles ucrReceiverSort.Leave
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorByDataFrameAddRemove.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
        ucrBase.clsRsyntax.AddParameter("col_names", ucrReceiverSort.GetVariableNames())
        'Test ok enabled
        TestOKEnabled()
    End Sub

    'For grouped radio buttons put all CheckedChanged events into one sub and check which is checked.
    Private Sub grpOrder_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAscending.CheckedChanged, rdoDescending.CheckedChanged
        If rdoAscending.Checked Then
            ucrBase.clsRsyntax.AddParameter("decreasing", "FALSE")
        ElseIf rdoDescending.Checked Then
            ucrBase.clsRsyntax.AddParameter("decreasing", "TRUE")
        Else
            'This case should never happen if the dialog has been designed correctly,
            'but in case of problems it keeps the code stable
            ucrBase.clsRsyntax.RemoveParameter("decreasing")
        End If
        'Test ok enabled
        TestOKEnabled()
    End Sub

    'Same here for this group of buttona
    Private Sub grpMissingValues_ChekedChanged(sender As Object, e As EventArgs) Handles rdoFirst.CheckedChanged, rdoLast.CheckedChanged
        If rdoFirst.Checked Then
            ucrBase.clsRsyntax.AddParameter("na.last", "FALSE")
        ElseIf rdoLast.Checked Then
            ucrBase.clsRsyntax.AddParameter("na.last", "TRUE")
        Else
            ucrBase.clsRsyntax.RemoveParameter("na.last")
        End If

        'Test ok enabled
        TestOKEnabled()
    End Sub

    'When the reset button is clicked, set the defaults again
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    'Use this event to see when something has changed in a receiver
    'For some receivers you need to run TestOKEnabled() on this event.
    Private Sub ucrReceiverSort_SelectionChanged() Handles ucrReceiverSort.SelectionChanged
        'Test ok enabled
        TestOKEnabled()
    End Sub
End Class