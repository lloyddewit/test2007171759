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

Public Class sdgWindrose
    Public bControlsInitialised As Boolean = False
    Public clsWindRoseFunc As New RFunction
    Private Sub sdgWindrose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim dctThemePairs As New Dictionary(Of String, String)
        Dim dctSequatailPairs As New Dictionary(Of String, String)
        Dim dctDivergingPairs As New Dictionary(Of String, String)
        Dim dctQualititivePairs As New Dictionary(Of String, String)


        ucrPnlColourPalette.AddRadioButton(rdoDiverging)
        ucrPnlColourPalette.AddRadioButton(rdoSequential)
        ucrPnlColourPalette.AddRadioButton(rdoQualitative)
        ucrPnlColourPalette.SetParameter(New RParameter("col_pal"))


        ucrNudNoOfDirections.SetParameter(New RParameter("n_directions", 3))
        ucrNudNoOfDirections.SetRDefault(12)

        ucrNudNoOfSpeeds.SetParameter(New RParameter("n_speeds", 4))
        ucrNudNoOfSpeeds.SetRDefault(5)

        ucrInputSpeedCuts.SetParameter(New RParameter("speed_cuts", 5))
        ucrInputSpeedCuts.SetRDefault("NA")

        ucrNudCalmWind.SetParameter(New RParameter("calm_wind", 9))
        ucrNudCalmWind.SetRDefault(0)

        ucrInputTheme.SetParameter(New RParameter("ggtheme", 7))
        dctThemePairs.Add("grey", Chr(34) & "grey" & Chr(34))
        dctThemePairs.Add("gray", Chr(34) & "gray" & Chr(34))
        dctThemePairs.Add("bw", Chr(34) & "bw" & Chr(34))
        dctThemePairs.Add("linedraw", Chr(34) & "linedraw" & Chr(34))
        dctThemePairs.Add("light", Chr(34) & "light" & Chr(34))
        dctThemePairs.Add("minimal", Chr(34) & "minimal" & Chr(34))
        dctThemePairs.Add("classic", Chr(34) & "classic" & Chr(34))
        ucrInputTheme.SetItems(dctThemePairs)
        ucrInputTheme.SetDropDownStyleAsNonEditable()
        ucrInputSpeedCuts.AddToLinkedControls(ucrNudNoOfSpeeds, {"NA"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)

        ucrInputSequential.SetParameter(New RParameter("col_pal"))
        ucrInputSequential.bAllowNonConditionValues = True
        dctSequatailPairs.Add("Blues", Chr(34) & "Blues" & Chr(34))
        dctSequatailPairs.Add("Greens", Chr(34) & "Greens" & Chr(34))
        dctSequatailPairs.Add("Greys", Chr(34) & "Greys" & Chr(34))
        dctSequatailPairs.Add("Oranges", Chr(34) & "Oranges" & Chr(34))
        dctSequatailPairs.Add("Purples", Chr(34) & "Purples" & Chr(34))
        dctSequatailPairs.Add("Reds", Chr(34) & "Reds" & Chr(34))
        dctSequatailPairs.Add("BuGn", Chr(34) & "BuGn" & Chr(34))
        dctSequatailPairs.Add("BuPu", Chr(34) & "BuPu" & Chr(34))
        dctSequatailPairs.Add("GnBu", Chr(34) & "GnBu" & Chr(34))
        dctSequatailPairs.Add("OrRd", Chr(34) & "OrRd" & Chr(34))
        dctSequatailPairs.Add("PuBu", Chr(34) & "PuBu" & Chr(34))
        dctSequatailPairs.Add("PuBuGn", Chr(34) & "PuBuGn" & Chr(34))
        dctSequatailPairs.Add("PuRd", Chr(34) & "PuRd" & Chr(34))
        dctSequatailPairs.Add("RdPu", Chr(34) & "RdPu" & Chr(34))
        dctSequatailPairs.Add("YlGn", Chr(34) & "YlGn" & Chr(34))
        dctSequatailPairs.Add("YlGnBu", Chr(34) & "YlGnBu" & Chr(34))
        dctSequatailPairs.Add("YlOrBr", Chr(34) & "YlOrBr" & Chr(34))
        dctSequatailPairs.Add("YlOrRd", Chr(34) & "YlOrRd" & Chr(34))
        ucrInputSequential.SetItems(dctSequatailPairs)
        ucrInputSequential.SetDropDownStyleAsNonEditable()

        ucrInputDiverging.SetParameter(New RParameter("col_pal"))
        ucrInputDiverging.bAllowNonConditionValues = True
        dctDivergingPairs.Add("Spectral", Chr(34) & "Spectral" & Chr(34))
        dctDivergingPairs.Add("BrBG", Chr(34) & "BrBG" & Chr(34))
        dctDivergingPairs.Add("PiYG", Chr(34) & "PiYG" & Chr(34))
        dctDivergingPairs.Add("PRGn", Chr(34) & "PRGn" & Chr(34))
        dctDivergingPairs.Add("PuOr", Chr(34) & "PuOr" & Chr(34))
        dctDivergingPairs.Add("RdBu", Chr(34) & "RdBu" & Chr(34))
        dctDivergingPairs.Add("RdGy", Chr(34) & "RdGy" & Chr(34))
        dctDivergingPairs.Add("RdYlBu", Chr(34) & "RdYlBu" & Chr(34))
        dctDivergingPairs.Add("RdYlGn", Chr(34) & "RdYlGn" & Chr(34))
        ucrInputDiverging.SetItems(dctDivergingPairs)
        ucrInputDiverging.SetDropDownStyleAsNonEditable()

        ucrInputQualitative.SetParameter(New RParameter("col_pal"))
        ucrInputQualitative.bAllowNonConditionValues = True
        dctQualititivePairs.Add("Accent", Chr(34) & "Accent" & Chr(34))
        dctQualititivePairs.Add("Dark2", Chr(34) & "Dark2" & Chr(34))
        dctQualititivePairs.Add("Pastel1", Chr(34) & "Pastel1" & Chr(34))
        dctQualititivePairs.Add("Pastel2", Chr(34) & "Pastel2" & Chr(34))
        dctQualititivePairs.Add("Set1", Chr(34) & "Set1" & Chr(34))
        dctQualititivePairs.Add("Set2", Chr(34) & "Set2" & Chr(34))
        dctQualititivePairs.Add("Set3", Chr(34) & "Set3" & Chr(34))
        ucrInputQualitative.SetItems(dctQualititivePairs)
        ucrInputQualitative.SetDropDownStyleAsNonEditable()

        ucrPnlColourPalette.AddParameterValuesCondition(rdoSequential, "col_pal", dctSequatailPairs.Values.ToArray, True)
        ucrPnlColourPalette.AddParameterValuesCondition(rdoDiverging, "col_pal", dctDivergingPairs.Values.ToArray, True)
        ucrPnlColourPalette.AddParameterValuesCondition(rdoQualitative, "col_pal", dctQualititivePairs.Values.ToArray, True)

        bControlsInitialised = True
    End Sub

    Public Sub SetRFunction(clsNewRFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsWindRoseFunc = clsNewRFunction
        SetRCode(Me, clsWindRoseFunc, bReset)
    End Sub

    Private Sub ShowHideCombos()
        If rdoDiverging.Checked Then
            ucrInputDiverging.Visible = True
            ucrInputSequential.Visible = False
            ucrInputQualitative.Visible = False
        ElseIf rdoQualitative.Checked Then
            ucrInputDiverging.Visible = False
            ucrInputSequential.Visible = False
            ucrInputQualitative.Visible = True
        Else
            ucrInputDiverging.Visible = False
            ucrInputSequential.Visible = True
            ucrInputQualitative.Visible = False
        End If
    End Sub

    Private Sub ucrPnlColourPalette_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlColourPalette.ControlValueChanged
        ShowHideCombos()
    End Sub
End Class