using System;
using System.Collections.Generic;
using System.Text;

namespace PhonebookConsole
{
   class Phonebook
  {
    private List<Contact> _Contacts { get; set;} = new
    private void DisplayContactDetails( Contact contacts)
    {
         Console.WriteLine($"contact:{contact.Name},{contact.Number}");  
    }

    private void DisplayContactDetails(List<Contact> contacts) 
    {
            foreach (var contact in _Contacts)
        {
           DisplayContactDetails(contact);
        }
    }

    public void AddContact (Contact contacts)
    {
        _Contacts.Add(contact);
    }
    public void DisplayContact(string number)
    {
        var contact= _Contacts.FirstOrDefault(c => c.Number == number);
        if (contact == null)
        {
            Console.WriteLine("contact not found");
        }
        else{
            DisplayContactDetails(contact);
        }
    }
    public void DisplayAllContacts()
        {
           DisplayContactDetails(_Contacts);
        }

    
    public void DisplayMatchingContact(string searchphrase)
    {
        var matchingcontacts= _Contacts.Where(c => c.Name.Contains(searchphrase)).ToList();
        DisplayContactDetails(matchingcontacts);

    }

  }

}