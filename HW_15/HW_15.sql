SELECT cust.id as CustomerID, FirstName, LastName, prod.id as ProductID,
	sum(quantity) as ProductQuantity, price as ProductPrice FROM customers cust
inner join orders ord
on cust.ID=ord.customerid
inner join products prod
on prod.ID=ord.productid
where age>30
group by cust.id, prod.id
having prod.id=1