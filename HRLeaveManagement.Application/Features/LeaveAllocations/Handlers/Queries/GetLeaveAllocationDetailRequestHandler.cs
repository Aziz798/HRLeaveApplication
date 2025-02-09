﻿using AutoMapper;
using HRLeaveManagement.Application.DTOs.LeaveAllocation;
using HRLeaveManagement.Application.Features.LeaveAllocations.Requests.Queries;
using HRLeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveAllocations.Handlers.Queries;

public class GetLeaveAllocationDetailRequestHandler:IRequestHandler<GetLeaveAllocationDetailRequest,LeaveAllocationDto>
{
    private readonly ILeaveAllocationRepository _leaveAllocationRepository;
    private readonly IMapper _mapper;
    public GetLeaveAllocationDetailRequestHandler(ILeaveAllocationRepository leaveTypeRepository,IMapper mapper)
    {
        _leaveAllocationRepository = leaveTypeRepository; 
        _mapper = mapper;
    }
    public async Task<LeaveAllocationDto> Handle(GetLeaveAllocationDetailRequest request, CancellationToken cancellationToken)
    {
        var leaveAllocation = await _leaveAllocationRepository.GetAsync(request.Id);
        return _mapper.Map<LeaveAllocationDto>(leaveAllocation); 
    }
}