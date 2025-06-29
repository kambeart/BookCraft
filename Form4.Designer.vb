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
        llblAddress = New LinkLabel()
        lblAddress = New Label()
        Label6 = New Label()
        Panel12 = New Panel()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        Panel11 = New Panel()
        RadioButton_Female = New RadioButton()
        RadioButton_Male = New RadioButton()
        Label3 = New Label()
        Panel10 = New Panel()
        llblPhone = New LinkLabel()
        lblPhone = New Label()
        Label4 = New Label()
        Panel8 = New Panel()
        Panel9 = New Panel()
        llbl_ChangeEmail = New LinkLabel()
        lblEmail = New Label()
        Label2 = New Label()
        txtEmail = New TextBox()
        Panel6 = New Panel()
        Panel7 = New Panel()
        lblName = New Label()
        Label1 = New Label()
        Panel13 = New Panel()
        Label7 = New Label()
        Label8 = New Label()
        Panel14 = New Panel()
        txtBio = New TextBox()
        btnBackToLoginPage = New Button()
        llblSettings = New LinkLabel()
        llblLogOut = New LinkLabel()
        CType(picPFP, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        Panel12.SuspendLayout()
        Panel11.SuspendLayout()
        Panel10.SuspendLayout()
        Panel8.SuspendLayout()
        Panel9.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        Panel14.SuspendLayout()
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
        Panel5.Controls.Add(llblAddress)
        Panel5.Controls.Add(lblAddress)
        Panel5.Controls.Add(Label6)
        Panel5.Controls.Add(Panel12)
        Panel5.Controls.Add(Panel11)
        Panel5.Controls.Add(Panel10)
        Panel5.Controls.Add(Panel8)
        Panel5.Controls.Add(Panel6)
        Panel5.Location = New Point(169, 305)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(996, 344)
        Panel5.TabIndex = 5
        ' 
        ' llblAddress
        ' 
        llblAddress.AutoSize = True
        llblAddress.Location = New Point(816, 276)
        llblAddress.Name = "llblAddress"
        llblAddress.Size = New Size(116, 20)
        llblAddress.TabIndex = 8
        llblAddress.TabStop = True
        llblAddress.Text = "Change Address"
        ' 
        ' lblAddress
        ' 
        lblAddress.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAddress.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        lblAddress.Location = New Point(184, 268)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(811, 33)
        lblAddress.TabIndex = 3
        lblAddress.Text = "(Address)"
        lblAddress.Visible = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label6.Location = New Point(12, 268)
        Label6.Name = "Label6"
        Label6.Size = New Size(176, 33)
        Label6.TabIndex = 6
        Label6.Text = "Address         :"
        ' 
        ' Panel12
        ' 
        Panel12.Controls.Add(DateTimePicker1)
        Panel12.Controls.Add(Label5)
        Panel12.Dock = DockStyle.Top
        Panel12.Location = New Point(0, 212)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(994, 53)
        Panel12.TabIndex = 5
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Font = New Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(184, 0)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(346, 34)
        DateTimePicker1.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label5.Location = New Point(5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(183, 33)
        Label5.TabIndex = 5
        Label5.Text = "Date Of Birth :"
        ' 
        ' Panel11
        ' 
        Panel11.Controls.Add(RadioButton_Female)
        Panel11.Controls.Add(RadioButton_Male)
        Panel11.Controls.Add(Label3)
        Panel11.Dock = DockStyle.Top
        Panel11.Location = New Point(0, 159)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(994, 53)
        Panel11.TabIndex = 4
        ' 
        ' RadioButton_Female
        ' 
        RadioButton_Female.AutoSize = True
        RadioButton_Female.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton_Female.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        RadioButton_Female.Location = New Point(301, -4)
        RadioButton_Female.Name = "RadioButton_Female"
        RadioButton_Female.Size = New Size(116, 37)
        RadioButton_Female.TabIndex = 5
        RadioButton_Female.TabStop = True
        RadioButton_Female.Text = "Female"
        RadioButton_Female.UseVisualStyleBackColor = True
        ' 
        ' RadioButton_Male
        ' 
        RadioButton_Male.AutoSize = True
        RadioButton_Male.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton_Male.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        RadioButton_Male.Location = New Point(202, -4)
        RadioButton_Male.Name = "RadioButton_Male"
        RadioButton_Male.Size = New Size(93, 37)
        RadioButton_Male.TabIndex = 4
        RadioButton_Male.TabStop = True
        RadioButton_Male.Text = "Male"
        RadioButton_Male.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label3.Location = New Point(1, -4)
        Label3.Name = "Label3"
        Label3.Size = New Size(187, 33)
        Label3.TabIndex = 3
        Label3.Text = "Gender            :"
        ' 
        ' Panel10
        ' 
        Panel10.Controls.Add(llblPhone)
        Panel10.Controls.Add(lblPhone)
        Panel10.Controls.Add(Label4)
        Panel10.Dock = DockStyle.Top
        Panel10.Location = New Point(0, 106)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(994, 53)
        Panel10.TabIndex = 3
        ' 
        ' llblPhone
        ' 
        llblPhone.AutoSize = True
        llblPhone.Location = New Point(810, 13)
        llblPhone.Name = "llblPhone"
        llblPhone.Size = New Size(162, 20)
        llblPhone.TabIndex = 7
        llblPhone.TabStop = True
        llblPhone.Text = "Change Phone Number"
        ' 
        ' lblPhone
        ' 
        lblPhone.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPhone.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        lblPhone.Location = New Point(184, 0)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(559, 33)
        lblPhone.TabIndex = 4
        lblPhone.Text = "(Phone Number)"
        lblPhone.Visible = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label4.Location = New Point(-1, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(189, 33)
        Label4.TabIndex = 4
        Label4.Text = "Phone Number:"
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(Panel9)
        Panel8.Dock = DockStyle.Top
        Panel8.Location = New Point(0, 53)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(994, 53)
        Panel8.TabIndex = 2
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(llbl_ChangeEmail)
        Panel9.Controls.Add(lblEmail)
        Panel9.Controls.Add(Label2)
        Panel9.Controls.Add(txtEmail)
        Panel9.Dock = DockStyle.Top
        Panel9.Location = New Point(0, 0)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(994, 53)
        Panel9.TabIndex = 3
        ' 
        ' llbl_ChangeEmail
        ' 
        llbl_ChangeEmail.AutoSize = True
        llbl_ChangeEmail.Location = New Point(832, 13)
        llbl_ChangeEmail.Name = "llbl_ChangeEmail"
        llbl_ChangeEmail.Size = New Size(100, 20)
        llbl_ChangeEmail.TabIndex = 6
        llbl_ChangeEmail.TabStop = True
        llbl_ChangeEmail.Text = "Change Email"
        ' 
        ' lblEmail
        ' 
        lblEmail.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmail.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        lblEmail.Location = New Point(193, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(619, 33)
        lblEmail.TabIndex = 3
        lblEmail.Text = "(Enter an Email"
        lblEmail.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label2.Location = New Point(1, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(186, 33)
        Label2.TabIndex = 2
        Label2.Text = "Email              :"
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.Font = New Font("Times New Roman", 16.2F)
        txtEmail.Location = New Point(184, 0)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(642, 32)
        txtEmail.TabIndex = 11
        txtEmail.Visible = False
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(Panel7)
        Panel6.Dock = DockStyle.Top
        Panel6.Location = New Point(0, 0)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(994, 53)
        Panel6.TabIndex = 0
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(lblName)
        Panel7.Controls.Add(Label1)
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(0, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(994, 53)
        Panel7.TabIndex = 1
        ' 
        ' lblName
        ' 
        lblName.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblName.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        lblName.Location = New Point(184, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(807, 33)
        lblName.TabIndex = 2
        lblName.Text = "(Name)"
        lblName.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(185, 33)
        Label1.TabIndex = 1
        Label1.Text = "Name              :"
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.Silver
        Panel13.Location = New Point(663, 82)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(388, 50)
        Panel13.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(663, 135)
        Label7.Name = "Label7"
        Label7.Size = New Size(42, 26)
        Label7.TabIndex = 7
        Label7.Text = "ID:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(700, 135)
        Label8.Name = "Label8"
        Label8.Size = New Size(52, 26)
        Label8.TabIndex = 8
        Label8.Text = "(ID)"
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = Color.White
        Panel14.Controls.Add(txtBio)
        Panel14.Location = New Point(662, 171)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(389, 85)
        Panel14.TabIndex = 9
        ' 
        ' txtBio
        ' 
        txtBio.Location = New Point(0, 0)
        txtBio.Multiline = True
        txtBio.Name = "txtBio"
        txtBio.Size = New Size(389, 108)
        txtBio.TabIndex = 0
        ' 
        ' btnBackToLoginPage
        ' 
        btnBackToLoginPage.BackColor = Color.FromArgb(CByte(210), CByte(227), CByte(188))
        btnBackToLoginPage.BackgroundImageLayout = ImageLayout.Zoom
        btnBackToLoginPage.FlatAppearance.BorderSize = 0
        btnBackToLoginPage.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(210), CByte(227), CByte(188))
        btnBackToLoginPage.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(210), CByte(227), CByte(188))
        btnBackToLoginPage.FlatStyle = FlatStyle.Flat
        btnBackToLoginPage.Image = My.Resources.Resources.Adobe_Express___file
        btnBackToLoginPage.Location = New Point(49, 55)
        btnBackToLoginPage.Name = "btnBackToLoginPage"
        btnBackToLoginPage.Size = New Size(78, 71)
        btnBackToLoginPage.TabIndex = 5
        btnBackToLoginPage.UseVisualStyleBackColor = False
        ' 
        ' llblSettings
        ' 
        llblSettings.ActiveLinkColor = Color.DarkGray
        llblSettings.AutoSize = True
        llblSettings.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        llblSettings.LinkColor = Color.Black
        llblSettings.Location = New Point(1190, 80)
        llblSettings.Name = "llblSettings"
        llblSettings.Size = New Size(76, 25)
        llblSettings.TabIndex = 7
        llblSettings.TabStop = True
        llblSettings.Text = "Settings"
        ' 
        ' llblLogOut
        ' 
        llblLogOut.ActiveLinkColor = Color.DarkGray
        llblLogOut.AutoSize = True
        llblLogOut.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        llblLogOut.LinkColor = Color.Black
        llblLogOut.Location = New Point(1183, 679)
        llblLogOut.Name = "llblLogOut"
        llblLogOut.Size = New Size(107, 33)
        llblLogOut.TabIndex = 10
        llblLogOut.TabStop = True
        llblLogOut.Text = "Log Out"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(210), CByte(227), CByte(188))
        ClientSize = New Size(1348, 721)
        Controls.Add(llblLogOut)
        Controls.Add(llblSettings)
        Controls.Add(btnBackToLoginPage)
        Controls.Add(Panel14)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Panel13)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(LinkImageUpload)
        Controls.Add(picPFP)
        Controls.Add(Panel1)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Profile"
        CType(picPFP, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel14.ResumeLayout(False)
        Panel14.PerformLayout()
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
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents RadioButton_Male As RadioButton
    Friend WithEvents lblPhone As Label
    Friend WithEvents RadioButton_Female As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblAddress As Label
    Friend WithEvents llblPhone As LinkLabel
    Friend WithEvents llbl_ChangeEmail As LinkLabel
    Friend WithEvents llblAddress As LinkLabel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents txtBio As TextBox
    Friend WithEvents btnBackToLoginPage As Button
    Friend WithEvents llblSettings As LinkLabel
    Friend WithEvents llblLogOut As LinkLabel
    Friend WithEvents txtEmail As TextBox
End Class
