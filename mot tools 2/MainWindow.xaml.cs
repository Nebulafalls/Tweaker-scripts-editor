using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Configuration;
using System.Windows.Threading;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Collections;
using System.Diagnostics;

namespace mot_tools_2

{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        DispatcherTimer timer = new DispatcherTimer();

        //创建一个打开文件式的对话框
        //创建一个打开文件式的对话框
      
        string qd = "1";
        string sfjc_tip1 = "0";
        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(50000000);
            timer.Start();
            
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (sfjc_tip1 == "0")
            {
                if (tips_part.SelectedIndex == 0)
                {
                    tips_part.SelectedIndex = 1;
                }
                else
                {
                    if (tips_part.SelectedIndex == 1)
                    {
                        tips_part.SelectedIndex = 2;
                    }
                    else
                    {
                        if (tips_part.SelectedIndex == 2)
                        {
                            tips_part.SelectedIndex = 0;
                        }
                    }
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            kztsc.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Clipboard.SetDataObject(kztsc.Text);//复制到剪贴板
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            cbl.IsOpen = true;
            //打开侧边栏
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            主界面.SelectedIndex = 2;
        }






        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (s1.Text == "")
            {
                s1.Text = "null";
            }
            if (s2.Text == "")
            {
                s2.Text = "null";
            }
            if (s3.Text == "")
            {
                s3.Text = "null";
            }
            if (s4.Text == "")
            {
                s4.Text = "null";
            }
            if (s5.Text == "")
            {
                s5.Text = "null";
            }
            if (s6.Text == "")
            {
                s6.Text = "null";
            }
            if (s7.Text == "")
            {
                s7.Text = "null";
            }
            if (s8.Text == "")
            {
                s8.Text = "null";
            }
            if (s9.Text == "")
            {
                s9.Text = "null";
            }
            if (s10.Text == "")
            {
                s10.Text = "null";
            }
            if (s11.Text == "")
            {
                s11.Text = "null";
            }
            if (s12.Text == "")
            {
                s12.Text = "null";
            }
            if (s13.Text == "")
            {
                s13.Text = "null";
            }
            if (s14.Text == "")
            {
                s14.Text = "null";
            }
            if (s15.Text == "")
            {
                s15.Text = "null";
            }
            if (s16.Text == "")
            {
                s16.Text = "null";
            }
            if (s17.Text == "")
            {
                s17.Text = "null";
            }
            if (s18.Text == "")
            {
                s18.Text = "null";
            }
            if (s19.Text == "")
            {
                s19.Text = "null";
            }
            if (s20.Text == "")
            {
                s20.Text = "null";
            }
            if (s21.Text == "")
            {
                s21.Text = "null";
            }
            if (s22.Text == "")
            {
                s22.Text = "null";
            }
            if (s23.Text == "")
            {
                s23.Text = "null";
            }
            if (s24.Text == "")
            {
                s24.Text = "null";
            }
            if (s25.Text == "")
            {
                s25.Text = "null";
            }
            if (s26.Text == "")
            {
                s26.Text = "null";
            }
            if (s27.Text == "")
            {
                s27.Text = "null";
            }
            if (s28.Text == "")
            {
                s28.Text = "null";
            }
            if (s29.Text == "")
            {
                s29.Text = "null";
            }
            if (s30.Text == "")
            {
                s30.Text = "null";
            }
            if (s31.Text == "")
            {
                s31.Text = "null";
            }
            if (s32.Text == "")
            {
                s32.Text = "null";
            }
            if (s33.Text == "")
            {
                s33.Text = "null";
            }
            if (s34.Text == "")
            {
                s34.Text = "null";
            }
            if (s35.Text == "")
            {
                s35.Text = "null";
            }
            if (s36.Text == "")
            {
                s36.Text = "null";
            }
            if (s37.Text == "")
            {
                s37.Text = "null";
            }
            if (s38.Text == "")
            {
                s38.Text = "null";
            }
            if (s39.Text == "")
            {
                s39.Text = "null";
            }
            if (s40.Text == "")
            {
                s40.Text = "null";
            }
            if (s41.Text == "")
            {
                s41.Text = "null";
            }
            if (s42.Text == "")
            {
                s42.Text = "null";
            }
            if (s43.Text == "")
            {
                s43.Text = "null";
            }
            if (s44.Text == "")
            {
                s44.Text = "null";
            }
            if (s45.Text == "")
            {
                s45.Text = "null";
            }
            if (s46.Text == "")
            {
                s46.Text = "null";
            }
            if (s47.Text == "")
            {
                s47.Text = "null";
            }
            if (s48.Text == "")
            {
                s48.Text = "null";
            }
            if (s49.Text == "")
            {
                s49.Text = "null";
            }
            if (s50.Text == "")
            {
                s50.Text = "null";
            }
            if (s51.Text == "")
            {
                s51.Text = "null";
            }
            if (s52.Text == "")
            {
                s52.Text = "null";
            }
            if (s53.Text == "")
            {
                s53.Text = "null";
            }
            if (s54.Text == "")
            {
                s54.Text = "null";
            }
            if (s55.Text == "")
            {
                s55.Text = "null";
            }
            if (s56.Text == "")
            {
                s56.Text = "null";
            }
            if (s57.Text == "")
            {
                s57.Text = "null";
            }
            if (s58.Text == "")
            {
                s58.Text = "null";
            }
            if (s59.Text == "")
            {
                s59.Text = "null";
            }
            if (s60.Text == "")
            {
                s60.Text = "null";
            }
            if (s61.Text == "")
            {
                s61.Text = "null";
            }
            if (s62.Text == "")
            {
                s62.Text = "null";
            }
            if (s63.Text == "")
            {
                s63.Text = "null";
            }
            if (s64.Text == "")
            {
                s64.Text = "null";
            }
            if (s65.Text == "")
            {
                s65.Text = "null";
            }
            if (s66.Text == "")
            {
                s66.Text = "null";
            }
            if (s67.Text == "")
            {
                s67.Text = "null";
            }
            if (s68.Text == "")
            {
                s68.Text = "null";
            }
            if (s69.Text == "")
            {
                s69.Text = "null";
            }
            if (s70.Text == "")
            {
                s70.Text = "null";
            }
            if (s71.Text == "")
            {
                s71.Text = "null";
            }
            if (s72.Text == "")
            {
                s72.Text = "null";
            }
            if (s73.Text == "")
            {
                s73.Text = "null";
            }
            if (s74.Text == "")
            {
                s74.Text = "null";
            }
            if (s75.Text == "")
            {
                s75.Text = "null";
            }
            if (s76.Text == "")
            {
                s76.Text = "null";
            }
            if (s77.Text == "")
            {
                s77.Text = "null";
            }
            if (s78.Text == "")
            {
                s78.Text = "null";
            }
            if (s79.Text == "")
            {
                s79.Text = "null";
            }
            if (s80.Text == "")
            {
                s80.Text = "null";
            }
            if (s81.Text == "")
            {
                s81.Text = "null";
            }
        }//检测空白

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            主界面.SelectedIndex = 1;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            主界面.SelectedIndex = 0;
        }

        private void Qk_Click(object sender, RoutedEventArgs e)
        {
            sck.Text = "";
            s1.Text = "";
            s2.Text = "";
            s3.Text = "";
            s4.Text = "";
            s5.Text = "";
            s6.Text = "";
            s7.Text = "";
            s8.Text = "";
            s9.Text = "";
            s10.Text = "";
            s11.Text = "";
            s12.Text = "";
            s13.Text = "";
            s14.Text = "";
            s15.Text = "";
            s16.Text = "";
            s17.Text = "";
            s18.Text = "";
            s19.Text = "";
            s20.Text = "";
            s21.Text = "";
            s22.Text = "";
            s23.Text = "";
            s24.Text = "";
            s25.Text = "";
            s26.Text = "";
            s27.Text = "";
            s28.Text = "";
            s29.Text = "";
            s30.Text = "";
            s31.Text = "";
            s32.Text = "";
            s33.Text = "";
            s34.Text = "";
            s35.Text = "";
            s36.Text = "";
            s37.Text = "";
            s38.Text = "";
            s39.Text = "";
            s40.Text = "";
            s41.Text = "";
            s42.Text = "";
            s43.Text = "";
            s44.Text = "";
            s45.Text = "";
            s46.Text = "";
            s47.Text = "";
            s48.Text = "";
            s49.Text = "";
            s50.Text = "";
            s51.Text = "";
            s52.Text = "";
            s53.Text = "";
            s54.Text = "";
            s55.Text = "";
            s56.Text = "";
            s57.Text = "";
            s58.Text = "";
            s59.Text = "";
            s60.Text = "";
            s61.Text = "";
            s62.Text = "";
            s63.Text = "";
            s64.Text = "";
            s65.Text = "";
            s66.Text = "";
            s67.Text = "";
            s68.Text = "";
            s69.Text = "";
            s70.Text = "";
            s71.Text = "";
            s72.Text = "";
            s73.Text = "";
            s74.Text = "";
            s75.Text = "";
            s76.Text = "";
            s77.Text = "";
            s78.Text = "";
            s79.Text = "";
            s80.Text = "";
            s81.Text = "";
        }//清除

        private void 输出_Click(object sender, RoutedEventArgs e)
        {
            string sc;
            if (sck.Text == "")
            {
                this.ShowMessageAsync("警告", "成品未填写");
            }
            else
            {
                if (无序.IsChecked == false)
                {
                    sc = "mods.avaritia.ExtremeCrafting.addShaped(" + sck.Text + ",[" + Environment.NewLine + "[" + s1.Text + "," + s2.Text + "," + s3.Text + "," + s4.Text + "," + s5.Text + "," + s6.Text + "," + s7.Text + "," + s8.Text + "," + s9.Text + "]," + Environment.NewLine + "[" + s10.Text + "," + s11.Text + "," + s12.Text + "," + s13.Text + "," + s14.Text + "," + s15.Text + "," + s16.Text + "," + s17.Text + "," + s18.Text + "]," + Environment.NewLine + "[" + s19.Text + "," + s20.Text + "," + s21.Text + "," + s22.Text + "," + s23.Text + "," + s24.Text + "," + s25.Text + "," + s26.Text + "," + s27.Text + "]," + Environment.NewLine + "[" + s28.Text + "," + s29.Text + "," + s30.Text + "," + s31.Text + "," + s32.Text + "," + s33.Text + "," + s34.Text + "," + s35.Text + "," + s36.Text + "]," + Environment.NewLine + "[" + s37.Text + "," + s38.Text + "," + s39.Text + "," + s40.Text + "," + s41.Text + "," + s42.Text + "," + s43.Text + "," + s44.Text + "," + s45.Text + "]," + Environment.NewLine + "[" + s46.Text + "," + s47.Text + "," + s48.Text + "," + s49.Text + "," + s50.Text + "," + s51.Text + "," + s52.Text + "," + s53.Text + "," + s54.Text + "]," + Environment.NewLine + "[" + s55.Text + "," + s56.Text + "," + s57.Text + "," + s58.Text + "," + s59.Text + "," + s60.Text + "," + s61.Text + "," + s62.Text + "," + s63.Text + "]," + Environment.NewLine + "[" + s64.Text + "," + s65.Text + "," + s66.Text + "," + s67.Text + "," + s68.Text + "," + s69.Text + "," + s70.Text + "," + s71.Text + "," + s72.Text + "]," + Environment.NewLine + "[" + s73.Text + "," + s74.Text + "," + s75.Text + "," + s76.Text + "," + s77.Text + "," + s78.Text + "," + s79.Text + "," + s80.Text + "," + s81.Text + "]]);";
                    kztsc.Text = sc;
                }
                else
                {
                    sc = "mods.avaritia.ExtremeCrafting.addShapeless(" + sck.Text + ",[" + Environment.NewLine + "[" + s1.Text + "," + s2.Text + "," + s3.Text + "," + s4.Text + "," + s5.Text + "," + s6.Text + "," + s7.Text + "," + s8.Text + "," + s9.Text + "]," + Environment.NewLine + "[" + s10.Text + "," + s11.Text + "," + s12.Text + "," + s13.Text + "," + s14.Text + "," + s15.Text + "," + s16.Text + "," + s17.Text + "," + s18.Text + "]," + Environment.NewLine + "[" + s19.Text + "," + s20.Text + "," + s21.Text + "," + s22.Text + "," + s23.Text + "," + s24.Text + "," + s25.Text + "," + s26.Text + "," + s27.Text + "]," + Environment.NewLine + "[" + s28.Text + "," + s29.Text + "," + s30.Text + "," + s31.Text + "," + s32.Text + "," + s33.Text + "," + s34.Text + "," + s35.Text + "," + s36.Text + "]," + Environment.NewLine + "[" + s37.Text + "," + s38.Text + "," + s39.Text + "," + s40.Text + "," + s41.Text + "," + s42.Text + "," + s43.Text + "," + s44.Text + "," + s45.Text + "]," + Environment.NewLine + "[" + s46.Text + "," + s47.Text + "," + s48.Text + "," + s49.Text + "," + s50.Text + "," + s51.Text + "," + s52.Text + "," + s53.Text + "," + s54.Text + "]," + Environment.NewLine + "[" + s55.Text + "," + s56.Text + "," + s57.Text + "," + s58.Text + "," + s59.Text + "," + s60.Text + "," + s61.Text + "," + s62.Text + "," + s63.Text + "]," + Environment.NewLine + "[" + s64.Text + "," + s65.Text + "," + s66.Text + "," + s67.Text + "," + s68.Text + "," + s69.Text + "," + s70.Text + "," + s71.Text + "," + s72.Text + "]," + Environment.NewLine + "[" + s73.Text + "," + s74.Text + "," + s75.Text + "," + s76.Text + "," + s77.Text + "," + s78.Text + "," + s79.Text + "," + s80.Text + "," + s81.Text + "]]);";
                    kztsc.Text = sc;
                }
            }
        }//生成

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {

            if (ConfigurationManager.AppSettings["darkt"] == "1")
            {
                // set the Red accent and dark theme only to the current window
                ThemeManager.ChangeAppStyle(this,
                                            ThemeManager.GetAccent("blue"),
                                            ThemeManager.GetAppTheme("BaseDark"));
                dark_theme1.IsChecked = true;
                qd = "0";

            }
            else
            {
                dark_theme1.IsChecked = false;
                qd = "0";
            }
            string path = System.Windows.Forms.Application.StartupPath + "/projects";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "/projects");
            }
            if (!Directory.Exists(path + "/无尽贪婪"))
            {
                Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "/projects/无尽贪婪");
            }
            if (!Directory.Exists(path + "/热力膨胀"))
            {
                Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "/projects/热力膨胀");
            }
            if (!Directory.Exists(path + "/热力膨胀/熔岩炉"))
            {
                Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "/projects/热力膨胀/熔岩炉");
            }
            if (!Directory.Exists(path + @"\无尽贪婪\中子态素压缩机"))
            {
                Directory.CreateDirectory(path + @"\无尽贪婪\中子态素压缩机");
            }
             if (!Directory.Exists(path + @"\热力膨胀\红石炉"))
            {
                Directory.CreateDirectory(path + @"\热力膨胀\红石炉");
            }
            if (!Directory.Exists(path + @"\热力膨胀\有机灌注机"))
            {
                Directory.CreateDirectory(path + @"\热力膨胀\有机灌注机");
            }
        }
        private void Dark_theme1_IsCheckedChanged(object sender, EventArgs e)
        {
            if (qd == "0")
            {
                if (dark_theme1.IsChecked == true)
                {
                    Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    cfa.AppSettings.Settings["darkt"].Value = "1";
                    cfa.Save();
                    this.ShowMessageAsync("提示", "重启以生效");
                }
                else
                {
                    Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    cfa.AppSettings.Settings["darkt"].Value = "0";
                    cfa.Save();
                    this.ShowMessageAsync("提示", "重启以生效");
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string ml = System.Windows.Forms.Application.StartupPath + @"\projects\无尽贪婪";
            string filename = "";
            //创建一个保存文件式的对话框
            SaveFileDialog sfd = new SaveFileDialog();
            //设置这个对话框的起始保存路径
            sfd.InitialDirectory = ml;
            //设置保存的文件的类型，注意过滤器的语法
            sfd.Filter = "mot tools 2保存文件|*.mt2save";
            //调用ShowDialog()方法显示该对话框，该方法的返回值代表用户是否点击了确定按钮
            if (sfd.ShowDialog() == true)
            {
                filename = sfd.FileName;
                if (!File.Exists(filename))
                {
                    using (File.Create(filename)) { };
                }
                IniFileHelper.SetValue("保存", "类型", "无尽贪婪", filename);
                IniFileHelper.SetValue("保存", "成品", sck.Text, filename);
                if (无序.IsChecked == true)
                {
                    IniFileHelper.SetValue("保存", "是否有序", "0", filename);
                }
                else
                {
                    IniFileHelper.SetValue("保存", "是否有序", "1", filename);
                }
                IniFileHelper.SetValue("保存", "1", s1.Text, filename);
                IniFileHelper.SetValue("保存", "2", s2.Text, filename);
                IniFileHelper.SetValue("保存", "3", s3.Text, filename);
                IniFileHelper.SetValue("保存", "4", s4.Text, filename);
                IniFileHelper.SetValue("保存", "5", s5.Text, filename);
                IniFileHelper.SetValue("保存", "6", s6.Text, filename);
                IniFileHelper.SetValue("保存", "7", s7.Text, filename);
                IniFileHelper.SetValue("保存", "8", s8.Text, filename);
                IniFileHelper.SetValue("保存", "9", s9.Text, filename);
                IniFileHelper.SetValue("保存", "10", s10.Text, filename);
                IniFileHelper.SetValue("保存", "11", s11.Text, filename);
                IniFileHelper.SetValue("保存", "12", s12.Text, filename);
                IniFileHelper.SetValue("保存", "13", s13.Text, filename);
                IniFileHelper.SetValue("保存", "14", s14.Text, filename);
                IniFileHelper.SetValue("保存", "15", s15.Text, filename);
                IniFileHelper.SetValue("保存", "16", s16.Text, filename);
                IniFileHelper.SetValue("保存", "17", s17.Text, filename);
                IniFileHelper.SetValue("保存", "18", s18.Text, filename);
                IniFileHelper.SetValue("保存", "19", s19.Text, filename);
                IniFileHelper.SetValue("保存", "20", s20.Text, filename);
                IniFileHelper.SetValue("保存", "21", s21.Text, filename);
                IniFileHelper.SetValue("保存", "22", s22.Text, filename);
                IniFileHelper.SetValue("保存", "23", s23.Text, filename);
                IniFileHelper.SetValue("保存", "24", s24.Text, filename);
                IniFileHelper.SetValue("保存", "25", s25.Text, filename);
                IniFileHelper.SetValue("保存", "26", s26.Text, filename);
                IniFileHelper.SetValue("保存", "27", s27.Text, filename);
                IniFileHelper.SetValue("保存", "28", s28.Text, filename);
                IniFileHelper.SetValue("保存", "29", s29.Text, filename);
                IniFileHelper.SetValue("保存", "30", s30.Text, filename);
                IniFileHelper.SetValue("保存", "31", s31.Text, filename);
                IniFileHelper.SetValue("保存", "32", s32.Text, filename);
                IniFileHelper.SetValue("保存", "33", s33.Text, filename);
                IniFileHelper.SetValue("保存", "34", s34.Text, filename);
                IniFileHelper.SetValue("保存", "35", s35.Text, filename);
                IniFileHelper.SetValue("保存", "36", s36.Text, filename);
                IniFileHelper.SetValue("保存", "37", s37.Text, filename);
                IniFileHelper.SetValue("保存", "38", s38.Text, filename);
                IniFileHelper.SetValue("保存", "39", s39.Text, filename);
                IniFileHelper.SetValue("保存", "40", s40.Text, filename);
                IniFileHelper.SetValue("保存", "41", s41.Text, filename);
                IniFileHelper.SetValue("保存", "42", s42.Text, filename);
                IniFileHelper.SetValue("保存", "43", s43.Text, filename);
                IniFileHelper.SetValue("保存", "44", s44.Text, filename);
                IniFileHelper.SetValue("保存", "45", s45.Text, filename);
                IniFileHelper.SetValue("保存", "46", s46.Text, filename);
                IniFileHelper.SetValue("保存", "47", s47.Text, filename);
                IniFileHelper.SetValue("保存", "48", s48.Text, filename);
                IniFileHelper.SetValue("保存", "49", s49.Text, filename);
                IniFileHelper.SetValue("保存", "50", s50.Text, filename);
                IniFileHelper.SetValue("保存", "51", s51.Text, filename);
                IniFileHelper.SetValue("保存", "52", s52.Text, filename);
                IniFileHelper.SetValue("保存", "53", s53.Text, filename);
                IniFileHelper.SetValue("保存", "54", s54.Text, filename);
                IniFileHelper.SetValue("保存", "55", s55.Text, filename);
                IniFileHelper.SetValue("保存", "56", s56.Text, filename);
                IniFileHelper.SetValue("保存", "57", s57.Text, filename);
                IniFileHelper.SetValue("保存", "58", s58.Text, filename);
                IniFileHelper.SetValue("保存", "59", s59.Text, filename);
                IniFileHelper.SetValue("保存", "60", s60.Text, filename);
                IniFileHelper.SetValue("保存", "61", s61.Text, filename);
                IniFileHelper.SetValue("保存", "62", s62.Text, filename);
                IniFileHelper.SetValue("保存", "63", s63.Text, filename);
                IniFileHelper.SetValue("保存", "64", s64.Text, filename);
                IniFileHelper.SetValue("保存", "65", s65.Text, filename);
                IniFileHelper.SetValue("保存", "66", s66.Text, filename);
                IniFileHelper.SetValue("保存", "67", s67.Text, filename);
                IniFileHelper.SetValue("保存", "68", s68.Text, filename);
                IniFileHelper.SetValue("保存", "69", s69.Text, filename);
                IniFileHelper.SetValue("保存", "70", s70.Text, filename);
                IniFileHelper.SetValue("保存", "71", s71.Text, filename);
                IniFileHelper.SetValue("保存", "72", s72.Text, filename);
                IniFileHelper.SetValue("保存", "73", s73.Text, filename);
                IniFileHelper.SetValue("保存", "74", s74.Text, filename);
                IniFileHelper.SetValue("保存", "75", s75.Text, filename);
                IniFileHelper.SetValue("保存", "76", s76.Text, filename);
                IniFileHelper.SetValue("保存", "77", s77.Text, filename);
                IniFileHelper.SetValue("保存", "78", s78.Text, filename);
                IniFileHelper.SetValue("保存", "79", s79.Text, filename);
                IniFileHelper.SetValue("保存", "80", s80.Text, filename);
                IniFileHelper.SetValue("保存", "81", s81.Text, filename);
                this.ShowMessageAsync("提示", "保存成功");
            }
            else
            {
;                this.ShowMessageAsync("警告","保存失败请重试");
            }
        }


        public static class IniFileHelper
        {
            #region 引用DLL

            /// <summary>
            /// 读取ini配置文件
            /// </summary>
            /// <param name="sectionName">要读取的section名,如果传入null获取ini文件所有的section名</param>
            /// <param name="key">要读取的key,如果传入null获取此section名下的所有key</param>
            /// <param name="defaultValue">读取异常的情况下的缺省值</param>
            /// <param name="returnBuffer">key所对应的值，如果该key不存在则返回defaultValue</param>
            /// <param name="size">值允许的大小</param>
            /// <param name="filePath">ini文件的完整路径和文件名</param>
            /// <see cref="https://msdn.microsoft.com/zh-cn/library/ms724353.aspx"/>
            /// <returns></returns>
            [DllImport("kernel32")]
            private static extern int GetPrivateProfileString(string sectionName, string key, string defaultValue, byte[] returnBuffer, int size, string filePath);

            /// <summary>
            /// 写入ini配置文件
            /// </summary>
            /// <param name="sectionName">要写入的section名</param>
            /// <param name="key">要写入的key，如果传入为null，整个sectionName被清除</param>
            /// <param name="value">key所对应的值，如果传入为null，此key将被清除</param>
            /// <param name="filePath">ini文件的完整路径和文件名</param>
            /// <see cref="https://msdn.microsoft.com/zh-cn/library/ms725501.aspx"/>
            /// <returns></returns>
            [DllImport("kernel32")]
            private static extern long WritePrivateProfileString(string sectionName, string key, string value, string filePath);




            #endregion


            /// <summary>
            /// 根据key读取Value
            /// </summary>
            /// <param name="sectionName">section名称</param>
            /// <param name="key">key的名称</param>
            /// <param name="filePath">文件路径</param>
            public static string GetValue(string sectionName, string key, string filePath)
            {
                byte[] buffer = new byte[2048];
                int length = GetPrivateProfileString(sectionName, key, "发生错误", buffer, 999, filePath);
                string rs = System.Text.UTF8Encoding.Default.GetString(buffer, 0, length);
                return rs;
            }

            /// <summary>
            /// 获取ini文件内所有的section名称
            /// </summary>
            /// <param name="filePath">文件路径</param>
            /// <returns>返回一个包含section名称的集合</returns>
            public static List<string> GetSectionNames(string filePath)
            {
                byte[] buffer = new byte[2048];
                int length = GetPrivateProfileString(null, "", "", buffer, 999, filePath);
                String[] rs = System.Text.UTF8Encoding.Default.GetString(buffer, 0, length).Split(new string[] { "\0" }, StringSplitOptions.RemoveEmptyEntries);
                return rs.ToList();
            }

            /// <summary>
            /// 获取指定section内的所有key
            /// </summary>
            /// <param name="sectionName">section名称</param>
            /// <param name="filePath">文件路径</param>
            /// <returns>返回一个包含key名称的集合</returns>
            public static List<string> GetKeys(string sectionName, string filePath)
            {
                byte[] buffer = new byte[2048];
                int length = GetPrivateProfileString(sectionName, null, "", buffer, 999, filePath);
                String[] rs = System.Text.UTF8Encoding.Default.GetString(buffer, 0, length).Split(new string[] { "\0" }, StringSplitOptions.RemoveEmptyEntries);
                return rs.ToList();
            }

            /// <summary>
            /// 保存内容到ini文件
            /// <para>若存在相同的key，就覆盖，否则就增加</para>
            /// </summary>
            /// <param name="sectionName">section名称</param>
            /// <param name="key">key的名称</param>
            /// <param name="value">存储的值</param>
            /// <param name="filePath">文件路径</param>
            public static bool SetValue(string sectionName, string key, string value, string filePath)
            {
                try
                {
                    int rs = (int)WritePrivateProfileString(sectionName, key, value, filePath);
                    return rs > 0;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            /// <summary>
            /// 移除指定的section
            /// </summary>
            /// <param name="sectionName">section名称</param>
            /// <param name="filePath">文件路径</param>
            /// <returns></returns>
            public static bool RemoveSection(string sectionName, string filePath)
            {
                try
                {
                    int rs = (int)WritePrivateProfileString(sectionName, null, "", filePath);
                    return rs > 0;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            /// <summary>
            /// 移除指定的key
            /// </summary>
            /// <param name="sectionName">section名称</param>
            /// <param name="filePath">文件路径</param>
            /// <returns></returns>
            public static bool Removekey(string sectionName, string key, string filePath)
            {
                try
                {
                    int rs = (int)WritePrivateProfileString(sectionName, key, null, filePath);
                    return rs > 0;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }//ini操作

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            string filename = "";
            string ml= System.Windows.Forms.Application.StartupPath + @"\projects\无尽贪婪";
            //创建一个打开文件式的对话框
            OpenFileDialog ofd = new OpenFileDialog();
            //设置这个对话框的起始打开路径
            ofd.InitialDirectory = ml;
            //设置打开的文件的类型，注意过滤器的语法
            ofd.Filter = "mot tools 2保存文件|*.mt2save";
            if (ofd.ShowDialog() == true)
            {
                filename = ofd.FileName;
                if (IniFileHelper.GetValue("保存", "类型", filename) == "无尽贪婪")
                {

                    sck.Text = IniFileHelper.GetValue("保存", "成品", filename);
                    if (IniFileHelper.GetValue("保存", "是否有序", filename) == "0")
                    {
                        无序.IsChecked = true;
                    }
                    else
                    {
                        无序.IsChecked = false;
                    }
                    s1.Text = IniFileHelper.GetValue("保存", "1", filename);
                    s2.Text = IniFileHelper.GetValue("保存", "2", filename);
                    s3.Text = IniFileHelper.GetValue("保存", "3", filename);
                    s4.Text = IniFileHelper.GetValue("保存", "4", filename);
                    s5.Text = IniFileHelper.GetValue("保存", "5", filename);
                    s6.Text = IniFileHelper.GetValue("保存", "6", filename);
                    s7.Text = IniFileHelper.GetValue("保存", "7", filename);
                    s8.Text = IniFileHelper.GetValue("保存", "8", filename);
                    s9.Text = IniFileHelper.GetValue("保存", "9", filename);
                    s10.Text = IniFileHelper.GetValue("保存", "10", filename);
                    s11.Text = IniFileHelper.GetValue("保存", "11", filename);
                    s12.Text = IniFileHelper.GetValue("保存", "12", filename);
                    s13.Text = IniFileHelper.GetValue("保存", "13", filename);
                    s14.Text = IniFileHelper.GetValue("保存", "14", filename);
                    s15.Text = IniFileHelper.GetValue("保存", "15", filename);
                    s16.Text = IniFileHelper.GetValue("保存", "16", filename);
                    s17.Text = IniFileHelper.GetValue("保存", "17", filename);
                    s18.Text = IniFileHelper.GetValue("保存", "18", filename);
                    s19.Text = IniFileHelper.GetValue("保存", "19", filename);
                    s20.Text = IniFileHelper.GetValue("保存", "20", filename);
                    s21.Text = IniFileHelper.GetValue("保存", "21", filename);
                    s22.Text = IniFileHelper.GetValue("保存", "22", filename);
                    s23.Text = IniFileHelper.GetValue("保存", "23", filename);
                    s24.Text = IniFileHelper.GetValue("保存", "24", filename);
                    s25.Text = IniFileHelper.GetValue("保存", "25", filename);
                    s26.Text = IniFileHelper.GetValue("保存", "26", filename);
                    s27.Text = IniFileHelper.GetValue("保存", "27", filename);
                    s28.Text = IniFileHelper.GetValue("保存", "28", filename);
                    s29.Text = IniFileHelper.GetValue("保存", "29", filename);
                    s30.Text = IniFileHelper.GetValue("保存", "30", filename);
                    s31.Text = IniFileHelper.GetValue("保存", "31", filename);
                    s32.Text = IniFileHelper.GetValue("保存", "32", filename);
                    s33.Text = IniFileHelper.GetValue("保存", "33", filename);
                    s34.Text = IniFileHelper.GetValue("保存", "34", filename);
                    s35.Text = IniFileHelper.GetValue("保存", "35", filename);
                    s36.Text = IniFileHelper.GetValue("保存", "36", filename);
                    s37.Text = IniFileHelper.GetValue("保存", "37", filename);
                    s38.Text = IniFileHelper.GetValue("保存", "38", filename);
                    s39.Text = IniFileHelper.GetValue("保存", "39", filename);
                    s40.Text = IniFileHelper.GetValue("保存", "40", filename);
                    s41.Text = IniFileHelper.GetValue("保存", "41", filename);
                    s42.Text = IniFileHelper.GetValue("保存", "42", filename);
                    s43.Text = IniFileHelper.GetValue("保存", "43", filename);
                    s44.Text = IniFileHelper.GetValue("保存", "44", filename);
                    s45.Text = IniFileHelper.GetValue("保存", "45", filename);
                    s46.Text = IniFileHelper.GetValue("保存", "46", filename);
                    s47.Text = IniFileHelper.GetValue("保存", "47", filename);
                    s48.Text = IniFileHelper.GetValue("保存", "48", filename);
                    s49.Text = IniFileHelper.GetValue("保存", "49", filename);
                    s50.Text = IniFileHelper.GetValue("保存", "50", filename);
                    s51.Text = IniFileHelper.GetValue("保存", "51", filename);
                    s52.Text = IniFileHelper.GetValue("保存", "52", filename);
                    s53.Text = IniFileHelper.GetValue("保存", "53", filename);
                    s54.Text = IniFileHelper.GetValue("保存", "54", filename);
                    s55.Text = IniFileHelper.GetValue("保存", "55", filename);
                    s56.Text = IniFileHelper.GetValue("保存", "56", filename);
                    s57.Text = IniFileHelper.GetValue("保存", "57", filename);
                    s58.Text = IniFileHelper.GetValue("保存", "58", filename);
                    s59.Text = IniFileHelper.GetValue("保存", "59", filename);
                    s60.Text = IniFileHelper.GetValue("保存", "60", filename);
                    s61.Text = IniFileHelper.GetValue("保存", "61", filename);
                    s62.Text = IniFileHelper.GetValue("保存", "62", filename);
                    s63.Text = IniFileHelper.GetValue("保存", "63", filename);
                    s64.Text = IniFileHelper.GetValue("保存", "64", filename);
                    s65.Text = IniFileHelper.GetValue("保存", "65", filename);
                    s66.Text = IniFileHelper.GetValue("保存", "66", filename);
                    s67.Text = IniFileHelper.GetValue("保存", "67", filename);
                    s68.Text = IniFileHelper.GetValue("保存", "68", filename);
                    s69.Text = IniFileHelper.GetValue("保存", "69", filename);
                    s70.Text = IniFileHelper.GetValue("保存", "70", filename);
                    s71.Text = IniFileHelper.GetValue("保存", "71", filename);
                    s72.Text = IniFileHelper.GetValue("保存", "72", filename);
                    s73.Text = IniFileHelper.GetValue("保存", "73", filename);
                    s74.Text = IniFileHelper.GetValue("保存", "74", filename);
                    s75.Text = IniFileHelper.GetValue("保存", "75", filename);
                    s76.Text = IniFileHelper.GetValue("保存", "76", filename);
                    s77.Text = IniFileHelper.GetValue("保存", "77", filename);
                    s78.Text = IniFileHelper.GetValue("保存", "78", filename);
                    s79.Text = IniFileHelper.GetValue("保存", "79", filename);
                    s80.Text = IniFileHelper.GetValue("保存", "80", filename);
                    s81.Text = IniFileHelper.GetValue("保存", "81", filename);

                }

                else
                {
                    this.ShowMessageAsync("错误", "这可能不是一个无尽贪婪保存文件");
                }
            }
            else
            {
                this.ShowMessageAsync("警告", "打开失败请重试");
            }
        }

        private void Tile_Click_1(object sender, RoutedEventArgs e)
        {
            this.ShowMessageAsync("提示","施工中...");
        }

        private void Jcgx_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.mcbbs.net/thread-894290-1-1.html");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            r1.Text = "";
            r2.Text = "";
            r3.Text = "";
            r4.Text = "";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (d1.IsChecked == false)
            {
                kztsc.Text = "mods.thermalexpansion.Crucible.addRecipe(" + r1.Text + "," + r2.Text + "," + r3.Text + "*" + r4.Text + ");";
            }
            else
            {
                kztsc.Text = "mods.thermalexpansion.Crucible.removeRecipe(" + r2.Text + ");";
            }
        }

        private void 无序_Copy_IsCheckedChanged(object sender, EventArgs e)
        {
            if (d1.IsChecked == true)
            {
                r1.IsEnabled = false;
                r3.IsEnabled = false;
                r4.IsEnabled = false;
            }
            else
            {
                r1.IsEnabled = true;
                r3.IsEnabled = true;
                r4.IsEnabled = true;
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            string ml = System.Windows.Forms.Application.StartupPath + @"\projects\热力膨胀\熔岩炉";
            string filename = "";
            //创建一个保存文件式的对话框
            SaveFileDialog sfd = new SaveFileDialog();
            //设置这个对话框的起始保存路径
            sfd.InitialDirectory = ml;
            //设置保存的文件的类型，注意过滤器的语法
            sfd.Filter = "mot tools 2保存文件|*.mt2save";
            //调用ShowDialog()方法显示该对话框，该方法的返回值代表用户是否点击了确定按钮
            if (sfd.ShowDialog() == true)
            {
                filename = sfd.FileName;
                if (!File.Exists(filename))
                { 
                       using (File.Create(filename)) { };
                }
                IniFileHelper.SetValue("保存", "类型", "热力膨胀_熔岩炉", filename);
                IniFileHelper.SetValue("保存", "1", r1.Text, filename);
                IniFileHelper.SetValue("保存", "2", r2.Text, filename);
                IniFileHelper.SetValue("保存", "3", r3.Text, filename);
                IniFileHelper.SetValue("保存", "4", r4.Text, filename);
                if (d1.IsChecked == true)
                {
                    IniFileHelper.SetValue("保存", "删除", "1", filename);
                }
                else
                {
                    IniFileHelper.SetValue("保存", "删除", "0", filename);
                }
                this.ShowMessageAsync("提示", "保存成功");
            }
            else
            {
                this.ShowMessageAsync("警告", "保存失败请重试");
            }
        }

        private void Open1_Click(object sender, RoutedEventArgs e)
        {
            string filename = "";
            string ml = System.Windows.Forms.Application.StartupPath + @"\projects\无尽贪婪";
            //创建一个打开文件式的对话框
            OpenFileDialog ofd = new OpenFileDialog();
            //设置这个对话框的起始打开路径
            ofd.InitialDirectory = ml;
            //设置打开的文件的类型，注意过滤器的语法
            ofd.Filter = "mot tools 2保存文件|*.mt2save";
            if (ofd.ShowDialog() == true)
            {
                filename = ofd.FileName;
                if (IniFileHelper.GetValue("保存", "类型", filename) == "热力膨胀_熔岩炉")
                {
                    r1.Text = IniFileHelper.GetValue("保存", "1", filename);
                    r2.Text = IniFileHelper.GetValue("保存", "2", filename);
                    r3.Text = IniFileHelper.GetValue("保存", "3", filename);
                    r4.Text = IniFileHelper.GetValue("保存", "4", filename);
                    if (IniFileHelper.GetValue("保存", "删除", filename) == "1")
                    {
                        d1.IsChecked = true;
                    }
                    else
                    {
                        d1.IsChecked = false;
                    }
                }
                else
                {
                    this.ShowMessageAsync("错误", "这可能不是一个热力膨胀_熔岩炉保存文件");
                }
            }
            else
            {
                this.ShowMessageAsync("警告", "打开失败请重试");
            }
        }

        private void Tips_part_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tips_part.SelectedIndex == 0)
            {
                tips_part.BannerText = "小贴士qwq";
            }
            if (tips_part.SelectedIndex == 1)
            {
                tips_part.BannerText = "关于软件";
            }
            if (tips_part.SelectedIndex == 3)
            {
                tips_part.BannerText = "赞助作者";
            }
        }

        private void Tips_part_MouseEnter(object sender, MouseEventArgs e)
        {
            sfjc_tip1 = "1";
        }

        private void Tips_part_MouseLeave(object sender, MouseEventArgs e)
        {
            sfjc_tip1 = "0";
        }

        private void Clear1_无尽贪婪_Click(object sender, RoutedEventArgs e)
        {
            z1_无尽贪婪.Text = "";
            z2_无尽贪婪.Text = "";
            z3_无尽贪婪.Text = "";
        }

        private void Output1_无尽贪婪_Click(object sender, RoutedEventArgs e)
        {
            kztsc.Text = "mods.avaritia.Compressor.add(" + z1_无尽贪婪.Text + "," + z2_无尽贪婪.Text + "," + z3_无尽贪婪.Text + ");";
        }

        private void Save1_无尽贪婪_Click(object sender, RoutedEventArgs e)
        {
            string ml = System.Windows.Forms.Application.StartupPath + @"\projects\无尽贪婪\中子态素压缩机";
            string filename = "";
            //创建一个保存文件式的对话框
            SaveFileDialog sfd = new SaveFileDialog();
            //设置这个对话框的起始保存路径
            sfd.InitialDirectory = ml;
            //设置保存的文件的类型，注意过滤器的语法
            sfd.Filter = "mot tools 2保存文件|*.mt2save";
            //调用ShowDialog()方法显示该对话框，该方法的返回值代表用户是否点击了确定按钮
            if (sfd.ShowDialog() == true)
            {
                filename = sfd.FileName;
                if (!File.Exists(filename))
                {
                    using (File.Create(filename)) { };
                }
                IniFileHelper.SetValue("保存", "类型", "无尽贪婪_压缩", filename);
                IniFileHelper.SetValue("保存", "z1",z1_无尽贪婪.Text, filename);
                IniFileHelper.SetValue("保存", "z2", z2_无尽贪婪.Text, filename);
                IniFileHelper.SetValue("保存", "z3", z3_无尽贪婪.Text, filename);

                //这里是主要执存的代码

                this.ShowMessageAsync("提示", "保存成功");
            }
            else
            {
                this.ShowMessageAsync("警告", "保存失败请重试");
            }
        }

        private void Open2_无尽贪婪_Click(object sender, RoutedEventArgs e)
        {
            string filename = "";
            string ml = System.Windows.Forms.Application.StartupPath + @"\projects\无尽贪婪\中子态素压缩机";
            //创建一个打开文件式的对话框
            OpenFileDialog ofd = new OpenFileDialog();
            //设置这个对话框的起始打开路径
            ofd.InitialDirectory = ml;
            //设置打开的文件的类型，注意过滤器的语法
            ofd.Filter = "mot tools 2保存文件|*.mt2save";
            if (ofd.ShowDialog() == true)
            {
                filename = ofd.FileName;
                if (IniFileHelper.GetValue("保存", "类型", filename)== "无尽贪婪_压缩")
                {
                    z1_无尽贪婪.Text = IniFileHelper.GetValue("保存", "z1",filename);
                    z2_无尽贪婪.Text = IniFileHelper.GetValue("保存", "z2",filename);
                    z3_无尽贪婪.Text = IniFileHelper.GetValue("保存", "z3", filename);
                }
                else
                {
                    this.ShowMessageAsync("错误", "这可能不是一个无尽贪婪_压缩的保存文件");
                }
                //这里是主要执存的代码


            }
            else
            {
                this.ShowMessageAsync("警告", "打开失败请重试");
            }
        }

        private void Tile_Click_2(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://shang.qq.com/wpa/qunwpa?idkey=632a3d1b055a2ed3c814d2d89defb2d082156294dac55be7964fbfbbfc6e31e7");
        }

        private void D2_IsCheckedChanged(object sender, EventArgs e)
        {
            if (d2.IsChecked == true)
            {
                r5.IsEnabled = false;
                r6.IsEnabled = false;
            }
            else
            {
                r5.IsEnabled = true;
                r6.IsEnabled = true;
            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            if (d2.IsChecked == true)
            {
                kztsc.Text = "mods.thermalexpansion.Furnace.removeRecipe(" + r7.Text + ");";
            }
            else
            {
                kztsc.Text = "mods.thermalexpansion.Furnace.addRecipe(" + r5.Text + "," + r6.Text + "," + r7.Text + ");";
            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            r5.Text = "";
            r6.Text = "";
            r7.Text = "";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            string ml = System.Windows.Forms.Application.StartupPath + @"\projects\热力膨胀\红石炉";
            string filename = "";
            //创建一个保存文件式的对话框
            SaveFileDialog sfd = new SaveFileDialog();
            //设置这个对话框的起始保存路径
            sfd.InitialDirectory = ml;
            //设置保存的文件的类型，注意过滤器的语法
            sfd.Filter = "mot tools 2保存文件|*.mt2save";
            //调用ShowDialog()方法显示该对话框，该方法的返回值代表用户是否点击了确定按钮
            if (sfd.ShowDialog() == true)
            {
                filename = sfd.FileName;
                if (!File.Exists(filename))
                {
                    using (File.Create(filename)) { };
                }
                IniFileHelper.SetValue("保存", "类型", "热力膨胀_红石炉", filename);
                IniFileHelper.SetValue("保存", "r5",r5.Text, filename);
                IniFileHelper.SetValue("保存", "r6", r6.Text, filename);
                IniFileHelper.SetValue("保存", "r7", r7.Text, filename);
                //这里是主要执存的代码
                if(d2.IsChecked==true)
                {
                    IniFileHelper.SetValue("保存", "删除", "1", filename);
                }
                else
                {
                    IniFileHelper.SetValue("保存", "删除", "0", filename);
                }


                this.ShowMessageAsync("提示", "保存成功");
            }
            else
            {
                this.ShowMessageAsync("警告", "保存失败请重试");
            }
        }

        private void Open2_Click(object sender, RoutedEventArgs e)
        {
            string filename = "";
            string ml = System.Windows.Forms.Application.StartupPath + @"\projects\热力膨胀\红石炉";
            //创建一个打开文件式的对话框
            OpenFileDialog ofd = new OpenFileDialog();
            //设置这个对话框的起始打开路径
            ofd.InitialDirectory = ml;
            //设置打开的文件的类型，注意过滤器的语法
            ofd.Filter = "mot tools 2保存文件|*.mt2save";
            if (ofd.ShowDialog() == true)
            {
                filename = ofd.FileName;
                if (IniFileHelper.GetValue("保存", "类型", filename) == "热力膨胀_红石炉")
                {
                    r5.Text = IniFileHelper.GetValue("保存", "r5", filename);
                    r6.Text = IniFileHelper.GetValue("保存", "r6", filename);
                    r7.Text = IniFileHelper.GetValue("保存", "r7", filename);
                    if (IniFileHelper.GetValue("保存", "删除", filename) == "1")
                    {
                        d2.IsChecked = true;
                    }
                    else
                    {
                        d2.IsChecked = false;
                    }
                }
                else
                {
                    this.ShowMessageAsync("错误", "这可能不是一个热力膨胀_红石炉保存文件");
                }
            }
            else
            {
                this.ShowMessageAsync("警告", "打开失败请重试");
            }
        }

        public static string StringToUnicode(string value)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(value);
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < bytes.Length; i += 2)
            {
                // 取两个字符，每个字符都是右对齐。
                str.AppendFormat("/u{0}{1}", bytes[i + 1].ToString("x").PadLeft(2, '0'), bytes[i].ToString("x").PadLeft(2, '0'));
            }
            return str.ToString();
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            Clipboard.SetDataObject ( u_out1.Text);
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            u_out1.Text = StringToUnicode(wz_in1.Text);
        }

        private void T_是否自定义物品_IsCheckedChanged(object sender, EventArgs e)
        {
            if (t_是否自定义物品.IsChecked == true)
            {
                wbk_物品名字_高级物品编辑.IsEnabled = true;
            }
            else
            {
                wbk_物品名字_高级物品编辑.IsEnabled = false;
            }
        }

        private void T_是否自定义物品lore_IsCheckedChanged(object sender, EventArgs e)
        {
            if (t_是否自定义物品lore.IsChecked == true)
            {
                wbk_物品lore_高级物品编辑.IsEnabled = true;
            }
            else
            {
                wbk_物品lore_高级物品编辑.IsEnabled = false;
            }
        }

        private void Button_高级物品编辑输出_Click(object sender, RoutedEventArgs e)
        {
            wbk_高级物品编辑_输出.Text = wz_in2.Text;
            if(t_是否忽略附加值.IsChecked==true)
            {
                if(wz_in2.Text.Contains(":*>")==false)
                {
                    wz_in2.Text = wz_in2.Text = wz_in2.Text.Replace(">", ":*>");
                }
                wbk_高级物品编辑_输出.Text = wz_in2.Text;
            }
            if (t_是否自定义物品.IsChecked == true)
            {
                wbk_高级物品编辑_输出.Text= wz_in2.Text + ".withTag({display: {" + "Name:" + '"' +StringToUnicode( wbk_物品名字_高级物品编辑.Text )+ '"' + ',';
                if (t_是否自定义物品lore.IsChecked == true)
                {
                    // 获取文本框文本根据换行符分割成字符串数组
                    int line = wbk_物品lore_高级物品编辑.LineCount;
                    string lore = "";


                    for (int l = 0; l < line; l = l + 1)
                    {
                        if (l == line - 1)
                        {
                            lore += '"' + StringToUnicode(wbk_物品lore_高级物品编辑.GetLineText(l).Replace(Environment.NewLine, "")) + '"';
                        }
                        else
                        {
                            lore += '"' + StringToUnicode(wbk_物品lore_高级物品编辑.GetLineText(l).Replace(Environment.NewLine, "")) + '"' + ',';
                        }
                    }
                    lore = lore.Replace(Environment.NewLine, "");
                    wbk_高级物品编辑_输出.Text += "Lore: [" +lore + "]}})";
                }
                else
                {
                    wbk_高级物品编辑_输出.Text = wz_in2.Text + ".withTag({display: {" + "Name:" + '"' + StringToUnicode(wbk_物品名字_高级物品编辑.Text) + "}})";
                }
            }
            else
            {
                if (t_是否自定义物品lore.IsChecked == true)
                {
                    // 获取文本框文本根据换行符分割成字符串数组
                    int line = wbk_物品lore_高级物品编辑.LineCount;
                    string lore = "";


                    for (int l = 0; l < line; l = l + 1)
                    {
                        if (l == line - 1)
                        {
                            lore += '"' + StringToUnicode(wbk_物品lore_高级物品编辑.GetLineText(l).Replace(Environment.NewLine, "")) + '"';
                        }
                        else
                        {
                            lore += '"' + StringToUnicode(wbk_物品lore_高级物品编辑.GetLineText(l).Replace(Environment.NewLine, "")) + '"' + ',';
                        }
                    }
                    lore = lore.Replace(Environment.NewLine, "");
                    wbk_高级物品编辑_输出.Text =wz_in2.Text+ ".withTag({display: {"+ "Lore: [" + lore + "]}})";
                }
            }
            if (t_是否自定义物品lnbt.IsChecked == true)
            {
                wbk_高级物品编辑_输出.Text = wbk_高级物品编辑_输出.Text.Replace("})", "}") + wbk_物品nbt_高级物品编辑.Text + ")";
            }
            if (t_是否无视耐久.IsChecked == true)
            {
                wbk_高级物品编辑_输出.Text += ".anyDamage()";
                if (wbk_高级物品编辑_输出.Text == ".anyDamage()")
                {
                    wbk_高级物品编辑_输出.Text = wz_in2.Text + ".anyDamage()";
                }
            }
            if(t_是否限定nbt标签.IsChecked==true)
            {
                wbk_高级物品编辑_输出.Text = wbk_高级物品编辑_输出.Text.Replace("withTag", "onlyWithTag");
            }
            else
            {
                wbk_高级物品编辑_输出.Text = wbk_高级物品编辑_输出.Text.Replace("onlyWithTag", "withTag");
            }
            if(t_是否自定义耐久.IsChecked==true)
            {
                wbk_高级物品编辑_输出.Text += ".withDamage(" + wbk_自定义耐久.Text+")";
            }
            if(t_是否消耗耐久or转换物品.IsChecked==true)
            {
                wbk_高级物品编辑_输出.Text += ".transformDamage(" + wbk_消耗耐久.Text + ")";
            }
            if(t_是否限定耐久.IsChecked==true)
            {
                if(dx1.IsChecked==true)
                {
                    wbk_高级物品编辑_输出.Text += ".onlyDamageAtLeast(" + wbk_限定耐久.Text + ")";
                }
                if (dx2.IsChecked == true)
                {
                    wbk_高级物品编辑_输出.Text += ".onlyDamageAtMost(" + wbk_限定耐久.Text + ")";
                }
                if (dx3.IsChecked == true)
                {
                    wbk_高级物品编辑_输出.Text += ".onlyDamageBetween(" +wbk_限定耐久小于.Text+","+wbk_限定耐久大于.Text+ ")";
                }
            }
        }

        private void Button_高级物品编辑输出_Copy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetDataObject(wbk_高级物品编辑_输出.Text);
        }

        private void T_是否自定义物品lnbt_IsCheckedChanged(object sender, EventArgs e)
        {
            if (t_是否自定义物品lnbt.IsChecked == true)
            {
                wbk_物品nbt_高级物品编辑.IsEnabled = true;
            }
            else
            {
                wbk_物品nbt_高级物品编辑.IsEnabled = false;
            }

        }

        private void T_是否忽略附加值_IsCheckedChanged(object sender, EventArgs e)
        {
            if (t_是否忽略附加值.IsChecked == true)
            {
                wz_in2.Text= wz_in2.Text.Replace(">", ":*>");
            }
            else
            {
                wz_in2.Text = wz_in2.Text.Replace(":*>", ">");
            }
        }

        private void T_是否消耗耐久_IsCheckedChanged(object sender, EventArgs e)
        {
            if (t_是否消耗耐久or转换物品.IsChecked == true)
            {
                wbk_消耗耐久.IsEnabled = true;
            }
            else
            {
                wbk_消耗耐久.IsEnabled = false;
            }
        }

        private void T_是否自定义耐久_IsCheckedChanged(object sender, EventArgs e)
        {
            if (t_是否自定义耐久.IsChecked == true)
            {
                wbk_自定义耐久.IsEnabled = true;
            }
            else
            {
                wbk_自定义耐久.IsEnabled = false;
            }
        }

        private void T_是否限定耐久_IsCheckedChanged(object sender, EventArgs e)
        {
            if (t_是否限定耐久.IsChecked == true)
            {
                dx1.IsEnabled = true;
                dx2.IsEnabled = true;
                dx3.IsEnabled = true;
            }
            else
            {
                dx1.IsEnabled = false;
                dx2.IsEnabled = false;
                dx3.IsEnabled = false;
                wbk_限定耐久.IsEnabled = false;
                wbk_限定耐久大于.IsEnabled = false;
                wbk_限定耐久小于.IsEnabled = false;

            }
        }

        private void Dx1_Checked(object sender, RoutedEventArgs e)
        {
            wbk_限定耐久.IsEnabled = true;
            wbk_限定耐久大于.IsEnabled = false;
            wbk_限定耐久小于.IsEnabled = false;
        }

        private void Dx2_Checked(object sender, RoutedEventArgs e)
        {
            wbk_限定耐久.IsEnabled = true;
            wbk_限定耐久大于.IsEnabled = false;
            wbk_限定耐久小于.IsEnabled = false;
        }

        private void Dx3_Checked(object sender, RoutedEventArgs e)
        {
            wbk_限定耐久.IsEnabled = false;
            wbk_限定耐久大于.IsEnabled = true;
            wbk_限定耐久小于.IsEnabled = true;
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            r_产物1_有机灌注级.Text = "";
            r_产物2_有机灌注级.Text = "";
            r_产物2产生几率_有机灌注级.Text = "";
            r_物品1输入_有机灌注机.Text = "";
            r_物品2输入_有机灌注机.Text = "";
            r_能量_有机灌注机.Text = "";

        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            if(d3.IsChecked==false)
            {
                kztsc.Text = "mods.thermalexpansion.Insolator.addRecipe(;" + r_能量_有机灌注机.Text + "," + r_物品1输入_有机灌注机.Text + "," + r_物品2输入_有机灌注机.Text + "," + r_产物1_有机灌注级.Text + "," + r_产物2_有机灌注级.Text + "," + r_产物2产生几率_有机灌注级.Text + ");";
            }
            else
            {
                kztsc.Text = "mods.thermalexpansion.Insolator.removeRecipe(" + r_产物1_有机灌注级.Text + "," + r_产物2_有机灌注级.Text + ");";
            }
            
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
              if(d4.IsChecked==false)
            {
                kztsc.Text = "mods.thermalexpansion.Pulverizer.addRecipe(" + r_能量_粉碎机.Text + "," + r_物品1输入_粉碎机.Text + "," + r_产物1_粉碎机.Text + "," + r_产物2_粉碎机.Text + "," + r_产物2几率_粉碎机.Text + ");";
            }
              else
            {
                kztsc.Text = "mods.thermalexpansion.Pulverizer.removeRecipe(" + r_物品1输入_粉碎机.Text + ");";
            }
            //mods.thermalexpansion.Pulverizer.addRecipe(3000, <minecraft:flint_and_steel>, <minecraft:flint>, <minecraft:iron_ingot>, 80);

            //粉碎物品需要的RF能，输入被粉碎的物品ID，输出粉碎产物1ID，输出粉碎产物2ID，生成粉碎产物2的几率
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {

            r_物品1输入_粉碎机.Text = "";
            r_能量_粉碎机.Text = "";
            r_产物1_粉碎机.Text = "";
            r_产物2_粉碎机.Text = "";
            r_产物2几率_粉碎机.Text = "";

        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            string ml = System.Windows.Forms.Application.StartupPath + @"\projects\热力膨胀\有机灌注机";
            string filename = "";
            //创建一个保存文件式的对话框
            SaveFileDialog sfd = new SaveFileDialog();
            //设置这个对话框的起始保存路径
            sfd.InitialDirectory = ml;
            //设置保存的文件的类型，注意过滤器的语法
            sfd.Filter = "mot tools 2保存文件|*.mt2save";
            //调用ShowDialog()方法显示该对话框，该方法的返回值代表用户是否点击了确定按钮
            if (sfd.ShowDialog() == true)
            {
                filename = sfd.FileName;
                if (!File.Exists(filename))
                {
                    using (File.Create(filename)) { };
                }

                IniFileHelper.SetValue("保存", "类型", "热力膨胀_有机灌注机", filename);
                if(d3.IsChecked==true)
                {
                    IniFileHelper.SetValue("保存", "删除", "1", filename);
                }
                else
                {
                    IniFileHelper.SetValue("保存", "删除", "0", filename);
                }
                IniFileHelper.SetValue("保存","能量",r_能量_有机灌注机.Text,filename);
                IniFileHelper.SetValue("保存", "产物1", r_产物1_有机灌注级.Text, filename);
                IniFileHelper.SetValue("保存", "产物2", r_产物2_有机灌注级.Text, filename);
                IniFileHelper.SetValue("保存", "产物2几率", r_产物2产生几率_有机灌注级.Text, filename);
                IniFileHelper.SetValue("保存", "输入物品1", r_物品1输入_有机灌注机.Text, filename);
                IniFileHelper.SetValue("保存", "输入物品2", r_物品2输入_有机灌注机.Text, filename);
                //这里是主要执存的代码  
                this.ShowMessageAsync("提示", "保存成功");
            }
            else
            {
                this.ShowMessageAsync("警告", "保存失败请重试");
            }
        }

        private void Open3_Click(object sender, RoutedEventArgs e)
        {
            string filename = "";
            string ml = System.Windows.Forms.Application.StartupPath + @"\projects\热力膨胀\有机灌注机";
            //创建一个打开文件式的对话框
            OpenFileDialog ofd = new OpenFileDialog();
            //设置这个对话框的起始打开路径
            ofd.InitialDirectory = ml;
            //设置打开的文件的类型，注意过滤器的语法
            ofd.Filter = "mot tools 2保存文件|*.mt2save";
            if (ofd.ShowDialog() == true)
            {
                filename = ofd.FileName;
                //这里是主要执存的代码
                if(IniFileHelper.GetValue("保存", "类型",filename)== "热力膨胀_有机灌注机")
                {
                    this.ShowMessageAsync("提示", "这玩意儿还没弄好");
                    // IniFileHelper.GetValue();
                }
                else
                {
                    this.ShowMessageAsync("错误", "这可能不是一个热力膨胀_有机灌注机保存文件");
                }
                


            }
            else
            {
                this.ShowMessageAsync("警告", "打开失败请重试");
            }
        }
    }
}
/*保存模板
 string ml = System.Windows.Forms.Application.StartupPath + @"文件路径";
            string filename = "";
            //创建一个保存文件式的对话框
            SaveFileDialog sfd = new SaveFileDialog();
            //设置这个对话框的起始保存路径
            sfd.InitialDirectory = ml;
            //设置保存的文件的类型，注意过滤器的语法
            sfd.Filter = "mot tools 2保存文件|*.mt2save";
            //调用ShowDialog()方法显示该对话框，该方法的返回值代表用户是否点击了确定按钮
            if (sfd.ShowDialog() == true)
            {
                filename = sfd.FileName;
                if (!File.Exists(filename))
                { 
                       using (File.Create(filename)) { };
                }


               //这里是主要执存的代码


             
                this.ShowMessageAsync("提示", "保存成功");
            }
            else
            {
                this.ShowMessageAsync("警告", "保存失败请重试");
            }

    打开模板
            string filename = "";
            string ml = System.Windows.Forms.Application.StartupPath + @"\projects\无尽贪婪";
            //创建一个打开文件式的对话框
            OpenFileDialog ofd = new OpenFileDialog();
            //设置这个对话框的起始打开路径
            ofd.InitialDirectory = ml;
            //设置打开的文件的类型，注意过滤器的语法
            ofd.Filter = "mot tools 2保存文件|*.mt2save";
            if (ofd.ShowDialog() == true)
            {
                filename = ofd.FileName;

                //这里是主要执存的代码


            }
            else
            {
                this.ShowMessageAsync("警告", "打开失败请重试");
            }
*/
