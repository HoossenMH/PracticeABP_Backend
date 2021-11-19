using Abp.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeABP.Players
{
    public class Player : Entity<int>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public decimal Height { get; set; }
    }
}
