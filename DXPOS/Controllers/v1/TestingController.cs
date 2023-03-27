using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace DXPOS.Controllers.v1;

[ApiController]
[ApiVersion("1")]
[Route("v{version:apiVersion}/[controller]/[action]")]
[Tags("Testing endpoints space")]
public class TestingController : ControllerBase
{
    [HttpGet("search")]
    public IResult Search([FromQuery] SearchCriteria criteria)
    {
        return Results.Ok($"Author: {criteria.Author}, Year published: {criteria.YearPublished}");
    }
}

public class SearchCriteria
{
    public string? Author { get; set; }
    public int YearPublished { get; set; }

    protected static ValueTask<SearchCriteria?> BindAsync(HttpContext context, ParameterInfo parameter)
    {
        string author = context.Request.Query["Author"];
        int.TryParse(context.Request.Query["YearPublished"], out var year);
        var result = new SearchCriteria
        {
            Author = author,
            YearPublished = year
        };
        return ValueTask.FromResult<SearchCriteria?>(result);
    }
}