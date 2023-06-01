namespace PR.Data
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int RateTimesCount { get; set; }
        public int VerificationCode { get; set; }
        public List<TeacherRating>? TeacherRatings { get; set; }
        public List<DisciplineRating>? DisciplineRatings { get; set; }
    }
}
