using CounterTool.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterTool.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Members definition
        #region Fields definition
        private readonly CounterHolder _counterHolder;
        #endregion Fields definition

        #region Properties definition
        public ObservableCollection<Counter> Counters
        {
            get { return this._counterHolder.Counters; }
        }
        #endregion Properties definition
        #endregion Members definition

        #region Constructors definition
        public MainWindowViewModel()
        {
            this._counterHolder = new CounterHolder();
            this._counterHolder.Add();
        }
        #endregion Constructors definition

        #region Methods definition

        #endregion Methods definition
    }
}
