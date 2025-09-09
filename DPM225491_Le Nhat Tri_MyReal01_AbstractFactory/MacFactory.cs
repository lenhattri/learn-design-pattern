
/// <summary>
/// Concrete Factory: MacOS Factory
/// Tạo ra sản phẩm MacOS (Button + Checkbox).
/// </summary>
public class MacFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacCheckbox();
    }
}
