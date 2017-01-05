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
Public Class sdgCalculationsSummmary
    Public bFirstLoad As Boolean = True
    Private clsCalculationFunction As New RFunction
    Dim lstType As New List(Of KeyValuePair(Of String, String))
    Private lstSubCalcFunctions As New List(Of KeyValuePair(Of String, RFunction))
    Private lstManipulationFunctions As New List(Of KeyValuePair(Of String, RFunction))
    Dim clsSubCalcsList As New RFunction
    Dim clsManipulationsList As New RFunction
    Dim iSubCalcCount As Integer = 1
    Dim iManipCount As Integer = 1

    Private Sub sdgCalculationsSummmary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            'temporary solution to subdialog linking issues
            SetDefaults()
        End If
    End Sub

    Private Sub InitialiseDialog()
        ' Set Items in ucrType

        ucrType.SetItems({"calculation", "summary", "by", "filter"}) ' and combine
        ucrReceiverBy.Selector = ucrSelectorBy
        ucrReceiverBy.SetMeAsReceiver()
        ucrReceiverBy.SetDataType("factor")

        ' This is the new way of using this control. Not needed yet
        'lstType.Add(New KeyValuePair(Of String, String)("Calculation", Chr(34) & "calculation" & Chr(34)))
        'lstType.Add(New KeyValuePair(Of String, String)("Summary", Chr(34) & "summary" & Chr(34)))
        'lstType.Add(New KeyValuePair(Of String, String)("By", Chr(34) & "by" & Chr(34)))
        'lstType.Add(New KeyValuePair(Of String, String)("Filter", Chr(34) & "filter" & Chr(34)))
        'lstType.Add(New KeyValuePair(Of String, String)("Combine", Chr(34) & "combination" & Chr(34)))
        'ucrType.SetItems(lstType)
        'ucrType.SetParameterName("type")

        ucrCalcSummary.ucrReceiverForCalculation.SetMeAsReceiver()
        ucrCalcSummary.chkSaveResultInto.Visible = False
        ucrCalcSummary.ucrSaveResultInto.Visible = False
        ucrResultName.SetValidationTypeAsRVariable()
        ucrCalculationName.SetValidationTypeAsRVariable()

        clsSubCalcsList.SetRCommand("list")
        clsManipulationsList.SetRCommand("list")
    End Sub

    Private Sub SetDefaults()
        ucrSelectorBy.Reset()
        ucrSelectorBy.Focus()

        ucrType.SetName("calculation")
        SetType()

        rdoDoNotSave.Checked = True
        SetSaveOption()

        ucrCalcSummary.ucrSelectorForCalculations.Reset()
        ucrCalculationName.SetName("")
        ucrResultName.SetName("")

        'temp until working
        cmdManipEdit.Enabled = False
        cmdSubCalcEdit.Enabled = False

    End Sub

    Public Sub SetCalculationFunction(clsNewCalcFunction As RFunction)
        clsCalculationFunction = clsNewCalcFunction
    End Sub

    Private Sub DisplayOptions()
        If ucrType.GetText = "calculation" OrElse ucrType.GetText = "summary" Then
            ucrSelectorBy.Visible = False
            ucrReceiverBy.Visible = False
            lblFactors.Visible = False
            ucrCalcSummary.Visible = True
            If ucrType.GetText = "calculation" Then
                ucrCalcSummary.ucrInputCalOptions.SetName("Basic")
            Else
                ucrCalcSummary.ucrInputCalOptions.SetName("Statistics")
            End If
            ucrDefineFilter.Visible = False
            rdoSaveCalcAndResult.Enabled = True
        ElseIf ucrType.GetText = "by" Then
            ucrSelectorBy.Visible = True
            ucrReceiverBy.Visible = True
            lblFactors.Visible = True
            ucrCalcSummary.Visible = False
            clsCalculationFunction.RemoveParameterByName("function_exp")
            ucrDefineFilter.Visible = False
            If rdoSaveCalcAndResult.Checked Then
                rdoSaveCalculation.Checked = True
            End If
            rdoSaveCalcAndResult.Enabled = False
        ElseIf ucrType.GetText = "filter" Then
            ucrSelectorBy.Visible = False
            ucrReceiverBy.Visible = False
            lblFactors.Visible = False
            ucrCalcSummary.Visible = False
            ucrDefineFilter.Visible = True
            If rdoSaveCalcAndResult.Checked Then
                rdoSaveCalculation.Checked = True
            End If
            rdoSaveCalcAndResult.Enabled = False
        Else
            ' combine options
        End If
    End Sub

    Private Sub rdoSaveOptions_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDoNotSave.CheckedChanged, rdoSaveCalculation.CheckedChanged, rdoSaveCalcAndResult.CheckedChanged
        If rdoSaveCalculation.Checked Then
            clsCalculationFunction.AddParameter("save", "1")
        ElseIf rdoSaveCalcAndResult.Checked Then
            clsCalculationFunction.AddParameter("save", "2")
        Else
            clsCalculationFunction.AddParameter("save", "0")
        End If
    End Sub

    Private Sub SetSaveOption()
        If rdoSaveCalculation.Checked Then
            clsCalculationFunction.AddParameter("save", "1")
        ElseIf rdoSaveCalcAndResult.Checked Then
            clsCalculationFunction.AddParameter("save", "2")
        Else
            clsCalculationFunction.AddParameter("save", "0")
        End If
    End Sub

    ' Looking at Manipulations Tab
    Private Sub cmdManipAdd_Click(sender As Object, e As EventArgs) Handles cmdManipAdd.Click

    End Sub
    ' We want to have that this opens a dialog which only shows filter and by as options in type

    ' Sub Calculations Tab
    ' We want to have that this opens a dialog which only shows calculations and summary (and combine) as options in type
    Private Sub cmdSubCalcAdd_Click(sender As Object, e As EventArgs) Handles cmdSubCalcAdd.Click
        Dim clsSubCalcFunction As New RFunction
        Dim sdgSubCalc As New sdgCalculationsSummmary

        clsSubCalcFunction.SetRCommand("instat_calculation$new")
        sdgSubCalc.SetCalculationFunction(clsSubCalcFunction)
        sdgSubCalc.ShowDialog()
        If clsSubCalcFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "name") <> -1 Then
            lstSubCalcs.Items.Add(clsSubCalcFunction.clsParameters.Find(Function(x) x.strArgumentName = "name").strArgumentValue)
        Else
            lstSubCalcs.Items.Add("sub_calc" & iSubCalcCount)
            iSubCalcCount = iSubCalcCount + 1
        End If
        lstSubCalcFunctions.Add(New KeyValuePair(Of String, RFunction)(lstSubCalcs.Items(lstSubCalcs.Items.Count - 1).Text, clsSubCalcFunction.Clone()))
    End Sub

    Private Sub ucrType_NameChanged() Handles ucrType.NameChanged
        SetType()
    End Sub

    Private Sub SetType()
        DisplayOptions()
        If ucrType.IsEmpty Then
            clsCalculationFunction.RemoveParameterByName("type")
        Else
            clsCalculationFunction.AddParameter("type", Chr(34) & ucrType.GetText() & Chr(34))
        End If
    End Sub

    Private Sub ucrCalcSummary_SelectionChanged() Handles ucrCalcSummary.SelectionChanged
        If {"calculation", "summary"}.Contains(ucrType.GetText()) Then
            If Not ucrCalcSummary.ucrReceiverForCalculation.IsEmpty Then
                clsCalculationFunction.AddParameter("function_exp", Chr(34) & ucrCalcSummary.ucrReceiverForCalculation.GetText() & Chr(34))
            Else
                clsCalculationFunction.RemoveParameterByName("function_exp")
            End If

            If ucrCalcSummary.ucrSelectorForCalculations.lstVariablesInReceivers.Count > 0 Then
                clsCalculationFunction.AddParameter("calculated_from", CreateCalcFromList(ucrCalcSummary.ucrSelectorForCalculations.lstVariablesInReceivers, ucrCalcSummary.ucrSelectorForCalculations))
            Else
                clsCalculationFunction.RemoveParameterByName("calculated_from")
            End If
        End If
    End Sub

    Private Sub ucrCalculationName_NameChanged() Handles ucrCalculationName.NameChanged
        If ucrCalculationName.IsEmpty Then
            clsCalculationFunction.RemoveParameterByName("name")
            clsCalculationFunction.RemoveAssignTo()
        Else
            clsCalculationFunction.AddParameter("name", Chr(34) & ucrCalculationName.GetText() & Chr(34))
            clsCalculationFunction.SetAssignTo(ucrCalculationName.GetText())
        End If
    End Sub

    Private Sub ucrColumnName_NameChanged() Handles ucrResultName.NameChanged
        If ucrResultName.IsEmpty Then
            clsCalculationFunction.RemoveParameterByName("result_name")
        Else
            clsCalculationFunction.AddParameter("result_name", Chr(34) & ucrResultName.GetText() & Chr(34))
        End If
    End Sub

    Private Sub ucrReceiverBy_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverBy.SelectionChanged
        If ucrType.GetText() = "by" Then
            If ucrReceiverBy.IsEmpty Then
                clsCalculationFunction.RemoveParameterByName("calculated_from")
            Else
                clsCalculationFunction.AddParameter("calculated_from", CreateCalcFromList(ucrReceiverBy.GetVariableNamesAsList(), ucrSelectorBy))
            End If
        End If
    End Sub

    'Need to do this instead of with RFunctions because the calculated_from list can have multiple items with the same label
    Private Function CreateCalcFromList(lstVariables As List(Of String), ucrCurrentSelector As ucrSelectorByDataFrame) As String
        Dim strCalcFromList As String
        Dim strColumn As String

        strCalcFromList = "list("
        For i = 0 To lstVariables.Count - 1
            strColumn = lstVariables(i)
            If i > 0 Then
                strCalcFromList = strCalcFromList & ","
            End If
            strCalcFromList = strCalcFromList & ucrCurrentSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text & " = " & Chr(34) & strColumn & Chr(34)
        Next
        strCalcFromList = strCalcFromList & ")"
        Return strCalcFromList
    End Function

    Private Sub ucrDefineFilter_FilterChanged() Handles ucrDefineFilter.FilterChanged
        If ucrType.GetText() = "filter" Then
            If ucrDefineFilter.ucrFilterPreview.IsEmpty Then
                clsCalculationFunction.RemoveParameterByName("function_exp")
                clsCalculationFunction.RemoveParameterByName("calculated_from")
            Else
                clsCalculationFunction.AddParameter("function_exp", Chr(34) & ucrDefineFilter.ucrFilterPreview.GetText() & Chr(34))
                clsCalculationFunction.AddParameter("calculated_from", CreateCalcFromList(ucrDefineFilter.GetFilteredVariables(False), ucrDefineFilter.ucrSelectorForFitler))
            End If
        End If
    End Sub

    Private Sub UpdateSubCalcs()
        clsSubCalcsList.ClearParameters()
        For i As Integer = 0 To lstSubCalcFunctions.Count - 1
            clsSubCalcsList.AddParameter(i, clsRFunctionParameter:=lstSubCalcFunctions(i).Value.Clone(), bIncludeArgumentName:=False)
        Next
        If lstSubCalcFunctions.Count > 0 Then
            clsCalculationFunction.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubCalcsList)
        Else
            clsCalculationFunction.RemoveParameterByName("sub_calculations")
        End If
    End Sub

    Private Sub UpdateManipulations()
        clsManipulationsList.ClearParameters()
        For i As Integer = 0 To lstManipulationFunctions.Count - 1
            clsManipulationsList.AddParameter(i, clsRFunctionParameter:=lstManipulationFunctions(i).Value.Clone(), bIncludeArgumentName:=False)
        Next

        If lstManipulationFunctions.Count > 0 Then
            clsCalculationFunction.AddParameter("manipulations", clsRFunctionParameter:=clsManipulationsList)
        Else
            clsCalculationFunction.RemoveParameterByName("manipulations")
        End If
    End Sub
End Class