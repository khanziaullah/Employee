using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Services.Model
{
    [DataContract]
    public class RequestBase
    {
        [DataMember]
        public Guid RequestId { get; set; }
        [DataMember]
        public string SourceSystem { get; set; }
    }
}
