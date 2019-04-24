using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaCars.clases
{
    public partial class TextBox01 : Component
    {
        public TextBox01()
        {
            InitializeComponent();
        }

        public TextBox01(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
