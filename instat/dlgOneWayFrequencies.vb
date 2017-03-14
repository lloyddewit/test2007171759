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

Public Class dlgOneWayFrequencies
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsSjtFreq As New RFunction
    Private clsSjpFrq As New RFunction
    Private Sub dlgOneWayFrequencies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverOneWayFreq.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlSort.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkTable.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkGraph.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkweights.SetRCode(clsSjtFreq, bReset)
        ucrChkweights.SetRCode(clsSjpFrq, bReset)
        ucrChkFlip.SetRCode(clsSjpFrq, bReset)
    End Sub

    Private Sub InitialiseDialog()
        'HelpID
        ' ucrBase.iHelpTopicID = 
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrReceiverOneWayFreq.Selector = ucrSelectorOneWayFreq
        ucrReceiverOneWayFreq.SetMeAsReceiver()
        ucrReceiverOneWayFreq.SetDataType("numeric")
        ucrReceiverOneWayFreq.SetParameter(New RParameter("data", 1))
        ucrReceiverOneWayFreq.SetParameterIsRFunction()


        ucrPnlSort.SetParameter(New RParameter("sort.frq"))
        ucrPnlSort.AddRadioButton(rdoNone, Chr(34) & "none" & Chr(34))
        ucrPnlSort.AddRadioButton(rdoAscending, Chr(34) & "asc" & Chr(34))
        ucrPnlSort.AddRadioButton(rdoDescending, Chr(34) & "desc" & Chr(34))
        ucrPnlSort.SetRDefault(Chr(34) & "none" & Chr(34))


        ucrChkTable.SetText("Table")
        ucrChkweights.SetText("Weights")
        '   ucrChkweights.SetParameter(New RParameter("weight.by"))

        ucrChkGraph.SetText("Graph")

        ucrChkFlip.SetText("Flip Coordinates")
        ucrChkFlip.SetParameter(New RParameter("coord.flip"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkFlip.SetRDefault("FALSE")

        ucrChkweights.AddToLinkedControls(ucrReceiverOneWayFreq, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverOneWayFreq.SetLinkedDisplayControl(lblSelectedVariable)

        ucrSaveGraph.SetPrefix("one_way_freq")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorOneWayFreq.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()
    End Sub

    Private Sub SetDefaults()
        clsSjtFreq = New RFunction
        clsSjpFrq = New RFunction
        ucrSelectorOneWayFreq.Reset()
        ucrSaveGraph.Reset()
        ucrReceiverOneWayFreq.SetParameter(New RParameter("data", 1))
        ucrReceiverOneWayFreq.SetParameterIsRFunction()
        clsSjtFreq.SetRCommand("sjPlot::sjt.frq")
        clsSjtFreq.AddParameter("data", clsRFunctionParameter:=ucrReceiverOneWayFreq.GetVariables)
        ' clsSjtFreq.AddParameter("weight.by", ucrReceiverOneWayFreq.GetVariableNames)
        clsSjtFreq.AddParameter("sort.frq", Chr(34) & "none" & Chr(34))
        'clsSjtFreq.AddParameter("use.viewer", "TRUE")
        clsSjpFrq.SetRCommand("sjPlot::sjp.frq")
        clsSjpFrq.AddParameter("var.cnt", clsRFunctionParameter:=ucrReceiverOneWayFreq.GetVariables)
        ' clsSjpFrq.AddParameter("weight.by", ucrReceiverOneWayFreq.GetVariableNames)


        ucrBase.clsRsyntax.SetBaseRFunction(clsSjtFreq)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverOneWayFreq.IsEmpty() AndAlso ucrSaveGraph.IsComplete() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ChangeBaseFunction()
        If ucrChkTable.Checked Then
            ucrReceiverOneWayFreq.SetParameter(New RParameter("data", 1))
            ucrReceiverOneWayFreq.SetParameterIsRFunction()
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjtFreq)
        Else
            ucrReceiverOneWayFreq.SetParameter(New RParameter("var.cnt", 1))
            ucrReceiverOneWayFreq.SetParameterIsRFunction()
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjpFrq)
        End If
        SetRCodeForControls(False)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub


    'Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
    '    If ucrChkTable.Checked Then
    '        frmMain.clsRLink.RunScript(clsSjtFreq.ToScript(), iCallType:=2)
    '    End If
    'End Sub
    Private Sub AllControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOneWayFreq.ControlValueChanged, ucrChkTable.ControlValueChanged, ucrChkGraph.ControlValueChanged, ucrPnlSort.ControlValueChanged
        ChangeBaseFunction()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOneWayFreq.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged
        TestOkEnabled()
    End Sub

End Class