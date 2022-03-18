namespace ChirngauzerSquareGraph
{
    partial class MainForm
    {
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.WrongData = new System.Windows.Forms.ErrorProvider(this.components);
      this.ConstA = new System.Windows.Forms.TextBox();
      this.LeftBorder = new System.Windows.Forms.TextBox();
      this.RightBorder = new System.Windows.Forms.TextBox();
      this.Step = new System.Windows.Forms.TextBox();
      this.Calculate = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.PictureOfGraph = new System.Windows.Forms.PictureBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.getInitialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveInitialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveInExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.Table = new System.Windows.Forms.Button();
      this.pictureWithRabbit = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.WrongData)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.PictureOfGraph)).BeginInit();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureWithRabbit)).BeginInit();
      this.SuspendLayout();
      // 
      // WrongData
      // 
      this.WrongData.ContainerControl = this;
      // 
      // ConstA
      // 
      this.ConstA.Location = new System.Drawing.Point(545, 135);
      this.ConstA.Name = "ConstA";
      this.ConstA.Size = new System.Drawing.Size(85, 27);
      this.ConstA.TabIndex = 0;
      // 
      // LeftBorder
      // 
      this.LeftBorder.Location = new System.Drawing.Point(545, 178);
      this.LeftBorder.Name = "LeftBorder";
      this.LeftBorder.Size = new System.Drawing.Size(85, 27);
      this.LeftBorder.TabIndex = 1;
      // 
      // RightBorder
      // 
      this.RightBorder.Location = new System.Drawing.Point(545, 221);
      this.RightBorder.Name = "RightBorder";
      this.RightBorder.Size = new System.Drawing.Size(85, 27);
      this.RightBorder.TabIndex = 2;
      // 
      // Step
      // 
      this.Step.Location = new System.Drawing.Point(545, 263);
      this.Step.Name = "Step";
      this.Step.Size = new System.Drawing.Size(85, 27);
      this.Step.TabIndex = 3;
      // 
      // Calculate
      // 
      this.Calculate.Location = new System.Drawing.Point(604, 320);
      this.Calculate.Name = "Calculate";
      this.Calculate.Size = new System.Drawing.Size(119, 46);
      this.Calculate.TabIndex = 4;
      this.Calculate.Text = "Calculate";
      this.Calculate.UseVisualStyleBackColor = true;
      this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(638, 139);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(70, 20);
      this.label1.TabIndex = 5;
      this.label1.Text = "Сonst \"a\"";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(639, 183);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(144, 20);
      this.label2.TabIndex = 6;
      this.label2.Text = "Left border of graph";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(638, 224);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(154, 20);
      this.label3.TabIndex = 7;
      this.label3.Text = "Right border of graph";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(638, 266);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(100, 20);
      this.label4.TabIndex = 8;
      this.label4.Text = "Step of graph";
      // 
      // PictureOfGraph
      // 
      this.PictureOfGraph.Location = new System.Drawing.Point(569, 42);
      this.PictureOfGraph.Name = "PictureOfGraph";
      this.PictureOfGraph.Size = new System.Drawing.Size(204, 62);
      this.PictureOfGraph.TabIndex = 9;
      this.PictureOfGraph.TabStop = false;
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.informationToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 28);
      this.menuStrip1.TabIndex = 10;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getInitialToolStripMenuItem,
            this.saveInitialToolStripMenuItem,
            this.saveInExcelToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // getInitialToolStripMenuItem
      // 
      this.getInitialToolStripMenuItem.Name = "getInitialToolStripMenuItem";
      this.getInitialToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
      this.getInitialToolStripMenuItem.Text = "Get initial";
      this.getInitialToolStripMenuItem.Click += new System.EventHandler(this.getInitialToolStripMenuItem_Click);
      // 
      // saveInitialToolStripMenuItem
      // 
      this.saveInitialToolStripMenuItem.Name = "saveInitialToolStripMenuItem";
      this.saveInitialToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
      this.saveInitialToolStripMenuItem.Text = "Save initial";
      this.saveInitialToolStripMenuItem.Click += new System.EventHandler(this.saveInitialToolStripMenuItem_Click);
      // 
      // saveInExcelToolStripMenuItem
      // 
      this.saveInExcelToolStripMenuItem.Name = "saveInExcelToolStripMenuItem";
      this.saveInExcelToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
      this.saveInExcelToolStripMenuItem.Text = "Save in Excel";
      this.saveInExcelToolStripMenuItem.Click += new System.EventHandler(this.saveInExcelToolStripMenuItem_Click);
      // 
      // informationToolStripMenuItem
      // 
      this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
      this.informationToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
      this.informationToolStripMenuItem.Text = "Information";
      this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
      // 
      // Table
      // 
      this.Table.Location = new System.Drawing.Point(604, 387);
      this.Table.Name = "Table";
      this.Table.Size = new System.Drawing.Size(119, 41);
      this.Table.TabIndex = 11;
      this.Table.Text = "Table";
      this.Table.UseVisualStyleBackColor = true;
      this.Table.Click += new System.EventHandler(this.Table_Click);
      // 
      // pictureWithRabbit
      // 
      this.pictureWithRabbit.Image = ((System.Drawing.Image)(resources.GetObject("pictureWithRabbit.Image")));
      this.pictureWithRabbit.Location = new System.Drawing.Point(547, 343);
      this.pictureWithRabbit.Name = "pictureWithRabbit";
      this.pictureWithRabbit.Size = new System.Drawing.Size(51, 56);
      this.pictureWithRabbit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureWithRabbit.TabIndex = 12;
      this.pictureWithRabbit.TabStop = false;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 440);
      this.Controls.Add(this.pictureWithRabbit);
      this.Controls.Add(this.Table);
      this.Controls.Add(this.PictureOfGraph);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.Calculate);
      this.Controls.Add(this.Step);
      this.Controls.Add(this.RightBorder);
      this.Controls.Add(this.LeftBorder);
      this.Controls.Add(this.ConstA);
      this.Controls.Add(this.menuStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.MaximumSize = new System.Drawing.Size(818, 487);
      this.MinimumSize = new System.Drawing.Size(818, 487);
      this.Name = "MainForm";
      this.Text = "CharngauzerSquare";
      ((System.ComponentModel.ISupportInitialize)(this.WrongData)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.PictureOfGraph)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureWithRabbit)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private ErrorProvider WrongData;
    private TextBox ConstA;
    private TextBox RightBorder;
    private TextBox LeftBorder;
    private TextBox Step;
    private Button Calculate;
    private PictureBox PictureOfGraph;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem informationToolStripMenuItem;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem getInitialToolStripMenuItem;
    private ToolStripMenuItem saveInitialToolStripMenuItem;
    private ToolStripMenuItem saveInExcelToolStripMenuItem;
    private Button Table;
    private PictureBox pictureWithRabbit;
  }
}