using InventoryManagement.Application.Contract.Inventory;
using System;
using System.Collections.Generic;
using _0_FrameWork.Application;
using InventoryManagement.Domain.InventoryAgg;

namespace InventoryManagement.Application
{
    public class InventoryApplication:IInventoryApplication
    {
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryApplication(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public OperationResult Create(CreateInventory command)
        {
            var operation = new OperationResult();
            
            var inventory = new Inventory(command.ProductId, command.UnitPrice);
            _inventoryRepository.Create(inventory);
            _inventoryRepository.SaveChanges();
            return operation.Succeed();
        }

        public OperationResult Edit(EditInventory command)
        {
            var operation = new OperationResult();
            var inventory = _inventoryRepository.Get(command.Id);
            if (inventory == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);
            if (_inventoryRepository.Exists(x => 
                x.ProductId == command.ProductId&& x.Id != command.Id))
                return operation.Failed(ApplicationMessage.DuplicatedRecord);
            inventory.Edit(command.ProductId,command.UnitPrice);
            _inventoryRepository.SaveChanges();
            return operation.Succeed();
        }

        public OperationResult Increase(IncreaseInventory command)
        {
            var operation = new OperationResult();
            var inventory = _inventoryRepository.Get(command.InventoryId);
            if (inventory == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);
            const long operatorId = 1;
            inventory.Increase(command.Count,operatorId,command.Description);
            _inventoryRepository.SaveChanges();
           return operation.Succeed();
        }

        public OperationResult Decrease(List<DecreaseInventory> command)
        {
            var operation = new OperationResult();
            const long operatorId = 1;
            foreach (var item in command)
            {
                var inventory = _inventoryRepository.GetBy(item.ProductId);
                inventory.Decrease(item.Count,operatorId,item.Description,item.OrderId);
            }
            _inventoryRepository.SaveChanges();
            return operation.Succeed();
        }

        public OperationResult Decrease(DecreaseInventory command)
        {
            var operation = new OperationResult();
            var inventory = _inventoryRepository.Get(command.InventoryId);
            if (inventory == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);
            const long operatorId = 1;
            inventory.Decrease(command.Count, operatorId, command.Description,0);
            _inventoryRepository.SaveChanges();
            return operation.Succeed();
        }

        public EditInventory GetDetails(long id)
        {
          return  _inventoryRepository.GetDetails(id);
        }

        public List<InventoryViewModel> Search(InventorySearchModel searchModel)
        {
          return  _inventoryRepository.Search(searchModel);
        }

        public List<InventoryOperationViewModel> GetOperationLog(long inventorId)
        {
            return _inventoryRepository.GetOperationLog(inventorId);
        }
    }
}
