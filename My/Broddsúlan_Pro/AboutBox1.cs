namespace BroddsúlanPro
{
    using BroddsúlanPro.My;
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
    public sealed class AboutBox1 : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        [AccessedThroughProperty("LabelCompanyName")]
        private Label _LabelCompanyName;
        [AccessedThroughProperty("LabelCopyright")]
        private Label _LabelCopyright;
        [AccessedThroughProperty("LabelProductName")]
        private Label _LabelProductName;
        [AccessedThroughProperty("LabelVersion")]
        private Label _LabelVersion;
        [AccessedThroughProperty("LogoPictureBox")]
        private PictureBox _LogoPictureBox;
        [AccessedThroughProperty("OKButton")]
        private Button _OKButton;
        [AccessedThroughProperty("TableLayoutPanel")]
        private System.Windows.Forms.TableLayoutPanel _TableLayoutPanel;
        [AccessedThroughProperty("TextBoxDescription")]
        private TextBox _TextBoxDescription;
        private IContainer components;

        [DebuggerNonUserCode]
        public AboutBox1()
        {
            base.Load += new EventHandler(this.AboutBox1_Load);
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

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        private void AboutBox1_Load(object sender, EventArgs e)
        {
            string title;
            if (MyProject.Application.Info.Title != "")
            {
                title = MyProject.Application.Info.Title;
            }
            else
            {
                title = Path.GetFileNameWithoutExtension(MyProject.Application.Info.AssemblyName);
            }
            this.Text = string.Format("关于 {0}", title);
            this.LabelProductName.Text = MyProject.Application.Info.ProductName;
            this.LabelVersion.Text = string.Format("版本 {0}", MyProject.Application.Info.Version.ToString());
            this.LabelCopyright.Text = MyProject.Application.Info.Copyright;
            this.LabelCompanyName.Text = MyProject.Application.Info.CompanyName;
            this.TextBoxDescription.Text = MyProject.Application.Info.Description;
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(AboutBox1));
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LogoPictureBox = new PictureBox();
            this.LabelProductName = new Label();
            this.LabelVersion = new Label();
            this.LabelCopyright = new Label();
            this.LabelCompanyName = new Label();
            this.TextBoxDescription = new TextBox();
            this.OKButton = new Button();
            this.TableLayoutPanel.SuspendLayout();
            ((ISupportInitialize) this.LogoPictureBox).BeginInit();
            this.SuspendLayout();
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33f));
            this.TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67f));
            this.TableLayoutPanel.Controls.Add(this.LogoPictureBox, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.LabelProductName, 1, 0);
            this.TableLayoutPanel.Controls.Add(this.LabelVersion, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.LabelCopyright, 1, 2);
            this.TableLayoutPanel.Controls.Add(this.LabelCompanyName, 1, 3);
            this.TableLayoutPanel.Controls.Add(this.TextBoxDescription, 1, 4);
            this.TableLayoutPanel.Controls.Add(this.OKButton, 1, 5);
            this.TableLayoutPanel.Dock = DockStyle.Fill;
            Point point2 = new Point(9, 8);
            this.TableLayoutPanel.Location = point2;
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 6;
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10f));
            Size size2 = new Size(0x18c, 0xef);
            this.TableLayoutPanel.Size = size2;
            this.TableLayoutPanel.TabIndex = 0;
            this.LogoPictureBox.Dock = DockStyle.Fill;
            this.LogoPictureBox.Image = (Image) manager.GetObject("LogoPictureBox.Image");
            point2 = new Point(3, 3);
            this.LogoPictureBox.Location = point2;
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.TableLayoutPanel.SetRowSpan(this.LogoPictureBox, 6);
            size2 = new Size(0x7c, 0xe9);
            this.LogoPictureBox.Size = size2;
            this.LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            this.LabelProductName.Dock = DockStyle.Fill;
            point2 = new Point(0x88, 0);
            this.LabelProductName.Location = point2;
            Padding padding2 = new Padding(6, 0, 3, 0);
            this.LabelProductName.Margin = padding2;
            size2 = new Size(0, 0x10);
            this.LabelProductName.MaximumSize = size2;
            this.LabelProductName.Name = "LabelProductName";
            size2 = new Size(0x101, 0x10);
            this.LabelProductName.Size = size2;
            this.LabelProductName.TabIndex = 0;
            this.LabelProductName.Text = "产品名称";
            this.LabelProductName.TextAlign = ContentAlignment.MiddleLeft;
            this.LabelVersion.Dock = DockStyle.Fill;
            point2 = new Point(0x88, 0x17);
            this.LabelVersion.Location = point2;
            padding2 = new Padding(6, 0, 3, 0);
            this.LabelVersion.Margin = padding2;
            size2 = new Size(0, 0x10);
            this.LabelVersion.MaximumSize = size2;
            this.LabelVersion.Name = "LabelVersion";
            size2 = new Size(0x101, 0x10);
            this.LabelVersion.Size = size2;
            this.LabelVersion.TabIndex = 0;
            this.LabelVersion.Text = "版本";
            this.LabelVersion.TextAlign = ContentAlignment.MiddleLeft;
            this.LabelCopyright.Dock = DockStyle.Fill;
            point2 = new Point(0x88, 0x2e);
            this.LabelCopyright.Location = point2;
            padding2 = new Padding(6, 0, 3, 0);
            this.LabelCopyright.Margin = padding2;
            size2 = new Size(0, 0x10);
            this.LabelCopyright.MaximumSize = size2;
            this.LabelCopyright.Name = "LabelCopyright";
            size2 = new Size(0x101, 0x10);
            this.LabelCopyright.Size = size2;
            this.LabelCopyright.TabIndex = 0;
            this.LabelCopyright.Text = "版权";
            this.LabelCopyright.TextAlign = ContentAlignment.MiddleLeft;
            this.LabelCompanyName.Dock = DockStyle.Fill;
            point2 = new Point(0x88, 0x45);
            this.LabelCompanyName.Location = point2;
            padding2 = new Padding(6, 0, 3, 0);
            this.LabelCompanyName.Margin = padding2;
            size2 = new Size(0, 0x10);
            this.LabelCompanyName.MaximumSize = size2;
            this.LabelCompanyName.Name = "LabelCompanyName";
            size2 = new Size(0x101, 0x10);
            this.LabelCompanyName.Size = size2;
            this.LabelCompanyName.TabIndex = 0;
            this.LabelCompanyName.Text = "公司名称";
            this.LabelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
            this.TextBoxDescription.Dock = DockStyle.Fill;
            point2 = new Point(0x88, 0x5f);
            this.TextBoxDescription.Location = point2;
            padding2 = new Padding(6, 3, 3, 3);
            this.TextBoxDescription.Margin = padding2;
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.ReadOnly = true;
            this.TextBoxDescription.ScrollBars = ScrollBars.Both;
            size2 = new Size(0x101, 0x71);
            this.TextBoxDescription.Size = size2;
            this.TextBoxDescription.TabIndex = 0;
            this.TextBoxDescription.TabStop = false;
            this.TextBoxDescription.Text = "说明 :\r\n\r\n(在运行时，将用应用程序的程序集信息替换这些标签的文本。\r\n在";
            this.OKButton.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.OKButton.DialogResult = DialogResult.Cancel;
            point2 = new Point(0x13e, 0xd7);
            this.OKButton.Location = point2;
            this.OKButton.Name = "OKButton";
            size2 = new Size(0x4b, 0x15);
            this.OKButton.Size = size2;
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "确定(&O)";
            SizeF ef2 = new SizeF(6f, 12f);
            this.AutoScaleDimensions = ef2;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.CancelButton = this.OKButton;
            size2 = new Size(0x19e, 0xff);
            this.ClientSize = size2;
            this.Controls.Add(this.TableLayoutPanel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox1";
            padding2 = new Padding(9, 8, 9, 8);
            this.Padding = padding2;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "AboutBox1";
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            ((ISupportInitialize) this.LogoPictureBox).EndInit();
            this.ResumeLayout(false);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal virtual Label LabelCompanyName
        {
            [DebuggerNonUserCode]
            get
            {
                return this._LabelCompanyName;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._LabelCompanyName = value;
            }
        }

        internal virtual Label LabelCopyright
        {
            [DebuggerNonUserCode]
            get
            {
                return this._LabelCopyright;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._LabelCopyright = value;
            }
        }

        internal virtual Label LabelProductName
        {
            [DebuggerNonUserCode]
            get
            {
                return this._LabelProductName;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._LabelProductName = value;
            }
        }

        internal virtual Label LabelVersion
        {
            [DebuggerNonUserCode]
            get
            {
                return this._LabelVersion;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._LabelVersion = value;
            }
        }

        internal virtual PictureBox LogoPictureBox
        {
            [DebuggerNonUserCode]
            get
            {
                return this._LogoPictureBox;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._LogoPictureBox = value;
            }
        }

        internal virtual Button OKButton
        {
            [DebuggerNonUserCode]
            get
            {
                return this._OKButton;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.OKButton_Click);
                if (this._OKButton != null)
                {
                    this._OKButton.Click -= handler;
                }
                this._OKButton = value;
                if (this._OKButton != null)
                {
                    this._OKButton.Click += handler;
                }
            }
        }

        internal virtual System.Windows.Forms.TableLayoutPanel TableLayoutPanel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TableLayoutPanel;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TableLayoutPanel = value;
            }
        }

        internal virtual TextBox TextBoxDescription
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TextBoxDescription;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._TextBoxDescription = value;
            }
        }
    }
}

