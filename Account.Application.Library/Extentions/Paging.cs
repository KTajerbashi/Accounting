﻿namespace Account.Application.Library.Extentions
{
    public class Paging
    {
        public Paging()
        {
            Page = 0;
        }
        public int Page { get; set; } = 0;

        public void Prev()
        {
            Page--;
            if (Page == 0)
            {
                Page = 0;
            }
        }

        public void Next(int max, int count)
        {
            var res = count / max;
            if (res > Page)
            {
                Page++;
            }
        }
        public string Order(int skip, int take = 20)
        {
            if (Page < 1)
            {
                skip = 0;
                Page = 0;
            }
            return $@"OFFSET {skip * take} ROWS FETCH NEXT {take} ROWS ONLY";
        }
    }
}
