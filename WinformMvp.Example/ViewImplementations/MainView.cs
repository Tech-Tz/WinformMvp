using MVP.Sample.ViewDefinitions;
using WinFormMvp;

namespace MVP.Sample.ViewImplementations
{
    public partial class MainView : BaseView, IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public Action OnOpenModalClicked { get; set; }

        private void BtnOpenModal_Click(object sender, EventArgs e)
        {
            OnOpenModalClicked?.Invoke();
        }
    }
}
