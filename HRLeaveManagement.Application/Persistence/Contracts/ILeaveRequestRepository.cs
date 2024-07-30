﻿using HRLeaveManagement.Application.Persistence.Contracts.Common;
using HRLeaveManagement.Domain;

namespace HRLeaveManagement.Application.Persistence.Contracts;

public interface ILeaveRequestRepository:IGenericRepository<LeaveRequest>
{
    
}