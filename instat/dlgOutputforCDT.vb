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


Public Class dlgOutputforCDT
    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$output_for_CDT")
        ucrBase.clsRsyntax.iCallType = 1
    End Sub


    Private Sub txtFilename_Leave(sender As Object, e As EventArgs)
        ucrBase.clsRsyntax.AddParameter("Filename", Chr(34) & ucrInputFileName.Text & Chr(34))

    End Sub


    Private Sub txtInterestedVariables_TextChanged(sender As Object, e As EventArgs)
        ucrBase.clsRsyntax.AddParameter("Interested_vaiables", Chr(34) & ucrInputInterestedVariables.Text & Chr(34))

    End Sub
End Class


