﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrSelectorByDataFrame
    Inherits instat.ucrSelector

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
        Me.ucrAvailableDataFrames = New instat.ucrDataFrame()
        Me.SuspendLayout()
        '
        'lstAvailableVariable
        '
        Me.lstAvailableVariable.Location = New System.Drawing.Point(3, 50)
        '
        'ucrAvailableDataFrames
        '
        Me.ucrAvailableDataFrames.Location = New System.Drawing.Point(3, 3)
        Me.ucrAvailableDataFrames.Name = "ucrAvailableDataFrames"
        Me.ucrAvailableDataFrames.Size = New System.Drawing.Size(127, 41)
        Me.ucrAvailableDataFrames.TabIndex = 84
        '
        'ucrSelectorByDataFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrAvailableDataFrames)
        Me.Name = "ucrSelectorByDataFrame"
        Me.Size = New System.Drawing.Size(147, 177)
        Me.Controls.SetChildIndex(Me.lstAvailableVariable, 0)
        Me.Controls.SetChildIndex(Me.ucrAvailableDataFrames, 0)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents ucrAvailableDataFrames As ucrDataFrame
End Class
