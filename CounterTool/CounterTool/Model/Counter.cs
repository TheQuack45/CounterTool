using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterTool.Model
{
    public class Counter : ModelBase
    {
        #region Members definition
        #region Fields definition
        private readonly int _id;

        private int _value;
        private int? _maximum;
        private int? _minimum;
        #endregion Fields definition

        #region Properties definition
        public string Title { get; set; }

        public int Id
        {
            get { return this._id; }
        }
        public int Value
        {
            get { return this._value; }
            private set { this.SetProperty<int>(ref this._value, value); }
            //private set { this._value = value; }
        }
        public int Step { get; set; }
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
        #endregion Members definition

        #region Constructors definition
        public Counter(int id)
        {
            this._id = id;

            this.Value = 0;
            this.Step = 1;
            this.Maximum = null;
            this.Minimum = null;
        }

        public Counter(int id, string title)
            : this(id)
        {
            this.Title = title;
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
            this._maximum = max;
        }

        public void SetMinimum(int? min)
        {
            if (min > this.Maximum)
            { return; }

            this.SetProperty<int?>(ref this._minimum, min);
            this._minimum = min;
        }
        #endregion Methods definition
    }
}
