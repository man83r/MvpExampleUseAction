using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvpActionSimple.IViews
{
    public interface IView
    {
        string UserText { get; set; }
        string OuterText { get; set; }

        event Action UpdateText;
    }
}
