namespace PivotTable
{
    public class InvoiceService
    {
        public List<InvoiceModel> GetInvoices() {
            return new List<InvoiceModel>() {

                new InvoiceModel() {InvoiceNumber = 1,Amount = 20,CostCategory="Services",Period="2019-11"},
                new InvoiceModel() {InvoiceNumber = 2,Amount = 70,CostCategory="Telephone",Period="2019-11"},
                new InvoiceModel() {InvoiceNumber = 3,Amount = 60,CostCategory="Services",Period="2019-11"},
                new InvoiceModel() {InvoiceNumber = 4,Amount = 40,CostCategory="Raw materials",Period="2019-11"},
                new InvoiceModel() {InvoiceNumber = 5,Amount = 40,CostCategory="Raw materials",Period="2019-11"},
                new InvoiceModel() {InvoiceNumber = 6,Amount = 30,CostCategory="Services",Period="2019-11"}
            };
        
        }
    }
}
