using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Game
{
  internal class Enemy
  {
    public int HP, dmg;
    public double x, y;
    int PlayerX, PlayerY;
    public Series series;
    System.Threading.Timer timer;
    public Enemy(int hp, int dmg, int MaxXMap, int MaxYMap)
    {
      HP = hp;
      this.dmg = dmg;
      Random r = new Random();
      x = r.Next(0, MaxXMap);
      y = MaxYMap - r.Next(0, Convert.ToInt32(MaxYMap * 0.1));
      timer = new Timer(Move, null, 0, 100);
    }

    void Move(object obj)
    {
      float Step = 1;
      double diagonal = Math.Sqrt((x - PlayerX) * (x - PlayerX) + (y - PlayerY) * (y - PlayerY));
      double catetX = PlayerX - x;
      double catetY = PlayerY - y;
      double cosForX = catetX / diagonal;
      double cosForY = catetY / diagonal;
      double stepX = Step * cosForX;
      double stepY = Step * cosForY;
      x += stepX;
      y += stepY;
    }

    public void UpdatePlaerLocation(int PlayerX, int PlayerY)
    {
      this.PlayerX = PlayerX;
      this.PlayerY = PlayerY;
    }

    public bool UpdateSeries()
    {
      series = new Series();
      series.ChartType = SeriesChartType.Point;
      series.Color = Color.Red;
      series.Points.AddXY(x, y);
      timer = new Timer(Move, null, 500, 1000);

      if(x < PlayerX + 2 && x > PlayerX - 2)
      {
        if(y < PlayerY + 2 && y > PlayerY - 2)
        {
          return false;
        }
      }
      return true;
    }
  }
}
