using Microsoft.EntityFrameworkCore;

namespace GestionComande.Web.Models
{
    public interface INorthwindContext
    {
        DbSet<AlphabeticalListOfProduct> AlphabeticalListOfProducts { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<CategorySalesFor1997> CategorySalesFor1997s { get; set; }
        DbSet<CurrentProductList> CurrentProductLists { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<CustomerAndSuppliersByCity> CustomerAndSuppliersByCities { get; set; }
        DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Invoice> Invoices { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderDetail> OrderDetails { get; set; }
        DbSet<OrderDetailsExtended> OrderDetailsExtendeds { get; set; }
        DbSet<OrderSubtotal> OrderSubtotals { get; set; }
        DbSet<OrdersQry> OrdersQries { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductSalesFor1997> ProductSalesFor1997s { get; set; }
        DbSet<ProductsAboveAveragePrice> ProductsAboveAveragePrices { get; set; }
        DbSet<ProductsByCategory> ProductsByCategories { get; set; }
        DbSet<QuarterlyOrder> QuarterlyOrders { get; set; }
        DbSet<Region> Regions { get; set; }
        DbSet<SalesByCategory> SalesByCategories { get; set; }
        DbSet<SalesTotalsByAmount> SalesTotalsByAmounts { get; set; }
        DbSet<Shipper> Shippers { get; set; }
        DbSet<SummaryOfSalesByQuarter> SummaryOfSalesByQuarters { get; set; }
        DbSet<SummaryOfSalesByYear> SummaryOfSalesByYears { get; set; }
        DbSet<Supplier> Suppliers { get; set; }
        DbSet<Territory> Territories { get; set; }
    }
}