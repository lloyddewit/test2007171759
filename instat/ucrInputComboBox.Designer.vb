﻿' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrInputComboBox
    Inherits instat.ucrInput

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrInputComboBox))
        Me.cboInput = New System.Windows.Forms.ComboBox()
        Me.mnuRightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuRightClickCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRightClick.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboInput
        '
        Me.cboInput.ContextMenuStrip = Me.mnuRightClick
        resources.ApplyResources(Me.cboInput, "cboInput")
        Me.cboInput.FormattingEnabled = True
        Me.cboInput.Name = "cboInput"
        '
        'mnuRightClick
        '
        Me.mnuRightClick.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuRightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRightClickCopy})
        Me.mnuRightClick.Name = "mnuRightClick"
        resources.ApplyResources(Me.mnuRightClick, "mnuRightClick")
        '
        'mnuRightClickCopy
        '
        Me.mnuRightClickCopy.Name = "mnuRightClickCopy"
        resources.ApplyResources(Me.mnuRightClickCopy, "mnuRightClickCopy")
        '
        'ucrInputComboBox
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cboInput)
        Me.Name = "ucrInputComboBox"
        Me.mnuRightClick.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboInput As ComboBox
    Friend WithEvents mnuRightClick As ContextMenuStrip
    Friend WithEvents mnuRightClickCopy As ToolStripMenuItem
End Class
