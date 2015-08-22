using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WakeHelper
{
  public partial class Form1 : Form
  {
    public static List<string> listRestartProgram = new List<string>();
    public Form1()
    {
      InitializeComponent();

      loadSettings();

      //Start sleep/wake monitor
      monitorPowerState();

      if (isProgramRunning("wakehelper", 0) > 1)
      {
        try
        {
          Environment.Exit(0);
        }
        catch
        {
        }
      }

      this.WindowState = FormWindowState.Minimized;
      this.ShowInTaskbar = false;
    }
    private static void monitorPowerState()
    {
      SystemEvents.PowerModeChanged += OnPowerModeChanged;
    }

    private static void OnPowerModeChanged(object sender, PowerModeChangedEventArgs e)
    {
      if (e.Mode == PowerModes.Resume)
      {
        try
        {
          foreach (var item in listRestartProgram)
          {
            string exeName = item.Split('\\').Last().ToLower().Replace(".exe", string.Empty);

            Thread.Sleep(2500);

            //MessageBox.Show("Killing process: " + exeName);
            closeProcess(exeName);

            Thread.Sleep(2500);

            if (isProgramRunning(exeName, 0) <= 1)
            {
              // Restart process
              int restartDelay = int.Parse(Properties.Settings.Default.restartDelay);
              Thread.Sleep(restartDelay);
              startProcess(item, "");
            }
            else
            {
              closeProcess(exeName);

              if (isProgramRunning(exeName, 0) <= 1)
              {
                // Restart process
                int restartDelay = int.Parse(Properties.Settings.Default.restartDelay);
                Thread.Sleep(restartDelay);
                startProcess(item, "");
              }
            }
          }
        }
        catch (Exception)
        {
        }
      }
    }

    public static void closeProcess(string exeName)
    {
      var restartProcess = Process.GetProcesses().
        Where(
          pr =>
            pr.ProcessName.ToLower().Replace(".exe", string.Empty) == exeName);

      foreach (var process in restartProcess)
      {
        //MessageBox.Show("Killed process!");
        process.Kill();
      }
    }

    public static int isProgramRunning(string name, int runtime)
    {
      foreach (Process clsProcess in Process.GetProcesses())
      {
        if (clsProcess.ProcessName.ToLower().Equals(name))
        {
          runtime++;
        }
      }
      return runtime;
    }

    private static void startProcess(string program, string arguments)
    {
      try
      {
        //MessageBox.Show("Starting process: " + program);

        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.FileName = program;
        Process proc = Process.Start(startInfo);
      }
      catch (Exception eStartProcess)
      {
      }

      // Sleep timer to avoid Windows being to quick upon COM port unlocking
      Thread.Sleep(2500);
    }


    private
      void btnAddProgram_Click(object sender, EventArgs e)
    {
      ListViewItem lvItem = new ListViewItem();
      lvItem.SubItems.Add(tbExeName.Text.Trim());
      lvItem.Text = tbProgramName.Text.Trim();
      lvProgramRestart.Items.Add(lvItem);

      tbProgramName.Text = "";
      tbExeName.Text = "";
      tbProgramName.Focus();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }

    private void loadSettings()
    {
      try
      {
        string restartProcessList = Properties.Settings.Default.restartProcessList;
        string[] processes = restartProcessList.Split(';');
        listRestartProgram.Clear();

        foreach (var itemprocess in processes)
        {
          string[] processesSplit = itemprocess.Split(',');

          ListViewItem lvItem = new ListViewItem();
          lvItem.SubItems.Add(processesSplit[1]);
          lvItem.Text = processesSplit[0];
          lvProgramRestart.Items.Add(lvItem);
          listRestartProgram.Add(processesSplit[1]);
        }
      }
      catch (Exception)
      {
      }
    }
    private void saveSettings()
    {
      listRestartProgram.Clear();
      List<string> listItems = new List<string>();
      string formattedSettingsList = "";

      foreach (ListViewItem item in lvProgramRestart.Items)
      {
        string programName = item.Text;
        string exeName = item.SubItems[1].Text;

        listItems.Add(programName + "," + exeName);
        listRestartProgram.Add(exeName);

      }

      foreach (var item in listItems)
      {
        if (string.IsNullOrEmpty(formattedSettingsList))
        {
          formattedSettingsList = item;
        }
        else
        {
          formattedSettingsList = formattedSettingsList + ";" + item;
        }
      }

      //MessageBox.Show(formattedSettingsList);

      Properties.Settings.Default.restartProcessList = formattedSettingsList;
      Properties.Settings.Default.Save();
    }

    private void btnExitProgram_Click(object sender, EventArgs e)
    {
      saveSettings();

      if (trayIcon.Visible)
      {
        try
        {
          trayIcon.Visible = false;
          trayIcon.Dispose();
        }
        catch (Exception)
        {
        }
      }

      Environment.Exit(0);
    }

    private void trayIcon_Click(object sender, EventArgs e)
    {
      this.Show();
      this.WindowState = FormWindowState.Normal;
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      saveSettings();
      e.Cancel = true;
      this.WindowState = FormWindowState.Minimized;
    }

    private void btnRemoveItem_Click(object sender, EventArgs e)
    {
      try
      {
        List<ListViewItem> currentItems = new List<ListViewItem>();
        String selectedItem = lvProgramRestart.SelectedItems[0].Text;
        foreach (ListViewItem item in lvProgramRestart.Items)
        {
          if (item.Text != selectedItem)
          {
            currentItems.Add(item);
          }
        }

        lvProgramRestart.Items.Clear();

        foreach (ListViewItem item in currentItems)
        {
          lvProgramRestart.Items.Add(item);
        }
      }
      catch (Exception et)
      {
        MessageBox.Show("Error while removing item " + et.Message);
      }
    }

    private void tbRestartDelay_Validating(object sender, CancelEventArgs e)
    {
      Properties.Settings.Default.Save();
    }

    private void Form1_Resize(object sender, EventArgs e)
    {
      if (FormWindowState.Minimized == this.WindowState)
      {
        trayIcon.Visible = true;
        this.Hide();
      }

      else if (FormWindowState.Normal == this.WindowState)
      {
        trayIcon.Visible = false;
        this.Show();
      }
    }
  }
}
