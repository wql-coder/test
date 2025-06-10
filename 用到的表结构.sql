use brandmanagement
go

-- �����û���
create table users (
    userid int primary key identity(1,1),
    username nvarchar(50) not null unique,
    password nvarchar(100) not null,  
    role nvarchar(20) not null check (role in ('customer', 'merchant', 'admin')),
    phone nvarchar(20) not null,
    registerdate datetime default getdate(),
    lastlogin datetime
)

-- ������Ʒ��
create table products (
    productid int primary key identity(1,1),
    name nvarchar(100) not null,
    description nvarchar(500),
    price decimal(10, 2) not null,
    stock int not null default 0,
    category nvarchar(50),           -- ��װ������
    imagepath nvarchar(255),         -- ��ƷͼƬ����·��
    isactive bit default 1,          -- 1=�ϼ�, 0=�¼�
    createdby int foreign key references users(userid),
    createddate datetime default getdate(),
    modifieddate datetime
)

-- �������ﳵ��
create table shoppingcart (
    cartid int primary key identity(1,1),
    userid int foreign key references users(userid),
    productid int foreign key references products(productid),
    quantity int not null default 1,
    addeddate datetime default getdate()
)

-- ����ϵͳ��־��
create table systemlogs (
    logid int primary key identity(1,1),
    userid int,
    operationtype nvarchar(50) not null,
    operationcontent nvarchar(max),
    operationtime datetime default getdate(),
    foreign key (userid) references users(userid)
)