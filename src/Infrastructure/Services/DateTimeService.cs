using demo2.Application.Common.Interfaces;

namespace demo2.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now.ToUniversalTime();
}
