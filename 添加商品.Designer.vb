Partial Class 添加商品
    Inherits MaterialSkin.Controls.MaterialForm

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtPrice = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtStock = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtimagePath = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.rtbDescription = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Label1 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label2 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label3 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label4 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label5 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label6 = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Depth = 0
        Me.txtName.Hint = "请输入商品名称"
        Me.txtName.Location = New System.Drawing.Point(100, 100)
        Me.txtName.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = ControlChars.NullChar
        Me.txtName.SelectedText = ""
        Me.txtName.SelectionLength = 0
        Me.txtName.SelectionStart = 0
        Me.txtName.Size = New System.Drawing.Size(200, 23)
        Me.txtName.TabIndex = 0
        Me.txtName.UseSystemPasswordChar = False
        '
        'txtPrice
        '
        Me.txtPrice.Depth = 0
        Me.txtPrice.Hint = "请输入商品价格"
        Me.txtPrice.Location = New System.Drawing.Point(100, 150)
        Me.txtPrice.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = ControlChars.NullChar
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.SelectionLength = 0
        Me.txtPrice.SelectionStart = 0
        Me.txtPrice.Size = New System.Drawing.Size(200, 23)
        Me.txtPrice.TabIndex = 1
        Me.txtPrice.UseSystemPasswordChar = False
        '
        'txtStock
        '
        Me.txtStock.Depth = 0
        Me.txtStock.Hint = "请输入商品库存"
        Me.txtStock.Location = New System.Drawing.Point(100, 200)
        Me.txtStock.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtStock.Name = "txtStock"
        Me.txtStock.PasswordChar = ControlChars.NullChar
        Me.txtStock.SelectedText = ""
        Me.txtStock.SelectionLength = 0
        Me.txtStock.SelectionStart = 0
        Me.txtStock.Size = New System.Drawing.Size(200, 23)
        Me.txtStock.TabIndex = 2
        Me.txtStock.UseSystemPasswordChar = False
        '
        'txtimagePath
        '
        Me.txtimagePath.Depth = 0
        Me.txtimagePath.Hint = "请输入图片路径"
        Me.txtimagePath.Location = New System.Drawing.Point(100, 250)
        Me.txtimagePath.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtimagePath.Name = "txtimagePath"
        Me.txtimagePath.PasswordChar = ControlChars.NullChar
        Me.txtimagePath.SelectedText = ""
        Me.txtimagePath.SelectionLength = 0
        Me.txtimagePath.SelectionStart = 0
        Me.txtimagePath.Size = New System.Drawing.Size(200, 23)
        Me.txtimagePath.TabIndex = 3
        Me.txtimagePath.UseSystemPasswordChar = False
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"电子产品", "服装", "食品", "家居", "其他"})
        Me.cmbCategory.Location = New System.Drawing.Point(100, 300)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(200, 23)
        Me.cmbCategory.TabIndex = 4
        '
        'rtbDescription
        '
        Me.rtbDescription.Location = New System.Drawing.Point(100, 370)
        Me.rtbDescription.Name = "rtbDescription"
        Me.rtbDescription.Size = New System.Drawing.Size(200, 100)
        Me.rtbDescription.TabIndex = 5
        Me.rtbDescription.Multiline = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Depth = 0
        Me.btnSubmit.Location = New System.Drawing.Point(100, 500)
        Me.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Primary = True
        Me.btnSubmit.Size = New System.Drawing.Size(200, 36)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "提交"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Depth = 0
        Me.Label1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(30, 100)
        Me.Label1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "商品名称："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Depth = 0
        Me.Label2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(30, 150)
        Me.Label2.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "商品价格："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Depth = 0
        Me.Label3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(30, 200)
        Me.Label3.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "商品库存："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Depth = 0
        Me.Label4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(30, 250)
        Me.Label4.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "图片路径："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Depth = 0
        Me.Label5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(30, 300)
        Me.Label5.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "商品分类："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Depth = 0
        Me.Label6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(30, 370)
        Me.Label6.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "商品描述："
        '
        '添加商品
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 561)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.rtbDescription)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.txtimagePath)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtName)
        Me.Name = "添加商品"
        Me.Text = "添加商品"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtPrice As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtStock As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtimagePath As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents rtbDescription As TextBox
    Friend WithEvents btnSubmit As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Label1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label6 As MaterialSkin.Controls.MaterialLabel
End Class
