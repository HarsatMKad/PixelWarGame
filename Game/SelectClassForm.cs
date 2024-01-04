using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
  public partial class SelectClassForm : Form
  {
    MainForm mainForm;
    public SelectClassForm()
    {
      InitializeComponent();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.Hide();
      mainForm = new MainForm(false);
      mainForm.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Hide();
      mainForm = new MainForm(true);
      mainForm.Show();
    }
  }
}
