using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Services.Model
{
    [DataContract]
    public class ResponseBase
    {
        [DataMember]
        public Guid RequestId { get; set; }
        [DataMember]
        public List<string> Errors { get; set; }
        [DataMember]
        public Status Status { get; set; }
    }
}
