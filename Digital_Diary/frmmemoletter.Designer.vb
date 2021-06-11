<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmemoletter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmemoletter))
        Me.txtcc = New System.Windows.Forms.TextBox
        Me.txtsub = New System.Windows.Forms.TextBox
        Me.txtrecp = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbCdate = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txturref = New System.Windows.Forms.TextBox
        Me.txtref = New System.Windows.Forms.TextBox
        Me.txtldate = New System.Windows.Forms.TextBox
        Me.txtsms = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnU = New System.Windows.Forms.Button
        Me.btnD = New System.Windows.Forms.Button
        Me.btnV = New System.Windows.Forms.Button
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtcc
        '
        Me.txtcc.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcc.Location = New System.Drawing.Point(89, 231)
        Me.txtcc.Name = "txtcc"
        Me.txtcc.Size = New System.Drawing.Size(166, 26)
        Me.txtcc.TabIndex = 5
        '
        'txtsub
        '
        Me.txtsub.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsub.Location = New System.Drawing.Point(89, 182)
        Me.txtsub.Multiline = True
        Me.txtsub.Name = "txtsub"
        Me.txtsub.Size = New System.Drawing.Size(166, 43)
        Me.txtsub.TabIndex = 4
        '
        'txtrecp
        '
        Me.txtrecp.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrecp.Location = New System.Drawing.Point(89, 143)
        Me.txtrecp.Name = "txtrecp"
        Me.txtrecp.Size = New System.Drawing.Size(166, 26)
        Me.txtrecp.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 19)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Cc:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 19)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Subject:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 19)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "To:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(283, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 19)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Current Date"
        '
        'lbCdate
        '
        Me.lbCdate.AutoSize = True
        Me.lbCdate.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCdate.Location = New System.Drawing.Point(470, 20)
        Me.lbCdate.Name = "lbCdate"
        Me.lbCdate.Size = New System.Drawing.Size(95, 19)
        Me.lbCdate.TabIndex = 72
        Me.lbCdate.Text = "Expiry Date(s)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(266, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 19)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Ref:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(397, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 19)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Message"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(77, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 19)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Date:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(431, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 19)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "ur Ref:"
        '
        'txturref
        '
        Me.txturref.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txturref.Location = New System.Drawing.Point(380, 99)
        Me.txturref.Name = "txturref"
        Me.txturref.Size = New System.Drawing.Size(125, 26)
        Me.txturref.TabIndex = 2
        '
        'txtref
        '
        Me.txtref.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtref.Location = New System.Drawing.Point(194, 99)
        Me.txtref.Name = "txtref"
        Me.txtref.ReadOnly = True
        Me.txtref.Size = New System.Drawing.Size(180, 26)
        Me.txtref.TabIndex = 1
        '
        'txtldate
        '
        Me.txtldate.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtldate.Location = New System.Drawing.Point(35, 99)
        Me.txtldate.Name = "txtldate"
        Me.txtldate.Size = New System.Drawing.Size(136, 26)
        Me.txtldate.TabIndex = 0
        '
        'txtsms
        '
        Me.txtsms.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsms.Location = New System.Drawing.Point(260, 164)
        Me.txtsms.Multiline = True
        Me.txtsms.Name = "txtsms"
        Me.txtsms.Size = New System.Drawing.Size(321, 260)
        Me.txtsms.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnU)
        Me.GroupBox2.Controls.Add(Me.btnD)
        Me.GroupBox2.Controls.Add(Me.btnV)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 317)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 95)
        Me.GroupBox2.TabIndex = 81
        Me.GroupBox2.TabStop = False
        '
        'btnU
        '
        Me.btnU.ForeColor = System.Drawing.Color.Black
        Me.btnU.Image = CType(resources.GetObject("btnU.Image"), System.Drawing.Image)
        Me.btnU.Location = New System.Drawing.Point(67, 55)
        Me.btnU.Name = "btnU"
        Me.btnU.Size = New System.Drawing.Size(75, 34)
        Me.btnU.TabIndex = 9
        Me.btnU.Text = "Prin&t"
        Me.btnU.UseVisualStyleBackColor = True
        '
        'btnD
        '
        Me.btnD.ForeColor = System.Drawing.Color.Black
        Me.btnD.Image = CType(resources.GetObject("btnD.Image"), System.Drawing.Image)
        Me.btnD.Location = New System.Drawing.Point(131, 11)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(75, 38)
        Me.btnD.TabIndex = 8
        Me.btnD.Text = "&Print Preview"
        Me.btnD.UseVisualStyleBackColor = True
        '
        'btnV
        '
        Me.btnV.ForeColor = System.Drawing.Color.Black
        Me.btnV.Image = CType(resources.GetObject("btnV.Image"), System.Drawing.Image)
        Me.btnV.Location = New System.Drawing.Point(10, 11)
        Me.btnV.Name = "btnV"
        Me.btnV.Size = New System.Drawing.Size(75, 38)
        Me.btnV.TabIndex = 7
        Me.btnV.Text = "&Save"
        Me.btnV.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frmmemoletter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.Digital_Diary.My.Resources.Resources.DataInterfaceBack
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(593, 436)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtsms)
        Me.Controls.Add(Me.txturref)
        Me.Controls.Add(Me.txtref)
        Me.Controls.Add(Me.txtldate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbCdate)
        Me.Controls.Add(Me.txtcc)
        Me.Controls.Add(Me.txtsub)
        Me.Controls.Add(Me.txtrecp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmmemoletter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Samtech Digital Diary | Memo & Letter"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcc As System.Windows.Forms.TextBox
    Friend WithEvents txtsub As System.Windows.Forms.TextBox
    Friend WithEvents txtrecp As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbCdate As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txturref As System.Windows.Forms.TextBox
    Friend WithEvents txtref As System.Windows.Forms.TextBox
    Friend WithEvents txtldate As System.Windows.Forms.TextBox
    Friend WithEvents txtsms As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnU As System.Windows.Forms.Button
    Friend WithEvents btnD As System.Windows.Forms.Button
    Friend WithEvents btnV As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
End Class
