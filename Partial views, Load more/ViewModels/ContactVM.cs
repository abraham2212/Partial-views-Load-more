using PurpleBuzz.Models;

namespace PurpleBuzz.ViewModels
{
    public class ContactVM
    {
        public ContactBanner ContactBanner { get; set; }
        public ContactHeader ContactHeader { get; set; }
        public IEnumerable<Contact> Contacts { get; set; }

    }
}
