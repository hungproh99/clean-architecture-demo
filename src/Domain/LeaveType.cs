using test.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace test.Domain
{
    public class LeaveType : BaseDomainEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
