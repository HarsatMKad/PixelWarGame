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
  public partial class LvLForm : Form
  {
    public Player player;
    public bool flag = false;
    public LvLForm(Player player)
    {
      InitializeComponent();
      this.player = player;
      if(player.attackColdown <= 2)
      {
        button3.Enabled = false;
      }
      if (player.AttackRange >= 30)
      {
        button4.Enabled = false;
      }
    }

    private void LvLForm_Load(object sender, EventArgs e)
    {

    }

    private void CloseMethod()
    {
      this.DialogResult = DialogResult.OK;
      this.Dispose();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      player.dmg += 5;
      CloseMethod();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if(player.CurrentHP > player.MaxHP - 10)
      {
        player.CurrentHP = player.MaxHP;
      }
      else
      {
        player.CurrentHP += 10;
      }
      CloseMethod();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      player.attackColdown -= 0.5F;
      CloseMethod();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      player.AttackRange += 2;
      CloseMethod();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      player.MaxHP += 20;
      CloseMethod();
    }
  }
}
