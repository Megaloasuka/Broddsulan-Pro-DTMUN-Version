namespace BroddsúlanPro
{
    using BroddsúlanPro.My;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class PanelsExpanding
    {
        public static void dockPanels()
        {
            MyProject.Forms.Form1.panel_sidebar_timer.Dock = DockStyle.Top;
            MyProject.Forms.Form1.panel_umc.Dock = DockStyle.Top;
            MyProject.Forms.Form1.panel_mc.Dock = DockStyle.Top;
            MyProject.Forms.Form1.panel_mcedit.Dock = DockStyle.Bottom;
            MyProject.Forms.Form1.panel_welcome.Dock = DockStyle.Fill;
            MyProject.Forms.Form1.panel_sidebar_starting.Dock = DockStyle.Fill;
            MyProject.Forms.Form1.panel_spakers_list.Dock = DockStyle.Fill;
            MyProject.Forms.Form1.panel_motion.Dock = DockStyle.Fill;
            MyProject.Forms.Form1.panel_files.Dock = DockStyle.Fill;
            MyProject.Forms.Form1.panel_misc.Dock = DockStyle.Fill;
            MyProject.Forms.Form1.panel_system.Dock = DockStyle.Fill;
            MyProject.Forms.Form1.WebBrowser1.Dock = DockStyle.Fill;
            MyProject.Forms.Form1.panel_readfile.Dock = DockStyle.Top;
            MyProject.Forms.Form1.panel_dbq.Dock = DockStyle.Top;
            MyProject.Forms.Form1.panel_main.Dock = DockStyle.Fill;
            MyProject.Forms.Form1.panel_manage.Dock = DockStyle.Fill;
            MyProject.Forms.Form1.panel_vote.Dock = DockStyle.Fill;
        }

        public static void flExpand(int selction)
        {
            int num3;
            Panel[] panelArray = new Panel[] { MyProject.Forms.Form1.panel_file_1, MyProject.Forms.Form1.panel_file_2, MyProject.Forms.Form1.panel_files_3, MyProject.Forms.Form1.panel_files_4, MyProject.Forms.Form1.panel_files_5 };
            Panel[] panelArray2 = new Panel[] { MyProject.Forms.Form1.panel_f_1, MyProject.Forms.Form1.panel_f_2, MyProject.Forms.Form1.panel_f_3, MyProject.Forms.Form1.panel_f_4, MyProject.Forms.Form1.panel_f_5 };
            Button[] buttonArray = new Button[] { MyProject.Forms.Form1.btn_file_1, MyProject.Forms.Form1.btn_file_2, MyProject.Forms.Form1.btn_files_3, MyProject.Forms.Form1.btn_files_4, MyProject.Forms.Form1.btn_files_5 };
            if (selction == 0)
            {
                int index = 0;
                do
                {
                    panelArray[index].Height = MyProject.Forms.Form1.btn_motion_1.Height;
                    buttonArray[index].BackColor = MyProject.Forms.Form1.darkcolor;
                    index++;
                    num3 = 4;
                }
                while (index <= num3);
                MyProject.Forms.Form1.btn_file_ok.Visible = false;
            }
            else
            {
                int num2 = 0;
                do
                {
                    panelArray[num2].Height = 0;
                    num2++;
                    num3 = 4;
                }
                while (num2 <= num3);
                buttonArray[selction - 1].BackColor = MyProject.Forms.Form1.midcolor;
                panelArray[selction - 1].Height = buttonArray[selction - 1].Height + panelArray2[selction - 1].Height;
                if (selction == 1)
                {
                    MyProject.Forms.Form1.signatories();
                }
                MyProject.Forms.Form1.btn_file_ok.Visible = true;
            }
        }

        public static void mcExpand(int selction)
        {
            int num5;
            int[] numArray = new int[] { 0, 0, 1, 2, 3, 3, 1, 4, 4, 5 };
            Panel[] panelArray = new Panel[] { MyProject.Forms.Form1.panel_motions_1, MyProject.Forms.Form1.panel_motions_2, MyProject.Forms.Form1.panel_motions_3, MyProject.Forms.Form1.panel_motion_4, MyProject.Forms.Form1.panel_motion_5, MyProject.Forms.Form1.panel_motion_6 };
            Panel[] panelArray2 = new Panel[] { MyProject.Forms.Form1.panel_m_1, MyProject.Forms.Form1.panel_m_2, MyProject.Forms.Form1.panel_m_3, MyProject.Forms.Form1.panel_m_4, MyProject.Forms.Form1.panel_m_5, MyProject.Forms.Form1.panel_m_6 };
            Button[] buttonArray = new Button[] { MyProject.Forms.Form1.btn_motion_1, MyProject.Forms.Form1.btn_motion_2, MyProject.Forms.Form1.btn_motion_3, MyProject.Forms.Form1.btn_motion_4, MyProject.Forms.Form1.btn_motion_5, MyProject.Forms.Form1.btn_motion_6, MyProject.Forms.Form1.btn_motion_7, MyProject.Forms.Form1.btn_motion_8, MyProject.Forms.Form1.btn_motion_9 };
            if (selction == 0)
            {
                int index = 0;
                do
                {
                    panelArray[index].Height = MyProject.Forms.Form1.btn_motion_1.Height;
                    buttonArray[index].BackColor = MyProject.Forms.Form1.darkcolor;
                    index++;
                    num5 = 5;
                }
                while (index <= num5);
                int num2 = 6;
                do
                {
                    buttonArray[num2].BackColor = MyProject.Forms.Form1.darkcolor;
                    num2++;
                    num5 = 8;
                }
                while (num2 <= num5);
                MyProject.Forms.Form1.btn_motion_2.Text = "自由磋商";
                MyProject.Forms.Form1.btn_motion_4.Text = "调整投票顺序";
                MyProject.Forms.Form1.btn_motion_7.Text = "结束辩论";
                MyProject.Forms.Form1.Label99.Text = "优先对 　　　　　　　　　　投票";
                MyProject.Forms.Form1.btn_motion_5.Visible = true;
                MyProject.Forms.Form1.btn_motion_6.Visible = true;
                MyProject.Forms.Form1.btn_motion_8.Visible = true;
                MyProject.Forms.Form1.btn_motion_finish.Visible = false;
            }
            else
            {
                int num3 = 0;
                do
                {
                    panelArray[num3].Height = 0;
                    num3++;
                    num5 = 5;
                }
                while (num3 <= num5);
                switch (selction)
                {
                    case 5:
                    case 6:
                    case 8:
                        buttonArray[numArray[selction]].BackColor = MyProject.Forms.Form1.midcolor;
                        panelArray[numArray[selction]].Height = buttonArray[numArray[selction]].Height + panelArray2[numArray[selction]].Height;
                        break;

                    default:
                        buttonArray[selction - 1].BackColor = MyProject.Forms.Form1.midcolor;
                        panelArray[numArray[selction]].Height = buttonArray[selction - 1].Height + panelArray2[numArray[selction]].Height;
                        break;
                }
                if (selction == 5)
                {
                    MyProject.Forms.Form1.Label99.Text = "对文件 　　　　　　　　　　投票";
                    MyProject.Forms.Form1.btn_motion_4.Text = "对文件投票";
                }
                if (selction == 6)
                {
                    MyProject.Forms.Form1.btn_motion_2.Text = "开始茶歇";
                }
                if (selction == 7)
                {
                    panelArray[numArray[selction]].Height = buttonArray[selction].Height;
                }
                if (selction == 8)
                {
                    MyProject.Forms.Form1.btn_motion_7.Text = "休会";
                    MyProject.Forms.Form1.btn_motion_7.BackColor = MyProject.Forms.Form1.midcolor;
                }
                MyProject.Forms.Form1.btn_motion_5.Visible = false;
                MyProject.Forms.Form1.btn_motion_6.Visible = false;
                MyProject.Forms.Form1.btn_motion_8.Visible = false;
                MyProject.Forms.Form1.btn_motion_finish.Visible = true;
            }
        }

        public static void miscCollapse(int fonction)
        {
            int num3;
            Panel[] panelArray = new Panel[] { MyProject.Forms.Form1.panel_misc_1, MyProject.Forms.Form1.panel_misc_2, MyProject.Forms.Form1.panel_misc_3, MyProject.Forms.Form1.panel_misc_5 };
            Panel[] panelArray2 = new Panel[] { MyProject.Forms.Form1.panel_ms_1, MyProject.Forms.Form1.panel_ms_2, MyProject.Forms.Form1.panel_ms_3, MyProject.Forms.Form1.panel_ms_5 };
            Button[] buttonArray = new Button[] { MyProject.Forms.Form1.btn_misc_1, MyProject.Forms.Form1.btn_misc_2, MyProject.Forms.Form1.btn_misc_3, MyProject.Forms.Form1.btn_misc_5 };
            if (fonction == 0)
            {
                int index = 0;
                do
                {
                    panelArray[index].Height = MyProject.Forms.Form1.btn_motion_1.Height;
                    buttonArray[index].BackColor = MyProject.Forms.Form1.darkcolor;
                    index++;
                    num3 = 3;
                }
                while (index <= num3);
                MyProject.Forms.Form1.btn_misc_4.Visible = true;
                MyProject.Forms.Form1.btn_misc_ok.Visible = false;
            }
            else
            {
                int num2 = 0;
                do
                {
                    panelArray[num2].Height = 0;
                    num2++;
                    num3 = 3;
                }
                while (num2 <= num3);
                buttonArray[fonction - 1].BackColor = MyProject.Forms.Form1.midcolor;
                panelArray[fonction - 1].Height = buttonArray[fonction - 1].Height + panelArray2[fonction - 1].Height;
                MyProject.Forms.Form1.btn_misc_ok.Visible = true;
                MyProject.Forms.Form1.btn_misc_4.Visible = false;
            }
        }

        public static void readPaneHeight(bool isIntro)
        {
            if (isIntro)
            {
                MyProject.Forms.Form1.panel_introtask.Top = (MyProject.Forms.Form1.lbl_fileinfo.Top + MyProject.Forms.Form1.lbl_fileinfo.Height) + (MyProject.Forms.Form1.lbl_fileinfo.Margin.Top * 2);
                MyProject.Forms.Form1.btn_read_close.Top = (MyProject.Forms.Form1.panel_introtask.Top + MyProject.Forms.Form1.panel_introtask.Height) + (MyProject.Forms.Form1.Label192.Margin.Top * 2);
                MyProject.Forms.Form1.panel_introtask.Visible = true;
            }
            else
            {
                MyProject.Forms.Form1.btn_read_close.Top = (MyProject.Forms.Form1.lbl_fileinfo.Top + MyProject.Forms.Form1.lbl_fileinfo.Height) + (MyProject.Forms.Form1.lbl_fileinfo.Margin.Top * 2);
                MyProject.Forms.Form1.panel_introtask.Visible = false;
            }
            MyProject.Forms.Form1.panel_readfile.Height = (MyProject.Forms.Form1.btn_read_close.Height + MyProject.Forms.Form1.btn_read_close.Top) + (MyProject.Forms.Form1.btn_read_close.Margin.Top * 2);
        }

        public static void taskbarUnslect()
        {
            MyProject.Forms.Form1.panel_sidebar_starting.Visible = false;
            MyProject.Forms.Form1.panel_sidebar_timer.Visible = false;
            MyProject.Forms.Form1.panel_spakers_list.Visible = false;
            MyProject.Forms.Form1.tlp_screenlist.Visible = false;
            MyProject.Forms.Form1.panel_motion.Visible = false;
            MyProject.Forms.Form1.panel_files.Visible = false;
            MyProject.Forms.Form1.panel_misc.Visible = false;
            MyProject.Forms.Form1.panel_system.Visible = false;
            MyProject.Forms.Form1.tlp_taskbar2.Visible = false;
            MyProject.Forms.Form1.timingStatus = "";
            MyProject.Forms.Form1.btn_sessionstart.BackColor = Color.White;
            MyProject.Forms.Form1.btn_sessionstart.ForeColor = Color.Black;
            MyProject.Forms.Form1.btn_speakerslist.BackColor = Color.White;
            MyProject.Forms.Form1.btn_speakerslist.ForeColor = Color.Black;
            MyProject.Forms.Form1.btn_motions.BackColor = Color.White;
            MyProject.Forms.Form1.btn_motions.ForeColor = Color.Black;
            MyProject.Forms.Form1.btn_file.BackColor = Color.White;
            MyProject.Forms.Form1.btn_file.ForeColor = Color.Black;
            MyProject.Forms.Form1.btn_misc.BackColor = Color.White;
            MyProject.Forms.Form1.btn_misc.ForeColor = Color.Black;
            MyProject.Forms.Form1.btn_system.BackColor = Color.White;
            MyProject.Forms.Form1.btn_system.ForeColor = Color.Black;
        }

        public static void unlockTaskbar()
        {
            taskbarUnslect();
            MyProject.Forms.Form1.lblcount.Text = "00:00";
            MyProject.Forms.Form1.lblcount.ForeColor = Color.White;
            MyProject.Forms.Form1.tlp_taskbar.Enabled = true;
            MyProject.Forms.Form1.numtime.Enabled = true;
        }
    }
}

