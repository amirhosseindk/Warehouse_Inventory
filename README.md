# Warehouse Inventory Management System

This is a comprehensive Warehouse Inventory Management System developed in C#. The project is structured following the Clean Architecture principles and uses Entity Framework Core for data access. 

## Features

1. **User Management**: The system provides comprehensive user management features. It includes services for user commands and validation. The user-related functionalities are encapsulated in the `UserCommandService.cs`, `UserService.cs`, and `UserVMValidator.cs` files.

2. **Supplier and Consumer Management**: The system allows managing suppliers and consumers. The related functionalities are encapsulated in the `SupplierCommandService.cs`, `SupplierService.cs`, `ConsumerCommandService.cs`, and `ConsumerService.cs` files.

3. **Country and Measure Management**: The system provides features to manage countries and measures. The related functionalities are encapsulated in the `CountryCommandService.cs`, `CountryService.cs`, `MeasureCommandService.cs`, and `MeasureService.cs` files.

4. **Inventory Management**: The system provides comprehensive inventory management features. It includes functionalities for managing inventory items, inventory receipts, inventory requisitions, and inventory turnovers. The related functionalities are encapsulated in the `Inventory.cs`, `InventoryItemList.cs`, `InventoryReceipt.cs`, `InventoryRequisition.cs`, and `InventoryTurnover.cs` files.

5. **Commodity and Category Management**: The system allows managing commodities and categories. The related functionalities are encapsulated in the `Commodity.cs` and `Category.cs` files.

6. **Buy Request Management**: The system provides features to manage buy requests. The related functionalities are encapsulated in the `BuyRequest.cs` and `BuyRequestItemList.cs` files.

7. **Warehouse Management**: The system provides features to manage warehouses. The related functionalities are encapsulated in the `Warehouse.cs` file.

8. **Password Hashing**: The system includes a password hashing service for secure user authentication. The related functionalities are encapsulated in the `PasswordHasher.cs` file.

9. **Mapping Configurations**: The system includes mapping configurations for data transfer objects. The related functionalities are encapsulated in the `MappingConfig.cs` file.

## Entities

The system includes several entities, each representing a different aspect of the warehouse inventory management. Here are the main entities:

- `User`: Represents a system user.
- `Supplier`: Represents a supplier.
- `Consumer`: Represents a consumer.
- `MadeInCountry`: Represents the country of origin of a product.
- `UnitMeasure`: Represents the unit of measure of a product.
- `Commodity`: Represents a commodity.
- `Category`: Represents a category of commodities.
- `BuyRequest`: Represents a buy request.
- `Inventory`: Represents an inventory.
- `Warehouse`: Represents a warehouse.

## Services

The system includes several services, each providing different functionalities:

- `GenericCommandServices`: Provides generic command services.
- `GenericServices`: Provides generic services.
- `UserCommandService`: Provides user command services.
- `UserService`: Provides user services.
- `SupplierCommandService`: Provides supplier command services.
- `SupplierService`: Provides supplier services.
- `ConsumerCommandService`: Provides consumer command services.
- `ConsumerService`: Provides consumer services.
- `CountryCommandService`: Provides country command services.
- `CountryService`: Provides country services.
- `MeasureCommandService`: Provides measure command services.
- `MeasureService`: Provides measure services.
- `PasswordHasher`: Provides password hashing services.

Please refer to the respective files for more details about each feature, entity, and service.
