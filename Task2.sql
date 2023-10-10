/* create categories table*/
CREATE TABLE [dbo].[Categories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE INDEX IX_Categories_Id ON [dbo].[Categories] (id);

/* create products table*/
CREATE TABLE [dbo].[Products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE INDEX IX_Products_Id ON [dbo].[Products] (id);

/* create relations table*/
CREATE TABLE [dbo].[Relations](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] INT FOREIGN KEY REFERENCES [dbo].[Products](Id) NOT NULL,
	[category_id] INT FOREIGN KEY REFERENCES [dbo].[Categories](Id) NULL,
 CONSTRAINT [PK_Relations] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE INDEX IX_Relations_Id ON [dbo].[Products] (id);

/* insert example values */
INSERT INTO [dbo].[Products] (name) VALUES ('POOP'), ('LOOP'), ('SOOP');
INSERT INTO [dbo].[Categories] (name) VALUES ('Cat1'), ('Cat2'), ('Cat3');
INSERT INTO [dbo].[Relations] VALUES 
	(1, 1),
	(1, 2),
	(1, 3), 
	(2, 1),
	(2, 2);

/* select pairs */
SELECT products.[name], categories.[name]
FROM [dbo].[Products] as products
LEFT JOIN [dbo].[Relations] as relations
	ON products.id = relations.product_id
LEFT JOIN [dbo].[Categories] as categories
	ON relations.category_id = categories.id;




