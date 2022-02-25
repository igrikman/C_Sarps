using System;
using System.Collections.Generic;
using System.Text;

namespace S_Sharp
{
    internal interface IHasInfo
    {
        void ShowInfo();
    }
    internal interface ICar
    {
        public int Speed { get; }
        public void Drive();
    }
}
