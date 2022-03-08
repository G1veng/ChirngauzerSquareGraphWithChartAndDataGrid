using System.Windows.Forms.DataVisualization.Charting;
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using Services;

namespace ChirngauzerSquareGraph
{
  public partial class MainForm : Form
  {
    private readonly string error = "Wrong data";
    private readonly string errorOfConst = "Graph is dot";
    private readonly string borderError = "Wrong border edges";
    private readonly ICharngauzerSquare _concentrationService;
    Chart chart;
    public MainForm(ICharngauzerSquare concentrationService)
    {
      _concentrationService = concentrationService ?? throw new ArgumentNullException(nameof(concentrationService));
      InitializeComponent();
      ConstA.Text = "1";
      LeftBorder.Text = "-100";
      RightBorder.Text = "1";
      Step.Text = "1";
      Bitmap bmp = new Bitmap(@"D:\4 семестр\РПС\ChirngauzerSquareGraph\ChirngauzerSquareGraph\Equation.png");
      PictureOfGraph.Image = bmp;
      if (OpenGreetingsForm() == 0)
      {
        Greetings greeting = new Greetings();
        greeting.StartPosition = FormStartPosition.CenterParent;
        greeting.Show();
      }
    }
    private void CheckData()
    {
      WrongData.Clear();
      string constA = "", leftBorder = "", rightBorder = "", step = "";
      if (ConstA.Text == "" || !double.TryParse(ConstA.Text, out double uselessResult))
      {
        WrongData.SetError(ConstA, error);
      }
      if (ConstA.Text != "" && double.TryParse(ConstA.Text, out uselessResult))
      {
        if (double.Parse(ConstA.Text) == 0)
        {
          WrongData.SetError(ConstA, errorOfConst);
        }
        else
        {
          constA = ConstA.Text;
        }
      }
      if (LeftBorder.Text == "" || !double.TryParse(LeftBorder.Text, out uselessResult))
        WrongData.SetError(LeftBorder, error);
      else
      {
        leftBorder = LeftBorder.Text;
      }
      if (RightBorder.Text == "" || !double.TryParse(RightBorder.Text, out uselessResult))
        WrongData.SetError(RightBorder, error);
      else
      {
        rightBorder = RightBorder.Text;
      }
      if (Step.Text == "" | !double.TryParse(Step.Text, out uselessResult) | (int)uselessResult <= 0)
        WrongData.SetError(Step, error);
      else
      {
        step = Step.Text;
      }
      if (ConstA.Text != "" && ConstA.Text != "0" && WrongData.GetError(LeftBorder) == "" && WrongData.GetError(RightBorder) == "")
      {
        if (double.Parse(constA) > 0)
          if (double.Parse(rightBorder) > double.Parse(constA))
            WrongData.SetError(RightBorder, error);
        if (double.Parse(constA) < 0)
          if (double.Parse(leftBorder) < double.Parse(constA))
            WrongData.SetError(LeftBorder, error);
      }
      if (RightBorder.Text != "" && double.TryParse(RightBorder.Text, out uselessResult))
      {
        if (LeftBorder.Text != "" && double.TryParse(LeftBorder.Text, out uselessResult))
        {
          if (double.Parse(LeftBorder.Text) > double.Parse(RightBorder.Text))
          {
            WrongData.SetError(LeftBorder, borderError);
            WrongData.SetError(RightBorder, borderError);
          }
        }
      }
    }
    private List<ModelCharngauzerSquare> GetCalculations()
    {
      CheckData();
      if (WrongData.GetError(LeftBorder) == "" && WrongData.GetError(RightBorder) == ""
        && WrongData.GetError(ConstA) == "" && WrongData.GetError(Step) == "")
        return _concentrationService.GetPoints(double.Parse(ConstA.Text), double.Parse(LeftBorder.Text), double.Parse(RightBorder.Text), double.Parse(Step.Text));
      return null;
    }
    private void Calculate_Click(object sender, EventArgs e)
    {
      CheckData();
      if (WrongData.GetError(LeftBorder) == "" && WrongData.GetError(RightBorder) == ""
        && WrongData.GetError(ConstA) == "" && WrongData.GetError(Step) == "")
      {
        var points = GetCalculations();
        PointF[] somePointsUp = new PointF[points.Count / 2];
        PointF[] somePointsDown = new PointF[points.Count / 2];
        int centerX = 0;
        int centerY = 0;
        int iterator = 0;
        for (int i = 0; i < points.Count; i += 2)
        {
          somePointsUp[iterator] = new PointF((float)(points[i].x + centerX), ((float)points[i].y + centerY));
          somePointsDown[iterator] = new PointF((float)(points[i + 1].x + centerX), (float)(points[i + 1].y + centerY));
          iterator++;
        }
        if (chart != null)
          chart.Dispose();
        CreateChart();
        var seriesUp = new Series
        {
          Name = "ChirngauzSquareUp",
          Color = Color.Green,
          IsVisibleInLegend = false,
          IsXValueIndexed = true,
          ChartType = SeriesChartType.Line,
          LegendText = "True",
        };
        var seriesDown = new Series
        {
          Name = "ChirngauzSquareDown",
          Color = Color.Green,
          IsVisibleInLegend = false,
          IsXValueIndexed = true,
          ChartType = SeriesChartType.Line
        };
        chart.Series.Add(seriesUp);
        chart.Series.Add(seriesDown);
        chart.Series.Add(new Series { ChartType = SeriesChartType.Line });
        for (int i = 0; i < somePointsDown.Length; i++)
        {
          seriesUp.Points.AddXY(somePointsUp[i].X, somePointsUp[i].Y);
          seriesDown.Points.AddXY(somePointsDown[i].X, somePointsDown[i].Y);
        }
        chart.Invalidate();
      }
    }
    private void CreateChart()
    {
      ChartArea chartArea1 = new ChartArea();
      Legend legend1 = new Legend();
      chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
      chartArea1.Name = "ChartArea";
      chart.ChartAreas.Add(chartArea1);
      legend1.Name = "Graph";
      chart.Legends.Add(legend1);
      chart.Location = new Point(10, 40);
      chart.Name = "chart";
      chart.Size = new Size(((this.Width * 2) / 3) - 20, this.Height - 100);
      chart.TabIndex = 0;
      chart.Text = "chart";
      chart.Series.Clear();
      this.Controls.Add(chart);
    }
    private void informationToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Greetings greeting = new Greetings();
      greeting.StartPosition = FormStartPosition.CenterParent;
      greeting.Show();
    }
    private int OpenGreetingsForm()
    {
      FileStream createFile = null;
      StreamReader file = null;
      try
      {
        file = new StreamReader("Agreement.txt");
      }
      catch
      {
        createFile = File.Create("Agreement.txt");
        createFile.Close();
        file = new StreamReader("Agreement.txt");
      }
      int Agreement = 0;
      if (file != null)
      {
        string yesOrNo = file.ReadLine();
        if (yesOrNo != null)
          Agreement = int.Parse(yesOrNo);
        else
          Agreement = 0;
      }
      file.Close();
      return Agreement;
    }
    private void getInitialToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (OpenFileDialog openFileDialog = new OpenFileDialog())
      {
        openFileDialog.InitialDirectory = "d:\\4 семестр\\РПС";
        openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        openFileDialog.FilterIndex = 2;
        openFileDialog.RestoreDirectory = true;
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
          var filePath = openFileDialog.FileName;
          var fileStream = openFileDialog.OpenFile();
          using (StreamReader reader = new StreamReader(fileStream))
          {
            ConstA.Text = reader.ReadLine();
            LeftBorder.Text = reader.ReadLine();
            RightBorder.Text = reader.ReadLine();
            Step.Text = reader.ReadLine();
          }
        }
      }
    }
    private void saveInitialToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CheckData();
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.InitialDirectory = "d:\\4 семестр\\РПС";
      saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
      if (WrongData.GetError(LeftBorder) == "" && WrongData.GetError(RightBorder) == ""
        && WrongData.GetError(ConstA) == "" && WrongData.GetError(Step) == "")
      {
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
          var filePath = saveFileDialog.FileName;
          using (StreamWriter file = new StreamWriter(filePath, false))
          {
            if (int.Parse(ConstA.Text) == 0)
            {
              WrongData.SetError(ConstA, errorOfConst);
            }
            else
            {
              file.WriteLine(double.Parse(ConstA.Text));
              file.WriteLine(double.Parse(LeftBorder.Text));
              file.WriteLine(double.Parse(RightBorder.Text));
              file.WriteLine(double.Parse(Step.Text));
            }
          }
        }
      }
    }
    private void saveInExcelToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CheckData();
      if (WrongData.GetError(LeftBorder) == "" && WrongData.GetError(RightBorder) == ""
        && WrongData.GetError(ConstA) == "" && WrongData.GetError(Step) == "")
      {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.InitialDirectory = "d:\\4 семестр\\РПС";
        saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.xlsx)|*.xlsx";
        saveFileDialog.FilterIndex = 2;
        saveFileDialog.RestoreDirectory = true;
        var filePath = "";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
          filePath = saveFileDialog.FileName;
        }
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        var package = new ExcelPackage();
        var sheet = package.Workbook.Worksheets.Add("GraphPoint");
        var graph = package.Workbook.Worksheets.Add("Chart");
        sheet.Cells[1, 1].Value = "a - "; sheet.Cells[1, 2].Value = double.Parse(ConstA.Text);
        sheet.Cells[2, 1].Value = "Left border - "; sheet.Cells[2, 2].Value = double.Parse(LeftBorder.Text);
        sheet.Column(1).Width = 14;
        sheet.Column(2).Width = 14;
        sheet.Cells[3, 1].Value = "Right border - "; sheet.Cells[3, 2].Value = double.Parse(RightBorder.Text);
        sheet.Cells[4, 1].Value = "Step - "; sheet.Cells[4, 2].Value = double.Parse(Step.Text);
        sheet.Cells[5, 1, 5, 2].LoadFromArrays(new object[][] { new[] { "X", "Y" } });
        sheet.Cells[5, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
        sheet.Cells[5, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
        var points = GetCalculations();
        int iterator = 0;
        for (int i = 0; i < points.Count; i+=2)
        {
          sheet.Cells[iterator + 6, 1].Value = points[i].x;
          sheet.Cells[iterator + 6, 2].Value = points[i].y;
          iterator++;
        }
        iterator = 0;
        for(int i = 1; i < points.Count; i += 2)
        {
          sheet.Cells[iterator + 6, 3].Value = points[i].y;
          iterator++;
        }
        var chart = (ExcelLineChart)graph.Drawings.AddChart("Square", eChartType.Line);
        chart.Legend.Position = eLegendPosition.Right;
        chart.Legend.Add();
        chart.SetPosition(1, 0, 1, 0);
        chart.SetSize(1000, 600);
        int count = points.Count / 2;
        ExcelRangeBase excelFirstRangeBase = sheet.Cells["B6:B" + count.ToString()];
        ExcelRangeBase excelSecondRangeBase = sheet.Cells["C6:C" + count.ToString()];
        chart.Series.Add(excelFirstRangeBase);
        chart.Series.Add(excelSecondRangeBase);
        File.WriteAllBytes(filePath, package.GetAsByteArray());
      }
    }
    private void Table_Click(object sender, EventArgs e)
    {
      Table table = new Table(GetCalculations());
      table.Show();
    }
  }
}