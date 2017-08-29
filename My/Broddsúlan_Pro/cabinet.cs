namespace BroddsúlanPro
{
    using BroddsúlanPro.My;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class cabinet : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        [AccessedThroughProperty("Cancel_Button")]
        private Button _Cancel_Button;
        [AccessedThroughProperty("CheckBox1")]
        private CheckBox _CheckBox1;
        [AccessedThroughProperty("DateTimePicker1")]
        private DateTimePicker _DateTimePicker1;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("LinkLabel1")]
        private LinkLabel _LinkLabel1;
        [AccessedThroughProperty("numhh")]
        private NumericUpDown _numhh;
        [AccessedThroughProperty("nummm")]
        private NumericUpDown _nummm;
        [AccessedThroughProperty("OK_Button")]
        private Button _OK_Button;
        [AccessedThroughProperty("TableLayoutPanel1")]
        private TableLayoutPanel _TableLayoutPanel1;
        [AccessedThroughProperty("TextBox1")]
        private TextBox _TextBox1;
        [AccessedThroughProperty("TrackBar1")]
        private TrackBar _TrackBar1;
        private IContainer components;
        private int[] x;

        public cabinet()
        {
            base.Load += new EventHandler(this.cabinet_Load);
            __ENCAddToList(this);
            this.x = new int[] { 1, 2, 3, 5, 10, 20, 30, 60, 120, 180, 360, 720, 0x5a0 };
            this.InitializeComponent();
        }

        [DebuggerNonUserCode]
        private static void __ENCAddToList(object value)
        {
            List<WeakReference> list = __ENCList;
            lock (list)
            {
                if (__ENCList.Count == __ENCList.Capacity)
                {
                    int index = 0;
                    int num3 = __ENCList.Count - 1;
                    for (int i = 0; i <= num3; i++)
                    {
                        WeakReference reference = __ENCList[i];
                        if (reference.IsAlive)
                        {
                            if (i != index)
                            {
                                __ENCList[index] = __ENCList[i];
                            }
                            index++;
                        }
                    }
                    __ENCList.RemoveRange(index, __ENCList.Count - index);
                    __ENCList.Capacity = __ENCList.Count;
                }
                __ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
            }
        }

        private void cabinet_Load(object sender, EventArgs e)
        {
            this.Top = 30;
            this.Left = 0x300;
            StreamReader reader = new StreamReader(@"config\clock.txt");
            this.CheckBox1.Checked = Conversions.ToBoolean(reader.ReadLine());
            DateTime timeValue = Conversions.ToDate(reader.ReadLine());
            this.TrackBar1.Value = Conversions.ToInteger(reader.ReadLine());
            reader.Close();
            if (!this.CheckBox1.Checked)
            {
                this.TrackBar1.Value = 0;
            }
            this.TextBox1.Text = Conversions.ToString(this.x[this.TrackBar1.Value]);
            if (!this.CheckBox1.Checked)
            {
                this.DateTimePicker1.Value = DateTime.Today;
                this.numhh.Value = new decimal(DateAndTime.Hour(DateAndTime.TimeOfDay));
                this.nummm.Value = new decimal(DateAndTime.Minute(DateAndTime.TimeOfDay));
            }
            else
            {
                this.DateTimePicker1.Value = timeValue;
                this.numhh.Value = new decimal(DateAndTime.Hour(timeValue));
                this.nummm.Value = new decimal(DateAndTime.Minute(timeValue));
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.CheckBox1.Checked)
            {
                this.Label1.Enabled = false;
                this.Label2.Enabled = false;
                this.Label3.Enabled = false;
                this.Label4.Enabled = false;
                this.Label5.Enabled = false;
                this.DateTimePicker1.Enabled = false;
                this.numhh.Enabled = false;
                this.nummm.Enabled = false;
                this.TrackBar1.Enabled = false;
                this.TextBox1.Enabled = false;
            }
            else
            {
                this.Label1.Enabled = true;
                this.Label2.Enabled = true;
                this.Label3.Enabled = true;
                this.Label4.Enabled = true;
                this.Label5.Enabled = true;
                this.DateTimePicker1.Enabled = true;
                this.numhh.Enabled = true;
                this.nummm.Enabled = true;
                this.TrackBar1.Enabled = true;
                this.TextBox1.Enabled = true;
            }
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (this.components != null))
                {
                    this.components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.TableLayoutPanel1 = new TableLayoutPanel();
            this.OK_Button = new Button();
            this.Cancel_Button = new Button();
            this.CheckBox1 = new CheckBox();
            this.DateTimePicker1 = new DateTimePicker();
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.numhh = new NumericUpDown();
            this.nummm = new NumericUpDown();
            this.Label3 = new Label();
            this.Label4 = new Label();
            this.TrackBar1 = new TrackBar();
            this.TextBox1 = new TextBox();
            this.Label5 = new Label();
            this.LinkLabel1 = new LinkLabel();
            this.TableLayoutPanel1.SuspendLayout();
            this.numhh.BeginInit();
            this.nummm.BeginInit();
            this.TrackBar1.BeginInit();
            this.SuspendLayout();
            this.TableLayoutPanel1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            Point point2 = new Point(0x59, 0xa7);
            this.TableLayoutPanel1.Location = point2;
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
            Size size2 = new Size(0x92, 0x1d);
            this.TableLayoutPanel1.Size = size2;
            this.TableLayoutPanel1.TabIndex = 0;
            this.OK_Button.Anchor = AnchorStyles.None;
            point2 = new Point(3, 3);
            this.OK_Button.Location = point2;
            this.OK_Button.Name = "OK_Button";
            size2 = new Size(0x43, 0x17);
            this.OK_Button.Size = size2;
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "确定";
            this.Cancel_Button.Anchor = AnchorStyles.None;
            this.Cancel_Button.DialogResult = DialogResult.Cancel;
            point2 = new Point(0x4c, 3);
            this.Cancel_Button.Location = point2;
            this.Cancel_Button.Name = "Cancel_Button";
            size2 = new Size(0x43, 0x17);
            this.Cancel_Button.Size = size2;
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "取消";
            this.CheckBox1.AutoSize = true;
            point2 = new Point(0x13, 0x16);
            this.CheckBox1.Location = point2;
            this.CheckBox1.Name = "CheckBox1";
            size2 = new Size(0x62, 0x11);
            this.CheckBox1.Size = size2;
            this.CheckBox1.TabIndex = 1;
            this.CheckBox1.Text = "启用内阁时钟";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.DateTimePicker1.Enabled = false;
            point2 = new Point(0x58, 0x2f);
            this.DateTimePicker1.Location = point2;
            this.DateTimePicker1.Name = "DateTimePicker1";
            size2 = new Size(0x90, 20);
            this.DateTimePicker1.Size = size2;
            this.DateTimePicker1.TabIndex = 2;
            this.Label1.AutoSize = true;
            this.Label1.Enabled = false;
            point2 = new Point(0x11, 0x35);
            this.Label1.Location = point2;
            this.Label1.Name = "Label1";
            size2 = new Size(0x3d, 13);
            this.Label1.Size = size2;
            this.Label1.TabIndex = 3;
            this.Label1.Text = "起始日期: ";
            this.Label2.AutoSize = true;
            this.Label2.Enabled = false;
            point2 = new Point(0x11, 0x52);
            this.Label2.Location = point2;
            this.Label2.Name = "Label2";
            size2 = new Size(0xd9, 13);
            this.Label2.Size = size2;
            this.Label2.TabIndex = 4;
            this.Label2.Text = "起始时间:　　　　　　　　时　　　 分";
            this.numhh.Enabled = false;
            point2 = new Point(0x7f, 0x4f);
            this.numhh.Location = point2;
            decimal num = new decimal(new int[] { 0x17, 0, 0, 0 });
            this.numhh.Maximum = num;
            this.numhh.Name = "numhh";
            size2 = new Size(0x22, 20);
            this.numhh.Size = size2;
            this.numhh.TabIndex = 5;
            this.nummm.Enabled = false;
            point2 = new Point(0xb6, 0x4f);
            this.nummm.Location = point2;
            num = new decimal(new int[] { 0x3b, 0, 0, 0 });
            this.nummm.Maximum = num;
            this.nummm.Name = "nummm";
            size2 = new Size(0x22, 20);
            this.nummm.Size = size2;
            this.nummm.TabIndex = 6;
            num = new decimal(new int[] { 0x3b, 0, 0, 0 });
            this.nummm.Value = num;
            this.Label3.AutoSize = true;
            this.Label3.Enabled = false;
            point2 = new Point(0x11, 0x72);
            this.Label3.Location = point2;
            this.Label3.Name = "Label3";
            size2 = new Size(0x22, 13);
            this.Label3.Size = size2;
            this.Label3.TabIndex = 7;
            this.Label3.Text = "倍率:";
            this.Label4.AutoSize = true;
            this.Label4.Enabled = false;
            point2 = new Point(0xd7, 0x72);
            this.Label4.Location = point2;
            this.Label4.Name = "Label4";
            size2 = new Size(0x13, 13);
            this.Label4.Size = size2;
            this.Label4.TabIndex = 9;
            this.Label4.Text = "倍";
            this.TrackBar1.Enabled = false;
            this.TrackBar1.LargeChange = 1;
            point2 = new Point(0x3a, 0x6d);
            this.TrackBar1.Location = point2;
            this.TrackBar1.Maximum = 12;
            this.TrackBar1.Name = "TrackBar1";
            size2 = new Size(0x72, 0x2d);
            this.TrackBar1.Size = size2;
            this.TrackBar1.TabIndex = 10;
            this.TextBox1.Enabled = false;
            point2 = new Point(0xb2, 0x6f);
            this.TextBox1.Location = point2;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.RightToLeft = RightToLeft.Yes;
            size2 = new Size(0x22, 20);
            this.TextBox1.Size = size2;
            this.TextBox1.TabIndex = 11;
            this.TextBox1.Text = "1";
            this.Label5.AutoSize = true;
            this.Label5.Enabled = false;
            point2 = new Point(0x3d, 0x8e);
            this.Label5.Location = point2;
            this.Label5.Name = "Label5";
            size2 = new Size(100, 13);
            this.Label5.Size = size2;
            this.Label5.TabIndex = 12;
            this.Label5.Text = "1分钟   1小时  1天";
            this.LinkLabel1.AutoSize = true;
            point2 = new Point(0x11, 0xae);
            this.LinkLabel1.Location = point2;
            this.LinkLabel1.Name = "LinkLabel1";
            size2 = new Size(0x43, 13);
            this.LinkLabel1.Size = size2;
            this.LinkLabel1.TabIndex = 13;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "查看倍率表";
            this.AcceptButton = this.OK_Button;
            SizeF ef2 = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef2;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            size2 = new Size(0xf7, 0xd0);
            this.ClientSize = size2;
            this.Controls.Add(this.LinkLabel1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.nummm);
            this.Controls.Add(this.numhh);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.TrackBar1);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cabinet";
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "内阁时钟";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.numhh.EndInit();
            this.nummm.EndInit();
            this.TrackBar1.EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyProject.Forms.Form1.lblmain.Text = "倍数—内阁时间/现实时间比例\r\n1x—1分钟/1分钟\r\n2x—2分钟/1分钟\r\n3x—3分钟/1分钟\r\n5x—5分钟/1分钟\r\n10x—10分钟/1分钟\r\n20x—20分钟/1分钟\r\n30x—30分钟/1分钟\r\n60x—1小时/1分钟\r\n120x—2小时/1分钟\r\n180x—3小时/1分钟\r\n360x—6小时/1分钟\r\n720x—12小时/1分钟\r\n1440x—1天/1分钟";
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            DateTime time = new DateTime(DateAndTime.Year(this.DateTimePicker1.Value), DateAndTime.Month(this.DateTimePicker1.Value), DateAndTime.Day(this.DateTimePicker1.Value), Convert.ToInt32(this.numhh.Value), Convert.ToInt32(this.nummm.Value), 0);
            StreamWriter writer = new StreamWriter(@"config\clock.txt");
            writer.WriteLine(this.CheckBox1.Checked);
            writer.WriteLine(time);
            writer.WriteLine(this.TrackBar1.Value);
            writer.Close();
            MyProject.Forms.Form1.cabingo();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            this.TextBox1.Text = Conversions.ToString(this.x[this.TrackBar1.Value]);
        }

        internal virtual Button Cancel_Button
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Cancel_Button;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Cancel_Button_Click);
                if (this._Cancel_Button != null)
                {
                    this._Cancel_Button.Click -= handler;
                }
                this._Cancel_Button = value;
                if (this._Cancel_Button != null)
                {
                    this._Cancel_Button.Click += handler;
                }
            }
        }

        internal virtual CheckBox CheckBox1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._CheckBox1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.CheckBox1_CheckedChanged);
                if (this._CheckBox1 != null)
                {
                    this._CheckBox1.CheckedChanged -= handler;
                }
                this._CheckBox1 = value;
                if (this._CheckBox1 != null)
                {
                    this._CheckBox1.CheckedChanged += handler;
                }
            }
        }

        internal virtual DateTimePicker DateTimePicker1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DateTimePicker1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._DateTimePicker1 = value;
            }
        }

        internal virtual Label Label1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label1 = value;
            }
        }

        internal virtual Label Label2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label2 = value;
            }
        }

        internal virtual Label Label3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label3 = value;
            }
        }

        internal virtual Label Label4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label4;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label4 = value;
            }
        }

        internal virtual Label Label5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label5;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Label5 = value;
            }
        }

        internal virtual LinkLabel LinkLabel1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._LinkLabel1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                LinkLabelLinkClickedEventHandler handler = new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
                if (this._LinkLabel1 != null)
                {
                    this._LinkLabel1.LinkClicked -= handler;
                }
                this._LinkLabel1 = value;
                if (this._LinkLabel1 != null)
                {
                    this._LinkLabel1.LinkClicked += handler;
                }
            }
        }

        internal virtual NumericUpDown numhh
        {
            [DebuggerNonUserCode]
            get
            {
                return this._numhh;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._numhh = value;
            }
        }

        internal virtual NumericUpDown nummm
        {
            [DebuggerNonUserCode]
            get
            {
                return this._nummm;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._nummm = value;
            }
        }

        internal virtual Button OK_Button
        {
            [DebuggerNonUserCode]
            get
            {
                return this._OK_Button;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.OK_Button_Click);
                if (this._OK_Button != null)
                {
                    this._OK_Button.Click -= handler;
                }
                this._OK_Button = value;
                if (this._OK_Button != null)
                {
                    this._OK_Button.Click += handler;
                }
            }
        }

        internal virtual TableLayoutPanel TableLayoutPanel1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TableLayoutPanel1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TableLayoutPanel1 = value;
            }
        }

        internal virtual TextBox TextBox1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TextBox1 = value;
            }
        }

        internal virtual TrackBar TrackBar1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TrackBar1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.TrackBar1_Scroll);
                if (this._TrackBar1 != null)
                {
                    this._TrackBar1.Scroll -= handler;
                }
                this._TrackBar1 = value;
                if (this._TrackBar1 != null)
                {
                    this._TrackBar1.Scroll += handler;
                }
            }
        }
    }
}

