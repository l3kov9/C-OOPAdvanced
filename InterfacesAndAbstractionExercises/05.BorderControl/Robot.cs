namespace _05.BorderControl
{
    public class Robot : SocietyMember
    {
        public Robot(string model, string id) 
            : base(id)
        {
            this.Model = model;
        }

        public string Model { get; set; }
    }
}
