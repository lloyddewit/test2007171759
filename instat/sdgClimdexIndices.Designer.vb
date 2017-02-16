﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgClimdexIndices
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
        Me.components = New System.ComponentModel.Container()
        Me.ucrChkPrecExceed10mm = New instat.ucrCheck()
        Me.ucrChkMaxDrySpell = New instat.ucrCheck()
        Me.ucrChkPrecExceedSpecifiedA = New instat.ucrCheck()
        Me.ucrChkPrecExceed20mm = New instat.ucrCheck()
        Me.ucrChkTotalDailyPrec = New instat.ucrCheck()
        Me.ucrChkPrecExceed99Percent = New instat.ucrCheck()
        Me.ucrChkPrecExceed95Percent = New instat.ucrCheck()
        Me.ucrChkMaxWetSpell = New instat.ucrCheck()
        Me.ucrChkSimplePrecII = New instat.ucrCheck()
        Me.ttClimdexIndices = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.tbClimdex = New System.Windows.Forms.TabControl()
        Me.TbSettings = New System.Windows.Forms.TabPage()
        Me.ucrChkCenterMean = New instat.ucrCheck()
        Me.ucrChkSpellDISpanYear = New instat.ucrCheck()
        Me.ucrChkNHemisphere = New instat.ucrCheck()
        Me.ucrChkMaxSpellSpanYears = New instat.ucrCheck()
        Me.lblBaseRange = New System.Windows.Forms.Label()
        Me.ucrMultipleInputBaseRange = New instat.ucrMultipleInput()
        Me.ucrNudN = New instat.ucrNud()
        Me.ucrNudThreshold = New instat.ucrNud()
        Me.ucrNudMinBaseData = New instat.ucrNud()
        Me.lblFreq = New System.Windows.Forms.Label()
        Me.lblMinBaseData = New System.Windows.Forms.Label()
        Me.ucrInputFreq = New instat.ucrInputComboBox()
        Me.ucrMultipleInputTempQtiles = New instat.ucrMultipleInput()
        Me.ucrMultipleInputPrecQtiles = New instat.ucrMultipleInput()
        Me.lblPrecQuantiles = New System.Windows.Forms.Label()
        Me.lblTempQuantiles = New System.Windows.Forms.Label()
        Me.grpMaxMissingDays = New System.Windows.Forms.GroupBox()
        Me.lblMonthly = New System.Windows.Forms.Label()
        Me.lblAnnual = New System.Windows.Forms.Label()
        Me.ucrNudMothlyMissingDays = New instat.ucrNud()
        Me.ucrNudAnnualMissingDays = New instat.ucrNud()
        Me.lblN = New System.Windows.Forms.Label()
        Me.tbPrecipitation = New System.Windows.Forms.TabPage()
        Me.grpPrecAnnual = New System.Windows.Forms.GroupBox()
        Me.grpPrecAnnualMonthly = New System.Windows.Forms.GroupBox()
        Me.ucrChkMonthlyMax5dayPrec = New instat.ucrCheck()
        Me.ucrChkMonthlyMax1dayPrec = New instat.ucrCheck()
        Me.tbTemperature = New System.Windows.Forms.TabPage()
        Me.grpTmaxTmin = New System.Windows.Forms.GroupBox()
        Me.grpTmaxTminAnnualMonthly = New System.Windows.Forms.GroupBox()
        Me.ucrChkMeanDiurnalTempRange = New instat.ucrCheck()
        Me.grpTmaxTminAnnual = New System.Windows.Forms.GroupBox()
        Me.ucrChkGrowingSeasonLength = New instat.ucrCheck()
        Me.grpTmax = New System.Windows.Forms.GroupBox()
        Me.grpTmaxAnnualMonthly = New System.Windows.Forms.GroupBox()
        Me.ucrChkMonthlyMaxDailyTMax = New instat.ucrCheck()
        Me.ucrChkTmaxAbove90Percent = New instat.ucrCheck()
        Me.ucrChkTmaxBelow10Percent = New instat.ucrCheck()
        Me.ucrChkMonthlyMinDailyTMax = New instat.ucrCheck()
        Me.grpTmaxAnnual = New System.Windows.Forms.GroupBox()
        Me.ucrChkSummerDays = New instat.ucrCheck()
        Me.ucrChkWarmSpellDI = New instat.ucrCheck()
        Me.ucrChkIcingDays = New instat.ucrCheck()
        Me.grpTmin = New System.Windows.Forms.GroupBox()
        Me.grpTminAnnualMonthly = New System.Windows.Forms.GroupBox()
        Me.ucrChkMonthlyMinDailyTMin = New instat.ucrCheck()
        Me.ucrChkMonthlyMaxDailyTMin = New instat.ucrCheck()
        Me.ucrChkTminBelow10Percent = New instat.ucrCheck()
        Me.ucrChkTminAbove90Percent = New instat.ucrCheck()
        Me.grpTminAnnual = New System.Windows.Forms.GroupBox()
        Me.ucrChkColdSpellDI = New instat.ucrCheck()
        Me.ucrChkTropicalNights = New instat.ucrCheck()
        Me.ucrChkFrostDays = New instat.ucrCheck()
        Me.ucrChkSave = New instat.ucrCheck()
        Me.ucrButtonsClimdexIndices = New instat.ucrButtonsSubdialogue()
        Me.tbClimdex.SuspendLayout()
        Me.TbSettings.SuspendLayout()
        Me.grpMaxMissingDays.SuspendLayout()
        Me.tbPrecipitation.SuspendLayout()
        Me.grpPrecAnnual.SuspendLayout()
        Me.grpPrecAnnualMonthly.SuspendLayout()
        Me.tbTemperature.SuspendLayout()
        Me.grpTmaxTmin.SuspendLayout()
        Me.grpTmaxTminAnnualMonthly.SuspendLayout()
        Me.grpTmaxTminAnnual.SuspendLayout()
        Me.grpTmax.SuspendLayout()
        Me.grpTmaxAnnualMonthly.SuspendLayout()
        Me.grpTmaxAnnual.SuspendLayout()
        Me.grpTmin.SuspendLayout()
        Me.grpTminAnnualMonthly.SuspendLayout()
        Me.grpTminAnnual.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrChkPrecExceed10mm
        '
        Me.ucrChkPrecExceed10mm.Checked = False
        Me.ucrChkPrecExceed10mm.Location = New System.Drawing.Point(7, 156)
        Me.ucrChkPrecExceed10mm.Name = "ucrChkPrecExceed10mm"
        Me.ucrChkPrecExceed10mm.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkPrecExceed10mm.TabIndex = 83
        '
        'ucrChkMaxDrySpell
        '
        Me.ucrChkMaxDrySpell.Checked = False
        Me.ucrChkMaxDrySpell.Location = New System.Drawing.Point(7, 180)
        Me.ucrChkMaxDrySpell.Name = "ucrChkMaxDrySpell"
        Me.ucrChkMaxDrySpell.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkMaxDrySpell.TabIndex = 82
        '
        'ucrChkPrecExceedSpecifiedA
        '
        Me.ucrChkPrecExceedSpecifiedA.Checked = False
        Me.ucrChkPrecExceedSpecifiedA.Location = New System.Drawing.Point(7, 204)
        Me.ucrChkPrecExceedSpecifiedA.Name = "ucrChkPrecExceedSpecifiedA"
        Me.ucrChkPrecExceedSpecifiedA.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkPrecExceedSpecifiedA.TabIndex = 81
        '
        'ucrChkPrecExceed20mm
        '
        Me.ucrChkPrecExceed20mm.Checked = False
        Me.ucrChkPrecExceed20mm.Location = New System.Drawing.Point(7, 43)
        Me.ucrChkPrecExceed20mm.Name = "ucrChkPrecExceed20mm"
        Me.ucrChkPrecExceed20mm.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkPrecExceed20mm.TabIndex = 80
        '
        'ucrChkTotalDailyPrec
        '
        Me.ucrChkTotalDailyPrec.Checked = False
        Me.ucrChkTotalDailyPrec.Location = New System.Drawing.Point(7, 132)
        Me.ucrChkTotalDailyPrec.Name = "ucrChkTotalDailyPrec"
        Me.ucrChkTotalDailyPrec.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkTotalDailyPrec.TabIndex = 79
        '
        'ucrChkPrecExceed99Percent
        '
        Me.ucrChkPrecExceed99Percent.Checked = False
        Me.ucrChkPrecExceed99Percent.Location = New System.Drawing.Point(7, 90)
        Me.ucrChkPrecExceed99Percent.Name = "ucrChkPrecExceed99Percent"
        Me.ucrChkPrecExceed99Percent.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkPrecExceed99Percent.TabIndex = 78
        '
        'ucrChkPrecExceed95Percent
        '
        Me.ucrChkPrecExceed95Percent.Checked = False
        Me.ucrChkPrecExceed95Percent.Location = New System.Drawing.Point(7, 114)
        Me.ucrChkPrecExceed95Percent.Name = "ucrChkPrecExceed95Percent"
        Me.ucrChkPrecExceed95Percent.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkPrecExceed95Percent.TabIndex = 77
        '
        'ucrChkMaxWetSpell
        '
        Me.ucrChkMaxWetSpell.Checked = False
        Me.ucrChkMaxWetSpell.Location = New System.Drawing.Point(7, 66)
        Me.ucrChkMaxWetSpell.Name = "ucrChkMaxWetSpell"
        Me.ucrChkMaxWetSpell.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkMaxWetSpell.TabIndex = 76
        '
        'ucrChkSimplePrecII
        '
        Me.ucrChkSimplePrecII.Checked = False
        Me.ucrChkSimplePrecII.Location = New System.Drawing.Point(7, 19)
        Me.ucrChkSimplePrecII.Name = "ucrChkSimplePrecII"
        Me.ucrChkSimplePrecII.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkSimplePrecII.TabIndex = 74
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(13, 136)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(54, 13)
        Me.lblThreshold.TabIndex = 1
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Threshold"
        '
        'tbClimdex
        '
        Me.tbClimdex.Controls.Add(Me.TbSettings)
        Me.tbClimdex.Controls.Add(Me.tbPrecipitation)
        Me.tbClimdex.Controls.Add(Me.tbTemperature)
        Me.tbClimdex.Location = New System.Drawing.Point(8, 6)
        Me.tbClimdex.Name = "tbClimdex"
        Me.tbClimdex.SelectedIndex = 0
        Me.tbClimdex.Size = New System.Drawing.Size(476, 499)
        Me.tbClimdex.TabIndex = 7
        '
        'TbSettings
        '
        Me.TbSettings.Controls.Add(Me.ucrChkCenterMean)
        Me.TbSettings.Controls.Add(Me.ucrChkSpellDISpanYear)
        Me.TbSettings.Controls.Add(Me.ucrChkNHemisphere)
        Me.TbSettings.Controls.Add(Me.ucrChkMaxSpellSpanYears)
        Me.TbSettings.Controls.Add(Me.lblBaseRange)
        Me.TbSettings.Controls.Add(Me.ucrMultipleInputBaseRange)
        Me.TbSettings.Controls.Add(Me.ucrNudN)
        Me.TbSettings.Controls.Add(Me.ucrNudThreshold)
        Me.TbSettings.Controls.Add(Me.ucrNudMinBaseData)
        Me.TbSettings.Controls.Add(Me.lblFreq)
        Me.TbSettings.Controls.Add(Me.lblMinBaseData)
        Me.TbSettings.Controls.Add(Me.ucrInputFreq)
        Me.TbSettings.Controls.Add(Me.ucrMultipleInputTempQtiles)
        Me.TbSettings.Controls.Add(Me.ucrMultipleInputPrecQtiles)
        Me.TbSettings.Controls.Add(Me.lblPrecQuantiles)
        Me.TbSettings.Controls.Add(Me.lblTempQuantiles)
        Me.TbSettings.Controls.Add(Me.grpMaxMissingDays)
        Me.TbSettings.Controls.Add(Me.lblN)
        Me.TbSettings.Controls.Add(Me.lblThreshold)
        Me.TbSettings.Location = New System.Drawing.Point(4, 22)
        Me.TbSettings.Name = "TbSettings"
        Me.TbSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.TbSettings.Size = New System.Drawing.Size(468, 473)
        Me.TbSettings.TabIndex = 0
        Me.TbSettings.Tag = ""
        Me.TbSettings.Text = "Settings"
        Me.TbSettings.UseVisualStyleBackColor = True
        '
        'ucrChkCenterMean
        '
        Me.ucrChkCenterMean.Checked = False
        Me.ucrChkCenterMean.Location = New System.Drawing.Point(284, 187)
        Me.ucrChkCenterMean.Name = "ucrChkCenterMean"
        Me.ucrChkCenterMean.Size = New System.Drawing.Size(171, 20)
        Me.ucrChkCenterMean.TabIndex = 49
        '
        'ucrChkSpellDISpanYear
        '
        Me.ucrChkSpellDISpanYear.Checked = False
        Me.ucrChkSpellDISpanYear.Location = New System.Drawing.Point(13, 218)
        Me.ucrChkSpellDISpanYear.Name = "ucrChkSpellDISpanYear"
        Me.ucrChkSpellDISpanYear.Size = New System.Drawing.Size(233, 20)
        Me.ucrChkSpellDISpanYear.TabIndex = 48
        '
        'ucrChkNHemisphere
        '
        Me.ucrChkNHemisphere.Checked = False
        Me.ucrChkNHemisphere.Location = New System.Drawing.Point(13, 107)
        Me.ucrChkNHemisphere.Name = "ucrChkNHemisphere"
        Me.ucrChkNHemisphere.Size = New System.Drawing.Size(212, 20)
        Me.ucrChkNHemisphere.TabIndex = 47
        '
        'ucrChkMaxSpellSpanYears
        '
        Me.ucrChkMaxSpellSpanYears.Checked = False
        Me.ucrChkMaxSpellSpanYears.Location = New System.Drawing.Point(13, 187)
        Me.ucrChkMaxSpellSpanYears.Name = "ucrChkMaxSpellSpanYears"
        Me.ucrChkMaxSpellSpanYears.Size = New System.Drawing.Size(233, 20)
        Me.ucrChkMaxSpellSpanYears.TabIndex = 46
        '
        'lblBaseRange
        '
        Me.lblBaseRange.AutoSize = True
        Me.lblBaseRange.Location = New System.Drawing.Point(13, 6)
        Me.lblBaseRange.Name = "lblBaseRange"
        Me.lblBaseRange.Size = New System.Drawing.Size(66, 13)
        Me.lblBaseRange.TabIndex = 45
        Me.lblBaseRange.Tag = ""
        Me.lblBaseRange.Text = "Base Range"
        '
        'ucrMultipleInputBaseRange
        '
        Me.ucrMultipleInputBaseRange.Location = New System.Drawing.Point(13, 23)
        Me.ucrMultipleInputBaseRange.Name = "ucrMultipleInputBaseRange"
        Me.ucrMultipleInputBaseRange.Size = New System.Drawing.Size(150, 29)
        Me.ucrMultipleInputBaseRange.TabIndex = 44
        '
        'ucrNudN
        '
        Me.ucrNudN.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudN.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudN.Location = New System.Drawing.Point(379, 158)
        Me.ucrNudN.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudN.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudN.Name = "ucrNudN"
        Me.ucrNudN.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudN.TabIndex = 43
        Me.ucrNudN.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudThreshold
        '
        Me.ucrNudThreshold.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThreshold.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudThreshold.Location = New System.Drawing.Point(93, 132)
        Me.ucrNudThreshold.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudThreshold.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThreshold.Name = "ucrNudThreshold"
        Me.ucrNudThreshold.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudThreshold.TabIndex = 42
        Me.ucrNudThreshold.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMinBaseData
        '
        Me.ucrNudMinBaseData.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinBaseData.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinBaseData.Location = New System.Drawing.Point(210, 158)
        Me.ucrNudMinBaseData.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinBaseData.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinBaseData.Name = "ucrNudMinBaseData"
        Me.ucrNudMinBaseData.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMinBaseData.TabIndex = 41
        Me.ucrNudMinBaseData.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblFreq
        '
        Me.lblFreq.AutoSize = True
        Me.lblFreq.Location = New System.Drawing.Point(284, 6)
        Me.lblFreq.Name = "lblFreq"
        Me.lblFreq.Size = New System.Drawing.Size(57, 13)
        Me.lblFreq.TabIndex = 36
        Me.lblFreq.Tag = "Frequency"
        Me.lblFreq.Text = "Frequency"
        '
        'lblMinBaseData
        '
        Me.lblMinBaseData.AutoSize = True
        Me.lblMinBaseData.Location = New System.Drawing.Point(13, 162)
        Me.lblMinBaseData.Name = "lblMinBaseData"
        Me.lblMinBaseData.Size = New System.Drawing.Size(193, 13)
        Me.lblMinBaseData.TabIndex = 34
        Me.lblMinBaseData.Tag = "Minimum_Fraction_of_Base_Data_ Present"
        Me.lblMinBaseData.Text = "Minimum Fraction of Base Data Present"
        '
        'ucrInputFreq
        '
        Me.ucrInputFreq.IsReadOnly = False
        Me.ucrInputFreq.Location = New System.Drawing.Point(284, 27)
        Me.ucrInputFreq.Name = "ucrInputFreq"
        Me.ucrInputFreq.Size = New System.Drawing.Size(145, 21)
        Me.ucrInputFreq.TabIndex = 24
        '
        'ucrMultipleInputTempQtiles
        '
        Me.ucrMultipleInputTempQtiles.Location = New System.Drawing.Point(284, 73)
        Me.ucrMultipleInputTempQtiles.Name = "ucrMultipleInputTempQtiles"
        Me.ucrMultipleInputTempQtiles.Size = New System.Drawing.Size(150, 29)
        Me.ucrMultipleInputTempQtiles.TabIndex = 30
        '
        'ucrMultipleInputPrecQtiles
        '
        Me.ucrMultipleInputPrecQtiles.Location = New System.Drawing.Point(284, 128)
        Me.ucrMultipleInputPrecQtiles.Name = "ucrMultipleInputPrecQtiles"
        Me.ucrMultipleInputPrecQtiles.Size = New System.Drawing.Size(150, 29)
        Me.ucrMultipleInputPrecQtiles.TabIndex = 33
        '
        'lblPrecQuantiles
        '
        Me.lblPrecQuantiles.AutoSize = True
        Me.lblPrecQuantiles.Location = New System.Drawing.Point(284, 107)
        Me.lblPrecQuantiles.Name = "lblPrecQuantiles"
        Me.lblPrecQuantiles.Size = New System.Drawing.Size(112, 13)
        Me.lblPrecQuantiles.TabIndex = 32
        Me.lblPrecQuantiles.Tag = "Precipitation_Quantiles"
        Me.lblPrecQuantiles.Text = "Precipitation Quantiles"
        '
        'lblTempQuantiles
        '
        Me.lblTempQuantiles.AutoSize = True
        Me.lblTempQuantiles.Location = New System.Drawing.Point(284, 56)
        Me.lblTempQuantiles.Name = "lblTempQuantiles"
        Me.lblTempQuantiles.Size = New System.Drawing.Size(114, 13)
        Me.lblTempQuantiles.TabIndex = 28
        Me.lblTempQuantiles.Tag = "Temperature_Quantiles"
        Me.lblTempQuantiles.Text = "Temperature Quantiles"
        '
        'grpMaxMissingDays
        '
        Me.grpMaxMissingDays.Controls.Add(Me.lblMonthly)
        Me.grpMaxMissingDays.Controls.Add(Me.lblAnnual)
        Me.grpMaxMissingDays.Controls.Add(Me.ucrNudMothlyMissingDays)
        Me.grpMaxMissingDays.Controls.Add(Me.ucrNudAnnualMissingDays)
        Me.grpMaxMissingDays.Location = New System.Drawing.Point(13, 56)
        Me.grpMaxMissingDays.Name = "grpMaxMissingDays"
        Me.grpMaxMissingDays.Size = New System.Drawing.Size(216, 45)
        Me.grpMaxMissingDays.TabIndex = 29
        Me.grpMaxMissingDays.TabStop = False
        Me.grpMaxMissingDays.Tag = "Maximum_Missing_Days"
        Me.grpMaxMissingDays.Text = "Maximum Missing Days"
        '
        'lblMonthly
        '
        Me.lblMonthly.AutoSize = True
        Me.lblMonthly.Location = New System.Drawing.Point(106, 19)
        Me.lblMonthly.Name = "lblMonthly"
        Me.lblMonthly.Size = New System.Drawing.Size(44, 13)
        Me.lblMonthly.TabIndex = 2
        Me.lblMonthly.Tag = "Monthly"
        Me.lblMonthly.Text = "Monthly"
        '
        'lblAnnual
        '
        Me.lblAnnual.AutoSize = True
        Me.lblAnnual.Location = New System.Drawing.Point(7, 19)
        Me.lblAnnual.Name = "lblAnnual"
        Me.lblAnnual.Size = New System.Drawing.Size(40, 13)
        Me.lblAnnual.TabIndex = 0
        Me.lblAnnual.Tag = "Annual"
        Me.lblAnnual.Text = "Annual"
        '
        'ucrNudMothlyMissingDays
        '
        Me.ucrNudMothlyMissingDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMothlyMissingDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMothlyMissingDays.Location = New System.Drawing.Point(160, 15)
        Me.ucrNudMothlyMissingDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMothlyMissingDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMothlyMissingDays.Name = "ucrNudMothlyMissingDays"
        Me.ucrNudMothlyMissingDays.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMothlyMissingDays.TabIndex = 39
        Me.ucrNudMothlyMissingDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudAnnualMissingDays
        '
        Me.ucrNudAnnualMissingDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAnnualMissingDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAnnualMissingDays.Location = New System.Drawing.Point(53, 15)
        Me.ucrNudAnnualMissingDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAnnualMissingDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAnnualMissingDays.Name = "ucrNudAnnualMissingDays"
        Me.ucrNudAnnualMissingDays.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAnnualMissingDays.TabIndex = 38
        Me.ucrNudAnnualMissingDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Location = New System.Drawing.Point(284, 162)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(93, 13)
        Me.lblN.TabIndex = 26
        Me.lblN.Tag = "Days_for_Quantiles"
        Me.lblN.Text = "Days for Quantiles"
        '
        'tbPrecipitation
        '
        Me.tbPrecipitation.Controls.Add(Me.grpPrecAnnual)
        Me.tbPrecipitation.Controls.Add(Me.grpPrecAnnualMonthly)
        Me.tbPrecipitation.Location = New System.Drawing.Point(4, 22)
        Me.tbPrecipitation.Name = "tbPrecipitation"
        Me.tbPrecipitation.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPrecipitation.Size = New System.Drawing.Size(468, 473)
        Me.tbPrecipitation.TabIndex = 1
        Me.tbPrecipitation.Text = "Precipitation"
        Me.tbPrecipitation.UseVisualStyleBackColor = True
        '
        'grpPrecAnnual
        '
        Me.grpPrecAnnual.Controls.Add(Me.ucrChkPrecExceedSpecifiedA)
        Me.grpPrecAnnual.Controls.Add(Me.ucrChkMaxDrySpell)
        Me.grpPrecAnnual.Controls.Add(Me.ucrChkPrecExceed95Percent)
        Me.grpPrecAnnual.Controls.Add(Me.ucrChkPrecExceed10mm)
        Me.grpPrecAnnual.Controls.Add(Me.ucrChkMaxWetSpell)
        Me.grpPrecAnnual.Controls.Add(Me.ucrChkPrecExceed20mm)
        Me.grpPrecAnnual.Controls.Add(Me.ucrChkPrecExceed99Percent)
        Me.grpPrecAnnual.Controls.Add(Me.ucrChkTotalDailyPrec)
        Me.grpPrecAnnual.Controls.Add(Me.ucrChkSimplePrecII)
        Me.grpPrecAnnual.Location = New System.Drawing.Point(6, 6)
        Me.grpPrecAnnual.Name = "grpPrecAnnual"
        Me.grpPrecAnnual.Size = New System.Drawing.Size(445, 228)
        Me.grpPrecAnnual.TabIndex = 2
        Me.grpPrecAnnual.TabStop = False
        Me.grpPrecAnnual.Text = "Annual"
        '
        'grpPrecAnnualMonthly
        '
        Me.grpPrecAnnualMonthly.Controls.Add(Me.ucrChkMonthlyMax5dayPrec)
        Me.grpPrecAnnualMonthly.Controls.Add(Me.ucrChkMonthlyMax1dayPrec)
        Me.grpPrecAnnualMonthly.Location = New System.Drawing.Point(6, 236)
        Me.grpPrecAnnualMonthly.Name = "grpPrecAnnualMonthly"
        Me.grpPrecAnnualMonthly.Size = New System.Drawing.Size(445, 63)
        Me.grpPrecAnnualMonthly.TabIndex = 1
        Me.grpPrecAnnualMonthly.TabStop = False
        Me.grpPrecAnnualMonthly.Text = "Annual/Monthly"
        '
        'ucrChkMonthlyMax5dayPrec
        '
        Me.ucrChkMonthlyMax5dayPrec.Checked = False
        Me.ucrChkMonthlyMax5dayPrec.Location = New System.Drawing.Point(7, 42)
        Me.ucrChkMonthlyMax5dayPrec.Name = "ucrChkMonthlyMax5dayPrec"
        Me.ucrChkMonthlyMax5dayPrec.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkMonthlyMax5dayPrec.TabIndex = 78
        '
        'ucrChkMonthlyMax1dayPrec
        '
        Me.ucrChkMonthlyMax1dayPrec.Checked = False
        Me.ucrChkMonthlyMax1dayPrec.Location = New System.Drawing.Point(7, 19)
        Me.ucrChkMonthlyMax1dayPrec.Name = "ucrChkMonthlyMax1dayPrec"
        Me.ucrChkMonthlyMax1dayPrec.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkMonthlyMax1dayPrec.TabIndex = 77
        '
        'tbTemperature
        '
        Me.tbTemperature.Controls.Add(Me.grpTmaxTmin)
        Me.tbTemperature.Controls.Add(Me.grpTmax)
        Me.tbTemperature.Controls.Add(Me.grpTmin)
        Me.tbTemperature.Location = New System.Drawing.Point(4, 22)
        Me.tbTemperature.Name = "tbTemperature"
        Me.tbTemperature.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTemperature.Size = New System.Drawing.Size(468, 473)
        Me.tbTemperature.TabIndex = 2
        Me.tbTemperature.Text = "Temperature"
        Me.tbTemperature.UseVisualStyleBackColor = True
        '
        'grpTmaxTmin
        '
        Me.grpTmaxTmin.Controls.Add(Me.grpTmaxTminAnnualMonthly)
        Me.grpTmaxTmin.Controls.Add(Me.grpTmaxTminAnnual)
        Me.grpTmaxTmin.Location = New System.Drawing.Point(6, 369)
        Me.grpTmaxTmin.Name = "grpTmaxTmin"
        Me.grpTmaxTmin.Size = New System.Drawing.Size(445, 96)
        Me.grpTmaxTmin.TabIndex = 52
        Me.grpTmaxTmin.TabStop = False
        Me.grpTmaxTmin.Text = "Tmax/Tmin"
        '
        'grpTmaxTminAnnualMonthly
        '
        Me.grpTmaxTminAnnualMonthly.Controls.Add(Me.ucrChkMeanDiurnalTempRange)
        Me.grpTmaxTminAnnualMonthly.Location = New System.Drawing.Point(4, 52)
        Me.grpTmaxTminAnnualMonthly.Name = "grpTmaxTminAnnualMonthly"
        Me.grpTmaxTminAnnualMonthly.Size = New System.Drawing.Size(423, 38)
        Me.grpTmaxTminAnnualMonthly.TabIndex = 3
        Me.grpTmaxTminAnnualMonthly.TabStop = False
        Me.grpTmaxTminAnnualMonthly.Text = "Annual/Monthly"
        '
        'ucrChkMeanDiurnalTempRange
        '
        Me.ucrChkMeanDiurnalTempRange.Checked = False
        Me.ucrChkMeanDiurnalTempRange.Location = New System.Drawing.Point(8, 15)
        Me.ucrChkMeanDiurnalTempRange.Name = "ucrChkMeanDiurnalTempRange"
        Me.ucrChkMeanDiurnalTempRange.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkMeanDiurnalTempRange.TabIndex = 74
        '
        'grpTmaxTminAnnual
        '
        Me.grpTmaxTminAnnual.Controls.Add(Me.ucrChkGrowingSeasonLength)
        Me.grpTmaxTminAnnual.Location = New System.Drawing.Point(4, 14)
        Me.grpTmaxTminAnnual.Name = "grpTmaxTminAnnual"
        Me.grpTmaxTminAnnual.Size = New System.Drawing.Size(423, 37)
        Me.grpTmaxTminAnnual.TabIndex = 2
        Me.grpTmaxTminAnnual.TabStop = False
        Me.grpTmaxTminAnnual.Text = "Annual"
        '
        'ucrChkGrowingSeasonLength
        '
        Me.ucrChkGrowingSeasonLength.Checked = False
        Me.ucrChkGrowingSeasonLength.Location = New System.Drawing.Point(8, 12)
        Me.ucrChkGrowingSeasonLength.Name = "ucrChkGrowingSeasonLength"
        Me.ucrChkGrowingSeasonLength.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkGrowingSeasonLength.TabIndex = 78
        '
        'grpTmax
        '
        Me.grpTmax.Controls.Add(Me.grpTmaxAnnualMonthly)
        Me.grpTmax.Controls.Add(Me.grpTmaxAnnual)
        Me.grpTmax.Location = New System.Drawing.Point(6, 1)
        Me.grpTmax.Name = "grpTmax"
        Me.grpTmax.Size = New System.Drawing.Size(445, 183)
        Me.grpTmax.TabIndex = 5
        Me.grpTmax.TabStop = False
        Me.grpTmax.Text = "Tmax"
        '
        'grpTmaxAnnualMonthly
        '
        Me.grpTmaxAnnualMonthly.Controls.Add(Me.ucrChkMonthlyMaxDailyTMax)
        Me.grpTmaxAnnualMonthly.Controls.Add(Me.ucrChkTmaxAbove90Percent)
        Me.grpTmaxAnnualMonthly.Controls.Add(Me.ucrChkTmaxBelow10Percent)
        Me.grpTmaxAnnualMonthly.Controls.Add(Me.ucrChkMonthlyMinDailyTMax)
        Me.grpTmaxAnnualMonthly.Location = New System.Drawing.Point(4, 80)
        Me.grpTmaxAnnualMonthly.Name = "grpTmaxAnnualMonthly"
        Me.grpTmaxAnnualMonthly.Size = New System.Drawing.Size(423, 93)
        Me.grpTmaxAnnualMonthly.TabIndex = 1
        Me.grpTmaxAnnualMonthly.TabStop = False
        Me.grpTmaxAnnualMonthly.Text = "Annual/Monthly"
        '
        'ucrChkMonthlyMaxDailyTMax
        '
        Me.ucrChkMonthlyMaxDailyTMax.Checked = False
        Me.ucrChkMonthlyMaxDailyTMax.Location = New System.Drawing.Point(8, 32)
        Me.ucrChkMonthlyMaxDailyTMax.Name = "ucrChkMonthlyMaxDailyTMax"
        Me.ucrChkMonthlyMaxDailyTMax.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkMonthlyMaxDailyTMax.TabIndex = 66
        '
        'ucrChkTmaxAbove90Percent
        '
        Me.ucrChkTmaxAbove90Percent.Checked = False
        Me.ucrChkTmaxAbove90Percent.Location = New System.Drawing.Point(8, 51)
        Me.ucrChkTmaxAbove90Percent.Name = "ucrChkTmaxAbove90Percent"
        Me.ucrChkTmaxAbove90Percent.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkTmaxAbove90Percent.TabIndex = 73
        '
        'ucrChkTmaxBelow10Percent
        '
        Me.ucrChkTmaxBelow10Percent.Checked = False
        Me.ucrChkTmaxBelow10Percent.Location = New System.Drawing.Point(8, 70)
        Me.ucrChkTmaxBelow10Percent.Name = "ucrChkTmaxBelow10Percent"
        Me.ucrChkTmaxBelow10Percent.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkTmaxBelow10Percent.TabIndex = 71
        '
        'ucrChkMonthlyMinDailyTMax
        '
        Me.ucrChkMonthlyMinDailyTMax.Checked = False
        Me.ucrChkMonthlyMinDailyTMax.Location = New System.Drawing.Point(8, 15)
        Me.ucrChkMonthlyMinDailyTMax.Name = "ucrChkMonthlyMinDailyTMax"
        Me.ucrChkMonthlyMinDailyTMax.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkMonthlyMinDailyTMax.TabIndex = 68
        '
        'grpTmaxAnnual
        '
        Me.grpTmaxAnnual.Controls.Add(Me.ucrChkSummerDays)
        Me.grpTmaxAnnual.Controls.Add(Me.ucrChkWarmSpellDI)
        Me.grpTmaxAnnual.Controls.Add(Me.ucrChkIcingDays)
        Me.grpTmaxAnnual.Location = New System.Drawing.Point(4, 13)
        Me.grpTmaxAnnual.Name = "grpTmaxAnnual"
        Me.grpTmaxAnnual.Size = New System.Drawing.Size(421, 65)
        Me.grpTmaxAnnual.TabIndex = 0
        Me.grpTmaxAnnual.TabStop = False
        Me.grpTmaxAnnual.Text = "Annual"
        '
        'ucrChkSummerDays
        '
        Me.ucrChkSummerDays.Checked = False
        Me.ucrChkSummerDays.Location = New System.Drawing.Point(8, 13)
        Me.ucrChkSummerDays.Name = "ucrChkSummerDays"
        Me.ucrChkSummerDays.Size = New System.Drawing.Size(100, 18)
        Me.ucrChkSummerDays.TabIndex = 80
        '
        'ucrChkWarmSpellDI
        '
        Me.ucrChkWarmSpellDI.Checked = False
        Me.ucrChkWarmSpellDI.Location = New System.Drawing.Point(8, 45)
        Me.ucrChkWarmSpellDI.Name = "ucrChkWarmSpellDI"
        Me.ucrChkWarmSpellDI.Size = New System.Drawing.Size(100, 18)
        Me.ucrChkWarmSpellDI.TabIndex = 81
        '
        'ucrChkIcingDays
        '
        Me.ucrChkIcingDays.Checked = False
        Me.ucrChkIcingDays.Location = New System.Drawing.Point(8, 30)
        Me.ucrChkIcingDays.Name = "ucrChkIcingDays"
        Me.ucrChkIcingDays.Size = New System.Drawing.Size(100, 18)
        Me.ucrChkIcingDays.TabIndex = 79
        '
        'grpTmin
        '
        Me.grpTmin.Controls.Add(Me.grpTminAnnualMonthly)
        Me.grpTmin.Controls.Add(Me.grpTminAnnual)
        Me.grpTmin.Location = New System.Drawing.Point(6, 185)
        Me.grpTmin.Name = "grpTmin"
        Me.grpTmin.Size = New System.Drawing.Size(445, 181)
        Me.grpTmin.TabIndex = 4
        Me.grpTmin.TabStop = False
        Me.grpTmin.Text = "Tmin"
        '
        'grpTminAnnualMonthly
        '
        Me.grpTminAnnualMonthly.Controls.Add(Me.ucrChkMonthlyMinDailyTMin)
        Me.grpTminAnnualMonthly.Controls.Add(Me.ucrChkMonthlyMaxDailyTMin)
        Me.grpTminAnnualMonthly.Controls.Add(Me.ucrChkTminBelow10Percent)
        Me.grpTminAnnualMonthly.Controls.Add(Me.ucrChkTminAbove90Percent)
        Me.grpTminAnnualMonthly.Location = New System.Drawing.Point(4, 85)
        Me.grpTminAnnualMonthly.Name = "grpTminAnnualMonthly"
        Me.grpTminAnnualMonthly.Size = New System.Drawing.Size(423, 90)
        Me.grpTminAnnualMonthly.TabIndex = 3
        Me.grpTminAnnualMonthly.TabStop = False
        Me.grpTminAnnualMonthly.Text = "Annual/Monthly"
        '
        'ucrChkMonthlyMinDailyTMin
        '
        Me.ucrChkMonthlyMinDailyTMin.Checked = False
        Me.ucrChkMonthlyMinDailyTMin.Location = New System.Drawing.Point(8, 52)
        Me.ucrChkMonthlyMinDailyTMin.Name = "ucrChkMonthlyMinDailyTMin"
        Me.ucrChkMonthlyMinDailyTMin.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkMonthlyMinDailyTMin.TabIndex = 69
        '
        'ucrChkMonthlyMaxDailyTMin
        '
        Me.ucrChkMonthlyMaxDailyTMin.Checked = False
        Me.ucrChkMonthlyMaxDailyTMin.Location = New System.Drawing.Point(8, 17)
        Me.ucrChkMonthlyMaxDailyTMin.Name = "ucrChkMonthlyMaxDailyTMin"
        Me.ucrChkMonthlyMaxDailyTMin.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkMonthlyMaxDailyTMin.TabIndex = 67
        '
        'ucrChkTminBelow10Percent
        '
        Me.ucrChkTminBelow10Percent.Checked = False
        Me.ucrChkTminBelow10Percent.Location = New System.Drawing.Point(8, 35)
        Me.ucrChkTminBelow10Percent.Name = "ucrChkTminBelow10Percent"
        Me.ucrChkTminBelow10Percent.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkTminBelow10Percent.TabIndex = 70
        '
        'ucrChkTminAbove90Percent
        '
        Me.ucrChkTminAbove90Percent.Checked = False
        Me.ucrChkTminAbove90Percent.Location = New System.Drawing.Point(8, 71)
        Me.ucrChkTminAbove90Percent.Name = "ucrChkTminAbove90Percent"
        Me.ucrChkTminAbove90Percent.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkTminAbove90Percent.TabIndex = 72
        '
        'grpTminAnnual
        '
        Me.grpTminAnnual.Controls.Add(Me.ucrChkColdSpellDI)
        Me.grpTminAnnual.Controls.Add(Me.ucrChkTropicalNights)
        Me.grpTminAnnual.Controls.Add(Me.ucrChkFrostDays)
        Me.grpTminAnnual.Location = New System.Drawing.Point(4, 10)
        Me.grpTminAnnual.Name = "grpTminAnnual"
        Me.grpTminAnnual.Size = New System.Drawing.Size(423, 69)
        Me.grpTminAnnual.TabIndex = 2
        Me.grpTminAnnual.TabStop = False
        Me.grpTminAnnual.Text = "Annual"
        '
        'ucrChkColdSpellDI
        '
        Me.ucrChkColdSpellDI.Checked = False
        Me.ucrChkColdSpellDI.Location = New System.Drawing.Point(8, 45)
        Me.ucrChkColdSpellDI.Name = "ucrChkColdSpellDI"
        Me.ucrChkColdSpellDI.Size = New System.Drawing.Size(100, 18)
        Me.ucrChkColdSpellDI.TabIndex = 83
        '
        'ucrChkTropicalNights
        '
        Me.ucrChkTropicalNights.Checked = False
        Me.ucrChkTropicalNights.Location = New System.Drawing.Point(8, 28)
        Me.ucrChkTropicalNights.Name = "ucrChkTropicalNights"
        Me.ucrChkTropicalNights.Size = New System.Drawing.Size(100, 18)
        Me.ucrChkTropicalNights.TabIndex = 80
        '
        'ucrChkFrostDays
        '
        Me.ucrChkFrostDays.Checked = False
        Me.ucrChkFrostDays.Location = New System.Drawing.Point(8, 12)
        Me.ucrChkFrostDays.Name = "ucrChkFrostDays"
        Me.ucrChkFrostDays.Size = New System.Drawing.Size(100, 18)
        Me.ucrChkFrostDays.TabIndex = 79
        '
        'ucrChkSave
        '
        Me.ucrChkSave.Checked = False
        Me.ucrChkSave.Location = New System.Drawing.Point(8, 506)
        Me.ucrChkSave.Name = "ucrChkSave"
        Me.ucrChkSave.Size = New System.Drawing.Size(107, 20)
        Me.ucrChkSave.TabIndex = 51
        '
        'ucrButtonsClimdexIndices
        '
        Me.ucrButtonsClimdexIndices.Location = New System.Drawing.Point(169, 519)
        Me.ucrButtonsClimdexIndices.Name = "ucrButtonsClimdexIndices"
        Me.ucrButtonsClimdexIndices.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsClimdexIndices.TabIndex = 6
        '
        'sdgClimdexIndices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 557)
        Me.Controls.Add(Me.ucrChkSave)
        Me.Controls.Add(Me.tbClimdex)
        Me.Controls.Add(Me.ucrButtonsClimdexIndices)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgClimdexIndices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Indices"
        Me.Text = "Indices"
        Me.tbClimdex.ResumeLayout(False)
        Me.TbSettings.ResumeLayout(False)
        Me.TbSettings.PerformLayout()
        Me.grpMaxMissingDays.ResumeLayout(False)
        Me.grpMaxMissingDays.PerformLayout()
        Me.tbPrecipitation.ResumeLayout(False)
        Me.grpPrecAnnual.ResumeLayout(False)
        Me.grpPrecAnnualMonthly.ResumeLayout(False)
        Me.tbTemperature.ResumeLayout(False)
        Me.grpTmaxTmin.ResumeLayout(False)
        Me.grpTmaxTminAnnualMonthly.ResumeLayout(False)
        Me.grpTmaxTminAnnual.ResumeLayout(False)
        Me.grpTmax.ResumeLayout(False)
        Me.grpTmaxAnnualMonthly.ResumeLayout(False)
        Me.grpTmaxAnnual.ResumeLayout(False)
        Me.grpTmin.ResumeLayout(False)
        Me.grpTminAnnualMonthly.ResumeLayout(False)
        Me.grpTminAnnual.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrButtonsClimdexIndices As ucrButtonsSubdialogue
    Friend WithEvents ttClimdexIndices As ToolTip
    Friend WithEvents lblThreshold As Label
    Friend WithEvents tbClimdex As TabControl
    Friend WithEvents TbSettings As TabPage
    Friend WithEvents tbPrecipitation As TabPage
    Friend WithEvents ucrInputFreq As ucrInputComboBox
    Friend WithEvents ucrMultipleInputTempQtiles As ucrMultipleInput
    Friend WithEvents ucrMultipleInputPrecQtiles As ucrMultipleInput
    Friend WithEvents lblPrecQuantiles As Label
    Friend WithEvents lblTempQuantiles As Label
    Friend WithEvents grpMaxMissingDays As GroupBox
    Friend WithEvents lblMonthly As Label
    Friend WithEvents lblAnnual As Label
    Friend WithEvents lblN As Label
    Friend WithEvents lblMinBaseData As Label
    Friend WithEvents lblFreq As Label
    Friend WithEvents ucrNudN As ucrNud
    Friend WithEvents ucrNudThreshold As ucrNud
    Friend WithEvents ucrNudMinBaseData As ucrNud
    Friend WithEvents ucrNudMothlyMissingDays As ucrNud
    Friend WithEvents ucrNudAnnualMissingDays As ucrNud
    Friend WithEvents ucrMultipleInputBaseRange As ucrMultipleInput
    Friend WithEvents lblBaseRange As Label
    Friend WithEvents ucrChkCenterMean As ucrCheck
    Friend WithEvents ucrChkSpellDISpanYear As ucrCheck
    Friend WithEvents ucrChkNHemisphere As ucrCheck
    Friend WithEvents ucrChkMaxSpellSpanYears As ucrCheck
    Friend WithEvents ucrChkPrecExceed10mm As ucrCheck
    Friend WithEvents ucrChkMaxDrySpell As ucrCheck
    Friend WithEvents ucrChkPrecExceedSpecifiedA As ucrCheck
    Friend WithEvents ucrChkPrecExceed20mm As ucrCheck
    Friend WithEvents ucrChkTotalDailyPrec As ucrCheck
    Friend WithEvents ucrChkPrecExceed99Percent As ucrCheck
    Friend WithEvents ucrChkPrecExceed95Percent As ucrCheck
    Friend WithEvents ucrChkMaxWetSpell As ucrCheck
    Friend WithEvents ucrChkSimplePrecII As ucrCheck
    Friend WithEvents ucrChkSave As ucrCheck
    Friend WithEvents tbTemperature As TabPage

    Private Sub ucrChkColdSpellDI_Load(sender As Object, e As EventArgs) Handles ucrChkColdSpellDI.Load

    End Sub
    Friend WithEvents ucrChkMeanDiurnalTempRange As ucrCheck
    Friend WithEvents ucrChkTmaxAbove90Percent As ucrCheck
    Friend WithEvents ucrChkTminAbove90Percent As ucrCheck
    Friend WithEvents ucrChkTmaxBelow10Percent As ucrCheck
    Friend WithEvents ucrChkTminBelow10Percent As ucrCheck
    Friend WithEvents ucrChkMonthlyMinDailyTMin As ucrCheck
    Friend WithEvents ucrChkMonthlyMinDailyTMax As ucrCheck
    Friend WithEvents ucrChkMonthlyMaxDailyTMin As ucrCheck
    Friend WithEvents ucrChkMonthlyMaxDailyTMax As ucrCheck
    Friend WithEvents grpPrecAnnual As GroupBox
    Friend WithEvents grpPrecAnnualMonthly As GroupBox
    Friend WithEvents ucrChkMonthlyMax5dayPrec As ucrCheck
    Friend WithEvents ucrChkMonthlyMax1dayPrec As ucrCheck
    Friend WithEvents ucrChkWarmSpellDI As ucrCheck
    Friend WithEvents ucrChkSummerDays As ucrCheck
    Friend WithEvents ucrChkIcingDays As ucrCheck
    Friend WithEvents grpTmaxTmin As GroupBox
    Friend WithEvents grpTmax As GroupBox
    Friend WithEvents grpTmaxAnnualMonthly As GroupBox
    Friend WithEvents grpTmaxAnnual As GroupBox
    Friend WithEvents grpTmin As GroupBox
    Friend WithEvents grpTmaxTminAnnualMonthly As GroupBox
    Friend WithEvents grpTmaxTminAnnual As GroupBox
    Friend WithEvents grpTminAnnualMonthly As GroupBox
    Friend WithEvents grpTminAnnual As GroupBox
    Friend WithEvents ucrChkGrowingSeasonLength As ucrCheck
    Friend WithEvents ucrChkColdSpellDI As ucrCheck
    Friend WithEvents ucrChkTropicalNights As ucrCheck
    Friend WithEvents ucrChkFrostDays As ucrCheck
End Class