using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiTest.Models
{
    public interface IContactRepository
    {
        IEnumerable GetAllContacts();
        Contact GetContact(string id);
        Contact AddContact(Contact item);
        bool RemoveContact(string id);
        bool UpdateContact(string id, Contact item);
    }
}