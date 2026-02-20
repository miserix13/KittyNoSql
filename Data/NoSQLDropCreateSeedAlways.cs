namespace NoSqlWrapper.Data
{
    public class NoSQLDropCreateSeedAlways 
    {
        public void Seed(NoSQLContext context)
        {
            NoSQLSeedData.SeedDemoData(context);
        }
    }
}
