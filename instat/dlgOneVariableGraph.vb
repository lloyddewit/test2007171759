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

Public Class dlgOneVariableGraph
    Private bFirstLoad As Boolean = True
    Private clsDefaultRFunction As New RFunction

    Private Sub dlgOneVariableGraph_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOkEnabled()
    End Sub

    Private Sub SetDefaults()
        ' Set default RFunction as the base function
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction.Clone())

        ucrSelectorOneVarGraph.Reset()
        ucrOneVarGraphSave.Reset()
        ucrOneVarGraphSave.strPrefix = "OneVariableGraph"

        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        'Define the default RFunction
        clsDefaultRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$graph_one_variable")
        clsDefaultRFunction.AddParameter("numeric", Chr(34) & "geom_boxplot" & Chr(34))
        clsDefaultRFunction.AddParameter("categorical", Chr(34) & "geom_bar" & Chr(34))
        'clsDefaultRFunction.AddParameter("output", Chr(34) & "facets" & Chr(34))
        clsDefaultRFunction.AddParameter("coord_flip", "TRUE")
        'clsDefaultRFunction.AddParameter("ncol", "2")

        ucrRdoFacets.SetText("Facets")
        ucrRdoFacets.strValueIfChecked = Chr(34) & "facets" & Chr(34)
        ucrRdoFacets.SetDefault(Chr(34) & "facets" & Chr(34))
        ucrRdoSingleGraphs.SetText("Single Graphs")
        ucrRdoSingleGraphs.strValueIfChecked = Chr(34) & "single" & Chr(34)
        ucrRdoCombine.SetText("Combine Graphs")
        ucrRdoCombine.strValueIfChecked = Chr(34) & "combine" & Chr(34)
        SetParameterName({ucrRdoFacets, ucrRdoSingleGraphs, ucrRdoCombine}, "output")

        ucrReceiverOneVarGraph.Selector = ucrSelectorOneVarGraph
        ucrReceiverOneVarGraph.SetMeAsReceiver()
        ucrReceiverOneVarGraph.SetParameterName("columns")
        ucrReceiverOneVarGraph.SetParameterIsString()

        ucrSelectorOneVarGraph.strParameterName = "data_name"
        ucrSelectorOneVarGraph.SetParameterIsString()
        clsDefaultRFunction.AddParameter(ucrSelectorOneVarGraph.GetParameter(), 0)

        ucrChkFlip.SetText("Flip Coordinates")
        ucrChkFlip.SetParameterName("coord_flip")
        ucrChkFlip.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkFlip.SetDefault("FALSE")

        ucrBase.iHelpTopicID = 412
        ucrOneVarGraphSave.strPrefix = "OneVariableGraph"
        ucrOneVarGraphSave.SetDataFrameSelector(ucrSelectorOneVarGraph.ucrAvailableDataFrames)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
    End Sub

    Private Sub ReopenDialog()
        CheckDataType()
    End Sub

    Private Sub TestOkEnabled()
        'Question: What should TestOK do in the new implementation? Still check controls or check the code?
        'this test when to enable okay button. Should be enabled only when the receiver is not empty or when the save graph is schecked and the save graph is not empty
        If ucrReceiverOneVarGraph.IsEmpty() OrElse (ucrOneVarGraphSave.chkSaveGraph.Checked AndAlso ucrOneVarGraphSave.ucrInputGraphName.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOkEnabled()
    End Sub

    Private Sub ucrOneVarGraphSave_GraphNameChanged() Handles ucrOneVarGraphSave.GraphNameChanged, ucrOneVarGraphSave.SaveGraphCheckedChanged
        'this sub saves graphs 
        If ucrOneVarGraphSave.bSaveGraph Then
            ucrBase.clsRsyntax.SetAssignTo(ucrOneVarGraphSave.strGraphName, strTempDataframe:=ucrSelectorOneVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrOneVarGraphSave.strGraphName)
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorOneVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        End If
        TestOkEnabled()
    End Sub

    Private Sub cmdGraph_Click(sender As Object, e As EventArgs) Handles cmdGraphOptions.Click
        ' Link the base function to the sub dialog
        sdgOneVarGraph.SetRFunction(ucrBase.clsRsyntax.clsBaseFunction, True)
        sdgOneVarGraph.ShowDialog()
    End Sub

    Private Sub CheckDataType()
        'this checks for data types and if all the selected variable are of same type, enables facets 
        If ucrReceiverOneVarGraph.IsAllNumeric() OrElse ucrReceiverOneVarGraph.IsAllCategorical() Then
            ucrRdoFacets.Enabled = True
        Else
            ucrRdoFacets.Enabled = False
            If ucrRdoFacets.Checked Then
                ucrRdoCombine.Checked = True
            End If
        End If
    End Sub

    Private Sub ucrOneVarGraphSave_ContentsChanged() Handles ucrOneVarGraphSave.ContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub AllControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorOneVarGraph.ControlContentsChanged, ucrChkFlip.ControlContentsChanged, ucrRdoCombine.ControlContentsChanged, ucrRdoFacets.ControlContentsChanged, ucrRdoSingleGraphs.ControlContentsChanged, ucrReceiverOneVarGraph.ControlContentsChanged, ucrSelectorOneVarGraph.ControlContentsChanged
        TestOkEnabled()
    End Sub

    'When any of the ucrCore controls have been changed we update the R Code to match the contents
    Private Sub AllControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorOneVarGraph.ControlValueChanged, ucrChkFlip.ControlValueChanged, ucrRdoCombine.ControlValueChanged, ucrRdoFacets.ControlValueChanged, ucrRdoSingleGraphs.ControlValueChanged, ucrReceiverOneVarGraph.ControlValueChanged, ucrSelectorOneVarGraph.ControlValueChanged
        'The control that has changed updates the R code
        ucrChangedControl.UpdateRCode()
    End Sub
End Class