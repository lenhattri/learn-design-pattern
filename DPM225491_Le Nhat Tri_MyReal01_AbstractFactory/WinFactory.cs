
/// <summary>
/// Concrete Factory: Windows Factory
/// Tạo ra sản phẩm Windows (Button + Checkbox).
/// </summary>
public class WinFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new WinButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new WinCheckbox();
    }
}
