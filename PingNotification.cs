using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Notifications;

namespace PingTimeoutNotifications
{
    public partial class PingNotification : Form
    {
        private int defaultIntervalMins = 5;
        private int currentIntervalMins;
        private static bool currentlyRunning = false;
        private List<IPAddress> ipList;
        private byte[] buffer;
        private PingOptions options;
        private CancellationTokenSource cancellation;

        public PingNotification()
        {
            InitializeComponent();
            numudInterval.Value = defaultIntervalMins;
            currentIntervalMins = defaultIntervalMins;
            cancellation = new CancellationTokenSource();
            UpdateLabels();
        }

        private void Ping_Load(object sender, EventArgs e)
        {
            ConsoleOut("Welcome!");
        }

        private void Ping_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }


        private void ConsoleOut(string str)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(ConsoleOut), new object[] { str });
                return;
            }
            DateTime curDT = DateTime.Now;
            txtConsole.Text += curDT.ToString("d-MMM-yyyy HH:mm:ss - ") + str + Environment.NewLine;
        }

        public void UpdateLabels()
        {
            if (currentlyRunning)
            {
                lblRunning.Visible = true;
                lblStopped.Visible = false;
            }
            else
            {
                lblRunning.Visible = false;
                lblStopped.Visible = true;
            }
        }

        private void btnAddIP_Click(object sender, EventArgs e)
        {
            if (CheckIP(txtIP.Text))
            {
                AddIP(txtIP.Text);
                txtIP.Text = "";
            }
            else
            {
                ConsoleOut("Error! Invalid IP.");
            };
        }

        private bool CheckIP(string ip)
        {
            IPAddress address;
            if (IPAddress.TryParse(ip, out address))
            {
                switch (address.AddressFamily)
                {
                    case System.Net.Sockets.AddressFamily.InterNetwork:
                        return true;

                    default:
                        return false;
                }
            }
            else return false;
        }

        private void AddIP(string ip)
        {
            lstIPs.Items.Add(IPAddress.Parse(ip));
            ConsoleOut("Added " + IPAddress.Parse(ip));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = lstIPs.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int currentIndex = lstIPs.SelectedIndices[i];
                ConsoleOut("Removed " + lstIPs.Items[currentIndex]);
                lstIPs.Items.RemoveAt(currentIndex);
            }
        }

        private void txtConsole_TextChanged(object sender, EventArgs e)
        {
            txtConsole.SelectionStart = txtConsole.Text.Length;
            txtConsole.ScrollToCaret();
        }

        private async void PingIPs()
        {
            currentlyRunning = true;
            UpdateLabels();
            buffer = Encoding.ASCII.GetBytes(".");
            options = new PingOptions(50, true);

            ipList = lstIPs.Items.Cast<IPAddress>().ToList();

            var tasks = new List<Task>();

            foreach (IPAddress ip in ipList)
            {
                var task = PingAndUpdateNodeAsync(new Ping(), ip);
                tasks.Add(task);
            }

            await Task.WhenAll(tasks);
        }

        private async Task PingAndUpdateNodeAsync(Ping ping, IPAddress ip)
        {
            var reply = await ping.SendPingAsync(ip, 1000, buffer, options);
            if (reply.Status == IPStatus.Success)
            {
                ConsoleOut(ip + " is up!");
            }
            else
            {
                ConsoleOut(ip + " is down!");
                CreateToast(ip);
            }
        }

        private void CreateToast(IPAddress ip)
        {
            try
            {
                var xml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText01);
                var text = xml.GetElementsByTagName("text");
                text[0].AppendChild(xml.CreateTextNode(ip.ToString() + " is down!"));
                var toast = new ToastNotification(xml);
                ToastNotificationManager.CreateToastNotifier("Ping Timeout Notifications").Show(toast);
            }
            catch (Exception e)
            {
                ConsoleOut(e.Message);
            }
        }

        public static async Task RepeatActionEvery(Action action, int interval, CancellationToken cancellationToken)
        {
            while (true)
            {
                action();
                Task task = Task.Delay(interval, cancellationToken);

                try
                {
                    await task;
                }
                catch (TaskCanceledException)
                {
                    currentlyRunning = false;
                    return;
                }
            }
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (cancellation == null || cancellation.IsCancellationRequested)
            {
                cancellation = new CancellationTokenSource();
            }

            if (!currentlyRunning && !cancellation.IsCancellationRequested)
            {
                currentlyRunning = true;
                UpdateLabels();
                await RepeatActionEvery(PingIPs, currentIntervalMins * 60 * 1000, cancellation.Token);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (currentlyRunning && !cancellation.IsCancellationRequested)
            {
                currentlyRunning = false;
                UpdateLabels();
                cancellation.Cancel();
            }
        }

        private void numudInterval_ValueChanged(object sender, EventArgs e)
        {
            currentIntervalMins = (int)numudInterval.Value;
        }
    }
}