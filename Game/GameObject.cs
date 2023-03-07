using System.Drawing;

namespace Game; 

public abstract class GameObject
{
  public Point Location { get; set; }

  public int Width { get; internal set; }

  public int Height { get; internal set; }

  public event EventHandler<EventArgs>? Moved;

  protected void Move() => Moved?.Invoke(this, EventArgs.Empty);

  public int Step { get; set; } = 50;
}
