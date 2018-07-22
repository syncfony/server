using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Syncfony.Api.Models
{
    public class MidiMessage
    {
        public MidiMessageState State { get; set; }
        public int Note { get; set; }
        public int Velocity { get; set; }
    }

    public enum MidiMessageState
    {
        Hit,
        Release
    }
}
