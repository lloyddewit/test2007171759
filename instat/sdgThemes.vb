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

Public Class sdgThemes
    Public bControlsInitialised As Boolean = False
    Private clsElementLine, clsElementRect, clsElementXAxisTextTop, clsElementXAxisLine, clsElementYAxisLine, clsElementText, clsElementYAxisTextRight, clsElementXAxisLineTop, clsThemeFunction As New RFunction

    Private clsBaseOperator As New ROperator

    Private dctThemeFunctions As New Dictionary(Of String, RFunction)

    Private Sub sdgThemes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim dctLegendPosition As New Dictionary(Of String, String)
        Dim dctLegendDirection As New Dictionary(Of String, String)
        Dim dctLegendBox As New Dictionary(Of String, String)
        Dim dctLegendBoxJust As New Dictionary(Of String, String)
        Dim dctLegendJustification As New Dictionary(Of String, String)

        ucrThemeBottomXAxis.setlabel("X axis tick labels")
        ucrThemeTopXAxis.setlabel("X axis tick labels on top axis")
        ucrThemeLeftYAxis.setlabel("Y axis tick labels")
        ucrThemeYRightAxis.setlabel("Y axis tick labels on right axis")
        ucrThemeTitleXAxis.setlabel("X axis label ")
        ucrThemeTitleXTopAxis.setlabel("X axis label on top axis")
        ucrThemeTitleYAxis.setlabel("Y axis labels")
        ucrThemeTitleYRightAxis.setlabel("Y axis labels on right axis")
        ucrTickMarksYAxis.setlabel("Y axis tick marks")
        ucrYAxisLines.setlabel("Line along y axis")
        ucrTickMarksXAxis.setlabel("X axis tick marks")
        ucrXAxisLines.setlabel("Line along x axis")
        ucrTickMarksAxes.setlabel("Tick marks along axes")
        ucrThemeAxesTitle.setlabel("Label of axes")
        ucrThemeAxesTickLabels.setlabel("Tick marks along axes")
        ucrThemeAxesLines.setlabel("Lines along axes")

        ucrLegendTitle.setlabel("Title of legend")
        ucrLegendText.setlabel("Legend item labels")
        ucrLegendBackground.setlabel("Background of legend")
        ucrLegendKey.setlabel("Background underneath legend keys")
        ucrLegendBoxBackground.setlabel("Background of legend area")

        ucrPanelGrid.setlabel("Grid lines")
        ucrPanelGridMajor.setlabel("Major grid lines ")
        ucrPanelGridMinor.setlabel("Major grid lines ")
        ucrPanelBorder.setlabel("Panel border")
        ucrPanelBackGround.setlabel("Panel background")

        ucrPlotBackGround.setlabel("")
        ucrPlotCaption.setlabel("")
        ucrPlotSubTitle.setlabel("")
        ucrPlotTitle.setlabel("")

        'Units
        ucrChkUnits.SetText("Tick length")
        ucrInputTickUnits.SetParameter(New RParameter("units"))
        ucrInputTickUnits.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctFonts))
        ucrInputTickUnits.SetRDefault(Chr(34) & "npc" & Chr(34))


        ' TODO: Find what this means: "two-element numeric vector"
        urChkLegendPosition.SetText("Legend Position")
        ucrInputLegendPosition.SetParameter(New RParameter("legend.position"))
        dctLegendPosition.Add("None", Chr(34) & "none" & Chr(34))
        dctLegendPosition.Add("Left", Chr(34) & "left" & Chr(34))
        dctLegendPosition.Add("Right", Chr(34) & "right" & Chr(34))
        dctLegendPosition.Add("Top", Chr(34) & "top" & Chr(34))
        dctLegendPosition.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        ucrInputLegendPosition.SetItems(dctLegendPosition)
        ucrInputLegendPosition.SetRDefault(Chr(34) & "none" & Chr(34))

        ucrChkLegendBox.SetText("Legend Layout")
        ucrInputLegendBox.SetParameter(New RParameter("legend.box"))
        dctLegendBox.Add("Vertical", Chr(34) & "vertical" & Chr(34))
        dctLegendBox.Add("Horizontal", Chr(34) & "horizontal" & Chr(34))
        ucrInputLegendBox.SetItems(dctLegendBox)
        ucrInputLegendBox.SetRDefault(Chr(34) & "vertical" & Chr(34))

        urChkLegendBoxJust.SetText("Justify Legend Box")
        ucrInputLegendBoxJust.SetParameter(New RParameter("legend.box.just"))
        dctLegendBoxJust.Add("Top", Chr(34) & "top" & Chr(34))
        dctLegendBoxJust.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        dctLegendBoxJust.Add("Right", Chr(34) & "right" & Chr(34))
        dctLegendBoxJust.Add("Left", Chr(34) & "left" & Chr(34))
        ucrInputLegendBoxJust.SetItems(dctLegendBoxJust)
        ucrInputLegendBoxJust.SetRDefault(Chr(34) & "top" & Chr(34))


        ucrChkLegendDirection.SetText("Legend Direction")
        ucrInputLegendDirection.SetParameter(New RParameter("legend.direction"))
        dctLegendDirection.Add("Vertical", Chr(34) & "vertical" & Chr(34))
        dctLegendDirection.Add("Horizontal", Chr(34) & "horizontal" & Chr(34))
        ucrInputLegendDirection.SetItems(dctLegendDirection)
        ucrInputLegendDirection.SetRDefault(Chr(34) & "vertical" & Chr(34))


        ucrChkLegendJustification.SetText("Legend Justification")
        ucrInputLegendJustification.SetParameter(New RParameter("legend.justification"))
        dctLegendJustification.Add("Top", Chr(34) & "top" & Chr(34))
        dctLegendJustification.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        dctLegendJustification.Add("Right", Chr(34) & "right" & Chr(34))
        dctLegendJustification.Add("Left", Chr(34) & "left" & Chr(34))
        dctLegendJustification.Add("Center", Chr(34) & "centre" & Chr(34))
        ucrInputLegendJustification.SetItems(dctLegendJustification)
        ucrInputLegendJustification.SetRDefault(Chr(34) & "top" & Chr(34))

        urChkLegendPosition.AddToLinkedControls(ucrInputLegendPosition, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLegendBox.AddToLinkedControls(ucrInputLegendBox, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        urChkLegendBoxJust.AddToLinkedControls(ucrInputLegendBoxJust, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLegendDirection.AddToLinkedControls(ucrInputLegendDirection, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLegendJustification.AddToLinkedControls(ucrInputLegendJustification, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

    End Sub

    Public Sub SetRCode(clsBaseOperator As ROperator, clsNewThemeFunction As RFunction, dctNewThemeFunctions As Dictionary(Of String, RFunction), Optional bReset As Boolean = False)
        Dim clsXElementText As New RFunction
        Dim clsElementTickText As New RFunction
        Dim clsXElementTitleText As New RFunction
        Dim clsYElementText As New RFunction
        Dim clsXTopElementText As New RFunction
        Dim clsYRightElementText As New RFunction
        Dim clsXElementTitle As New RFunction
        Dim clsYElementTitle As New RFunction
        Dim clsXTopElementTitle As New RFunction
        Dim clsYRightElementTitle As New RFunction
        Dim clsElementLegendText As New RFunction
        Dim clsElementLegendTitle As New RFunction

        Dim clsXElementLine As New RFunction
        Dim clsElementLineAxes As New RFunction
        Dim clsYElementLine As New RFunction
        Dim clsElementTickAxes As New RFunction
        Dim clsElementTickXAxis As New RFunction
        Dim clsElementTickYAxis As New RFunction
        Dim clsElementLineXAxis As New RFunction
        Dim clsElementLineYAxis As New RFunction

        Dim clsElementLegendBackground As New RFunction
        Dim clsElementLegendBoxBackground As New RFunction
        Dim clsElementLegendtKey As New RFunction

        Dim clsElementBorder As New RFunction
        Dim clsElementPanelBackGround As New RFunction

        Dim clsElementPanelGrid As New RFunction
        Dim clsElementPanelGridMajor As New RFunction
        Dim clsElementPanelGridMinor As New RFunction

        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)
        clsThemeFunction = clsNewThemeFunction

        dctThemeFunctions = dctNewThemeFunctions
        dctThemeFunctions.TryGetValue("axis.text", clsElementTickText)
        dctThemeFunctions.TryGetValue("axis.text.x", clsXElementText)
        dctThemeFunctions.TryGetValue("axis.text.y", clsYElementText)
        dctThemeFunctions.TryGetValue("axis.text.x.top", clsXTopElementText)
        dctThemeFunctions.TryGetValue("axis.text.y.right", clsYRightElementText)

        dctThemeFunctions.TryGetValue("legend.text", clsElementLegendText)
        dctThemeFunctions.TryGetValue("legend.title", clsElementLegendTitle)

        dctThemeFunctions.TryGetValue("axis.title", clsXElementTitleText)
        dctThemeFunctions.TryGetValue("axis.title.x", clsXElementTitle)
        dctThemeFunctions.TryGetValue("axis.title.y", clsYElementTitle)
        dctThemeFunctions.TryGetValue("axis.title.x.top", clsXTopElementTitle)
        dctThemeFunctions.TryGetValue("axis.title.y.right", clsYRightElementTitle)


        dctThemeFunctions.TryGetValue("axis.ticks.x", clsXElementLine)
        dctThemeFunctions.TryGetValue("axis.ticks.y", clsYElementLine)
        dctThemeFunctions.TryGetValue("axis.line.x", clsElementLineXAxis)
        dctThemeFunctions.TryGetValue("axis.line.y", clsElementLineYAxis)
        dctThemeFunctions.TryGetValue("axis.ticks", clsElementTickAxes)
        dctThemeFunctions.TryGetValue("axis.line", clsElementLineAxes)

        dctThemeFunctions.TryGetValue("Panel.grid", clsElementPanelGrid)
        dctThemeFunctions.TryGetValue("Panel.grid.major", clsElementPanelGridMajor)
        dctThemeFunctions.TryGetValue("Panel.grid.minor", clsElementPanelGridMinor)

        dctThemeFunctions.TryGetValue("legend.background", clsElementLegendBackground)
        dctThemeFunctions.TryGetValue("legend.box.background", clsElementLegendBoxBackground)
        dctThemeFunctions.TryGetValue("legend.key", clsElementLegendtKey)
        dctThemeFunctions.TryGetValue("Panel.background", clsElementPanelBackGround)
        dctThemeFunctions.TryGetValue("Panel.border", clsElementBorder)

        ucrTickMarksXAxis.SetRCodeForControl("axis.ticks.x", clsXElementLine, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrTickMarksYAxis.SetRCodeForControl("axis.ticks.y", clsYElementLine, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrXAxisLines.SetRCodeForControl("axis.line.x", clsElementLineXAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrYAxisLines.SetRCodeForControl("axis.line.y", clsElementLineYAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeAxesTickLabels.SetRCodeForControl("axis.ticks", clsElementTickAxes, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrTickMarksAxes.SetRCodeForControl("axis.text", clsElementTickText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeAxesTitle.SetRCodeForControl("axis.title", clsXElementTitleText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeAxesLines.SetRCodeForControl("axis.line", clsElementLineAxes, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrThemeBottomXAxis.SetRCodeForControl("axis.text.x", clsXElementText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeTopXAxis.SetRCodeForControl("axis.text.x.top", clsXTopElementText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeLeftYAxis.SetRCodeForControl("axis.text.y", clsYElementText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeYRightAxis.SetRCodeForControl("axis.text.y.right", clsYRightElementText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrThemeTitleXAxis.SetRCodeForControl("axis.title.x", clsXElementTitle, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeTitleXTopAxis.SetRCodeForControl("axis.title.x.top", clsXTopElementTitle, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeTitleYAxis.SetRCodeForControl("axis.title.y", clsYElementTitle, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeTitleYRightAxis.SetRCodeForControl("axis.title.y.right", clsYRightElementTitle, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrLegendTitle.SetRCodeForControl("legend.title", clsElementLegendTitle, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrLegendText.SetRCodeForControl("legend.text", clsElementLegendText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrLegendBackground.SetRCodeForControl("legend.background", clsElementLegendBackground, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrLegendBoxBackground.SetRCodeForControl("legend.box.background", clsElementLegendBoxBackground, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrLegendKey.SetRCodeForControl("legend.key", clsElementLegendtKey, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrPanelGrid.SetRCodeForControl("Panel.grid", clsElementPanelGrid, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelGridMajor.SetRCodeForControl("Panel.grid.major", clsElementPanelGridMajor, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelGridMinor.SetRCodeForControl("Panel.grid.minor", clsElementPanelGridMinor, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelBorder.SetRCodeForControl("Panel.background", clsElementPanelBackGround, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelBackGround.SetRCodeForControl("Panel.border", clsElementBorder, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrPlotBackGround.SetRCodeForControl("Panel.border", clsElementBorder, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPlotCaption.SetRCodeForControl("Panel.border", clsElementBorder, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPlotSubTitle.SetRCodeForControl("Panel.border", clsElementBorder, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPlotTitle.SetRCodeForControl("Panel.border", clsElementBorder, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)


        urChkLegendPosition.SetRCode(clsThemeFunction, bReset)
        ucrInputLegendPosition.SetRCode(clsThemeFunction, bReset)

        ucrChkLegendBox.SetRCode(clsThemeFunction, bReset)
        ucrInputLegendBox.SetRCode(clsThemeFunction, bReset)

        urChkLegendBoxJust.SetRCode(clsThemeFunction, bReset)
        ucrInputLegendBoxJust.SetRCode(clsThemeFunction, bReset)

        ucrChkLegendDirection.SetRCode(clsThemeFunction, bReset)
        ucrInputLegendDirection.SetRCode(clsThemeFunction, bReset)

        ucrChkLegendJustification.SetRCode(clsThemeFunction, bReset)
        ucrInputLegendJustification.SetRCode(clsThemeFunction, bReset)
        AddRemoveElementParameters()
    End Sub

    Private Sub AddRemoveElementParameters()
        If ucrChkLegendBox.Checked Then
            clsThemeFunction.AddParameter("legend.box")
        Else
            clsThemeFunction.RemoveParameterByName("legend.box")
        End If

        If ucrChkLegendDirection.Checked Then
            clsThemeFunction.AddParameter("legend.direction")
        Else
            clsThemeFunction.RemoveParameterByName("legend.direction")
        End If

        If ucrChkLegendJustification.Checked Then
            clsThemeFunction.AddParameter("legend.justification")
        Else
            clsThemeFunction.RemoveParameterByName("legend.justification")
        End If

        If urChkLegendBoxJust.Checked Then
            clsThemeFunction.AddParameter("legend.box.just")
        Else
            clsThemeFunction.RemoveParameterByName("legend.box.just")
        End If

        If urChkLegendPosition.Checked Then
            clsThemeFunction.AddParameter("legend.position")
        Else
            clsThemeFunction.RemoveParameterByName("legend.position")
        End If

        AddRemoveTheme()
    End Sub

    Private Sub AddRemoveTheme()
        If clsThemeFunction.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)
        Else
            clsBaseOperator.RemoveParameterByName("theme")
        End If
    End Sub

    Private Sub ElementLegendControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLegendBox.ControlValueChanged, ucrChkLegendDirection.ControlValueChanged, ucrChkLegendJustification.ControlValueChanged, urChkLegendBoxJust.ControlValueChanged, urChkLegendPosition.ControlValueChanged
        AddRemoveElementParameters()
    End Sub
End Class