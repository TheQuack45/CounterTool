using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CounterTool
{
    /// <summary>
    /// A struct used in the WrapLayout class. <see cref="WrapLayout"/>
    /// </summary>
    /// <remarks>
    /// Developed by Charles Petzold and David Britch.
    /// WrapLayout implementation available at https://github.com/xamarin/xamarin-forms-samples/tree/master/UserInterface/CustomLayout/WrapLayout.
    /// Containing repository available at https://github.com/xamarin/xamarin-forms-samples.
    /// Provided under the Apache License 2.0, available at http://www.apache.org/licenses/LICENSE-2.0.
    /// </remarks>
    struct LayoutData
    {
        public int VisibleChildCount { get; private set; }

        public Size CellSize { get; private set; }

        public int Rows { get; private set; }

        public int Columns { get; private set; }

        public LayoutData(int visibleChildCount, Size cellSize, int rows, int columns) : this()
        {
            VisibleChildCount = visibleChildCount;
            CellSize = cellSize;
            Rows = rows;
            Columns = columns;
        }
    }
}
