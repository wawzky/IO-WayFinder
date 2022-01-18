<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SHOWWAY
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SHOWWAY))
        Me.PanelVid = New System.Windows.Forms.Panel()
        Me.PATHVIEW = New AxAXVLC.AxVLCPlugin2()
        Me.Panelprint = New System.Windows.Forms.Panel()
        Me.Panelbig = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Panelsmall = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Picmap = New System.Windows.Forms.PictureBox()
        Me.TxtTitle = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelRep = New System.Windows.Forms.Panel()
        Me.Replay = New System.Windows.Forms.Button()
        Me.BckD = New System.Windows.Forms.Button()
        Me.PrintRec = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelVid.SuspendLayout()
        CType(Me.PATHVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelprint.SuspendLayout()
        Me.Panelbig.SuspendLayout()
        Me.Panelsmall.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picmap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRep.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelVid
        '
        Me.PanelVid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelVid.Controls.Add(Me.PATHVIEW)
        Me.PanelVid.Location = New System.Drawing.Point(29, 29)
        Me.PanelVid.Margin = New System.Windows.Forms.Padding(20)
        Me.PanelVid.Name = "PanelVid"
        Me.PanelVid.Size = New System.Drawing.Size(1498, 826)
        Me.PanelVid.TabIndex = 8
        '
        'PATHVIEW
        '
        Me.PATHVIEW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PATHVIEW.Enabled = True
        Me.PATHVIEW.Location = New System.Drawing.Point(0, 0)
        Me.PATHVIEW.MaximumSize = New System.Drawing.Size(1498, 826)
        Me.PATHVIEW.Name = "PATHVIEW"
        Me.PATHVIEW.OcxState = CType(resources.GetObject("PATHVIEW.OcxState"), System.Windows.Forms.AxHost.State)
        Me.PATHVIEW.Size = New System.Drawing.Size(1498, 826)
        Me.PATHVIEW.TabIndex = 4
        Me.PATHVIEW.UseWaitCursor = True
        '
        'Panelprint
        '
        Me.Panelprint.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panelprint.BackColor = System.Drawing.Color.Gold
        Me.Panelprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panelprint.Controls.Add(Me.Panelbig)
        Me.Panelprint.Location = New System.Drawing.Point(29, 29)
        Me.Panelprint.Margin = New System.Windows.Forms.Padding(20)
        Me.Panelprint.Name = "Panelprint"
        Me.Panelprint.Size = New System.Drawing.Size(1498, 826)
        Me.Panelprint.TabIndex = 8
        Me.Panelprint.Visible = False
        '
        'Panelbig
        '
        Me.Panelbig.BackColor = System.Drawing.Color.Orange
        Me.Panelbig.Controls.Add(Me.btnPrint)
        Me.Panelbig.Controls.Add(Me.Panelsmall)
        Me.Panelbig.Location = New System.Drawing.Point(1230, 60)
        Me.Panelbig.Margin = New System.Windows.Forms.Padding(631, 62, 619, 30)
        Me.Panelbig.Name = "Panelbig"
        Me.Panelbig.Size = New System.Drawing.Size(235, 680)
        Me.Panelbig.TabIndex = 1
        '
        'btnPrint
        '
        Me.btnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPrint.BackColor = System.Drawing.Color.Red
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.btnPrint.FlatAppearance.BorderSize = 3
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Rockwell Extra Bold", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPrint.Location = New System.Drawing.Point(10, 594)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(10, 5, 10, 10)
        Me.btnPrint.MinimumSize = New System.Drawing.Size(76, 76)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(215, 76)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Panelsmall
        '
        Me.Panelsmall.BackColor = System.Drawing.Color.White
        Me.Panelsmall.Controls.Add(Me.PictureBox1)
        Me.Panelsmall.Controls.Add(Me.Picmap)
        Me.Panelsmall.Controls.Add(Me.TxtTitle)
        Me.Panelsmall.Location = New System.Drawing.Point(10, 10)
        Me.Panelsmall.Margin = New System.Windows.Forms.Padding(10, 10, 10, 3)
        Me.Panelsmall.Name = "Panelsmall"
        Me.Panelsmall.Size = New System.Drawing.Size(215, 571)
        Me.Panelsmall.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.IO.My.Resources.Resources.qwe
        Me.PictureBox1.Location = New System.Drawing.Point(62, 74)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(62, 3, 62, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Picmap
        '
        Me.Picmap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Picmap.BackColor = System.Drawing.Color.Transparent
        Me.Picmap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Picmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Picmap.Location = New System.Drawing.Point(5, 171)
        Me.Picmap.Margin = New System.Windows.Forms.Padding(3, 30, 3, 3)
        Me.Picmap.Name = "Picmap"
        Me.Picmap.Size = New System.Drawing.Size(205, 205)
        Me.Picmap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Picmap.TabIndex = 2
        Me.Picmap.TabStop = False
        '
        'TxtTitle
        '
        Me.TxtTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTitle.Font = New System.Drawing.Font("Rockwell Extra Bold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitle.Location = New System.Drawing.Point(5, 5)
        Me.TxtTitle.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(205, 61)
        Me.TxtTitle.TabIndex = 1
        Me.TxtTitle.Text = "B.E. Building WayFinder"
        Me.TxtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'PanelRep
        '
        Me.PanelRep.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelRep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelRep.BackColor = System.Drawing.Color.Maroon
        Me.PanelRep.Controls.Add(Me.Replay)
        Me.PanelRep.Controls.Add(Me.BckD)
        Me.PanelRep.Controls.Add(Me.PrintRec)
        Me.PanelRep.Location = New System.Drawing.Point(29, 29)
        Me.PanelRep.Name = "PanelRep"
        Me.PanelRep.Size = New System.Drawing.Size(223, 826)
        Me.PanelRep.TabIndex = 11
        '
        'Replay
        '
        Me.Replay.AutoSize = True
        Me.Replay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Replay.BackColor = System.Drawing.Color.Gold
        Me.Replay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Replay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Replay.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.Replay.FlatAppearance.BorderSize = 3
        Me.Replay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Replay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Replay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Replay.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Replay.ForeColor = System.Drawing.Color.Black
        Me.Replay.Image = Global.IO.My.Resources.Resources.rep6
        Me.Replay.Location = New System.Drawing.Point(0, 261)
        Me.Replay.Margin = New System.Windows.Forms.Padding(436, 10, 10, 3)
        Me.Replay.MinimumSize = New System.Drawing.Size(109, 51)
        Me.Replay.Name = "Replay"
        Me.Replay.Size = New System.Drawing.Size(140, 140)
        Me.Replay.TabIndex = 8
        Me.Replay.UseVisualStyleBackColor = False
        '
        'BckD
        '
        Me.BckD.AutoSize = True
        Me.BckD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BckD.BackColor = System.Drawing.Color.Gold
        Me.BckD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BckD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BckD.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.BckD.FlatAppearance.BorderSize = 3
        Me.BckD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.BckD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BckD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BckD.ForeColor = System.Drawing.Color.Black
        Me.BckD.Image = Global.IO.My.Resources.Resources.camera_back
        Me.BckD.Location = New System.Drawing.Point(0, 0)
        Me.BckD.Margin = New System.Windows.Forms.Padding(10, 10, 40, 10)
        Me.BckD.MinimumSize = New System.Drawing.Size(76, 76)
        Me.BckD.Name = "BckD"
        Me.BckD.Size = New System.Drawing.Size(76, 76)
        Me.BckD.TabIndex = 10
        Me.BckD.UseVisualStyleBackColor = False
        '
        'PrintRec
        '
        Me.PrintRec.AutoSize = True
        Me.PrintRec.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PrintRec.BackColor = System.Drawing.Color.Gold
        Me.PrintRec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PrintRec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PrintRec.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.PrintRec.FlatAppearance.BorderSize = 3
        Me.PrintRec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.PrintRec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.PrintRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintRec.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintRec.ForeColor = System.Drawing.Color.Black
        Me.PrintRec.Image = Global.IO.My.Resources.Resources.printlocs
        Me.PrintRec.Location = New System.Drawing.Point(0, 598)
        Me.PrintRec.Margin = New System.Windows.Forms.Padding(10, 10, 30, 24)
        Me.PrintRec.MinimumSize = New System.Drawing.Size(109, 51)
        Me.PrintRec.Name = "PrintRec"
        Me.PrintRec.Size = New System.Drawing.Size(140, 204)
        Me.PrintRec.TabIndex = 9
        Me.PrintRec.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Location = New System.Drawing.Point(1304, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(223, 826)
        Me.Panel1.TabIndex = 11
        '
        'SHOWWAY
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(1556, 884)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelRep)
        Me.Controls.Add(Me.PanelVid)
        Me.Controls.Add(Me.Panelprint)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.Name = "SHOWWAY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelVid.ResumeLayout(False)
        CType(Me.PATHVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelprint.ResumeLayout(False)
        Me.Panelbig.ResumeLayout(False)
        Me.Panelsmall.ResumeLayout(False)
        Me.Panelsmall.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picmap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRep.ResumeLayout(False)
        Me.PanelRep.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrintRec As Button
    Friend WithEvents Replay As Button
    Friend WithEvents PanelVid As Panel
    Friend WithEvents PATHVIEW As AxAXVLC.AxVLCPlugin2
    Friend WithEvents BckD As Button
    Friend WithEvents Panelprint As Panel
    Friend WithEvents Panelbig As Panel
    Friend WithEvents Panelsmall As Panel
    Friend WithEvents btnPrint As Button
    Friend WithEvents TxtTitle As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Picmap As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelRep As Panel
    Friend WithEvents Panel1 As Panel
End Class
