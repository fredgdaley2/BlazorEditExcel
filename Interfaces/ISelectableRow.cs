
namespace BlazorEditExcel
{
    public interface ISelectableRow<T>
    {
        bool Selected { get; set; }
        string RowClass { get; }
        void RowClick();

    }
}
