using System.Windows.Forms;

namespace PolicyConnect
{
    internal class WindowHelper
    {
        private WindowHelper()
        {
        }

        internal static void CloseParent(Control control)
        {
            var parent = (Form)control.Parent;
            parent.Close();
            parent.Dispose();
        }
    }
}
