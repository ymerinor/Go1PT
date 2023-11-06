namespace Quote.Models.Provider
{
    internal class Agency
    {
        public int Code { get; set; }
        public int Branch { get; set; }
        public string Comments { get; set; }
        public Sucursal Sucursal { get; set; }
    }
}
