using Bookify.Application.Abstractions.Messages;

namespace Bookify.Application.Apartments;

public sealed record SearchApartmentsQuery(
    DateOnly StartDate,
    DateOnly EndDate) : IQuery<IReadOnlyList<ApartmentResponse>>;