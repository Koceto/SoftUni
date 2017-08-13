using Work_Force.Interfaces;

namespace Work_Force.Entities
{
    public delegate void JobCompleteEventHandler(Job job);

    public class Job
    {
        public JobCompleteEventHandler JobComplete;
        private IEmploee emploee;
        private string name;
        private int workRequired;

        public Job(string name, int hours, IEmploee emploee)
        {
            this.Name = name;
            this.WorkRequired = hours;
            this.emploee = emploee;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int WorkRequired
        {
            get { return this.workRequired; }
            set
            {
                this.workRequired = value;

                if (this.workRequired <= 0)
                {
                    this.OnWorkComplete();
                }
            }
        }

        public void Update()
        {
            this.WorkRequired -= this.emploee.WorkHoursPerWeek;
        }

        public void OnWorkComplete()
        {
            if (this.JobComplete != null)
            {
                this.JobComplete(this);
            }
        }
    }
}