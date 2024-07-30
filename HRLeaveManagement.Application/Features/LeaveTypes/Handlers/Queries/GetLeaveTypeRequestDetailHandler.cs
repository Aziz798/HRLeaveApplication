using AutoMapper;
using HRLeaveManagement.Application.DTOs.LeaveType;
using HRLeaveManagement.Application.Features.LeaveTypes.Requests.Queries;
using HRLeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveTypes.Handlers.Queries;

public class GetLeaveTypeRequestDetailHandler:IRequestHandler<GetLeaveTypeDetailRequest,LeaveTypeDto>
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly IMapper _mapper;
    public GetLeaveTypeRequestDetailHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
    {
        _leaveTypeRepository = leaveTypeRepository; 
        _mapper = mapper;
    }

    public async Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
    {
        var leaveType = await _leaveTypeRepository.GetAsync(request.Id);
        return _mapper.Map<LeaveTypeDto>(leaveType);  
    }
}