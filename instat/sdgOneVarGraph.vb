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
Imports instat
Imports instat.Translations
Public Class sdgOneVarGraph
    Public bFirstLoad As Boolean = True
    Public clsGraphOneVariable As New RFunction

    Private Sub sdgOneVarGraph_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseDialog()
        Dim lstNumericPairs As New List(Of KeyValuePair(Of String, String))
        Dim lstCategoricalPairs As New List(Of KeyValuePair(Of String, String))

        lstNumericPairs.Add(New KeyValuePair(Of String, String)("Boxplot", Chr(34) & "geom_boxplot" & Chr(34)))
        lstNumericPairs.Add(New KeyValuePair(Of String, String)("Histogram", Chr(34) & "geom_histogram" & Chr(34)))
        lstNumericPairs.Add(New KeyValuePair(Of String, String)("Dotplot", Chr(34) & "geom_dotplot" & Chr(34)))
        lstNumericPairs.Add(New KeyValuePair(Of String, String)("Point Plot", Chr(34) & "geom_point" & Chr(34)))
        lstNumericPairs.Add(New KeyValuePair(Of String, String)("Density Plot", Chr(34) & "geom_density" & Chr(34)))
        lstNumericPairs.Add(New KeyValuePair(Of String, String)("Frequency Polygon", Chr(34) & "geom_freqpoly" & Chr(34)))
        lstNumericPairs.Add(New KeyValuePair(Of String, String)("Violin Plot", Chr(34) & "geom_violin" & Chr(34)))
        lstNumericPairs.Add(New KeyValuePair(Of String, String)("Jitter Plot", Chr(34) & "geom_jitter" & Chr(34)))
        lstNumericPairs.Add(New KeyValuePair(Of String, String)("Boxplot + Jitter", Chr(34) & "box_jitter" & Chr(34)))
        lstNumericPairs.Add(New KeyValuePair(Of String, String)("Violin + Jitter", Chr(34) & "violin_jitter" & Chr(34)))
        lstNumericPairs.Add(New KeyValuePair(Of String, String)("Violin + Boxplot", Chr(34) & "violin_box" & Chr(34)))
        ucrInputNumeric.SetItems(lstNumericPairs)

        lstCategoricalPairs.Add(New KeyValuePair(Of String, String)("Bar Chart", Chr(34) & "geom_bar" & Chr(34)))
        lstCategoricalPairs.Add(New KeyValuePair(Of String, String)("Pie Chart", Chr(34) & "pie_chart" & Chr(34)))
        lstCategoricalPairs.Add(New KeyValuePair(Of String, String)("Dot Plot", Chr(34) & "geom_dotplot" & Chr(34)))
        ucrInputCategorical.SetItems(lstCategoricalPairs)

        ucrInputNumeric.strParameterName = "numeric"
        ucrInputCategorical.strParameterName = "categorical"

        ucrChkSpecifyLayout.strParameterName = "ncol"
        ucrChkSpecifyLayout.SetText("Specify Layout")
        ucrChkSpecifyLayout.bChangeParameterValue = False
        ucrChkSpecifyLayout.AddToLinkedControls(ucrLinked:=ucrNudNumberofColumns, objValues:={}, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeParameterToDefault:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkFreeScaleAxisforFacets.SetText("Free Scale Axis for Facets")

        ucrNudNumberofColumns.strParameterName = "ncol"
        ucrNudNumberofColumns.SetMinMax(1, 10)
    End Sub

    Public Sub SetRFunction(clsNewRFunction As RFunction)
        clsGraphOneVariable = clsNewRFunction
    End Sub

    Private Sub CoreControlsValueChanged(ucrChangedControl As ucrCore) Handles ucrChkFreeScaleAxisforFacets.ControlValueChanged, ucrChkSpecifyLayout.ControlContentsChanged, ucrInputCategorical.ControlContentsChanged, ucrInputNumeric.ControlContentsChanged, ucrNudNumberofColumns.ControlContentsChanged
        ucrChangedControl.UpdateRCode()
        'After one control has edited the code, other controls may need to be updated
        'Could make more efficient by only updating controls "linked" to ucrChangedControl, but for this this seems a simple solution.
        'UpdateControls(Me)
    End Sub
End Class
