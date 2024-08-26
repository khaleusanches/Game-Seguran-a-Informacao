using cybershield_api.Data;
using cybershield_api.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace cybershield_api.Controllers
{
    [ApiController]
    [Route("Scores")]
    public class ScoresController : Controller
    {
        private readonly IMongoCollection<ScoresModel>? _scores;
        private readonly IMongoCollection<Usuarios>? _users;
        public ScoresController(DBContext db)
        {
            _scores = db.Database?.GetCollection<ScoresModel>("Score");
            _users = db.Database?.GetCollection<Usuarios>("Usuario");
        }
        [HttpGet]
        public async Task<ActionResult> getScores()
        {
            var sort = Builders<ScoresModel>.Sort.Descending(score => score.score).Ascending(score=> score.HoraPontuacao);
            var users = await _users.Find(FilterDefinition<Usuarios>.Empty).ToListAsync();
            var scores = await _scores.Find(FilterDefinition<ScoresModel>.Empty).Sort(sort).ToListAsync();
            var result = scores.Select(score => new
            {
                id = score.Id,
                user_id = score.Users_id,
                Username = users.FirstOrDefault(user => user.Id == score.Users_id)?.Username,
                Score = score.score,
                HoraPontuacao = score.HoraPontuacao,
            });
            return Ok(result);
        }
        [HttpGet("attScores/user={users_id};score={score};HoraPontuacao={HoraPontuacao}")]
        public async Task<ActionResult> postScore(string users_id, int score, string HoraPontuacao)
        {
            var new_score = new ScoresModel(users_id, score, HoraPontuacao);
            var filterEQ = Builders<ScoresModel>.Filter.Eq(score => score.Users_id, new_score.Users_id);
            var listaScores = await _scores.Find(filterEQ).ToListAsync();
            if (listaScores.Count() != 0 && listaScores != null)
            {
                var filterLT = Builders<ScoresModel>.Filter.Lte(score => score.score, new_score.score);
                var combinedFilter = Builders<ScoresModel>.Filter.And(filterLT, filterEQ);
                var update = Builders<ScoresModel>.Update.Set
                    (score => score.score, new_score.score).Set(score => score.HoraPontuacao, new_score.HoraPontuacao);
                await _scores.UpdateOneAsync(combinedFilter, update);
                return Ok("Atualizado score");
            }
            else
            {
                await _scores.InsertOneAsync(new_score);
                return Ok("Criado score");
            }
        }
    }
}
