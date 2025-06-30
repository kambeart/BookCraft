<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        btnSignIn = New Button()
        btnLogIn = New Button()
        linkForgotPass = New LinkLabel()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        TextBox1 = New TextBox()
        Panel2 = New Panel()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.WhatsApp_Image_2025_05_21_at_18_24_37_f09943ca
        PictureBox1.Location = New Point(511, 40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(287, 272)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(btnSignIn)
        Panel1.Controls.Add(btnLogIn)
        Panel1.Controls.Add(linkForgotPass)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(txtUsername)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1348, 768)
        Panel1.TabIndex = 1
        ' 
        ' btnSignIn
        ' 
        btnSignIn.BackColor = Color.FromArgb(CByte(38), CByte(222), CByte(129))
        btnSignIn.FlatAppearance.BorderSize = 0
        btnSignIn.FlatAppearance.MouseOverBackColor = Color.Teal
        btnSignIn.FlatStyle = FlatStyle.Popup
        btnSignIn.Font = New Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSignIn.Location = New Point(655, 517)
        btnSignIn.Name = "btnSignIn"
        btnSignIn.Size = New Size(128, 50)
        btnSignIn.TabIndex = 5
        btnSignIn.Text = "Sign Up"
        btnSignIn.UseVisualStyleBackColor = False
        ' 
        ' btnLogIn
        ' 
        btnLogIn.BackColor = Color.FromArgb(CByte(38), CByte(222), CByte(129))
        btnLogIn.FlatAppearance.BorderSize = 0
        btnLogIn.FlatAppearance.MouseOverBackColor = Color.Teal
        btnLogIn.FlatStyle = FlatStyle.Popup
        btnLogIn.Font = New Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogIn.Location = New Point(520, 517)
        btnLogIn.Name = "btnLogIn"
        btnLogIn.Size = New Size(129, 50)
        btnLogIn.TabIndex = 4
        btnLogIn.Text = "Log In"
        btnLogIn.UseVisualStyleBackColor = False
        ' 
        ' linkForgotPass
        ' 
        linkForgotPass.AutoSize = True
        linkForgotPass.Location = New Point(596, 594)
        linkForgotPass.Name = "linkForgotPass"
        linkForgotPass.Size = New Size(118, 20)
        linkForgotPass.TabIndex = 1
        linkForgotPass.TabStop = True
        linkForgotPass.Text = "Forgot Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Cursor = Cursors.IBeam
        txtUsername.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(511, 343)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "USERNAME"
        txtUsername.Size = New Size(287, 27)
        txtUsername.TabIndex = 2
        txtUsername.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Cursor = Cursors.IBeam
        txtPassword.Location = New Point(511, 403)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = "PASSWORD"
        txtPassword.Size = New Size(287, 27)
        txtPassword.TabIndex = 3
        txtPassword.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.Location = New Point(511, 464)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "ADMIN PASSKEY"
        TextBox1.Size = New Size(287, 27)
        TextBox1.TabIndex = 5
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel2
        ' 
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1348, 34)
        Panel2.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Image = My.Resources.Resources._75519_icon_size_15_removebg_preview
        Button1.Location = New Point(1311, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(37, 34)
        Button1.TabIndex = 7
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(210), CByte(227), CByte(188))
        ClientSize = New Size(1348, 721)
        Controls.Add(TextBox1)
        Controls.Add(txtPassword)
        Controls.Add(Panel1)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Page"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogIn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents linkForgotPass As LinkLabel
    Friend WithEvents btnSignIn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button

End Class
