using System;
using System.Collections.Generic;

public class AddressBook
{
  public Dictionary<string, Contact> Person {get; set;} = new Dictionary<string, Contact>();

  public void AddContact(Contact contact)
  {
    Person.Add(contact.Email, contact);
  }

  public void GetByEmail(string email)
  {

  }
}