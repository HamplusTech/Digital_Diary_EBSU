<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsetting))
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.btnfs = New System.Windows.Forms.Button
        Me.btncs = New System.Windows.Forms.Button
        Me.btnfcs = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnfs
        '
        Me.btnfs.ForeColor = System.Drawing.Color.Black
        Me.btnfs.Image = CType(resources.GetObject("btnfs.Image"), System.Drawing.Image)
        Me.btnfs.Location = New System.Drawing.Point(37, 104)
        Me.btnfs.Name = "btnfs"
        Me.btnfs.Size = New System.Drawing.Size(163, 38)
        Me.btnfs.TabIndex = 10
        Me.btnfs.Text = "&Font Settings"
        Me.btnfs.UseVisualStyleBackColor = True
        '
        'btncs
        '
        Me.btncs.ForeColor = System.Drawing.Color.Black
        Me.btncs.Image = CType(resources.GetObject("btncs.Image"), System.Drawing.Image)
        Me.btncs.Location = New System.Drawing.Point(37, 43)
        Me.btncs.Name = "btncs"
        Me.btncs.Size = New System.Drawing.Size(163, 38)
        Me.btncs.TabIndex = 9
        Me.btncs.Text = "&Colour Setting"
        Me.btncs.UseVisualStyleBackColor = True
        '
        'btnfcs
        '
        Me.btnfcs.ForeColor = System.Drawing.Color.Black
        Me.btnfcs.Image = CType(resources.GetObject("btnfcs.Image"), System.Drawing.Image)
        Me.btnfcs.Location = New System.Drawing.Point(37, 160)
        Me.btnfcs.Name = "btnfcs"
        Me.btnfcs.Size = New System.Drawing.Size(163, 38)
        Me.btnfcs.TabIndex = 11
        Me.btnfcs.Text = "Font C&olour settings"
        Me.btnfcs.UseVisualStyleBackColor = True
        '
        'frmsetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.Digital_Diary.My.Resources.Resources.DataInterfaceBack
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(314, 235)
        Me.Controls.Add(Me.btnfcs)
        Me.Controls.Add(Me.btnfs)
        Me.Controls.Add(Me.btncs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmsetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Samtech Digital Diary | Settings"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents btnfs As System.Windows.Forms.Button
    Friend WithEvents btncs As System.Windows.Forms.Button
    Friend WithEvents btnfcs As System.Windows.Forms.Button
End Class
