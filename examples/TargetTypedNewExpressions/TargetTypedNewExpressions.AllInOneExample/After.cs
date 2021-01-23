using System;
using System.Collections.Generic;

namespace TargetTypedNewExpressions.AllInOneExample
{
    public class After
    {
        private readonly Dictionary<string, string> dictionary = new ();

        protected List<After> Children { get; } = new ();

        public IEnumerable<DateTime> GetDates()
        {
            IEnumerable<DateTime> dates = new DateTime[]
            {
                new (2021, 01, 23),
                new (2021, 02, 24),
                new (2021, 03, 25),
                new (2021, 04, 26),
                new (2021, 05, 27)
            };

            SomeHelperLocalFunction(new (1999, 12, 13, 12, 0, 0));

            return dates;

            void SomeHelperLocalFunction(DateTime date)
            {
            }
        }
    }
}
