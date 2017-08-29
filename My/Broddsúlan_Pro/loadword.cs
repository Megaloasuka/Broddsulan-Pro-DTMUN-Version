namespace BroddsúlanPro
{
    using BroddsúlanPro.My;
    using Microsoft.Office.Interop.Word;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.IO;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    public class loadword
    {
        public static void ConvertFileWordToHtml(string WordFilePath, string SaveHtmlPath)
        {
            object fileName = WordFilePath;
            object obj6 = SaveHtmlPath;
            object objectValue = RuntimeHelpers.GetObjectValue(System.Type.Missing);
            object readOnly = true;
            object visible = false;
            Guid clsid = new Guid("000209FF-0000-0000-C000-000000000046");
            Microsoft.Office.Interop.Word.Application application = (Microsoft.Office.Interop.Word.Application) Activator.CreateInstance(System.Type.GetTypeFromCLSID(clsid));
            Document document = application.Documents.Open(ref fileName, ref objectValue, ref readOnly, ref objectValue, ref objectValue, ref objectValue, ref objectValue, ref objectValue, ref objectValue, ref objectValue, ref objectValue, ref visible, ref objectValue, ref objectValue, ref objectValue, ref objectValue);
            System.Type type = document.GetType();
            object wdFormatHTML = WdSaveFormat.wdFormatHTML;
            MyProject.Forms.Form1.Cursor = Cursors.AppStarting;
            document.SaveAs2(ref obj6, ref wdFormatHTML, ref Missing.Value, ref Missing.Value, ref Missing.Value, ref Missing.Value, ref Missing.Value, ref Missing.Value, ref Missing.Value, ref Missing.Value, ref Missing.Value, ref Missing.Value, ref Missing.Value, ref Missing.Value, ref Missing.Value, ref Missing.Value, ref Missing.Value);
            document.Close(ref objectValue, ref objectValue, ref objectValue);
            application.Quit(ref objectValue, ref objectValue, ref objectValue);
            MyProject.Forms.Form1.Cursor = Cursors.Arrow;
        }

        public static void loadCcong(string path)
        {
            StreamReader reader = new StreamReader(@"saved\" + path + @"\config.txt");
            string str = reader.ReadLine();
            if (((str == Conversions.ToString(1)) || (str == Conversions.ToString(0x14b))) || ((str == Conversions.ToString(0x14c)) || (str == Conversions.ToString(0x191))))
            {
                MyProject.Forms.Form1.isStarted = Conversions.ToBoolean(reader.ReadLine());
                MyProject.Forms.Form1.isSingelDel = Conversions.ToBoolean(reader.ReadLine());
                MyProject.Forms.Form1.session = Conversions.ToInteger(reader.ReadLine());
                MyProject.Forms.Form1.presentWhenRoll = Conversions.ToInteger(reader.ReadLine());
            }
            reader.Close();
        }

        public static object loadVersion()
        {
            object obj2;
            StreamReader reader = new StreamReader("version.txt");
            return reader.ReadLine();
            reader.Close();
            return obj2;
        }
    }
}

