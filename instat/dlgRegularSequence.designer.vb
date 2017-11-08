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
Partial Class dlgRegularSequence
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRegularSequence))
        Me.grpSequenceDefinition = New System.Windows.Forms.GroupBox()
        Me.ucrChkDefineAsFactor = New instat.ucrCheck()
        Me.ucrNudRepeatValues = New instat.ucrNud()
        Me.ucrInputInStepsOf = New instat.ucrInputTextBox()
        Me.ucrInputTo = New instat.ucrInputTextBox()
        Me.ucrInputFrom = New instat.ucrInputTextBox()
        Me.ucrDataFrameLengthForRegularSequence = New instat.ucrDataFrameLength()
        Me.dtpSelectorB = New System.Windows.Forms.DateTimePicker()
        Me.dtpSelectorA = New System.Windows.Forms.DateTimePicker()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblTimes = New System.Windows.Forms.Label()
        Me.lblRepeatValues = New System.Windows.Forms.Label()
        Me.lblInStepsOf = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.txtGetPreview = New System.Windows.Forms.RichTextBox()
        Me.grpSequenceType = New System.Windows.Forms.GroupBox()
        Me.rdoNumeric = New System.Windows.Forms.RadioButton()
        Me.rdoDates = New System.Windows.Forms.RadioButton()
        Me.ucrPnlSequenceType = New instat.UcrPanel()
        Me.ucrNewColumnName = New instat.ucrSave()
        Me.ucrSelectDataFrameRegularSequence = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.grpSequenceDefinition.SuspendLayout()
        Me.grpSequenceType.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSequenceDefinition
        '
        Me.grpSequenceDefinition.Controls.Add(Me.ucrChkDefineAsFactor)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrNudRepeatValues)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrInputInStepsOf)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrInputTo)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrInputFrom)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrDataFrameLengthForRegularSequence)
        Me.grpSequenceDefinition.Controls.Add(Me.dtpSelectorB)
        Me.grpSequenceDefinition.Controls.Add(Me.dtpSelectorA)
        Me.grpSequenceDefinition.Controls.Add(Me.lblLength)
        Me.grpSequenceDefinition.Controls.Add(Me.lblTimes)
        Me.grpSequenceDefinition.Controls.Add(Me.lblRepeatValues)
        Me.grpSequenceDefinition.Controls.Add(Me.lblInStepsOf)
        Me.grpSequenceDefinition.Controls.Add(Me.lblTo)
        Me.grpSequenceDefinition.Controls.Add(Me.lblFrom)
        resources.ApplyResources(Me.grpSequenceDefinition, "grpSequenceDefinition")
        Me.grpSequenceDefinition.Name = "grpSequenceDefinition"
        Me.grpSequenceDefinition.TabStop = False
        Me.grpSequenceDefinition.Tag = "Sequence_definition"
        Me.grpSequenceDefinition.UseCompatibleTextRendering = True
        '
        'ucrChkDefineAsFactor
        '
        Me.ucrChkDefineAsFactor.Checked = False
        resources.ApplyResources(Me.ucrChkDefineAsFactor, "ucrChkDefineAsFactor")
        Me.ucrChkDefineAsFactor.Name = "ucrChkDefineAsFactor"
        '
        'ucrNudRepeatValues
        '
        Me.ucrNudRepeatValues.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRepeatValues.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudRepeatValues, "ucrNudRepeatValues")
        Me.ucrNudRepeatValues.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRepeatValues.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRepeatValues.Name = "ucrNudRepeatValues"
        Me.ucrNudRepeatValues.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputInStepsOf
        '
        Me.ucrInputInStepsOf.AddQuotesIfUnrecognised = True
        Me.ucrInputInStepsOf.IsMultiline = False
        Me.ucrInputInStepsOf.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputInStepsOf, "ucrInputInStepsOf")
        Me.ucrInputInStepsOf.Name = "ucrInputInStepsOf"
        '
        'ucrInputTo
        '
        Me.ucrInputTo.AddQuotesIfUnrecognised = True
        Me.ucrInputTo.IsMultiline = False
        Me.ucrInputTo.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTo, "ucrInputTo")
        Me.ucrInputTo.Name = "ucrInputTo"
        '
        'ucrInputFrom
        '
        Me.ucrInputFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputFrom.IsMultiline = False
        Me.ucrInputFrom.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFrom, "ucrInputFrom")
        Me.ucrInputFrom.Name = "ucrInputFrom"
        '
        'ucrDataFrameLengthForRegularSequence
        '
        resources.ApplyResources(Me.ucrDataFrameLengthForRegularSequence, "ucrDataFrameLengthForRegularSequence")
        Me.ucrDataFrameLengthForRegularSequence.Name = "ucrDataFrameLengthForRegularSequence"
        Me.ucrDataFrameLengthForRegularSequence.ucrDataFrameSelector = Nothing
        '
        'dtpSelectorB
        '
        resources.ApplyResources(Me.dtpSelectorB, "dtpSelectorB")
        Me.dtpSelectorB.Name = "dtpSelectorB"
        '
        'dtpSelectorA
        '
        resources.ApplyResources(Me.dtpSelectorA, "dtpSelectorA")
        Me.dtpSelectorA.Name = "dtpSelectorA"
        '
        'lblLength
        '
        resources.ApplyResources(Me.lblLength, "lblLength")
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Tag = "Length"
        '
        'lblTimes
        '
        resources.ApplyResources(Me.lblTimes, "lblTimes")
        Me.lblTimes.Name = "lblTimes"
        Me.lblTimes.Tag = "Times"
        '
        'lblRepeatValues
        '
        resources.ApplyResources(Me.lblRepeatValues, "lblRepeatValues")
        Me.lblRepeatValues.Name = "lblRepeatValues"
        Me.lblRepeatValues.Tag = "Repeat_values"
        '
        'lblInStepsOf
        '
        resources.ApplyResources(Me.lblInStepsOf, "lblInStepsOf")
        Me.lblInStepsOf.Name = "lblInStepsOf"
        Me.lblInStepsOf.Tag = "In_steps_Of"
        '
        'lblTo
        '
        resources.ApplyResources(Me.lblTo, "lblTo")
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Tag = ""
        '
        'lblFrom
        '
        resources.ApplyResources(Me.lblFrom, "lblFrom")
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Tag = "From:"
        '
        'lblPreview
        '
        resources.ApplyResources(Me.lblPreview, "lblPreview")
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Tag = "Preview"
        '
        'txtGetPreview
        '
        resources.ApplyResources(Me.txtGetPreview, "txtGetPreview")
        Me.txtGetPreview.Name = "txtGetPreview"
        '
        'grpSequenceType
        '
        Me.grpSequenceType.Controls.Add(Me.rdoNumeric)
        Me.grpSequenceType.Controls.Add(Me.rdoDates)
        Me.grpSequenceType.Controls.Add(Me.ucrPnlSequenceType)
        resources.ApplyResources(Me.grpSequenceType, "grpSequenceType")
        Me.grpSequenceType.Name = "grpSequenceType"
        Me.grpSequenceType.TabStop = False
        '
        'rdoNumeric
        '
        resources.ApplyResources(Me.rdoNumeric, "rdoNumeric")
        Me.rdoNumeric.Name = "rdoNumeric"
        Me.rdoNumeric.Tag = "Numeric"
        Me.rdoNumeric.UseVisualStyleBackColor = True
        '
        'rdoDates
        '
        resources.ApplyResources(Me.rdoDates, "rdoDates")
        Me.rdoDates.Name = "rdoDates"
        Me.rdoDates.Tag = "Dates"
        Me.rdoDates.UseVisualStyleBackColor = True
        '
        'ucrPnlSequenceType
        '
        resources.ApplyResources(Me.ucrPnlSequenceType, "ucrPnlSequenceType")
        Me.ucrPnlSequenceType.Name = "ucrPnlSequenceType"
        '
        'ucrNewColumnName
        '
        resources.ApplyResources(Me.ucrNewColumnName, "ucrNewColumnName")
        Me.ucrNewColumnName.Name = "ucrNewColumnName"
        '
        'ucrSelectDataFrameRegularSequence
        '
        Me.ucrSelectDataFrameRegularSequence.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectDataFrameRegularSequence, "ucrSelectDataFrameRegularSequence")
        Me.ucrSelectDataFrameRegularSequence.Name = "ucrSelectDataFrameRegularSequence"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.lblMessage, "lblMessage")
        Me.lblMessage.Name = "lblMessage"
        '
        'dlgRegularSequence
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.grpSequenceType)
        Me.Controls.Add(Me.ucrNewColumnName)
        Me.Controls.Add(Me.txtGetPreview)
        Me.Controls.Add(Me.grpSequenceDefinition)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.ucrSelectDataFrameRegularSequence)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRegularSequence"
        Me.ShowIcon = False
        Me.Tag = "Entry_of_regular_sequence"
        Me.grpSequenceDefinition.ResumeLayout(False)
        Me.grpSequenceDefinition.PerformLayout()
        Me.grpSequenceType.ResumeLayout(False)
        Me.grpSequenceType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpSequenceDefinition As GroupBox
    Friend WithEvents lblInStepsOf As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectDataFrameRegularSequence As ucrDataFrame
    Friend WithEvents lblPreview As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents lblTimes As Label
    Friend WithEvents lblRepeatValues As Label
    Friend WithEvents dtpSelectorA As DateTimePicker
    Friend WithEvents dtpSelectorB As DateTimePicker
    Friend WithEvents txtGetPreview As RichTextBox
    Friend WithEvents ucrDataFrameLengthForRegularSequence As ucrDataFrameLength
    Friend WithEvents ucrNewColumnName As ucrSave
    Friend WithEvents grpSequenceType As GroupBox
    Friend WithEvents rdoNumeric As RadioButton
    Friend WithEvents rdoDates As RadioButton
    Friend WithEvents ucrPnlSequenceType As UcrPanel
    Friend WithEvents ucrInputInStepsOf As ucrInputTextBox
    Friend WithEvents ucrInputTo As ucrInputTextBox
    Friend WithEvents ucrInputFrom As ucrInputTextBox
    Friend WithEvents ucrNudRepeatValues As ucrNud
    Friend WithEvents ucrChkDefineAsFactor As ucrCheck
    Friend WithEvents lblMessage As Label
End Class
