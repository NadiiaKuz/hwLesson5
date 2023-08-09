namespace hwLesson5
{
    class ButtonPhone : Phone
    {
        public ButtonPhone(string brand, string model, string color)
            : base(brand, model, color)
        {
        }

        public override void Initate()
        {
            imay = GetImayFromApi();
            RegisterInDB();
        }

        private string GetImayFromApi()
        {
            return "32423423432434";
        }

        private void RegisterInDB()
        {
            Console.WriteLine($"Registered in DB by {imay}");
        }
    }
}
