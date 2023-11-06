using System.Collections.Generic;

namespace Quote.Models.Provider
{
    internal class Holder
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public bool Mailing { get; set; }
        public long MailUpdDate { get; set; }
        public string Country { get; set; }
        public List<string> Telephones { get; set; }
    }
}
