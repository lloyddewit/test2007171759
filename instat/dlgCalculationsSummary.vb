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

Public Class dlgCalculationsSummary
    Public bFirstLoad As Boolean = True
    Public bResetSubdialog As Boolean = True
    Private dctCalculations As New Dictionary(Of String, RFunction)
    Private iCalcCount As Integer = 0

    Private Sub dlgCalculationsSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()
        SetEnabledStatusButtons()
    End Sub

    Private Sub TestOKEnabled()
        If lstCalculations.Items.Count > 0 Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        lstCalculations.Items.Clear()
        dctCalculations.Clear()
        ucrBase.clsRsyntax.ClearCodes()
        iCalcCount = 0
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 513
        cmdEdit.Enabled = False
        cmdDuplicate.Enabled = False
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim clsNewCalculationFunction As New RFunction
        Dim strCalcName As String
        Dim clsApplyCalculation = New RFunction

        iCalcCount = iCalcCount + 1
        strCalcName = "calc" & iCalcCount

        clsApplyCalculation.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsApplyCalculation.AddParameter("calc", clsRFunctionParameter:=clsNewCalculationFunction)

        clsNewCalculationFunction.SetRCommand("instat_calculation$new")
        clsNewCalculationFunction.AddParameter("name", Chr(34) & strCalcName & Chr(34))
        clsNewCalculationFunction.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsNewCalculationFunction.AddParameter("save", "2")

        dctCalculations.Add(strCalcName, clsNewCalculationFunction)
        sdgCalculationsSummmary.Setup(clsNewCalculationFunction:=clsNewCalculationFunction, clsNewParentCalculationFunction:=Nothing, bNewIsSubCalc:=False, bNewIsManipulation:=False, bReset:=True)
        sdgCalculationsSummmary.ShowDialog()
        If clsNewCalculationFunction.ContainsParameter("name") Then
            strCalcName = clsNewCalculationFunction.GetParameter("name").strArgumentValue.Trim(Chr(34))
        End If
        clsNewCalculationFunction.SetAssignTo(strCalcName)

        lstCalculations.Items.Add(strCalcName)

        If clsNewCalculationFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "save") <> -1 AndAlso clsNewCalculationFunction.GetParameter("save").strArgumentValue = "2" Then
            clsApplyCalculation.iCallType = 0
            clsApplyCalculation.AddParameter("display", "FALSE")
        Else
            clsApplyCalculation.iCallType = 2
            clsApplyCalculation.AddParameter("display", "TRUE")
        End If

        ucrBase.clsRsyntax.AddToBeforeCodes(clsApplyCalculation.Clone(), iPosition:=iCalcCount)
        TestOKEnabled()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim iIndex As Integer

        For Each lviTemp As ListViewItem In lstCalculations.SelectedItems
            iIndex = lstCalculations.Items.IndexOf(lviTemp)
            lstCalculations.Items.Remove(lviTemp)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(RSyntaxCodeContaining(dctCalculations(lviTemp.Text)))
            dctCalculations.Remove(lviTemp.Text)
        Next
    End Sub

    Private Function RSyntaxCodeContaining(clsCalcFunction As RFunction) As RFunction
        For Each clsApplyFunc As RFunction In ucrBase.clsRsyntax.lstBeforeCodes
            'TODO better way to check this
            If clsApplyFunc.ContainsParameter("calc") AndAlso clsApplyFunc.GetParameter("calc").clsArgumentCodeStructure IsNot Nothing AndAlso clsApplyFunc.GetParameter("calc").clsArgumentCodeStructure.strAssignTo = clsCalcFunction.strAssignTo Then
                Return clsApplyFunc
            End If
        Next
        Return Nothing
    End Function

    Private Sub lstLayers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCalculations.SelectedIndexChanged
        SetEnabledStatusButtons()
    End Sub

    Private Sub SetEnabledStatusButtons()
        If lstCalculations.SelectedItems.Count > 0 Then
            cmdDelete.Enabled = True
        Else
            cmdDelete.Enabled = False
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub
End Class