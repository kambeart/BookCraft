﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        btnBookMarket = New Button()
        btnGoToProfile = New Button()
        btnEbook = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1348, 145)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.WhatsApp_Image_2025_05_21_at_18_24_37_f09943ca
        PictureBox1.Location = New Point(1212, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(124, 119)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(69, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(260, 46)
        Label1.TabIndex = 0
        Label1.Text = "E-Books Section"
        ' 
        ' Panel2
        ' 
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 145)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1348, 66)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(70, 213)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1202, 333)
        Panel3.TabIndex = 2
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Sienna
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(btnBookMarket, 0, 0)
        TableLayoutPanel1.Controls.Add(btnGoToProfile, 2, 0)
        TableLayoutPanel1.Controls.Add(btnEbook, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Bottom
        TableLayoutPanel1.Location = New Point(0, 595)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1348, 126)
        TableLayoutPanel1.TabIndex = 3
        ' 
        ' btnBookMarket
        ' 
        btnBookMarket.Anchor = AnchorStyles.None
        btnBookMarket.FlatAppearance.BorderSize = 0
        btnBookMarket.FlatStyle = FlatStyle.Flat
        btnBookMarket.Image = My.Resources.Resources.book_icon_resize
        btnBookMarket.Location = New Point(6, 6)
        btnBookMarket.Name = "btnBookMarket"
        btnBookMarket.Size = New Size(439, 113)
        btnBookMarket.TabIndex = 5
        btnBookMarket.UseVisualStyleBackColor = True
        ' 
        ' btnGoToProfile
        ' 
        btnGoToProfile.Anchor = AnchorStyles.None
        btnGoToProfile.BackColor = Color.Sienna
        btnGoToProfile.FlatAppearance.BorderSize = 0
        btnGoToProfile.FlatStyle = FlatStyle.Flat
        btnGoToProfile.Image = My.Resources.Resources.pfp_icon_2_uodated
        btnGoToProfile.Location = New Point(902, 6)
        btnGoToProfile.Name = "btnGoToProfile"
        btnGoToProfile.Size = New Size(440, 113)
        btnGoToProfile.TabIndex = 2
        btnGoToProfile.UseVisualStyleBackColor = False
        ' 
        ' btnEbook
        ' 
        btnEbook.Anchor = AnchorStyles.None
        btnEbook.FlatAppearance.BorderSize = 0
        btnEbook.FlatStyle = FlatStyle.Flat
        btnEbook.Image = My.Resources.Resources.Ebook_Icon_Resize
        btnEbook.Location = New Point(454, 6)
        btnEbook.Name = "btnEbook"
        btnEbook.Size = New Size(439, 113)
        btnEbook.TabIndex = 4
        btnEbook.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(210), CByte(227), CByte(188))
        ClientSize = New Size(1348, 721)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "E-Book Menu"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnGoToProfile As Button
    Friend WithEvents btnEbook As Button
    Friend WithEvents btnBookMarket As Button
End Class
