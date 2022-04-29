using CCB.Data;
using CCB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCB.Repository
{
    public class ContractorsRepository
    {
        private readonly ApplicationDbContext _context = null;

        public ContractorsRepository(ApplicationDbContext context)
        {
            _context = context;      
        }

        public async Task<List<Contractor>> GetAllContractors()
        {
            var contractors = new List<Contractor>();
            var allContractors = await _context.Contractors.ToListAsync();
            if(allContractors?.Any() == true)
            {
                foreach (var contractor in allContractors)
                {
                    contractors.Add(new Contractor()
                    { 
                    
                        Company = contractor.Company,
                        FirstName = contractor.FirstName,
                        Title = contractor.Title,
                        Manager = contractor.Manager
                    
                    });
                }

               
            }

            return contractors;
        }



        public async Task<int> AddNewContractor(Contractor model)
        {        

            var newContractor = new Contractors()
            {
                Company = model.Company,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Title = model.Title,
                Manager = model.Manager,
                CreatedOn = DateTime.UtcNow,
                UpdatedOn = DateTime.UtcNow


            };

           await _context.Contractors.AddAsync(newContractor);
           await _context.SaveChangesAsync();

            return newContractor.Id;
        }

    }
}
