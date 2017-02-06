using Microsoft.AspNetCore.Mvc;

[Route("customer")]
public class CustomerCareController : Controller

{
    public IActionResult Index()

    {
        return Ok("This is the index for the CustomerCareController");
    }

    public IActionResult Claim()

    {
        return Ok("This is the quote for the CustomerCareController");
    }

    [Route("fileclaim")]
    public IActionResult NewClaim()

    {
        return Ok("File new claim");
    }

    [Route("claimstatus")]
    public IActionResult ClaimHistory()

    {
        return Ok("File claim status");
    }

}