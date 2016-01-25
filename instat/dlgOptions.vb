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

Imports System.Globalization
Imports System.Threading
Imports instat.Translations

Public Class dlgOptions
    Public StrComment As String

    Private Sub dlgOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        txtComment.Text = "code generated by the dialog"
    End Sub
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        rdoEnglish.Checked = False
        rdoFrench.Checked = False
        rdoKiswahili.Checked = False
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        StrComment = txtComment.Text
        If Not (rdoKiswahili.Checked And rdoFrench.Checked And rdoFrench.Checked) Then
            Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
            autoTranslate(frmMain)
            autoTranslate(Me)
            Me.Close()
        End If

        If rdoEnglish.Checked = True Then
            Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
            autoTranslate(frmMain)
            autoTranslate(Me)
            rdoEnglish.Checked = False
            rdoFrench.Checked = False
            rdoKiswahili.Checked = False
            Me.Close()
        End If
        If rdoFrench.Checked = True Then
            Thread.CurrentThread.CurrentCulture = New CultureInfo("fr-FR")
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("fr-FR")
            autoTranslate(frmMain)
            autoTranslate(Me)
            Me.Close()
        End If
        If rdoKiswahili.Checked = True Then
            Thread.CurrentThread.CurrentCulture = New CultureInfo("sw-KE")
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("sw-KE")
            autoTranslate(frmMain)
            autoTranslate(Me)
            Me.Close()
        End If
    End Sub

    Private Sub cmdApply_Click(sender As Object, e As EventArgs) Handles cmdApply.Click
        StrComment = txtComment.Text
        If Not (rdoFrench.Checked And rdoKiswahili.Checked) Then
            Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
            autoTranslate(frmMain)
            autoTranslate(Me)
        End If

        If rdoEnglish.Checked = True Then
            Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
            autoTranslate(frmMain)
            autoTranslate(Me)
        End If

        If rdoFrench.Checked = True Then
            Thread.CurrentThread.CurrentCulture = New CultureInfo("fr-FR")
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("fr-FR")
            autoTranslate(frmMain)
            autoTranslate(Me)
        End If

        If rdoKiswahili.Checked = True Then
            Thread.CurrentThread.CurrentCulture = New CultureInfo("sw-KE")
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("sw-KE")
            autoTranslate(frmMain)
            autoTranslate(Me)
        End If
    End Sub
End Class