using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;
using AppKit;
using InitialChar;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(MyTextbox), typeof(InitialChar.Mac.MyTextBoxRenderer))]
namespace InitialChar.Mac
{
    public class MyTextBoxRenderer : EntryRenderer
    {
        private float fFontDefault = 40f;
        public MyTextBoxRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            //float fSize = (float?)Element?.FontSize ?? fFontDefault;
            float fSize = fFontDefault;
            if (Control != null)
            {
                Control.Font = NSFont.SystemFontOfSize(fSize);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if(e.PropertyName == "FontSize")
            {
                //float fSize = (float?)Element?.FontSize ?? fFontDefault;
                float fSize = fFontDefault;
                if (Control != null)
                {
                    Control.Font = NSFont.SystemFontOfSize(fSize);
                }
            }
        }


        public override void KeyDown(NSEvent theEvent)
        {
            var sKey = theEvent.KeyCode;

            (Element as MyTextbox).KeyPressed += (object sender, KeyEventArgs e) => {
                e.Key = theEvent.KeyCode.ToString();
            };



            if (theEvent.KeyCode.Equals(36))
            {
                Element.Text += "\n";
            }
            else
            {
                base.KeyDown(theEvent);
            }

        }

        public override void KeyUp(NSEvent theEvent)
        {
            base.KeyUp(theEvent);

            var sKey = theEvent.KeyCode;

            KeyEventArgs arg = new KeyEventArgs()
            {
                Key = sKey.ToString()
            };

            //(Element as MyTextbox).KeyUp(Element, arg);
            // += (object sender, KeyEventArgs e) => {
              //  e.Key = theEvent.KeyCode.ToString();
            //};
        }
    }
}
