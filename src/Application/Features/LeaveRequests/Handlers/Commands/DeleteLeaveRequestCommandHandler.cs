using AutoMapper;
using test.Application.Exceptions;
using test.Application.Features.LeaveRequests.Requests.Commands;
using test.Application.Features.LeaveTypes.Requests.Commands;
using test.Application.Contracts.Persistence;
using test.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test.Application.Features.LeaveRequests.Handlers.Commands
{
    public class DeleteLeaveRequestCommandHandler : IRequestHandler<DeleteLeaveRequestCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteLeaveRequestCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _unitOfWork.LeaveRequestRepository.Get(request.Id);

            if (leaveRequest == null)
                throw new NotFoundException(nameof(LeaveRequest), request.Id);

            await _unitOfWork.LeaveRequestRepository.Delete(leaveRequest);
            await _unitOfWork.Save();
            return Unit.Value;
        }

        Task IRequestHandler<DeleteLeaveRequestCommand>.Handle(DeleteLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
