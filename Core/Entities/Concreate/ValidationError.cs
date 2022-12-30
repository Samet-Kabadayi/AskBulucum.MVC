namespace Core.Entities.Concreate
{
    public class ValidationError
    {
        public string PropertyName { get; set; } //CategoryName
        public string Message { get; set; } // CategoryName alanı 100 karakterden büyük olmamalıdır.
    }
}
