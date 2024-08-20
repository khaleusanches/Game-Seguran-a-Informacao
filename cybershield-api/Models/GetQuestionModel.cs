namespace cybershield_api.Models
{
    public record GetQuestionModel
    {
        public int id_question { get; set; }
        public string theme_question { get; set; }
        public string text_question { get; set; }
        public string[] options { get; set; }
    }
}
