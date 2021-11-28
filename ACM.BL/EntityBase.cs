using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    public abstract class EntityBase//can only be used as a base class
    {
        public EntityStateOption EntityState { get; set; }
        public bool IsNew { get; private set; }//May need to access from repository classes so we leave it public
        public bool HasChanges { get; set; }
        public bool IsValid => Validate();

        public abstract bool Validate();//abstract so it can be overridden


    }
}
