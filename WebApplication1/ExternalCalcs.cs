namespace WebApplication1
{
    public class ExternalCalcs
    {
        public double CalcTDEE(double BMR, string activitylevel)
        {

            double TDEE = 0;

            if (activitylevel == ("sedentary"))
            {
                TDEE = (BMR * 1.2);
            }
            else if (activitylevel == ("light exercise"))
            {
                TDEE = (BMR * 1.375);
            }
            else if (activitylevel == ("moderate exercise"))
            {
                TDEE = (BMR * 1.55);
            }
            else if (activitylevel == ("heavy exercise"))
            {
                TDEE = (BMR * 1.725);
            }
            else if (activitylevel == ("athlete"))
            {
                TDEE = (BMR * 1.9);
            }
            return TDEE;
        }
    }
}
