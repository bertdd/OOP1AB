using System.Drawing;

namespace Game;

public class BreakoutGame
{
  public BreakoutGame(int width , int height)
  {
    SizeChanged(width, height);
  }

  public Ball Ball;

  public Paddle Paddle;

  /// <summary>
  /// The width of the screen.
  /// </summary>
  private int Width;

  /// <summary>
  /// The height in the screen.
  /// </summary>
  private int Height;

  public void SizeChanged(int width, int height)
  {
    Width = width;
    Height = height;
  }

  public void MovePaddleLeft() => Paddle.MoveLeft();
  public void MovePaddleRight() => Paddle.MoveRight(Width);
  public void MoveBall() => Ball.Move(Width, Height);
}
