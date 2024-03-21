using demo.Application.Common.Interfaces;

namespace demo.Infrastructure.Services;
public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now.ToUniversalTime();
}
