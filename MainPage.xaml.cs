using AddressBook;

namespace GA_Prog2Class_DesmondR
{
    public partial class MainPage : ContentPage
    {
        private Person person;
        private List<Person> peopleList;

        public MainPage()
        {
            InitializeComponent();
            person = new Person("John", "Doe");
            firstNameEntry.text = person.FirstName;
            lastNameEntry.text = person.LastName;
            fullNameEntry.Text = person.GetFullName();

            ...
                peopleList = new List<Person>
                {
new Person("John", "doe"),
new Person("Jane", "Doe"),
new Person("Steve", "Smith")
};
            DisplayPeopleInfo();
        } 
        private void DisplayPeopleInfo()
        {
        var stringBuilder = new System.Text.StringBuilder();
        foreach (var person in peopleList))
            {
                stringBuilder.AppendLine($"Name: {person.getFullName()}");
            }
    infoEditor.Text = stringBuilder.ToString);
        }

        }//Main
    }//Class

}//NameSpace
