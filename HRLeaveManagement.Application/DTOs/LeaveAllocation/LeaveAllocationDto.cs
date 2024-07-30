using HRLeaveManagement.Application.DTOs.LeaveType;

namespace HRLeaveManagement.Application.DTOs.LeaveAllocation;

public class LeaveAllocationDto
{
    public LeaveTypeDto LeaveType { get; set; }
    
    public int LeaveTypeId { get; set; }
    public int Period { get; set; }
}