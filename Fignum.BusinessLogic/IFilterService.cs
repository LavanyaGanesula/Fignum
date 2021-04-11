namespace Fignum.BusinessLogic
{
    public interface IFilterService
    {
        FilterResponse ProcessFilter(FilterResponse stringResponse);
        FilterResponse ProcessSort(FilterResponse stringResponse);
    }
}
