using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.API.Domain.Communication;
using SuperMarket.API.Domain.Repositories;
using SuperMarket.API.Domain.Repository;
using SuperMarket.API.Models;

namespace SuperMarket.API.Domain.Services
{
    public class CompanyService : ICompanyService
    {

        private readonly ICompanyRepository _companyRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CompanyService(ICompanyRepository companyRepository, IUnitOfWork unitOfWork)
        {
            _companyRepository = companyRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Company>> ListAsync()
        {
            return await _companyRepository.ListAsync();
        }

        public async Task<Company> FindByIdAsync(int id)
        {
            return await _companyRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<Company>> FindByNameAsync(string name)
        {
            return await _companyRepository.FindByNameAsync(name);

        }
        public async Task<CompanyResponse> SaveAsync(Company company)
        {
            try
            {
                await _companyRepository.AddAsync(company);
                await _unitOfWork.CompleteAsync();
                return new CompanyResponse(company);
            }
            catch(Exception ex)
            {
                return new CompanyResponse($"An error ocurred when saving the company : {ex.Message}");
            }
        }

        public async Task<CompanyResponse> UpdateAsync(int id,Company company)
        {
            var existingCompany = await _companyRepository.FindByIdAsync(id);

            if (existingCompany == null)
                return new CompanyResponse("Company not found");
            existingCompany.FancyName = company.FancyName;

            try
            {
                _companyRepository.Update(existingCompany);
                await _unitOfWork.CompleteAsync();

                return new CompanyResponse(existingCompany);
            }
            catch (Exception ex)
            {
                return new CompanyResponse($"An error ocurred when updating the company: {ex.Message }");
            }

        }

        public async Task<CompanyResponse> DeleteAsync(int id)
        {
            var existingCompany = await _companyRepository.FindByIdAsync(id);

            if (existingCompany == null)
                return new CompanyResponse("Company not found");

            try
            {
                _companyRepository.Remove(existingCompany);
                await _unitOfWork.CompleteAsync();

                return new CompanyResponse(existingCompany);

            }
            catch(Exception ex)
            {
                return new CompanyResponse($"An error ocurred when deleting the company : {ex.Message}");
            }
        }
    }
}
