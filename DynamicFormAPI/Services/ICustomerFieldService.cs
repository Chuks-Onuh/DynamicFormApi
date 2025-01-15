using DynamicFormAPI.Dtos;

namespace DynamicFormAPI.Services
{
    public interface ICustomerFieldService
    {
        CustomerFieldsResponse GetFieldsByAccountNumber(string accountNumber);
    }
}
