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
Public Class dlgGeneralForGraphics
    Private clsRggplotFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Private lstLayerComplete As New List(Of Boolean)
    Private iLayerIndex As Integer
    Private WithEvents clsGgplotAesFunction As New RFunction
    Private strGgplotDataFrame As String = ""
    Public bDataFrameSet As Boolean = False

    Private Sub dlgGeneralForGraphics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        'setting the base ggplot functions
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsGgplotAesFunction.SetRCommand("aes")
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        ucrBase.iHelpTopicID = 356
    End Sub

    Private Sub SetDefaults()
        iLayerIndex = 0
        lstLayers.Clear()
        lstLayerComplete.Clear()
        SetEditDeleteEnabled()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim clsNewGeomFunction As New RFunction

        sdgLayerOptions.SetupLayer(clsTempGeomFunc:=clsNewGeomFunction, clsTempAesFunc:=clsGgplotAesFunction, bFixAes:=False, bFixGeom:=False, strDataframe:=strGgplotDataFrame, bUseGlobalAes:=lstLayers.Items.Count = 0, bFixDataFrame:=lstLayers.Items.Count > 0)
        sdgLayerOptions.ShowDialog()
        AddLayers()
    End Sub

    Public Sub AddLayers()
        Dim lviLayer As ListViewItem
        Dim strLayerName As String

        If Not bDataFrameSet AndAlso sdgLayerOptions.ucrGeomWithAes.chkApplyOnAllLayers.Checked Then
            strGgplotDataFrame = sdgLayerOptions.ucrGeomWithAes.UcrSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text
            sdgLayerOptions.strGgplotDataFrame = strGgplotDataFrame
            clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=sdgLayerOptions.ucrGeomWithAes.UcrSelector.ucrAvailableDataFrames.clsCurrDataFrame.Clone())
            bDataFrameSet = True
            sdgLayerOptions.bDataFrameSet = True
        End If

        iLayerIndex = iLayerIndex + 1
        strLayerName = iLayerIndex & "." & sdgLayerOptions.ucrGeomWithAes.cboGeomList.SelectedItem
        lviLayer = New ListViewItem(text:=strLayerName)
        If lstLayers.Items.Contains(lviLayer) Then
            lstLayerComplete(lstLayers.Items.IndexOf(lviLayer)) = sdgLayerOptions.TestForOKEnabled()
        Else
            lstLayers.Items.Add(lviLayer)
            lstLayerComplete.Add(sdgLayerOptions.TestForOKEnabled())
        End If

        If sdgLayerOptions.TestForOKEnabled() Then
            lstLayers.Items(lstLayers.Items.IndexOf(lviLayer)).ForeColor = Color.Green
        Else
            lstLayers.Items(lstLayers.Items.IndexOf(lviLayer)).ForeColor = Color.Red
        End If
        ucrBase.clsRsyntax.SetOperatorParameter(False, strParameterName:=strLayerName, clsRFunc:=sdgLayerOptions.clsGeomFunction.Clone)
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        Dim bTemp As Boolean = False
        For Each bTemp In lstLayerComplete
            If Not bTemp Then
                Exit For
            End If
        Next
        ucrBase.OKEnabled(bTemp)
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If lstLayers.SelectedItems.Count = 1 Then
            ucrBase.clsRsyntax.RemoveOperatorParameter(lstLayers.SelectedItems(0).Text)
            lstLayerComplete.RemoveAt(lstLayers.SelectedIndices(0))
            lstLayers.Items.Remove(lstLayers.SelectedItems(0))
        End If
        TestOKEnabled()
    End Sub

    Private Sub lstLayers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLayers.SelectedIndexChanged
        SetEditDeleteEnabled()
    End Sub

    Private Sub SetEditDeleteEnabled()
        If lstLayers.SelectedItems.Count = 1 Then
            cmdDelete.Enabled = True
            'Edit disabled for now
            'cmdEdit.Enabled = True
        Else
            cmdDelete.Enabled = False
            cmdEdit.Enabled = False
        End If
    End Sub

    Private Sub clsGgplotAesFunction_ParametersChanged() Handles clsGgplotAesFunction.ParametersChanged
        If clsGgplotAesFunction.iParameterCount > 0 Then
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsGgplotAesFunction)
        Else
            clsRggplotFunction.RemoveParameterByName("mapping")
        End If
    End Sub
End Class