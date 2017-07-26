using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component2
{
    public partial class Component2 : Component
    {
        public Component2()
        {
            InitializeComponent();
        }

        public Component2(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public bool check(string text){
            if (text.Length == 0 || text.Length != 8)
            {
                return true;

            }
            else
            {
                return false;

            }

        }
    }
}
