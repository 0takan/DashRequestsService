using System;

namespace DashRequestService.Clients.Models
{
    [Serializable]
    public class RestException : Exception
    {
        public RestException()
        {
        }

        public RestException(string customMessage) : base(customMessage)
        {
        }

        public RestException(string customMessage, Exception exception) : base(customMessage, exception)
        {
        }
    }
}
