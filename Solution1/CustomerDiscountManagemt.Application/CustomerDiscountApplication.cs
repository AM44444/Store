using System.Collections.Generic;
using _0_Framework.Application;
using _0_FrameWork.Application;
using DiscountManagement.Application.Contract.CustomerDiscount;
using DiscountManagement.Domain.CustomerDiscountAgg;

namespace DiscountManagement.Application
{
    public class CustomerDiscountApplication:ICustomerDiscountApplication
    {
        private readonly ICustomerDiscountRepository _customerDiscountRepository;

        public CustomerDiscountApplication(ICustomerDiscountRepository customerDiscountRepository)
        {
            _customerDiscountRepository = customerDiscountRepository;
        }

        public OperationResult Define(DefineCustomerDiscount command)
        {
            var startDate = command.StartDateTime.ToGeorgianDateTime();
            var endDate = command.EndDateTime.ToGeorgianDateTime();
            var operation = new OperationResult();
            if (_customerDiscountRepository.Exists(x
                =>x.ProductId == command.ProductId && x.DiscountRate == command.DiscountRate))
            {
                return operation.Failed(ApplicationMessage.DuplicatedRecord);
            }
            else
            {
                var customerDiscount = new CustomerDiscount(command.ProductId, command.DiscountRate
                    , startDate, endDate, command.DiscountReason);
                _customerDiscountRepository.Create(customerDiscount);
                _customerDiscountRepository.SaveChanges();
                return operation.Succeed();
            }
            
        }

        public OperationResult Edit(EditCustomerDiscount command)
        {
            var operation = new OperationResult();
            var customerDiscount = _customerDiscountRepository.Get(command.Id);
            if (customerDiscount == null)
            {
                return operation.Failed(ApplicationMessage.RecordNotFound);
            }
            else if (_customerDiscountRepository.Exists(x
                => x.ProductId == command.ProductId && x.DiscountRate == command.DiscountRate && x.Id != command.Id))

            {
                return operation.Failed(ApplicationMessage.DuplicatedRecord);

            }
            else
            {
                var startDate = command.StartDateTime.ToGeorgianDateTime();
                var endDate = command.EndDateTime.ToGeorgianDateTime();
                customerDiscount.Edit(command.ProductId,command.DiscountRate,startDate,endDate
                ,command.DiscountReason);
                _customerDiscountRepository.SaveChanges();
                return operation.Succeed();
            }

        }

        public EditCustomerDiscount GetDetails(long id)
        {
           return _customerDiscountRepository.GetDetails(id);
        }

        public List<CustomerDiscountViewModel> Search(CustomerDiscountSearchModel searchModel)
        {
            return _customerDiscountRepository.Search(searchModel);
        }

       
    }
}
