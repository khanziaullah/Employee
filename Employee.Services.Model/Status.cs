using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Employee.Services.Model
{
    [DataContract]
    public enum Status
    {
        [EnumMember]
        Success,
        [EnumMember]
        Error,
    }
}
