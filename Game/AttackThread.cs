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
  internal class AttackThread
  {
    int cX, cY, pX, pY;
    double attacX = 0, attacY = 0;
    float AttacRange = 10;
    Series Series = new Series();
    Thread thread;

    public AttackThread(float Range, int currentX, int currentY, int previousX, int previousY)
    {
      AttacRange = Range;
      cX = currentX;
      cY = currentY;
      pX = previousX / 4 - 12;
      pY = Math.Abs(previousY - 850) / 4 - 12;
      thread = new Thread(this.func);
      thread.Start();
    }

    void func()
    {
      double diagonal = Math.Sqrt((cX - pX) * (cX - pX) + (cY - pY) * (cY - pY));
      double catetX = pX - cX;
      double catetY = pY - cY;
      double cosForX = catetX / diagonal;
      double cosForY = catetY / diagonal;
      double stepX = AttacRange * cosForX;
      double stepY = AttacRange * cosForY;
      attacX = cX + stepX;
      attacY = cY + stepY;
    }

    public Series getSeries()
    {
      thread.Join();
      Series.Points.AddXY(attacX, attacY);
      Series.ChartType = SeriesChartType.Bubble;
      Series.BorderWidth = 3;
      Series.Color = Color.Black;
      return Series;
    }
  }
}
