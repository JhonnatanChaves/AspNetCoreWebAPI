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

        public async Task<PurchaseResponse> UpdateAsync(int id, Purchase purchase)
        {
            var existingPurchase = await _purchaseRepository.FindByIdAsync(id);

            if (existingPurchase == null)
                return new PurchaseResponse("Purchase not found");

            existingPurchase.Value = purchase.Value;
            existingPurchase.Observation = purchase.Observation;
            existingPurchase.ZipCode = purchase.ZipCode;
            existingPurchase.Address = purchase.Address;
            existingPurchase.ProductId = purchase.ProductId;
            existingPurchase.UserId = purchase.UserId;

            try
            {
                _purchaseRepository.Update(existingPurchase);
                await _unitOfWork.CompleteAsync();

                return new PurchaseResponse(existingPurchase);
            }
            catch (Exception ex)
            {
                return new PurchaseResponse($"An error ocurred when updating the purchase: {ex.Message }");
            }
        }
    }
}
