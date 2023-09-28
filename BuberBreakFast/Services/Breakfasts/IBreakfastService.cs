using BuberBraskfast.Models;

namespace BuberBreakfast.Services.Breakfasts;

public interface IBreakfastService{
    void CreateBreakfast(Breakfast breakfast);
    void UpsertBreakfast(Breakfast breakfast);
    Breakfast GetBreakfast(Guid id);
    Breakfast DeleteBreakfast(Guid id);
}