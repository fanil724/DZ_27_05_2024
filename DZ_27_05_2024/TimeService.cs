namespace DZ_27_05_2024
{
    public class TimeService
    {
        public string GetTime()=>DateTime.Now.ToLongTimeString();
    }
}
