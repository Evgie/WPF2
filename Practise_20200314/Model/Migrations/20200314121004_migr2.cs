using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class migr2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_ProductId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Staffs_StaffId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Stores_StoreId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Stores_StoreId",
                table: "Staffs");

            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Products_ProductId",
                table: "Stocks");

            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Stores_StoreId",
                table: "Stocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stores",
                table: "Stores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stocks",
                table: "Stocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brands",
                table: "Brands");

            migrationBuilder.RenameTable(
                name: "Stores",
                newName: "stores (sales)");

            migrationBuilder.RenameTable(
                name: "Stocks",
                newName: "stocks (production)");

            migrationBuilder.RenameTable(
                name: "Staffs",
                newName: "staffs (sales)");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "products (production)");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "orders (sales)");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                newName: "order_items (sales)");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "customers (sales)");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "categories (production)");

            migrationBuilder.RenameTable(
                name: "Brands",
                newName: "brands (production)");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "stores (sales)",
                newName: "street");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "stores (sales)",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "stores (sales)",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "stores (sales)",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "stores (sales)",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "stores (sales)",
                newName: "zip_code");

            migrationBuilder.RenameColumn(
                name: "StoreName",
                table: "stores (sales)",
                newName: "store_name");

            migrationBuilder.RenameColumn(
                name: "StoreId",
                table: "stores (sales)",
                newName: "store_id");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "stocks (production)",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "stocks (production)",
                newName: "product_id");

            migrationBuilder.RenameColumn(
                name: "StoreId",
                table: "stocks (production)",
                newName: "store_id");

            migrationBuilder.RenameIndex(
                name: "IX_Stocks_ProductId",
                table: "stocks (production)",
                newName: "IX_stocks (production)_product_id");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "staffs (sales)",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "staffs (sales)",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "staffs (sales)",
                newName: "active");

            migrationBuilder.RenameColumn(
                name: "StoreId",
                table: "staffs (sales)",
                newName: "store_id");

            migrationBuilder.RenameColumn(
                name: "ManagerId",
                table: "staffs (sales)",
                newName: "manager_id");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "staffs (sales)",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "staffs (sales)",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "StaffId",
                table: "staffs (sales)",
                newName: "staff_id");

            migrationBuilder.RenameIndex(
                name: "IX_Staffs_StoreId",
                table: "staffs (sales)",
                newName: "IX_staffs (sales)_store_id");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "products (production)",
                newName: "product_name");

            migrationBuilder.RenameColumn(
                name: "ModelYear",
                table: "products (production)",
                newName: "model_year");

            migrationBuilder.RenameColumn(
                name: "ListPrice",
                table: "products (production)",
                newName: "list_price");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "products (production)",
                newName: "category_id");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "products (production)",
                newName: "brand_id");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "products (production)",
                newName: "product_id");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "products (production)",
                newName: "IX_products (production)_category_id");

            migrationBuilder.RenameIndex(
                name: "IX_Products_BrandId",
                table: "products (production)",
                newName: "IX_products (production)_brand_id");

            migrationBuilder.RenameColumn(
                name: "StoreId",
                table: "orders (sales)",
                newName: "store_id");

            migrationBuilder.RenameColumn(
                name: "OrderStatus",
                table: "orders (sales)",
                newName: "order_status");

            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "orders (sales)",
                newName: "order_date");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "orders (sales)",
                newName: "customer_id");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "orders (sales)",
                newName: "order_id");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_StoreId",
                table: "orders (sales)",
                newName: "IX_orders (sales)_store_id");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_StaffId",
                table: "orders (sales)",
                newName: "IX_orders (sales)_StaffId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomerId",
                table: "orders (sales)",
                newName: "IX_orders (sales)_customer_id");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "order_items (sales)",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "Discount",
                table: "order_items (sales)",
                newName: "discount");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "order_items (sales)",
                newName: "product_id");

            migrationBuilder.RenameColumn(
                name: "ListPrice",
                table: "order_items (sales)",
                newName: "list_price");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "order_items (sales)",
                newName: "item_id");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "order_items (sales)",
                newName: "order_id");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_ProductId",
                table: "order_items (sales)",
                newName: "IX_order_items (sales)_product_id");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "customers (sales)",
                newName: "street");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "customers (sales)",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "customers (sales)",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "customers (sales)",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "customers (sales)",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "customers (sales)",
                newName: "zip_code");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "customers (sales)",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "customers (sales)",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "customers (sales)",
                newName: "customer_id");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "categories (production)",
                newName: "category_name");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "categories (production)",
                newName: "brand_id");

            migrationBuilder.RenameColumn(
                name: "BrandName",
                table: "brands (production)",
                newName: "brand_name");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "brands (production)",
                newName: "brand_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_stores (sales)",
                table: "stores (sales)",
                column: "store_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_stocks (production)",
                table: "stocks (production)",
                columns: new[] { "store_id", "product_id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_staffs (sales)",
                table: "staffs (sales)",
                column: "staff_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_products (production)",
                table: "products (production)",
                column: "product_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orders (sales)",
                table: "orders (sales)",
                column: "order_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_order_items (sales)",
                table: "order_items (sales)",
                columns: new[] { "order_id", "item_id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_customers (sales)",
                table: "customers (sales)",
                column: "customer_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categories (production)",
                table: "categories (production)",
                column: "brand_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_brands (production)",
                table: "brands (production)",
                column: "brand_id");

            migrationBuilder.AddForeignKey(
                name: "FK_order_items (sales)_orders (sales)_order_id",
                table: "order_items (sales)",
                column: "order_id",
                principalTable: "orders (sales)",
                principalColumn: "order_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_order_items (sales)_products (production)_product_id",
                table: "order_items (sales)",
                column: "product_id",
                principalTable: "products (production)",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders (sales)_customers (sales)_customer_id",
                table: "orders (sales)",
                column: "customer_id",
                principalTable: "customers (sales)",
                principalColumn: "customer_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders (sales)_staffs (sales)_StaffId",
                table: "orders (sales)",
                column: "StaffId",
                principalTable: "staffs (sales)",
                principalColumn: "staff_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders (sales)_stores (sales)_store_id",
                table: "orders (sales)",
                column: "store_id",
                principalTable: "stores (sales)",
                principalColumn: "store_id");

            migrationBuilder.AddForeignKey(
                name: "FK_products (production)_brands (production)_brand_id",
                table: "products (production)",
                column: "brand_id",
                principalTable: "brands (production)",
                principalColumn: "brand_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products (production)_categories (production)_category_id",
                table: "products (production)",
                column: "category_id",
                principalTable: "categories (production)",
                principalColumn: "brand_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_staffs (sales)_stores (sales)_store_id",
                table: "staffs (sales)",
                column: "store_id",
                principalTable: "stores (sales)",
                principalColumn: "store_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_stocks (production)_products (production)_product_id",
                table: "stocks (production)",
                column: "product_id",
                principalTable: "products (production)",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_stocks (production)_stores (sales)_store_id",
                table: "stocks (production)",
                column: "store_id",
                principalTable: "stores (sales)",
                principalColumn: "store_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_items (sales)_orders (sales)_order_id",
                table: "order_items (sales)");

            migrationBuilder.DropForeignKey(
                name: "FK_order_items (sales)_products (production)_product_id",
                table: "order_items (sales)");

            migrationBuilder.DropForeignKey(
                name: "FK_orders (sales)_customers (sales)_customer_id",
                table: "orders (sales)");

            migrationBuilder.DropForeignKey(
                name: "FK_orders (sales)_staffs (sales)_StaffId",
                table: "orders (sales)");

            migrationBuilder.DropForeignKey(
                name: "FK_orders (sales)_stores (sales)_store_id",
                table: "orders (sales)");

            migrationBuilder.DropForeignKey(
                name: "FK_products (production)_brands (production)_brand_id",
                table: "products (production)");

            migrationBuilder.DropForeignKey(
                name: "FK_products (production)_categories (production)_category_id",
                table: "products (production)");

            migrationBuilder.DropForeignKey(
                name: "FK_staffs (sales)_stores (sales)_store_id",
                table: "staffs (sales)");

            migrationBuilder.DropForeignKey(
                name: "FK_stocks (production)_products (production)_product_id",
                table: "stocks (production)");

            migrationBuilder.DropForeignKey(
                name: "FK_stocks (production)_stores (sales)_store_id",
                table: "stocks (production)");

            migrationBuilder.DropPrimaryKey(
                name: "PK_stores (sales)",
                table: "stores (sales)");

            migrationBuilder.DropPrimaryKey(
                name: "PK_stocks (production)",
                table: "stocks (production)");

            migrationBuilder.DropPrimaryKey(
                name: "PK_staffs (sales)",
                table: "staffs (sales)");

            migrationBuilder.DropPrimaryKey(
                name: "PK_products (production)",
                table: "products (production)");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orders (sales)",
                table: "orders (sales)");

            migrationBuilder.DropPrimaryKey(
                name: "PK_order_items (sales)",
                table: "order_items (sales)");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customers (sales)",
                table: "customers (sales)");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categories (production)",
                table: "categories (production)");

            migrationBuilder.DropPrimaryKey(
                name: "PK_brands (production)",
                table: "brands (production)");

            migrationBuilder.RenameTable(
                name: "stores (sales)",
                newName: "Stores");

            migrationBuilder.RenameTable(
                name: "stocks (production)",
                newName: "Stocks");

            migrationBuilder.RenameTable(
                name: "staffs (sales)",
                newName: "Staffs");

            migrationBuilder.RenameTable(
                name: "products (production)",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "orders (sales)",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "order_items (sales)",
                newName: "OrderItems");

            migrationBuilder.RenameTable(
                name: "customers (sales)",
                newName: "Customers");

            migrationBuilder.RenameTable(
                name: "categories (production)",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "brands (production)",
                newName: "Brands");

            migrationBuilder.RenameColumn(
                name: "street",
                table: "Stores",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "Stores",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Stores",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Stores",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Stores",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "zip_code",
                table: "Stores",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "store_name",
                table: "Stores",
                newName: "StoreName");

            migrationBuilder.RenameColumn(
                name: "store_id",
                table: "Stores",
                newName: "StoreId");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "Stocks",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "Stocks",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "store_id",
                table: "Stocks",
                newName: "StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_stocks (production)_product_id",
                table: "Stocks",
                newName: "IX_Stocks_ProductId");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Staffs",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Staffs",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "active",
                table: "Staffs",
                newName: "Active");

            migrationBuilder.RenameColumn(
                name: "store_id",
                table: "Staffs",
                newName: "StoreId");

            migrationBuilder.RenameColumn(
                name: "manager_id",
                table: "Staffs",
                newName: "ManagerId");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Staffs",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "Staffs",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "staff_id",
                table: "Staffs",
                newName: "StaffId");

            migrationBuilder.RenameIndex(
                name: "IX_staffs (sales)_store_id",
                table: "Staffs",
                newName: "IX_Staffs_StoreId");

            migrationBuilder.RenameColumn(
                name: "product_name",
                table: "Products",
                newName: "ProductName");

            migrationBuilder.RenameColumn(
                name: "model_year",
                table: "Products",
                newName: "ModelYear");

            migrationBuilder.RenameColumn(
                name: "list_price",
                table: "Products",
                newName: "ListPrice");

            migrationBuilder.RenameColumn(
                name: "category_id",
                table: "Products",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "brand_id",
                table: "Products",
                newName: "BrandId");

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "Products",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_products (production)_category_id",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_products (production)_brand_id",
                table: "Products",
                newName: "IX_Products_BrandId");

            migrationBuilder.RenameColumn(
                name: "store_id",
                table: "Orders",
                newName: "StoreId");

            migrationBuilder.RenameColumn(
                name: "order_status",
                table: "Orders",
                newName: "OrderStatus");

            migrationBuilder.RenameColumn(
                name: "order_date",
                table: "Orders",
                newName: "OrderDate");

            migrationBuilder.RenameColumn(
                name: "customer_id",
                table: "Orders",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "order_id",
                table: "Orders",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_orders (sales)_store_id",
                table: "Orders",
                newName: "IX_Orders_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_orders (sales)_StaffId",
                table: "Orders",
                newName: "IX_Orders_StaffId");

            migrationBuilder.RenameIndex(
                name: "IX_orders (sales)_customer_id",
                table: "Orders",
                newName: "IX_Orders_CustomerId");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "OrderItems",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "discount",
                table: "OrderItems",
                newName: "Discount");

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "OrderItems",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "list_price",
                table: "OrderItems",
                newName: "ListPrice");

            migrationBuilder.RenameColumn(
                name: "item_id",
                table: "OrderItems",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "order_id",
                table: "OrderItems",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_order_items (sales)_product_id",
                table: "OrderItems",
                newName: "IX_OrderItems_ProductId");

            migrationBuilder.RenameColumn(
                name: "street",
                table: "Customers",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "Customers",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Customers",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Customers",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Customers",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "zip_code",
                table: "Customers",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Customers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "Customers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "customer_id",
                table: "Customers",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "category_name",
                table: "Categories",
                newName: "CategoryName");

            migrationBuilder.RenameColumn(
                name: "brand_id",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "brand_name",
                table: "Brands",
                newName: "BrandName");

            migrationBuilder.RenameColumn(
                name: "brand_id",
                table: "Brands",
                newName: "BrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stores",
                table: "Stores",
                column: "StoreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stocks",
                table: "Stocks",
                columns: new[] { "StoreId", "ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs",
                column: "StaffId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                columns: new[] { "OrderId", "ItemId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brands",
                table: "Brands",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_ProductId",
                table: "OrderItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Staffs_StaffId",
                table: "Orders",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "StaffId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Stores_StoreId",
                table: "Orders",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Stores_StoreId",
                table: "Staffs",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Products_ProductId",
                table: "Stocks",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Stores_StoreId",
                table: "Stocks",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
