namespace EmailChecker2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCheckClicked(object sender, EventArgs e)
        {
            string ent = mailEnd.Text;
            bool czyOk = false;
            if (ent != null) {
                if (ent.Contains("@")){
                    int IndexEnt = ent.IndexOf("@");
                    if (IndexEnt>0 && IndexEnt < ent.Length-1)
                    {
                        czyOk = true;
                    }
                } else { }
            }

            if(czyOk)
            {
                Weryfikacja.Text = "poprawny";
            }
            else {
                Weryfikacja.Text = "zly";
            }
            SemanticScreenReader.Announce(Weryfikacja.Text);
        }
    }
}