namespace BuberBreakfast.Contracts.Breakfast;

    //record: trata os objetos desse tipo como um valor de dados imutável
    public record UpsertBreakfastRequest(
        string Name,
        string Description,
        DateTime StartDateTime,
        DateTime EndDateTime,
        List<string> Savory,
        List<string> Sweet
    );
