﻿' R-Instat
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


Public Class sdgMapOption
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsXlimFunction, clsYlimFunction As New RFunction
    Private clsGgplotOperator As New ROperator
    Private bControlsInitalised As Boolean = False

    Private Sub sdgMapOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrInputLongMin.SetParameter(New RParameter("longmin", bNewIncludeArgumentName:=False))
        ucrInputLongMin.SetValidationTypeAsNumeric()
        ucrInputLongMin.AddQuotesIfUnrecognised = False

        ucrInputLongMax.SetParameter(New RParameter("longmax", bNewIncludeArgumentName:=False))
        ucrInputLongMax.SetValidationTypeAsNumeric()
        ucrInputLongMax.AddQuotesIfUnrecognised = False

        ucrInputLatMin.SetParameter(New RParameter("latmin", bNewIncludeArgumentName:=False))
        ucrInputLatMin.SetValidationTypeAsNumeric()
        ucrInputLatMin.AddQuotesIfUnrecognised = False

        ucrInputLatMax.SetParameter(New RParameter("latmax", bNewIncludeArgumentName:=False))
        ucrInputLatMax.SetValidationTypeAsNumeric()
        ucrInputLatMax.AddQuotesIfUnrecognised = False

        bControlsInitalised = True
    End Sub

    Public Sub SetRCode(clsBaseOperator As ROperator, clsXlim As RFunction, clsylim As RFunction, Optional bReset As Boolean = False)

        If Not bControlsInitalised Then
            InitialiseDialog()
        End If

        clsGgplotOperator = clsBaseOperator
        clsXlimFunction = clsXlim
        clsYlimFunction = clsylim

        If Not clsGgplotOperator.ContainsParameter("xlim") Then
            clsGgplotOperator.AddParameter("xlim", clsRFunctionParameter:=clsXlimFunction)
        End If

        If Not clsGgplotOperator.ContainsParameter("ylim") Then
            clsGgplotOperator.AddParameter("ylim", clsRFunctionParameter:=clsYlimFunction)
        End If

        ucrInputLongMin.SetRCode(clsXlimFunction, bReset)
        ucrInputLongMax.SetRCode(clsXlimFunction, bReset)
        ucrInputLatMin.SetRCode(clsYlimFunction, bReset)
        ucrInputLatMax.SetRCode(clsYlimFunction, bReset)
    End Sub

    Private Sub CheckMinMaxValues()
        'If ucrInputLongMin.GetValue() > ucrInputLongMax.GetValue() OrElse ucrInputLongMin.GetValue() > ucrInputLongMax.GetValue() Then
        '    MsgBox("You can not have minimum longitude value greater or equal to maximum longitude", vbOKOnly, "Warning")
        '    'TODO sould we disable return button??
        'ElseIf ucrInputLatMin.GetValue() > ucrInputLatMax.GetValue() OrElse ucrInputLatMin.GetValue() > ucrInputLatMax.GetValue() Then
        '    MsgBox("You can not have minimum latitude value greater or equal to maximum latitude", vbOKOnly, "Warning")

        'End If
    End Sub
    Private Sub ucrInputLatMax_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputLatMax.ControlValueChanged, ucrInputLongMax.ControlValueChanged
        'CheckMinMaxValues()
    End Sub
End Class