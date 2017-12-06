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
Public Class dlgParallelCoordinatePlot
    Private clsggparcoordFunc As New RFunction
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgParallelCoordinatePlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Dim dctScale As New Dictionary(Of String, String)

        ucrSelectorParallelCoordinatePlot.SetParameter(New RParameter("data", 0))
        ucrSelectorParallelCoordinatePlot.SetParameterIsrfunction()

        ucrReceiverXVariables.SetParameter(New RParameter("columns", 1))
        ucrReceiverXVariables.SetParameterIsString()
        ucrReceiverXVariables.bWithQuotes = False
        ucrReceiverXVariables.strSelectorHeading = "Numerics"
        ucrReceiverXVariables.Selector = ucrSelectorParallelCoordinatePlot
        ucrReceiverXVariables.SetIncludedDataTypes({"numeric"})


        ucrReceiverFactor.SetParameter(New RParameter("groupColumn", 2))
        ucrReceiverFactor.strSelectorHeading = "Factors"
        ucrReceiverFactor.Selector = ucrSelectorParallelCoordinatePlot
        ucrReceiverFactor.SetIncludedDataTypes({"factor"})
        ucrReceiverFactor.SetParameterIsString()

        ucrChkBoxplots.SetParameter(New RParameter("boxplot", 3))
        ucrChkBoxplots.SetText("Boxplot")
        ucrChkBoxplots.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkBoxplots.SetRDefault("FALSE")

        ucrChkPoints.SetParameter(New RParameter("showPoints", 4))
        ucrChkPoints.SetText("Points")
        ucrChkPoints.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkPoints.SetRDefault("FALSE")

        ucrNudTransparency.SetParameter(New RParameter("alphalines", 5))
        ucrNudTransparency.SetMinMax(0, 1)
        ucrNudTransparency.DecimalPlaces = 2
        ucrNudTransparency.Increment = 0.01

        ucrInputScale.SetParameter(New RParameter("scale", 6))
        dctScale.Add("Std", "std")
        dctScale.Add("Robust", Chr(34) & "robust" & Chr(34))
        dctScale.Add("Uniminmax", Chr(34) & "uniminmax" & Chr(34))
        dctScale.Add("Globalminmax", Chr(34) & "globalminmax" & Chr(34))
        dctScale.Add("Center", Chr(34) & "center" & Chr(34))
        dctScale.Add("CenterObs", Chr(34) & "centerObs" & Chr(34))
        ucrInputScale.SetItems(dctScale)
        ucrInputScale.SetRDefault("std")
        ucrInputScale.SetDropDownStyleAsNonEditable()

        ucrSaveGraph.SetPrefix("ParCoord")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorParallelCoordinatePlot.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")

    End Sub

    Private Sub SetDefaults()
        clsggparcoordFunc = New RFunction

        ucrReceiverXVariables.SetMeAsReceiver()
        ucrSelectorParallelCoordinatePlot.Reset()
        ucrSaveGraph.Reset()

        clsggparcoordFunc.SetPackageName("GGally")
        clsggparcoordFunc.SetRCommand("ggparcoord")

        clsggparcoordFunc.AddParameter("boxplot", "FALSE")
        clsggparcoordFunc.AddParameter("showPoints", "FALSE")
        clsggparcoordFunc.AddParameter("scale", "std")
        clsggparcoordFunc.AddParameter("alphalines", "1")

        clsggparcoordFunc.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorParallelCoordinatePlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseRFunction(clsggparcoordFunc)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverXVariables.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverXVariables_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverXVariables.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class