using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;

namespace MinorProject5.Functions
{
    public class PremierLeagueFunctions
    {
        // Azure Function 1: Match Prediction
        [Function("GetMatchPrediction")]
        public IActionResult GetMatchPrediction([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
        {
            var prediction = new
            {
                Fixture = "Arsenal vs Manchester City",
                Stadium = "Emirates Stadium",
                PredictedScore = "2 - 1",
                KeyPlayer = "Bukayo Saka",
                Source = "Live from Azure Function 1"
            };

            return new OkObjectResult(prediction);
        }

        // Azure Function 2: League News
        [Function("GetLeagueNews")]
        public IActionResult GetLeagueNews([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
        {
            var news = new
            {
                Headline = "Premier League Tactical Roundup",
                TopStory = "Michael Carrick's Deep Build-up system boosts Manchester United possession stats.",
                Matchweek = 12,
                Status = "Active",
                Source = "Live from Azure Function 2"
            };

            return new OkObjectResult(news);
        }
    }
}