using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;
using System.Text.RegularExpressions;
using GIVE_AID.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Win32;

namespace GIVE_AID.Controllers
{
    public class HomeController : Controller
	{
		public readonly ngoDbContext db;

		public HomeController(ngoDbContext db)
		{
			this.db = db;
		}

		public IActionResult Index()
		{
			return View(db.OurPrograms.ToList());
		}
		public IActionResult Contact()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Contact(contact op)
		{
			if (HttpContext.Session.GetString("s") != null)
			{
				// Set user ID in the donation object
				op.UserId = Convert.ToInt32(HttpContext.Session.GetString("s"));

				db.Contact.Add(op);
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			else
			{
				// If user ID is not set in session, redirect to another action or page
				return RedirectToAction("login");
			}
	
	}
	
        public IActionResult About()
        {
            var cwu = db.About_Career_with_us.ToList();
            var om = db.ABout_Our_Mission.ToList();
            var os = db.About_Our_Supporters.ToList();
            var team = db.About_team.ToList();
            var wwd = db.About_what_we_do.ToList();
            about1 ab = new about1()
            {
                aboutcwu = cwu,
                aboutom = om,
                aboutos = os,
                aboutteam = team,
                aboutwwd = wwd,
            };

            return View(ab);
        }
        public IActionResult Donate()
        {
            //var dep = db.AddDonation.ToList();
            var ep = db.AddDonation.ToList();
            //ViewBag.dep = new SelectList(dep, "donationId", "amount");
            ViewBag.ep = new SelectList(ep, "donationId", "cause");
            return View();
        }

        [HttpPost]
        public IActionResult Donate(donation add)
        {
            // Check if user ID is set in session
            if (HttpContext.Session.GetString("s") != null)
            {
                // Set user ID in the donation object
                add.UserId = Convert.ToInt32(HttpContext.Session.GetString("s"));

                if (ValidateCard(add.CardNumber, add.ExpiryDate, add.CVV))
                {
                    db.Donation.Add(add);
                    db.SaveChanges();
                    return RedirectToAction("donationthanks");
                }
                else
                {
                    ViewData["ErrorMessage"] = "Invalid card details.";
                    return View();
                }
            }
            else
            {
                // If user ID is not set in session, redirect to another action or page
                return RedirectToAction("login");
            }
        }
        private bool ValidateCard(string cardNumber, string expiryDate, string cvv)
        {

            if (cardNumber.Length == 19 && cvv.Length == 3 && Regex.IsMatch(expiryDate, @"(0[1-9]|1[0-2])\/([0-9]{2})"))
            {
                return cardNumber.Length == 19 && cvv.Length == 3 && Regex.IsMatch(expiryDate, @"(0[1-9]|1[0-2])\/([0-9]{2})");
            }
            else
            {
                return false;
            }
        }
        public IActionResult donationthanks()
        {
            return View();
        }
        public IActionResult Our_Programes()
		{
			return View(db.OurPrograms.ToList());
		}
		public IActionResult Help_Center()
		{
			return View(db.HelpCentre.ToList());

		}
		public IActionResult Partners()
		{
			return View(db.About_team.ToList());
		}


        public IActionResult Gallery()
		{
			return View(db.Gallery.ToList());
		}
		public IActionResult Teams()
		{
			return View(db.About_team.ToList());
		}

		public IActionResult Careers()
		{
			return View();
		}
        // POST: Handle the form submission for career applications
        [HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Careers(about_cwu model, IFormFile cv)
		{
			if (ModelState.IsValid)
			{
				if (cv != null && cv.Length > 0)
				{
					// Ensure only specific file types are allowed (e.g., pdf, doc, docx)
					var allowedExtensions = new[] { ".pdf", ".doc", ".docx" };
					var ext = Path.GetExtension(cv.FileName).ToLower();

					if (!allowedExtensions.Contains(ext))
					{
						ViewBag.Error = "Please upload a valid CV file (PDF, DOC, DOCX only).";
						return View(model);
					}

					// Create a unique file name for the uploaded CV
					var uniqueFileName = Guid.NewGuid().ToString() + Path.GetFileName(cv.FileName);

					// Set the folder path where the CV will be saved
					var uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/cvuploads");

					// Create the folder if it doesn't exist
					if (!Directory.Exists(uploadFolder))
					{
						Directory.CreateDirectory(uploadFolder);
					}

					// Save the CV to the folder
					var filePath = Path.Combine(uploadFolder, uniqueFileName);
					using (var stream = new FileStream(filePath, FileMode.Create))
					{
						cv.CopyTo(stream);
					}

					// Set the CV path in the model (this will save the file path in the database)
					model.cv = Path.Combine("cvuploads", uniqueFileName);
				}

				// Add the model to the 'About_Career_with_us' table (about_cwu model)
				db.About_Career_with_us.Add(model);
				db.SaveChanges();

				// Redirect back to the Careers page or a success page
				return RedirectToAction("Careers");
			}

			// If the model state is invalid, return the view with validation errors
			return View(model);
		}

		public IActionResult register()
		{
			return View();
		}
		[HttpPost]
		public IActionResult register(UserReg add)
		{
			db.User_Reg.Add(add);
			db.SaveChanges();
			return RedirectToAction("Login");
		}

		public IActionResult Login()
		{
			if (HttpContext.Session.GetString("s") != null)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
		[HttpPost]
		public IActionResult Login(UserReg log)
		{
			var login = db.User_Reg.Where(db => db.UserEmail == log.UserEmail && db.UserPass == log.UserPass).FirstOrDefault();
			if (login != null)
			{
		//		HttpContext.Session.SetString("s", login.UserId.Convert.ToInt32);
		HttpContext.Session.SetString("s", login.UserId.ToString());

				return RedirectToAction("Index");
			}
			else
			{
				ViewBag.m = "Login Failed";
			}
			return View();
		}
		public IActionResult logout()
		{

			if (HttpContext.Session.GetString("s") != null)
			{
				HttpContext.Session.Remove("s");
				return RedirectToAction("Login");
			}
			return View();
		}
	
	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}