namespace NoSqlWrapper.Data
{
    public class NoSQLDropCreateSeedIfModified
    {
        public void Seed(NoSQLContext context)
        {
            NoSQLSeedData.SeedDemoData(context);
        }
    }
}
