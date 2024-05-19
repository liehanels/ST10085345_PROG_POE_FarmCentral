namespace ST10085345_PROG_POE_FarmCentral.Models
{
    public class Product
    {
        public int productID { get; set; }
        public int userID { get; set; }
        public string productName { get; set; }
        public string productCategory { get; set; }
        DateOnly productionDate { get; set; }
        DateOnly bestBeforeDate { get; set; }
    }
}
