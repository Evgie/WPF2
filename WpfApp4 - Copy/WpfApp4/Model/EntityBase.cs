using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Model
{
    public class EntityBase
    {
        public int Id { get; set; }

        public bool IsNew { get; set; }

        private static int counter;

        public EntityBase()
        {
            this.IsNew = true;
            this.Id = EntityBase.counter++;
        }

        public void Save()
        {
            this.IsNew = false;
        }
    }
}
