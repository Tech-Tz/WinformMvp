namespace WinFormMvp;

public interface IView
{
    void OpenView();

    void OpenViewModal();

    void CloseView();

    void ShowMessage(string message);
}
