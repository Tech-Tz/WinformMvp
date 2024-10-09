namespace WinFormMvp;

public abstract class BaseView : Form, IView
{
    public void CloseView() => Close();

    public void OpenView() => new Thread((ThreadStart)delegate { Application.Run(this); }).Start();

    public void OpenViewModal() => ShowDialog();

    public void ShowMessage(string message) => MessageBox.Show(message);
}