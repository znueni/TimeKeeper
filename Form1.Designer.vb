<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RestartTimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetTimerDurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MaximizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlwaysStayOnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideFormBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.IncreaseTextSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecreaseTextSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.InvertColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestartTimerToolStripMenuItem, Me.ResetTimerDurationToolStripMenuItem, Me.ToolStripSeparator1, Me.MaximizeToolStripMenuItem, Me.AlwaysStayOnTopToolStripMenuItem, Me.HideFormBorderToolStripMenuItem, Me.InvertColorsToolStripMenuItem, Me.ToolStripSeparator2, Me.IncreaseTextSizeToolStripMenuItem, Me.DecreaseTextSizeToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(182, 192)
        '
        'RestartTimerToolStripMenuItem
        '
        Me.RestartTimerToolStripMenuItem.Name = "RestartTimerToolStripMenuItem"
        Me.RestartTimerToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.RestartTimerToolStripMenuItem.Text = "Restart timer"
        '
        'ResetTimerDurationToolStripMenuItem
        '
        Me.ResetTimerDurationToolStripMenuItem.Name = "ResetTimerDurationToolStripMenuItem"
        Me.ResetTimerDurationToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ResetTimerDurationToolStripMenuItem.Text = "Reset timer duration"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'MaximizeToolStripMenuItem
        '
        Me.MaximizeToolStripMenuItem.Name = "MaximizeToolStripMenuItem"
        Me.MaximizeToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.MaximizeToolStripMenuItem.Text = "Maximize"
        '
        'AlwaysStayOnTopToolStripMenuItem
        '
        Me.AlwaysStayOnTopToolStripMenuItem.Name = "AlwaysStayOnTopToolStripMenuItem"
        Me.AlwaysStayOnTopToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AlwaysStayOnTopToolStripMenuItem.Text = "Always stay on top"
        '
        'HideFormBorderToolStripMenuItem
        '
        Me.HideFormBorderToolStripMenuItem.Name = "HideFormBorderToolStripMenuItem"
        Me.HideFormBorderToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.HideFormBorderToolStripMenuItem.Text = "Hide Form border"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(178, 6)
        '
        'IncreaseTextSizeToolStripMenuItem
        '
        Me.IncreaseTextSizeToolStripMenuItem.Name = "IncreaseTextSizeToolStripMenuItem"
        Me.IncreaseTextSizeToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.IncreaseTextSizeToolStripMenuItem.Text = "Increase text size"
        '
        'DecreaseTextSizeToolStripMenuItem
        '
        Me.DecreaseTextSizeToolStripMenuItem.Name = "DecreaseTextSizeToolStripMenuItem"
        Me.DecreaseTextSizeToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.DecreaseTextSizeToolStripMenuItem.Text = "Decrease text size"
        '
        'lbl
        '
        Me.lbl.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 70.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(0, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(726, 422)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "double-click"
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'InvertColorsToolStripMenuItem
        '
        Me.InvertColorsToolStripMenuItem.Name = "InvertColorsToolStripMenuItem"
        Me.InvertColorsToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.InvertColorsToolStripMenuItem.Text = "Invert colors"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(726, 422)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.lbl)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents RestartTimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetTimerDurationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents MaximizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HideFormBorderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncreaseTextSizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DecreaseTextSizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl As Label
    Friend WithEvents AlwaysStayOnTopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents Timer1 As Timer
    Friend WithEvents InvertColorsToolStripMenuItem As ToolStripMenuItem
End Class
