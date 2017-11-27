using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CounterTool.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CounterView : Grid
    {
        #region Members definition
        #region Fields definition
        private string _title;

        private int _value;
        private int _step;
        private int _maximum;
        private int _minimum;
        #endregion Fields definition

        #region Properties definition
        // TODO: Check if defaultBindingMode has to be set
        public static readonly BindableProperty Title = BindableProperty.Create(nameof(_title), typeof(bool), typeof(CounterView), defaultBindingMode: BindingMode.TwoWay);
        public static readonly BindableProperty Value = BindableProperty.Create(nameof(_value), typeof(int), typeof(CounterView));
        public static readonly BindableProperty Step = BindableProperty.Create(nameof(_step), typeof(int), typeof(CounterView), defaultBindingMode: BindingMode.TwoWay);
        public static readonly BindableProperty Maximum = BindableProperty.Create(nameof(_maximum), typeof(int), typeof(CounterView), defaultBindingMode: BindingMode.TwoWay);
        public static readonly BindableProperty Minimum = BindableProperty.Create(nameof(_minimum), typeof(int), typeof(CounterView), defaultBindingMode: BindingMode.TwoWay);
        #endregion Properties definition
        #endregion Members definition

        public CounterView()
        {
            InitializeComponent();
        }
    }
}