using ContactModel = agricocw_ContactList.Models.Contact;
using agricocw_ContactList.Models;
using System.Collections.ObjectModel;

namespace agricocw_ContactList;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        LoadContacts();
    }

    private void LoadContacts()
    {
        var contacts = new List<ContactModel>
        {
            new ContactModel { Name = "Alice Anderson", Email = "alice@example.com", Phone = "123-456-7890", Description = "Friend from school", Photo = "picone.png" },
            new ContactModel { Name = "Aaron Smith", Email = "aaron@example.com", Phone = "123-456-7891", Description = "Neighbor", Photo = "pictwo.png" },
            new ContactModel { Name = "Amanda Jones", Email = "amanda@example.com", Phone = "123-456-7892", Description = "College buddy", Photo = "picthree.png" },
            new ContactModel { Name = "Bob Brown", Email = "bob@example.com", Phone = "123-456-7893", Description = "Work friend", Photo = "picfour.png" },
            new ContactModel { Name = "Ben Davis", Email = "ben@example.com", Phone = "123-456-7894", Description = "Old neighbor", Photo = "picone.png" },
            new ContactModel { Name = "Cindy Clark", Email = "cindy@example.com", Phone = "123-456-7895", Description = "Classmate", Photo = "pictwo.png" },
            new ContactModel { Name = "Carlos Cruz", Email = "carlos@example.com", Phone = "123-456-7896", Description = "Travel friend", Photo = "picthree.png" },
            new ContactModel { Name = "Chloe Campbell", Email = "chloe@example.com", Phone = "123-456-7897", Description = "Sorority sister", Photo = "picfour.png" },
            new ContactModel { Name = "Derek Davis", Email = "derek@example.com", Phone = "123-456-7898", Description = "Roommate", Photo = "picone.png" },
            new ContactModel { Name = "Dana Drew", Email = "dana@example.com", Phone = "123-456-7899", Description = "Project partner", Photo = "pictwo.png" },
            new ContactModel { Name = "Ethan Evans", Email = "ethan@example.com", Phone = "123-456-7800", Description = "Soccer teammate", Photo = "picthree.png" },
            new ContactModel { Name = "Ella Edwards", Email = "ella@example.com", Phone = "123-456-7801", Description = "Friend from camp", Photo = "picfour.png" },
            new ContactModel { Name = "Erik East", Email = "erik@example.com", Phone = "123-456-7802", Description = "Tutor", Photo = "picone.png" },
            new ContactModel { Name = "Fiona Fox", Email = "fiona@example.com", Phone = "123-456-7803", Description = "Dance class", Photo = "pictwo.png" },
            new ContactModel { Name = "Frank Foster", Email = "frank@example.com", Phone = "123-456-7804", Description = "Cousin", Photo = "picthree.png" }
        };

        var groupedContacts = contacts
            .GroupBy(c => c.Name[0].ToString().ToUpper())
            .OrderBy(g => g.Key)
            .Select(g => new Grouping<string, ContactModel>(g.Key, g))
            .ToList();

        contactsView.ItemsSource = groupedContacts;
    }

    private async void OnContactSelected(object sender, SelectionChangedEventArgs e)
    {
        var contact = e.CurrentSelection.FirstOrDefault() as ContactModel;
        if (contact != null)
        {
            await Navigation.PushAsync(new ContactDetailsPage(contact));
        }
    }
}
