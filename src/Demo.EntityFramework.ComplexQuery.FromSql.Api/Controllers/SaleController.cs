using Demo.EntityFramework.ComplexQuery.FromSql.Api.EntityFramework;
using Demo.EntityFramework.ComplexQuery.FromSql.Api.Model;
using Microsoft.AspNetCore.Mvc;
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

    [HttpGet("costumer")]
    public async Task<ActionResult<IQueryable<QuerySalesCostumer>>> GetCostumer()
        => await Task.FromResult(
            Ok(
                _context.QuerySalesCostumers.FromSqlRaw(
                    @"""
                    SELECT * FROM 
                    """
                    )
            )
        );
}