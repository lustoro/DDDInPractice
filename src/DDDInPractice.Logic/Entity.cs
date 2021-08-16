namespace DDDInPractice.Logic
{
   public abstract class Entity
    {
        public long Id { get; private set; }

        public override bool Equals(object obj)
        {
            var other = obj as Entity;
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (GetType() != other.GetType())
                return false;
            if (Id == 0 || other.Id == 0)
                return false;
            return Id == other.Id;
        }

        public static bool operator ==(Entity entity1, Entity entity2)
        {
            if (ReferenceEquals(entity1, null) && ReferenceEquals(entity2, null))
                return true;
            if (ReferenceEquals(entity1, null) || ReferenceEquals(entity2, null))
                return false;

            return entity1.Equals(entity2);
        }

        public static bool operator !=(Entity entity1, Entity entity2)
        {
            return !(entity1 == entity2);
        }

        public override int GetHashCode()
        {
            return (GetType().ToString() + Id).GetHashCode();
        }

    }
}
