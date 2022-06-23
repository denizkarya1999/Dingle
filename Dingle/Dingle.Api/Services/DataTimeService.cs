
using Dingle.Domain.Interfaces;
using System;

namespace Dingle.Api.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
