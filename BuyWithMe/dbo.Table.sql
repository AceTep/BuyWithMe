﻿CREATE TABLE ShoppingLists
(
	ID INT NOT NULL PRIMARY KEY,
	Itemname VARCHAR(40) NOT NULL,
	ItemPrice DECIMAL(3,2) NOT NULL,
	ItemQuantity INT NOT NULL
)