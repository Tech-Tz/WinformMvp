using MVP.Sample.ViewDefinitions;
using WinFormMvp;

namespace MVP.Sample.ViewImplementations
{
    public partial class ModalView : BaseView, IModalView
    {
        public ModalView()
        {
            InitializeComponent();
        }
    }
}
