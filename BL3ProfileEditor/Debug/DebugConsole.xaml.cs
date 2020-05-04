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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace BL3ProfileEditor.Debug
{
    /// <summary>
    /// Interaction logic for DebugConsole.xaml
    /// </summary>
    public partial class DebugConsole : Window
    {
        ConsoleRedirectWriter consoleRedirectWriter;

        public DebugConsole()
        {
            InitializeComponent();
            consoleRedirectWriter = new ConsoleRedirectWriter(textBoxDebug);
            // Releases console when window closes.
            Closed += delegate (Object o, EventArgs e) { consoleRedirectWriter.Release(); };
        }
    }
}
