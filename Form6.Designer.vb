﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Label6 = New Label()
        btnBackToMainMenu = New Button()
        Panel2 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel3 = New Panel()
        Panel4 = New Panel()
        btnCheckOut = New Button()
        lblPrice = New Label()
        Label5 = New Label()
        btnClearList = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(btnBackToMainMenu)
        Panel1.Location = New Point(28, 28)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1291, 81)
        Panel1.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label6.Location = New Point(135, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(228, 46)
        Label6.TabIndex = 7
        Label6.Text = "Shopping Cart"
        ' 
        ' btnBackToMainMenu
        ' 
        btnBackToMainMenu.BackColor = Color.White
        btnBackToMainMenu.BackgroundImageLayout = ImageLayout.Zoom
        btnBackToMainMenu.FlatAppearance.BorderSize = 0
        btnBackToMainMenu.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(210), CByte(227), CByte(188))
        btnBackToMainMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(210), CByte(227), CByte(188))
        btnBackToMainMenu.FlatStyle = FlatStyle.Flat
        btnBackToMainMenu.Image = My.Resources.Resources.Adobe_Express___file
        btnBackToMainMenu.Location = New Point(3, 3)
        btnBackToMainMenu.Name = "btnBackToMainMenu"
        btnBackToMainMenu.Size = New Size(78, 71)
        btnBackToMainMenu.TabIndex = 6
        btnBackToMainMenu.UseVisualStyleBackColor = False
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
        Panel4.Controls.Add(btnCheckOut)
        Panel4.Controls.Add(lblPrice)
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(btnClearList)
        Panel4.Location = New Point(28, 637)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1291, 57)
        Panel4.TabIndex = 1
        ' 
        ' btnCheckOut
        ' 
        btnCheckOut.BackColor = Color.Sienna
        btnCheckOut.FlatAppearance.BorderSize = 0
        btnCheckOut.FlatStyle = FlatStyle.Flat
        btnCheckOut.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCheckOut.ForeColor = Color.White
        btnCheckOut.Location = New Point(1132, 10)
        btnCheckOut.Name = "btnCheckOut"
        btnCheckOut.Size = New Size(112, 39)
        btnCheckOut.TabIndex = 5
        btnCheckOut.Text = "Check Out"
        btnCheckOut.UseVisualStyleBackColor = False
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
        Text = "Shopping Cart"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents btnBackToMainMenu As Button
    Friend WithEvents Label6 As Label
End Class
