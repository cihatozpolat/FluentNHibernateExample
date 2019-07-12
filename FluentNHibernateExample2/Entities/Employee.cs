namespace Domain.Entities
{
    public class Employee
    {
        public virtual int Id { get; protected set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual int Salary { get; set; }
        public virtual Store Store { get; set; }
    }
}
// en az maasa sahıp magaza calısanının bulundugu magazadakı urunlerın lısteleyen query