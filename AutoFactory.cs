using SimpleFactoryLibrary.Model;

namespace SimpleFactoryLibrary
{
    public class AutoFactory
    {
        public  IAutomobile MakeCar(AutoType type)
        {
            if (type == AutoType.Tesla)
                return new Tesla();
            else if (type == AutoType.BMW)
                return new BMW();
            return new Audi();
        }
    }
}