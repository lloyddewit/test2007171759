﻿' Instat-R
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
Public Class dlgOneVarUseModel
    Public bfirstload As Boolean = True
    Public bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Public clsRBootFunction, clsQuantileFunction, clsSeqFunction As New RFunction
    Private Sub dlgOneVarUseModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bfirstload Then
            InitialiseDialog()
            bfirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 375
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrReceiverObject.SetParameter(New RParameter("x", 0))
        ucrReceiverObject.Selector = ucrSelectorUseModel
        ucrReceiverObject.SetParameterIsRFunction()
        ucrReceiverObject.SetMeAsReceiver()
        ucrReceiverObject.strSelectorHeading = "Models" ' check this

        ucrSelectorUseModel.SetItemType("model")

        ucrChkProduceBootstrap.AddToLinkedControls(ucrSaveObjects, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=False)
        ucrChkProduceBootstrap.AddParameterValueFunctionNamesCondition(True, "x", "bootdist", True)
        ucrChkProduceBootstrap.AddParameterValueFunctionNamesCondition(False, "x", "bootdist", False)
        ucrChkProduceBootstrap.SetText("Produce Bootstrap")

        'This part is temporary for now
        sdgOneVarUseModFit.SetMyBootFunction(clsRBootFunction)

        ucrNewDataFrameName.SetPrefix("UseModel")
        ucrNewDataFrameName.SetDataFrameSelector(ucrSelectorUseModel.ucrAvailableDataFrames)
        ucrNewDataFrameName.SetSaveTypeAsModel()
        ucrNewDataFrameName.SetIsComboBox()
        ucrNewDataFrameName.SetCheckBoxText("Save Model")
        ucrNewDataFrameName.SetAssignToIfUncheckedValue("last_model")

        ucrSaveObjects.SetPrefix("bootstrap")
        ucrSaveObjects.SetSaveTypeAsModel()
        ucrSaveObjects.SetIsComboBox()
        ucrSaveObjects.SetCheckBoxText("Save Bootstrap")
        '        ucrSaveObjects.SetAssignToIfUncheckedValue("last_bootstrap")
    End Sub

    Private Sub SetDefaults()
        clsRBootFunction = New RFunction
        clsQuantileFunction = New RFunction
        clsSeqFunction = New RFunction

        ucrSelectorUseModel.Reset()
        ucrSaveObjects.Enabled = False 'for now
        ucrSaveObjects.Reset()
        ucrNewDataFrameName.Reset()
        sdgOneVarUseModFit.SetDefaults()

        clsSeqFunction.SetRCommand("seq")
        clsSeqFunction.AddParameter("from", 0)
        clsSeqFunction.AddParameter("to", 1)
        clsSeqFunction.AddParameter("by",0.25)

        clsQuantileFunction.SetRCommand("quantile")
        clsQuantileFunction.AddParameter("probs", clsRFunctionParameter:=clsSeqFunction)

        clsRBootFunction.SetPackageName("fitdistrplus")
        clsRBootFunction.SetRCommand("bootdist")
        clsRBootFunction.AddParameter("bootmethod", Chr(34) & "nonparam" & Chr(34))
        clsRBootFunction.AddParameter("niter", 1001)

        ucrBase.clsRsyntax.SetBaseRFunction(clsQuantileFunction)

        ucrBase.clsRsyntax.SetAssignTo(ucrNewDataFrameName.GetText, strTempModel:="last_model", strTempDataframe:=ucrSelectorUseModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        '        clsRBootFunction.SetAssignTo(ucrSaveObjects.GetText, strTempModel:="last_bootstrap", strTempDataframe:=ucrSelectorUseModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text) ' test at end.
        bResetSubdialog = True
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverObject.AddAdditionalCodeParameterPair(clsRBootFunction, New RParameter("f"), iAdditionalPairNo:=1)
        ucrChkProduceBootstrap.SetRCode(clsRBootFunction, bReset)
        ucrNewDataFrameName.SetRCode(clsQuantileFunction, bReset)
        ucrSaveObjects.SetRCode(clsRBootFunction, bReset)
        ucrReceiverObject.SetRCode(clsQuantileFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverObject.IsEmpty AndAlso ucrSaveObjects.IsComplete() AndAlso ucrNewDataFrameName.IsComplete() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        If ucrChkProduceBootstrap.Checked Then
            frmMain.clsRLink.RunScript(clsRBootFunction.ToScript(), iCallType:=2)
        End If
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        sdgOneVarUseModFit.CreateGraphs()
    End Sub

    '  Private Sub AssignSaveObjects()
    ' If chkSaveBootstrap.Checked AndAlso Not ucrSaveObjects.IsEmpty Then
    ''       ucrBase.clsRsyntax.SetAssignTo(ucrSaveObjects.GetText, strTempModel:=ucrSaveObjects.GetText, strTempDataframe:=ucrSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
    ''Else
    ''       ucrBase.clsRsyntax.SetAssignTo("last_bootstrap", strTempModel:="last_bootstrap", strTempDataframe:=ucrSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
    'End If
    'End Sub

    Public Sub QuantileCommand()
        If sdgOneVarUseModFit.rdoSequence.Checked Then
            clsQuantileFunction.AddParameter("probs", clsRFunctionParameter:=clsSeqFunction)
        Else
            clsQuantileFunction.AddParameter("probs", strParameterValue:="c(" & sdgOneVarUseModFit.ucrInputQuantiles.GetText & ")")
        End If
    End Sub

    Private Sub cmdFitModel_Click(sender As Object, e As EventArgs) Handles cmdFitModelandBootstrap.Click
        sdgOneVarUseModFit.SetRFunction(clsSeqFunction, clsRBootFunction, clsQuantileFunction, bResetSubdialog)
        bResetSubdialog = False
        sdgOneVarUseModFit.ShowDialog()
    End Sub

    Private Sub ucrChkProduceBootstrap_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkProduceBootstrap.ControlValueChanged
        If ucrChkProduceBootstrap.Checked Then
            clsQuantileFunction.AddParameter("x", clsRFunctionParameter:=clsRBootFunction)
        Else
            clsQuantileFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverObject.GetVariables())
                   End If
        sdgOneVarUseModFit.SetPlotOptions()
    End Sub

    Private Sub ucrReceiver_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverObject.ControlContentsChanged, ucrSaveObjects.ControlContentsChanged, ucrNewDataFrameName.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class