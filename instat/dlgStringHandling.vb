﻿'' Instat-R
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
Public Class dlgStringHandling
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsCountFunction, clsExtractFunction, clsDetectFunction, clsLocateFunction, clsReplaceFunction As New RFunction
    Private Sub dlgStringHandling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        'ucrReceiver
        ucrReceiverStringHandling.SetParameter(New RParameter("string", 0))
        ucrReceiverStringHandling.SetParameterIsRFunction()
        ucrReceiverStringHandling.Selector = ucrSelectorStringHandling
        ucrReceiverStringHandling.SetMeAsReceiver()

        'ucrRdoOptions
        ucrPnlStringHandling.AddRadioButton(rdoCount)
        ucrPnlStringHandling.AddRadioButton(rdoExtract)
        ucrPnlStringHandling.AddRadioButton(rdoDetect)
        ucrPnlStringHandling.AddRadioButton(rdoLocate)
        ucrPnlStringHandling.AddRadioButton(rdoReplace)

        ucrPnlStringHandling.AddFunctionNamesCondition(rdoCount, "str_count")
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoExtract, "str_extract")
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoDetect, "str_detect")
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoLocate, "str_locate")
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoReplace, "str_replace")

        ucrInputPattern.SetParameter(New RParameter("pattern", 1))
        ucrInputReplaceBy.SetParameter(New RParameter("replacement", 2))

        'disabling replaceby input text box
        ucrPnlStringHandling.AddToLinkedControls(ucrInputReplaceBy, {rdoReplace}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)

        'ucrSave
        ucrSaveStringHandling.SetPrefix("count")
        ucrSaveStringHandling.SetSaveTypeAsColumn()
        ucrSaveStringHandling.SetDataFrameSelector(ucrSelectorStringHandling.ucrAvailableDataFrames)
        ucrSaveStringHandling.SetIsTextBox()
        'ucrSaveStringHandling.SetLabelText("Save Result:")
    End Sub

    Private Sub SetDefaults()
        clsCountFunction = New RFunction
        clsExtractFunction = New RFunction
        clsDetectFunction = New RFunction
        clsLocateFunction = New RFunction
        clsReplaceFunction = New RFunction

        ucrSelectorStringHandling.Reset()
        ucrInputPattern.Reset()
        ucrInputReplaceBy.Reset()
        ucrSaveStringHandling.Reset()
        ucrInputReplaceBy.SetName("")
        ucrInputPattern.SetName("")
        clsCountFunction.SetPackageName("stringr")
        clsCountFunction.SetRCommand("str_count")
        clsExtractFunction.SetPackageName("stringr")
        clsExtractFunction.SetRCommand("str_extract")
        clsDetectFunction.SetPackageName("stringr")
        clsDetectFunction.SetRCommand("str_detect")
        clsLocateFunction.SetPackageName("stringr")
        clsLocateFunction.SetRCommand("str_locate")
        clsReplaceFunction.SetPackageName("stringr")
        clsReplaceFunction.SetRCommand("str_replace")
        clsCountFunction.SetAssignTo(ucrSaveStringHandling.GetText, strTempDataframe:=ucrSelectorStringHandling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveStringHandling.GetText, bAssignToIsPrefix:=True)
        ucrBase.clsRsyntax.SetBaseRFunction(clsCountFunction)
        NewColumnName()
        ChangePrefixName()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsDetectFunction, New RParameter("string", 0), iAdditionalPairNo:=1)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsExtractFunction, New RParameter("string", 0), iAdditionalPairNo:=2)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsLocateFunction, New RParameter("string", 0), iAdditionalPairNo:=3)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsReplaceFunction, New RParameter("string", 0), iAdditionalPairNo:=4)

        ucrInputPattern.AddAdditionalCodeParameterPair(clsDetectFunction, New RParameter("pattern", 1), iAdditionalPairNo:=1)
        ucrInputPattern.AddAdditionalCodeParameterPair(clsExtractFunction, New RParameter("pattern", 1), iAdditionalPairNo:=2)
        ucrInputPattern.AddAdditionalCodeParameterPair(clsLocateFunction, New RParameter("pattern", 1), iAdditionalPairNo:=3)
        ucrInputPattern.AddAdditionalCodeParameterPair(clsReplaceFunction, New RParameter("pattern", 1), iAdditionalPairNo:=4)

        ucrReceiverStringHandling.SetRCode(clsCountFunction, bReset)
        ucrInputPattern.SetRCode(clsCountFunction, bReset)
        ucrInputReplaceBy.SetRCode(clsReplaceFunction, bReset)
        ucrPnlStringHandling.SetRCode(clsCountFunction, bReset)
        ucrSaveStringHandling.SetRCode(clsCountFunction, bReset)

        ucrSaveStringHandling.AddAdditionalRCode(clsDetectFunction, iAdditionalPairNo:=1)
        ucrSaveStringHandling.AddAdditionalRCode(clsExtractFunction, iAdditionalPairNo:=2)
        ucrSaveStringHandling.AddAdditionalRCode(clsLocateFunction, iAdditionalPairNo:=3)
        ucrSaveStringHandling.AddAdditionalRCode(clsReplaceFunction, iAdditionalPairNo:=4)
    End Sub

    Private Sub ChangePrefixName()
        If Not ucrSaveStringHandling.bUserTyped Then
            If rdoCount.Checked Then
                ucrSaveStringHandling.SetPrefix("count")
            ElseIf rdoDetect.Checked Then
                ucrSaveStringHandling.SetPrefix("detect")
            ElseIf rdoExtract.Checked Then
                ucrSaveStringHandling.SetPrefix("extract")
            ElseIf rdoLocate.Checked Then
                ucrSaveStringHandling.SetName("locate")
            ElseIf rdoReplace.Checked Then
                ucrSaveStringHandling.SetPrefix("replace")
            End If
        End If
    End Sub

    Private Sub NewColumnName()
        If rdoLocate.Checked Then
            ucrSaveStringHandling.SetLabelText("New Column Name:")
        Else
            ucrSaveStringHandling.SetLabelText("Save Result:")
        End If
    End Sub
    Private Sub TestOkEnabled()
        If rdoReplace.Checked AndAlso ucrSaveStringHandling.IsComplete() AndAlso Not ucrReceiverStringHandling.IsEmpty() AndAlso Not ucrInputPattern.IsEmpty AndAlso Not ucrInputReplaceBy.IsEmpty Then
            ucrBase.OKEnabled(True)
        ElseIf (rdoCount.Checked OrElse rdoDetect.Checked OrElse rdoExtract.Checked OrElse rdoLocate.Checked) AndAlso ucrSaveStringHandling.IsComplete() AndAlso Not ucrReceiverStringHandling.IsEmpty() AndAlso Not ucrInputPattern.IsEmpty() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverStringHandling_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStringHandling.ControlContentsChanged, ucrPnlStringHandling.ControlContentsChanged, ucrInputPattern.ControlContentsChanged, ucrInputReplaceBy.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlStringHandling_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlStringHandling.ControlValueChanged
        ChangePrefixName()
        NewColumnName()
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        If rdoCount.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsCountFunction)
        ElseIf rdoDetect.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsDetectFunction)
        ElseIf rdoExtract.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsExtractFunction)
        ElseIf rdoLocate.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsLocateFunction)
        ElseIf rdoReplace.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsReplaceFunction)
        End If
    End Sub
End Class