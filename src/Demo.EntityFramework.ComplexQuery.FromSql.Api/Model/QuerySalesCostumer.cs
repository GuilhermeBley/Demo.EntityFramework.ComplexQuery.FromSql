namespace Demo.EntityFramework.ComplexQuery.FromSql.Api.Model;

public class QuerySalesCostumer
{
    public Guid SaleId { get; set; }
    public string SaleDescription { get; set; } = string.Empty;
    public double SaleValue { get; set; }
    public DateTime SaleDate { get; set; }

    public Guid CustomerId { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string CustomerAddress { get; set; } = string.Empty;
}