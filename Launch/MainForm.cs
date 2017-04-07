﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Launch
{
    public partial class MainForm : Form
    {
        const string ApplicationTitle = "Launch";
        string _storagePath = "Launch.xml";
        bool _reorder = false;
        bool _minified = false;

        BindingList<Command> _dataSource = new BindingList<Command>();


        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            _storagePath = Path.Combine(dir, _storagePath);

            Text = $"{ApplicationTitle} V{Assembly.GetExecutingAssembly().GetName().Version.ToString()}";

            LoadCommands();

            if (_dataSource.Count == 0)
            {
                _dataSource.Add(new Command { Title = "Command Window", Application = "cmd" });
                _dataSource.Add(new Command { Title = "File Explorer", Application = "explorer" });
                var browser = GetBrowser();
                if (browser != null)
                    _dataSource.Add(new Command { Title = "Browser", Application = browser.ToString() });
                else
                    _dataSource.Add(new Command { Title = "Browser", Application = "http://www.google.com" });
            }

            commandListBox.DataSource = _dataSource;

            Fit();
        }

        private void commandListBox_DoubleClick(object sender, EventArgs e)
        {
            Launch();
        }

        private void commandListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Launch();
            }
        }

        private void commandListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (!_reorder) return;
            if (commandListBox.SelectedItem == null) return;
            commandListBox.DoDragDrop(commandListBox.SelectedItem, DragDropEffects.Move);
        }

        private void commandListBox_DragOver(object sender, DragEventArgs e)
        {
            if (!_reorder) return;
            e.Effect = DragDropEffects.Move;
        }

        private void commandListBox_DragDrop(object sender, DragEventArgs e)
        {
            if (!_reorder) return;
            Point point = commandListBox.PointToClient(new Point(e.X, e.Y));
            int index = commandListBox.IndexFromPoint(point);
            if (index < 0) index = commandListBox.Items.Count - 1;
            var data = commandListBox.SelectedItem as Command;
            _dataSource.Remove(data);
            _dataSource.Insert(index, data);
            SaveCommands();
        }

        private void commandListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var command = commandListBox.SelectedItem as Command;

            if (command != null)
            {
                ShowStatus($"{command.Application} {command.Arguments}");
            }
        }

        private void addLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddOrEdit();
        }

        private void editLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (commandListBox.SelectedValue != null)
            {
                AddOrEdit(commandListBox.SelectedValue as Command);
            }
        }

        private void reorderLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _reorder = !_reorder;
            if (_reorder)
                ShowStatus("Reorder commands by drag && drop. Press Reorder again when finished.");
            else
                ShowStatus("");
        }

        private void deleteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var item = commandListBox.SelectedItem as Command;
            if (item != null)
            {
                if (MessageBox.Show("Delete the selected item?", "Confirm", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    _dataSource.Remove(item);
                    SaveCommands();
                    Fit();
                }
            }
        }



        private void AddOrEdit(Command command = null)
        {
            var dialog = new CommandForm(command);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.Command.Id == Guid.Empty)
                {
                    dialog.Command.Id = Guid.NewGuid();
                    _dataSource.Add(dialog.Command);
                }
                SaveCommands();

                Fit();
            }
        }

        private void SaveCommands()
        {
            Type[] types = { typeof(Command) };
            var serializer = new XmlSerializer(typeof(CommandList), types);
            using (var stream = new FileStream(_storagePath, FileMode.Create))
            {
                var commandList = new CommandList();
                commandList.AddRange(_dataSource.Select(o => o));
                serializer.Serialize(stream, commandList);
                stream.Flush();
            }
        }

        private void LoadCommands()
        {
            if (File.Exists(_storagePath))
            {
                var serializer = new XmlSerializer(typeof(CommandList));
                using (var stream = File.Open(_storagePath, FileMode.Open))
                {
                    var commands = serializer.Deserialize(stream) as CommandList;
                    foreach (var command in commands)
                    {
                        _dataSource.Add(command);
                    }
                }
            }
        }

        private void Launch()
        {
            var command = commandListBox.SelectedValue as Command;
            if (command != null)
            {
                Process.Start(command.Application, command.Arguments);
            }
        }

        private void ShowStatus(string text)
        {
            //toolStripStatusLabel1.Text = text;
        }

        private void Fit()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Size = Measure();
            var taskBarHeight = Screen.PrimaryScreen.Bounds.Bottom - Screen.PrimaryScreen.WorkingArea.Bottom;
            Left = 0;
            Top = Screen.PrimaryScreen.WorkingArea.Bottom - Height;
        }

        private Size Measure()
        {
            var measures = new SizeF();
            using (var graphics = Graphics.FromHwnd(Handle))
            {
                foreach (var item in _dataSource)
                {
                    var size = graphics.MeasureString(item.ToString(), commandListBox.Font);
                    measures.Height += size.Height + 1;
                    measures.Width = Math.Max(measures.Width, size.Width);
                }
            }
            measures.Height = Height - commandListBox.Height + measures.Height;
            measures.Width = Width - commandListBox.Width + measures.Width;
            measures.Width = Math.Max(reorderLinkLabel.Width + addLinkLabel.Width + editLinkLabel.Width + deleteLinkLabel.Width + 30, measures.Width);
            return new Size(Convert.ToInt32(measures.Width), Convert.ToInt32(measures.Height));
        }

        private static string GetBrowser()
        {
            var value = Registry.GetValue(@"HKEY_CLASSES_ROOT\htmlfile\shell\open", "command", null);
            if (value != null)
                return value.ToString();
            else
                return null;
        }
    }
}
