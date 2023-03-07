using Game;

namespace Breakout;

public partial class Form1 : Form
{
  public Form1()
  {
    InitializeComponent();
    game = new BreakoutGame(Width, Width)
    {
      Paddle = new Paddle(paddle.Width, paddle.Location),
      Ball = new Ball(ball.Width, ball.Height, ball.Location),
    };
    game.Paddle.Moved += (o, e) => paddle.Location = game.Paddle.Location;
    game.Ball.Moved += (o, e) => ball.Location = game.Ball.Location;
  }

  protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
  {
    switch (keyData)
    {
      case Keys.Left:
        game.MovePaddleLeft();
        return true;

      case Keys.Right:
        game.MovePaddleRight();
        return true;
    }
    return base.ProcessCmdKey(ref msg, keyData);
  }

  private void Form1_Resize(object sender, EventArgs e)
  {
    var oldLocation = paddle.Location;
    var max = Width - paddle.Width - 20;
    var newLocation = new Point(Math.Min(oldLocation.X, max), oldLocation.Y);
    if (game != null)
    {
      game.Paddle.Location = newLocation;
    }
  }

  private void Timer_Tick(object sender, EventArgs e)
  {
    game.MoveBall();
  }

  readonly BreakoutGame game;

  private void Form1_SizeChanged(object sender, EventArgs e)
  {
    game?.SizeChanged(Width, Height);
  }
}
