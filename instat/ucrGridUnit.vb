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

Public Class ucrGridUnit

    Private bInitialiseControls As Boolean = False
    Public strUnit As String
    Private clsThemeFunction As New RFunction
    Private clsUnit As New RFunction
    Private clsBaseOperator As New ROperator
    Public Sub InitialiseControl()
        'Units
        ucrChkUnits.SetText("Tick length")
        ucrInputUnits.SetParameter(New RParameter("units"))
        ucrInputUnits.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctUnits))
        '? default npc  
        ' ucrInputUnits.SetRDefault(Chr(34) & "npc" & Chr(34))

        ucrInputData.SetParameter(New RParameter("data"))
        ucrInputData.SetRDefault("NULL")
        ucrInputData.AddQuotesIfUnrecognised = False
        ' ucrInputData.SetValidationTypeAsNumeric()

        ucrInputVector.SetParameter(New RParameter("x"))
        ucrInputVector.AddQuotesIfUnrecognised = False
        ' ucrInputVector.SetValidationTypeAsNumeric()


        ucrChkUnits.AddToLinkedControls(ucrInputUnits, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkUnits.AddToLinkedControls(ucrInputData, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkUnits.AddToLinkedControls(ucrInputVector, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputData.SetLinkedDisplayControl(lblData)

    End Sub

    Public Sub SetUnits(strNewAxis As String)
        strUnit = strNewAxis
    End Sub

    Public Sub SetRCodeForControl(strNewUnit As String, clsNewUnit As RFunction, clsNewThemeFunction As RFunction, clsNewBaseOperator As ROperator, Optional bReset As Boolean = False)
        If Not bInitialiseControls Then
            InitialiseControl()
        End If

        SetUnits(strNewUnit)
        clsBaseOperator = clsNewBaseOperator
        clsThemeFunction = clsNewThemeFunction
        clsUnit = clsNewUnit

        ucrChkUnits.SetRCode(clsUnit, bReset)
        ucrInputUnits.SetRCode(clsUnit, bReset)
        ucrInputData.SetRCode(clsUnit, bReset)
        ucrInputVector.SetRCode(clsUnit, bReset)
    End Sub

    Private Sub AddRemoveElementLineAxis()
        If ucrChkUnits.Checked Then
            clsThemeFunction.AddParameter(strUnit, clsRFunctionParameter:=clsUnit)
        Else
            clsThemeFunction.RemoveParameterByName(strUnit)
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

    Private Sub ElementTickAxisLineControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkUnits.ControlValueChanged
        AddRemoveElementLineAxis()
    End Sub

    Public Sub setlabel(strlabel As String)
        grpUnits.Text = strlabel
    End Sub
End Class
