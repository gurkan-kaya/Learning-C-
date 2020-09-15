using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atik_toplama_oyun
{
    public interface IDolabilen
    {
        int Kapasite { get; set; }
        int DoluHacim { get; }
        double DolulukOrani { get; }
    }
}
