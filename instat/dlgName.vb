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
Public Class dlgName
    Dim bFirstLoad As Boolean = True
    Private clsDefaultRFunction As New RFunction
    Dim bUseSelectedColumn As Boolean = False
    Dim strSelectedColumn As String = ""
    Dim strSelectedDataFrame As String = ""

    Private Sub dlgName_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            Initialisedialog()
            Setdefaults()
            bFirstLoad = False
        End If
        If bUseSelectedColumn Then
            Setdefaultcolumn()
        End If
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverName.IsEmpty() AndAlso Not ucrInputNewName.IsEmpty() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub Initialisedialog()
        ucrReceiverName.Selector = ucrSelectVariables
        ucrReceiverName.SetMeAsReceiver()
        ucrReceiverName.SetParameter(New RParameter("column_name"))
        ucrReceiverName.SetParameterIsString()
        ucrSelectVariables.SetParameter(New RParameter("data_name"))
        ucrSelectVariables.SetParameterIsString()
        ucrBase.iHelpTopicID = 33
        ucrInputNewName.SetParameter(New RParameter("new_val"))
        ucrInputNewName.SetName("new_column_name")
        ucrInputNewName.SetValidationTypeAsRVariable()
        clsDefaultRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$rename_column_in_data")
        clsDefaultRFunction.AddParameter("new_val", Chr(34) & "new_column_name" & Chr(34))
    End Sub

    Public Sub Setdefaults()
        ' Set default RFunction as the base function
        ucrSelectVariables.Reset()
        ucrInputNewName.Reset()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction.Clone())
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
    End Sub

    Public Sub Setcurrentcolumn(strcolumn As String, strdataframe As String)
        strSelectedColumn = strcolumn
        strSelectedDataFrame = strdataframe
        bUseSelectedColumn = True
    End Sub

    Private Sub Setdefaultcolumn()
        ucrSelectVariables.SetDataframe(strSelectedDataFrame)
        ucrReceiverName.Add(strSelectedColumn, strSelectedDataFrame)
        bUseSelectedColumn = False
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        Setdefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputNewName_ContentsChanged() Handles ucrInputNewName.ControlContentsChanged, ucrReceiverName.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class
