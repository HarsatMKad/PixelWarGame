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
    int AttacRange = 10;
    Series Series = new Series();
    Thread thread;

    public AttackThread(int Range, int currentX, int currentY, int previousX, int previousY, bool Distance)
    {
      AttacRange = Range;
      cX = currentX;
      cY = currentY;
      pX = previousX / 4 - 12;
      pY = Math.Abs(previousY - 850) / 4 - 12;
      if (!Distance)
      {
        thread = new Thread(this.Melee);
      }
      else
      {
        thread = new Thread(this.Range);
      }
      thread.Start();
    }

    void Melee()
    {
      Series.ChartType = SeriesChartType.Point;
      double diagonal = Math.Sqrt((cX - pX) * (cX - pX) + (cY - pY) * (cY - pY));
      double catetX = pX - cX;
      double catetY = pY - cY;
      double cosForX = catetX / diagonal;
      double cosForY = catetY / diagonal;
      double stepX = (AttacRange + 10) * cosForX;
      double stepY = (AttacRange + 10) * cosForY;
      attacX = cX + stepX;
      attacY = cY + stepY;
      Series.Points.AddXY(attacX, attacY);
      Console.WriteLine(Math.Sqrt(stepX* stepX + stepY * stepY));
      Series.Points[0].MarkerSize = Convert.ToInt32(AttacRange * 8) + 20;
    }

    void Range()
    {
      Series.ChartType = SeriesChartType.Line;
      Series.BorderWidth = AttacRange;
      for (int i = 0; i < 200; i += AttacRange)
      {
        if (cX < pX)
        {
          attacX = cX + i;
        }
        else
        {
          attacX = cX - i;
        }
        attacY = (pY - cY) * (attacX - cX) / (pX - cX) + cY;
        
        Series.Points.AddXY(attacX, attacY);
      }
    }

    public Series getSeries()
    {
      thread.Join();
      Series.Color = Color.Black;
      return Series;
    }
  }
}
