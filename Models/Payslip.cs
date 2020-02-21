namespace empservice.Models
{
    public class Payslip
    {
        public int EmployeeId { get; set; }

        public int TransactionYear { get; set; }

        public int TrasactionMonth { get; set; }

        public string RowDetail { get; set; }

        public string GenerateUser { get; set; }

        public int GenerateSequence { get; set; }

        public int LineOrder { get; set; }
    }
}