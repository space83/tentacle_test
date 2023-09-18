namespace WebApplication2.Model.Transaction
{
    public class RequestMessage : Model.RequestMessage
    {

    }

    public class ResponseMessage : Model.ResponseMessage
    {
        public bool result { get; set; }

        public string resultmessage { get; set; }
    }
}
