using test.Application.DTOs.LeaveRequest;
using test.Application.DTOs.LeaveType;
using test.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace test.Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand : IRequest<BaseCommandResponse>
    {
        public CreateLeaveRequestDto LeaveRequestDto { get; set; }

    }
}
