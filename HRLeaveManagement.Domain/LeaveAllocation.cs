﻿using System.ComponentModel.DataAnnotations.Schema;
using HRLeaveManagement.Domain.Common;

namespace HRLeaveManagement.Domain;

public class LeaveAllocation:BaseDomainEntity
{
    public int NumberOfDays { get; set; }
    public LeaveType LeaveType { get; set; }
    [ForeignKey(nameof(LeaveType))]
    public int LeaveTypeId { get; set; }
    public int Period { get; set; }
   // public string EmployeeId { get; set; }

}