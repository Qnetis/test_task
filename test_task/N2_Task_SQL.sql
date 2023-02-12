

CREATE TABLE Products (
  Id INT NOT NULL PRIMARY KEY,
  Name VARCHAR(50) NOT NULL,
  Description VARCHAR(50) DEFAULT NULL
);

CREATE TABLE Category (
  Id INT NOT NULL PRIMARY KEY,
  Name VARCHAR(50) NOT NULL,
  Department VARCHAR(250) DEFAULT NULL
);
CREATE TABLE Products_Connection_Category  (
Product_id INT NOT NULL,
Category_id INT NOT NULL,

FOREIGN KEY (Product_id) REFERENCES Products (Id) ON DELETE NO ACTION,
FOREIGN KEY (Category_id) REFERENCES Category (Id) ON DELETE NO ACTION
);

INSERT INTO Products VALUES (1,'Домик в деревне','3 процента жира'), (2,'Ручка М82','Синяя'), (3,'Whiskas',null), (4,'Простоквашино','Глазированный сырок');
INSERT INTO Category VALUES(1,'Молочные продукты',"Еда"), (2,'Недельные скидки','Ниже чем на прилавке'),(3,'Ручки','Канцелярия'),(4,'Сухой корм','Животные');
INSERT INTO Products_Connection_Category 
VALUES
(1, 1), 
(1, 2), 
(2, 3), 
(3,4);


SELECT 
	p.name AS "Продукт",
	c.name AS "Категория"
FROM Products p
LEFT JOIN Products_Connection_Category connect ON  connect.Product_id = p.Id
LEFT JOIN Category  c ON c.Id = connect.Category_id
ORDER BY p.name


