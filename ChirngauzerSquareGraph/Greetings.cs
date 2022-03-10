﻿
namespace ChirngauzerSquareGraph
{
  public partial class Greetings : Form
  {
    public Greetings()
    {
      InitializeComponent();
      this.StartPosition = FormStartPosition.CenterParent;
      this.Icon = new Icon(@"D:\4 семестр\РПС\ChirngauzerSquareGraph\SmartRabbit.ico");
      GreetingInner();
    }
    CheckBox dontShowAgain;
    private void GreetingInner()
    {
      this.Size = new Size(500, 350);
      this.MinimumSize = this.Size;
      this.MaximumSize = this.Size;
      this.TopMost = true;
      TextBox welcome = new TextBox();
      welcome.ReadOnly = true;
      welcome.Text = "Created by: Shishko Daniil Yrevich";
      welcome.Size = new Size(this.Width / 2, 20);
      welcome.Location = new Point(this.Width / 10, 5);
      welcome.BorderStyle = BorderStyle.None;
      this.Controls.Add(welcome);
      TextBox information = new TextBox();
      information.ReadOnly = true;
      information.Text = "Option: 9" + Environment.NewLine + "Aim: Create Win Forms application to " +
        "plotting a function graph and outputting a table of function values. User sets " +
        "rigth and left borders, step, coefficients (if presents). If unable to " +
        "plot a finction graph in seted gap user get warning " +
        "about this to change borders. If function graph in cause of" +
        "coefficients becomes a dot or can't be ploted user also sees warning.";
      information.Multiline = true;
      information.TextAlign = HorizontalAlignment.Left;
      information.Size = new Size(this.Width / 2 + 150, this.Height / 2);
      information.Location = new Point(welcome.Location.X - 5, welcome.Height + 10);
      information.BorderStyle = BorderStyle.None;
      this.Controls.Add(information);
      dontShowAgain = new CheckBox();
      dontShowAgain.Enabled = true;
      dontShowAgain.Size = new Size(20, welcome.Height);
      dontShowAgain.Location = new Point(welcome.Location.X, information.Height + 20 + welcome.Height);
      dontShowAgain.Appearance = Appearance.Normal;
      using (StreamReader file = new StreamReader("Agreement.txt"))
      {
        if (int.Parse(file.ReadLine()) == 1)
          dontShowAgain.Checked = true;
        else
          dontShowAgain.Checked = false;
      }
      this.Controls.Add(dontShowAgain);
      TextBox dontShowAgreement = new TextBox();
      dontShowAgreement.ReadOnly = true;
      dontShowAgreement.TextAlign = HorizontalAlignment.Left;
      dontShowAgreement.Text = "Check if you don't want see this again";
      dontShowAgreement.Size = new Size(welcome.Width + 20, 0);
      dontShowAgreement.Location = new Point(welcome.Location.X + 30, dontShowAgain.Location.Y + 3);
      dontShowAgreement.BorderStyle = BorderStyle.None;
      this.Controls.Add(dontShowAgreement);
      Button close = new Button();
      close.Text = "OK";
      close.Location = new Point(dontShowAgain.Location.X + dontShowAgreement.Size.Width + dontShowAgain.Size.Width + 20, dontShowAgain.Location.Y);
      close.Size = new Size(40, 30);
      this.Controls.Add(close);
      close.Click += Close_Click;
    }
    private void Close_Click(object sender, EventArgs e)
    {
      if (dontShowAgain.Checked)
      {
        using (StreamWriter file = new StreamWriter("Agreement.txt", false))
        {
          file.WriteLine(1);
        }
      }
      if (!dontShowAgain.Checked)
      {
        using (StreamWriter file = new StreamWriter("Agreement.txt", false))
        {
          file.WriteLine(0);
        }
      }
      this.Close();
    }
  }
}
