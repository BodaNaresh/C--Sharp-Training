create table Category(cid int primary key identity(1,1),catid int,cName nvarchar(30))

create table Products(pid int primary key identity(1,1),Name nvarchar(30),Price money,Qty int, catid int)


select * from Category


select * from Products


create procedure sp_categoryproduct
as
begin
select p.pid,p.Name,p.price,p.Qty,c.cName from Products as p inner join  Category as c on p.catid=c.catid
end

exec sp_categoryproduct
