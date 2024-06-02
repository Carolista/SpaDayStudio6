using Microsoft.AspNetCore.Mvc;

namespace SpaDay6.Controllers
{
    public class SpaController : Controller
    {
        public bool CheckSkinType(string skinType, string facialType)
        {

            if (facialType != "Microdermabrasion")
            {
                if (skinType == "oily" && facialType != "Rejuvenating")
                {
                    return false;
                }
                else if (skinType == "combination" && (facialType != "Rejuvenating" || facialType != "Enzyme Peel"))
                {
                    return false;
                }
                else if (skinType == "dry" && facialType != "Hydrofacial")
                {
                    return false;
                }
            }

            return true;

        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/menu")] // Bonus mission 3 - change route from /spa
        public IActionResult Menu(string name, string skintype, string manipedi)
        {
            List<string> facials = new List<string>()
            {
                "Microdermabrasion", "Hydrofacial", "Rejuvenating", "Enzyme Peel"
            };

            List<string> appropriateFacials = new List<string>();
            for (int i = 0; i < facials.Count; i++)
            {
                if (CheckSkinType(skintype, facials[i]))
                {
                    appropriateFacials.Add(facials[i]);
                }
            }
            ViewBag.Name = name;
            ViewBag.SkinType = skintype;
            ViewBag.AppropriateFacials = appropriateFacials;
            ViewBag.ManiPedi = manipedi;

            // Bonus mission 1
            List<string> polishChoices = new();
            polishChoices.Add("#ed553e");
            polishChoices.Add("#ed3e4d");
            polishChoices.Add("#d12c71");
            polishChoices.Add("#a31787");
            polishChoices.Add("#34a39e");
            polishChoices.Add("#63c295");
            ViewBag.PolishChoices = polishChoices;
            return View();
        }

    }
}

