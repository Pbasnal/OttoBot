using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OttoUI
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        private bool sendContinously = false;
        private bool playAnimation = false;
        private bool readSerialOutput = true;
        private int sendIntervalInMs = 200;
        private AnimationData SelectedAnimData;
        private int SelectedIndex;

        private string ack;

        private List<AnimationData> AnimationTimeline = new List<AnimationData>();

        public Form1()
        {
            InitializeComponent();
            Init();
            PrintSerialOutput();
            SelectedAnimData = new AnimationData();
        }

        private void Init()
        {
            serialPort = new SerialPort("COM4", 9600);
            serialPort.Open();
            ListSavedAnimations();
        }

        private async Task PrintSerialOutput()
        {
            while (true)
            {
                if (!string.IsNullOrWhiteSpace(ack))
                {
                    serialOutput.AppendText(ack);
                    ack = string.Empty;
                }
                await Task.Delay(10);
            }
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            SendToOtto(ParseInputAngles());
        }

        private void SendToOtto(AnimationData animdata)
        {
            string cmd = "1:" + animdata.LF + "&2:" + animdata.LL + "&3:" + animdata.RF + "&4:" + animdata.RL;

            serialPort.WriteLine(cmd);
            ack = serialPort.ReadLine();
        }

        private void ContinousBtn_Click(object sender, EventArgs e)
        {
            if (sendContinously)
            {
                sendContinously = false;
                sendBtn.Enabled = true;
            }
            else
            {
                sendContinously = true;
                sendBtn.Enabled = false;
                SendContinously();
            }
        }

        private void ListSavedAnimations()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            string[] files = Directory.GetFiles(currentDirectory, "*.anim");

            savedAnimationsList.Items.Clear();

            foreach (var file in files)
            {
                savedAnimationsList.Items.Add(file.Replace(currentDirectory + "\\", "").Replace(".anim", ""));
            }
        }


        private async Task SendContinously()
        {
            while (sendContinously)
            {
                SendToOtto(ParseInputAngles());
                await Task.Delay(sendIntervalInMs);
            }
        }

        private AnimationData ParseInputAngles()
        {
            AnimationData animdata = new AnimationData();

            int input;
            if (Int32.TryParse(leftLegIn.Text, out input) && input != 0)
            {
                animdata.LL = input;
            }
            if (Int32.TryParse(leftFeetIn.Text, out input) && input != 0)
            {
                animdata.LF = input;
            }
            if (Int32.TryParse(rightLegIn.Text, out input) && input != 0)
            {
                animdata.RL = input;
            }
            if (Int32.TryParse(rightFeetIn.Text, out input) && input != 0)
            {
                animdata.RF = input;
            }
            if (Int32.TryParse(timeIn.Text, out input) && input != 0)
            {
                animdata.Time = input;
            }

            return animdata;
        }

        private void RecordBtn_Click(object sender, EventArgs e)
        {
            var animData = ParseInputAngles();
            AnimationTimeline.Add(animData);
            animationListBox.Items.Add(animData.ToString());
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            if (playAnimation)
            {
                playAnimation = false;
                playBtn.Text = "Play";
            }
            else
            {
                playAnimation = true;
                playBtn.Text = "Stop";
                PlayAnimation(AnimationTimeline.Select(a => a.Clone()).ToList());
            }
        }

        private async Task PlayAnimation(List<AnimationData> timeline)
        {
            await Task.Run(() =>
            {
                while (playAnimation)
                {
                    foreach (var animData in timeline)
                    {
                        if (!playAnimation) break;

                        var startTime = DateTime.UtcNow;
                        SendToOtto(animData);
                        var waitTime = animData.Time - (DateTime.UtcNow - startTime).TotalMilliseconds;

                        if (waitTime > 0)
                        { Thread.Sleep((int)waitTime); }
                    }
                }
            });
        }

        private void RestBtn_Click(object sender, EventArgs e)
        {
            AnimationData animData = new AnimationData();
            animData.LL = 90;
            animData.RL = 65;
            animData.LF = 120;
            animData.RF = 90;

            leftFeetIn.Text = animData.LF.ToString();
            leftLegIn.Text = animData.LL.ToString();
            rightFeetIn.Text = animData.RF.ToString();
            rightLegIn.Text = animData.RL.ToString();
            timeIn.Text = animData.Time.ToString();

            SendToOtto(animData);
        }

        private void AnimationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = (ListBox)sender;
            var selected = (string)listBox.SelectedItem;
            if (selected == null)
            {
                return;
            }
            SelectedIndex = listBox.SelectedIndex;
            SelectedAnimData.FromString(selected);

            leftFeetIn.Text = SelectedAnimData.LF.ToString();
            leftLegIn.Text = SelectedAnimData.LL.ToString();
            rightFeetIn.Text = SelectedAnimData.RF.ToString();
            rightLegIn.Text = SelectedAnimData.RL.ToString();
            timeIn.Text = SelectedAnimData.Time.ToString();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            AnimationTimeline[SelectedIndex] = ParseInputAngles();
            animationListBox.Items[SelectedIndex] = AnimationTimeline[SelectedIndex].ToString();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var animationName = setAnimationNameText.Text;
            using (StreamWriter file = new StreamWriter(animationName + ".anim"))
            {
                foreach (var anim in AnimationTimeline)
                {
                    file.WriteLine(anim.ToString());
                }
            }

            ListSavedAnimations();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            var selected = (string)savedAnimationsList.SelectedItem;
            var currentDirectory = Directory.GetCurrentDirectory();
            var lines = File.ReadAllLines(currentDirectory + "\\" + selected + ".anim");
            AnimationTimeline.Clear();
            animationListBox.Items.Clear();

            foreach (var line in lines)
            {
                var anim = new AnimationData(line);
                AnimationTimeline.Add(anim);
                animationListBox.Items.Add(anim.ToString());
            }

            setAnimationNameText.Text = selected;
        }
    }
}
