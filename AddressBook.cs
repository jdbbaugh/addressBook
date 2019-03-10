using System;
using System.Collections.Generic;

public class AddressBook
{
  public Dictionary<string, Contact> Person {get; set;} = new Dictionary<string, Contact>();

  public void AddContact(Contact contact)
  {
    try
    {
    Person.Add(contact.Email, contact);
    }
    catch(ArgumentException)
    {
      Console.WriteLine($"You've already added {contact.FirstName} as a contact");
    }

  }

  public Contact GetByEmail(string email)
  {
    return Person[email];
  }
}