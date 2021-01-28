--select
--ANSI
Select ContactName Adi,CompanyName ŞirketAdi,City Şehri from Customers

Select * from Customers where City = 'London'

select * from Products where CategoryID =1 or CategoryID = 3

select * from Products where CategoryID =1 and  UnitPrice >= 10

select * from Products where CategoryID = 1 order by UnitPrice desc   ---ascending   ---descending

select count (*) Adet from Products where CategoryID = 2

select categoryID, count (*) from Products where UnitPrice>20 group by CategoryID having count (*)<10



select Products.ProductID, Products.ProductName, Products.UnitPrice,Categories.CategoryName
 from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10


--DTO  Date Transfeormation Object

---inner join sadece iki tabloda eşleşenleri getirir eşleşmeyen varsa getirmez

select * from Products p inner join [Order Details] od  --left = solda olup sağda olmayanları getir
on p.ProductID = od.ProductID
inner join orders o
on o.OrderID = od.OrderID

Select * from Customers c left join Orders o            ---right join sağda olup solda olmayan demek
on c.CustomerID = o.CustomerID
where  o.CustomerID is null




