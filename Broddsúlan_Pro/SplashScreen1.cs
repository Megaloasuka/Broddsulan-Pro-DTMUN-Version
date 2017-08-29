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
    public sealed class SplashScreen1 : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        [AccessedThroughProperty("ApplicationTitle")]
        private Label _ApplicationTitle;
        [AccessedThroughProperty("Copyright")]
        private Label _Copyright;
        [AccessedThroughProperty("DetailsLayoutPanel")]
        private TableLayoutPanel _DetailsLayoutPanel;
        [AccessedThroughProperty("MainLayoutPanel")]
        private TableLayoutPanel _MainLayoutPanel;
        [AccessedThroughProperty("Version")]
        private Label _Version;
        private IContainer components;

        [DebuggerNonUserCode]
        public SplashScreen1()
        {
            base.Load += new EventHandler(this.SplashScreen1_Load);
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(SplashScreen1));
            this.MainLayoutPanel = new TableLayoutPanel();
            this.DetailsLayoutPanel = new TableLayoutPanel();
            this.Version = new Label();
            this.Copyright = new Label();
            this.ApplicationTitle = new Label();
            this.MainLayoutPanel.SuspendLayout();
            this.DetailsLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            this.MainLayoutPanel.BackgroundImage = (Image) manager.GetObject("MainLayoutPanel.BackgroundImage");
            this.MainLayoutPanel.BackgroundImageLayout = ImageLayout.Stretch;
            this.MainLayoutPanel.ColumnCount = 2;
            this.MainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 243f));
            this.MainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100f));
            this.MainLayoutPanel.Controls.Add(this.DetailsLayoutPanel, 1, 1);
            this.MainLayoutPanel.Controls.Add(this.ApplicationTitle, 1, 0);
            this.MainLayoutPanel.Dock = DockStyle.Fill;
            Point point2 = new Point(0, 0);
            this.MainLayoutPanel.Location = point2;
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 218f));
            this.MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 38f));
            Size size2 = new Size(0x1f0, 0x12f);
            this.MainLayoutPanel.Size = size2;
            this.MainLayoutPanel.TabIndex = 0;
            this.DetailsLayoutPanel.Anchor = AnchorStyles.None;
            this.DetailsLayoutPanel.BackColor = Color.Transparent;
            this.DetailsLayoutPanel.ColumnCount = 1;
            this.DetailsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 247f));
            this.DetailsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 142f));
            this.DetailsLayoutPanel.Controls.Add(this.Version, 0, 0);
            this.DetailsLayoutPanel.Controls.Add(this.Copyright, 0, 1);
            point2 = new Point(0xf6, 0xdd);
            this.DetailsLayoutPanel.Location = point2;
            this.DetailsLayoutPanel.Name = "DetailsLayoutPanel";
            this.DetailsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33f));
            this.DetailsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33f));
            size2 = new Size(0xf7, 0x4f);
            this.DetailsLayoutPanel.Size = size2;
            this.DetailsLayoutPanel.TabIndex = 1;
            this.Version.Anchor = AnchorStyles.None;
            this.Version.BackColor = Color.Transparent;
            this.Version.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point2 = new Point(3, 9);
            this.Version.Location = point2;
            this.Version.Name = "Version";
            size2 = new Size(0xf1, 20);
            this.Version.Size = size2;
            this.Version.TabIndex = 1;
            this.Version.Text = "版本 {0}.{1:00}";
            this.Copyright.Anchor = AnchorStyles.None;
            this.Copyright.BackColor = Color.Transparent;
            this.Copyright.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point2 = new Point(3, 0x27);
            this.Copyright.Location = point2;
            this.Copyright.Name = "Copyright";
            size2 = new Size(0xf1, 40);
            this.Copyright.Size = size2;
            this.Copyright.TabIndex = 2;
            this.Copyright.Text = "版权";
            this.ApplicationTitle.Anchor = AnchorStyles.None;
            this.ApplicationTitle.BackColor = Color.Transparent;
            this.ApplicationTitle.Font = new Font("Segoe UI Light", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point2 = new Point(0xf6, 3);
            this.ApplicationTitle.Location = point2;
            this.ApplicationTitle.Name = "ApplicationTitle";
            size2 = new Size(0xf7, 0xd4);
            this.ApplicationTitle.Size = size2;
            this.ApplicationTitle.TabIndex = 0;
            this.ApplicationTitle.Text = "应用程序标题";
            this.ApplicationTitle.TextAlign = ContentAlignment.BottomLeft;
            SizeF ef2 = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef2;
            this.AutoScaleMode = AutoScaleMode.Font;
            size2 = new Size(0x1f0, 0x12f);
            this.ClientSize = size2;
            this.ControlBox = false;
            this.Controls.Add(this.MainLayoutPanel);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen1";
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MainLayoutPanel.ResumeLayout(false);
            this.DetailsLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        private void SplashScreen1_Load(object sender, EventArgs e)
        {
            if (MyProject.Application.Info.Title != "")
            {
                this.ApplicationTitle.Text = MyProject.Application.Info.Title;
            }
            else
            {
                this.ApplicationTitle.Text = Path.GetFileNameWithoutExtension(MyProject.Application.Info.AssemblyName);
            }
            this.Version.Text = string.Format(this.Version.Text, MyProject.Application.Info.Version.Major, MyProject.Application.Info.Version.Minor);
            this.Copyright.Text = MyProject.Application.Info.Copyright;
        }

        internal virtual Label ApplicationTitle
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ApplicationTitle;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._ApplicationTitle = value;
            }
        }

        internal virtual Label Copyright
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Copyright;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Copyright = value;
            }
        }

        internal virtual TableLayoutPanel DetailsLayoutPanel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DetailsLayoutPanel;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._DetailsLayoutPanel = value;
            }
        }

        internal virtual TableLayoutPanel MainLayoutPanel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._MainLayoutPanel;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._MainLayoutPanel = value;
            }
        }

        internal virtual Label Version
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Version;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                this._Version = value;
            }
        }
    }
}

