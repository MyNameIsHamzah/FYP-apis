using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{

    [ApiController]
    [Route("api/TheController")]
    public class TheController : ControllerBase
    {

        [HttpGet("GetBMI")]
        public double GetTheirBMI(double heightinM, double weightinKG)
        {

            double BMI = (weightinKG / (heightinM * heightinM));

            return Math.Round(BMI, 2);
        }


        [HttpGet("GetTDEE")]
        public double GetTheirTDEE(double heightinM, double weightinKG, int age, string gender, string activitylevel)
        {

            var calc = new ExternalCalcs();

            if (gender == ("female"))
            {
                double femheightincm = heightinM * 100;
                double femaleBMR = (10 * weightinKG) + (6.25 * femheightincm) - (5 * age) - 161;
                double femTdee = calc.CalcTDEE(femaleBMR, activitylevel);
                return Math.Round(femTdee);
            }

            double heightincm = heightinM * 100;
            double BMR = (10 * weightinKG) + (6.25 * heightincm) - (5 * age) + 5;
            double theTdee = calc.CalcTDEE(BMR, activitylevel);
            return Math.Round(theTdee);
        }
    }
}