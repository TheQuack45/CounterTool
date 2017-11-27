using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CounterTool.ViewModel
{
    public class CounterViewViewModel : ViewModelBase
    {
        #region Members definition
        #region Fields definition
        private string _title;

        private int _value;
        private int _step;
        private int? _maximum;
        private int? _minimum;
        #endregion Fields definition

        #region Properties definition
        public string Title
        {
            get { return this._title; }
            set { this.SetProperty<string>(ref this._title, value); }
        }

        public int Value
        {
            get { return this._value; }
            private set { this.SetProperty<int>(ref this._value, value); }
        }
        public int Step
        {
            get { return this._step; }
            set { this.SetProperty<int>(ref this._step, value); }
        }
        public int? Maximum
        {
            get { return this._maximum; }
            set { this.SetMaximum(value); }
        }
        public int? Minimum
        {
            get { return this._minimum; }
            set { this.SetMinimum(value); }
        }
        #endregion Properties definition

        #region Command members definition
        private ICommand _incrementCommand;
        public ICommand IncrementCommand
        {
            get
            {
                if (this._incrementCommand == null)
                {
                    this._incrementCommand = new Command(() => this.Increment());
                }
                return this._incrementCommand;
            }
        }

        private ICommand _decrementCommand;
        public ICommand DecrementCommand
        {
            get
            {
                if (this._decrementCommand == null)
                {
                    this._decrementCommand = new Command(() => this.Decrement());
                }
                return this._decrementCommand;
            }
        }
        #endregion Command members definition
        #endregion Members definition

        #region Constructors definition
        public CounterViewViewModel()
        {
            this.Title = "Title";
            this.Value = 0;
            this.Step = 1;
            this.Maximum = null;
            this.Minimum = null;
        }
        #endregion Constructors definition

        #region Methods definition
        public void Increment()
        {
            int newValue = this.Value + this.Step;

            if (this.Maximum != null && newValue > this.Maximum)
            { this.Value = (int)this.Maximum; }
            if (this.Minimum != null && newValue < this.Minimum)
            { this.Value = (int)this.Minimum; }
            else
            { this.Value = newValue; }
        }

        public void Decrement()
        {
            int newValue = this.Value - this.Step;

            if (this.Maximum != null && newValue > this.Maximum)
            { this.Value = (int)this.Maximum; }
            if (this.Minimum != null && newValue < this.Minimum)
            { this.Value = (int)this.Minimum; }
            else
            { this.Value = newValue; }
        }

        // TODO: Setting maximum or minimum to improper values could just block buttons until it is resolved rather than ignoring it.
        // This could use the ValidatableObject<T> class as specified https://developer.xamarin.com/guides/xamarin-forms/enterprise-application-patterns/validation/.
        public void SetMaximum(int? max)
        {
            if (max < this.Minimum)
            { return; }

            this.SetProperty<int?>(ref this._maximum, max);
        }

        public void SetMinimum(int? min)
        {
            if (min > this.Maximum)
            { return; }

            this.SetProperty<int?>(ref this._minimum, min);
        }
        #endregion Methods definition
    }
}
