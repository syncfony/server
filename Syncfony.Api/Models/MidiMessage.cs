using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syncfony.Api.Models
{
    public class MidiMessage
    {
        public MidiMessageState State { get; set; }
        public MidiNote Note { get; set; }
    }

    public enum MidiMessageState
    {
        Hit,
        Release
    }
}
