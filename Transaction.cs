namespace BankingManagementSystem
{
    public class Transaction
    {
        private int transactionId;
        private DateTime dateTime;
        private decimal amount;
        private string description;
        private string relatedAccountNo;
        private string transactionType;
        public Transaction(int transactionId, decimal amount, string transactionType, string description, string relatedAccountNo)
        {
            this.transactionId = transactionId;
            this.dateTime = DateTime.Now;
            this.amount = amount;
            this.transactionType = transactionType;
            this.description = description;
            this.relatedAccountNo = relatedAccountNo;
        }
        public void DisplayTransactionDetails()
        {
            Console.WriteLine($"Transaction ID: {transactionId}");
            Console.WriteLine($"Date & Time: {dateTime}");
            Console.WriteLine($"Amount: Rs. {amount}");
            Console.WriteLine($"Transaction Type: {transactionType}");
            Console.WriteLine($"Description: {description}");

            if (relatedAccountNo != null)
            {
                Console.WriteLine($"Related Account: {relatedAccountNo}");
            }
        }

    }
}
