using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingKata;

namespace LoggingKata
{
    public interface ITrackable
    {
        string Name { get; set; }
        Point Location { get; set; }
    }
}