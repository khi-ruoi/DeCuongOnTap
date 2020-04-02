using System.Windows.Forms;

namespace DeCuongOnTap.Classes
{
    public class clKeyEvent
    {
        public void AllowKey(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) &&!char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
