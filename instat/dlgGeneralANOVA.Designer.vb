﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgGeneralANOVA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.ucrBase = New instat.ucrButtons()
        Me.rdoAnalysis = New System.Windows.Forms.RadioButton()
        Me.rdoReplicates = New System.Windows.Forms.RadioButton()
        Me.ucrSelectorGeneralANOVA = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverLayout = New instat.ucrReceiverSingle()
        Me.ucrReceiverTreatmentStructure = New instat.ucrReceiverSingle()
        Me.ucrReceiverYVariable = New instat.ucrReceiverSingle()
        Me.lblYVariable = New System.Windows.Forms.Label()
        Me.lblTreatmentFactor = New System.Windows.Forms.Label()
        Me.lblLayout = New System.Windows.Forms.Label()
        Me.chkSaveModel = New System.Windows.Forms.CheckBox()
        Me.ucrModelName = New instat.ucrVariableName()
        Me.cmdGeneralANOVAOptions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(2, 295)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 51)
        Me.ucrBase.TabIndex = 0
        '
        'rdoAnalysis
        '
        Me.rdoAnalysis.AutoSize = True
        Me.rdoAnalysis.Location = New System.Drawing.Point(46, 13)
        Me.rdoAnalysis.Name = "rdoAnalysis"
        Me.rdoAnalysis.Size = New System.Drawing.Size(63, 17)
        Me.rdoAnalysis.TabIndex = 1
        Me.rdoAnalysis.TabStop = True
        Me.rdoAnalysis.Tag = "Analysis"
        Me.rdoAnalysis.Text = "Analysis"
        Me.rdoAnalysis.UseVisualStyleBackColor = True
        '
        'rdoReplicates
        '
        Me.rdoReplicates.AutoSize = True
        Me.rdoReplicates.Location = New System.Drawing.Point(231, 13)
        Me.rdoReplicates.Name = "rdoReplicates"
        Me.rdoReplicates.Size = New System.Drawing.Size(75, 17)
        Me.rdoReplicates.TabIndex = 2
        Me.rdoReplicates.TabStop = True
        Me.rdoReplicates.Tag = "Replicates"
        Me.rdoReplicates.Text = "Replicates"
        Me.rdoReplicates.UseVisualStyleBackColor = True
        '
        'ucrSelectorGeneralANOVA
        '
        Me.ucrSelectorGeneralANOVA.Location = New System.Drawing.Point(2, 46)
        Me.ucrSelectorGeneralANOVA.Name = "ucrSelectorGeneralANOVA"
        Me.ucrSelectorGeneralANOVA.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorGeneralANOVA.TabIndex = 3
        '
        'ucrReceiverLayout
        '
        Me.ucrReceiverLayout.Location = New System.Drawing.Point(292, 188)
        Me.ucrReceiverLayout.Name = "ucrReceiverLayout"
        Me.ucrReceiverLayout.Selector = Nothing
        Me.ucrReceiverLayout.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverLayout.TabIndex = 4
        '
        'ucrReceiverTreatmentStructure
        '
        Me.ucrReceiverTreatmentStructure.Location = New System.Drawing.Point(292, 139)
        Me.ucrReceiverTreatmentStructure.Name = "ucrReceiverTreatmentStructure"
        Me.ucrReceiverTreatmentStructure.Selector = Nothing
        Me.ucrReceiverTreatmentStructure.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverTreatmentStructure.TabIndex = 5
        '
        'ucrReceiverYVariable
        '
        Me.ucrReceiverYVariable.Location = New System.Drawing.Point(292, 89)
        Me.ucrReceiverYVariable.Name = "ucrReceiverYVariable"
        Me.ucrReceiverYVariable.Selector = Nothing
        Me.ucrReceiverYVariable.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverYVariable.TabIndex = 6
        '
        'lblYVariable
        '
        Me.lblYVariable.AutoSize = True
        Me.lblYVariable.Location = New System.Drawing.Point(297, 77)
        Me.lblYVariable.Name = "lblYVariable"
        Me.lblYVariable.Size = New System.Drawing.Size(54, 13)
        Me.lblYVariable.TabIndex = 7
        Me.lblYVariable.Tag = "Y_variable"
        Me.lblYVariable.Text = "Y variable"
        '
        'lblTreatmentFactor
        '
        Me.lblTreatmentFactor.AutoSize = True
        Me.lblTreatmentFactor.Location = New System.Drawing.Point(298, 127)
        Me.lblTreatmentFactor.Name = "lblTreatmentFactor"
        Me.lblTreatmentFactor.Size = New System.Drawing.Size(99, 13)
        Me.lblTreatmentFactor.TabIndex = 8
        Me.lblTreatmentFactor.Tag = "Treatment_structure"
        Me.lblTreatmentFactor.Text = "Treatment structure"
        '
        'lblLayout
        '
        Me.lblLayout.AutoSize = True
        Me.lblLayout.Location = New System.Drawing.Point(298, 176)
        Me.lblLayout.Name = "lblLayout"
        Me.lblLayout.Size = New System.Drawing.Size(39, 13)
        Me.lblLayout.TabIndex = 9
        Me.lblLayout.Tag = "Layout"
        Me.lblLayout.Text = "Layout"
        '
        'chkSaveModel
        '
        Me.chkSaveModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkSaveModel.Location = New System.Drawing.Point(3, 248)
        Me.chkSaveModel.Name = "chkSaveModel"
        Me.chkSaveModel.Size = New System.Drawing.Size(104, 24)
        Me.chkSaveModel.TabIndex = 10
        Me.chkSaveModel.Tag = "Save_Model"
        Me.chkSaveModel.Text = "Save Model"
        Me.chkSaveModel.UseVisualStyleBackColor = True
        '
        'ucrModelName
        '
        Me.ucrModelName.Location = New System.Drawing.Point(108, 246)
        Me.ucrModelName.Name = "ucrModelName"
        Me.ucrModelName.Size = New System.Drawing.Size(149, 23)
        Me.ucrModelName.TabIndex = 11
        '
        'cmdGeneralANOVAOptions
        '
        Me.cmdGeneralANOVAOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGeneralANOVAOptions.Location = New System.Drawing.Point(263, 246)
        Me.cmdGeneralANOVAOptions.Name = "cmdGeneralANOVAOptions"
        Me.cmdGeneralANOVAOptions.Size = New System.Drawing.Size(149, 23)
        Me.cmdGeneralANOVAOptions.TabIndex = 12
        Me.cmdGeneralANOVAOptions.Tag = "General_ANOVA_Options..."
        Me.cmdGeneralANOVAOptions.Text = "General ANOVA Options..."
        Me.cmdGeneralANOVAOptions.UseVisualStyleBackColor = True
        '
        'dlgGeneralANOVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 347)
        Me.Controls.Add(Me.chkSaveModel)
        Me.Controls.Add(Me.ucrModelName)
        Me.Controls.Add(Me.cmdGeneralANOVAOptions)
        Me.Controls.Add(Me.lblLayout)
        Me.Controls.Add(Me.lblTreatmentFactor)
        Me.Controls.Add(Me.lblYVariable)
        Me.Controls.Add(Me.ucrReceiverYVariable)
        Me.Controls.Add(Me.ucrReceiverTreatmentStructure)
        Me.Controls.Add(Me.ucrReceiverLayout)
        Me.Controls.Add(Me.ucrSelectorGeneralANOVA)
        Me.Controls.Add(Me.rdoReplicates)
        Me.Controls.Add(Me.rdoAnalysis)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgGeneralANOVA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "General_ANOVA"
        Me.Text = "General ANOVA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents rdoAnalysis As RadioButton
    Friend WithEvents rdoReplicates As RadioButton
    Friend WithEvents ucrSelectorGeneralANOVA As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverLayout As ucrReceiverSingle
    Friend WithEvents ucrReceiverTreatmentStructure As ucrReceiverSingle
    Friend WithEvents ucrReceiverYVariable As ucrReceiverSingle
    Friend WithEvents lblYVariable As Label
    Friend WithEvents lblTreatmentFactor As Label
    Friend WithEvents lblLayout As Label
    Friend WithEvents chkSaveModel As CheckBox
    Friend WithEvents ucrModelName As ucrVariableName
    Friend WithEvents cmdGeneralANOVAOptions As Button
End Class