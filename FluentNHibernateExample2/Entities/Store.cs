using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Store
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual IList<Product> Products { get; set; }
        public virtual IList<Employee> Employees { get; set; }

        public Store()
        {
            Products = new List<Product>();
            Employees = new List<Employee>();
        }

        public virtual void AddEmployee(Employee emp)
        {
            emp.Store = this;
            Employees.Add(emp);
        }























        //public virtual void AddProduct(Product product)
        //{
        //    product.StoresStockedIn.Add(this);
        //    Products.Add(product);                
        //}

        //public virtual void AddEmployee(Employee employee)
        //{
        //    employee.Store = this;
        //    Employees.Add(employee);
        //}

        //public virtual void RemoveEmployee(Employee employee)
        //{
        //    Employees.Remove(employee);
        //}

        //public virtual Employee FindEmployee(int Id)
        //{

        //    return Employees.ElementAt<Employee>(Id);
        //}

    }
}
