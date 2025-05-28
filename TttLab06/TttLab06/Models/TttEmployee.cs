using System;

namespace TttLab06.Models
{
    public class TttEmployee
    {
        public int TttId { get; set; }
        public string TttName { get; set; }
        public DateTime TttBirthDay { get; set; }
        public string TttEmail { get; set; }
        public string TttPhone { get; set; }
        public decimal TttSalary { get; set; }
        public bool TttStatus { get; set; }
    }
}
