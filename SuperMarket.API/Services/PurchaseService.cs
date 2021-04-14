using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.API.Domain.Communication;
using SuperMarket.API.Domain.Repositories;
using SuperMarket.API.Models;

namespace SuperMarket.API.Services
{
    public class PurchaseService : IPurchaseService
    {
        private IPurchaseRepository _purchaseRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PurchaseService(IPurchaseRepository purchaseRepository, IUnitOfWork unitOfWork)
        {
            _purchaseRepository = purchaseRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Purchase>> ListAsync()
        {
            return await _purchaseRepository.ListAsync();
        }

        public async Task<PurchaseResponse> SaveAsync(Purchase purchase)
        {
            try
            {
                await _purchaseRepository.AddAsync(purchase);
                await _unitOfWork.CompleteAsync();
                return new PurchaseResponse(purchase);
            }
            catch (Exception ex)
            {
                return new PurchaseResponse($"An error ocurred when saving the purchase : {ex.Message}");
            }
        }
    }
}
