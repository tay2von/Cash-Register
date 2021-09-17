<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtInvNumber = New System.Windows.Forms.TextBox()
        Me.lblInvNumber = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblOnHand = New System.Windows.Forms.Label()
        Me.lblRetail = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtOnHand = New System.Windows.Forms.TextBox()
        Me.txtRetailPrice = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbAllItems = New System.Windows.Forms.ListBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.GBItems = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GBItems.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInvNumber
        '
        Me.txtInvNumber.Location = New System.Drawing.Point(812, 72)
        Me.txtInvNumber.Name = "txtInvNumber"
        Me.txtInvNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtInvNumber.TabIndex = 1
        '
        'lblInvNumber
        '
        Me.lblInvNumber.AutoSize = True
        Me.lblInvNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvNumber.Location = New System.Drawing.Point(658, 76)
        Me.lblInvNumber.Name = "lblInvNumber"
        Me.lblInvNumber.Size = New System.Drawing.Size(116, 16)
        Me.lblInvNumber.TabIndex = 1
        Me.lblInvNumber.Text = "Inventory Number:"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(812, 126)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtDescription.TabIndex = 2
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(661, 126)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(107, 16)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "Item Description:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(702, 179)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(66, 16)
        Me.lblCost.TabIndex = 4
        Me.lblCost.Text = "Item Cost:"
        '
        'lblOnHand
        '
        Me.lblOnHand.AutoSize = True
        Me.lblOnHand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnHand.Location = New System.Drawing.Point(680, 227)
        Me.lblOnHand.Name = "lblOnHand"
        Me.lblOnHand.Size = New System.Drawing.Size(94, 16)
        Me.lblOnHand.TabIndex = 5
        Me.lblOnHand.Text = "Items on hand:"
        '
        'lblRetail
        '
        Me.lblRetail.AutoSize = True
        Me.lblRetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetail.Location = New System.Drawing.Point(688, 286)
        Me.lblRetail.Name = "lblRetail"
        Me.lblRetail.Size = New System.Drawing.Size(80, 16)
        Me.lblRetail.TabIndex = 6
        Me.lblRetail.Text = "Retail Price:"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(812, 179)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(100, 20)
        Me.txtCost.TabIndex = 3
        '
        'txtOnHand
        '
        Me.txtOnHand.Location = New System.Drawing.Point(812, 227)
        Me.txtOnHand.Name = "txtOnHand"
        Me.txtOnHand.Size = New System.Drawing.Size(100, 20)
        Me.txtOnHand.TabIndex = 4
        '
        'txtRetailPrice
        '
        Me.txtRetailPrice.Location = New System.Drawing.Point(812, 281)
        Me.txtRetailPrice.Name = "txtRetailPrice"
        Me.txtRetailPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtRetailPrice.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(274, 416)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(84, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(429, 416)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 8
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(585, 413)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 26)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(751, 413)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 26)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'lbAllItems
        '
        Me.lbAllItems.FormattingEnabled = True
        Me.lbAllItems.Location = New System.Drawing.Point(21, 26)
        Me.lbAllItems.Name = "lbAllItems"
        Me.lbAllItems.Size = New System.Drawing.Size(367, 238)
        Me.lbAllItems.TabIndex = 16
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(136, 415)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'GBItems
        '
        Me.GBItems.Controls.Add(Me.lbAllItems)
        Me.GBItems.Location = New System.Drawing.Point(30, 50)
        Me.GBItems.Name = "GBItems"
        Me.GBItems.Size = New System.Drawing.Size(485, 289)
        Me.GBItems.TabIndex = 18
        Me.GBItems.TabStop = False
        Me.GBItems.Text = "All Items"
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(984, 548)
        Me.Controls.Add(Me.GBItems)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtRetailPrice)
        Me.Controls.Add(Me.txtOnHand)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.lblRetail)
        Me.Controls.Add(Me.lblOnHand)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblInvNumber)
        Me.Controls.Add(Me.txtInvNumber)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmInventory"
        Me.Text = "Cash Register by Tayvon Lewis"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GBItems.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInvNumber As TextBox
    Friend WithEvents lblInvNumber As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblOnHand As Label
    Friend WithEvents lblRetail As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtOnHand As TextBox
    Friend WithEvents txtRetailPrice As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbAllItems As ListBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents GBItems As GroupBox
End Class
