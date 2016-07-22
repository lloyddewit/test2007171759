﻿
' Instat-R
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

Public Class ucrReceiverMetadataProperty
    Public clsLayerParam As LayerParameters
    Public ctrActive As Control

    Public Sub SetControls()

        nudParamValue.Visible = False
        ucrcborParamValue.Visible = False
        UcrColor.Visible = False
        If Not IsNothing(clsLayerParam) Then
            If clsLayerParam.strLayerParameterDataType = "numeric" Then
                If clsLayerParam.lstParameterStrings.Count >= 1 Then
                    nudParamValue.DecimalPlaces = clsLayerParam.lstParameterStrings(0)
                Else
                    nudParamValue.DecimalPlaces = 0
                End If
                nudParamValue.Increment = Math.Pow(10, -nudParamValue.DecimalPlaces)
                If clsLayerParam.lstParameterStrings.Count >= 2 Then
                    nudParamValue.Minimum = clsLayerParam.lstParameterStrings(1)
                Else
                    nudParamValue.Minimum = Decimal.MinValue
                End If
                If clsLayerParam.lstParameterStrings.Count >= 3 Then
                    nudParamValue.Maximum = clsLayerParam.lstParameterStrings(2)
                Else
                    nudParamValue.Maximum = Decimal.MaxValue
                End If
                ctrActive = nudParamValue
            ElseIf clsLayerParam.strLayerParameterDataType = "boolean" Then
                ctrActive = ucrcborParamValue
                ucrcborParamValue.SetItems({"TRUE", "FALSE"})
            ElseIf clsLayerParam.strLayerParameterDataType = "colour" Then
                ctrActive = UcrColor
            ElseIf clsLayerParam.strLayerParameterDataType = "list" Then
                ctrActive = ucrcborParamValue

                ucrcborParamValue.SetItems(clsLayerParam.lstParameterStrings)
                ucrcborParamValue.Visible = True
            Else
                ctrActive = New Control 'this should never actually be used but is here to ensure the code is stable even if a developper uses an incorrect datatype
            End If

        End If


    End Sub
End Class
