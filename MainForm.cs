namespace BusylightForm
{
    using Busylight;
    using NonInvasiveKeyboardHookLibrary;
    using System;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        private KuandoSDK sdk;
        private KeyboardHookManager manager;
        private ModifierKeys[] modifiers;

        private int oneKey = 0x31;
        private int twoKey = 0x32;
        private int zeroKey = 0x30;


        public MainForm()
        {
            InitializeComponent();

            this.modifiers = new ModifierKeys[] { NonInvasiveKeyboardHookLibrary.ModifierKeys.Control, NonInvasiveKeyboardHookLibrary.ModifierKeys.Shift };

            this.sdk = new KuandoSDK("omega");
            this.manager = new KeyboardHookManager();

            this.manager.Start();

            this.RegisterShortcuts();

            this.HideForm();
        }

        private void RegisterShortcuts()
        {
            // Ctrl + shift + 0 to turn off
            this.manager.RegisterHotkey(modifiers, zeroKey, () => LightOn(BusylightColor.Off));

            // Ctrl + shift + 1 to turn red
            this.manager.RegisterHotkey(modifiers, oneKey, () => LightOn(BusylightColor.Red));

            // Ctrl + shift + 2 to turn blue
            this.manager.RegisterHotkey(modifiers, twoKey, () => LightOn(BusylightColor.Blue));
        }

        private void RedLightButton_Click(object sender, EventArgs e)
        {
            this.LightOn(BusylightColor.Red);
        }

        private void BlueLightButton_Click(object sender, EventArgs e)
        {
            this.LightOn(BusylightColor.Blue);
        }

        private void NoLightButton_Click(object sender, EventArgs e)
        {
            this.LightOn(BusylightColor.Off);
        }



        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.HideForm();
            }
        }

        private void reducedIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowForm();
        }

        private void LightOn(BusylightColor color)
        {
            this.sdk.Light(color);
        }

        private void HideForm()
        {
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
            reducedIcon.Visible = true;
        }

        private void ShowForm()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            reducedIcon.Visible = false;
        }
    }
}
