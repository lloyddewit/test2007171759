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
Partial Class dlgDescribeOneVariable
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.ucrBaseDescribeOneVar = New instat.ucrButtons()
        Me.ucrReceiverDescribeOneVar = New instat.ucrReceiverMultiple()
        Me.ucrSelectorDescribeOneVar = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrChkSaveResult = New instat.ucrCheck()
        Me.ucrChkCustomise = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'cmdSummaries
        '
        Me.cmdSummaries.Location = New System.Drawing.Point(305, 189)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(76, 23)
        Me.cmdSummaries.TabIndex = 4
        Me.cmdSummaries.Tag = "Summaries"
        Me.cmdSummaries.Text = "Summaries..."
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.Location = New System.Drawing.Point(261, 45)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(124, 14)
        Me.lblSelectedVariable.TabIndex = 1
        Me.lblSelectedVariable.Tag = "Selected_Variable"
        Me.lblSelectedVariable.Text = "Variable(s) to Describe:"
        '
        'ucrBaseDescribeOneVar
        '
        Me.ucrBaseDescribeOneVar.Location = New System.Drawing.Point(10, 252)
        Me.ucrBaseDescribeOneVar.Name = "ucrBaseDescribeOneVar"
        Me.ucrBaseDescribeOneVar.Size = New System.Drawing.Size(410, 52)
        Me.ucrBaseDescribeOneVar.TabIndex = 7
        '
        'ucrReceiverDescribeOneVar
        '
        Me.ucrReceiverDescribeOneVar.frmParent = Me
        Me.ucrReceiverDescribeOneVar.Location = New System.Drawing.Point(261, 60)
        Me.ucrReceiverDescribeOneVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDescribeOneVar.Name = "ucrReceiverDescribeOneVar"
        Me.ucrReceiverDescribeOneVar.Selector = Nothing
        Me.ucrReceiverDescribeOneVar.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverDescribeOneVar.TabIndex = 2
        '
        'ucrSelectorDescribeOneVar
        '
        Me.ucrSelectorDescribeOneVar.bShowHiddenColumns = False
        Me.ucrSelectorDescribeOneVar.bUseCurrentFilter = True
        Me.ucrSelectorDescribeOneVar.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorDescribeOneVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDescribeOneVar.Name = "ucrSelectorDescribeOneVar"
        Me.ucrSelectorDescribeOneVar.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDescribeOneVar.TabIndex = 0
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(10, 200)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkOmitMissing.TabIndex = 5
        '
        'ucrChkSaveResult
        '
        Me.ucrChkSaveResult.Checked = False
        Me.ucrChkSaveResult.Location = New System.Drawing.Point(10, 226)
        Me.ucrChkSaveResult.Name = "ucrChkSaveResult"
        Me.ucrChkSaveResult.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSaveResult.TabIndex = 6
        '
        'ucrChkCustomise
        '
        Me.ucrChkCustomise.Checked = False
        Me.ucrChkCustomise.Location = New System.Drawing.Point(261, 163)
        Me.ucrChkCustomise.Name = "ucrChkCustomise"
        Me.ucrChkCustomise.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkCustomise.TabIndex = 3
        '
        'dlgDescribeOneVariable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 310)
        Me.Controls.Add(Me.ucrChkCustomise)
        Me.Controls.Add(Me.ucrChkSaveResult)
        Me.Controls.Add(Me.ucrChkOmitMissing)
        Me.Controls.Add(Me.ucrSelectorDescribeOneVar)
        Me.Controls.Add(Me.ucrReceiverDescribeOneVar)
        Me.Controls.Add(Me.ucrBaseDescribeOneVar)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.cmdSummaries)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescribeOneVariable"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Describe_One_Variable"
        Me.Text = "Describe One Variable"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents ucrBaseDescribeOneVar As ucrButtons
    Friend WithEvents ucrReceiverDescribeOneVar As ucrReceiverMultiple
    Friend WithEvents ucrSelectorDescribeOneVar As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrChkSaveResult As ucrCheck
    Friend WithEvents ucrChkOmitMissing As ucrCheck
    Friend WithEvents ucrChkCustomise As ucrCheck
End Class