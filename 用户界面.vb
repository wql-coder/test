Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports MaterialSkin
Imports MaterialSkin.Controls

Public Class 用户界面
    Inherits MaterialForm

    Public Sub New()
        InitializeComponent()
        ' 初始化 MaterialSkin 主题
        Dim materialSkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        materialSkinManager.AddFormToManage(Me)
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        materialSkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    ' 查询已上架的商品 
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Using myconn As New SqlConnection("Database = BrandManagement; Data Source = SHQ; Integrated Security = True"),
              mycmd As New SqlCommand("sp_SearchProducts", myconn)
            myconn.Open()
            Dim dt As New DataTable()
            mycmd.CommandType = CommandType.StoredProcedure
            mycmd.Parameters.Clear()
            mycmd.Parameters.Add("@Keyword", SqlDbType.NVarChar, 100).Value = txtSearch.Text.Trim()
            'mycmd.Parameters.AddWithValue("@Category", DBNull.Value)
            'mycmd.Parameters.AddWithValue("@MinPrice", DBNull.Value)
            'mycmd.Parameters.AddWithValue("@MaxPrice", DBNull.Value)
            dt.Load(mycmd.ExecuteReader())
            dgvProductList.DataSource = dt
        End Using
    End Sub

    ' 加入购物车
    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        Using myconn As New SqlConnection("Database = BrandManagement; Data Source = SHQ; Integrated Security = True"),
              mycmd As New SqlCommand("sp_addtocart", myconn)
            myconn.Open()
            If dgvProductList.SelectedRows.Count = 0 Then
                MessageBox.Show("请先选择商品！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            ' 只能选择一行商品
            Dim productID As Integer = CInt(dgvProductList.SelectedRows(0).Cells("商品号").Value)
            mycmd.CommandType = CommandType.StoredProcedure
            mycmd.Parameters.Clear()
            mycmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = CInt(txtQty.Text)
            mycmd.Parameters.Add("@UserID", SqlDbType.Int).Value = CurrentUserID
            mycmd.Parameters.Add("@ProductID", SqlDbType.Int).Value = productID
            mycmd.ExecuteNonQuery()
        End Using
        MessageBox.Show("已加入购物车", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' 查看购物车
    Private Sub btnViewCart_Click(sender As Object, e As EventArgs) Handles btnViewCart.Click
        Using myconn As New SqlConnection("Database = BrandManagement; Data Source = SHQ; Integrated Security = True"),
              mycmd As New SqlCommand("sp_getcartitems", myconn)
            myconn.Open()
            Dim dt As New DataTable()
            mycmd.CommandType = CommandType.StoredProcedure
            mycmd.Parameters.Clear()
            mycmd.Parameters.Add("@UserID", SqlDbType.Int).Value = CurrentUserID
            dt.Load(mycmd.ExecuteReader())
            dgvCart.DataSource = dt
        End Using
    End Sub

    ' 修改购物车数量
    Private Sub btnUpdateCart_Click(sender As Object, e As EventArgs) Handles btnUpdateCart.Click
        Using myconn As New SqlConnection("Database = BrandManagement; Data Source = SHQ; Integrated Security = True"),
              mycmd As New SqlCommand("sp_updatecartitemquantity", myconn)
            myconn.Open()
            If dgvCart.SelectedRows.Count = 0 Then
                MessageBox.Show("请先选择商品！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Dim productID As Integer = CInt(dgvCart.SelectedRows(0).Cells("商品号").Value)
            mycmd.CommandType = CommandType.StoredProcedure
            mycmd.Parameters.Clear()
            mycmd.Parameters.Add("@UserID", SqlDbType.Int).Value = CurrentUserID
            mycmd.Parameters.Add("@ProductID", SqlDbType.Int).Value = productID
            mycmd.Parameters.Add("@NewQuantity", SqlDbType.Int).Value = CInt(txtUpdateQty.Text)
            mycmd.ExecuteNonQuery()
        End Using
        MessageBox.Show("数量已修改", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class