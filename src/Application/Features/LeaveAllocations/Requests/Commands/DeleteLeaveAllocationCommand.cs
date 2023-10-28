using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace test.Application.Features.LeaveAllocations.Requests.Commands
{
    public class DeleteLeaveAllocationCommand : IRequest
    {
        public int Id { get; set; }
    }
}
