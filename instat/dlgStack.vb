﻿' Copyright (C) 2015
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
Public Class dlgStack
    Public bFirstLoad As Boolean = True
    Private Sub dlgStack_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If bFirstLoad Then
            initialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If

        TestOKEnabled()
    End Sub

    Private Sub initialiseDialog()
        ucrBase.clsRsyntax.SetFunction("melt")
        ucrBase.iHelpTopicID = 57
        ucrReceiverColumnsToBeStack.Selector = ucrSelectorStack
        ucrIDVariablesReceiver.Selector = ucrSelectorStack
        autoTranslate(Me)
        ucrNewDataFrameName.SetName(ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked")
        SetStackIntoText("value")
        SetFactorIntoText("variable")
        ucrReceiverColumnsToBeStack.SetMeAsReceiver()
    End Sub

    Private Sub ReopenDialog()
        'TODO this is a work around for AssignTo not clearing in RSyntax
        ucrNewDataFrameName.SetName(ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked")
    End Sub



    Private Sub TestOKEnabled()
        If Not ucrReceiverColumnsToBeStack.IsEmpty() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        ucrNewDataFrameName.Reset()
        ucrSelectorStack.Reset()
        ucrSelectorStack.Focus()
        chkIDVariables.Checked = False
        ucrIDVariablesReceiver.Visible = False
        ucrNewDataFrameName.bUserTyped = False

    End Sub

    Private Sub SetFactorIntoText(strNewVal As String)
        txtFactorInto.Text = strNewVal
        If txtFactorInto.Text = "" Or (txtFactorInto.Text = "variable" AndAlso (Not frmMain.clsInstatOptions.bIncludeRDefaultParameters)) Then
            ucrBase.clsRsyntax.RemoveParameter("variable.name")
        Else
            ucrBase.clsRsyntax.AddParameter("variable.name", Chr(34) & txtFactorInto.Text & Chr(34))
        End If
    End Sub

    Private Sub SetStackIntoText(strNewVal As String)
        txtStackDataInto.Text = strNewVal
        If txtStackDataInto.Text = "" Or (txtStackDataInto.Text = "value" AndAlso (Not frmMain.clsInstatOptions.bIncludeRDefaultParameters)) Then
            ucrBase.clsRsyntax.RemoveParameter("value.name")
        Else
            ucrBase.clsRsyntax.AddParameter("value.name", Chr(34) & txtStackDataInto.Text & Chr(34))
        End If
    End Sub

    Private Sub chkIDVariables_CheckedChanged(sender As Object, e As EventArgs) Handles chkIDVariables.CheckedChanged
        If chkIDVariables.Checked Then
            ucrIDVariablesReceiver.Visible = True
            SetIDVars()
            ucrIDVariablesReceiver.SetMeAsReceiver()
        Else
            ucrIDVariablesReceiver.Visible = False
            ucrReceiverColumnsToBeStack.SetMeAsReceiver()
            ucrBase.clsRsyntax.AddParameter("id.vars", "NULL")
        End If
    End Sub

    Private Sub ucrReceiverColumnsToBeStack_SelectionChanged() Handles ucrReceiverColumnsToBeStack.SelectionChanged
        If Not ucrReceiverColumnsToBeStack.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("measure.vars", ucrReceiverColumnsToBeStack.GetVariableNames())
        Else
            ucrBase.clsRsyntax.RemoveParameter("measure.vars")
        End If
        TestOKEnabled()
    End Sub


    Private Sub ucrIDVariablesReceiver_SelectionChanged() Handles ucrIDVariablesReceiver.SelectionChanged
        SetIDVars()
        TestOKEnabled()
    End Sub

    Private Sub SetIDVars()
        If Not ucrIDVariablesReceiver.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("id.vars", ucrIDVariablesReceiver.GetVariableNames())
        Else
            ucrBase.clsRsyntax.AddParameter("id.vars", "NULL")
        End If

    End Sub

    Private Sub txtFactorInto_Leave(sender As Object, e As EventArgs) Handles txtFactorInto.Leave
        SetFactorIntoText(txtFactorInto.Text)
        TestOKEnabled()
    End Sub

    Private Sub txtStackDataInto_Leave(sender As Object, e As EventArgs) Handles txtStackDataInto.Leave
        SetStackIntoText(txtStackDataInto.Text)
        TestOKEnabled()
    End Sub

    Private Sub ucrDataFrameAddRemove_DataFrameChanged() Handles ucrSelectorStack.DataFrameChanged
        'Always change the data parameter when data frame changed.
        ucrBase.clsRsyntax.AddParameter("data", clsRFunctionParameter:=ucrSelectorStack.ucrAvailableDataFrames.clsCurrDataFrame)

        'For Stack ucrNewDataFrameName may also be changed when data frame changed.
        If Not ucrNewDataFrameName.bUserTyped Then
            ucrNewDataFrameName.SetName(ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked")
        End If

    End Sub

    Private Sub chkIDVariables_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chkIDVariables.KeyPress
        If e.KeyChar = vbCr Then
            If chkIDVariables.Checked Then
                chkIDVariables.Checked = False
            Else
                chkIDVariables.Checked = True
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrNewDataFrameName_NameChanged() Handles ucrNewDataFrameName.NameChanged
        If ucrNewDataFrameName.txtValidation.Text <> "" Then
            ucrBase.clsRsyntax.SetAssignTo(ucrNewDataFrameName.txtValidation.Text, strTempDataframe:=ucrNewDataFrameName.txtValidation.Text)
        Else
            ucrBase.clsRsyntax.RemoveAssignTo()
        End If
    End Sub
End Class