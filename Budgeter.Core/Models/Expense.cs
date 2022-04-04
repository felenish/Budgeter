namespace Budgeter.Core.Models
{
    public class Expense
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public bool IsRecurring { get; set; }
        public string RecurrenceInterval { get; set; }
        public string MyProperty { get; set; }

        public Expense()
        {
        }

    }
}