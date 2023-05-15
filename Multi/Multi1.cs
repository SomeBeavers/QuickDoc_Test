namespace Multi
{
    public class Multi1
    {
        public string Name { get; set; }
#if NET6_0
        // test comment
        private protected static string Test(string name)
        {
            var string1 = Resource1.String1;
            return name.ToLower();
        }


#endif
    }
}