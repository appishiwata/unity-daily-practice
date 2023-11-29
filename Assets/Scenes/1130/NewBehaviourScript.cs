using UnityEngine;

namespace Scenes._1130
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            Employee employee = new Employee("Taro", "Yamada", "Sales");
            employee.PrintName();
            employee.PrintDepartment();
        }
    }
    
    public class Employee
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Department { get; set; }
    
        public Employee(string firstName, string lastName, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }
        
        public void PrintName()
        {
            Debug.Log($"Employee Name: {FirstName} {LastName}");
        }
    
        public void PrintDepartment()
        {
            Debug.Log($"Department: {Department}");
        }
    }
}
