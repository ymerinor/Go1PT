using System.Collections.Generic;

namespace Quote.Models.Provider
{
    public class StartingPoint
    {
        public string Type { get; set; }
        public MeetingPoint MeetingPoint { get; set; }
        public List<PickupInstruction> PickupInstructions { get; set; }
    }
}
