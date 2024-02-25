namespace testyungching.Bussinse
{
    public class Base
    {
        public ConfigurationBuilder builder = (ConfigurationBuilder)new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json");

        public IConfigurationRoot config { get; set; }
        public Base()
        {
              config = builder.Build();
        }
    }
}
