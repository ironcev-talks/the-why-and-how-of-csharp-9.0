using System;
using System.Collections.Generic;

namespace TargetTypedNewExpressions.AllInOneExample
{
    public class Before
    {
        private readonly Dictionary<string, string> dictionary = new Dictionary<string, string>();

        protected List<Before> Children { get; } = new List<Before>();

        public IEnumerable<DateTime> GetDates()
        {
            IEnumerable<DateTime> dates = new DateTime[]
            {
                new DateTime(2021, 01, 23),
                new DateTime(2021, 02, 24),
                new DateTime(2021, 03, 25),
                new DateTime(2021, 04, 26),
                new DateTime(2021, 05, 27)
            };

            SomeHelperLocalFunction(new DateTime(1999, 12, 13, 12, 0, 0));

            return dates;

            void SomeHelperLocalFunction(DateTime date)
            {
            }
        }
    }
}
