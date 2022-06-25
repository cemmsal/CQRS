namespace CQRSExample.CQRS.Manuel.Commands.Request
{
    public class CreateBookCommandRequest
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
    }
}
