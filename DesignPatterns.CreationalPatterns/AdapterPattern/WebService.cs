namespace DesignPatterns.CreationalPatterns.AdapterPattern
{
    public class WebService
    {
        public int Request(string json)
        {
            if (json.ToUpper() == "a valid object".ToUpper())
            {
                return 200;
            }

            else if (json.ToUpper() == "an invalid object".ToUpper())
            {
                return 400;
            }

            else
            {
                return 403;
            }

        }
    }
}