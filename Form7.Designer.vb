<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Label1 = New Label()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        RadioButton_Ewallet = New RadioButton()
        Panel2 = New Panel()
        RadioButton_OnlineBanking = New RadioButton()
        Panel3 = New Panel()
        RadioButton1 = New RadioButton()
        btnBackToShoppingCart = New Button()
        btnConfirmPayment = New Button()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(440, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(446, 46)
        Label1.TabIndex = 1
        Label1.Text = "Choose A Transaction Option"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(RadioButton_Ewallet)
        Panel1.Location = New Point(78, 98)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1184, 125)
        Panel1.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Qr_Payment
        PictureBox2.Location = New Point(1003, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(139, 119)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.TNG_ICON
        PictureBox1.Location = New Point(858, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(139, 119)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' RadioButton_Ewallet
        ' 
        RadioButton_Ewallet.AutoSize = True
        RadioButton_Ewallet.Font = New Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton_Ewallet.Location = New Point(47, 41)
        RadioButton_Ewallet.Name = "RadioButton_Ewallet"
        RadioButton_Ewallet.Size = New Size(210, 44)
        RadioButton_Ewallet.TabIndex = 0
        RadioButton_Ewallet.TabStop = True
        RadioButton_Ewallet.Text = "E-Wallet / QR"
        RadioButton_Ewallet.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(RadioButton_OnlineBanking)
        Panel2.Location = New Point(78, 282)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1184, 124)
        Panel2.TabIndex = 3
        ' 
        ' RadioButton_OnlineBanking
        ' 
        RadioButton_OnlineBanking.AutoSize = True
        RadioButton_OnlineBanking.Font = New Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton_OnlineBanking.Location = New Point(47, 39)
        RadioButton_OnlineBanking.Name = "RadioButton_OnlineBanking"
        RadioButton_OnlineBanking.Size = New Size(231, 44)
        RadioButton_OnlineBanking.TabIndex = 1
        RadioButton_OnlineBanking.TabStop = True
        RadioButton_OnlineBanking.Text = "Online Banking"
        RadioButton_OnlineBanking.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(PictureBox5)
        Panel3.Controls.Add(RadioButton1)
        Panel3.Location = New Point(78, 465)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1184, 125)
        Panel3.TabIndex = 3
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton1.Location = New Point(47, 41)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(99, 44)
        RadioButton1.TabIndex = 2
        RadioButton1.TabStop = True
        RadioButton1.Text = "Card"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' btnBackToShoppingCart
        ' 
        btnBackToShoppingCart.BackColor = Color.FromArgb(CByte(210), CByte(227), CByte(188))
        btnBackToShoppingCart.BackgroundImageLayout = ImageLayout.Zoom
        btnBackToShoppingCart.FlatAppearance.BorderSize = 0
        btnBackToShoppingCart.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(210), CByte(227), CByte(188))
        btnBackToShoppingCart.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(210), CByte(227), CByte(188))
        btnBackToShoppingCart.FlatStyle = FlatStyle.Flat
        btnBackToShoppingCart.Image = My.Resources.Resources.Adobe_Express___file
        btnBackToShoppingCart.Location = New Point(12, 638)
        btnBackToShoppingCart.Name = "btnBackToShoppingCart"
        btnBackToShoppingCart.Size = New Size(78, 71)
        btnBackToShoppingCart.TabIndex = 6
        btnBackToShoppingCart.UseVisualStyleBackColor = False
        ' 
        ' btnConfirmPayment
        ' 
        btnConfirmPayment.BackColor = Color.Sienna
        btnConfirmPayment.FlatAppearance.BorderSize = 0
        btnConfirmPayment.FlatStyle = FlatStyle.Flat
        btnConfirmPayment.Font = New Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnConfirmPayment.Location = New Point(539, 638)
        btnConfirmPayment.Name = "btnConfirmPayment"
        btnConfirmPayment.Size = New Size(263, 53)
        btnConfirmPayment.TabIndex = 7
        btnConfirmPayment.Text = "Confirm"
        btnConfirmPayment.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.Maybank_Icon2
        PictureBox3.Location = New Point(858, 0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(139, 121)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.CImb_Icon
        PictureBox4.Location = New Point(1003, 0)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(139, 121)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 4
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.Card_Icon
        PictureBox5.Location = New Point(937, 4)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(139, 121)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 5
        PictureBox5.TabStop = False
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(210), CByte(227), CByte(188))
        ClientSize = New Size(1348, 721)
        Controls.Add(btnConfirmPayment)
        Controls.Add(btnBackToShoppingCart)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "Form7"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Transaction Page"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RadioButton_Ewallet As RadioButton
    Friend WithEvents btnBackToShoppingCart As Button
    Friend WithEvents RadioButton_OnlineBanking As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnConfirmPayment As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
