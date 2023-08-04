using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvpActionSimple.IViews;
using MvpActionSimple.Models;

namespace MvpActionSimple.Presenters
{
    public class Presenter
    {
        private Model model = new Model();
        private readonly IView view;

        public Presenter(IView view)
        {
            this.view = view;
            view.UpdateText += OnGetUpdateText;
        }

        private void OnGetUpdateText()
        {
            model.UserText = view.UserText;
            model.GetUpdateText();
            RefreshView();
        }

        private void RefreshView()
        {
            view.OuterText = model.OuterText;
        }
    }
}
