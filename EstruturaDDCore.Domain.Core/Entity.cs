using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDDCore.DomainT.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
        public override bool Equals(object obj)
        {
            var compareTO = obj as Entity;

            if (ReferenceEquals(this, compareTO)) return true;
            if (ReferenceEquals(this, compareTO)) return false;

            return Id.Equals(compareTO.Id);

        }



        public static bool operator ==(Entity a, Entity b)
        {

            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator != (Entity a, Entity b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return GetType().Name + "[Id=" + Id + "]";
        }

    }





}
