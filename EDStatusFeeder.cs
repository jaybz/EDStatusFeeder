using System;
using System.Windows.Forms;
using vJoyInterfaceWrap;

namespace EDStatusFeeder
{
    class EDStatusFeeder : ApplicationContext
    {
        private readonly ConfigurationDialog configWindow = new ConfigurationDialog();
        private readonly NotifyIcon trayIcon = new NotifyIcon()
        {
            Text = "ED Status Feeder",
            BalloonTipTitle = "ED Status Feeder",
            Icon = Resources.AppIcon,
            Visible = true,
        };
        private readonly vJoy vJoy = new vJoy();

        public EDStatusFeeder()
        {
            if (!vJoy.vJoyEnabled())
                throw new Exception("vJoy not enabled!");

            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem itemConfig = new ToolStripMenuItem("Configuration");
            itemConfig.Click += Config;
            itemConfig.Font = new System.Drawing.Font(itemConfig.Font, System.Drawing.FontStyle.Bold);
            menu.Items.Add(itemConfig);
            menu.Items.Add(new ToolStripSeparator());
            ToolStripMenuItem itemExit = new ToolStripMenuItem("Exit");
            itemExit.Click += Exit;
            menu.Items.Add(itemExit);

            // Initialize Tray Icon
            trayIcon.ContextMenuStrip = menu;
            trayIcon.DoubleClick += Config;

            if (Configuration.Data.DeviceId == 0)
                ShowConfigurationMenu();
            else
            {
                TrayNotify("Status Feeder is now active");
            }

            StatusChanged();
            EDStatusMonitor.MonitorInstance.Changed += StatusChanged;
        }

        void TrayNotify(string text, int duration=100)
        {
            trayIcon.BalloonTipText = text;
            trayIcon.ShowBalloonTip(duration);
        }

        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;

            Application.Exit();
        }
        void Config(object sender, EventArgs e)
        {
            ShowConfigurationMenu();
        }

        void ShowConfigurationMenu()
        {
            //configWindow.
            if (configWindow.Visible)
                configWindow.Activate();
            else
                configWindow.ShowDialog();
        }

        void StatusChanged()
        {
            try
            {
                if (Configuration.Data.DeviceId > 0)
                    ButtonFeeder.Feed(vJoy, Configuration.Data, EDStatusMonitor.MonitorInstance);
            }
            catch (ButtonFeederException e)
            {
                TrayNotify(e.Message, 5000);
            }
        }
    }
}
