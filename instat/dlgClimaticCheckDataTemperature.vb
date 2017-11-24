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

Imports instat.Translations
Public Class dlgClimaticCheckDataTemperature
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private strCurrDataFrame As String
    Private clsGroupByFunc, clsListFunc, clsFilterFunc, clsRunCalcFunc As RFunction
    Private clsLessOperator, clsGreaterOperator, clsAndOpertor As ROperator

    'jump
    Private clsConcFunc, clsDiffFunc, clsAbsFunc As RFunction
    Private clsJumpGreaterOperator As ROperator

    'same
    Private clsRepFunc, clsRleFunc, clsAsNumFunc As RFunction
    Private clsDollarOperator, clsSameGreaterOperator As ROperator

    'difference
    Private clsDiffOperator, clsLessDiffOperator As ROperator

    'combined
    Private clsOrRangeJumpOperator, clsOrRangeSameOperator, clsOrRangeDiffOperator, clsOrSameJumpOperator, clsOrSameDiffOperator, clsOrJumpDiffOperator As ROperator

    Private Sub dlgClimaticCheckDataTemperature_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
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

        'Station Receiver
        ucrReceiverStation.Selector = ucrSelectorTemperature
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Station Variables"

        'Date Receiver
        ucrReceiverDate.Selector = ucrSelectorTemperature
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.SetMeAsReceiver()
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        'Year Receiver
        ucrReceiverYear.Selector = ucrSelectorTemperature
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        'Month Receiver
        ucrReceiverMonth.Selector = ucrSelectorTemperature
        ucrReceiverMonth.SetClimaticType("month")
        ucrReceiverMonth.bAutoFill = True
        ucrReceiverMonth.strSelectorHeading = "Month Variables"


        'Day Receiver
        ucrReceiverDay.Selector = ucrSelectorTemperature
        ucrReceiverDay.SetParameter(New RParameter("day", 0))
        ucrReceiverDay.SetParameterIsString()
        ucrReceiverDay.bWithQuotes = False
        ucrReceiverDay.bAutoFill = True
        ucrReceiverDay.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverDay.strSelectorHeading = "Day Variables"

        'Element Receiver
        ucrReceiverElement1.Selector = ucrSelectorTemperature
        ucrReceiverElement1.SetParameter(New RParameter("x", 0, bNewIncludeArgumentName:=False))
        ucrReceiverElement1.SetParameterIsString()
        ucrReceiverElement1.bWithQuotes = False
        'ucrReceiverElement.strSelectorHeading = "Numerics"
        'ucrReceiverElement.SetDataType("numeric")

        ucrReceiverElement2.Selector = ucrSelectorTemperature
        ucrReceiverElement2.SetParameter(New RParameter("x", iNewPosition:=1, bNewIncludeArgumentName:=False))
        ucrReceiverElement2.SetParameterIsString()
        ucrReceiverElement2.bWithQuotes = False

        'Checkboxes for options
        ucrChkRange.SetText("Range")
        ucrChkRange.AddToLinkedControls(ucrNudRangeElement1Min, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrChkRange.AddToLinkedControls(ucrNudRangeElement1Max, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=50)

        ucrChkSame.SetText("Same")
        ucrChkSame.AddToLinkedControls(ucrNudSame, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=4)

        ucrChkJump.SetText("Jump")
        ucrChkJump.AddToLinkedControls(ucrNudJumpElement1, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrChkJump.AddToLinkedControls(ucrNudJumpElement2, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=20)

        ucrChkDifference.SetText("Difference")
        ucrChkDifference.AddToLinkedControls(ucrNudDifference, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)

        ucrChkOutlier.SetText("Outlier")

        'Nuds for the respective options
        'Range Option
        ucrNudRangeElement1Min.SetParameter(New RParameter("from", iNewPosition:=1, bNewIncludeArgumentName:=False))
        ucrNudRangeElement1Min.SetMinMax(-50, 65)
        ucrNudRangeElement1Min.SetLinkedDisplayControl(lblRangeElement1)

        ucrNudRangeElement1Max.SetParameter(New RParameter("to", 1, bNewIncludeArgumentName:=False))
        ucrNudRangeElement1Max.SetMinMax(-50, 65)
        ucrNudRangeElement1Max.SetLinkedDisplayControl(lblRangeElement1to)


        ucrNudRangeElement2Min.SetParameter(New RParameter("from", 1))
        ucrNudRangeElement2Min.SetMinMax(-50, 50)

        ucrNudRangeElement2Max.SetParameter(New RParameter("from", 1))
        ucrNudRangeElement2Max.SetMinMax(-50, 50)

        'Same Option
        ucrNudSame.SetParameter(New RParameter("n", 1, bNewIncludeArgumentName:=False))
        ucrNudSame.SetMinMax(2, 366)


        'Jump Option
        ucrNudJumpElement1.SetParameter(New RParameter("from", iNewPosition:=1, bNewIncludeArgumentName:=False))
        ucrNudJumpElement1.SetMinMax(1, 25)
        ucrNudJumpElement1.SetLinkedDisplayControl(lblJumpElement1)

        ucrNudJumpElement2.SetParameter(New RParameter("from", 1))
        ucrNudJumpElement2.SetMinMax(1, 25)
        ucrNudJumpElement2.SetLinkedDisplayControl(lblJumpElement2)

        'Difference Option
        ucrNudDifference.SetParameter(New RParameter("n", iNewPosition:=1, bNewIncludeArgumentName:=False))
        ucrNudDifference.SetMinMax(-5, 5)

        'Outlier Option
        'More deliberations required for this Nud.

    End Sub

    Private Sub SetDefaults()
        Dim strLengths As String = "lengths"

        clsGroupByFunc = New RFunction
        clsListFunc = New RFunction
        clsFilterFunc = New RFunction
        clsRunCalcFunc = New RFunction
        clsLessOperator = New ROperator
        clsGreaterOperator = New ROperator
        clsAndOpertor = New ROperator
        clsConcFunc = New RFunction
        clsDiffFunc = New RFunction
        clsAbsFunc = New RFunction
        clsJumpGreaterOperator = New ROperator
        clsDiffOperator = New ROperator
        clsLessDiffOperator = New ROperator
        clsRepFunc = New RFunction
        clsRleFunc = New RFunction
        clsAsNumFunc = New RFunction
        clsSameGreaterOperator = New ROperator
        clsDollarOperator = New ROperator

        clsOrRangeJumpOperator = New ROperator
        clsOrRangeSameOperator = New ROperator
        clsOrRangeDiffOperator = New ROperator
        clsOrSameJumpOperator = New ROperator
        clsOrSameDiffOperator = New ROperator
        clsOrJumpDiffOperator = New ROperator

        ucrSelectorTemperature.Reset()

        clsSameGreaterOperator.bToScriptAsRString = True
        clsSameGreaterOperator.SetOperation(">")
        clsSameGreaterOperator.AddParameter("left", bIncludeArgumentName:=False, clsRFunctionParameter:=clsRepFunc, iPosition:=0)

        clsRepFunc.SetRCommand("rep")
        clsRepFunc.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsDollarOperator, iPosition:=0)
        clsRepFunc.AddParameter("right", bIncludeArgumentName:=False, clsROperatorParameter:=clsDollarOperator, iPosition:=1)

        clsAsNumFunc.SetRCommand("as.numeric")
        clsRleFunc.SetRCommand("rle")
        clsRleFunc.AddParameter("left", bIncludeArgumentName:=False, clsRFunctionParameter:=clsAsNumFunc, iPosition:=0)

        clsDollarOperator.SetOperation("$")
        clsDollarOperator.AddParameter("left", bIncludeArgumentName:=False, clsRFunctionParameter:=clsRleFunc, iPosition:=0)
        clsDollarOperator.AddParameter("right", strParameterValue:=strLengths, bIncludeArgumentName:=False, iPosition:=1)
        'difference
        clsLessDiffOperator.SetOperation("<")
        clsLessDiffOperator.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsDiffOperator, iPosition:=0)

        clsLessDiffOperator.bToScriptAsRString = True
        clsDiffOperator.SetOperation("-")

        'jump functions
        clsConcFunc.SetRCommand("c")
        clsConcFunc.AddParameter("left", "NA", bIncludeArgumentName:=False, iPosition:=0)
        clsConcFunc.AddParameter("right", bIncludeArgumentName:=False, clsRFunctionParameter:=clsDiffFunc, iPosition:=1)

        clsAbsFunc.SetRCommand("abs")
        clsAbsFunc.AddParameter("diff", bIncludeArgumentName:=False, clsRFunctionParameter:=clsConcFunc, iPosition:=0)

        clsDiffFunc.SetRCommand("diff")

        clsJumpGreaterOperator.bToScriptAsRString = True
        clsJumpGreaterOperator.SetOperation(">")
        clsJumpGreaterOperator.AddParameter("left", bIncludeArgumentName:=False, clsRFunctionParameter:=clsAbsFunc, iPosition:=0)

        clsAndOpertor.bToScriptAsRString = True
        clsLessOperator.SetOperation("<")
        clsGreaterOperator.SetOperation(">")
        clsGreaterOperator.AddParameter("from", "0", bIncludeArgumentName:=False, iPosition:=1)
        clsAndOpertor.SetOperation("&")
        clsAndOpertor.bBrackets = False
        clsAndOpertor.AddParameter("left", clsROperatorParameter:=clsGreaterOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsAndOpertor.AddParameter("right", clsROperatorParameter:=clsLessOperator, iPosition:=1, bIncludeArgumentName:=False)
        clsListFunc.SetRCommand("list")

        clsListFunc.AddParameter("list", bIncludeArgumentName:=False, clsRFunctionParameter:=clsGroupByFunc, iPosition:=0)
        clsGroupByFunc.SetRCommand("instat_calculation$new")
        clsGroupByFunc.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        'clsGroupByFunc.AddParameter("calculated_from", clsRFunctionParameter:=clsListFunc, iPosition:=1)
        clsGroupByFunc.SetAssignTo("grouping")

        clsFilterFunc.SetRCommand("instat_calculation$new")
        clsFilterFunc.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsFilterFunc.AddParameter("save", "2", iPosition:=4)
        clsFilterFunc.AddParameter("result_data_frame", Chr(34) & "temp1" & Chr(34), iPosition:=5)
        clsFilterFunc.AddParameter("manipulations", clsRFunctionParameter:=clsListFunc, iPosition:=3)
        clsFilterFunc.SetAssignTo("temp_filter")


        'combined
        clsOrRangeJumpOperator.SetOperation("|")
        clsOrRangeJumpOperator.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsAndOpertor, iPosition:=0)
        clsOrRangeJumpOperator.AddParameter("right", bIncludeArgumentName:=False, clsROperatorParameter:=clsJumpGreaterOperator, iPosition:=1)

        clsOrRangeSameOperator.SetOperation("|")
        clsOrRangeSameOperator.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsAndOpertor, iPosition:=0)
        clsOrRangeSameOperator.AddParameter("right", bIncludeArgumentName:=False, clsROperatorParameter:=clsSameGreaterOperator, iPosition:=1)

        clsOrRangeDiffOperator.SetOperation("|")
        clsOrRangeDiffOperator.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsAndOpertor, iPosition:=0)
        clsOrRangeDiffOperator.AddParameter("right", bIncludeArgumentName:=False, clsROperatorParameter:=clsLessDiffOperator, iPosition:=1)

        clsOrSameJumpOperator.SetOperation("|")
        clsOrSameJumpOperator.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsSameGreaterOperator, iPosition:=0)
        clsOrSameJumpOperator.AddParameter("right", bIncludeArgumentName:=False, clsROperatorParameter:=clsJumpGreaterOperator, iPosition:=1)

        clsOrSameDiffOperator.SetOperation("|")
        clsOrSameDiffOperator.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsSameGreaterOperator, iPosition:=0)
        clsOrSameDiffOperator.AddParameter("right", bIncludeArgumentName:=False, clsROperatorParameter:=clsLessDiffOperator, iPosition:=1)

        clsOrJumpDiffOperator.SetOperation("|")
        clsOrJumpDiffOperator.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsJumpGreaterOperator, iPosition:=0)
        clsOrJumpDiffOperator.AddParameter("right", bIncludeArgumentName:=False, clsROperatorParameter:=clsLessDiffOperator, iPosition:=1)


        clsRunCalcFunc.SetRCommand("InstatDataObject$run_instat_calculation")
        clsRunCalcFunc.AddParameter("calc", clsRFunctionParameter:=clsFilterFunc, iPosition:=0)
        clsRunCalcFunc.AddParameter("display", "FALSE")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRunCalcFunc)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        ucrReceiverElement1.AddAdditionalCodeParameterPair(clsLessOperator, New RParameter("left", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverElement1.AddAdditionalCodeParameterPair(clsDiffFunc, New RParameter("left", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverElement1.AddAdditionalCodeParameterPair(clsDiffOperator, New RParameter("left", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)
        ucrReceiverElement1.AddAdditionalCodeParameterPair(clsAsNumFunc, New RParameter("x", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=4)
        ucrReceiverElement1.SetRCode(clsGreaterOperator, bReset)
        ucrNudRangeElement1Min.SetRCode(clsGreaterOperator, bReset)
        ucrNudRangeElement1Max.SetRCode(clsLessOperator, bReset)
        ucrNudJumpElement1.SetRCode(clsJumpGreaterOperator, bReset)
        ucrReceiverElement2.SetRCode(clsDiffOperator, bReset)
        ucrNudDifference.SetRCode(clsLessDiffOperator, bReset)
        ucrNudSame.SetRCode(clsSameGreaterOperator, bReset)
    End Sub
    Private Sub TestOkEnabled()
        'If Not ucrReceiverStation.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverMonth.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty() AndAlso Not ucrReceiverDay.IsEmpty() AndAlso Not ucrReceiverElement.IsEmpty() AndAlso ucrNudJumpElement1Max.GetText <> "" AndAlso ucrNudJumpElement1Min.GetText <> "" AndAlso ucrNudJumpElement2Max.GetText <> "" AndAlso ucrNudJumpElement2Min.GetText <> "" AndAlso ucrNudSame.GetText <> "" AndAlso ucrNudJumpElement1Max.GetText <> "" AndAlso ucrNudJumpElement1Min.GetText <> "" AndAlso ucrNudJumpElement2Max.GetText <> "" AndAlso ucrNudJumpElement2Min.GetText <> "" AndAlso ucrNudDifference.GetText <> "" AndAlso ucrNudOutlier.GetText <> "" Then
        '    ucrBase.OKEnabled(True)
        'Else
        '    ucrBase.OKEnabled(False)
        'End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ListOptions()
        If Not ucrReceiverStation.IsEmpty Then
            clsGroupByFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverStation.GetVariableNames & ")", iPosition:=1)
        End If
    End Sub

    Private Sub FilterFunc()
        clsFilterFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & ")", iPosition:=2)
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverMonth.ControlContentsChanged, ucrReceiverDay.ControlContentsChanged, ucrReceiverElement1.ControlContentsChanged, ucrNudSame.ControlContentsChanged, ucrNudRangeElement1Min.ControlContentsChanged, ucrNudRangeElement1Max.ControlContentsChanged, ucrNudRangeElement2Min.ControlContentsChanged, ucrNudRangeElement2Max.ControlContentsChanged, ucrNudJumpElement1.ControlContentsChanged, ucrNudRangeElement2Min.ControlContentsChanged, ucrNudRangeElement2Max.ControlContentsChanged, ucrNudDifference.ControlContentsChanged, ucrNudOutlier.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSelectorTemperature_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTemperature.ControlValueChanged
        strCurrDataFrame = Chr(34) & ucrSelectorTemperature.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        ListOptions()
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        ListOptions()
    End Sub

    Private Sub ucrReceiverElement_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement1.ControlValueChanged
        FilterFunc()
    End Sub

    Private Sub ucrChkRange_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRange.ControlValueChanged, ucrChkJump.ControlValueChanged, ucrChkDifference.ControlValueChanged, ucrChkSame.ControlValueChanged
        If ucrChkRange.Checked AndAlso Not ucrChkJump.Checked AndAlso Not ucrChkDifference.Checked AndAlso Not ucrChkSame.Checked Then
            clsAndOpertor.bToScriptAsRString = True
            clsFilterFunc.AddParameter("function_exp", clsROperatorParameter:=clsAndOpertor, iPosition:=1)
        ElseIf ucrChkJump.Checked AndAlso Not ucrChkRange.Checked AndAlso Not ucrChkDifference.Checked AndAlso Not ucrChkSame.Checked Then
            clsJumpGreaterOperator.bToScriptAsRString = True
            clsFilterFunc.AddParameter("function_exp", clsROperatorParameter:=clsJumpGreaterOperator, iPosition:=1)
        ElseIf ucrChkDifference.Checked AndAlso Not ucrChkJump.Checked AndAlso Not ucrChkRange.Checked AndAlso Not ucrChkSame.Checked Then
            clsLessDiffOperator.bToScriptAsRString = True
            clsFilterFunc.AddParameter("function_exp", clsROperatorParameter:=clsLessDiffOperator, iPosition:=1)
        ElseIf ucrChkSame.Checked AndAlso Not ucrChkJump.Checked AndAlso Not ucrChkDifference.Checked AndAlso Not ucrChkRange.Checked Then
            clsSameGreaterOperator.bToScriptAsRString = True
            clsFilterFunc.AddParameter("function_exp", clsROperatorParameter:=clsSameGreaterOperator, iPosition:=1)
        ElseIf ucrChkRange.Checked AndAlso ucrChkJump.Checked Then
            clsAndOpertor.bToScriptAsRString = False
            clsJumpGreaterOperator.bToScriptAsRString = False
            clsOrRangeJumpOperator.bToScriptAsRString = True
            clsFilterFunc.AddParameter("function_exp", clsROperatorParameter:=clsOrRangeJumpOperator, iPosition:=1)
        ElseIf ucrChkRange.Checked AndAlso ucrChkSame.Checked Then
            clsAndOpertor.bToScriptAsRString = False
            clsSameGreaterOperator.bToScriptAsRString = False
            clsOrRangeSameOperator.bToScriptAsRString = True
            clsFilterFunc.AddParameter("function_exp", clsROperatorParameter:=clsOrRangeSameOperator, iPosition:=1)
        ElseIf ucrChkRange.Checked AndAlso ucrChkDifference.Checked Then
            clsAndOpertor.bToScriptAsRString = False
            clsLessDiffOperator.bToScriptAsRString = False
            clsOrRangeDiffOperator.bToScriptAsRString = True
            clsFilterFunc.AddParameter("function_exp", clsROperatorParameter:=clsOrRangeDiffOperator, iPosition:=1)
        ElseIf ucrChkSame.Checked AndAlso ucrChkJump.Checked Then
            clsSameGreaterOperator.bToScriptAsRString = False
            clsJumpGreaterOperator.bToScriptAsRString = False
            clsOrSameJumpOperator.bToScriptAsRString = True
            clsFilterFunc.AddParameter("function_exp", clsROperatorParameter:=clsOrSameJumpOperator, iPosition:=1)
        ElseIf ucrChkSame.Checked AndAlso ucrChkDifference.Checked Then
            clsSameGreaterOperator.bToScriptAsRString = False
            clsLessDiffOperator.bToScriptAsRString = False
            clsOrSameDiffOperator.bToScriptAsRString = True
            clsFilterFunc.AddParameter("function_exp", clsROperatorParameter:=clsOrSameDiffOperator, iPosition:=1)
        ElseIf ucrChkJump.Checked AndAlso ucrChkDifference.Checked Then
            clsJumpGreaterOperator.bToScriptAsRString = False
            clsLessDiffOperator.bToScriptAsRString = False
            clsOrJumpDiffOperator.bToScriptAsRString = True
            clsFilterFunc.AddParameter("function_exp", clsROperatorParameter:=clsOrJumpDiffOperator, iPosition:=1)
        End If

    End Sub
End Class