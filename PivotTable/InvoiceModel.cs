namespace PivotTable
{
    public class InvoiceModel
    {
        public int InvoiceNumber { get; set; }
        public double Amount{ get; set; }
        public string ?CostCategory { get; set; }
        public string ?Period{ get; set; }
    }
}
