using System.Collections.Generic;

namespace DashRequestService.Clients.Models
{
    public class SignRawTransactionWithErrorResponse : SignRawTransactionResponse
    {
        public List<SignRawTransactionError> Errors { get; set; }
    }
}
