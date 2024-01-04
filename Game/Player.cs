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
    bool r = false;
    public int MaxHP;
    public int CurrentHP;
    public int dmg;
    public int LvL = 0;
    public int Experience = 0;
    public int x = 100, y = 100;
    public int AttackRange;
    public float attackColdown;
    public Series AttackSeries;

    public Player(bool Range)
    {
      if (Range)
      {
        r = Range;
        MaxHP = 70;
        CurrentHP = 70;
        dmg = 8;
        AttackRange = 5;
        attackColdown = 10;
      }
      else
      {
        MaxHP = 100;
        CurrentHP = 100;
        dmg = 12;
        AttackRange = 10;
        attackColdown = 20;
      }
    }

    public Series Attack(int MouseX, int MouseY)
    {
      AttackThread mt = new AttackThread(AttackRange, x, y, MouseX, MouseY, r);
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
