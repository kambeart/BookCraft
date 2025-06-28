<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        picPFP = New PictureBox()
        LinkImageUpload = New LinkLabel()
        OpenFileDialog1 = New OpenFileDialog()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CType(picPFP, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' picPFP
        ' 
        picPFP.Image = My.Resources.Resources.pfp_icon_21
        picPFP.Location = New Point(415, 61)
        picPFP.Name = "picPFP"
        picPFP.Size = New Size(216, 195)
        picPFP.SizeMode = PictureBoxSizeMode.Zoom
        picPFP.TabIndex = 0
        picPFP.TabStop = False
        ' 
        ' LinkImageUpload
        ' 
        LinkImageUpload.AutoSize = True
        LinkImageUpload.Location = New Point(471, 259)
        LinkImageUpload.Name = "LinkImageUpload"
        LinkImageUpload.Size = New Size(104, 20)
        LinkImageUpload.TabIndex = 1
        LinkImageUpload.TabStop = True
        LinkImageUpload.Text = "Upload Image"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Panel1
        ' 
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1348, 55)
        Panel1.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel3)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 55)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(52, 666)
        Panel2.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(52, 666)
        Panel3.TabIndex = 4
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Right
        Panel4.Location = New Point(1296, 55)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(52, 666)
        Panel4.TabIndex = 4
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(Label5)
        Panel5.Controls.Add(Label4)
        Panel5.Controls.Add(Label3)
        Panel5.Controls.Add(Label2)
        Panel5.Controls.Add(Label1)
        Panel5.Location = New Point(169, 305)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(996, 309)
        Panel5.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label1.Location = New Point(3, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 33)
        Label1.TabIndex = 1
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label2.Location = New Point(3, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 33)
        Label2.TabIndex = 2
        Label2.Text = "Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label3.Location = New Point(3, 184)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 33)
        Label3.TabIndex = 3
        Label3.Text = "Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label4.Location = New Point(3, 117)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 33)
        Label4.TabIndex = 4
        Label4.Text = "Name:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label5.Location = New Point(-1, 246)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 33)
        Label5.TabIndex = 5
        Label5.Text = "Name:"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(210), CByte(227), CByte(188))
        ClientSize = New Size(1348, 721)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(LinkImageUpload)
        Controls.Add(picPFP)
        Name = "Form4"
        Text = "Profile"
        CType(picPFP, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picPFP As PictureBox
    Friend WithEvents LinkImageUpload As LinkLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
