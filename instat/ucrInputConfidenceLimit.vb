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
Public Class ucrInputConfidenceLimit
    Public Event NameChanged()
    Private Sub ucrConfidenceLimit_NameChanged() Handles ucrConfidenceLimit.NameChanged
        RaiseEvent NameChanged()
    End Sub

    Private Sub ucrInputConfidenceLimit_Load(sender As Object, e As EventArgs) Handles Me.Load
        ucrConfidenceLimit.AddItems({99.9, 99, 95, 90, 85, 80})
        ucrConfidenceLimit.SetValidationTypeAsNumeric(dcmMin:=0, bIncludeMin:=False, dcmMax:=100, bIncludeMax:=False)
        ucrConfidenceLimit.SetName(95)
    End Sub
End Class
