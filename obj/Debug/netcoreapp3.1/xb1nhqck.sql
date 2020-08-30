CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

CREATE TABLE "Custemers" (
    "id" INTEGER NOT NULL CONSTRAINT "PK_Custemers" PRIMARY KEY AUTOINCREMENT,
    "name" TEXT NULL,
    "lastname" TEXT NULL,
    "phone" TEXT NULL,
    "email" TEXT NULL,
    "adresse" TEXT NULL
);

CREATE TABLE "products" (
    "id" INTEGER NOT NULL CONSTRAINT "PK_products" PRIMARY KEY AUTOINCREMENT,
    "Name" TEXT NULL,
    "Type" TEXT NULL
);

CREATE TABLE "Orders" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Orders" PRIMARY KEY AUTOINCREMENT,
    "OrderPlace" TEXT NULL,
    "Number" INTEGER NOT NULL,
    "custemer_id" INTEGER NOT NULL,
    "Custemerid" INTEGER NULL,
    CONSTRAINT "FK_Orders_Custemers_Custemerid" FOREIGN KEY ("Custemerid") REFERENCES "Custemers" ("id") ON DELETE RESTRICT
);

CREATE TABLE "OrdersLignes" (
    "id" INTEGER NOT NULL CONSTRAINT "PK_OrdersLignes" PRIMARY KEY AUTOINCREMENT,
    "Products_id" INTEGER NOT NULL,
    "Order_id" INTEGER NOT NULL,
    "Quantity" INTEGER NOT NULL,
    "Price" REAL NOT NULL,
    "Productid" INTEGER NULL,
    "OrderId" INTEGER NULL,
    CONSTRAINT "FK_OrdersLignes_Orders_OrderId" FOREIGN KEY ("OrderId") REFERENCES "Orders" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_OrdersLignes_products_Productid" FOREIGN KEY ("Productid") REFERENCES "products" ("id") ON DELETE RESTRICT
);

CREATE INDEX "IX_Orders_Custemerid" ON "Orders" ("Custemerid");

CREATE INDEX "IX_OrdersLignes_OrderId" ON "OrdersLignes" ("OrderId");

CREATE INDEX "IX_OrdersLignes_Productid" ON "OrdersLignes" ("Productid");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20200818075846_InitialCreate', '3.1.7');

