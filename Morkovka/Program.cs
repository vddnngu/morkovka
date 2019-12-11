using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morkovka
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            TestParser parser = new TestParser("c:/temp/morkovka/testWriter.test");
            parser.Parse();
            Property prop = new Property();
            prop.testName = "testWriter";
            prop.addMainQuestion(1);
            TestWriter writer = new TestWriter(parser.getRootLink(), prop);
            writer.Save("c:/temp/morkovka");
            TestProcessing game = new TestProcessing (parser.getRootLink());
        }
    }
}
