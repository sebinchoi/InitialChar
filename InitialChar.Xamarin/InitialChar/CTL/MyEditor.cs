using System;
using Xamarin.Forms;
namespace InitialChar
{
    public class MyTextbox : Entry
    {
        public event EventHandler<KeyEventArgs> KeyPressed;
        public event EventHandler<KeyEventArgs> KeyUp;



        public MyTextbox() : base()
        {
            KeyUp += MyTextbox_KeyUp;
        }

        private void MyTextbox_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }

    public class KeyEventArgs : EventArgs
    {
       public string Key { get; set; }
    }
}
