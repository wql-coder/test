Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MaterialSkin
Imports MaterialSkin.Controls

Public Class 添加商品
    Inherits MaterialForm

    Public Sub New()
        InitializeComponent()
        ' 初始化 MaterialSkin 主题
        Dim materialSkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        materialSkinManager.AddFormToManage(Me)
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        materialSkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' 检查商品名称是否为空
        If String.IsNullOrEmpty(txtName.Text) Then
            MessageBox.Show("商品名称不能为空！")
            txtName.Focus()
            Return
        End If

        ' 检查价格是否为空
        If String.IsNullOrEmpty(txtPrice.Text) Then
            MessageBox.Show("商品价格不能为空！")
            txtPrice.Focus()
            Return
        End If

        ' 检查库存是否为空
        If String.IsNullOrEmpty(txtStock.Text) Then
            MessageBox.Show("商品库存不能为空！")
            txtStock.Focus()
            Return
        End If

        ' 检查是否选择了分类
        If cmbCategory.SelectedItem Is Nothing Then
            MessageBox.Show("请选择商品分类！")
            cmbCategory.Focus()
            Return
        End If

        ' 检查图片路径是否为空
        If String.IsNullOrEmpty(txtimagePath.Text) Then
            MessageBox.Show("图片路径不能为空！")
            txtimagePath.Focus()
            Return
        End If

        Using myconn As New SqlConnection("Database = BrandManagement; Data Source = SHQ; Integrated Security = True"),
              mycmd As New SqlCommand("sp_addproduct", myconn)
            myconn.Open()
            mycmd.CommandType = CommandType.StoredProcedure
            mycmd.Parameters.Clear()
            mycmd.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value = txtName.Text
            mycmd.Parameters.Add("@Description", SqlDbType.NVarChar, 500).Value = rtbDescription.Text
            mycmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = CDec(txtPrice.Text)
            mycmd.Parameters.Add("@Stock", SqlDbType.Int).Value = CInt(txtStock.Text)
            mycmd.Parameters.Add("@Category", SqlDbType.NVarChar, 50).Value = cmbCategory.SelectedItem
            mycmd.Parameters.Add("@ImagePath", SqlDbType.NVarChar, 255).Value = txtimagePath.Text
            mycmd.Parameters.Add("@CreatedBy", SqlDbType.Int).Value = CurrentUserID
            mycmd.ExecuteNonQuery()
        End Using
        MessageBox.Show("商品添加成功！")
        Me.Close()
    End Sub
End Class
