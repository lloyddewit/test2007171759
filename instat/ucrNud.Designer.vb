﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrNud
    Inherits instat.ucrCore

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
        Me.nudUpDown = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudUpDown
        '
        Me.nudUpDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudUpDown.Location = New System.Drawing.Point(0, 0)
        Me.nudUpDown.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.nudUpDown.Name = "nudUpDown"
        Me.nudUpDown.Size = New System.Drawing.Size(133, 38)
        Me.nudUpDown.TabIndex = 0
        '
        'ucrNud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.nudUpDown)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "ucrNud"
        Me.Size = New System.Drawing.Size(133, 48)
        CType(Me.nudUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents nudUpDown As NumericUpDown
End Class
