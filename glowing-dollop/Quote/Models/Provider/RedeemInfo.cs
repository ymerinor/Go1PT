using System.Collections.Generic;

namespace Quote.Models.Provider
{
    public class RedeemInfo
    {
        public string Type { get; set; }
        public bool DirectEntrance { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
