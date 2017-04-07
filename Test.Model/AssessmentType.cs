using System;

namespace Test.Model
{
    public enum SearchFields
    {
        Code = 1,
        Description = 2
    }

    public class AssessmentType
    {
        public int Id { get; set; }
        public string Cid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
