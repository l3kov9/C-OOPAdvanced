namespace _05.BorderControl
{
    public abstract class SocietyMember : IIdentifiable
    {
        protected SocietyMember(string id)
        {
            this.Id = id;
        }

        public string Id { get; }

        public bool IsValidId(string pattern)
        {
            if (this.Id.EndsWith(pattern))
            {
                return true;
            }

            return false;
        }
    }
}
