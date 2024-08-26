using cybershield_api.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json;

namespace cybershield_api.Controllers
{
    [ApiController]
    [Route("Question")]
    public class QuestionController : Controller
    {
        StreamReader questions_file = new StreamReader("Models/QuestionJ.Json");
        [HttpGet]
        public async Task<IActionResult> getRandomQuestion()
        {
            Random randomizer = new Random();
            List<QuestionModel> result = new List<QuestionModel>();
            var questions_json = await questions_file.ReadToEndAsync();
            var questions = JsonConvert.DeserializeObject<List<QuestionModel>>(questions_json);
            var question_num = randomizer.Next(questions.Count());
            var question = questions[question_num];
            while (true)
            {
                if (result.Contains(question))
                {
                    question_num = randomizer.Next(questions.Count());
                    question = questions[question_num];
                }
                else
                {
                    result.Add(question);
                }
                if(result.Count() == 15)
                {
                    return Json(result);
                }
            }
        }
    }
}
