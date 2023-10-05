<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpFlavour = New System.Windows.Forms.GroupBox()
        Me.cmbFlavourList = New System.Windows.Forms.ComboBox()
        Me.Size = New System.Windows.Forms.GroupBox()
        Me.radDoubleButton = New System.Windows.Forms.RadioButton()
        Me.radSingleButton = New System.Windows.Forms.RadioButton()
        Me.radKidButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.QuantScroll = New System.Windows.Forms.VScrollBar()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkSauceBox = New System.Windows.Forms.CheckBox()
        Me.chkFruitBox = New System.Windows.Forms.CheckBox()
        Me.chkNutBox = New System.Windows.Forms.CheckBox()
        Me.chkCreamBox = New System.Windows.Forms.CheckBox()
        Me.chkSmartBox = New System.Windows.Forms.CheckBox()
        Me.chkHTBox = New System.Windows.Forms.CheckBox()
        Me.chkChocBox = New System.Windows.Forms.CheckBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.grpFlavour.SuspendLayout()
        Me.Size.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(43, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(630, 75)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = """Sweet Treats"" Ice Creams"
        '
        'grpFlavour
        '
        Me.grpFlavour.Controls.Add(Me.cmbFlavourList)
        Me.grpFlavour.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpFlavour.Location = New System.Drawing.Point(12, 76)
        Me.grpFlavour.Name = "grpFlavour"
        Me.grpFlavour.Size = New System.Drawing.Size(244, 117)
        Me.grpFlavour.TabIndex = 1
        Me.grpFlavour.TabStop = False
        Me.grpFlavour.Text = "Flavour"
        '
        'cmbFlavourList
        '
        Me.cmbFlavourList.FormattingEnabled = True
        Me.cmbFlavourList.Location = New System.Drawing.Point(6, 41)
        Me.cmbFlavourList.Name = "cmbFlavourList"
        Me.cmbFlavourList.Size = New System.Drawing.Size(182, 46)
        Me.cmbFlavourList.TabIndex = 0
        '
        'Size
        '
        Me.Size.Controls.Add(Me.radDoubleButton)
        Me.Size.Controls.Add(Me.radSingleButton)
        Me.Size.Controls.Add(Me.radKidButton)
        Me.Size.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Size.Location = New System.Drawing.Point(12, 199)
        Me.Size.Name = "Size"
        Me.Size.Size = New System.Drawing.Size(244, 159)
        Me.Size.TabIndex = 2
        Me.Size.TabStop = False
        Me.Size.Text = "Size"
        '
        'radDoubleButton
        '
        Me.radDoubleButton.AutoSize = True
        Me.radDoubleButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radDoubleButton.Location = New System.Drawing.Point(16, 115)
        Me.radDoubleButton.Name = "radDoubleButton"
        Me.radDoubleButton.Size = New System.Drawing.Size(105, 32)
        Me.radDoubleButton.TabIndex = 2
        Me.radDoubleButton.TabStop = True
        Me.radDoubleButton.Text = "Double"
        Me.radDoubleButton.UseVisualStyleBackColor = True
        '
        'radSingleButton
        '
        Me.radSingleButton.AutoSize = True
        Me.radSingleButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radSingleButton.Location = New System.Drawing.Point(16, 77)
        Me.radSingleButton.Name = "radSingleButton"
        Me.radSingleButton.Size = New System.Drawing.Size(95, 32)
        Me.radSingleButton.TabIndex = 1
        Me.radSingleButton.TabStop = True
        Me.radSingleButton.Text = "Single"
        Me.radSingleButton.UseVisualStyleBackColor = True
        '
        'radKidButton
        '
        Me.radKidButton.AutoSize = True
        Me.radKidButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radKidButton.Location = New System.Drawing.Point(16, 39)
        Me.radKidButton.Name = "radKidButton"
        Me.radKidButton.Size = New System.Drawing.Size(97, 32)
        Me.radKidButton.TabIndex = 0
        Me.radKidButton.TabStop = True
        Me.radKidButton.Text = "Kiddie"
        Me.radKidButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtQuantity)
        Me.GroupBox2.Controls.Add(Me.QuantScroll)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 364)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 240)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(42, 104)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(150, 45)
        Me.txtQuantity.TabIndex = 1
        '
        'QuantScroll
        '
        Me.QuantScroll.LargeChange = 1
        Me.QuantScroll.Location = New System.Drawing.Point(6, 41)
        Me.QuantScroll.Maximum = 10
        Me.QuantScroll.Minimum = 1
        Me.QuantScroll.Name = "QuantScroll"
        Me.QuantScroll.Size = New System.Drawing.Size(33, 187)
        Me.QuantScroll.TabIndex = 0
        Me.QuantScroll.Value = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkSauceBox)
        Me.GroupBox3.Controls.Add(Me.chkFruitBox)
        Me.GroupBox3.Controls.Add(Me.chkNutBox)
        Me.GroupBox3.Controls.Add(Me.chkCreamBox)
        Me.GroupBox3.Controls.Add(Me.chkSmartBox)
        Me.GroupBox3.Controls.Add(Me.chkHTBox)
        Me.GroupBox3.Controls.Add(Me.chkChocBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.Location = New System.Drawing.Point(332, 87)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(350, 373)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Extras"
        '
        'chkSauceBox
        '
        Me.chkSauceBox.AutoSize = True
        Me.chkSauceBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkSauceBox.Location = New System.Drawing.Point(14, 309)
        Me.chkSauceBox.Name = "chkSauceBox"
        Me.chkSauceBox.Size = New System.Drawing.Size(226, 36)
        Me.chkSauceBox.TabIndex = 6
        Me.chkSauceBox.Text = "Chocolate Sauce"
        Me.chkSauceBox.UseVisualStyleBackColor = True
        '
        'chkFruitBox
        '
        Me.chkFruitBox.AutoSize = True
        Me.chkFruitBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkFruitBox.Location = New System.Drawing.Point(14, 267)
        Me.chkFruitBox.Name = "chkFruitBox"
        Me.chkFruitBox.Size = New System.Drawing.Size(104, 36)
        Me.chkFruitBox.TabIndex = 5
        Me.chkFruitBox.Text = "Fruits"
        Me.chkFruitBox.UseVisualStyleBackColor = True
        '
        'chkNutBox
        '
        Me.chkNutBox.AutoSize = True
        Me.chkNutBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkNutBox.Location = New System.Drawing.Point(14, 225)
        Me.chkNutBox.Name = "chkNutBox"
        Me.chkNutBox.Size = New System.Drawing.Size(203, 36)
        Me.chkNutBox.TabIndex = 4
        Me.chkNutBox.Text = "Chopped Nuts"
        Me.chkNutBox.UseVisualStyleBackColor = True
        '
        'chkCreamBox
        '
        Me.chkCreamBox.AutoSize = True
        Me.chkCreamBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkCreamBox.Location = New System.Drawing.Point(14, 185)
        Me.chkCreamBox.Name = "chkCreamBox"
        Me.chkCreamBox.Size = New System.Drawing.Size(223, 36)
        Me.chkCreamBox.TabIndex = 3
        Me.chkCreamBox.Text = "Whipped Cream"
        Me.chkCreamBox.UseVisualStyleBackColor = True
        '
        'chkSmartBox
        '
        Me.chkSmartBox.AutoSize = True
        Me.chkSmartBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkSmartBox.Location = New System.Drawing.Point(14, 143)
        Me.chkSmartBox.Name = "chkSmartBox"
        Me.chkSmartBox.Size = New System.Drawing.Size(139, 36)
        Me.chkSmartBox.TabIndex = 2
        Me.chkSmartBox.Text = "Smarties"
        Me.chkSmartBox.UseVisualStyleBackColor = True
        '
        'chkHTBox
        '
        Me.chkHTBox.AutoSize = True
        Me.chkHTBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkHTBox.Location = New System.Drawing.Point(14, 101)
        Me.chkHTBox.Name = "chkHTBox"
        Me.chkHTBox.Size = New System.Drawing.Size(332, 36)
        Me.chkHTBox.TabIndex = 1
        Me.chkHTBox.Text = "Hundreds and Thousands"
        Me.chkHTBox.UseVisualStyleBackColor = True
        '
        'chkChocBox
        '
        Me.chkChocBox.AutoSize = True
        Me.chkChocBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkChocBox.Location = New System.Drawing.Point(14, 59)
        Me.chkChocBox.Name = "chkChocBox"
        Me.chkChocBox.Size = New System.Drawing.Size(254, 36)
        Me.chkChocBox.TabIndex = 0
        Me.chkChocBox.Text = "Chocolate Spinkles"
        Me.chkChocBox.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnReset.Location = New System.Drawing.Point(394, 549)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(138, 45)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnQuit.Location = New System.Drawing.Point(538, 549)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(135, 43)
        Me.btnQuit.TabIndex = 5
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(351, 479)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 45)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cost:"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(442, 479)
        Me.txtCost.Multiline = True
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(150, 46)
        Me.txtCost.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(711, 604)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Size)
        Me.Controls.Add(Me.grpFlavour)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpFlavour.ResumeLayout(False)
        Me.Size.ResumeLayout(False)
        Me.Size.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grpFlavour As GroupBox
    Friend WithEvents cmbFlavourList As ComboBox
    Friend WithEvents Size As GroupBox
    Friend WithEvents radDoubleButton As RadioButton
    Friend WithEvents radSingleButton As RadioButton
    Friend WithEvents radKidButton As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents QuantScroll As VScrollBar
    Friend WithEvents chkSauceBox As CheckBox
    Friend WithEvents chkFruitBox As CheckBox
    Friend WithEvents chkNutBox As CheckBox
    Friend WithEvents chkCreamBox As CheckBox
    Friend WithEvents chkSmartBox As CheckBox
    Friend WithEvents chkHTBox As CheckBox
    Friend WithEvents chkChocBox As CheckBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtQuantity As TextBox
End Class
