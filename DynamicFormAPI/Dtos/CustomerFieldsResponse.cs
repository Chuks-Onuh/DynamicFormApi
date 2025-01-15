namespace DynamicFormAPI.Dtos
{
    public class CustomerFieldsResponse
    {
        public string AccountNumber { get; set; }
        public string Industry { get; set; }
        public List<Field> Fields { get; set; }
    }

    public class Field
    {
        public string Name { get; set; }
    }
}
