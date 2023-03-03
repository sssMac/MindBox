SELECT p.name, c.name
FROM Products p
	LEFT JOIN ProductsCategories pc ON p.id = pc.product_id
	LEFT JOIN Categories c ON c.id = pc.category_id;