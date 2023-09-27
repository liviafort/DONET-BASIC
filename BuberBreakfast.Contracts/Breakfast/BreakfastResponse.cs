namespace BuberBreakfast.Contracts.Breakfast{

    //record: trata os objetos desse tipo como um valor de dados imutável
    public record BreakfastResponse(
        Guid Id,
        string Name,
        string Description,
        DateTime StartDateTime,
        DateTime EndDateTime,
        DateTime LastModifiedDatetime,
        List<string> Savory,
        List<string> Sweet
    );
}