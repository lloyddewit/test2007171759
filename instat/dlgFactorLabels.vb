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
Public Class dlgViewFactorLabels
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsViewFunc, clsSelect As RFunction

    Private Sub dlgFactorLabels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        'TODO: HElP ID

        ucrReceiverFactorColumns.SetParameter(New RParameter("x", 1))
        ucrReceiverFactorColumns.SetParameterIsString()
        ucrReceiverFactorColumns.SetParameterIncludeArgumentName(False)
        ucrReceiverFactorColumns.bWithQuotes = False
        ucrReceiverFactorColumns.SetIncludedDataTypes({"factor", "numeric"})
        ucrReceiverFactorColumns.Selector = ucrSelectorViewFactorLabels
        ucrReceiverFactorColumns.SetMeAsReceiver()

        ucrSelectorViewFactorLabels.SetParameter(New RParameter(".data", 0))
        ucrSelectorViewFactorLabels.SetParameterIsrfunction()

        ucrChkShowLabels.SetParameter(New RParameter("show.labels", 1))
        ucrChkShowLabels.SetText("Show variable labels")
        ucrChkShowLabels.SetRDefault("TRUE")

        ucrChkShowType.SetParameter(New RParameter("show.type", 2))
        ucrChkShowType.SetText("Show column types")
        ucrChkShowType.SetRDefault("FALSE")

        ucrChkShowValues.SetParameter(New RParameter("show.values", 3))
        ucrChkShowValues.SetText("Show numeric values")
        ucrChkShowValues.SetRDefault("TRUE")

        ucrChkShowMissingValues.SetParameter(New RParameter("show.na", 4))
        ucrChkShowMissingValues.SetText("Show missing values")
        ucrChkShowMissingValues.SetRDefault("FALSE")

        ucrChkShowId.SetParameter(New RParameter("show.id", 5))
        ucrChkShowId.SetText("Show id")
        ucrChkShowId.SetRDefault("TRUE")

        ucrChkShowPercentage.SetParameter(New RParameter("show.prc", 6))
        ucrChkShowPercentage.SetText("Show percentages")
        ucrChkShowPercentage.SetRDefault("FALSE")

        ucrChkShowFrequencies.SetParameter(New RParameter("show.frq", 7))
        ucrChkShowFrequencies.SetText("Show frequencies")
        ucrChkShowFrequencies.SetRDefault("FALSE")

        ucrChkAlternateColour.SetParameter(New RParameter("altr.row.col", 8))
        ucrChkAlternateColour.SetText("Highlight alternate rows")
        ucrChkAlternateColour.SetRDefault("TRUE")

        ucrChkSortByName.SetParameter(New RParameter("sort.by.name", 9))
        ucrChkSortByName.SetText("Sort by name")
        ucrChkSortByName.SetRDefault("FALSE")
    End Sub

    Private Sub SetDefaults()
        clsViewFunc = New RFunction
        clsSelect = New RFunction

        'Reset
        ucrSelectorViewFactorLabels.Reset()
        'Defining the function
        clsViewFunc.SetPackageName("sjPlot")
        clsViewFunc.SetRCommand("view_df")

        clsSelect.SetPackageName("dplyr")
        clsSelect.SetRCommand("select")

        clsViewFunc.AddParameter("x", clsRFunctionParameter:=clsSelect)
        clsViewFunc.AddParameter("show.id", "FALSE")
        ucrBase.clsRsyntax.SetBaseRFunction(clsViewFunc)
    End Sub

    Private Sub TestOkEnabled()
        ucrBase.OKEnabled(True)
        'If (Not (ucrReceiverFactorColumns.IsEmpty) AndAlso (ucrChkShowLabels.Checked OrElse ucrChkShowType.Checked OrElse ucrChkShowValues.Checked)) Then
        '    ucrBase.OKEnabled(True)
        'Else
        '    ucrBase.OKEnabled(False)
        'End If
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrChkAlternateColour.SetRCode(clsViewFunc, bReset)
        ucrChkShowFrequencies.SetRCode(clsViewFunc, bReset)
        ucrChkShowId.SetRCode(clsViewFunc, bReset)
        ucrChkShowLabels.SetRCode(clsViewFunc, bReset)
        ucrChkShowMissingValues.SetRCode(clsViewFunc, bReset)
        ucrChkSortByName.SetRCode(clsViewFunc, bReset)
        ucrChkShowPercentage.SetRCode(clsViewFunc, bReset)
        ucrChkShowType.SetRCode(clsViewFunc, bReset)
        ucrChkShowValues.SetRCode(clsViewFunc, bReset)
        ucrReceiverFactorColumns.SetRCode(clsSelect, bReset)
        ucrSelectorViewFactorLabels.SetRCode(clsSelect, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverFactorColumns_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactorColumns.ControlContentsChanged, ucrChkAlternateColour.ControlContentsChanged, ucrChkShowFrequencies.ControlContentsChanged, ucrChkShowId.ControlContentsChanged, ucrChkShowLabels.ControlContentsChanged, ucrChkShowMissingValues.ControlContentsChanged, ucrChkShowPercentage.ControlContentsChanged, ucrChkShowType.ControlContentsChanged, ucrChkShowValues.ControlContentsChanged, ucrChkSortByName.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class