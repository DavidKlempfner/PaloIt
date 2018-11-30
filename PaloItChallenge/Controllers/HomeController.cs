using PaloItChallenge.Helpers;
using PaloItChallenge.Models;
using PaloItChallenge.Services;
using System.Web.Mvc;

namespace PaloItChallenge.Controllers
{
    public class HomeController : Controller
    {
        private IBusinessService _businessService;
        public HomeController(IBusinessService businessService)
        {
            _businessService = businessService;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Post(FullName fullName)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            _businessService.SaveFullName(fullName);

            ViewBag.MaxNumOfConsecutiveZeros = _businessService.GetMaxNumOfConsecutiveZerosFromAsciiValueSum(fullName);
            return View("Index", fullName);
        }
    }
}