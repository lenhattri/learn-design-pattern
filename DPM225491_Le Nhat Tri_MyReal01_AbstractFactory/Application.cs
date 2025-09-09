﻿
/// <summary>
/// Client
/// Chỉ làm việc thông qua Abstract Factory và Abstract Product.
/// </summary>
public class Application
{
    private readonly IButton _button;
    private readonly ICheckbox _checkbox;

    public Application(IGUIFactory factory)
    {
        _button = factory.CreateButton();
        _checkbox = factory.CreateCheckbox();
    }

    public void RenderUI()
    {
        _button.Render();
        _checkbox.Render();
    }
}
