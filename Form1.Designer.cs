namespace WakeHelper
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.tbProgramName = new System.Windows.Forms.TextBox();
      this.btnAddProgram = new System.Windows.Forms.Button();
      this.lvProgramRestart = new System.Windows.Forms.ListView();
      this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chEXEname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.tbExeName = new System.Windows.Forms.TextBox();
      this.lblProgramName = new System.Windows.Forms.Label();
      this.lblExeName = new System.Windows.Forms.Label();
      this.gbProgramsAfterWake = new System.Windows.Forms.GroupBox();
      this.lblRestartDelay = new System.Windows.Forms.Label();
      this.btnRemoveItem = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnExitProgram = new System.Windows.Forms.Button();
      this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
      this.tbRestartDelay = new System.Windows.Forms.TextBox();
      this.gbProgramsAfterWake.SuspendLayout();
      this.SuspendLayout();
      // 
      // tbProgramName
      // 
      this.tbProgramName.Location = new System.Drawing.Point(105, 36);
      this.tbProgramName.Name = "tbProgramName";
      this.tbProgramName.Size = new System.Drawing.Size(231, 20);
      this.tbProgramName.TabIndex = 0;
      // 
      // btnAddProgram
      // 
      this.btnAddProgram.Location = new System.Drawing.Point(393, 39);
      this.btnAddProgram.Name = "btnAddProgram";
      this.btnAddProgram.Size = new System.Drawing.Size(75, 43);
      this.btnAddProgram.TabIndex = 1;
      this.btnAddProgram.Text = "Add";
      this.btnAddProgram.UseVisualStyleBackColor = true;
      this.btnAddProgram.Click += new System.EventHandler(this.btnAddProgram_Click);
      // 
      // lvProgramRestart
      // 
      this.lvProgramRestart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chEXEname});
      this.lvProgramRestart.Location = new System.Drawing.Point(0, 88);
      this.lvProgramRestart.Name = "lvProgramRestart";
      this.lvProgramRestart.Size = new System.Drawing.Size(468, 226);
      this.lvProgramRestart.TabIndex = 2;
      this.lvProgramRestart.UseCompatibleStateImageBehavior = false;
      this.lvProgramRestart.View = System.Windows.Forms.View.Details;
      // 
      // chName
      // 
      this.chName.Text = "Name";
      this.chName.Width = 247;
      // 
      // chEXEname
      // 
      this.chEXEname.Text = "Exe name";
      this.chEXEname.Width = 151;
      // 
      // tbExeName
      // 
      this.tbExeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.tbExeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
      this.tbExeName.Location = new System.Drawing.Point(105, 62);
      this.tbExeName.Name = "tbExeName";
      this.tbExeName.Size = new System.Drawing.Size(282, 20);
      this.tbExeName.TabIndex = 3;
      // 
      // lblProgramName
      // 
      this.lblProgramName.AutoSize = true;
      this.lblProgramName.Location = new System.Drawing.Point(5, 39);
      this.lblProgramName.Name = "lblProgramName";
      this.lblProgramName.Size = new System.Drawing.Size(75, 13);
      this.lblProgramName.TabIndex = 4;
      this.lblProgramName.Text = "Program name";
      // 
      // lblExeName
      // 
      this.lblExeName.AutoSize = true;
      this.lblExeName.Location = new System.Drawing.Point(5, 65);
      this.lblExeName.Name = "lblExeName";
      this.lblExeName.Size = new System.Drawing.Size(65, 13);
      this.lblExeName.TabIndex = 5;
      this.lblExeName.Text = "Exe full path";
      // 
      // gbProgramsAfterWake
      // 
      this.gbProgramsAfterWake.Controls.Add(this.lblRestartDelay);
      this.gbProgramsAfterWake.Controls.Add(this.tbRestartDelay);
      this.gbProgramsAfterWake.Controls.Add(this.btnRemoveItem);
      this.gbProgramsAfterWake.Controls.Add(this.lvProgramRestart);
      this.gbProgramsAfterWake.Controls.Add(this.lblExeName);
      this.gbProgramsAfterWake.Controls.Add(this.tbProgramName);
      this.gbProgramsAfterWake.Controls.Add(this.lblProgramName);
      this.gbProgramsAfterWake.Controls.Add(this.btnAddProgram);
      this.gbProgramsAfterWake.Controls.Add(this.tbExeName);
      this.gbProgramsAfterWake.Location = new System.Drawing.Point(12, 12);
      this.gbProgramsAfterWake.Name = "gbProgramsAfterWake";
      this.gbProgramsAfterWake.Size = new System.Drawing.Size(474, 349);
      this.gbProgramsAfterWake.TabIndex = 6;
      this.gbProgramsAfterWake.TabStop = false;
      this.gbProgramsAfterWake.Text = "Programs to restart after wake";
      // 
      // lblRestartDelay
      // 
      this.lblRestartDelay.AutoSize = true;
      this.lblRestartDelay.Location = new System.Drawing.Point(1, 326);
      this.lblRestartDelay.Name = "lblRestartDelay";
      this.lblRestartDelay.Size = new System.Drawing.Size(91, 13);
      this.lblRestartDelay.TabIndex = 8;
      this.lblRestartDelay.Text = "Restart delay (ms)";
      // 
      // btnRemoveItem
      // 
      this.btnRemoveItem.Location = new System.Drawing.Point(176, 323);
      this.btnRemoveItem.Name = "btnRemoveItem";
      this.btnRemoveItem.Size = new System.Drawing.Size(141, 23);
      this.btnRemoveItem.TabIndex = 6;
      this.btnRemoveItem.Text = "Remove from list";
      this.btnRemoveItem.UseVisualStyleBackColor = true;
      this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(12, 378);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(139, 34);
      this.btnSave.TabIndex = 7;
      this.btnSave.Text = "Save and Close to tray";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnExitProgram
      // 
      this.btnExitProgram.Location = new System.Drawing.Point(350, 378);
      this.btnExitProgram.Name = "btnExitProgram";
      this.btnExitProgram.Size = new System.Drawing.Size(136, 34);
      this.btnExitProgram.TabIndex = 7;
      this.btnExitProgram.Text = "Exit program";
      this.btnExitProgram.UseVisualStyleBackColor = true;
      this.btnExitProgram.Click += new System.EventHandler(this.btnExitProgram_Click);
      // 
      // trayIcon
      // 
      this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
      this.trayIcon.Text = "Wake Helper";
      this.trayIcon.Click += new System.EventHandler(this.trayIcon_Click);
      // 
      // tbRestartDelay
      // 
      this.tbRestartDelay.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WakeHelper.Properties.Settings.Default, "restartDelay", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbRestartDelay.Location = new System.Drawing.Point(98, 323);
      this.tbRestartDelay.Name = "tbRestartDelay";
      this.tbRestartDelay.Size = new System.Drawing.Size(63, 20);
      this.tbRestartDelay.TabIndex = 7;
      this.tbRestartDelay.Text = global::WakeHelper.Properties.Settings.Default.restartDelay;
      this.tbRestartDelay.Validating += new System.ComponentModel.CancelEventHandler(this.tbRestartDelay_Validating);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(511, 428);
      this.Controls.Add(this.btnExitProgram);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.gbProgramsAfterWake);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "Wake Helper";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Resize += new System.EventHandler(this.Form1_Resize);
      this.gbProgramsAfterWake.ResumeLayout(false);
      this.gbProgramsAfterWake.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox tbProgramName;
    private System.Windows.Forms.Button btnAddProgram;
    private System.Windows.Forms.ListView lvProgramRestart;
    private System.Windows.Forms.ColumnHeader chName;
    private System.Windows.Forms.ColumnHeader chEXEname;
    private System.Windows.Forms.TextBox tbExeName;
    private System.Windows.Forms.Label lblProgramName;
    private System.Windows.Forms.Label lblExeName;
    private System.Windows.Forms.GroupBox gbProgramsAfterWake;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnExitProgram;
    private System.Windows.Forms.NotifyIcon trayIcon;
    private System.Windows.Forms.Button btnRemoveItem;
    private System.Windows.Forms.Label lblRestartDelay;
    private System.Windows.Forms.TextBox tbRestartDelay;
  }
}

