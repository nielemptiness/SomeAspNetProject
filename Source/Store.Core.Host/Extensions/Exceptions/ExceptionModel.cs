namespace Store.Core.Host.Extensions.Exceptions
{
    public class ExceptionModel
    {
        public string CorrelationId { get; set; }
        public object Error { get; set; }
    }
}