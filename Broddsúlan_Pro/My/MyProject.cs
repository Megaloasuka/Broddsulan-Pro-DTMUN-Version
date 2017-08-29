﻿namespace BroddsúlanPro.My
{
    using BroddsúlanPro;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.ApplicationServices;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Diagnostics;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [GeneratedCode("MyTemplate", "10.0.0.0"), HideModuleName, StandardModule]
    internal sealed class MyProject
    {
        private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();
        private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();
        private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();
        private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();
        private static readonly ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User> m_UserObjectProvider = new ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User>();

        [HelpKeyword("My.Application")]
        internal static MyApplication Application
        {
            [DebuggerHidden]
            get
            {
                return m_AppObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.Computer")]
        internal static MyComputer Computer
        {
            [DebuggerHidden]
            get
            {
                return m_ComputerObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.Forms")]
        internal static MyForms Forms
        {
            [DebuggerHidden]
            get
            {
                return m_MyFormsObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.User")]
        internal static Microsoft.VisualBasic.ApplicationServices.User User
        {
            [DebuggerHidden]
            get
            {
                return m_UserObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.WebServices")]
        internal static MyWebServices WebServices
        {
            [DebuggerHidden]
            get
            {
                return m_MyWebServicesObjectProvider.GetInstance;
            }
        }

        [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms"), EditorBrowsable(EditorBrowsableState.Never)]
        internal sealed class MyForms
        {
            public EC2_MineChair.AboutBox1 m_AboutBox1;
            public EC2_MineChair.award m_award;
            public EC2_MineChair.cabinet m_cabinet;
            public EC2_MineChair.Form1 m_Form1;
            [ThreadStatic]
            private static Hashtable m_FormBeingCreated;
            public EC2_MineChair.SplashScreen1 m_SplashScreen1;

            [DebuggerHidden]
            private static T Create__Instance__<T>(T Instance) where T: Form, new()
            {
                T local;
                if ((((Instance == null) || Instance.IsDisposed) ? 1 : 0) == 0)
                {
                    return Instance;
                }
                if (m_FormBeingCreated != null)
                {
                    if (m_FormBeingCreated.ContainsKey(typeof(T)))
                    {
                        throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
                    }
                }
                else
                {
                    m_FormBeingCreated = new Hashtable();
                }
                m_FormBeingCreated.Add(typeof(T), null);
                try
                {
                    return Activator.CreateInstance<T>();
                }
                catch when (?)
                {
                    TargetInvocationException exception;
                    throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[] { exception.InnerException.Message }), exception.InnerException);
                    ProjectData.ClearProjectError();
                }
                finally
                {
                    m_FormBeingCreated.Remove(typeof(T));
                }
                return local;
            }

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance) where T: Form
            {
                instance.Dispose();
                instance = default(T);
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object o)
            {
                return base.Equals(RuntimeHelpers.GetObjectValue(o));
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            internal Type GetType()
            {
                return typeof(MyProject.MyForms);
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString()
            {
                return base.ToString();
            }

            public EC2_MineChair.AboutBox1 AboutBox1
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_AboutBox1 = Create__Instance__<EC2_MineChair.AboutBox1>(this.m_AboutBox1);
                    return this.m_AboutBox1;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_AboutBox1)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<EC2_MineChair.AboutBox1>(ref this.m_AboutBox1);
                    }
                }
            }

            public EC2_MineChair.award award
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_award = Create__Instance__<EC2_MineChair.award>(this.m_award);
                    return this.m_award;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_award)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<EC2_MineChair.award>(ref this.m_award);
                    }
                }
            }

            public EC2_MineChair.cabinet cabinet
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_cabinet = Create__Instance__<EC2_MineChair.cabinet>(this.m_cabinet);
                    return this.m_cabinet;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_cabinet)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<EC2_MineChair.cabinet>(ref this.m_cabinet);
                    }
                }
            }

            public EC2_MineChair.Form1 Form1
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_Form1 = Create__Instance__<EC2_MineChair.Form1>(this.m_Form1);
                    return this.m_Form1;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_Form1)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<EC2_MineChair.Form1>(ref this.m_Form1);
                    }
                }
            }

            public EC2_MineChair.SplashScreen1 SplashScreen1
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_SplashScreen1 = Create__Instance__<EC2_MineChair.SplashScreen1>(this.m_SplashScreen1);
                    return this.m_SplashScreen1;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value != this.m_SplashScreen1)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<EC2_MineChair.SplashScreen1>(ref this.m_SplashScreen1);
                    }
                }
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
        internal sealed class MyWebServices
        {
            [DebuggerHidden]
            private static T Create__Instance__<T>(T instance) where T: new()
            {
                if (instance == null)
                {
                    return Activator.CreateInstance<T>();
                }
                return instance;
            }

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance)
            {
                instance = default(T);
            }

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            public override bool Equals(object o)
            {
                return base.Equals(RuntimeHelpers.GetObjectValue(o));
            }

            [DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            internal Type GetType()
            {
                return typeof(MyProject.MyWebServices);
            }

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            public override string ToString()
            {
                return base.ToString();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), ComVisible(false)]
        internal sealed class ThreadSafeObjectProvider<T> where T: new()
        {
            [ThreadStatic, CompilerGenerated]
            private static T m_ThreadStaticValue;

            internal T GetInstance
            {
                [DebuggerHidden]
                get
                {
                    if (MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
                    {
                        MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
                    }
                    return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
                }
            }
        }
    }
}

