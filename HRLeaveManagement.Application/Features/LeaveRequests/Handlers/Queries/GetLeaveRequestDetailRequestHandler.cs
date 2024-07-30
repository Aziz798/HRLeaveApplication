using AutoMapper;
using HRLeaveManagement.Application.DTOs.LeaveRequest;
using HRLeaveManagement.Application.Features.LeaveTypes.Requests.Queries;
using HRLeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveRequests.Handlers.Queries;

public class GetLeaveRequestDetailRequestHandler:IRequestHandler<GetLeaveTypeDetailRequest,LeaveRequestDto>
{
    private readonly ILeaveRequestRepository _leaveRequestRepository;
    public readonly IMapper _mapper;
    
    public GetLeaveRequestDetailRequestHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
    {
        _leaveRequestRepository = leaveRequestRepository;
        _mapper = mapper;
    }
    public async Task<LeaveRequestDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
    {
        var leaveRequest = await _leaveRequestRepository.GetAsync(request.Id);
        return _mapper.Map<LeaveRequestDto>(leaveRequest);
    }
}