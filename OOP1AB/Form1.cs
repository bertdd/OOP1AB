namespace OOP1AB
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void klikMijNooitButton_Click(object sender, EventArgs e)
    {
      klikMijNooitButton.Text = "Je deed het toch";

      klikMijNooitButton.BackColor = Color.Green;

    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
      switch (keyData)
      {
        case Keys.Left:
          racketLabel.Location = 
            new Point(Math.Max(0,racketLabel.Location.X - 5), racketLabel.Location.Y);
          return true;

        default:
          return base.ProcessCmdKey(ref msg, keyData);
      }
    }
  }
}