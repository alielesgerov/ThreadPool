using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace ThreadPool
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cts;
        private List<Car> _cars = new List<Car>();
        private readonly string[] _filesDirectories = Directory.GetFiles(@"C:\Users\noid3\source\repos\ThreadPool", "*.json", SearchOption.TopDirectoryOnly);
        private string _elapsedTime;
        private TimeSpan _ts;
        private readonly Stopwatch _sw = new Stopwatch();
        private bool _isRunnig;

        public Form1()
        {
            InitializeComponent();
            CheckBoxSingle.Checked = true;
            panel1.AutoScroll=true;
        }

        private void Start(CancellationToken token, string directory)
        {
            try
            {
                if (token.IsCancellationRequested) return;

                 _cars = JsonSerializer.Deserialize<List<Car>>(File.ReadAllText(directory)) ?? throw new InvalidOperationException();
                AddCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void CheckBoxSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxMulti.Checked && CheckBoxMulti.Checked)
            {
                CheckBoxMulti.Checked = false;
            }
        }

        private void CheckBoxMulti_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxMulti.Checked && CheckBoxMulti.Checked)
            {
                CheckBoxSingle.Checked = false;
                CheckBoxMulti.Checked=true;
            }
        }

        private void AddCars()
        {
            
            int i = 0;
            int y = 0;
            foreach (var c in _cars)
            {
                TimerFunc();
                CarView cw = new CarView();
                cw.Location = new Point(4, -1 + y);
                cw.Name = "CarView" + cw;
                cw.Size = new Size(768, 150);
                cw.TabIndex=i++;
                cw.AddToUserControl(c);
                panel1.BeginInvoke(new Action((() => panel1.Controls.Add(cw))));
                y +=cw.Height;
            }

        }

        private void TimerFunc()
        {
            _ts = _sw.Elapsed;
            _elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                _ts.Hours, _ts.Minutes, _ts.Seconds,
                _ts.Milliseconds / 10);
            LabelTimer.BeginInvoke((new Action((() => LabelTimer.Text = $@"Timer: {_elapsedTime}"))));
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            _cts.Cancel();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Controls.Clear();
                if (!_isRunnig)
                {
                    _isRunnig = true;
                    _cts = new CancellationTokenSource();
                    _sw.Stop();
                    _sw.Reset();
                    _sw.Start();
                    if (CheckBoxSingle.Checked)
                    {
                        System.Threading.ThreadPool.QueueUserWorkItem(_ =>
                        {
                            foreach (var directory in _filesDirectories)
                            {
                                Start(_cts.Token, directory);
                            }
                            _isRunnig=false;
                        });
                    }
                    else if (CheckBoxMulti.Checked)
                    {
                        
                        foreach (var directory in _filesDirectories)
                        {
                            
                            System.Threading.ThreadPool.QueueUserWorkItem(_ =>
                            {
                                Start(_cts.Token, directory);
                                _isRunnig=false;
                            });
                            if (_cts.Token.IsCancellationRequested) break;
                        }
                    }
                }
                else
                    throw new Exception("Proccess is running");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

    }
}
