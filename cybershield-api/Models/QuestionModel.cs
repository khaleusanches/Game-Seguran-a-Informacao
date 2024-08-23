using System.ComponentModel.DataAnnotations;

namespace cybershield_api.Models
{
    public class QuestionModel
    {
        //[Key]
        public int id_question { get; set; }
        public string theme_question { get; set; }

        public string text_question { get; set; }
        public string[] options { get; set; }
        public int _correct_answer { private get; set; }
        public string explanation { get; set; }

        //public QuestionModel(string theme_question, string[] options, string correct_answer)
        //{
        //    this.theme_question = theme_question;
        //     this.options = options;
        //     this.correct_answer = correct_answer;
        // }
        public int Correct_answer{
            get => _correct_answer;
            set => _correct_answer = value;
        }
    }
}
