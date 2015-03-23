﻿using NAXB.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NAXB.UnitTests.Mockups.Models
{
    [XmlModel]
    [NamespaceDeclaration(Uri = "http://josheinhorn.com", Prefix = "jse")]
    public class Person
    {
        [XPath("firstName")]
        public string FirstName { get; set; }

        [XPath("lastName")]
        public string LastName { get; set; }

        [XmlElement("middleName")]
        public string MiddleName;

        [XPath("emails/email")]
        public List<Email> Emails { get; set; }

        [XPath("address[@type=\"mailing\"]/line")]
        public List<string> MailingAddressLines { get; set; }

        [XPath("address[@type=\"billing\"]/line")]
        public List<string> BillingAddressLines { get; set; }

        [XPath("contacts/person")]
        public Person[] Contacts { get; set; }

        [XmlAttribute("role")]
        public string Role { get; set; }

        [XPath("contacts/person[@relationship=\"brother\"]")]
        public List<Person> Brothers { get; set; }

        [XmlElement("DOB")]
        [CustomFormat(DateTimeFormat = "dd-MM-yyyy")]
        public DateTime? DateOfBirth;
    }

   
}
