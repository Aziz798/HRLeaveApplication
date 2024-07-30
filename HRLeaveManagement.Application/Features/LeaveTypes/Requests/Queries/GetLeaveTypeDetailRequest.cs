using HRLeaveManagement.Application.DTOs.LeaveRequest;
using HRLeaveManagement.Application.DTOs.LeaveType;
using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveTypes.Requests.Queries;

public class GetLeaveTypeDetailRequest:IRequest<LeaveTypeDto>, IRequest<LeaveRequestDto>
{
    public int Id { get; set; }
}