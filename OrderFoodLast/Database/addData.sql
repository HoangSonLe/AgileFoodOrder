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
(N'Món Hấp','mon-hap',1,'2019-10-14',1,'2019-10-14',1,1),
(N'Món Xào','mon-xao',1,'2019-10-14',1,'2019-10-14',1,1),
(N'Món Chiên','mon-chien',1,'2019-10-14',1,'2019-10-14',1,1),
(N'Món Nướng','mon-nuong',1,'2019-10-14',1,'2019-10-14',1,1),
(N'Món Nước','mon-nuoc',1,'2019-10-14',1,'2019-10-14',1,1),
(N'Đồ Uống Đóng Chai','do-uong-dong-chai',2,'2019-10-14',1,'2019-10-14',1,1),
(N'Đồ Uống Tự Làm','do-uong-tu-lam',2,'2019-10-14',1,'2019-10-14',1,1),
(N'Chè','che',3,'2019-10-14',2,'2019-10-14',1,1),
(N'Bánh','banh',3,'2019-10-14',2,'2019-10-14',1,1),
(N'Trái Cây','trai-cay',3,'2019-10-14',2,'2019-10-14',1,1)


go
--insert Product món hấp
insert into Product(ProductName, SeoTitle, Description, ProductImage, Price, PromotionPrice,
					IncludeVAT, Quantity, CategoryID, CreatedDate, CreatedBy, ModifiedDate,
					ModifiedBy, Status, ViewCounts) values
(N'Bắp Bò Luộc','mon-hap/bap-bo-luoc',N'','BapBoLuoc.jpg',70000,65000,
1,50,4,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Cá Diêu Hồng Hấp','mon-hap/ca-dieu-hong-hap',N'','CaDieuHongHap.jpg',80000,65000,
1,50,4,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Cua Hấp','mon-hap/cua-hap',N'','CuaHap.jpg',80000,65000,
1,50,4,'2019-10-14',1,'2019-10-14',2,1,20),
(N'Gà Hấp Hành','mon-hap/ga-hap-hanh',N'','GaHapHanh.jpg',150000,140000,
1,50,4,'2019-10-14',1,'2019-10-14',2,1,20),
(N'Gà Hấp Muối','mon-hap/ga-hap-muoi',N'','GaHapMuoi.jpg',150000,140000,
1,40,4,'2019-10-14',1,'2019-10-14',2,1,20),
(N'Nghêu Hấp Thái','mon-hap/ngheu-hap-thai',N'','NgheuHapThai.jpg',70000,60000,
1,50,4,'2019-10-14',1,'2019-10-14',2,1,20)


go
--insert product món xào
insert into Product(ProductName, SeoTitle, Description, ProductImage, Price, PromotionPrice,
					IncludeVAT, Quantity, CategoryID, CreatedDate, CreatedBy, ModifiedDate,
					ModifiedBy, Status, ViewCounts) values
(N'Bắp Xào Bơ','mon-xao/bap-xao-bo',N'','BapXaoBo.jpg',20000,15000,
1,60,5,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Lươn Xào Lăn','mon-xao/luon-xao-lan',N'','LuonXaoLan.jpg',150000,140000,
1,60,5,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Mì Xào Bò','mon-xao/mi-xao-bo',N'','MyXaoBo.jpg',40000,35000,
1,60,5,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Mì Xào Hải Sản','mon-xao/mi-xao-hai-san',N'','MyXaoHaiSan.jpg',40000,35000,
1,60,5,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Mì Xào Trứng','mon-xao/mi-xao-trung',N'','MyXaoTrung.jpg',30000,25000,
1,60,5,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Nui Xào Trứng','mon-xao/mi-xao-trung',N'','NuiXaoTrung.jpg',30000,25000,
1,60,5,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Nui Xào Bò','mon-xao/nui-xao-bo',N'','NuiXaoBo.jpg',40000,35000,
1,60,5,'2019-10-14',2,'2019-10-14',1,1,20)


go
--insert product món chiên
insert into Product(ProductName, SeoTitle, Description, ProductImage, Price, PromotionPrice,
					IncludeVAT, Quantity, CategoryID, CreatedDate, CreatedBy, ModifiedDate,
					ModifiedBy, Status, ViewCounts) values
(N'Cơm Chiên Dương Châu','mon-chien/com-chien-duong-chau',N'','ComChienDuongChau.jpg',40000,35000,
1,60,6,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Cơm Chiên Xúc Xích','mon-chien/com-chien-xuc-xich',N'','ComChienXucXich.jpg',40000,35000,
1,60,6,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Cơm Gà Xối Mỡ','mon-chien/com-ga-xoi-mo',N'','ComChienXucXich.jpg',50000,40000,
1,80,6,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Giò Heo Chiên Giòn','mon-chien/gio-heo-chien-gion',N'','GioHeoChienGion.jpg',50000,40000,
1,80,6,'2019-10-14',2,'2019-10-14',1,1,20)


go
--insert product món nướng
insert into Product(ProductName, SeoTitle, Description, ProductImage, Price, PromotionPrice,
					IncludeVAT, Quantity, CategoryID, CreatedDate, CreatedBy, ModifiedDate,
					ModifiedBy, Status, ViewCounts) values
(N'Bạch Tuộc Nướng','mon-nuong/bach-tuoc-nuong',N'','BachTuocNuong.jpg',50000,45000,
1,50,7,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Ba Rọi Nướng','mon-nuong/ba-roi-nuong',N'','BaRoiNuong.jpg',50000,45000,
1,50,7,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Bò Nướng Lụi','mon-nuong/bo-nuong-lui',N'','BoNuongLui.jpg',50000,45000,
1,50,7,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Cá Sapa Nướng','mon-nuong/ca-sapa-nuong',N'','CaSapaNuong.jpg',50000,45000,
1,80,7,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Đùi Gà Quay','mon-nuong/dui-ga-quay',N'','DuiGaQuay.jpg',50000,45000,
1,80,7,'2019-10-14',2,'2019-10-14',1,1,20)


go
--insert product món nước
insert into Product(ProductName, SeoTitle, Description, ProductImage, Price, PromotionPrice,
					IncludeVAT, Quantity, CategoryID, CreatedDate, CreatedBy, ModifiedDate,
					ModifiedBy, Status, ViewCounts) values
(N'Phở Bò','mon-nuoc/dui-ga-quay',N'','PhoBo.jpg',40000,35000,
1,80,8,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Mì Sủi Cảo','mon-nuoc/mi-sui-cao',N'','MySuiCao.jpg',40000,35000,
1,80,8,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Mì Vit Tiem','mon-nuoc/mi-vit-tiem',N'','MyVitTiem.jpg',40000,35000,
1,80,8,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Súp Cua','mon-nuoc/sup-cua',N'','SupCua.jpg',40000,35000,
1,80,8,'2019-10-14',2,'2019-10-14',1,1,20)


go
--insert product Đồ uống đóng chai
insert into Product(ProductName, SeoTitle, Description, ProductImage, Price, PromotionPrice,
					IncludeVAT, Quantity, CategoryID, CreatedDate, CreatedBy, ModifiedDate,
					ModifiedBy, Status, ViewCounts) values
(N'CocaCola','do-uong-dong-chai/cocacola',N'','CocaCola.jpg',15000,10000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Pepsi','do-uong-dong-chai/pepsi',N'','Pepsi.jpg',15000,10000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Mirinda Soda Kem','do-uong-dong-chai/mirinda-soda-kem',N'','MirindaSodaKem.jpg',15000,10000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Mirinda Cam','do-uong-dong-chai/mirinda-cam',N'','MirindaCam.jpg',15000,10000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Mirinda Sá Xị','do-uong-dong-chai/mirinda-sa-xi',N'','MirindaSaxi.jpg',15000,10000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Bò Húc','do-uong-dong-chai/bo-huc',N'','BoHuc.jpg',15000,10000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Sting Dâu','do-uong-dong-chai/sting-dau',N'','StingDau.jpg',15000,10000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Sting Vàng','do-uong-dong-chai/sting-vang',N'','StingVang.jpg',15000,10000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Heniken','do-uong-dong-chai/heniken',N'','Heniken.jpg',20000,15000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Tiger Nâu','do-uong-dong-chai/tiger-nau',N'','TigerNau.jpg',20000,15000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Tiger Bạc','do-uong-dong-chai/tiger-bac',N'','TigerBac.jpg',20000,15000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Monster','do-uong-dong-chai/monster',N'','Monster.jpg',40000,35000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20)




go
--insert product Đồ uống tự làm
insert into Product(ProductName, SeoTitle, Description, ProductImage, Price, PromotionPrice,
					IncludeVAT, Quantity, CategoryID, CreatedDate, CreatedBy, ModifiedDate,
					ModifiedBy, Status, ViewCounts) values
(N'Nước Ép Cam','do-uong-tu-lam/nuoc-ep-cam',N'','CamEp.jpg',20000,15000,
1,500,10,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Nước Ép Ổi','do-uong-tu-lam/nuoc-ep-oi',N'','OiEp.jpg',20000,15000,
1,500,10,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Nước Ép Chanh','do-uong-tu-lam/nuoc-ep-chanh',N'','ChanhEp.jpg',20000,15000,
1,500,10,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Nước Ép Carot','do-uong-tu-lam/nuoc-ep-carot',N'','CarotEp.jpg',20000,15000,
1,500,10,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Nước Ép Cà Chua','do-uong-tu-lam/nuoc-ep-ca-chua',N'','CaChuaEp.jpg',20000,15000,
1,500,10,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Trà Sữa','do-uong-tu-lam/tra-sua',N'','TraSua.jpg',20000,15000,
1,500,10,'2019-10-14',2,'2019-10-14',1,1,20)




go
-- insert product  chè
insert into Product(ProductName, SeoTitle, Description, ProductImage, Price, PromotionPrice,
					IncludeVAT, Quantity, CategoryID, CreatedDate, CreatedBy, ModifiedDate,
					ModifiedBy, Status, ViewCounts) values
(N'Chè Sâm Bổ Lượng','che/che-sam-bo-luong',N'','CheSamBoLuong.jpg',15000,10000,
1,500,11,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Chè Thái','che/che-thai',N'','CheThai.jpg',15000,10000,
1,500,11,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Chè Long Nhản','che/che-long-nhan',N'','CheLongNhan.jpg',15000,10000,
1,500,11,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Chè Khúc Bạch','che/che-khuc-bach',N'','CheKhucBach.jpg',15000,10000,
1,500,11,'2019-10-14',2,'2019-10-14',1,1,20)



go
--insert product  trái cây
insert into Product(ProductName, SeoTitle, Description, ProductImage, Price, PromotionPrice,
					IncludeVAT, Quantity, CategoryID, CreatedDate, CreatedBy, ModifiedDate,
					ModifiedBy, Status, ViewCounts) values

(N'Trai Cây Tô','trai-cay/trai-cay-to',N'','TraiCayTo.jpg',20000,15000,
1,500,13,'2019-10-14',2,'2019-10-14',1,1,20)


go
-- insert product  bánh
insert into Product(ProductName, SeoTitle, Description, ProductImage, Price, PromotionPrice,
					IncludeVAT, Quantity, CategoryID, CreatedDate, CreatedBy, ModifiedDate,
					ModifiedBy, Status, ViewCounts) values
(N'Su Kem','banh/su-kem',N'','SuKem.jpg',15000,10000,
1,500,12,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Donut','banh/donut',N'','Donut.jpg',15000,10000,
1,500,12,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Bông Lan Trứng Muối','banh/bong-lan-trung-muoi',N'','BongLanTrungMuoi.jpg',15000,10000,
1,500,12,'2019-10-14',2,'2019-10-14',1,1,20)


--insert customer 
select * from Customer
insert into Customer(UserName, Password, FirstName, LastName, Address, Email, Phone,
					CreatedDate, CreatedBy, ModifiedDate, ModifiedBy, Status) values
('phuongnh','phuongnh',N'Hoàng',N'Phương','280 An Dương Vương','phuongnh@gmail.com','0123456',
'2019-10-14',null,'2019-10-14',null,1)

insert into Customer(UserName, Password, FirstName, LastName, Address, Email, Phone,
					CreatedDate, CreatedBy, ModifiedDate, ModifiedBy, Status) values
('thanhhv','thanhhv',N'Văn',N'Thành','280 An Dương Vương','thanhhv@gmail.com','0123456',
'2019-10-14',null,'2019-10-14',null,1)



go
--insert Orders
insert into Orders(CustomerID, EmployeeID, Comment, OrderStatus,
				CreatedDate, CreatedBy, ModifiedDate, ModifiedBy, ShipDate,Total)values
(1,null,N'Giao trước 3h',1,'2019-10-14',null,'2019-10-14',null,null, 120000)

insert into Orders(CustomerID, EmployeeID, Comment, OrderStatus,
				CreatedDate, CreatedBy, ModifiedDate, ModifiedBy, ShipDate, Total)values
(2,null,N'Giao trước 7h',1,'2019-10-14',null,'2019-10-14',null,null, 6969696)

--insert order detail
insert into OrderDetail(OrderID,ProductID,Quantity) values
(1,1,3),(1,2,1),(2,2,1),(2,3,1)


go
--insert Product món hấp
insert into Product(ProductName, SeoTitle, Description, ProductImage, Price, PromotionPrice,
					IncludeVAT, Quantity, CategoryID, CreatedDate, CreatedBy, ModifiedDate,
					ModifiedBy, Status, ViewCounts) values
(N'Bắp Bò Luộc','mon-hap/bap-bo-luoc',N'','BapBoLuoc.jpg',70000,65000,
1,50,4,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Cá Diêu Hồng Hấp','mon-hap/ca-dieu-hong-hap',N'','CaDieuHongHap.jpg',80000,65000,
1,50,4,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Cua Hấp','mon-hap/cua-hap',N'','CuaHap.jpg',80000,65000,
1,50,4,'2019-10-14',1,'2019-10-14',2,1,20),
(N'Gà Hấp Hành','mon-hap/ga-hap-hanh',N'','GaHapHanh.jpg',150000,140000,
1,50,4,'2019-10-14',1,'2019-10-14',2,1,20),
(N'Gà Hấp Muối','mon-hap/ga-hap-muoi',N'','GaHapMuoi.jpg',150000,140000,
1,40,4,'2019-10-14',1,'2019-10-14',2,1,20),
(N'Nghêu Hấp Thái','mon-hap/ngheu-hap-thai',N'','NgheuHapThai.jpg',70000,60000,
1,50,4,'2019-10-14',1,'2019-10-14',2,1,20)


go
--insert product món xào
insert into Product(ProductName, SeoTitle, Description, ProductImage, Price, PromotionPrice,
					IncludeVAT, Quantity, CategoryID, CreatedDate, CreatedBy, ModifiedDate,
					ModifiedBy, Status, ViewCounts) values
(N'Bắp Xào Bơ','mon-xao/bap-xao-bo',N'','BapXaoBo.jpg',20000,15000,
1,60,5,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Lươn Xào Lăn','mon-xao/luon-xao-lan',N'','LuonXaoLan.jpg',150000,140000,
1,60,5,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Mì Xào Bò','mon-xao/mi-xao-bo',N'','MyXaoBo.jpg',40000,35000,
1,60,5,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Mì Xào Hải Sản','mon-xao/mi-xao-hai-san',N'','MyXaoHaiSan.jpg',40000,35000,
1,60,5,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Mì Xào Trứng','mon-xao/mi-xao-trung',N'','MyXaoTrung.jpg',30000,25000,
1,60,5,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Nui Xào Trứng','mon-xao/mi-xao-trung',N'','NuiXaoTrung.jpg',30000,25000,
1,60,5,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Nui Xào Bò','mon-xao/nui-xao-bo',N'','NuiXaoBo.jpg',40000,35000,
1,60,5,'2019-10-14',2,'2019-10-14',1,1,20)


go
--insert product món chiên
insert into Product(ProductName, SeoTitle, Description, ProductImage, Price, PromotionPrice,
					IncludeVAT, Quantity, CategoryID, CreatedDate, CreatedBy, ModifiedDate,
					ModifiedBy, Status, ViewCounts) values
(N'Cơm Chiên Dương Châu','mon-chien/com-chien-duong-chau',N'','ComChienDuongChau.jpg',40000,35000,
1,60,6,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Cơm Chiên Xúc Xích','mon-chien/com-chien-xuc-xich',N'','ComChienXucXich.jpg',40000,35000,
1,60,6,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Cơm Gà Xối Mỡ','mon-chien/com-ga-xoi-mo',N'','ComChienXucXich.jpg',50000,40000,
1,80,6,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Giò Heo Chiên Giòn','mon-chien/gio-heo-chien-gion',N'','GioHeoChienGion.jpg',50000,40000,
1,80,6,'2019-10-14',2,'2019-10-14',1,1,20)


go
--insert product món nướng
insert into Product(ProductName, SeoTitle, Description, ProductImage, Price, PromotionPrice,
					IncludeVAT, Quantity, CategoryID, CreatedDate, CreatedBy, ModifiedDate,
					ModifiedBy, Status, ViewCounts) values
(N'Bạch Tuộc Nướng','mon-nuong/bach-tuoc-nuong',N'','BachTuocNuong.jpg',50000,45000,
1,50,7,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Ba Rọi Nướng','mon-nuong/ba-roi-nuong',N'','BaRoiNuong.jpg',50000,45000,
1,50,7,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Bò Nướng Lụi','mon-nuong/bo-nuong-lui',N'','BoNuongLui.jpg',50000,45000,
1,50,7,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Cá Sapa Nướng','mon-nuong/ca-sapa-nuong',N'','CaSapaNuong.jpg',50000,45000,
1,80,7,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Đùi Gà Quay','mon-nuong/dui-ga-quay',N'','DuiGaQuay.jpg',50000,45000,
1,80,7,'2019-10-14',2,'2019-10-14',1,1,20)


go
--insert product món nước
insert into Product(ProductName, SeoTitle, Description, ProductImage, Price, PromotionPrice,
					IncludeVAT, Quantity, CategoryID, CreatedDate, CreatedBy, ModifiedDate,
					ModifiedBy, Status, ViewCounts) values
(N'Phở Bò','mon-nuoc/dui-ga-quay',N'','PhoBo.jpg',40000,35000,
1,80,8,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Mì Sủi Cảo','mon-nuoc/mi-sui-cao',N'','MySuiCao.jpg',40000,35000,
1,80,8,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Mì Vit Tiem','mon-nuoc/mi-vit-tiem',N'','MyVitTiem.jpg',40000,35000,
1,80,8,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Súp Cua','mon-nuoc/sup-cua',N'','SupCua.jpg',40000,35000,
1,80,8,'2019-10-14',2,'2019-10-14',1,1,20)


go
--insert product Đồ uống đóng chai
insert into Product(ProductName, SeoTitle, Description, ProductImage, Price, PromotionPrice,
					IncludeVAT, Quantity, CategoryID, CreatedDate, CreatedBy, ModifiedDate,
					ModifiedBy, Status, ViewCounts) values
(N'CocaCola','do-uong-dong-chai/cocacola',N'','CocaCola.jpg',15000,10000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Pepsi','do-uong-dong-chai/pepsi',N'','Pepsi.jpg',15000,10000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Mirinda Soda Kem','do-uong-dong-chai/mirinda-soda-kem',N'','MirindaSodaKem.jpg',15000,10000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Mirinda Cam','do-uong-dong-chai/mirinda-cam',N'','MirindaCam.jpg',15000,10000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Mirinda Sá Xị','do-uong-dong-chai/mirinda-sa-xi',N'','MirindaSaxi.jpg',15000,10000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Bò Húc','do-uong-dong-chai/bo-huc',N'','BoHuc.jpg',15000,10000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Sting Dâu','do-uong-dong-chai/sting-dau',N'','StingDau.jpg',15000,10000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Sting Vàng','do-uong-dong-chai/sting-vang',N'','StingVang.jpg',15000,10000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Heniken','do-uong-dong-chai/heniken',N'','Heniken.jpg',20000,15000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Tiger Nâu','do-uong-dong-chai/tiger-nau',N'','TigerNau.jpg',20000,15000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Tiger Bạc','do-uong-dong-chai/tiger-bac',N'','TigerBac.jpg',20000,15000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Monster','do-uong-dong-chai/monster',N'','Monster.jpg',40000,35000,
1,500,9,'2019-10-14',2,'2019-10-14',1,1,20)




go
--insert product Đồ uống tự làm
insert into Product(ProductName, SeoTitle, Description, ProductImage, Price, PromotionPrice,
					IncludeVAT, Quantity, CategoryID, CreatedDate, CreatedBy, ModifiedDate,
					ModifiedBy, Status, ViewCounts) values
(N'Nước Ép Cam','do-uong-tu-lam/nuoc-ep-cam',N'','CamEp.jpg',20000,15000,
1,500,10,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Nước Ép Ổi','do-uong-tu-lam/nuoc-ep-oi',N'','OiEp.jpg',20000,15000,
1,500,10,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Nước Ép Chanh','do-uong-tu-lam/nuoc-ep-chanh',N'','ChanhEp.jpg',20000,15000,
1,500,10,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Nước Ép Carot','do-uong-tu-lam/nuoc-ep-carot',N'','CarotEp.jpg',20000,15000,
1,500,10,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Nước Ép Cà Chua','do-uong-tu-lam/nuoc-ep-ca-chua',N'','CaChuaEp.jpg',20000,15000,
1,500,10,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Trà Sữa','do-uong-tu-lam/tra-sua',N'','TraSua.jpg',20000,15000,
1,500,10,'2019-10-14',2,'2019-10-14',1,1,20)




go
-- insert product  chè
insert into Product(ProductName, SeoTitle, Description, ProductImage, Price, PromotionPrice,
					IncludeVAT, Quantity, CategoryID, CreatedDate, CreatedBy, ModifiedDate,
					ModifiedBy, Status, ViewCounts) values
(N'Chè Sâm Bổ Lượng','che/che-sam-bo-luong',N'','CheSamBoLuong.jpg',15000,10000,
1,500,11,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Chè Thái','che/che-thai',N'','CheThai.jpg',15000,10000,
1,500,11,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Chè Long Nhản','che/che-long-nhan',N'','CheLongNhan.jpg',15000,10000,
1,500,11,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Chè Khúc Bạch','che/che-khuc-bach',N'','CheKhucBach.jpg',15000,10000,
1,500,11,'2019-10-14',2,'2019-10-14',1,1,20)



go
--insert product  trái cây
insert into Product(ProductName, SeoTitle, Description, ProductImage, Price, PromotionPrice,
					IncludeVAT, Quantity, CategoryID, CreatedDate, CreatedBy, ModifiedDate,
					ModifiedBy, Status, ViewCounts) values

(N'Trai Cây Tô','trai-cay/trai-cay-to',N'','TraiCayTo.jpg',20000,15000,
1,500,13,'2019-10-14',2,'2019-10-14',1,1,20)


go
-- insert product  bánh
insert into Product(ProductName, SeoTitle, Description, ProductImage, Price, PromotionPrice,
					IncludeVAT, Quantity, CategoryID, CreatedDate, CreatedBy, ModifiedDate,
					ModifiedBy, Status, ViewCounts) values
(N'Su Kem','banh/su-kem',N'','SuKem.jpg',15000,10000,
1,500,12,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Donut','banh/donut',N'','Donut.jpg',15000,10000,
1,500,12,'2019-10-14',2,'2019-10-14',1,1,20),
(N'Bông Lan Trứng Muối','banh/bong-lan-trung-muoi',N'','BongLanTrungMuoi.jpg',15000,10000,
1,500,12,'2019-10-14',2,'2019-10-14',1,1,20)


--insert customer 
select * from Customer
insert into Customer(UserName, Password, FirstName, LastName, Address, Email, Phone,
					CreatedDate, CreatedBy, ModifiedDate, ModifiedBy, Status) values
('phuongnh','phuongnh',N'Hoàng',N'Phương','280 An Dương Vương','phuongnh@gmail.com','0123456',
'2019-10-14',null,'2019-10-14',null,1)

insert into Customer(UserName, Password, FirstName, LastName, Address, Email, Phone,
					CreatedDate, CreatedBy, ModifiedDate, ModifiedBy, Status) values
('thanhhv','thanhhv',N'Văn',N'Thành','280 An Dương Vương','thanhhv@gmail.com','0123456',
'2019-10-14',null,'2019-10-14',null,1)



go
--insert Orders
insert into Orders(CustomerID, EmployeeID, Comment, OrderStatus,
				CreatedDate, CreatedBy, ModifiedDate, ModifiedBy, ShipDate)values
(1,null,N'Giao trước 3h',1,'2019-10-14',null,'2019-10-14',null,null)

insert into Orders(CustomerID, EmployeeID, Comment, OrderStatus,
				CreatedDate, CreatedBy, ModifiedDate, ModifiedBy, ShipDate)values
(2,null,N'Giao trước 7h',1,'2019-10-14',null,'2019-10-14',null,null)

--insert order detail
insert into OrderDetail(OrderID,ProductID,Quantity) values
(1,1,3),(1,2,1),(2,2,1),(2,3,1)




