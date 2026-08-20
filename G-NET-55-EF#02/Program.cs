using System.Reflection.Emit;

namespace G_NET_55_EF_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region EventHub
            using (var context = new EventHubContext())
            {
                var organizer = new Organizer
                {
                    Name = "ahmed",
                    CompanyName = "Tech",
                    VerifiedStatus = true,
                    Profile = new Profile
                    {
             
                    }
                };

                context.Organizers.Add(organizer);
                context.SaveChanges();

                Console.WriteLine(" Profile اتسجل بنجاح");
            }

            #endregion

        }
    }
}
