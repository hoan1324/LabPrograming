namespace Models.Entity
{
    public class Major
    {
        public Major() {
            Learners = new HashSet<Learner>();
        }
        public int MajorId { get; set; }
        public string? MajorName { get; set; }
        public virtual ICollection<Learner> Learners { get; set; }
    }
}
