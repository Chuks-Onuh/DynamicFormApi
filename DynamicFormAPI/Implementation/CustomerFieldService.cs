using DynamicFormAPI.Dtos;
using DynamicFormAPI.Services;

namespace DynamicFormAPI.Implementation
{
    public class CustomerFieldService : ICustomerFieldService
    {
        private readonly Dictionary<string, CustomerFieldsResponse> _customerFields = new()
        {
            {
                "1234567890",
                new CustomerFieldsResponse
                {
                    AccountNumber = "1234567890",
                    Industry = "Manufacturing",
                    Fields = new List<Field>
                    {
                        new Field { Name = "Invoice Number" },
                        new Field { Name = "Quantity" },
                        new Field { Name = "Delivery Address" }
                    }
                }
            },
            {
                "2345678901",
                new CustomerFieldsResponse
                {
                    AccountNumber = "2345678901",
                    Industry = "Education",
                    Fields = new List<Field>
                    {
                        new Field { Name = "Matric Number" },
                        new Field { Name = "Level" },
                        new Field { Name = "Course" }
                    }
                }
            },
            {
                "3456789012",
                new CustomerFieldsResponse
                {
                    AccountNumber = "3456789012",
                    Industry = "Telecommunication",
                    Fields = new List<Field>
                    {
                        new Field { Name = "GSM Number" },
                        new Field { Name = "Network" },
                        new Field { Name = "Residential Address" }
                    }
                }
            }
        };

        public CustomerFieldsResponse GetFieldsByAccountNumber(string accountNumber)
        {
            return _customerFields.TryGetValue(accountNumber, out var fields) ? fields : null;
        }
    }
}
