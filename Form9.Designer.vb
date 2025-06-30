<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        picCoverPage = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        LinkLabel_UploadCover = New LinkLabel()
        Label2 = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnPublish = New Button()
        txtTitle = New TextBox()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        TextBox2 = New TextBox()
        btnUploadChapter = New Button()
        btnBackToShoppingCart = New Button()
        CType(picCoverPage, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' picCoverPage
        ' 
        picCoverPage.Image = My.Resources.Resources.E_book_Icon
        picCoverPage.Location = New Point(576, 26)
        picCoverPage.Name = "picCoverPage"
        picCoverPage.Size = New Size(189, 208)
        picCoverPage.SizeMode = PictureBoxSizeMode.Zoom
        picCoverPage.TabIndex = 0
        picCoverPage.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' LinkLabel_UploadCover
        ' 
        LinkLabel_UploadCover.AutoSize = True
        LinkLabel_UploadCover.Location = New Point(604, 237)
        LinkLabel_UploadCover.Name = "LinkLabel_UploadCover"
        LinkLabel_UploadCover.Size = New Size(136, 20)
        LinkLabel_UploadCover.TabIndex = 1
        LinkLabel_UploadCover.TabStop = True
        LinkLabel_UploadCover.Text = "Upload Cover Page"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(225, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 35)
        Label2.TabIndex = 4
        Label2.Text = "Title:"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(123, 295)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(296, 254)
        Panel1.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(148, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 35)
        Label1.TabIndex = 5
        Label1.Text = "Description:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(190, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 35)
        Label3.TabIndex = 6
        Label3.Text = "Genres:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(182, 213)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 35)
        Label4.TabIndex = 6
        Label4.Text = "Chapter:"
        ' 
        ' btnPublish
        ' 
        btnPublish.BackColor = Color.DarkGreen
        btnPublish.FlatAppearance.BorderSize = 0
        btnPublish.FlatStyle = FlatStyle.Flat
        btnPublish.Font = New Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPublish.Location = New Point(596, 583)
        btnPublish.Name = "btnPublish"
        btnPublish.Size = New Size(131, 39)
        btnPublish.TabIndex = 6
        btnPublish.Text = "Publish"
        btnPublish.UseVisualStyleBackColor = False
        ' 
        ' txtTitle
        ' 
        txtTitle.Font = New Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTitle.Location = New Point(425, 292)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(639, 42)
        txtTitle.TabIndex = 7
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(425, 342)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(639, 108)
        TextBox1.TabIndex = 8
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(425, 456)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(163, 43)
        ComboBox1.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(422, 505)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(166, 42)
        TextBox2.TabIndex = 10
        ' 
        ' btnUploadChapter
        ' 
        btnUploadChapter.BackColor = Color.Gray
        btnUploadChapter.FlatAppearance.BorderSize = 0
        btnUploadChapter.FlatStyle = FlatStyle.Flat
        btnUploadChapter.Font = New Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUploadChapter.Location = New Point(859, 459)
        btnUploadChapter.Name = "btnUploadChapter"
        btnUploadChapter.Size = New Size(205, 84)
        btnUploadChapter.TabIndex = 11
        btnUploadChapter.Text = "Upload Chapter"
        btnUploadChapter.UseVisualStyleBackColor = False
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
        btnBackToShoppingCart.Location = New Point(123, 26)
        btnBackToShoppingCart.Name = "btnBackToShoppingCart"
        btnBackToShoppingCart.Size = New Size(78, 71)
        btnBackToShoppingCart.TabIndex = 12
        btnBackToShoppingCart.UseVisualStyleBackColor = False
        ' 
        ' Form9
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(210), CByte(227), CByte(188))
        ClientSize = New Size(1348, 721)
        Controls.Add(btnBackToShoppingCart)
        Controls.Add(btnUploadChapter)
        Controls.Add(TextBox2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox1)
        Controls.Add(txtTitle)
        Controls.Add(btnPublish)
        Controls.Add(Panel1)
        Controls.Add(LinkLabel_UploadCover)
        Controls.Add(picCoverPage)
        Name = "Form9"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Upload Ebook"
        CType(picCoverPage, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picCoverPage As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents LinkLabel_UploadCover As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPublish As Button
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnUploadChapter As Button
    Friend WithEvents btnBackToShoppingCart As Button
End Class
