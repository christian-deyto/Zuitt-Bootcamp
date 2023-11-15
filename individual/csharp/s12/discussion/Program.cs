namespace discussion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //[SECTION] Select Operator
            Select select = new Select();

            //select.SelectOperator();
            //select.SelectNameAndPrice();


            //[SECTION] Where Operator
            Where where = new Where();

            //where.WhereOperator();

            //[SECTION] OrderBy Operator
            OrderByThenBy orderByThenBy = new OrderByThenBy();

            //orderByThenBy.OrderByOperator();

            //orderByThenBy.ThenByOperator();

            //[SECTION] GroupBy Operator

            GroupBy groupBy = new GroupBy();

            //groupBy.GroupByOperator();

            //groupBy.NewListGroupByOperator();

            groupBy.MoreGroupyBySample();
        }
    }
}