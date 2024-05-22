using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class FormController : Controller
    {
        private readonly MnjwebFormContext _formContext;

        public FormController (MnjwebFormContext formContext)
        {
            _formContext = formContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var formModel = new FormModel();
            return View(formModel);
            //return View();
        }
        [HttpPost]
        public IActionResult Index(FormModel formModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        formModel.PhotoImage.CopyTo(memoryStream);

                        var employee = new Employee
                        {
                            FirstName = formModel.FirstName,
                            LastName = formModel.LastName,
                            FatherName = formModel.FatherName,
                            Nationality = formModel.Nationality,
                            Sex = formModel.Sex,
                            MaritalStatus = formModel.MaritalStatus,
                            SocialSecurityNumber = formModel.SocialSecurityNumber,
                            PanCardNumber = formModel.PanCardNumber,
                            DateOfBirth = formModel.DateOfBirth,
                            PlaceOfBirth = formModel.PlaceOfBirth,
                            HouseNo = formModel.HouseNO,
                            City = formModel.City,
                            State = formModel.State,
                            PinCode = formModel.PinCode,
                            PeriodOfStay = formModel.PeriodOfStay,
                            Telephone = formModel.Telephone,
                            MobilePhone = formModel.MobilePhone,
                            EmailId = formModel.EmailID,
                            InstantMessagingSystemId = formModel.InstantMessagingSystemID,
                            PhotoImage = memoryStream.ToArray()
                        };

                        _formContext.Employees.Add(employee);
                        _formContext.SaveChanges();
                        return RedirectToAction("Success");
                    }
                }
                catch (Exception)
                {

                }
            }

            return View(formModel);
        }
        public IActionResult Success()
        {
            return View();
        }
    }   
}
