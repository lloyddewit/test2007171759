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

Public Class dlgOneVarCompareModels

    Public bfirstload As Boolean = True


    Private Sub dlgOneVarCompareModels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bfirstload Then
            InitialiseDialog()
            SetDefaults()
            bfirstload = False
        Else
            ReopenDialog()
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        'sdgOneVarCompareModels.InitaliseDialog()
        'UcrBase.clsRsyntax.SetFunction("fitdist")
        'ucrBase.iHelpTopicID = 
        ucrBase.clsRsyntax.iCallType = 2
        UcrReceiver.Selector = ucrSelectorOneVarCompModels
        UcrReceiver.SetMeAsReceiver()
    End Sub

    Private Sub SetDefaults()
        ucrSelectorOneVarCompModels.Reset()
        ucrSelectorOneVarCompModels.Focus()
        'sdgOneVarCompareModels.setdefaults()
        TestOKEnabled()
        'ucrSelectorOneVarCompModels.SetItemType("") I wish to compare models, but only models for one variable!
    End Sub

    Private Sub ReopenDialog()
    End Sub

    Private Sub TestOKEnabled()
        If Not UcrReceiver.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrSelectorOneVarCompModels_DataFrameChanged() Handles ucrSelectorOneVarCompModels.DataFrameChanged
    End Sub

    Private Sub UcrReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles UcrReceiver.SelectionChanged
        TestOKEnabled()
    End Sub

    Private Sub cmdDisplayObjects_Click(sender As Object, e As EventArgs) Handles cmdDisplayObjects.Click
        sdgOneVarCompareModels.ShowDialog()
        EnableOptions()
    End Sub

    Private Sub EnableOptions()
        If Not UcrReceiver.IsEmpty Then
            cmdDisplayObjects.Enabled = True
        Else
            cmdDisplayObjects.Enabled = False
        End If
    End Sub

End Class