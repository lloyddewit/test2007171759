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
Public Class dlgCalculationsSummary
    Public bFirstLoad As Boolean = True
    Private lstCalculations As New List(Of KeyValuePair(Of String, RFunction))
    Private clsApplyCalculation As New RFunction

    Private Sub dlgCalculationsSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        'Checks if Ok can be enabled.
        TestOKEnabled()
        SetEnabledStatusButtons()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If lstLayers.Items.Count > 0 Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
    End Sub

    Private Sub InitialiseDialog()
        cmdEdit.Enabled = False
        cmdDuplicate.Enabled = False
        clsApplyCalculation.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        'TODO Shoudl be option on the dialog/sub dialog
        clsApplyCalculation.AddParameter("display", "TRUE")
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim clsCalcFunction As New RFunction

        clsCalcFunction.SetRCommand("instat_calculation$new")
        sdgCalculationsSummmary.SetCalculationFunction(clsCalcFunction)
        sdgCalculationsSummmary.ShowDialog()
        If clsCalcFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "name") <> -1 Then
            lstLayers.Items.Add(clsCalcFunction.clsParameters.Find(Function(x) x.strArgumentName = "name").strArgumentValue)
        Else
            lstLayers.Items.Add("calc" & lstLayers.Items.Count + 1)
        End If
        lstCalculations.Add(New KeyValuePair(Of String, RFunction)(lstLayers.Items(lstLayers.Items.Count - 1).Text, clsCalcFunction.Clone()))
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        Dim strScript As String
        Dim strComment As String = ""
        Dim strTemp As String = ""

        For i = 0 To lstCalculations.Count - 1
            strScript = ""
            If i = 0 Then
                strComment = ucrBase.strComment
            Else
                strComment = ""
            End If
            clsApplyCalculation.AddParameter("calc", clsRFunctionParameter:=lstCalculations(i).Value.Clone())
            strTemp = clsApplyCalculation.ToScript(strScript)
            frmMain.clsRLink.RunScript(strScript & strTemp, iCallType:=2)
        Next
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        For Each iTemp As Integer In lstLayers.SelectedIndices
            lstLayers.Items.RemoveAt(iTemp)
            lstCalculations.RemoveAt(iTemp)
        Next
    End Sub

    Private Sub lstLayers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLayers.SelectedIndexChanged
        SetEnabledStatusButtons()
    End Sub

    Private Sub SetEnabledStatusButtons()
        If lstLayers.SelectedItems.Count > 0 Then
            cmdDelete.Enabled = True
        Else
            cmdDelete.Enabled = False
        End If
    End Sub
End Class