namespace OOP1AB
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      klikMijNooitButton = new Button();
      pictureBox = new PictureBox();
      racketLabel = new Label();
      ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
      SuspendLayout();
      // 
      // klikMijNooitButton
      // 
      klikMijNooitButton.Anchor = AnchorStyles.None;
      klikMijNooitButton.Font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point);
      klikMijNooitButton.Location = new Point(616, 311);
      klikMijNooitButton.Margin = new Padding(4);
      klikMijNooitButton.Name = "klikMijNooitButton";
      klikMijNooitButton.Size = new Size(246, 73);
      klikMijNooitButton.TabIndex = 0;
      klikMijNooitButton.Text = "Klik hier nooit";
      klikMijNooitButton.UseVisualStyleBackColor = true;
      klikMijNooitButton.Click += klikMijNooitButton_Click;
      // 
      // pictureBox
      // 
      pictureBox.Location = new Point(705, 38);
      pictureBox.Margin = new Padding(4);
      pictureBox.Name = "pictureBox";
      pictureBox.Size = new Size(265, 197);
      pictureBox.TabIndex = 1;
      pictureBox.TabStop = false;
      // 
      // racketLabel
      // 
      racketLabel.BackColor = Color.FromArgb(192, 255, 192);
      racketLabel.Location = new Point(174, 461);
      racketLabel.Margin = new Padding(4, 0, 4, 0);
      racketLabel.Name = "racketLabel";
      racketLabel.Size = new Size(114, 49);
      racketLabel.TabIndex = 2;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(13F, 32F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.FromArgb(255, 192, 192);
      BackgroundImage = Properties.Resources.mario;
      BackgroundImageLayout = ImageLayout.Zoom;
      ClientSize = new Size(1040, 576);
      Controls.Add(racketLabel);
      Controls.Add(pictureBox);
      Controls.Add(klikMijNooitButton);
      Margin = new Padding(4);
      Name = "Form1";
      Text = "Mario on the run";
      ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private Button klikMijNooitButton;
    private PictureBox pictureBox;
    private Label racketLabel;
  }
}