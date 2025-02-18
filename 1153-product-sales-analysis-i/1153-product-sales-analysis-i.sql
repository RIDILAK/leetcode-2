# Write your MySQL query statement below
select product_name,year,price
from Sales 
inner join Product on product.product_id=Sales.product_id;
