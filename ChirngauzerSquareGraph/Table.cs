using Services;

namespace ChirngauzerSquareGraph
{
  public partial class Table : Form
  {
    private DataGridView dataGridView = null;
    public Table(List<ModelCharngauzerSquare> data)
    {
      InitializeComponent();
      CreateGrid();
      FillDataGridWithData(data);
      CreateButtons();
    }
    private void CreateGrid()
    {
      this.Size = new Size(500, 350);
      this.MinimumSize = this.Size;
      this.MaximumSize = this.Size;
      dataGridView = new DataGridView();
      dataGridView.AllowUserToAddRows = false;
      dataGridView.AllowUserToDeleteRows = false;
      dataGridView.AllowUserToResizeRows = false;
      dataGridView.AllowUserToOrderColumns = false;
      dataGridView.AllowUserToResizeColumns = false;
      dataGridView.RowHeadersVisible = false;
      dataGridView.ReadOnly = true;
      dataGridView.Location = new Point(10, 10);
      dataGridView.Size = new Size(((this.Width * 2) / 3) - 39, this.Height - 80);
      var count = new DataGridViewTextBoxColumn();
      count.Name = "Count";
      count.HeaderText = "";
      count.Width = 60;
      dataGridView.Columns.Add(count);
      var columnX = new DataGridViewTextBoxColumn();
      columnX.Name = "X";
      columnX.HeaderText = "X";
      columnX.Width = 105;
      dataGridView.Columns.Add(columnX);
      var columnY = new DataGridViewTextBoxColumn();
      columnY.Name = "Y";
      columnY.Width = 105;
      columnY.HeaderText = "Y";
      dataGridView.Columns.Add(columnY);
      this.Controls.Add(dataGridView);
      dataGridView.MouseWheel += new MouseEventHandler(DataGridView_MouseWheel);
     
    }
    private void DataGridView_MouseWheel(object sender, MouseEventArgs e)
    {
      int currentIndex = this.dataGridView.FirstDisplayedScrollingRowIndex;
      int scrollLines = SystemInformation.MouseWheelScrollLines;

      if (e.Delta > 0)
      {
        this.dataGridView.FirstDisplayedScrollingRowIndex
            = Math.Max(0, currentIndex - scrollLines);
      }
      else if (e.Delta < 0)
      {
        this.dataGridView.FirstDisplayedScrollingRowIndex
            = currentIndex + scrollLines;
      }
    }
    private void FillDataGridWithData(List<ModelCharngauzerSquare> data)
    {
      PointF[] somePointsUp = new PointF[data.Count / 2];
      PointF[] somePointsDown = new PointF[data.Count / 2];
      int centerX = 0;
      int centerY = 0;
      int iterator = 0;
      for (int i = 0; i < data.Count; i += 2)
      {
        somePointsUp[iterator] = new PointF((float)(data[i].x + centerX), ((float)data[i].y + centerY));
        somePointsDown[iterator] = new PointF((float)(data[i + 1].x + centerX), (float)(data[i + 1].y + centerY));
        iterator++;
      }
      iterator = 0;
      for (int i = 0; i < somePointsUp.Length; i++)
      {
        dataGridView.Rows.Add(iterator.ToString(), Math.Round(somePointsUp[i].X, 4), Math.Round(somePointsUp[i].Y, 4));
        iterator++;
        dataGridView.Rows.Add(iterator.ToString(), Math.Round(somePointsDown[i].X, 4), Math.Round(somePointsDown[i].Y, 4));
        iterator++;
      }
    }
    private void CreateButtons()
    {
      Button save = new Button();
      save.Location = new Point((this.Width - dataGridView.Width) / 4 + dataGridView.Width, this.Height / 4);
      save.Size = new Size(60, 40);
      save.Text = "Save";
      save.Click += SaveClick;
      this.Controls.Add(save);
      Button close = new Button();
      close.Location = new Point(save.Location.X, save.Location.Y + save.Height + 20);
      close.Size = save.Size;
      close.Text = "Return";
      close.Click += CloseClick;
      this.Controls.Add(close);
    }
    private void CloseClick(object sender, EventArgs e)
    {
      this.Close();
    }
    private void SaveClick(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.InitialDirectory = @"d:\4 семестр\РПС";
      saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
      if (saveFileDialog.ShowDialog() == DialogResult.OK)
      {
        var filePath = saveFileDialog.FileName;
        StreamWriter file = new StreamWriter(filePath, false);
        for(int i = 0; i < dataGridView.Rows.Count; i++)
        {
          DataGridViewRow row = dataGridView.Rows[i];
          file.WriteLine(row.Cells[1].Value + " " + row.Cells[2].Value);
        }
        file.Close();
      }
    }
  }
}
