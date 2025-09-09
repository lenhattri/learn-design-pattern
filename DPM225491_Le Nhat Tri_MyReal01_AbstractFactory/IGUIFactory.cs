
/// <summary>
/// Abstract Factory
/// Định nghĩa interface để tạo ra họ sản phẩm liên quan.
/// </summary>
public interface IGUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}
