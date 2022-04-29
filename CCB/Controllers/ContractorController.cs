using CCB.Models;
using CCB.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CCB.Controllers
{
    public class ContractorController : Controller
    {
        private readonly ContractorsRepository _contractorRepository = null;

        public ContractorController(ContractorsRepository contractorsRepository)
        {
            _contractorRepository = contractorsRepository;
        }
        public IActionResult Index()
        {
            
            return View();
        }

        public async Task<ViewResult> GetAllContractors()
        {
            var data = await _contractorRepository.GetAllContractors();
            return View(data);
        }

        //adding new records for contractors
        [HttpPost]
        public async Task<IActionResult> Create(Contractor contractor)
        {
            int id = await _contractorRepository.AddNewContractor(contractor);

            if(id > 0 )
            {
                return RedirectToAction(nameof(Create), new { isSuccess = true, contractorId = id });
            }

            return View();
        }
    }
}
