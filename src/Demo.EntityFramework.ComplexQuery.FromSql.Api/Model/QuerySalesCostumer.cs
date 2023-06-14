namespace Demo.EntityFramework.ComplexQuery.FromSql.Api.Model;

public class QuerySalesCostumer
{
    public Guid SaleId { get; set; }
    public string SaleDescription { get; set; } = string.Empty;
    public double SaleValue { get; set; }
    public DateTime SaleDate { get; set; }

    public Guid CostumerId { get; set; }
    public string CostumerName { get; set; } = string.Empty;
    public string CostumerAddress { get; set; } = string.Empty;
}