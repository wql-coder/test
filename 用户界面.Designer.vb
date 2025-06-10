<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 用户界面
    Inherits MaterialSkin.Controls.MaterialForm

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabBrowse = New System.Windows.Forms.TabPage()
        Me.btnAddToCart = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtQty = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label2 = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvProductList = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtSearch = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label1 = New MaterialSkin.Controls.MaterialLabel()
        Me.tabCart = New System.Windows.Forms.TabPage()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClearCart = New System.Windows.Forms.Button()
        Me.btnUpdateCart = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtUpdateQty = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label3 = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvCart = New System.Windows.Forms.DataGridView()
        Me.btnViewCart = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.tabOrder = New System.Windows.Forms.TabPage()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.dgvOrders = New System.Windows.Forms.DataGridView()
        Me.btnQueryOrders = New System.Windows.Forms.Button()
        Me.tabReview = New System.Windows.Forms.TabPage()
        Me.btnReview = New System.Windows.Forms.Button()
        Me.txtReviewComment = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtReviewScore = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtReviewProductID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtReviewOrderID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnRemoveCartItem = New System.Windows.Forms.Button()
        Me.tabMain.SuspendLayout()
        Me.tabBrowse.SuspendLayout()
        CType(Me.dgvProductList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCart.SuspendLayout()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOrder.SuspendLayout()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabReview.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabBrowse)
        Me.tabMain.Controls.Add(Me.tabCart)
        Me.tabMain.Controls.Add(Me.tabOrder)
        Me.tabMain.Controls.Add(Me.tabReview)
        Me.tabMain.Location = New System.Drawing.Point(27, 28)
        Me.tabMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(1062, 704)
        Me.tabMain.TabIndex = 1
        '
        'tabBrowse
        '
        Me.tabBrowse.Controls.Add(Me.btnAddToCart)
        Me.tabBrowse.Controls.Add(Me.txtQty)
        Me.tabBrowse.Controls.Add(Me.Label2)
        Me.tabBrowse.Controls.Add(Me.dgvProductList)
        Me.tabBrowse.Controls.Add(Me.btnSearch)
        Me.tabBrowse.Controls.Add(Me.txtSearch)
        Me.tabBrowse.Controls.Add(Me.Label1)
        Me.tabBrowse.Location = New System.Drawing.Point(8, 39)
        Me.tabBrowse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabBrowse.Name = "tabBrowse"
        Me.tabBrowse.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabBrowse.Size = New System.Drawing.Size(1046, 657)
        Me.tabBrowse.TabIndex = 0
        Me.tabBrowse.Text = "商品浏览"
        Me.tabBrowse.UseVisualStyleBackColor = True
        '
        'btnAddToCart
        '
        Me.btnAddToCart.Location = New System.Drawing.Point(359, 88)
        Me.btnAddToCart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Primary = True
        Me.btnAddToCart.Size = New System.Drawing.Size(155, 42)
        Me.btnAddToCart.TabIndex = 6
        Me.btnAddToCart.Text = "加入购物车"
        Me.btnAddToCart.UseVisualStyleBackColor = True
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(183, 88)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.SelectedText = ""
        Me.txtQty.SelectionLength = 0
        Me.txtQty.SelectionStart = 0
        Me.txtQty.Size = New System.Drawing.Size(148, 23)
        Me.txtQty.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(93, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "数量："
        '
        'dgvProductList
        '
        Me.dgvProductList.AllowUserToAddRows = False
        Me.dgvProductList.AllowUserToDeleteRows = False
        Me.dgvProductList.AllowUserToResizeRows = False
        Me.dgvProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvProductList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProductList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvProductList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductList.Location = New System.Drawing.Point(-2, 152)
        Me.dgvProductList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvProductList.Name = "dgvProductList"
        Me.dgvProductList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvProductList.RowHeadersVisible = False
        Me.dgvProductList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProductList.RowTemplate.Height = 24
        Me.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductList.Size = New System.Drawing.Size(1038, 501)
        Me.dgvProductList.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(688, 24)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Primary = True
        Me.btnSearch.Size = New System.Drawing.Size(107, 47)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "搜索"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(186, 24)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.Size = New System.Drawing.Size(484, 23)
        Me.txtSearch.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(24, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "搜索关键词："
        '
        'tabCart
        '
        Me.tabCart.Controls.Add(Me.btnRemoveCartItem)
        Me.tabCart.Controls.Add(Me.btnCheckout)
        Me.tabCart.Controls.Add(Me.txtPhone)
        Me.tabCart.Controls.Add(Me.Label5)
        Me.tabCart.Controls.Add(Me.txtAddress)
        Me.tabCart.Controls.Add(Me.Label4)
        Me.tabCart.Controls.Add(Me.btnClearCart)
        Me.tabCart.Controls.Add(Me.btnUpdateCart)
        Me.tabCart.Controls.Add(Me.txtUpdateQty)
        Me.tabCart.Controls.Add(Me.Label3)
        Me.tabCart.Controls.Add(Me.dgvCart)
        Me.tabCart.Controls.Add(Me.btnViewCart)
        Me.tabCart.Location = New System.Drawing.Point(8, 39)
        Me.tabCart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabCart.Name = "tabCart"
        Me.tabCart.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabCart.Size = New System.Drawing.Size(1046, 657)
        Me.tabCart.TabIndex = 1
        Me.tabCart.Text = "购物车"
        Me.tabCart.UseVisualStyleBackColor = True
        '
        'btnCheckout
        '
        Me.btnCheckout.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnCheckout.Location = New System.Drawing.Point(850, 550)
        Me.btnCheckout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(160, 60)
        Me.btnCheckout.TabIndex = 12
        Me.btnCheckout.Text = "结算/下单"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(193, 604)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(213, 35)
        Me.txtPhone.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 615)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "联系电话："
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(193, 550)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(575, 35)
        Me.txtAddress.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 561)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "收货地址："
        '
        'btnClearCart
        '
        Me.btnClearCart.Location = New System.Drawing.Point(203, 17)
        Me.btnClearCart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClearCart.Name = "btnClearCart"
        Me.btnClearCart.Size = New System.Drawing.Size(162, 53)
        Me.btnClearCart.TabIndex = 7
        Me.btnClearCart.Text = "清空购物车"
        Me.btnClearCart.UseVisualStyleBackColor = True
        '
        'btnUpdateCart
        '
        Me.btnUpdateCart.Location = New System.Drawing.Point(708, 21)
        Me.btnUpdateCart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdateCart.Name = "btnUpdateCart"
        Me.btnUpdateCart.Primary = True
        Me.btnUpdateCart.Size = New System.Drawing.Size(147, 48)
        Me.btnUpdateCart.TabIndex = 5
        Me.btnUpdateCart.Text = "修改数量"
        Me.btnUpdateCart.UseVisualStyleBackColor = True
        '
        'txtUpdateQty
        '
        Me.txtUpdateQty.Location = New System.Drawing.Point(533, 28)
        Me.txtUpdateQty.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUpdateQty.Name = "txtUpdateQty"
        Me.txtUpdateQty.SelectedText = ""
        Me.txtUpdateQty.SelectionLength = 0
        Me.txtUpdateQty.SelectionStart = 0
        Me.txtUpdateQty.Size = New System.Drawing.Size(148, 23)
        Me.txtUpdateQty.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(395, 31)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "修改数量："
        '
        'dgvCart
        '
        Me.dgvCart.AllowUserToAddRows = False
        Me.dgvCart.AllowUserToDeleteRows = False
        Me.dgvCart.AllowUserToResizeRows = False
        Me.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCart.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCart.Location = New System.Drawing.Point(2, 103)
        Me.dgvCart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvCart.Name = "dgvCart"
        Me.dgvCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCart.RowHeadersVisible = False
        Me.dgvCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCart.RowTemplate.Height = 24
        Me.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCart.Size = New System.Drawing.Size(1040, 420)
        Me.dgvCart.TabIndex = 1
        '
        'btnViewCart
        '
        Me.btnViewCart.Location = New System.Drawing.Point(34, 17)
        Me.btnViewCart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnViewCart.Name = "btnViewCart"
        Me.btnViewCart.Primary = True
        Me.btnViewCart.Size = New System.Drawing.Size(152, 53)
        Me.btnViewCart.TabIndex = 0
        Me.btnViewCart.Text = "刷新购物车"
        Me.btnViewCart.UseVisualStyleBackColor = True
        '
        'tabOrder
        '
        Me.tabOrder.Controls.Add(Me.btnCancelOrder)
        Me.tabOrder.Controls.Add(Me.dgvOrders)
        Me.tabOrder.Controls.Add(Me.btnQueryOrders)
        Me.tabOrder.Location = New System.Drawing.Point(8, 39)
        Me.tabOrder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabOrder.Name = "tabOrder"
        Me.tabOrder.Size = New System.Drawing.Size(1046, 657)
        Me.tabOrder.TabIndex = 2
        Me.tabOrder.Text = "订单管理"
        Me.tabOrder.UseVisualStyleBackColor = True
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.Location = New System.Drawing.Point(179, 21)
        Me.btnCancelOrder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(148, 37)
        Me.btnCancelOrder.TabIndex = 2
        Me.btnCancelOrder.Text = "取消订单"
        Me.btnCancelOrder.UseVisualStyleBackColor = True
        '
        'dgvOrders
        '
        Me.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrders.Location = New System.Drawing.Point(6, 69)
        Me.dgvOrders.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvOrders.Name = "dgvOrders"
        Me.dgvOrders.RowHeadersWidth = 51
        Me.dgvOrders.RowTemplate.Height = 27
        Me.dgvOrders.Size = New System.Drawing.Size(1158, 584)
        Me.dgvOrders.TabIndex = 1
        '
        'btnQueryOrders
        '
        Me.btnQueryOrders.BackColor = System.Drawing.Color.Transparent
        Me.btnQueryOrders.Location = New System.Drawing.Point(6, 21)
        Me.btnQueryOrders.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnQueryOrders.Name = "btnQueryOrders"
        Me.btnQueryOrders.Size = New System.Drawing.Size(132, 37)
        Me.btnQueryOrders.TabIndex = 0
        Me.btnQueryOrders.Text = "刷新订单"
        Me.btnQueryOrders.UseVisualStyleBackColor = False
        '
        'tabReview
        '
        Me.tabReview.Controls.Add(Me.btnReview)
        Me.tabReview.Controls.Add(Me.txtReviewComment)
        Me.tabReview.Controls.Add(Me.Label9)
        Me.tabReview.Controls.Add(Me.txtReviewScore)
        Me.tabReview.Controls.Add(Me.Label8)
        Me.tabReview.Controls.Add(Me.txtReviewProductID)
        Me.tabReview.Controls.Add(Me.Label7)
        Me.tabReview.Controls.Add(Me.txtReviewOrderID)
        Me.tabReview.Controls.Add(Me.Label6)
        Me.tabReview.Location = New System.Drawing.Point(8, 39)
        Me.tabReview.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabReview.Name = "tabReview"
        Me.tabReview.Size = New System.Drawing.Size(1046, 657)
        Me.tabReview.TabIndex = 3
        Me.tabReview.Text = "商品评价"
        Me.tabReview.UseVisualStyleBackColor = True
        '
        'btnReview
        '
        Me.btnReview.Location = New System.Drawing.Point(36, 322)
        Me.btnReview.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReview.Name = "btnReview"
        Me.btnReview.Size = New System.Drawing.Size(112, 37)
        Me.btnReview.TabIndex = 8
        Me.btnReview.Text = "提交评价"
        Me.btnReview.UseVisualStyleBackColor = True
        '
        'txtReviewComment
        '
        Me.txtReviewComment.Location = New System.Drawing.Point(201, 235)
        Me.txtReviewComment.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtReviewComment.Multiline = True
        Me.txtReviewComment.Name = "txtReviewComment"
        Me.txtReviewComment.Size = New System.Drawing.Size(148, 38)
        Me.txtReviewComment.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 235)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 24)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "评价内容："
        '
        'txtReviewScore
        '
        Me.txtReviewScore.FormattingEnabled = True
        Me.txtReviewScore.Location = New System.Drawing.Point(201, 155)
        Me.txtReviewScore.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtReviewScore.Name = "txtReviewScore"
        Me.txtReviewScore.Size = New System.Drawing.Size(180, 32)
        Me.txtReviewScore.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 155)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 24)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "评分 (1–5)："
        '
        'txtReviewProductID
        '
        Me.txtReviewProductID.Location = New System.Drawing.Point(201, 75)
        Me.txtReviewProductID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtReviewProductID.Name = "txtReviewProductID"
        Me.txtReviewProductID.Size = New System.Drawing.Size(148, 35)
        Me.txtReviewProductID.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 80)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 24)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "商品ID："
        '
        'txtReviewOrderID
        '
        Me.txtReviewOrderID.Location = New System.Drawing.Point(201, 26)
        Me.txtReviewOrderID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtReviewOrderID.Name = "txtReviewOrderID"
        Me.txtReviewOrderID.Size = New System.Drawing.Size(148, 35)
        Me.txtReviewOrderID.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 21)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "订单号："
        '
        'btnRemoveCartItem
        '
        Me.btnRemoveCartItem.Location = New System.Drawing.Point(863, 23)
        Me.btnRemoveCartItem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRemoveCartItem.Name = "btnRemoveCartItem"
        Me.btnRemoveCartItem.Size = New System.Drawing.Size(157, 44)
        Me.btnRemoveCartItem.TabIndex = 6
        Me.btnRemoveCartItem.Text = "删除商品"
        Me.btnRemoveCartItem.UseVisualStyleBackColor = True
        '
        '用户界面
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 760)
        Me.Controls.Add(Me.tabMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "用户界面"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "用户界面"
        Me.tabMain.ResumeLayout(False)
        Me.tabBrowse.ResumeLayout(False)
        Me.tabBrowse.PerformLayout()
        CType(Me.dgvProductList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCart.ResumeLayout(False)
        Me.tabCart.PerformLayout()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOrder.ResumeLayout(False)
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabReview.ResumeLayout(False)
        Me.tabReview.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabMain As TabControl
    Friend WithEvents tabBrowse As TabPage
    Friend WithEvents btnAddToCart As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtQty As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvProductList As DataGridView
    Friend WithEvents btnSearch As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtSearch As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tabCart As TabPage
    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents btnViewCart As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents tabOrder As TabPage
    Friend WithEvents btnCancelOrder As Button
    Friend WithEvents dgvOrders As DataGridView
    Friend WithEvents btnQueryOrders As Button
    Friend WithEvents tabReview As TabPage
    Friend WithEvents btnReview As Button
    Friend WithEvents txtReviewComment As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtReviewScore As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtReviewProductID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtReviewOrderID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnClearCart As Button
    Friend WithEvents btnUpdateCart As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtUpdateQty As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnRemoveCartItem As Button
End Class
