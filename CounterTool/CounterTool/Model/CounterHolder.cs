using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterTool.Model
{
    public class CounterHolder : ModelBase
    {
        #region Members definition
        #region Fields definition
        private readonly List<Counter> _counters;
        //private ObservableCollection<Counter> _countersObservable;
        #endregion Fields definition

        #region Properties definition
        // TODO: This could probably all be reworked to be quite a bit cleaner.
        // Maybe the ObservableCollection doesn't need to be backed by a List since the elements only need to have unique IDs.
        //if (this._countersObservable == null)
        //{ this.SetProperty(ref this._countersObservable, new ObservableCollection<Counter>(this._counters)); }
        ////{ this._countersObservable = new ObservableCollection<Counter>(this._counters); }
        //return this._countersObservable;
        public ObservableCollection<Counter> Counters { get; private set; }
        #endregion Properties definition
        #endregion Members definition

        #region Constructors definition
        public CounterHolder()
        {
            this._counters = new List<Counter>();
            this.Counters = new ObservableCollection<Counter>(this._counters);
        }
        #endregion Constructors definition

        #region Methods definition
        public void Add()
        {
            this._counters.Add(new Counter(this._counters.Count + 1));
        }

        public void Remove(int id)
        {
            this._counters.RemoveAll(counter => counter.Id == id);
        }

        public void Remove(Counter counter)
        {
            this._counters.Remove(counter);
        }

        public Counter GetByID(int id)
        {
            return this._counters.Where(counter => counter.Id == id).First();
        }
        #endregion Methods definition
    }
}
