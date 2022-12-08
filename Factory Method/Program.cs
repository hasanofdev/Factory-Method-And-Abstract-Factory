public interface IButton
{
    void Render();
    void OnClick();
}

public class WindowsButton : IButton
{
    public void OnClick() => Console.WriteLine("Windows Button Clicked");
    public void Render() => Console.WriteLine("Windows Button Rendered");
}

public class HtmlButton : IButton
{
    public void OnClick() => Console.WriteLine("HTML Button Clicked");
    public void Render() => Console.WriteLine("HTML Button Rendered");
}


public abstract class Dialog
{
    public void Render()
    {
        IButton okButton = CreateButton();
        okButton.OnClick();
        okButton.Render();

    }

    public abstract IButton CreateButton();
}

public class WindowsDialog : Dialog
{
    public override IButton CreateButton() => new WindowsButton();
}

public class HtmlDialog : Dialog
{
    public override IButton CreateButton() => new HtmlButton();
}

public class Program
{
    public static void Main()
    {
        Dialog dialog = new WindowsDialog();
        dialog.Render();

        dialog = new HtmlDialog();
        dialog.Render();
    }
}