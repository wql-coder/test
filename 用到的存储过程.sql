use brandmanagement
go

-- 用户注册
create proc sp_registeruser
    @username nvarchar(50),
    @password nvarchar(100),
    @role nvarchar(20),
    @phone nvarchar(20)
as
begin
    -- 检查用户名是否已存在
    if exists (select 1 from users where username = @username)
        return -1

    -- 插入新用户
    insert into users (username, password, role, phone)
    values (@username,@password,@role,@phone)

    -- 记录系统日志
    insert into systemlogs (userid,operationtype,operationcontent)
    values (
        scope_identity(), -- 用于获取当前作用域内最后插入的标识值
        'register',
        '新用户注册：' + @username
    )
	return 0
end
go

-- 用户登录
create proc sp_userlogin
    @username nvarchar(50),
    @password nvarchar(100),
	@out_role nvarchar(20) output
as
begin
    declare @userid int
    declare @storedpassword nvarchar(100)
    declare @role nvarchar(20)

    -- 验证用户
    select 
        @userid = userid,
        @storedpassword = password,
        @role = role
    from users 
    where username = @username

    -- 检查用户是否存在
    if @userid is null
        return -1

    -- 验证密码
    if @storedpassword <> @password 
        return -2

    -- 更新最后登录时间
    update users 
    set lastlogin = getdate()
    where userid = @userid;

    -- 记录登录日志
    insert into systemlogs (userid,operationtype,operationcontent)
    values (@userid,'login','用户登录成功')

	set @out_role = @role

	return @userid -- 成功登录后返回用户id
end
go

-- 添加商品
create proc sp_addproduct
    @name nvarchar(100),
    @description nvarchar(500),
    @price decimal(10,2),
    @stock int,
    @category nvarchar(50),
    @imagepath nvarchar(255),
    @createdby int 
as
begin
    -- 插入商品
    insert into products(name,description,price,stock,category,imagepath,createdby)
    values (@name,@description,@price,@stock,@category,@imagepath,@createdby)

    -- 记录系统日志
    insert into systemlogs (
        userid,
        operationtype,
        operationcontent
    )
    values (
        @createdby,
        'addproduct',
        '添加新商品：' + @name
    )
end
go

create proc sp_searchproducts
    @keyword nvarchar(100)
as
begin
    select 
        p.productid as 商品号,
        p.name as 商品名称,
        p.price as 商品价格,
        p.stock as 商品库存,
        p.category as 商品类别,
        p.isactive as 商品是否上架
    from products p
    where p.isactive = 1
    and (
        @keyword is null 
        or p.name like '%' + @keyword + '%'
        or p.description like '%' + @keyword + '%'
    )
    order by p.name
end
go

-- 添加商品到购物车
create procedure sp_addtocart
    @userid int,
    @productid int,
    @quantity int
as
begin
    -- 检查购物车中是否已存在该商品
    if exists (
        select 1 
        from shoppingcart 
        where userid = @userid 
        and productid = @productid
    )
    begin
        -- 更新数量
        update shoppingcart
        set quantity = quantity + @quantity,
            addeddate = getdate()
        where userid = @userid 
        and productid = @productid;
    end
    else
    begin
        -- 添加新商品
        insert into shoppingcart (
            userid,
            productid,
            quantity
        )
        values (
            @userid,
            @productid,
            @quantity
        )
    end
end
go

-- 更新购物车商品数量
create procedure sp_updatecartitemquantity
    @userid int,
    @productid int,
    @newquantity int
as
begin
    -- 更新数量
    update shoppingcart
    set quantity = @newquantity,
        addeddate = getdate()
    where userid = @userid 
    and productid = @productid
end
go