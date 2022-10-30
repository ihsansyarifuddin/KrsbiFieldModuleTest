using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrsbiFieldModuleTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void fieldConfigurator1_Load(object sender, EventArgs e)
        {
            fieldConfigurator1.SaveResponse += FieldConfigurator1_SaveResponse;
        }

        private void FieldConfigurator1_SaveResponse(object sender, KrsbiFieldModule.EventObject.ConfigurationEventArgs e)
        {
            if (e.IsSuccess) Hide();
            else MessageBox.Show(e.Message);
        }
    }
}
