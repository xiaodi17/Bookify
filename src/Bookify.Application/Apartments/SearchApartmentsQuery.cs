using Bookify.Application.Abstractions.Caching;
using Bookify.Application.Abstractions.Messages;

namespace Bookify.Application.Apartments;

public sealed record SearchApartmentsQuery(
    DateOnly StartDate,
    DateOnly EndDate) : ICachedQuery<IReadOnlyList<ApartmentResponse>>
{
    public string CacheKey => $"bookings-{StartDate.ToString()}-{EndDate.ToString()}";

    public TimeSpan? Expiration => null;

}