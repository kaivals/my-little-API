﻿using mylittle_project.Application.DTOs;
using mylittle_project.Application.Interfaces;
using mylittle_project.Domain.Entities;
using mylittle_project.infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylittle_project.infrastructure.Services
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly DealerDbContext _context;

        public SubscriptionService(DealerDbContext context)
        {
            _context = context;
        }

        public async Task<int> AssignSubscriptionAsync(SubscriptionDealerDto dto)
        {
            var assignment = new SubscriptionDealer
            {
                TenantId = dto.TenantId,
                PortalName = dto.PortalName,
                SubscriptionPlan = dto.SubscriptionPlan,
                Price = dto.Price,
                DurationInMonths = dto.DurationInMonths,
                AutoRenew = dto.AutoRenew,
                QueueIfUnavailable = dto.QueueIfUnavailable,
                PlanStartDate = dto.PlanStartDate,
                Categories = dto.Categories.Select(c => new AssignedCategory
                {
                    Name = c.Name,
                    IsAvailable = c.IsAvailable
                }).ToList()
            };

            _context.Subscriptions.Add(assignment);
            await _context.SaveChangesAsync();
            return assignment.Id;
        }
    }
}
