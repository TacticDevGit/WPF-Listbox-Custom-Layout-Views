using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace Listbox_Layouts
{
    public  class LayoutListbox : ListBox
    {


        public Layout layout
        {
            get { return (Layout)GetValue(layoutProperty); }
            set { SetValue(layoutProperty, value); }
        }

        public static readonly DependencyProperty layoutProperty = DependencyProperty.Register("layout", typeof(Layout), typeof(LayoutListbox), new PropertyMetadata(Layout.List));


    }




    public enum Layout
    {
        Tile,
        List

    }
}
