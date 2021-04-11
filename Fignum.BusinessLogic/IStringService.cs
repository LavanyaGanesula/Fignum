namespace Fignum.BusinessLogic
{
    public interface IStringService
    {
        StringResponse ProcessFilter(StringResponse stringResponse);
        StringResponse ProcessSort(StringResponse stringResponse);
    }
}
