namespace Event_Implementation
{
    public delegate void NameChangeEventHandler(Dispatcher sender, NameChangeEventArgs args);

    public class Dispatcher
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
                OnNameChange(new NameChangeEventArgs(value));
            }
        }

        public event NameChangeEventHandler NameChange;

        public void OnNameChange(NameChangeEventArgs args)
        {
            if (this.NameChange != null)
            {
                this.NameChange(this, args);
            }
        }
    }
}