﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlBlkSortingOpts
    Inherits System.Windows.Forms.UserControl

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
        Me.grpBoxBlockSort = New System.Windows.Forms.GroupBox()
        Me.comboContext = New System.Windows.Forms.ComboBox()
        Me.lblContext = New System.Windows.Forms.Label()
        Me.grpBoxEntEnc = New System.Windows.Forms.GroupBox()
        Me.lblMemUsageNum = New System.Windows.Forms.Label()
        Me.lblMemUsageTag = New System.Windows.Forms.Label()
        Me.chkBoxCUDA = New System.Windows.Forms.CheckBox()
        Me.numSortTransformOder = New System.Windows.Forms.NumericUpDown()
        Me.chkBoxSortTransform = New System.Windows.Forms.CheckBox()
        Me.rBtnEntEncAdaptive = New System.Windows.Forms.RadioButton()
        Me.rBtnEntEncStatic = New System.Windows.Forms.RadioButton()
        Me.lblEntEnc = New System.Windows.Forms.Label()
        Me.lblBlkSize = New System.Windows.Forms.Label()
        Me.numBlkSize = New System.Windows.Forms.NumericUpDown()
        Me.grpBoxBlockSort.SuspendLayout()
        Me.grpBoxEntEnc.SuspendLayout()
        CType(Me.numSortTransformOder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numBlkSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBoxBlockSort
        '
        Me.grpBoxBlockSort.Controls.Add(Me.comboContext)
        Me.grpBoxBlockSort.Controls.Add(Me.lblContext)
        Me.grpBoxBlockSort.Controls.Add(Me.grpBoxEntEnc)
        Me.grpBoxBlockSort.Controls.Add(Me.lblBlkSize)
        Me.grpBoxBlockSort.Controls.Add(Me.numBlkSize)
        Me.grpBoxBlockSort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpBoxBlockSort.Location = New System.Drawing.Point(0, 0)
        Me.grpBoxBlockSort.Name = "grpBoxBlockSort"
        Me.grpBoxBlockSort.Size = New System.Drawing.Size(325, 206)
        Me.grpBoxBlockSort.TabIndex = 2
        Me.grpBoxBlockSort.TabStop = False
        Me.grpBoxBlockSort.Text = "Block Sorting"
        '
        'comboContext
        '
        Me.comboContext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboContext.FormattingEnabled = True
        Me.comboContext.ItemHeight = 13
        Me.comboContext.Items.AddRange(New Object() {"Following", "Preceding", "Autodetect"})
        Me.comboContext.Location = New System.Drawing.Point(199, 46)
        Me.comboContext.Name = "comboContext"
        Me.comboContext.Size = New System.Drawing.Size(120, 21)
        Me.comboContext.TabIndex = 8
        '
        'lblContext
        '
        Me.lblContext.AutoSize = True
        Me.lblContext.Location = New System.Drawing.Point(6, 46)
        Me.lblContext.Name = "lblContext"
        Me.lblContext.Size = New System.Drawing.Size(100, 13)
        Me.lblContext.TabIndex = 12
        Me.lblContext.Text = "Contexts for sorting:"
        '
        'grpBoxEntEnc
        '
        Me.grpBoxEntEnc.Controls.Add(Me.lblMemUsageNum)
        Me.grpBoxEntEnc.Controls.Add(Me.lblMemUsageTag)
        Me.grpBoxEntEnc.Controls.Add(Me.chkBoxCUDA)
        Me.grpBoxEntEnc.Controls.Add(Me.numSortTransformOder)
        Me.grpBoxEntEnc.Controls.Add(Me.chkBoxSortTransform)
        Me.grpBoxEntEnc.Controls.Add(Me.rBtnEntEncAdaptive)
        Me.grpBoxEntEnc.Controls.Add(Me.rBtnEntEncStatic)
        Me.grpBoxEntEnc.Controls.Add(Me.lblEntEnc)
        Me.grpBoxEntEnc.Location = New System.Drawing.Point(9, 73)
        Me.grpBoxEntEnc.Name = "grpBoxEntEnc"
        Me.grpBoxEntEnc.Size = New System.Drawing.Size(310, 127)
        Me.grpBoxEntEnc.TabIndex = 11
        Me.grpBoxEntEnc.TabStop = False
        Me.grpBoxEntEnc.Text = "Algorithm"
        '
        'lblMemUsageNum
        '
        Me.lblMemUsageNum.AutoSize = True
        Me.lblMemUsageNum.Location = New System.Drawing.Point(242, 98)
        Me.lblMemUsageNum.Name = "lblMemUsageNum"
        Me.lblMemUsageNum.Size = New System.Drawing.Size(32, 13)
        Me.lblMemUsageNum.TabIndex = 18
        Me.lblMemUsageNum.Text = "0 MB"
        Me.lblMemUsageNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMemUsageTag
        '
        Me.lblMemUsageTag.AutoSize = True
        Me.lblMemUsageTag.Location = New System.Drawing.Point(6, 96)
        Me.lblMemUsageTag.Name = "lblMemUsageTag"
        Me.lblMemUsageTag.Size = New System.Drawing.Size(193, 13)
        Me.lblMemUsageTag.TabIndex = 17
        Me.lblMemUsageTag.Text = "Estimated Memory Usage (Single Core):"
        '
        'chkBoxCUDA
        '
        Me.chkBoxCUDA.AutoSize = True
        Me.chkBoxCUDA.Enabled = False
        Me.chkBoxCUDA.Location = New System.Drawing.Point(9, 65)
        Me.chkBoxCUDA.Name = "chkBoxCUDA"
        Me.chkBoxCUDA.Size = New System.Drawing.Size(238, 17)
        Me.chkBoxCUDA.TabIndex = 16
        Me.chkBoxCUDA.Text = "Enable Sort Transform Acceleration (NVIDIA)"
        Me.chkBoxCUDA.UseVisualStyleBackColor = True
        '
        'numSortTransformOder
        '
        Me.numSortTransformOder.Enabled = False
        Me.numSortTransformOder.Location = New System.Drawing.Point(184, 39)
        Me.numSortTransformOder.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.numSortTransformOder.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.numSortTransformOder.Name = "numSortTransformOder"
        Me.numSortTransformOder.Size = New System.Drawing.Size(120, 20)
        Me.numSortTransformOder.TabIndex = 13
        Me.numSortTransformOder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numSortTransformOder.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'chkBoxSortTransform
        '
        Me.chkBoxSortTransform.AutoSize = True
        Me.chkBoxSortTransform.Location = New System.Drawing.Point(9, 42)
        Me.chkBoxSortTransform.Name = "chkBoxSortTransform"
        Me.chkBoxSortTransform.Size = New System.Drawing.Size(164, 17)
        Me.chkBoxSortTransform.TabIndex = 9
        Me.chkBoxSortTransform.Text = "Use Nth order Sort Transform"
        Me.chkBoxSortTransform.UseVisualStyleBackColor = True
        '
        'rBtnEntEncAdaptive
        '
        Me.rBtnEntEncAdaptive.AutoSize = True
        Me.rBtnEntEncAdaptive.Location = New System.Drawing.Point(234, 18)
        Me.rBtnEntEncAdaptive.Name = "rBtnEntEncAdaptive"
        Me.rBtnEntEncAdaptive.Size = New System.Drawing.Size(67, 17)
        Me.rBtnEntEncAdaptive.TabIndex = 15
        Me.rBtnEntEncAdaptive.Text = "Adaptive"
        Me.rBtnEntEncAdaptive.UseVisualStyleBackColor = True
        '
        'rBtnEntEncStatic
        '
        Me.rBtnEntEncStatic.AutoSize = True
        Me.rBtnEntEncStatic.Checked = True
        Me.rBtnEntEncStatic.Location = New System.Drawing.Point(137, 19)
        Me.rBtnEntEncStatic.Name = "rBtnEntEncStatic"
        Me.rBtnEntEncStatic.Size = New System.Drawing.Size(52, 17)
        Me.rBtnEntEncStatic.TabIndex = 14
        Me.rBtnEntEncStatic.TabStop = True
        Me.rBtnEntEncStatic.Text = "Static"
        Me.rBtnEntEncStatic.UseVisualStyleBackColor = True
        '
        'lblEntEnc
        '
        Me.lblEntEnc.AutoSize = True
        Me.lblEntEnc.Location = New System.Drawing.Point(6, 19)
        Me.lblEntEnc.Name = "lblEntEnc"
        Me.lblEntEnc.Size = New System.Drawing.Size(94, 13)
        Me.lblEntEnc.TabIndex = 13
        Me.lblEntEnc.Text = "Entropy Encoding:"
        '
        'lblBlkSize
        '
        Me.lblBlkSize.AutoSize = True
        Me.lblBlkSize.Location = New System.Drawing.Point(6, 20)
        Me.lblBlkSize.Name = "lblBlkSize"
        Me.lblBlkSize.Size = New System.Drawing.Size(85, 13)
        Me.lblBlkSize.TabIndex = 10
        Me.lblBlkSize.Text = "Block Size (MB):"
        '
        'numBlkSize
        '
        Me.numBlkSize.Location = New System.Drawing.Point(199, 16)
        Me.numBlkSize.Maximum = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.numBlkSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numBlkSize.Name = "numBlkSize"
        Me.numBlkSize.Size = New System.Drawing.Size(120, 20)
        Me.numBlkSize.TabIndex = 0
        Me.numBlkSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numBlkSize.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'ctlBlkSortingOpts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpBoxBlockSort)
        Me.Name = "ctlBlkSortingOpts"
        Me.Size = New System.Drawing.Size(325, 206)
        Me.grpBoxBlockSort.ResumeLayout(False)
        Me.grpBoxBlockSort.PerformLayout()
        Me.grpBoxEntEnc.ResumeLayout(False)
        Me.grpBoxEntEnc.PerformLayout()
        CType(Me.numSortTransformOder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numBlkSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBoxBlockSort As System.Windows.Forms.GroupBox
    Friend WithEvents comboContext As System.Windows.Forms.ComboBox
    Friend WithEvents lblContext As System.Windows.Forms.Label
    Friend WithEvents grpBoxEntEnc As System.Windows.Forms.GroupBox
    Friend WithEvents lblMemUsageNum As System.Windows.Forms.Label
    Friend WithEvents lblMemUsageTag As System.Windows.Forms.Label
    Friend WithEvents chkBoxCUDA As System.Windows.Forms.CheckBox
    Friend WithEvents numSortTransformOder As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkBoxSortTransform As System.Windows.Forms.CheckBox
    Friend WithEvents rBtnEntEncAdaptive As System.Windows.Forms.RadioButton
    Friend WithEvents rBtnEntEncStatic As System.Windows.Forms.RadioButton
    Friend WithEvents lblEntEnc As System.Windows.Forms.Label
    Friend WithEvents lblBlkSize As System.Windows.Forms.Label
    Friend WithEvents numBlkSize As System.Windows.Forms.NumericUpDown

End Class
