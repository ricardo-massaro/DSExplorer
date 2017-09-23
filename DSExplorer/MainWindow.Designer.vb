﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Me.components = New System.ComponentModel.Container()
        Me.txtDataFolder = New System.Windows.Forms.TextBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.treeFiles = New System.Windows.Forms.TreeView()
        Me.TabView = New System.Windows.Forms.TabControl()
        Me.TabPageHexView = New System.Windows.Forms.TabPage()
        Me.HexViewer = New DSExplorer.HexViewControl()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.menuFiles = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.miExtract = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.miExpandAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.miReload = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        CType(Me.SplitContainer2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer2.Panel1.SuspendLayout
        Me.SplitContainer2.Panel2.SuspendLayout
        Me.SplitContainer2.SuspendLayout
        Me.TabView.SuspendLayout
        Me.TabPageHexView.SuspendLayout
        Me.menuFiles.SuspendLayout
        Me.SuspendLayout
        '
        'txtDataFolder
        '
        Me.txtDataFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtDataFolder.Location = New System.Drawing.Point(83, 12)
        Me.txtDataFolder.MinimumSize = New System.Drawing.Size(50, 4)
        Me.txtDataFolder.Name = "txtDataFolder"
        Me.txtDataFolder.Size = New System.Drawing.Size(754, 20)
        Me.txtDataFolder.TabIndex = 0
        '
        'btnSelect
        '
        Me.btnSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnSelect.Location = New System.Drawing.Point(843, 10)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(89, 23)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "Select..."
        Me.btnSelect.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data Folder:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 38)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtInfo)
        Me.SplitContainer1.Size = New System.Drawing.Size(920, 547)
        Me.SplitContainer1.SplitterDistance = 383
        Me.SplitContainer1.TabIndex = 3
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.treeFiles)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabView)
        Me.SplitContainer2.Size = New System.Drawing.Size(920, 383)
        Me.SplitContainer2.SplitterDistance = 324
        Me.SplitContainer2.TabIndex = 0
        '
        'treeFiles
        '
        Me.treeFiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.treeFiles.Location = New System.Drawing.Point(3, 3)
        Me.treeFiles.Name = "treeFiles"
        Me.treeFiles.Size = New System.Drawing.Size(318, 377)
        Me.treeFiles.TabIndex = 0
        '
        'TabView
        '
        Me.TabView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TabView.Controls.Add(Me.TabPageHexView)
        Me.TabView.Location = New System.Drawing.Point(3, 3)
        Me.TabView.Name = "TabView"
        Me.TabView.SelectedIndex = 0
        Me.TabView.Size = New System.Drawing.Size(586, 377)
        Me.TabView.TabIndex = 0
        '
        'TabPageHexView
        '
        Me.TabPageHexView.Controls.Add(Me.HexViewer)
        Me.TabPageHexView.Location = New System.Drawing.Point(4, 22)
        Me.TabPageHexView.Name = "TabPageHexView"
        Me.TabPageHexView.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageHexView.Size = New System.Drawing.Size(578, 351)
        Me.TabPageHexView.TabIndex = 1
        Me.TabPageHexView.Text = "Hex Viewer"
        Me.TabPageHexView.UseVisualStyleBackColor = true
        '
        'HexViewer
        '
        Me.HexViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.HexViewer.AutoScroll = true
        Me.HexViewer.AutoScrollMinSize = New System.Drawing.Size(1, 0)
        Me.HexViewer.Data = Nothing
        Me.HexViewer.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.HexViewer.Location = New System.Drawing.Point(0, 0)
        Me.HexViewer.Name = "HexViewer"
        Me.HexViewer.Size = New System.Drawing.Size(575, 348)
        Me.HexViewer.TabIndex = 0
        '
        'txtInfo
        '
        Me.txtInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtInfo.Location = New System.Drawing.Point(3, 3)
        Me.txtInfo.Multiline = true
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInfo.Size = New System.Drawing.Size(914, 157)
        Me.txtInfo.TabIndex = 0
        '
        'StatusStrip
        '
        Me.StatusStrip.Location = New System.Drawing.Point(0, 588)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(944, 22)
        Me.StatusStrip.TabIndex = 4
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'menuFiles
        '
        Me.menuFiles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miExtract, Me.ToolStripSeparator1, Me.miExpandAll, Me.miReload})
        Me.menuFiles.Name = "menuFiles"
        Me.menuFiles.Size = New System.Drawing.Size(136, 76)
        '
        'miExtract
        '
        Me.miExtract.Name = "miExtract"
        Me.miExtract.Size = New System.Drawing.Size(135, 22)
        Me.miExtract.Text = "Extract"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(132, 6)
        '
        'miExpandAll
        '
        Me.miExpandAll.Name = "miExpandAll"
        Me.miExpandAll.Size = New System.Drawing.Size(135, 22)
        Me.miExpandAll.Text = "Expand All"
        '
        'miReload
        '
        Me.miReload.Name = "miReload"
        Me.miReload.Size = New System.Drawing.Size(135, 22)
        Me.miReload.Text = "Reload Tree"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 610)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.txtDataFolder)
        Me.Name = "MainWindow"
        Me.Text = "DarkSouls Explorer"
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        Me.SplitContainer1.Panel2.PerformLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.SplitContainer2.Panel1.ResumeLayout(false)
        Me.SplitContainer2.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer2,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer2.ResumeLayout(false)
        Me.TabView.ResumeLayout(false)
        Me.TabPageHexView.ResumeLayout(false)
        Me.menuFiles.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents txtDataFolder As TextBox
    Friend WithEvents btnSelect As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txtInfo As TextBox
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents treeFiles As TreeView
    Friend WithEvents menuFiles As ContextMenuStrip
    Friend WithEvents miExtract As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents miReload As ToolStripMenuItem
    Friend WithEvents miExpandAll As ToolStripMenuItem
    Friend WithEvents TabView As TabControl
    Friend WithEvents TabPageHexView As TabPage
    Friend WithEvents HexViewer As HexViewControl
End Class
