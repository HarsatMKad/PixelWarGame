﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Game
{
  public partial class MainForm : Form
  {
    int MaxXMap = 200, MaxYMap = 200;
    int MinXMap = 0, MinYMap = 0;
    int timer = 0;
    int Kills = 0;
    float attackTime = 0;
    List<Enemy> enemys = new List<Enemy>();
    Player player;
    public MainForm(bool СlassFlag)
    {
      InitializeComponent();
      this.DoubleBuffered = true;
      chart1.ChartAreas[0].AxisX.Maximum = MaxXMap;
      chart1.ChartAreas[0].AxisX.Minimum = MinXMap;
      chart1.ChartAreas[0].AxisX2.Minimum = MinXMap;
      chart1.ChartAreas[0].AxisY.Maximum = MaxYMap;
      chart1.ChartAreas[0].AxisY.Minimum = MinYMap;
      chart1.ChartAreas[0].AxisY2.Minimum = MinXMap;
      chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
      chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
      player = new Player(СlassFlag);
      label3.Text = player.dmg.ToString();
      label2.Text = player.CurrentHP + "/" + player.MaxHP;
      label19.Text = player.attackColdown.ToString();
      startPlay();
    }

    private void startPlay()
    {
      timer1.Start();
      timer1.Interval = 1000;
      timer2.Start();
      timer2.Interval = 100;
      Series PlayerSeries = new Series();
      PlayerSeries.ChartType = SeriesChartType.Point;
      PlayerSeries.Color = Color.Blue;
      PlayerSeries.Points.AddXY(player.x, player.y);
      PlayerSeries.Points[0].MarkerSize = 10;
      PlayerSeries.Points[0].MarkerStyle = MarkerStyle.Circle;

      Series PlayerAttackSeries = new Series();
      PlayerAttackSeries.ChartType = SeriesChartType.Bubble;
      PlayerAttackSeries.Color = Color.Black;
      chart1.Series.Add(PlayerSeries);
      chart1.Series.Add(PlayerAttackSeries);
    }

    private void UpdateHPBar(int stepBar)
    {
      player.CurrentHP += stepBar;
      label2.Text = player.CurrentHP + "/" + player.MaxHP;
      progressBar1.Value = 0;
      progressBar1.Maximum = player.MaxHP;
      progressBar1.Step = player.CurrentHP;
      progressBar1.PerformStep();

      if(player.CurrentHP < 40)
      {
        progressBar1.ForeColor = Color.DarkRed;
      }
      else
      {
        progressBar1.ForeColor = Color.LimeGreen;
      }

      if (player.CurrentHP <= 0)
      {
        timer1.Stop();
        timer2.Stop();
        MessageBox.Show("Вы проиграли", "Смерть");
        this.Dispose();
        return;
      }
    }

    private void UpdateExpBar()
    {
      int Exp = 10; //количество опыта за убийство пикселя
      player.Experience += Exp;
      progressBar2.Step = Exp;
      progressBar2.PerformStep();

      if(player.Experience >= 100)
      {
        ++player.LvL;
        player.Experience = 0;
        progressBar2.Value = 0;
        label8.Text = player.LvL.ToString();
        timer1.Stop();
        timer2.Stop();
        Thread.Sleep(100);
        int chp = player.CurrentHP;
        int cmhp = player.MaxHP;
        LvLForm lvlForm = new LvLForm(player);
        if(lvlForm.ShowDialog() == DialogResult.OK)
        {
          player = lvlForm.player;
          if (chp < player.CurrentHP || cmhp < player.MaxHP)
          {
            UpdateHPBar(0);
          }
          label3.Text = player.dmg.ToString();
          label19.Text = player.attackColdown.ToString();
          timer1.Start();
          timer2.Start();
        }
      }
    }

    private void createEnemy()
    {
      Enemy enemy = new Enemy(10 + 5 * timer/10, 10 + 5 * timer/10, MaxXMap, MaxYMap); //хп врагов, урон врагов
      enemy.UpdateSeries();
      enemys.Add(enemy);
      chart1.Series.Add(enemy.series);
    }

    private void TextBox_KeyDown(object sender, KeyEventArgs e)
    {
      if (chart1.Series.Count > 0)
      {
        player.Move(e.KeyCode, 1, MaxXMap, MaxYMap, MinXMap, MinYMap);
        chart1.Series[0].Points.Clear();
        chart1.Series[0].Points.AddXY(player.x, player.y);
        chart1.Series[0].Points[0].MarkerSize = 10;
        chart1.Series[0].Points[0].MarkerStyle = MarkerStyle.Circle;
        Update();
      }
      if(e.KeyCode == Keys.Escape)
      {
        timer1.Stop();
        timer2.Stop();
        if(MessageBox.Show("Выйти ?", "Меню",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
          this.Close();
        }
        else
        {
          timer1.Start();
          timer2.Start();
        }
      }
    }

    private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
    {

    }

    private void MainForm_KeyUp(object sender, KeyEventArgs e)
    {

    }

    private void MainForm_MouseClick(object sender, MouseEventArgs e)
    {

    }

    private void chart1_MouseClick(object sender, MouseEventArgs e)
    {
      try
      {
        if (attackTime <= 0)
        {
          attackTime = player.attackColdown;
          Series atts = player.Attack(e.Location.X, e.Location.Y);
          chart1.Series[1] = atts;
          Update();
          Thread.Sleep(10);

          for (int i = 0; i < enemys.Count; ++i)
          {
            for (int PointIndex = 0; PointIndex < chart1.Series[1].Points.Count; ++PointIndex)
            {
              if (enemys[i].x < chart1.Series[1].Points[PointIndex].XValue + player.AttackRange && enemys[i].x > chart1.Series[1].Points[PointIndex].XValue - player.AttackRange)
              {
                if (enemys[i].y < chart1.Series[1].Points[PointIndex].YValues[0] + player.AttackRange && enemys[i].y > chart1.Series[1].Points[PointIndex].YValues[0] - player.AttackRange)
                {
                  enemys[i].HP -= player.dmg;
                  if (enemys[i].HP <= 0)
                  {
                    enemys.Remove(enemys[i]);
                    ++Kills;
                    label7.Text = Kills.ToString();
                    UpdateExpBar();
                  }
                }
              }
            }
          }
          chart1.Series[1].Points.Clear();
        }
      }
      catch
      {
        chart1.Series[1].Points.Clear();
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      timer += 1;
      if(timer % 60 < 10)
      {
        label5.Text = Convert.ToString(timer / 60) + ":0" + Convert.ToString(timer % 60);
      }
      else
      {
        label5.Text = Convert.ToString(timer / 60) + ":" + Convert.ToString(timer % 60);
      }
      if (timer > 1 && enemys.Count < 20) //время перед появлением врагов и ограничение их количества
      {
        createEnemy();
      }
    }

    private void timer2_Tick(object sender, EventArgs e)
    {
      if(attackTime > 0)
      {
        attackTime -= 2;
      }
      Series playerSeries = chart1.Series[0];
      Series attackSeries = chart1.Series[1];
      chart1.Series.Clear();
      chart1.Series.Add(playerSeries);
      chart1.Series.Add(attackSeries);
      for (int i = 0; i < enemys.Count; ++i)
      {
        enemys[i].UpdatePlaerLocation(player.x, player.y);
        if (!enemys[i].UpdateSeries())
        {
          UpdateHPBar(-enemys[i].dmg);
          enemys.Remove(enemys[i]);       
        }
        else
        {
          chart1.Series.Add(enemys[i].series);
        }
      }
    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void chart1_Click(object sender, EventArgs e)
    {
      
    }
  }
}
