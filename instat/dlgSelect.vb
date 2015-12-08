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
Public Class dlgSelect
    Private Sub dlgSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        rdoSelectbycondition.Checked = True
        grpCondition.Visible = True
        grpFactor.Visible = False
    End Sub

    Private Sub rdoSelectbycondition_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSelectbycondition.CheckedChanged
        If rdoSelectbycondition.Checked = True Then
            grpCondition.Visible = True
        Else
            grpCondition.Visible = False
        End If
    End Sub

    Private Sub rdoSelectbyfactor_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSelectbyfactor.CheckedChanged
        If rdoSelectbyfactor.Checked = True Then
            grpFactor.Visible = True
        Else
            grpFactor.Visible = False
        End If
    End Sub
End Class