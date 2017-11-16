using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterTool.Model
{
    public class Counter
    {
        #region Members definition
        #region Fields definition
        private readonly int _id;

        private int _value;
        #endregion Fields definition

        #region Properties definition
        public string Name { get; set; }

        public int Id
        {
            get { return this._id; }
        }
        public int Value
        {
            get { return this._value; }
            set { this.SetValue(value); }
        }
        public int Step { get; set; }
        public int Maximum { get; set; }
        public int Minimum { get; set; }
        #endregion Properties definition
        #endregion Members definition

        #region Constructors definition
        public Counter(int id)
        {
            this._id = id;
        }

        public Counter(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
        #endregion Constructors definition

        #region Methods definition
        public void Increment()
        {
            this.Value += this.Step;
        }

        public void Decrement()
        {
            this.Value -= this.Step;
        }

        private void SetValue(int value)
        {
            if (this._value + value > this.Maximum)
                { this._value = this.Maximum; }
            else if (this._value + value < this.Minimum)
                { this._value = this.Minimum; }
            else
                { this._value += value; }
        }
        #endregion Methods definition
    }
}
