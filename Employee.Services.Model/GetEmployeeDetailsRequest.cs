using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Services.Model
{
    [DataContract]
    public class GetEmployeeDetailsRequest : RequestBase
    {
        [DataMember]
        public int EmployeeId { get; set; }
    }
}
