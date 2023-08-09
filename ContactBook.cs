namespace hwLesson5
{
    public class ContactBook
    {
        private Contact[] contacts;
        private string[] history;

        public ContactBook(uint countOfContact)
        {
            contacts = new Contact[countOfContact];
            history = new string[countOfContact];
        }

        public Contact this[string name]
        {
            get
            {
                for (int i = 0; i < contacts.Length; i++)
                {
                    if (contacts[i].Name.ToUpper() == name.Trim().ToUpper())
                        return contacts[i];
                }
                return new Contact();
            }
        }

        public int GetContactIndex(string name)
        {
            for (int i = 0; i < contacts.Length; i++)
            {
                if (contacts[i].Name.ToUpper() == name.Trim().ToUpper())
                {
                    return i;
                }
            }

            return -1;
        }

        private int GetEmptySpaceContacts()
        {
            for (int i = 0; i < contacts.Length; i++)
            {
                if (contacts[i] == null)
                    return i;
            }

            return -1;
        }

        private int GetEmptySpaceHistory()
        {
            for (int i = 0; i < history.Length; i++)
            {
                if (history[i] == null)
                    return i;
            }

            return -1;
        }


        public void AddContact(Contact contact)
        {
            int contactIndex = GetEmptySpaceContacts();

            if (contactIndex != -1)
                contacts[contactIndex] = contact;
        }


        public void RemoveContact(int id)
        {
            contacts[id] = null;
        }

        public Contact[] GetAllContacts() =>
            contacts;

        public void AddHistory(Contact contact)
        {
            int index = GetEmptySpaceHistory();

            if (index != -1)
                history[index] = $"{DateTime.Now} {contact.Name}";
        }

        public string[] GetHistory()
        {
            return history;
        }
    }
}
