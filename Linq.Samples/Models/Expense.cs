using System;

namespace Linq.Samples.Models
{
    public class Expense
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
        public Guid AccountTypeId { get; set; }
        public Guid CategoryId { get; set; }
        public RepeatType Repeat { get; set; } = RepeatType.NoRepetition;

        public Expense()
        {

        }
    }
}
