use OrderFood
go
--Insert Roles
insert into Roles values(1, 'Super Admin'),(2, 'Admin')
go

--Insert Employee
insert into Employee(UserName,Password,FirstName,LastName,Address,Email,Phone,BirthDate,Role,ManagerID,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,Status)
values('sonlh','sonlh',N'Hoàng',N'Sơn','280 An Dương Vương','sonlh@gmail.com','012345678','1998-11-02',1,null,'2019-10-14',null,'2019-10-14',null,1),
('minhlc','minhlc',N'Cẩm',N'Minh','280 An Dương Vương','minhlc@gmail.com','012345678','1998-11-02',2,1,'2019-10-14',1,'2019-10-14',null,1)

go
--insert menu
insert into Menu(MenuName, MenuContent, ParentID, IsActive) values
(N'Trang Chủ','',null,1),
(N'Sản Phẩm','',null,1),
(N'Giỏ Hàng','',null,1),
(N'Liên Hệ','',null,1)

--insert ProductCategory
insert into ProductCategory(Name, MetaTitle, ParentID, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy, Status) values
(N'Đồ Ăn','do-an',null,'2019-10-14',1,'2019-10-14',1,1)
insert into ProductCategory(Name, MetaTitle, ParentID, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy, Status) values
(N'Đồ Uống','do-uong',null,'2019-10-14',1,'2019-10-14',1,1),
(N'Tráng Miệng','trang-mieng',null,'2019-10-14',1,'2019-10-14',1,1),
(N'Món Hấp','do-an/mon-hap',1,'2019-10-14',1,'2019-10-14',1,1),
(N'Món Xào','do-an/mon-xao',1,'2019-10-14',1,'2019-10-14',1,1),
(N'Món Chiên','do-an/mon-chien',1,'2019-10-14',1,'2019-10-14',1,1),
(N'Món Nướng','do-an/mon-nuong',1,'2019-10-14',1,'2019-10-14',1,1),
(N'Món Nước','do-an/mon-nuoc',1,'2019-10-14',1,'2019-10-14',1,1),
(N'Đồ Uống Đóng Chai','do-uong/do-uong-dong-chai',2,'2019-10-14',1,'2019-10-14',1,1),
(N'Đồ Uống Tự Làm','do-uong/do-uong-tu-lam',2,'2019-10-14',1,'2019-10-14',1,1),
(N'Chè','trang-mieng/che',3,'2019-10-14',2,'2019-10-14',1,1),
(N'Bánh','trang-mieng/banh',3,'2019-10-14',2,'2019-10-14',1,1),
(N'Trái Cây','trang-mieng/trai-cay',3,'2019-10-14',2,'2019-10-14',1,1)


