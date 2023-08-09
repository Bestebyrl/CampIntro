--Select
Select ContactName Adi, CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

Select * from Products where categoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products order by UnitPrice asc	--ascendin(artan)  desc-descenting(azalan)

select count(*) Adet from Products where CategoryID=2

select categoryID, COUNT(*) from Products group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice,Categories.CategoryName
from Products inner join Categories on Products.CategoryID = Categories.CategoryID

select *  from Products p left join [Order Details] od on p.ProductID = od.ProductID

select *  from Customers c left join Orders o on c.CustomerID=o.CustomerID
where o.CustomerID is null