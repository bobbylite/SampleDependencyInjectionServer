using System;

namespace DependencyInjectionApp.Model
{
    public class SortableObject : IEquatable<SortableObject>, IComparable<SortableObject>
    {
        public int Value {get; set;}
        public string Name {get; set;}
        
        public int CompareTo(SortableObject other)
        {
            if (other == null)
                return 1;
            
            else
                return this.Value.CompareTo(other.Value);
        }

        public bool Equals(SortableObject other)
        {
            if (other == null) return false;
            return (this.Value.Equals(other.Value));
        }
    }
}