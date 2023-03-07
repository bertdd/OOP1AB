using System.Drawing;

namespace Game;

public class Paddle : GameObject
{
  public Paddle(int width, Point location)
  {
    Width = width;
    Location = location;
  }

  public void MoveLeft()
  {
    var oldLocation = Location;
    if (oldLocation.X > 0) {
      var newLocation = new Point(Math.Max(oldLocation.X - Step, 0), oldLocation.Y);
      Location = newLocation;
      Move();
    }
  }

  public void MoveRight(int formWidth)
  {
    var oldLocation = Location;
    var max = formWidth - Width - 20;
    if (oldLocation.X < max) {
      var newLocation = new Point(Math.Min(oldLocation.X + Step, max), oldLocation.Y);
      Location = newLocation;
      Move();
    }
  }
}
