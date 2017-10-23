using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Department
    {
        //Prop nhấn phím Tad
        public int Id { get; set; }
        public string Name { get; set; }

        public Department(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
