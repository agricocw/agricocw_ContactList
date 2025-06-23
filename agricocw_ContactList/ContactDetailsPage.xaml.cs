using ContactModel = agricocw_ContactList.Models.Contact;

namespace agricocw_ContactList;

public partial class ContactDetailsPage : ContentPage
{
    public ContactDetailsPage(ContactModel contact)
    {
        InitializeComponent();

        contactImage.Source = contact.Photo;
        nameLabel.Text = contact.Name;
        emailLabel.Text = $"Email: {contact.Email}";
        phoneLabel.Text = $"Phone: {contact.Phone}";
        descriptionLabel.Text = contact.Description;
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
