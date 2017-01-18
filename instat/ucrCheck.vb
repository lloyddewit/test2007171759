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

Public Class ucrCheck
    ''Is the checkbox linked to specific parameter values when checked/unchecked
    'Private bIsParameterValue As Boolean = True

    Private strValueIfChecked As String = "TRUE"
    Private strValueIfUnchecked As String = "FALSE"

    ''Is the checkbox linked to a parameter only by whether the parameter is present or not, irrespective of the parameter value
    'Private bIsParameterPresent As Boolean = False

    ''When bIsParameterPresent should the control be checked when the parameter is present (and unchecked when not present)
    ''If = False then the opposite.
    'Private bParameterIncludedWhenChecked As Boolean = True

    Public Overrides Sub UpdateControl()

        MyBase.UpdateControl()

        If clsParameter IsNot Nothing Then
            If bChangeParameterValue Then
                If clsParameter.strArgumentValue = strValueIfChecked OrElse clsParameter.strArgumentValue = strValueIfUnchecked Then
                    chkCheck.Checked = (clsParameter.strArgumentValue = strValueIfChecked)
                Else
                    MsgBox("Developer error: The value of parameter " & clsParameter.strArgumentName & ": " & clsParameter.strArgumentValue & " does not match strValueIfChecked or strValueIfUnchecked so cannot determine state for the checkbox. Setting as the default instead.")
                    chkCheck.Checked = False
                End If
            ElseIf bAddRemoveParameter Then
                'Commented out as not currently needed. Can be included if needed.
                'If bParameterIncludedWhenChecked Then
                chkCheck.Checked = clsRCode.clsParameters.Contains(clsParameter)
                'Else
                'chkCheck.Checked = Not clsRCodeObject.clsParameters.Contains(clsParameter)
                'End If
            End If
        End If
    End Sub

    Public Overrides Sub UpdateRCode(clsRCodeObject As RCodeStructure)
        Dim bCurrentAddValue As Boolean

        If clsParameter IsNot Nothing Then
            If bIsParameterValue Then
                If chkCheck.Checked Then
                    If strValueIfChecked <> objValueToRemoveParameter.ToString() Then
                        AddParameterToStructure(clsRCodeObject)
                        'clsRCodeObject.AddParameter(strParameterName:=strParameterName, strParameterValue:=strValueIfChecked)
                    Else
                        clsRCodeObject.RemoveParameterByName(strArgName:=strParameterName)
                    End If
                    If strValueIfUnchecked <> objValueToRemoveParameter.ToString() Then
                        'clsRCodeObject.AddParameter(strParameterName:=strParameterName, strParameterValue:=strValueIfUnchecked)
                    Else
                        clsRCodeObject.RemoveParameterByName(strArgName:=strParameterName)
                    End If
                End If
            ElseIf bIsParameterPresent Then
                If (chkCheck.Checked AndAlso bParameterIncludedWhenChecked) OrElse ((Not chkCheck.Checked) AndAlso (Not bParameterIncludedWhenChecked)) Then
                    If ucrLinkedControl IsNot Nothing Then
                        bCurrentAddValue = ucrLinkedControl.bAddIfParameterNotPresent
                        ucrLinkedControl.bAddIfParameterNotPresent = True
                        ucrLinkedControl.UpdateRCode(clsRCodeObject)
                        ucrLinkedControl.bAddIfParameterNotPresent = bCurrentAddValue
                    End If
                Else
                    clsRCodeObject.RemoveParameterByName(strArgName:=strParameterName)
                End If
            End If
        End If
    End Sub

    Public Sub SetValueIfChecked(strNewValueIfChecked As String)
        strValueIfChecked = strNewValueIfChecked
        bIsParameterValue = True
        bIsParameterPresent = False
    End Sub

    Public Sub SetValueIfUnchecked(strNewValueIfUnchecked As String)
        strValueIfUnchecked = strNewValueIfUnchecked
        bIsParameterValue = True
        bIsParameterPresent = False
    End Sub

    Public Sub SetValuesCheckedAndUnchecked(strNewValueIfChecked As String, strNewValueIfUnchecked As String)
        SetValueIfChecked(strNewValueIfChecked)
        SetValueIfUnchecked(strNewValueIfUnchecked)
    End Sub

    Public Sub SetIsParameterPresent()
        bIsParameterPresent = True
        bIsParameterValue = False
    End Sub

    Public Sub SetIsParameterValue()
        bIsParameterValue = True
        bIsParameterPresent = False
    End Sub

    Private Sub chkCheck_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheck.CheckedChanged
        OnControlValueChanged()
    End Sub

    Public Property Checked As Boolean
        Get
            Return chkCheck.Checked
        End Get
        Set(bChecked As Boolean)
            chkCheck.Checked = bChecked
        End Set
    End Property
End Class