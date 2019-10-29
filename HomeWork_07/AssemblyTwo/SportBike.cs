namespace AssemblyTwo
{
    public class SportBike : AssemblyOne.Motorcycle
    {
        public void StartEngine()
        {
            base.StartEngine();
        }

        public void CheckEngine()
        {
            base.CheckEngine();
        }

        public void Beep()
        {
            base.Beep();
        }

        public void ChangeColor()
        {
            //base.ChangeColor(); - (internal in base class) not available in derived classes
        }

        public void ChangeVin()
        {
            //base.ChangeVin(); - (protected in base class) not available in derived class
        }

        public void ResetVin()
        {
            //base.ResetVin(); - (private protected) not available for derived class 
        }
    }
}