namespace Breakout;

public partial class Form1 : Form
{
  public Form1()
  {
    InitializeComponent();
  }

  protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
  {
    switch (keyData)
    {
      case Keys.Left:
        MovePaddleLeft();
        return true;

      case Keys.Right:
        MovePaddleRight();
        return true;
    }
    return base.ProcessCmdKey(ref msg, keyData);
  }

  private int step = 50;

  private void MovePaddleLeft()
  {
    var oldLocation = paddle.Location;
    if (oldLocation.X > 0)
    {
      var newLocation = new Point(Math.Max(oldLocation.X - step, 0), oldLocation.Y);
      paddle.Location = newLocation;
    }
  }

  private void MovePaddleRight()
  {
    var oldLocation = paddle.Location;
    var max = Width - paddle.Width - 20;
    if (oldLocation.X < max)
    {
      var newLocation = new Point(Math.Min(oldLocation.X + step, max), oldLocation.Y);
      paddle.Location = newLocation;
    }
  }

  private void Form1_Resize(object sender, EventArgs e)
  {
    var oldLocation = paddle.Location;
    var max = Width - paddle.Width - 20;
    var newLocation = new Point(Math.Min(oldLocation.X, max), oldLocation.Y);
    paddle.Location = newLocation;
  }

  private void timer_Tick(object sender, EventArgs e)
  {
    MoveBall();
  }

  private void MoveBall()
  {
    var oldLocation = ball.Location;

    var max = Width - ball.Width - 20;
    if (oldLocation.X < max)
    {
      DoMove(oldLocation, max);
    }
    else
    {
      XDirection = -XDirection;
      DoMove(oldLocation, max);
    }
  }

  private void DoMove(Point oldLocation, int max)
  {
    var newLocation = new Point(Math.Min(oldLocation.X + (XDirection * 10), max),
                                          oldLocation.Y + (YDirection * 10));
    ball.Location = newLocation;
  }

  int XDirection = 1;

  int YDirection = 1;
}