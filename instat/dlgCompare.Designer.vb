﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgCompare
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgCompare))
        Me.ucrSelectorCompare = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverSateliteElement = New instat.ucrReceiverSingle()
        Me.ucrReceiverStationElement = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblSateliteElement = New System.Windows.Forms.Label()
        Me.lblStationElement = New System.Windows.Forms.Label()
        Me.lblWithinYear = New System.Windows.Forms.Label()
        Me.ucrReceiverWithinYear = New instat.ucrReceiverSingle()
        Me.ucrChkMovingAverage = New instat.ucrCheck()
        Me.ucrSaveAbsDev = New instat.ucrSave()
        Me.ucrSaveBias = New instat.ucrSave()
        Me.rdoAnomalies = New System.Windows.Forms.RadioButton()
        Me.rdoDifferences = New System.Windows.Forms.RadioButton()
        Me.ucrPnlCompare = New instat.UcrPanel()
        Me.ucrNudMovingAverage = New instat.ucrNud()
        Me.ucrSaveSateliteAnomalies = New instat.ucrSave()
        Me.ucrSaveStationAnomalies = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'ucrSelectorCompare
        '
        Me.ucrSelectorCompare.bDropUnusedFilterLevels = False
        Me.ucrSelectorCompare.bShowHiddenColumns = False
        Me.ucrSelectorCompare.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorCompare, "ucrSelectorCompare")
        Me.ucrSelectorCompare.Name = "ucrSelectorCompare"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReceiverSateliteElement
        '
        Me.ucrReceiverSateliteElement.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSateliteElement, "ucrReceiverSateliteElement")
        Me.ucrReceiverSateliteElement.Name = "ucrReceiverSateliteElement"
        Me.ucrReceiverSateliteElement.Selector = Nothing
        Me.ucrReceiverSateliteElement.strNcFilePath = ""
        Me.ucrReceiverSateliteElement.ucrSelector = Nothing
        '
        'ucrReceiverStationElement
        '
        Me.ucrReceiverStationElement.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverStationElement, "ucrReceiverStationElement")
        Me.ucrReceiverStationElement.Name = "ucrReceiverStationElement"
        Me.ucrReceiverStationElement.Selector = Nothing
        Me.ucrReceiverStationElement.strNcFilePath = ""
        Me.ucrReceiverStationElement.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverStation, "ucrReceiverStation")
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'lblStation
        '
        resources.ApplyResources(Me.lblStation, "lblStation")
        Me.lblStation.Name = "lblStation"
        '
        'lblSateliteElement
        '
        resources.ApplyResources(Me.lblSateliteElement, "lblSateliteElement")
        Me.lblSateliteElement.Name = "lblSateliteElement"
        '
        'lblStationElement
        '
        resources.ApplyResources(Me.lblStationElement, "lblStationElement")
        Me.lblStationElement.Name = "lblStationElement"
        '
        'lblWithinYear
        '
        resources.ApplyResources(Me.lblWithinYear, "lblWithinYear")
        Me.lblWithinYear.Name = "lblWithinYear"
        '
        'ucrReceiverWithinYear
        '
        Me.ucrReceiverWithinYear.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverWithinYear, "ucrReceiverWithinYear")
        Me.ucrReceiverWithinYear.Name = "ucrReceiverWithinYear"
        Me.ucrReceiverWithinYear.Selector = Nothing
        Me.ucrReceiverWithinYear.strNcFilePath = ""
        Me.ucrReceiverWithinYear.ucrSelector = Nothing
        '
        'ucrChkMovingAverage
        '
        Me.ucrChkMovingAverage.Checked = False
        resources.ApplyResources(Me.ucrChkMovingAverage, "ucrChkMovingAverage")
        Me.ucrChkMovingAverage.Name = "ucrChkMovingAverage"
        '
        'ucrSaveAbsDev
        '
        resources.ApplyResources(Me.ucrSaveAbsDev, "ucrSaveAbsDev")
        Me.ucrSaveAbsDev.Name = "ucrSaveAbsDev"
        '
        'ucrSaveBias
        '
        resources.ApplyResources(Me.ucrSaveBias, "ucrSaveBias")
        Me.ucrSaveBias.Name = "ucrSaveBias"
        '
        'rdoAnomalies
        '
        resources.ApplyResources(Me.rdoAnomalies, "rdoAnomalies")
        Me.rdoAnomalies.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAnomalies.FlatAppearance.BorderSize = 2
        Me.rdoAnomalies.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAnomalies.Name = "rdoAnomalies"
        Me.rdoAnomalies.TabStop = True
        Me.rdoAnomalies.UseVisualStyleBackColor = True
        '
        'rdoDifferences
        '
        resources.ApplyResources(Me.rdoDifferences, "rdoDifferences")
        Me.rdoDifferences.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDifferences.FlatAppearance.BorderSize = 2
        Me.rdoDifferences.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDifferences.Name = "rdoDifferences"
        Me.rdoDifferences.TabStop = True
        Me.rdoDifferences.UseVisualStyleBackColor = True
        '
        'ucrPnlCompare
        '
        resources.ApplyResources(Me.ucrPnlCompare, "ucrPnlCompare")
        Me.ucrPnlCompare.Name = "ucrPnlCompare"
        '
        'ucrNudMovingAverage
        '
        Me.ucrNudMovingAverage.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMovingAverage.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMovingAverage, "ucrNudMovingAverage")
        Me.ucrNudMovingAverage.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMovingAverage.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMovingAverage.Name = "ucrNudMovingAverage"
        Me.ucrNudMovingAverage.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSaveSateliteAnomalies
        '
        resources.ApplyResources(Me.ucrSaveSateliteAnomalies, "ucrSaveSateliteAnomalies")
        Me.ucrSaveSateliteAnomalies.Name = "ucrSaveSateliteAnomalies"
        '
        'ucrSaveStationAnomalies
        '
        resources.ApplyResources(Me.ucrSaveStationAnomalies, "ucrSaveStationAnomalies")
        Me.ucrSaveStationAnomalies.Name = "ucrSaveStationAnomalies"
        '
        'dlgCompare
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveSateliteAnomalies)
        Me.Controls.Add(Me.ucrSaveStationAnomalies)
        Me.Controls.Add(Me.ucrNudMovingAverage)
        Me.Controls.Add(Me.rdoAnomalies)
        Me.Controls.Add(Me.rdoDifferences)
        Me.Controls.Add(Me.ucrPnlCompare)
        Me.Controls.Add(Me.ucrSaveBias)
        Me.Controls.Add(Me.ucrSaveAbsDev)
        Me.Controls.Add(Me.ucrChkMovingAverage)
        Me.Controls.Add(Me.lblWithinYear)
        Me.Controls.Add(Me.ucrReceiverWithinYear)
        Me.Controls.Add(Me.lblStationElement)
        Me.Controls.Add(Me.lblSateliteElement)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrReceiverStationElement)
        Me.Controls.Add(Me.ucrReceiverSateliteElement)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorCompare)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCompare"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorCompare As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverSateliteElement As ucrReceiverSingle
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrReceiverStationElement As ucrReceiverSingle
    Friend WithEvents lblStationElement As Label
    Friend WithEvents lblSateliteElement As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents lblWithinYear As Label
    Friend WithEvents ucrReceiverWithinYear As ucrReceiverSingle
    Friend WithEvents ucrSaveBias As ucrSave
    Friend WithEvents ucrSaveAbsDev As ucrSave
    Friend WithEvents ucrChkMovingAverage As ucrCheck
    Friend WithEvents rdoAnomalies As RadioButton
    Friend WithEvents rdoDifferences As RadioButton
    Friend WithEvents ucrPnlCompare As UcrPanel
    Friend WithEvents ucrNudMovingAverage As ucrNud
    Friend WithEvents ucrSaveSateliteAnomalies As ucrSave
    Friend WithEvents ucrSaveStationAnomalies As ucrSave
End Class
