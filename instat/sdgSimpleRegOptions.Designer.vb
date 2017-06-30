﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgSimpleRegOptions
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
        Me.tbGraphics = New System.Windows.Forms.TabPage()
        Me.tcGraphics = New System.Windows.Forms.TabControl()
        Me.tbModel = New System.Windows.Forms.TabPage()
        Me.grpRugs = New System.Windows.Forms.GroupBox()
        Me.rdoPartial = New System.Windows.Forms.RadioButton()
        Me.rdo1 = New System.Windows.Forms.RadioButton()
        Me.rdo2 = New System.Windows.Forms.RadioButton()
        Me.lblWhiteSpace = New System.Windows.Forms.Label()
        Me.lblGraphicsSignLevel = New System.Windows.Forms.Label()
        Me.grpPlotType = New System.Windows.Forms.GroupBox()
        Me.rdoContrast = New System.Windows.Forms.RadioButton()
        Me.rdoConditional = New System.Windows.Forms.RadioButton()
        Me.grpScale = New System.Windows.Forms.GroupBox()
        Me.rdoResponse = New System.Windows.Forms.RadioButton()
        Me.rdoLinear = New System.Windows.Forms.RadioButton()
        Me.tbResiduals = New System.Windows.Forms.TabPage()
        Me.grpMultiplePlots = New System.Windows.Forms.GroupBox()
        Me.rdoSixPlots = New System.Windows.Forms.RadioButton()
        Me.rdoFourPlots = New System.Windows.Forms.RadioButton()
        Me.rdoChooseIndividual = New System.Windows.Forms.RadioButton()
        Me.grpIndividualPlots = New System.Windows.Forms.GroupBox()
        Me.tbDisplay = New System.Windows.Forms.TabPage()
        Me.lblConfLevel = New System.Windows.Forms.Label()
        Me.tbRegOptions = New System.Windows.Forms.TabControl()
        Me.tbSave = New System.Windows.Forms.TabPage()
        Me.ucrNudConfLevel = New instat.ucrNud()
        Me.ucrChkPvalues = New instat.ucrCheck()
        Me.ucrChkEstimates = New instat.ucrCheck()
        Me.ucrChkConfLimits = New instat.ucrCheck()
        Me.ucrChkANOVA = New instat.ucrCheck()
        Me.ucrChkModel = New instat.ucrCheck()
        Me.ucrNudWhiteSpace = New instat.ucrNud()
        Me.ucrNudGraphicsCLevel = New instat.ucrNud()
        Me.ucrChkRugs = New instat.ucrCheck()
        Me.ucrChkJitter = New instat.ucrCheck()
        Me.ucrChkPartial = New instat.ucrCheck()
        Me.ucrChkConfIntervalband = New instat.ucrCheck()
        Me.ucrChkFittedModel = New instat.ucrCheck()
        Me.ucrPnlPartial12 = New instat.UcrPanel()
        Me.ucrPnlPlotType = New instat.UcrPanel()
        Me.ucrPnlScale = New instat.UcrPanel()
        Me.ucrPnlMutiplePlots = New instat.UcrPanel()
        Me.ucrChkResidualPlots = New instat.ucrCheck()
        Me.ucrChkCooksDistance = New instat.ucrCheck()
        Me.ucrChkResidualsFitted = New instat.ucrCheck()
        Me.ucrChkScaleLocation = New instat.ucrCheck()
        Me.ucrChkResidualsLeverage = New instat.ucrCheck()
        Me.ucrChkQQ = New instat.ucrCheck()
        Me.ucrChkCooksDistanceLeverage = New instat.ucrCheck()
        Me.ucrSaveLeverageColumnName = New instat.ucrSave()
        Me.ucrSaveStdResidualsColumnName = New instat.ucrSave()
        Me.ucrSaveResidualsColumnName = New instat.ucrSave()
        Me.ucrSaveFittedColumnName = New instat.ucrSave()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.tbGraphics.SuspendLayout()
        Me.tcGraphics.SuspendLayout()
        Me.tbModel.SuspendLayout()
        Me.grpRugs.SuspendLayout()
        Me.grpPlotType.SuspendLayout()
        Me.grpScale.SuspendLayout()
        Me.tbResiduals.SuspendLayout()
        Me.grpMultiplePlots.SuspendLayout()
        Me.grpIndividualPlots.SuspendLayout()
        Me.tbDisplay.SuspendLayout()
        Me.tbRegOptions.SuspendLayout()
        Me.tbSave.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbGraphics
        '
        Me.tbGraphics.Controls.Add(Me.tcGraphics)
        Me.tbGraphics.Location = New System.Drawing.Point(4, 22)
        Me.tbGraphics.Name = "tbGraphics"
        Me.tbGraphics.Padding = New System.Windows.Forms.Padding(3)
        Me.tbGraphics.Size = New System.Drawing.Size(313, 316)
        Me.tbGraphics.TabIndex = 1
        Me.tbGraphics.Tag = "Graphics"
        Me.tbGraphics.Text = "Graphics"
        Me.tbGraphics.UseVisualStyleBackColor = True
        '
        'tcGraphics
        '
        Me.tcGraphics.Controls.Add(Me.tbModel)
        Me.tcGraphics.Controls.Add(Me.tbResiduals)
        Me.tcGraphics.Location = New System.Drawing.Point(6, 3)
        Me.tcGraphics.Name = "tcGraphics"
        Me.tcGraphics.SelectedIndex = 0
        Me.tcGraphics.Size = New System.Drawing.Size(304, 307)
        Me.tcGraphics.TabIndex = 10
        '
        'tbModel
        '
        Me.tbModel.AccessibleDescription = ""
        Me.tbModel.Controls.Add(Me.ucrNudWhiteSpace)
        Me.tbModel.Controls.Add(Me.ucrNudGraphicsCLevel)
        Me.tbModel.Controls.Add(Me.ucrChkRugs)
        Me.tbModel.Controls.Add(Me.ucrChkJitter)
        Me.tbModel.Controls.Add(Me.ucrChkPartial)
        Me.tbModel.Controls.Add(Me.ucrChkConfIntervalband)
        Me.tbModel.Controls.Add(Me.ucrChkFittedModel)
        Me.tbModel.Controls.Add(Me.grpRugs)
        Me.tbModel.Controls.Add(Me.lblWhiteSpace)
        Me.tbModel.Controls.Add(Me.lblGraphicsSignLevel)
        Me.tbModel.Controls.Add(Me.grpPlotType)
        Me.tbModel.Controls.Add(Me.grpScale)
        Me.tbModel.Location = New System.Drawing.Point(4, 22)
        Me.tbModel.Name = "tbModel"
        Me.tbModel.Padding = New System.Windows.Forms.Padding(3)
        Me.tbModel.Size = New System.Drawing.Size(296, 281)
        Me.tbModel.TabIndex = 0
        Me.tbModel.Tag = "Model"
        Me.tbModel.Text = "Model"
        Me.tbModel.UseVisualStyleBackColor = True
        '
        'grpRugs
        '
        Me.grpRugs.Controls.Add(Me.rdoPartial)
        Me.grpRugs.Controls.Add(Me.rdo1)
        Me.grpRugs.Controls.Add(Me.rdo2)
        Me.grpRugs.Controls.Add(Me.ucrPnlPartial12)
        Me.grpRugs.Location = New System.Drawing.Point(9, 231)
        Me.grpRugs.Name = "grpRugs"
        Me.grpRugs.Size = New System.Drawing.Size(190, 46)
        Me.grpRugs.TabIndex = 7
        Me.grpRugs.TabStop = False
        '
        'rdoPartial
        '
        Me.rdoPartial.AutoSize = True
        Me.rdoPartial.Location = New System.Drawing.Point(14, 16)
        Me.rdoPartial.Name = "rdoPartial"
        Me.rdoPartial.Size = New System.Drawing.Size(54, 17)
        Me.rdoPartial.TabIndex = 38
        Me.rdoPartial.TabStop = True
        Me.rdoPartial.Tag = "Partial"
        Me.rdoPartial.Text = "Partial"
        Me.rdoPartial.UseVisualStyleBackColor = True
        '
        'rdo1
        '
        Me.rdo1.AutoSize = True
        Me.rdo1.Location = New System.Drawing.Point(88, 16)
        Me.rdo1.Name = "rdo1"
        Me.rdo1.Size = New System.Drawing.Size(31, 17)
        Me.rdo1.TabIndex = 36
        Me.rdo1.TabStop = True
        Me.rdo1.Tag = "1"
        Me.rdo1.Text = "1"
        Me.rdo1.UseVisualStyleBackColor = True
        '
        'rdo2
        '
        Me.rdo2.AutoSize = True
        Me.rdo2.Location = New System.Drawing.Point(139, 16)
        Me.rdo2.Name = "rdo2"
        Me.rdo2.Size = New System.Drawing.Size(31, 17)
        Me.rdo2.TabIndex = 37
        Me.rdo2.TabStop = True
        Me.rdo2.Tag = "2"
        Me.rdo2.Text = "2"
        Me.rdo2.UseVisualStyleBackColor = True
        '
        'lblWhiteSpace
        '
        Me.lblWhiteSpace.AutoSize = True
        Me.lblWhiteSpace.Location = New System.Drawing.Point(9, 149)
        Me.lblWhiteSpace.Name = "lblWhiteSpace"
        Me.lblWhiteSpace.Size = New System.Drawing.Size(72, 13)
        Me.lblWhiteSpace.TabIndex = 8
        Me.lblWhiteSpace.Tag = "White_Space:"
        Me.lblWhiteSpace.Text = "White Space:"
        '
        'lblGraphicsSignLevel
        '
        Me.lblGraphicsSignLevel.AutoSize = True
        Me.lblGraphicsSignLevel.Location = New System.Drawing.Point(9, 124)
        Me.lblGraphicsSignLevel.Name = "lblGraphicsSignLevel"
        Me.lblGraphicsSignLevel.Size = New System.Drawing.Size(97, 13)
        Me.lblGraphicsSignLevel.TabIndex = 2
        Me.lblGraphicsSignLevel.Tag = "Significance_Level:"
        Me.lblGraphicsSignLevel.Text = "Significance Level:"
        '
        'grpPlotType
        '
        Me.grpPlotType.Controls.Add(Me.rdoContrast)
        Me.grpPlotType.Controls.Add(Me.rdoConditional)
        Me.grpPlotType.Controls.Add(Me.ucrPnlPlotType)
        Me.grpPlotType.Location = New System.Drawing.Point(10, 33)
        Me.grpPlotType.Name = "grpPlotType"
        Me.grpPlotType.Size = New System.Drawing.Size(111, 75)
        Me.grpPlotType.TabIndex = 5
        Me.grpPlotType.TabStop = False
        Me.grpPlotType.Tag = "Plot_type"
        Me.grpPlotType.Text = "Plot type"
        '
        'rdoContrast
        '
        Me.rdoContrast.AutoSize = True
        Me.rdoContrast.Location = New System.Drawing.Point(9, 42)
        Me.rdoContrast.Name = "rdoContrast"
        Me.rdoContrast.Size = New System.Drawing.Size(64, 17)
        Me.rdoContrast.TabIndex = 33
        Me.rdoContrast.Tag = "Contrast"
        Me.rdoContrast.Text = "Contrast"
        Me.rdoContrast.UseVisualStyleBackColor = True
        '
        'rdoConditional
        '
        Me.rdoConditional.AutoSize = True
        Me.rdoConditional.Location = New System.Drawing.Point(9, 19)
        Me.rdoConditional.Name = "rdoConditional"
        Me.rdoConditional.Size = New System.Drawing.Size(77, 17)
        Me.rdoConditional.TabIndex = 32
        Me.rdoConditional.Tag = "Conditional"
        Me.rdoConditional.Text = "Conditional"
        Me.rdoConditional.UseVisualStyleBackColor = True
        '
        'grpScale
        '
        Me.grpScale.Controls.Add(Me.rdoResponse)
        Me.grpScale.Controls.Add(Me.rdoLinear)
        Me.grpScale.Controls.Add(Me.ucrPnlScale)
        Me.grpScale.Location = New System.Drawing.Point(178, 33)
        Me.grpScale.Name = "grpScale"
        Me.grpScale.Size = New System.Drawing.Size(112, 75)
        Me.grpScale.TabIndex = 6
        Me.grpScale.TabStop = False
        Me.grpScale.Tag = "Scale"
        Me.grpScale.Text = "Scale"
        '
        'rdoResponse
        '
        Me.rdoResponse.AutoSize = True
        Me.rdoResponse.Location = New System.Drawing.Point(11, 42)
        Me.rdoResponse.Name = "rdoResponse"
        Me.rdoResponse.Size = New System.Drawing.Size(73, 17)
        Me.rdoResponse.TabIndex = 30
        Me.rdoResponse.TabStop = True
        Me.rdoResponse.Tag = "Response"
        Me.rdoResponse.Text = "Response"
        Me.rdoResponse.UseVisualStyleBackColor = True
        '
        'rdoLinear
        '
        Me.rdoLinear.AutoSize = True
        Me.rdoLinear.Location = New System.Drawing.Point(11, 19)
        Me.rdoLinear.Name = "rdoLinear"
        Me.rdoLinear.Size = New System.Drawing.Size(54, 17)
        Me.rdoLinear.TabIndex = 29
        Me.rdoLinear.TabStop = True
        Me.rdoLinear.Tag = "Linear"
        Me.rdoLinear.Text = "Linear"
        Me.rdoLinear.UseVisualStyleBackColor = True
        '
        'tbResiduals
        '
        Me.tbResiduals.Controls.Add(Me.grpMultiplePlots)
        Me.tbResiduals.Controls.Add(Me.ucrChkResidualPlots)
        Me.tbResiduals.Controls.Add(Me.grpIndividualPlots)
        Me.tbResiduals.Location = New System.Drawing.Point(4, 22)
        Me.tbResiduals.Name = "tbResiduals"
        Me.tbResiduals.Padding = New System.Windows.Forms.Padding(3)
        Me.tbResiduals.Size = New System.Drawing.Size(296, 281)
        Me.tbResiduals.TabIndex = 1
        Me.tbResiduals.Tag = "Residuals"
        Me.tbResiduals.Text = "Residuals"
        Me.tbResiduals.UseVisualStyleBackColor = True
        '
        'grpMultiplePlots
        '
        Me.grpMultiplePlots.Controls.Add(Me.rdoSixPlots)
        Me.grpMultiplePlots.Controls.Add(Me.rdoFourPlots)
        Me.grpMultiplePlots.Controls.Add(Me.rdoChooseIndividual)
        Me.grpMultiplePlots.Controls.Add(Me.ucrPnlMutiplePlots)
        Me.grpMultiplePlots.Location = New System.Drawing.Point(7, 33)
        Me.grpMultiplePlots.Name = "grpMultiplePlots"
        Me.grpMultiplePlots.Size = New System.Drawing.Size(278, 78)
        Me.grpMultiplePlots.TabIndex = 0
        Me.grpMultiplePlots.TabStop = False
        Me.grpMultiplePlots.Tag = ""
        Me.grpMultiplePlots.Text = "Plots"
        '
        'rdoSixPlots
        '
        Me.rdoSixPlots.AutoSize = True
        Me.rdoSixPlots.Location = New System.Drawing.Point(173, 18)
        Me.rdoSixPlots.Name = "rdoSixPlots"
        Me.rdoSixPlots.Size = New System.Drawing.Size(65, 17)
        Me.rdoSixPlots.TabIndex = 43
        Me.rdoSixPlots.TabStop = True
        Me.rdoSixPlots.Tag = "Six Plots"
        Me.rdoSixPlots.Text = "Six Plots"
        Me.rdoSixPlots.UseVisualStyleBackColor = True
        '
        'rdoFourPlots
        '
        Me.rdoFourPlots.AutoSize = True
        Me.rdoFourPlots.Location = New System.Drawing.Point(9, 18)
        Me.rdoFourPlots.Name = "rdoFourPlots"
        Me.rdoFourPlots.Size = New System.Drawing.Size(72, 17)
        Me.rdoFourPlots.TabIndex = 42
        Me.rdoFourPlots.TabStop = True
        Me.rdoFourPlots.Tag = "Four_Plots"
        Me.rdoFourPlots.Text = "Four Plots"
        Me.rdoFourPlots.UseVisualStyleBackColor = True
        '
        'rdoChooseIndividual
        '
        Me.rdoChooseIndividual.AutoSize = True
        Me.rdoChooseIndividual.Location = New System.Drawing.Point(9, 41)
        Me.rdoChooseIndividual.Name = "rdoChooseIndividual"
        Me.rdoChooseIndividual.Size = New System.Drawing.Size(135, 17)
        Me.rdoChooseIndividual.TabIndex = 41
        Me.rdoChooseIndividual.TabStop = True
        Me.rdoChooseIndividual.Tag = ""
        Me.rdoChooseIndividual.Text = "Choose Individual Plots"
        Me.rdoChooseIndividual.UseVisualStyleBackColor = True
        '
        'grpIndividualPlots
        '
        Me.grpIndividualPlots.Controls.Add(Me.ucrChkCooksDistance)
        Me.grpIndividualPlots.Controls.Add(Me.ucrChkResidualsFitted)
        Me.grpIndividualPlots.Controls.Add(Me.ucrChkScaleLocation)
        Me.grpIndividualPlots.Controls.Add(Me.ucrChkResidualsLeverage)
        Me.grpIndividualPlots.Controls.Add(Me.ucrChkQQ)
        Me.grpIndividualPlots.Controls.Add(Me.ucrChkCooksDistanceLeverage)
        Me.grpIndividualPlots.Location = New System.Drawing.Point(5, 117)
        Me.grpIndividualPlots.Name = "grpIndividualPlots"
        Me.grpIndividualPlots.Size = New System.Drawing.Size(285, 95)
        Me.grpIndividualPlots.TabIndex = 1
        Me.grpIndividualPlots.TabStop = False
        Me.grpIndividualPlots.Tag = ""
        Me.grpIndividualPlots.Text = "Individual Plots"
        '
        'tbDisplay
        '
        Me.tbDisplay.Controls.Add(Me.ucrNudConfLevel)
        Me.tbDisplay.Controls.Add(Me.ucrChkPvalues)
        Me.tbDisplay.Controls.Add(Me.ucrChkEstimates)
        Me.tbDisplay.Controls.Add(Me.ucrChkConfLimits)
        Me.tbDisplay.Controls.Add(Me.ucrChkANOVA)
        Me.tbDisplay.Controls.Add(Me.ucrChkModel)
        Me.tbDisplay.Controls.Add(Me.lblConfLevel)
        Me.tbDisplay.Location = New System.Drawing.Point(4, 22)
        Me.tbDisplay.Name = "tbDisplay"
        Me.tbDisplay.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDisplay.Size = New System.Drawing.Size(313, 316)
        Me.tbDisplay.TabIndex = 0
        Me.tbDisplay.Tag = "Display"
        Me.tbDisplay.Text = "Display"
        Me.tbDisplay.UseVisualStyleBackColor = True
        '
        'lblConfLevel
        '
        Me.lblConfLevel.AutoSize = True
        Me.lblConfLevel.Location = New System.Drawing.Point(49, 111)
        Me.lblConfLevel.Name = "lblConfLevel"
        Me.lblConfLevel.Size = New System.Drawing.Size(93, 13)
        Me.lblConfLevel.TabIndex = 5
        Me.lblConfLevel.Tag = "Confidence_Level:"
        Me.lblConfLevel.Text = "Confidence Level:"
        '
        'tbRegOptions
        '
        Me.tbRegOptions.Controls.Add(Me.tbDisplay)
        Me.tbRegOptions.Controls.Add(Me.tbGraphics)
        Me.tbRegOptions.Controls.Add(Me.tbSave)
        Me.tbRegOptions.Location = New System.Drawing.Point(2, 3)
        Me.tbRegOptions.Name = "tbRegOptions"
        Me.tbRegOptions.SelectedIndex = 0
        Me.tbRegOptions.Size = New System.Drawing.Size(321, 342)
        Me.tbRegOptions.TabIndex = 0
        '
        'tbSave
        '
        Me.tbSave.Controls.Add(Me.ucrSaveLeverageColumnName)
        Me.tbSave.Controls.Add(Me.ucrSaveStdResidualsColumnName)
        Me.tbSave.Controls.Add(Me.ucrSaveResidualsColumnName)
        Me.tbSave.Controls.Add(Me.ucrSaveFittedColumnName)
        Me.tbSave.Location = New System.Drawing.Point(4, 22)
        Me.tbSave.Name = "tbSave"
        Me.tbSave.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSave.Size = New System.Drawing.Size(313, 316)
        Me.tbSave.TabIndex = 2
        Me.tbSave.Tag = "Save"
        Me.tbSave.Text = "Save"
        Me.tbSave.UseVisualStyleBackColor = True
        '
        'ucrNudConfLevel
        '
        Me.ucrNudConfLevel.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudConfLevel.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudConfLevel.Location = New System.Drawing.Point(147, 109)
        Me.ucrNudConfLevel.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudConfLevel.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudConfLevel.Name = "ucrNudConfLevel"
        Me.ucrNudConfLevel.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudConfLevel.TabIndex = 12
        Me.ucrNudConfLevel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkPvalues
        '
        Me.ucrChkPvalues.Checked = False
        Me.ucrChkPvalues.Location = New System.Drawing.Point(147, 35)
        Me.ucrChkPvalues.Name = "ucrChkPvalues"
        Me.ucrChkPvalues.Size = New System.Drawing.Size(113, 20)
        Me.ucrChkPvalues.TabIndex = 11
        '
        'ucrChkEstimates
        '
        Me.ucrChkEstimates.Checked = False
        Me.ucrChkEstimates.Location = New System.Drawing.Point(10, 59)
        Me.ucrChkEstimates.Name = "ucrChkEstimates"
        Me.ucrChkEstimates.Size = New System.Drawing.Size(113, 20)
        Me.ucrChkEstimates.TabIndex = 10
        '
        'ucrChkConfLimits
        '
        Me.ucrChkConfLimits.Checked = False
        Me.ucrChkConfLimits.Location = New System.Drawing.Point(10, 83)
        Me.ucrChkConfLimits.Name = "ucrChkConfLimits"
        Me.ucrChkConfLimits.Size = New System.Drawing.Size(113, 20)
        Me.ucrChkConfLimits.TabIndex = 9
        '
        'ucrChkANOVA
        '
        Me.ucrChkANOVA.Checked = False
        Me.ucrChkANOVA.Location = New System.Drawing.Point(10, 35)
        Me.ucrChkANOVA.Name = "ucrChkANOVA"
        Me.ucrChkANOVA.Size = New System.Drawing.Size(113, 20)
        Me.ucrChkANOVA.TabIndex = 8
        '
        'ucrChkModel
        '
        Me.ucrChkModel.Checked = False
        Me.ucrChkModel.Location = New System.Drawing.Point(10, 11)
        Me.ucrChkModel.Name = "ucrChkModel"
        Me.ucrChkModel.Size = New System.Drawing.Size(113, 20)
        Me.ucrChkModel.TabIndex = 7
        '
        'ucrNudWhiteSpace
        '
        Me.ucrNudWhiteSpace.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWhiteSpace.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWhiteSpace.Location = New System.Drawing.Point(112, 150)
        Me.ucrNudWhiteSpace.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWhiteSpace.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWhiteSpace.Name = "ucrNudWhiteSpace"
        Me.ucrNudWhiteSpace.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWhiteSpace.TabIndex = 29
        Me.ucrNudWhiteSpace.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudGraphicsCLevel
        '
        Me.ucrNudGraphicsCLevel.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudGraphicsCLevel.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudGraphicsCLevel.Location = New System.Drawing.Point(112, 124)
        Me.ucrNudGraphicsCLevel.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudGraphicsCLevel.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudGraphicsCLevel.Name = "ucrNudGraphicsCLevel"
        Me.ucrNudGraphicsCLevel.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudGraphicsCLevel.TabIndex = 28
        Me.ucrNudGraphicsCLevel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkRugs
        '
        Me.ucrChkRugs.Checked = False
        Me.ucrChkRugs.Location = New System.Drawing.Point(115, 179)
        Me.ucrChkRugs.Name = "ucrChkRugs"
        Me.ucrChkRugs.Size = New System.Drawing.Size(113, 20)
        Me.ucrChkRugs.TabIndex = 24
        '
        'ucrChkJitter
        '
        Me.ucrChkJitter.Checked = False
        Me.ucrChkJitter.Location = New System.Drawing.Point(10, 204)
        Me.ucrChkJitter.Name = "ucrChkJitter"
        Me.ucrChkJitter.Size = New System.Drawing.Size(97, 20)
        Me.ucrChkJitter.TabIndex = 23
        '
        'ucrChkPartial
        '
        Me.ucrChkPartial.Checked = False
        Me.ucrChkPartial.Location = New System.Drawing.Point(10, 178)
        Me.ucrChkPartial.Name = "ucrChkPartial"
        Me.ucrChkPartial.Size = New System.Drawing.Size(113, 20)
        Me.ucrChkPartial.TabIndex = 25
        '
        'ucrChkConfIntervalband
        '
        Me.ucrChkConfIntervalband.Checked = False
        Me.ucrChkConfIntervalband.Location = New System.Drawing.Point(115, 202)
        Me.ucrChkConfIntervalband.Name = "ucrChkConfIntervalband"
        Me.ucrChkConfIntervalband.Size = New System.Drawing.Size(113, 20)
        Me.ucrChkConfIntervalband.TabIndex = 22
        '
        'ucrChkFittedModel
        '
        Me.ucrChkFittedModel.Checked = False
        Me.ucrChkFittedModel.Location = New System.Drawing.Point(10, 7)
        Me.ucrChkFittedModel.Name = "ucrChkFittedModel"
        Me.ucrChkFittedModel.Size = New System.Drawing.Size(113, 20)
        Me.ucrChkFittedModel.TabIndex = 21
        '
        'ucrPnlPartial12
        '
        Me.ucrPnlPartial12.Location = New System.Drawing.Point(6, 13)
        Me.ucrPnlPartial12.Name = "ucrPnlPartial12"
        Me.ucrPnlPartial12.Size = New System.Drawing.Size(176, 27)
        Me.ucrPnlPartial12.TabIndex = 35
        '
        'ucrPnlPlotType
        '
        Me.ucrPnlPlotType.Location = New System.Drawing.Point(9, 19)
        Me.ucrPnlPlotType.Name = "ucrPnlPlotType"
        Me.ucrPnlPlotType.Size = New System.Drawing.Size(77, 43)
        Me.ucrPnlPlotType.TabIndex = 31
        '
        'ucrPnlScale
        '
        Me.ucrPnlScale.Location = New System.Drawing.Point(6, 19)
        Me.ucrPnlScale.Name = "ucrPnlScale"
        Me.ucrPnlScale.Size = New System.Drawing.Size(94, 43)
        Me.ucrPnlScale.TabIndex = 28
        '
        'ucrPnlMutiplePlots
        '
        Me.ucrPnlMutiplePlots.Location = New System.Drawing.Point(4, 12)
        Me.ucrPnlMutiplePlots.Name = "ucrPnlMutiplePlots"
        Me.ucrPnlMutiplePlots.Size = New System.Drawing.Size(279, 56)
        Me.ucrPnlMutiplePlots.TabIndex = 40
        '
        'ucrChkResidualPlots
        '
        Me.ucrChkResidualPlots.Checked = False
        Me.ucrChkResidualPlots.Location = New System.Drawing.Point(10, 7)
        Me.ucrChkResidualPlots.Name = "ucrChkResidualPlots"
        Me.ucrChkResidualPlots.Size = New System.Drawing.Size(113, 20)
        Me.ucrChkResidualPlots.TabIndex = 22
        '
        'ucrChkCooksDistance
        '
        Me.ucrChkCooksDistance.Checked = False
        Me.ucrChkCooksDistance.Location = New System.Drawing.Point(185, 67)
        Me.ucrChkCooksDistance.Name = "ucrChkCooksDistance"
        Me.ucrChkCooksDistance.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkCooksDistance.TabIndex = 41
        '
        'ucrChkResidualsFitted
        '
        Me.ucrChkResidualsFitted.Checked = False
        Me.ucrChkResidualsFitted.Location = New System.Drawing.Point(15, 21)
        Me.ucrChkResidualsFitted.Name = "ucrChkResidualsFitted"
        Me.ucrChkResidualsFitted.Size = New System.Drawing.Size(164, 20)
        Me.ucrChkResidualsFitted.TabIndex = 36
        '
        'ucrChkScaleLocation
        '
        Me.ucrChkScaleLocation.Checked = False
        Me.ucrChkScaleLocation.Location = New System.Drawing.Point(185, 44)
        Me.ucrChkScaleLocation.Name = "ucrChkScaleLocation"
        Me.ucrChkScaleLocation.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkScaleLocation.TabIndex = 40
        '
        'ucrChkResidualsLeverage
        '
        Me.ucrChkResidualsLeverage.Checked = False
        Me.ucrChkResidualsLeverage.Location = New System.Drawing.Point(15, 44)
        Me.ucrChkResidualsLeverage.Name = "ucrChkResidualsLeverage"
        Me.ucrChkResidualsLeverage.Size = New System.Drawing.Size(164, 20)
        Me.ucrChkResidualsLeverage.TabIndex = 37
        '
        'ucrChkQQ
        '
        Me.ucrChkQQ.Checked = False
        Me.ucrChkQQ.Location = New System.Drawing.Point(185, 21)
        Me.ucrChkQQ.Name = "ucrChkQQ"
        Me.ucrChkQQ.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkQQ.TabIndex = 39
        '
        'ucrChkCooksDistanceLeverage
        '
        Me.ucrChkCooksDistanceLeverage.Checked = False
        Me.ucrChkCooksDistanceLeverage.Location = New System.Drawing.Point(15, 67)
        Me.ucrChkCooksDistanceLeverage.Name = "ucrChkCooksDistanceLeverage"
        Me.ucrChkCooksDistanceLeverage.Size = New System.Drawing.Size(164, 20)
        Me.ucrChkCooksDistanceLeverage.TabIndex = 38
        '
        'ucrSaveLeverageColumnName
        '
        Me.ucrSaveLeverageColumnName.Location = New System.Drawing.Point(9, 92)
        Me.ucrSaveLeverageColumnName.Name = "ucrSaveLeverageColumnName"
        Me.ucrSaveLeverageColumnName.Size = New System.Drawing.Size(255, 24)
        Me.ucrSaveLeverageColumnName.TabIndex = 27
        '
        'ucrSaveStdResidualsColumnName
        '
        Me.ucrSaveStdResidualsColumnName.Location = New System.Drawing.Point(9, 65)
        Me.ucrSaveStdResidualsColumnName.Name = "ucrSaveStdResidualsColumnName"
        Me.ucrSaveStdResidualsColumnName.Size = New System.Drawing.Size(255, 24)
        Me.ucrSaveStdResidualsColumnName.TabIndex = 26
        '
        'ucrSaveResidualsColumnName
        '
        Me.ucrSaveResidualsColumnName.Location = New System.Drawing.Point(9, 38)
        Me.ucrSaveResidualsColumnName.Name = "ucrSaveResidualsColumnName"
        Me.ucrSaveResidualsColumnName.Size = New System.Drawing.Size(255, 24)
        Me.ucrSaveResidualsColumnName.TabIndex = 25
        '
        'ucrSaveFittedColumnName
        '
        Me.ucrSaveFittedColumnName.Location = New System.Drawing.Point(9, 11)
        Me.ucrSaveFittedColumnName.Name = "ucrSaveFittedColumnName"
        Me.ucrSaveFittedColumnName.Size = New System.Drawing.Size(255, 24)
        Me.ucrSaveFittedColumnName.TabIndex = 24
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.Location = New System.Drawing.Point(94, 347)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(142, 30)
        Me.ucrSdgButtons.TabIndex = 0
        '
        'sdgSimpleRegOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 378)
        Me.Controls.Add(Me.tbRegOptions)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgSimpleRegOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Graph_and_Display_Options"
        Me.Text = "Graph and Display Options"
        Me.tbGraphics.ResumeLayout(False)
        Me.tcGraphics.ResumeLayout(False)
        Me.tbModel.ResumeLayout(False)
        Me.tbModel.PerformLayout()
        Me.grpRugs.ResumeLayout(False)
        Me.grpRugs.PerformLayout()
        Me.grpPlotType.ResumeLayout(False)
        Me.grpPlotType.PerformLayout()
        Me.grpScale.ResumeLayout(False)
        Me.grpScale.PerformLayout()
        Me.tbResiduals.ResumeLayout(False)
        Me.grpMultiplePlots.ResumeLayout(False)
        Me.grpMultiplePlots.PerformLayout()
        Me.grpIndividualPlots.ResumeLayout(False)
        Me.tbDisplay.ResumeLayout(False)
        Me.tbDisplay.PerformLayout()
        Me.tbRegOptions.ResumeLayout(False)
        Me.tbSave.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents tbGraphics As TabPage
    Friend WithEvents nudGraphicsCLevel As NumericUpDown
    Friend WithEvents lblGraphicsSignLevel As Label
    Friend WithEvents grpMultiplePlots As GroupBox
    Friend WithEvents tbDisplay As TabPage
    Friend WithEvents lblConfLevel As Label
    Friend WithEvents chkPvalues As CheckBox
    Friend WithEvents tbRegOptions As TabControl
    Friend WithEvents tbSave As TabPage
    Friend WithEvents grpPlotType As GroupBox
    Friend WithEvents grpScale As GroupBox
    Friend WithEvents nudWhiteSpace As NumericUpDown
    Friend WithEvents lblWhiteSpace As Label
    Friend WithEvents grpRugs As GroupBox
    Friend WithEvents tcGraphics As TabControl
    Friend WithEvents tbModel As TabPage
    Friend WithEvents tbResiduals As TabPage
    Friend WithEvents grpIndividualPlots As GroupBox
    Friend WithEvents ucrChkEstimates As ucrCheck
    Friend WithEvents ucrChkConfLimits As ucrCheck
    Friend WithEvents ucrChkANOVA As ucrCheck
    Friend WithEvents ucrChkModel As ucrCheck
    Friend WithEvents ucrNudConfLevel As ucrNud
    Friend WithEvents ucrChkPvalues As ucrCheck
    Friend WithEvents ucrChkRugs As ucrCheck
    Friend WithEvents ucrChkJitter As ucrCheck
    Friend WithEvents ucrChkPartial As ucrCheck
    Friend WithEvents ucrChkConfIntervalband As ucrCheck
    Friend WithEvents ucrChkFittedModel As ucrCheck
    Friend WithEvents rdoResponse As RadioButton
    Friend WithEvents rdoLinear As RadioButton
    Friend WithEvents ucrPnlScale As UcrPanel
    Friend WithEvents rdoContrast As RadioButton
    Friend WithEvents rdoConditional As RadioButton
    Friend WithEvents ucrPnlPlotType As UcrPanel
    Friend WithEvents rdoPartial As RadioButton
    Friend WithEvents rdo1 As RadioButton
    Friend WithEvents rdo2 As RadioButton
    Friend WithEvents ucrPnlPartial12 As UcrPanel
    Friend WithEvents ucrChkResidualPlots As ucrCheck
    Friend WithEvents rdoSixPlots As RadioButton
    Friend WithEvents rdoFourPlots As RadioButton
    Friend WithEvents rdoChooseIndividual As RadioButton
    Friend WithEvents ucrPnlMutiplePlots As UcrPanel
    Friend WithEvents ucrSaveFittedColumnName As ucrSave
    Friend WithEvents ucrSaveLeverageColumnName As ucrSave
    Friend WithEvents ucrSaveStdResidualsColumnName As ucrSave
    Friend WithEvents ucrSaveResidualsColumnName As ucrSave
    Friend WithEvents ucrNudWhiteSpace As ucrNud
    Friend WithEvents ucrNudGraphicsCLevel As ucrNud
    Friend WithEvents ucrChkCooksDistance As ucrCheck
    Friend WithEvents ucrChkScaleLocation As ucrCheck
    Friend WithEvents ucrChkQQ As ucrCheck
    Friend WithEvents ucrChkResidualsLeverage As ucrCheck
    Friend WithEvents ucrChkCooksDistanceLeverage As ucrCheck
    Friend WithEvents ucrChkResidualsFitted As ucrCheck
End Class