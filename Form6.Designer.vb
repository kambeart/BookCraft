<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Panel2 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel3 = New Panel()
        Panel4 = New Panel()
        btnClearList = New Button()
        Label5 = New Label()
        lblPrice = New Label()
        Button1 = New Button()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Location = New Point(28, 28)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1291, 81)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(28, 128)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1291, 41)
        Panel2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label1.Location = New Point(51, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 35)
        Label1.TabIndex = 1
        Label1.Text = "Books"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label2.Location = New Point(604, 3)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 35)
        Label2.TabIndex = 2
        Label2.Text = "Unit Price"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label3.Location = New Point(819, 3)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 35)
        Label3.TabIndex = 2
        Label3.Text = "Quantity"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label4.Location = New Point(1010, 3)
        Label4.Name = "Label4"
        Label4.Size = New Size(132, 35)
        Label4.TabIndex = 2
        Label4.Text = "Total Price"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Location = New Point(28, 194)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1291, 413)
        Panel3.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(Button1)
        Panel4.Controls.Add(lblPrice)
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(btnClearList)
        Panel4.Location = New Point(28, 637)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1291, 57)
        Panel4.TabIndex = 1
        ' 
        ' btnClearList
        ' 
        btnClearList.BackColor = Color.Transparent
        btnClearList.FlatAppearance.BorderSize = 0
        btnClearList.FlatStyle = FlatStyle.Flat
        btnClearList.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClearList.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        btnClearList.Location = New Point(22, 14)
        btnClearList.Name = "btnClearList"
        btnClearList.Size = New Size(112, 29)
        btnClearList.TabIndex = 0
        btnClearList.Text = "Clear List"
        btnClearList.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label5.Location = New Point(969, 16)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 27)
        Label5.TabIndex = 3
        Label5.Text = "Total :"
        ' 
        ' lblPrice
        ' 
        lblPrice.Anchor = AnchorStyles.None
        lblPrice.AutoSize = True
        lblPrice.BackColor = Color.White
        lblPrice.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPrice.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        lblPrice.Location = New Point(1038, 15)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(63, 27)
        lblPrice.TabIndex = 4
        lblPrice.Text = "(price)"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Sienna
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(1132, 10)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 39)
        Button1.TabIndex = 5
        Button1.Text = "Check Out"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(210), CByte(227), CByte(188))
        ClientSize = New Size(1348, 721)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form6"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form6"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnClearList As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
