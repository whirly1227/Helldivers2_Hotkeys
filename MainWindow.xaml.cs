using Gma.System.MouseKeyHook;
using Helldivers2_Hotkeys.Properties;
using System.Configuration;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Keyboard = InputMethods.Keyboard;

namespace Helldivers2_Hotkeys
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal static List<string> StratList = typeof(Stratagems).GetFields()
                            .Select(field => field.Name.Replace("_", " ")).ToList();
        private IKeyboardMouseEvents m_GlobalHook = Hook.GlobalEvents();
        private Stratagems stratagems = new();

        public MainWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            StratList.Sort();
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                ComboBox comboBox = new()
                {
                    Name = "Combo_" + i,
                    Margin = new Thickness(0, 2, 2, 2),
                    FontFamily = new FontFamily("Arial"),
                    ItemsSource = StratList,
                    VerticalContentAlignment = VerticalAlignment.Center,
                    HorizontalContentAlignment = HorizontalAlignment.Left
                };
                Grid.SetRow(comboBox, i);
                Grid.SetColumn(comboBox, 1);
                MainGrid.Children.Add(comboBox);
            }
            LoadSettings();
        }

        private void BTN_Save_Click(object sender, RoutedEventArgs e)
        {
            SaveSettings();
        }
        
        private void BTN_StartStop_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (BTN_StartStop.Content.ToString() == "Start")
                {
                    m_GlobalHook.KeyUp += M_GlobalHook_KeyPress;
                    BTN_StartStop.Content = "Stop";
                }
                else
                {
                    m_GlobalHook.KeyUp -= M_GlobalHook_KeyPress;
                    BTN_StartStop.Content = "Start";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LoadSettings()
        {
            try
            {
                Settings.Default.Numpad0 = Settings.Default.Numpad0;
                Settings.Default.Numpad1 = Settings.Default.Numpad1;
                Settings.Default.Numpad2 = Settings.Default.Numpad2;
                foreach (SettingsPropertyValue prop in Settings.Default.PropertyValues)
                {
                    prop.Name.ToString();
                    foreach (object? item in MainGrid.Children)
                    {
                        if (item.GetType() == typeof(ComboBox))
                        {
                            ComboBox comboBox = (ComboBox)item;
                            if (comboBox.Name.Replace("Combo_", "") == prop.Name.Replace("Numpad", ""))
                            {
                                comboBox.Text = prop.PropertyValue.ToString().Replace("_", " ");
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SaveSettings()
        {
            try
            {
                foreach (SettingsPropertyValue prop in Settings.Default.PropertyValues)
                {
                    prop.Name.ToString();
                    foreach (object? item in MainGrid.Children)
                    {
                        if (item.GetType() == typeof(ComboBox))
                        {
                            ComboBox comboBox = (ComboBox)item;
                            if (comboBox.Name.Replace("Combo_", "") == prop.Name.Replace("Numpad", ""))
                            {
                                if (comboBox.SelectedIndex < 0) break;
                                prop.PropertyValue = comboBox.Text.Replace(" ", "_");
                            }
                        }
                    }
                }
                Settings.Default.Save();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void M_GlobalHook_KeyPress(object? sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case System.Windows.Forms.Keys.NumPad0:
                    DoStrat(stratagems.GetType().GetField(Settings.Default.Numpad0).GetValue(stratagems) as Key[]);
                    break;
                case System.Windows.Forms.Keys.NumPad1:
                    DoStrat(stratagems.GetType().GetField(Settings.Default.Numpad1).GetValue(stratagems) as Key[]);
                    break;
                case System.Windows.Forms.Keys.NumPad2:
                    DoStrat(stratagems.GetType().GetField(Settings.Default.Numpad2).GetValue(stratagems) as Key[]);
                    break;
                case System.Windows.Forms.Keys.NumPad3:
                    DoStrat(stratagems.GetType().GetField(Settings.Default.Numpad3).GetValue(stratagems) as Key[]);
                    break;
                case System.Windows.Forms.Keys.NumPad4:
                    DoStrat(stratagems.GetType().GetField(Settings.Default.Numpad4).GetValue(stratagems) as Key[]);
                    break;
                case System.Windows.Forms.Keys.NumPad5:
                    DoStrat(stratagems.GetType().GetField(Settings.Default.Numpad5).GetValue(stratagems) as Key[]);
                    break;
                case System.Windows.Forms.Keys.NumPad6:
                    DoStrat(stratagems.GetType().GetField(Settings.Default.Numpad6).GetValue(stratagems) as Key[]);
                    break;
                case System.Windows.Forms.Keys.NumPad7:
                    DoStrat(stratagems.GetType().GetField(Settings.Default.Numpad7).GetValue(stratagems) as Key[]);
                    break;
                case System.Windows.Forms.Keys.NumPad8:
                    DoStrat(stratagems.GetType().GetField(Settings.Default.Numpad8).GetValue(stratagems) as Key[]);
                    break;
                case System.Windows.Forms.Keys.NumPad9:
                    DoStrat(stratagems.GetType().GetField(Settings.Default.Numpad9).GetValue(stratagems) as Key[]);
                    break;
            }
        }

        private void DoStrat(Key[] strat)
        {
            Keyboard.Press(Key.LeftCtrl);
            Thread.Sleep(50);
            for (int i = 0; i < strat.Length; i++)
            {
                Keyboard.Press(strat[i]);
                Thread.Sleep(25);
                Keyboard.Release(strat[i]);
                Thread.Sleep(25);
            }
            Keyboard.Release(Key.LeftCtrl);
            Thread.Sleep(50);
        }
    }
}