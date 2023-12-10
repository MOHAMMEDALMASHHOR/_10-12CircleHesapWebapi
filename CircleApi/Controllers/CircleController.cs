using CircleApi.Models;
using Microsoft.AspNetCore.Mvc;
using ErorrExceptios;

namespace CircleApi.Controllers;
[ApiController]
[Route("api/circle")]
public class CircleController : ControllerBase
{
    [HttpPost("CalculateCircumference")]
    public IActionResult CaluclateCircumference(Input input)
    {
        var result = new CircleHesaplama.CircleHesap();
        var netice = new Output();
        netice.Result = result.ClaculateCircumference(input.r);
        if (netice.Result <= 0)
        {
            throw new Exceptions($"The Radius(The half of the dimeter) can't be less than 0 or zero");
        }
        return Ok(netice);

    }
    [HttpPost("CalcluateCircleArea")]
    public IActionResult CalculateCircleArea(Input input)
    {
        var result = new CircleHesaplama.CircleHesap();
        var netice = new Output();
        netice.Result = result.ClaculateCircleArea(input.r);
        if (netice.Result <= 0)
        {
            throw new Exceptions($"The Radius of the Circle or the half of its Dimeter can't be equal or less than zero!!!");
        }
        return Ok(netice);
    }
    [HttpPost]
    public IActionResult CalculateTheCircle(Input input)
    {
        var circle = new CircleHesaplama.CircleHesap();
        var result = new Output();
        var result1 = new Output();
        //  result.Result = circle.ClaculateCircumference(input.r);
        //result1.Result = circle.ClaculateCircleArea(input.r);
        return Ok(new
        {
            Circumference = circle.ClaculateCircumference(input.r),
            CircleArea = circle.ClaculateCircleArea(input.r)

        });
    }
}