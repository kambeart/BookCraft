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
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogIn = New Button()
        TextBox1 = New TextBox()
        btnSignIn = New Button()
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
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1366, 343)
        Panel1.TabIndex = 1
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Cursor = Cursors.IBeam
        txtUsername.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(457, 349)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "                                        USERNAME"
        txtUsername.Size = New Size(401, 27)
        txtUsername.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Cursor = Cursors.IBeam
        txtPassword.Location = New Point(457, 403)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "                                        PASSWORD"
        txtPassword.Size = New Size(401, 27)
        txtPassword.TabIndex = 3
        ' 
        ' btnLogIn
        ' 
        btnLogIn.BackColor = Color.FromArgb(CByte(38), CByte(222), CByte(129))
        btnLogIn.FlatAppearance.BorderSize = 0
        btnLogIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(33), CByte(140), CByte(116))
        btnLogIn.FlatStyle = FlatStyle.Popup
        btnLogIn.Font = New Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogIn.Location = New Point(457, 519)
        btnLogIn.Name = "btnLogIn"
        btnLogIn.Size = New Size(401, 50)
        btnLogIn.TabIndex = 4
        btnLogIn.Text = "Log In"
        btnLogIn.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.Location = New Point(457, 464)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "                                     ADMIN PASSKEY"
        TextBox1.Size = New Size(401, 27)
        TextBox1.TabIndex = 5
        ' 
        ' btnSignIn
        ' 
        btnSignIn.BackColor = Color.FromArgb(CByte(210), CByte(227), CByte(188))
        btnSignIn.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnSignIn.FlatAppearance.BorderSize = 0
        btnSignIn.FlatStyle = FlatStyle.Flat
        btnSignIn.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSignIn.Location = New Point(521, 595)
        btnSignIn.Name = "btnSignIn"
        btnSignIn.Size = New Size(287, 29)
        btnSignIn.TabIndex = 6
        btnSignIn.Text = "Don't Have an Account? Sign in Here"
        btnSignIn.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(210), CByte(227), CByte(188))
        ClientSize = New Size(1366, 768)
        Controls.Add(btnSignIn)
        Controls.Add(TextBox1)
        Controls.Add(btnLogIn)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Panel1)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Page"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogIn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnSignIn As Button

End Class
