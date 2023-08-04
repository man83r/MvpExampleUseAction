using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvpActionSimple.Models
{
    public class Model
    {
        public string UserText { get; set; }

        public string OuterText { get; set; }

        public void GetUpdateText()
        {
            OuterText = UserText + ", гвоздь мне в кеды!";
        }
    }
}
