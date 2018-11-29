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
        public ActionResult SaveFullName(FullName fullName)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            _businessService.SaveFullName(fullName);

            //TODO: Pull this out into its own method, probably best to do this in Javascript once the UI has populated the name labels.
            int sumOfAsciiValues = AsciiHelper.SumAsciiValuesInString($"{fullName.FirstName} {fullName.LastName}");
            string sumOfAsciiValuesAsBinaryString = AsciiHelper.ConvertNumToBinaryString(sumOfAsciiValues);
            ViewBag.MaxNumOfConsecutiveZeros = AsciiHelper.GetMaxNumOfConsecutiveZeros(sumOfAsciiValuesAsBinaryString);
            return View("Index", fullName);
        }
    }
}