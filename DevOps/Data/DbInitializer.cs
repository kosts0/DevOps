using DevOps.Models;

namespace DevOps.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DevOpsContext context)
        {
            // Look for any students.
            if (context.ExapmleModel.Any())
            {
                return;   // DB has been seeded
            }

            var exampleModelList = new ExapmleModel[]
            {
                new ExapmleModel{Name="Carson",Description="Alexander",DateTimeCreated=DateTime.Parse("2019-09-01")},
                new ExapmleModel{Name="Meredith",Description="Alonso",DateTimeCreated=DateTime.Parse("2017-09-01")},
                new ExapmleModel{Name="Arturo",Description="Anand",DateTimeCreated=DateTime.Parse("2018-09-01")},
                new ExapmleModel{Name="Gytis",Description="Barzdukas",DateTimeCreated=DateTime.Parse("2017-09-01")},
            };

            context.ExapmleModel.AddRange(exampleModelList);
            context.SaveChanges();
        }
    }
}
