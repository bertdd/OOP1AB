using System.Drawing;

namespace Game;

public class Ball : GameObject
{
  public Ball(int width, int height, Point location)
  {
    Width = width;
    Height = height;
    Location = location;
    Step = 10;
  }

  public void Move(int formWidth, int formHeight)
  {
    var oldLocation = Location;

    var maxX = formWidth - Width - 20;
    if (oldLocation.X >= maxX || oldLocation.X < 0) {
      XDirection = -XDirection;
    }
    var maxY = formHeight - Height;
    if (oldLocation.Y >= maxY || oldLocation.Y < 0) {
      YDirection = -YDirection;
    }

    Location = new Point(Math.Min(oldLocation.X + (XDirection * Step), maxX),
                                Math.Min(oldLocation.Y + (YDirection * Step), maxY));
    Move(); 
  }

  public int XDirection { get; internal set; } = 1;
  public int YDirection { get; internal set; } = 1;
}
