using Demo.EntityFramework.ComplexQuery.FromSql.Api.EntityFramework;
using Demo.EntityFramework.ComplexQuery.FromSql.Api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;

namespace Demo.EntityFramework.ComplexQuery.FromSql.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SaleController : ControllerBase
{
    private readonly DemoContext _context;

    public SaleController(DemoContext context)
    {
        _context = context;
    }

    [EnableQuery]
    [HttpGet("costumer")]
    public async Task<ActionResult<IQueryable<QuerySalesCostumer>>> GetCostumer()
        => await Task.FromResult(
            Ok(
                _context.QuerySalesCostumers.FromSqlRaw(
                    @"
SELECT 
	s.Id SaleId,
    s.Description SaleDescription,
    s.Value SaleValue,
	s.Date SaleDate,
    
    c.Id CustomerId,
    c.Name CustomerName,
    c.Address CustomerAddress
FROM demo_ef_compq.sales s
INNER JOIN demo_ef_compq.customer c
	ON s.CustomerId = c.Id
                    ")
            )
        );

    [EnableQuery]
    [HttpGet("costumer/{costumerName}")]
    public async Task<ActionResult<IQueryable<QuerySalesCostumer>>> GetCostumer(string costumerName)
        => await Task.FromResult(
            Ok(
                _context.QuerySalesCostumers.FromSqlRaw(
                    @"
SELECT 
	s.Id SaleId,
    s.Description SaleDescription,
    s.Value SaleValue,
	s.Date SaleDate,
    
    c.Id CustomerId,
    c.Name CustomerName,
    c.Address CustomerAddress
FROM demo_ef_compq.sales s
INNER JOIN demo_ef_compq.customer c
	ON s.CustomerId = c.Id
WHERE c.Name = {0}
                    ", costumerName)
            )
        );
}