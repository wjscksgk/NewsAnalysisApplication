using System.Windows.Controls;
using NewsAnalysisApplication.viewmodels;

namespace NewsAnalysisApplication.views
{
    public partial class NewsView : UserControl
    {
        public NewsView()
        {
            InitializeComponent();
            DataContext = new NewsViewModel();
        }
    }
}