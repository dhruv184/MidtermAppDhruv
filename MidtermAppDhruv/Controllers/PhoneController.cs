using Microsoft.AspNetCore.Mvc;
using MidtermAppDhruv.BusinessLogic;
using MidtermAppDhruv.Models;

namespace MidtermAppDhruv.Controllers;

public class PhoneController : Controller
{
    private readonly PhoneService _phoneService;

    public PhoneController(PhoneService phoneService)
    {
        _phoneService = phoneService;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(PhoneOrder order)
    {
        var receipt = _phoneService.CalcuateReceipt(order);
        return View("Receipt", receipt);
    }
}