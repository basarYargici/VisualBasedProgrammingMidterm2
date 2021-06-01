using System.Windows.Forms;

namespace Hw_13._8
{
    public partial class LoginApplication : Form
    {
        // there will be only one DataGridView. Making it static will improve performance.
        public static DataGridView dataGridViw;
        public LoginApplication()
        {
            InitializeComponent();
            dataGridViw = dataGridView;
        }
    }
}
