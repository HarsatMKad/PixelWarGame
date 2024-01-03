using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace Game
{
  public class Player
  {
    public int MaxHP = 100;
    public int CurrentHP = 100;
    public int dmg = 5;
    public int LvL = 0;
    public int Experience = 0;
    public int x = 100, y = 100;
    public float AttackRange = 10;
    public Series AttackSeries;

    public Series Attack(int MouseX, int MouseY)
    {
      AttackThread mt = new AttackThread(AttackRange, x, y, MouseX, MouseY);
      AttackSeries = mt.getSeries();
      return AttackSeries;
    }

    public void Move(Keys key, int step, int MaxX, int MaxY, int MinX, int MinY)
    {
      if (key == Keys.W)
      {
        if (y + step <= MaxY)
        {
          y += step;
        }
        else
        {
          y = MaxY;
        }
      }
      else if (key == Keys.D)
      {
        if (x + step <= MaxX)
        {
          x += step;
        }
        else
        {
          x = MaxX;
        }
      }
      else if (key == Keys.S)
      {
        if (y - step >= MinY)
        {
          y -= step;
        }
        else
        {
          y = MinY;
        }
      }
      else if (key == Keys.A)
      {
        if (x - step >= MinX)
        {
          x -= step;
        }
        else
        {
          x = MinX;
        }
      }
    }
  }
}
