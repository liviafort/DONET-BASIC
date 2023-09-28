using BuberBraskfast.Models;
using BuberBreakfast.Services.Breakfasts;

namespace BuberBraskfast.Services;

public class BreakfastService: IBreakfastService{

    private static readonly Dictionary<Guid, Breakfast> _breakfasts = new();
    public void CreateBreakfast(Breakfast breakfast){
        _breakfasts.Add(breakfast.Id, breakfast);
    }

    public void UpsertBreakfast(Breakfast breakfast){
        _breakfasts.Add(breakfast.Id, breakfast);
    }

    public Breakfast GetBreakfast(Guid id){
        return _breakfasts[id];
    }

    public Breakfast DeleteBreakfast(Guid id){
        return _breakfasts[id];
    }

}