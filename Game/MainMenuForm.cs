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
  public partial class MainMenuForm : Form
  {
    public MainMenuForm()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Hide();
      SelectClassForm mainForm = new SelectClassForm();
      mainForm.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Dispose();
    }
  }
}
