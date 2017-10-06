<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.clockCheckTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ICCondition = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ErrorInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NextDwload = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PicBox700_00 = New System.Windows.Forms.PictureBox()
        Me.PicBox700_12 = New System.Windows.Forms.PictureBox()
        Me.PicBox850_00 = New System.Windows.Forms.PictureBox()
        Me.PicBox850_12 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PicBox500_00 = New System.Windows.Forms.PictureBox()
        Me.PicBox500_12 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StatusStrip.SuspendLayout()
        CType(Me.PicBox700_00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox700_12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox850_00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox850_12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox500_00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox500_12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clockCheckTimer
        '
        Me.clockCheckTimer.Enabled = True
        Me.clockCheckTimer.Interval = 10000
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ICCondition, Me.ErrorInfo, Me.NextDwload})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 541)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(915, 23)
        Me.StatusStrip.TabIndex = 0
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ICCondition
        '
        Me.ICCondition.ForeColor = System.Drawing.Color.DarkGreen
        Me.ICCondition.Name = "ICCondition"
        Me.ICCondition.Size = New System.Drawing.Size(182, 18)
        Me.ICCondition.Text = "Internet Connection Condition"
        '
        'ErrorInfo
        '
        Me.ErrorInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ErrorInfo.Name = "ErrorInfo"
        Me.ErrorInfo.Size = New System.Drawing.Size(66, 18)
        Me.ErrorInfo.Text = "Error info."
        '
        'NextDwload
        '
        Me.NextDwload.Name = "NextDwload"
        Me.NextDwload.Size = New System.Drawing.Size(103, 18)
        Me.NextDwload.Text = "Download clock:"
        '
        'PicBox700_00
        '
        Me.PicBox700_00.BackgroundImage = Global.upperWeatherMapDownload.My.Resources.Resources.no_image2
        Me.PicBox700_00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicBox700_00.Location = New System.Drawing.Point(308, 12)
        Me.PicBox700_00.Name = "PicBox700_00"
        Me.PicBox700_00.Size = New System.Drawing.Size(290, 240)
        Me.PicBox700_00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox700_00.TabIndex = 1
        Me.PicBox700_00.TabStop = False
        '
        'PicBox700_12
        '
        Me.PicBox700_12.BackgroundImage = Global.upperWeatherMapDownload.My.Resources.Resources.no_image2
        Me.PicBox700_12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicBox700_12.Location = New System.Drawing.Point(308, 271)
        Me.PicBox700_12.Name = "PicBox700_12"
        Me.PicBox700_12.Size = New System.Drawing.Size(290, 240)
        Me.PicBox700_12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox700_12.TabIndex = 2
        Me.PicBox700_12.TabStop = False
        '
        'PicBox850_00
        '
        Me.PicBox850_00.BackgroundImage = Global.upperWeatherMapDownload.My.Resources.Resources.no_image2
        Me.PicBox850_00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicBox850_00.Location = New System.Drawing.Point(612, 12)
        Me.PicBox850_00.Name = "PicBox850_00"
        Me.PicBox850_00.Size = New System.Drawing.Size(290, 240)
        Me.PicBox850_00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox850_00.TabIndex = 3
        Me.PicBox850_00.TabStop = False
        '
        'PicBox850_12
        '
        Me.PicBox850_12.BackgroundImage = Global.upperWeatherMapDownload.My.Resources.Resources.no_image2
        Me.PicBox850_12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicBox850_12.Location = New System.Drawing.Point(612, 271)
        Me.PicBox850_12.Name = "PicBox850_12"
        Me.PicBox850_12.Size = New System.Drawing.Size(290, 240)
        Me.PicBox850_12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox850_12.TabIndex = 4
        Me.PicBox850_12.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(396, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fig. 700 hPa 00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(396, 514)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fig. 700 hPa 12"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(728, 514)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fig. 850 hPa 12"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(728, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fig. 850 hPa 00"
        '
        'PicBox500_00
        '
        Me.PicBox500_00.BackgroundImage = Global.upperWeatherMapDownload.My.Resources.Resources.no_image2
        Me.PicBox500_00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicBox500_00.Location = New System.Drawing.Point(12, 12)
        Me.PicBox500_00.Name = "PicBox500_00"
        Me.PicBox500_00.Size = New System.Drawing.Size(290, 240)
        Me.PicBox500_00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox500_00.TabIndex = 9
        Me.PicBox500_00.TabStop = False
        '
        'PicBox500_12
        '
        Me.PicBox500_12.BackgroundImage = Global.upperWeatherMapDownload.My.Resources.Resources.no_image2
        Me.PicBox500_12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicBox500_12.Location = New System.Drawing.Point(12, 271)
        Me.PicBox500_12.Name = "PicBox500_12"
        Me.PicBox500_12.Size = New System.Drawing.Size(290, 240)
        Me.PicBox500_12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox500_12.TabIndex = 10
        Me.PicBox500_12.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(105, 514)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 12)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Fig. 500 hPa 12"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(105, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 12)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Fig. 500 hPa 00"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(915, 564)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PicBox500_12)
        Me.Controls.Add(Me.PicBox500_00)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicBox850_12)
        Me.Controls.Add(Me.PicBox850_00)
        Me.Controls.Add(Me.PicBox700_12)
        Me.Controls.Add(Me.PicBox700_00)
        Me.Controls.Add(Me.StatusStrip)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Upper Weather Map Downloader"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.PicBox700_00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox700_12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox850_00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox850_12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox500_00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox500_12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents clockCheckTimer As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ICCondition As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ErrorInfo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents NextDwload As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PicBox700_00 As System.Windows.Forms.PictureBox
    Friend WithEvents PicBox700_12 As System.Windows.Forms.PictureBox
    Friend WithEvents PicBox850_00 As System.Windows.Forms.PictureBox
    Friend WithEvents PicBox850_12 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PicBox500_00 As System.Windows.Forms.PictureBox
    Friend WithEvents PicBox500_12 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
