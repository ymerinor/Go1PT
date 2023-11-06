using System.Collections.Generic;

namespace Quote.Models.Provider
{
    public class ResponseBase
    {
        
        public string OperationId { get; set; }
        public List<Error> Errors { get; set; }
        public AuditData AuditData { get; set; }
    }

}
