namespace hwLesson5
{
    public abstract class Phone
    {
        protected string imay;
        protected readonly uint countOfContacts;
        protected ContactBook contactBook;

        public uint SizeOfMemory { get; private set; } = 12;
        public string Model { get; }
        public string Brand { get; }
        public string Color { get; }

        public Phone(string brand, string model, string color)
        {
            Initate();
            countOfContacts = SizeOfMemory * 4;
            contactBook = new ContactBook(countOfContacts);
            Brand = brand;
            Color = color;
            Model = model;
        }

        public virtual void MakeACall(string name)
        {
            int index = contactBook.GetContactIndex(name);
            if (index != -1)
                Console.WriteLine($"Calling to {contactBook[name].PhoneNumber}");
            else
                Console.WriteLine("Unknown contact");
        }

        public void AddContact(string name, string phoneNumber)
        {
            Contact contact = new Contact(name, phoneNumber);
            contactBook.AddContact(contact);
        }

        public void IncreaseMemory(uint newValue)
        {
            SizeOfMemory = newValue;
        }

        public abstract void Initate();
    }
}
