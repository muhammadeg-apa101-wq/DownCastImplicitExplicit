using DownCastImplicitExplicit.Models;

namespace DownCastImplicitExplicit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FahrenheitCelsius
            Celsius celsius = new Celsius(37);
            Fahrenheit fahrenheit = celsius;
            Console.WriteLine($"celsius: {celsius.celsius}, fahrenheit:  {fahrenheit.fahrenheit}");
            #endregion


            #region DownCastAsIs
            Animal animal = new Capybara();
            Capybara capybara = (Capybara)animal;
            capybara.Speak();

            if (animal is Capybara capybara2)
            {
                capybara2.Speak();
            }
            #endregion
        }
    }
}
