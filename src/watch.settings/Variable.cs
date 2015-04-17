namespace watch.settings
{
    public class Variable
    {
        public static Variable Create(string name = "New Variable")
        {
            return new Variable()
            {
                Name = name,
                Value = ""
            };
        }

        public string Name { get; set; }
        public string Value { get; set; }
    }
}
