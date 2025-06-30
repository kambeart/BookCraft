<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Label2 = New Label()
        Panel_ebook = New Panel()
        btnBackToShoppingCart = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(538, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(249, 69)
        Label1.TabIndex = 0
        Label1.Text = "Title Book"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(596, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 35)
        Label2.TabIndex = 1
        Label2.Text = "By: Author"
        ' 
        ' Panel_ebook
        ' 
        Panel_ebook.Location = New Point(305, 225)
        Panel_ebook.Name = "Panel_ebook"
        Panel_ebook.Size = New Size(711, 484)
        Panel_ebook.TabIndex = 2
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
        btnBackToShoppingCart.Location = New Point(48, 50)
        btnBackToShoppingCart.Name = "btnBackToShoppingCart"
        btnBackToShoppingCart.Size = New Size(78, 71)
        btnBackToShoppingCart.TabIndex = 13
        btnBackToShoppingCart.UseVisualStyleBackColor = False
        ' 
        ' Form10
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(210), CByte(227), CByte(188))
        ClientSize = New Size(1348, 721)
        Controls.Add(btnBackToShoppingCart)
        Controls.Add(Panel_ebook)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form10"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Read Ebook"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel_ebook As Panel
    Friend WithEvents btnBackToShoppingCart As Button
End Class
