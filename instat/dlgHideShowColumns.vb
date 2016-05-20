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
Public Class dlgHideShowColumns
    Public bFirstLoad As Boolean = True
    Private Sub dlgHideShowColumns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            TestOKEnabled
            bFirstLoad = False
        End If
    End Sub

    Private Sub TestOKEnabled()
        If Not UcrReceiverHiddenColumns.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub InitialiseDialog()
        UcrReceiverHiddenColumns.Selector = UcrSelectorForHiddenColumns
        UcrReceiverHiddenColumns.SetMeAsReceiver()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_hidden_columns")
    End Sub

    Private Sub SetDefaults()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorForHiddenColumns_DataFrameChanged() Handles UcrSelectorForHiddenColumns.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & UcrSelectorForHiddenColumns.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub UcrReceiverHiddenColumns_SelectionChanged() Handles UcrReceiverHiddenColumns.SelectionChanged
        If Not UcrReceiverHiddenColumns.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("col_names", UcrReceiverHiddenColumns.GetVariableNames())
        Else
            ucrBase.clsRsyntax.RemoveParameter("col_names")
        End If
        TestOKEnabled()
    End Sub
End Class