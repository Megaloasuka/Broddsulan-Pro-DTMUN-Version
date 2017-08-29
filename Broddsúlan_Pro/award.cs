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
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class award : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        [AccessedThroughProperty("Cancel_Button")]
        private Button _Cancel_Button;
        [AccessedThroughProperty("cbx_mtype")]
        private ComboBox _cbx_mtype;
        [AccessedThroughProperty("CheckBox1")]
        private CheckBox _CheckBox1;
        [AccessedThroughProperty("CheckBox2")]
        private CheckBox _CheckBox2;
        [AccessedThroughProperty("ComboBox1")]
        private ComboBox _ComboBox1;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("OK_Button")]
        private Button _OK_Button;
        [AccessedThroughProperty("TableLayoutPanel1")]
        private TableLayoutPanel _TableLayoutPanel1;
        [AccessedThroughProperty("TextBox1")]
        private TextBox _TextBox1;
        [AccessedThroughProperty("TextBox2")]
        private TextBox _TextBox2;
        [AccessedThroughProperty("TextBox3")]
        private TextBox _TextBox3;
        [AccessedThroughProperty("TextBox4")]
        private TextBox _TextBox4;
        [AccessedThroughProperty("TextBox5")]
        private TextBox _TextBox5;
        private string awardstring;
        private IContainer components;
        private bool info;
        private int renshu;

        [DebuggerNonUserCode]
        public award()
        {
            base.Load += new EventHandler(this.award_Load);
            __ENCAddToList(this);
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

        private void award_Load(object sender, EventArgs e)
        {
            this.Top = 0x2b7 - this.Height;
            this.Left = 0xd8;
        }

        public void awardstringmake()
        {
            if (this.info)
            {
                Interaction.MsgBox("请检查所有项目是否已经填写完成！", MsgBoxStyle.Exclamation, "颁奖");
            }
            else
            {
                this.awardstring = this.ComboBox1.Text + "\r\nAward to delegate of " + this.TextBox1.Text + "\r\n";
                if (this.renshu == 1)
                {
                    this.awardstring = this.awardstring + this.TextBox2.Text + "\r\nFrom " + this.TextBox5.Text + "\r\nCongratulations!!";
                }
                else if (this.renshu == 2)
                {
                    this.awardstring = this.awardstring + this.TextBox2.Text + " and " + this.TextBox3.Text + "\r\nFrom " + this.TextBox5.Text + "\r\nCongratulations!!";
                }
                else if (this.renshu == 3)
                {
                    this.awardstring = this.awardstring + this.TextBox2.Text + ", " + this.TextBox3.Text + " and " + this.TextBox4.Text + "\r\nFrom " + this.TextBox5.Text + "\r\nCongratulations!!";
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            this.ComboBox1.Text = "";
            MyProject.Forms.Form1.lblmain.Text = "";
            this.TextBox1.Text = "";
            this.TextBox2.Text = "";
            this.TextBox3.Text = "";
            this.TextBox4.Text = "";
            this.TextBox5.Text = "";
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            this.renshua();
            if ((((this.ComboBox1.Text == "") | (this.TextBox1.Text == "")) | (this.TextBox5.Text == "")) | (this.renshu == 0))
            {
                this.info = true;
            }
            this.awardstringmake();
            MyProject.Forms.Form1.lblmain.Text = this.awardstring;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBox1.Checked)
            {
                this.TextBox3.Enabled = true;
                this.CheckBox2.Enabled = true;
            }
            else
            {
                this.TextBox3.Enabled = false;
                this.CheckBox2.Checked = false;
                this.CheckBox2.Enabled = false;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBox2.Checked)
            {
                this.TextBox4.Enabled = true;
            }
            else
            {
                this.TextBox4.Enabled = false;
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
            this.ComboBox1 = new ComboBox();
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.TextBox1 = new TextBox();
            this.Label3 = new Label();
            this.TextBox2 = new TextBox();
            this.CheckBox1 = new CheckBox();
            this.CheckBox2 = new CheckBox();
            this.TextBox3 = new TextBox();
            this.TextBox4 = new TextBox();
            this.Label4 = new Label();
            this.TextBox5 = new TextBox();
            this.cbx_mtype = new ComboBox();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            this.TableLayoutPanel1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            Point point2 = new Point(0xba, 0x8f);
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
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] { "Best Delegates", "Outstandng Delegates", "Best Position Paper", "Best Colleagues", "Best Styles" });
            point2 = new Point(0x36, 0x12);
            this.ComboBox1.Location = point2;
            this.ComboBox1.Name = "ComboBox1";
            size2 = new Size(0x8a, 0x15);
            this.ComboBox1.Size = size2;
            this.ComboBox1.TabIndex = 0;
            this.Label1.AutoSize = true;
            point2 = new Point(0x13, 0x16);
            this.Label1.Location = point2;
            this.Label1.Name = "Label1";
            size2 = new Size(0x1f, 13);
            this.Label1.Size = size2;
            this.Label1.TabIndex = 10;
            this.Label1.Text = "奖项";
            this.Label2.AutoSize = true;
            point2 = new Point(0x13, 0x35);
            this.Label2.Location = point2;
            this.Label2.Name = "Label2";
            size2 = new Size(0x73, 13);
            this.Label2.Size = size2;
            this.Label2.TabIndex = 11;
            this.Label2.Text = "授予                    代表";
            point2 = new Point(0x36, 0x31);
            this.TextBox1.Location = point2;
            this.TextBox1.Name = "TextBox1";
            size2 = new Size(0x66, 20);
            this.TextBox1.Size = size2;
            this.TextBox1.TabIndex = 1;
            this.Label3.AutoSize = true;
            point2 = new Point(0x12, 0x53);
            this.Label3.Location = point2;
            this.Label3.Name = "Label3";
            size2 = new Size(0x37, 13);
            this.Label3.Size = size2;
            this.Label3.TabIndex = 12;
            this.Label3.Text = "代表姓名";
            point2 = new Point(0x4d, 80);
            this.TextBox2.Location = point2;
            this.TextBox2.Name = "TextBox2";
            size2 = new Size(0x40, 20);
            this.TextBox2.Size = size2;
            this.TextBox2.TabIndex = 2;
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Checked = true;
            this.CheckBox1.CheckState = CheckState.Checked;
            point2 = new Point(0x94, 0x52);
            this.CheckBox1.Location = point2;
            this.CheckBox1.Name = "CheckBox1";
            size2 = new Size(15, 14);
            this.CheckBox1.Size = size2;
            this.CheckBox1.TabIndex = 3;
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox2.AutoSize = true;
            point2 = new Point(0xed, 0x52);
            this.CheckBox2.Location = point2;
            this.CheckBox2.Name = "CheckBox2";
            size2 = new Size(15, 14);
            this.CheckBox2.Size = size2;
            this.CheckBox2.TabIndex = 5;
            this.CheckBox2.UseVisualStyleBackColor = true;
            point2 = new Point(0xa8, 80);
            this.TextBox3.Location = point2;
            this.TextBox3.Name = "TextBox3";
            size2 = new Size(0x40, 20);
            this.TextBox3.Size = size2;
            this.TextBox3.TabIndex = 4;
            this.TextBox4.Enabled = false;
            point2 = new Point(0x101, 80);
            this.TextBox4.Location = point2;
            this.TextBox4.Name = "TextBox4";
            size2 = new Size(0x40, 20);
            this.TextBox4.Size = size2;
            this.TextBox4.TabIndex = 6;
            this.Label4.AutoSize = true;
            point2 = new Point(0x12, 0x72);
            this.Label4.Location = point2;
            this.Label4.Name = "Label4";
            size2 = new Size(0x37, 13);
            this.Label4.Size = size2;
            this.Label4.TabIndex = 13;
            this.Label4.Text = "所在学校";
            point2 = new Point(0x4e, 0x6f);
            this.TextBox5.Location = point2;
            this.TextBox5.Name = "TextBox5";
            size2 = new Size(0xf3, 20);
            this.TextBox5.Size = size2;
            this.TextBox5.TabIndex = 7;
            this.cbx_mtype.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbx_mtype.FlatStyle = FlatStyle.Flat;
            this.cbx_mtype.ForeColor = SystemColors.Window;
            this.cbx_mtype.FormattingEnabled = true;
            this.cbx_mtype.Items.AddRange(new object[] { "请选择", "有主持核心磋商", "自由磋商", "调整发言时间", "对文件投票", "开始茶歇", "结束辩论", "休会", "自定义" });
            point2 = new Point(0xa8, 0x30);
            this.cbx_mtype.Location = point2;
            this.cbx_mtype.Name = "cbx_mtype";
            size2 = new Size(0xb8, 0x15);
            this.cbx_mtype.Size = size2;
            this.cbx_mtype.TabIndex = 14;
            this.AcceptButton = this.OK_Button;
            SizeF ef2 = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef2;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            size2 = new Size(0x158, 0xb8);
            this.ClientSize = size2;
            this.Controls.Add(this.cbx_mtype);
            this.Controls.Add(this.TextBox5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.CheckBox2);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "award";
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "颁奖";
            this.TopMost = true;
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            this.renshua();
            if ((((this.ComboBox1.Text == "") | (this.TextBox1.Text == "")) | (this.TextBox5.Text == "")) | (this.renshu == 0))
            {
                this.info = true;
            }
            this.awardstringmake();
            if (!this.info)
            {
                MyProject.Forms.Form1.lblmain.Text = this.awardstring;
                MyProject.Forms.Form1.txthcmotion.Text = this.awardstring;
                this.renshu = 0;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public void renshua()
        {
            if (this.TextBox2.Text != "")
            {
                this.renshu = 1;
                if ((this.TextBox3.Text != "") & this.CheckBox1.Checked)
                {
                    this.renshu = 2;
                    if ((this.TextBox4.Text != "") & this.CheckBox2.Checked)
                    {
                        this.renshu = 3;
                    }
                }
            }
            else
            {
                this.renshu = 0;
            }
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

        internal virtual ComboBox cbx_mtype
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cbx_mtype;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._cbx_mtype = value;
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

        internal virtual CheckBox CheckBox2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._CheckBox2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.CheckBox2_CheckedChanged);
                if (this._CheckBox2 != null)
                {
                    this._CheckBox2.CheckedChanged -= handler;
                }
                this._CheckBox2 = value;
                if (this._CheckBox2 != null)
                {
                    this._CheckBox2.CheckedChanged += handler;
                }
            }
        }

        internal virtual ComboBox ComboBox1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ComboBox1;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._ComboBox1 = value;
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

        internal virtual TextBox TextBox2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox2;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TextBox2 = value;
            }
        }

        internal virtual TextBox TextBox3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox3;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TextBox3 = value;
            }
        }

        internal virtual TextBox TextBox4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox4;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TextBox4 = value;
            }
        }

        internal virtual TextBox TextBox5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBox5;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TextBox5 = value;
            }
        }
    }
}

