using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Testwork.Models;

namespace Testwork.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly Application_DbContext _DbContext;

        public EmployeeController(Application_DbContext context)
        {
            _DbContext = context;
        }

        // GET: Index - List all employees
        [HttpGet]
        public IActionResult Index()
        {
            var employees = _DbContext.Employees.ToList();
            return View(employees);
        }

        // GET: Create - Display the form to create a new employee
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Create - Save the new employee and calculate values
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                CalculateAndSetEmployeeValues(employee);

                _DbContext.Employees.Add(employee);
                _DbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Edit - Display the form to edit an existing employee
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var employee = _DbContext.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Edit - Update the existing employee details
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                CalculateAndSetEmployeeValues(employee);

                _DbContext.Entry(employee).State = EntityState.Modified;
                _DbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Delete - Display the confirmation view for deletion
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var employee = _DbContext.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Delete - Remove the employee from the database
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var employee = _DbContext.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            _DbContext.Employees.Remove(employee);
            _DbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        // Helper method to calculate earnings and deductions
        private void CalculateAndSetEmployeeValues(Employee employee)
        {
            float dearnessAllowance = employee.BasicSalary * 0.40f;
            float conveyanceAllowance = Math.Min(dearnessAllowance * 0.10f, 250);
            float houseRentAllowance = Math.Max(employee.BasicSalary * 0.25f, 1500);
            float grossSalary = employee.BasicSalary + dearnessAllowance + conveyanceAllowance + houseRentAllowance;

            float professionalTax;
            if (grossSalary <= 3000)
            {
                professionalTax = 100;
            }
            else if (grossSalary <= 6000)
            {
                professionalTax = 150;
            }
            else
            {
                professionalTax = 200;
            }

            float totalSalary = grossSalary - professionalTax;

            // You can store these values in ViewBag for display
            ViewBag.DearnessAllowance = dearnessAllowance;
            ViewBag.ConveyanceAllowance = conveyanceAllowance;
            ViewBag.HouseRentAllowance = houseRentAllowance;
            ViewBag.ProfessionalTax = professionalTax;
            ViewBag.TotalSalary = totalSalary;
        }
    }
}
