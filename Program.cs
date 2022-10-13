using System;

class Employee  
{
    public int baseSalary=0;
    public int fuelAllowance=0;
    public int medicalAllowance=0;
    public Employee(int baseSalary, int fuelAllowance, int medicalAllowance)
    {
        this.baseSalary = baseSalary;
        this.fuelAllowance = fuelAllowance;
        this.medicalAllowance = medicalAllowance;
    }
    public int grossSalary()

    {
        return (int)(baseSalary + fuelAllowance + medicalAllowance);
    }

}

class Engineer:Employee
{
    public int annualAllowance = 0;

    public Engineer(int baseSalary, int fuelAllowance, int medicalAllowance,int annualAllowance) : base(baseSalary, fuelAllowance, medicalAllowance)
    {
        
        this.annualAllowance = annualAllowance;
     
    }
    public int setannualAllowance(int annualAllowance)
    {
        this.annualAllowance = annualAllowance;
        return annualAllowance;
    }
    public int finalSalary()
    {
         return annualAllowance/12+this.grossSalary();
    }
}
class Manager : Employee
{
    public int tax = 0;

    public Manager(int baseSalary, int fuelAllowance, int medicalAllowance, int tax) : base(baseSalary, fuelAllowance, medicalAllowance)
    {

        this.tax = tax;

    }
    public int settax(int tax)
    {
        this.tax = tax;
        
        return tax;
    }
    public int finalSalary()
    {   int basicSalary = this.baseSalary;
        return  this.grossSalary()-(tax* basicSalary / 100);
    }
}
class HR: Employee
{
    public int telephoneAllowance = 0;

    public HR(int baseSalary, int fuelAllowance, int medicalAllowance, int telephoneAllowance) : base(baseSalary, fuelAllowance, medicalAllowance)
    {

        this.telephoneAllowance = telephoneAllowance;

    }
    public int settelephoneAllowance(int telephoneAllowance)
    {
        this.telephoneAllowance = telephoneAllowance;

        return telephoneAllowance;
    }
    public int finalSalary()
    {
        int increment = telephoneAllowance*(this.medicalAllowance+this.fuelAllowance)/100;
        return this.grossSalary() + increment;
    }
}





class SalarySlip
{
    public string designation ="";

    public SalarySlip(string designation)
    {
        if (designation =="Engineer")
        {
            Engineer sal = new Engineer(1500,0,0,7000);

            Console.WriteLine("Engineer Gross Salay is: "+sal.finalSalary());
        }
        else if (designation == "Manager")
        {
            Manager sal = new Manager(1500, 250, 1000, 17);

            Console.WriteLine("MAnager Gross Salay is: "+sal.finalSalary());
        }
        else if (designation == "HR")
        {
            HR sal = new HR(1500, 150, 800, 10);

            Console.WriteLine("HR Gross Salay is: "+sal.finalSalary());
        }

    }
        

    
    
}







class Program
{
    static void Main(string[] args)

    {   
        Console.WriteLine("Enter number for designation: ");
        Console.WriteLine("1: Engineer");
        Console.WriteLine("2: Manager");
        Console.WriteLine("3: HR");
        string check ="";
        int number = Convert.ToInt32(Console.ReadLine());
        if (number==1)
        {
            check = "Engineer";
        }
        else if (number==2)
        {
            check = "Manager";
        }
        
        else if (number == 3)
        {
            check = "HR";
        }
        else
        {
            Console.WriteLine("Enter correct value: 1,2,3");
        }


        SalarySlip sal = new SalarySlip(check);
        
        
        Console.Read();
    }
}
///////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{   class Candidate
    {
        public string name;
        public string cnic;
        public string city;
        public double gpa;

    }
    class Program
    {
        static void Main(string[] args)
        {
           Candidate Candidate1 = new Candidate();
           Candidate1.name="Ahmad Shaukat";
           Candidate1.cnic = "3520227628485";
           Candidate1.city = "Lahore";
           Candidate1.gpa = 3.315;

           Candidate Candidate2 = new Candidate();
           Candidate2.name = "Faraz Abbas";
           Candidate2.cnic = "3522937628485";
           Candidate2.city = "Lahore";
           Candidate2.gpa = 3.8;

           Candidate Candidate3 = new Candidate();
           Candidate3.name = "Jamshaid Akhtar";
           Candidate3.cnic = "3522937628485";
           Candidate3.city = "Lahore";
           Candidate3.gpa = 2.7;

           Candidate Candidate4 = new Candidate();
           Candidate4.name = "Noman Khan";
           Candidate4.cnic = "3522937628485";
           Candidate4.city = "Lahore";
           Candidate4.gpa = 2.9;

           Candidate Candidate5 = new Candidate();
           Candidate5.name = "Nawaz sharif";
           Candidate5.cnic = "3522937628485";
           Candidate5.city = "Lahore";
           Candidate5.gpa = 3.3;

           Candidate Candidate6 = new Candidate();
           Candidate6.name = "Asif zardari";
           Candidate6.cnic = "3522937628485";
           Candidate6.city = "Lahore";
           Candidate6.gpa = 3.5;

           Candidate Candidate7 = new Candidate();
           Candidate7.name = "Bilawal Bhuto";
           Candidate7.cnic = "3522937628485";
           Candidate7.city = "Lahore";
           Candidate7.gpa = 2.7;

           Candidate Candidate8 = new Candidate();
           Candidate8.name = "Atif Anjum";
           Candidate8.cnic = "3522937628485";
           Candidate8.city = "Lahore";
           Candidate8.gpa = 3.0;

           Candidate Candidate9 = new Candidate();
           Candidate9.name = "Faraz Abbas";
           Candidate9.cnic = "3522937628485";
           Candidate9.city = "Rawalpindi";
           Candidate9.gpa = 3.8;

           Candidate Candidate10 = new Candidate();
           Candidate10.name = "Faraz Abbas";
           Candidate10.cnic = "3522937628485";
           Candidate10.city = "Lahore";
           Candidate10.gpa = 2.4;

           Candidate Candidate11 = new Candidate();
           Candidate11.name = "Faraz Abbas";
           Candidate11.cnic = "3522937628485";
           Candidate11.city = "Rawalpindi";
           Candidate11.gpa = 3.8;

           Candidate Candidate12 = new Candidate();
           Candidate12.name = "Khalil Ijaz";
           Candidate12.cnic = "3522937628485";
           Candidate12.city = "Lahore";
           Candidate12.gpa = 3.8;

           Candidate Candidate13 = new Candidate();
           Candidate13.name = "Faraz Abbas";
           Candidate13.cnic = "3522937628485";
           Candidate13.city = "Rawalpindi";
           Candidate13.gpa = 3.8;

           Candidate Candidate14 = new Candidate();
           Candidate14.name = "Faraz Abbas";
           Candidate14.cnic = "3522937628485";
           Candidate14.city = "Lahore";
           Candidate14.gpa = 3.8;

           Candidate Candidate15 = new Candidate();
           Candidate15.name = "Faraz Abbas";
           Candidate15.cnic = "3522937628485";
           Candidate15.city = "Rawalpindi";
           Candidate15.gpa = 2.4;

           List<Candidate> Customers = new List<Candidate>();
           List<Candidate> filterList= new List<Candidate>();
            
           Customers.Add(Candidate1);
           Customers.Add(Candidate2);
           Customers.Add(Candidate3);
           Customers.Add(Candidate4);
           Customers.Add(Candidate5);
           Customers.Add(Candidate6);
           Customers.Add(Candidate7);
           Customers.Add(Candidate8);
           Customers.Add(Candidate9);
           Customers.Add(Candidate10);
           Customers.Add(Candidate11);
           Customers.Add(Candidate12);
           Customers.Add(Candidate13);
           Customers.Add(Candidate14);
           Customers.Add(Candidate15);


           for (int i = 0; i < 15;i++ )
           {
              if (Customers[i].gpa>=3)
              {
                  filterList.Add(Customers[i]);
              }  
               
           }
           
               
           
            
            Console.Read();
        }
    }
}
///////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Candidate
    {
        public string name;
        public string cnic;
        public string city;
        public double gpa;


    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Candidate Candidate1 = new Candidate();
            Candidate1.name = "Ahmad Shaukat";
            Candidate1.cnic = "3520227628485";
            Candidate1.city = "Lahore";
            Candidate1.gpa = 3.315;

            Candidate Candidate2 = new Candidate();
            Candidate2.name = "Faraz Abbas";
            Candidate2.cnic = "3522937628485";
            Candidate2.city = "Lahore";
            Candidate2.gpa = 3.8;

            Candidate Candidate3 = new Candidate();
            Candidate3.name = "Jamshaid Akhtar";
            Candidate3.cnic = "3522937628485";
            Candidate3.city = "Lahore";
            Candidate3.gpa = 2.7;

            Candidate Candidate4 = new Candidate();
            Candidate4.name = "Noman Khan";
            Candidate4.cnic = "3522937628485";
            Candidate4.city = "Lahore";
            Candidate4.gpa = 2.9;

            Candidate Candidate5 = new Candidate();
            Candidate5.name = "Nawaz sharif";
            Candidate5.cnic = "3522937628485";
            Candidate5.city = "Lahore";
            Candidate5.gpa = 3.3;

            Candidate Candidate6 = new Candidate();
            Candidate6.name = "Asif zardari";
            Candidate6.cnic = "3522937628485";
            Candidate6.city = "Lahore";
            Candidate6.gpa = 3.5;

            Candidate Candidate7 = new Candidate();
            Candidate7.name = "Bilawal Bhuto";
            Candidate7.cnic = "3522937628485";
            Candidate7.city = "Lahore";
            Candidate7.gpa = 2.7;

            Candidate Candidate8 = new Candidate();
            Candidate8.name = "Atif Anjum";
            Candidate8.cnic = "3522937628485";
            Candidate8.city = "Lahore";
            Candidate8.gpa = 3.0;

            Candidate Candidate9 = new Candidate();
            Candidate9.name = "kareem Khan";
            Candidate9.cnic = "3522937628485";
            Candidate9.city = "Rawalpindi";
            Candidate9.gpa = 3.8;

            Candidate Candidate10 = new Candidate();
            Candidate10.name = "osma fazal";
            Candidate10.cnic = "3522937628485";
            Candidate10.city = "Lahore";
            Candidate10.gpa = 2.4;

            Candidate Candidate11 = new Candidate();
            Candidate11.name = "usman Aslam";
            Candidate11.cnic = "3522937628485";
            Candidate11.city = "Rawalpindi";
            Candidate11.gpa = 3.8;

            Candidate Candidate12 = new Candidate();
            Candidate12.name = "Tahir";
            Candidate12.cnic = "3522937628485";
            Candidate12.city = "Lahore";
            Candidate12.gpa = 3.8;

            Candidate Candidate13 = new Candidate();
            Candidate13.name = "Abdullah";
            Candidate13.cnic = "3522937628485";
            Candidate13.city = "Rawalpindi";
            Candidate13.gpa = 3.8;

            Candidate Candidate14 = new Candidate();
            Candidate14.name = "Ijaz";
            Candidate14.cnic = "3522937628485";
            Candidate14.city = "Lahore";
            Candidate14.gpa = 3.8;

            Candidate Candidate15 = new Candidate();
            Candidate15.name = "rafique";
            Candidate15.cnic = "3522937628485";
            Candidate15.city = "Rawalpindi";
            Candidate15.gpa = 2.4;
            //Task1

            List<Candidate> Customers = new List<Candidate>();



            Customers.Add(Candidate1);
            Customers.Add(Candidate2);
            Customers.Add(Candidate3);
            Customers.Add(Candidate4);
            Customers.Add(Candidate5);
            Customers.Add(Candidate6);
            Customers.Add(Candidate7);
            Customers.Add(Candidate8);
            Customers.Add(Candidate9);
            Customers.Add(Candidate10);
            Customers.Add(Candidate11);
            Customers.Add(Candidate12);
            Customers.Add(Candidate13);
            Customers.Add(Candidate14);
            Customers.Add(Candidate15);


            //Task 2
            List<Candidate> filterList = new List<Candidate>();
            for (int i = 0; i < 15; i++)
            {
                if (Customers[i].gpa >= 3)
                    filterList.Add(Customers[i]);

            }

            Dictionary<string, List<string>> myDic = new Dictionary<string, List<string>>();
            for (int i = 0; i < 15;i++ )
            {   
                myDic.Add(Customers[i].city,new List<string>());
                //myDic[Customers[i].city].Add(Customers[i].name);
                
            }


            Console.Read();
        }

    }
}

//////////////////////////////////////////////////////////////////////////////////////////////////////
using System;

class Employee  
{
    
    public virtual int grossSalary()

    {
        return 0;
    }
}

class Engineer:Employee

{
    private int baseSalary = 0;
    private int annualAllowance = 0;

    public Engineer(int baseSalary,int annualAllowance) : base()
    {
        this.baseSalary = baseSalary;
        this.annualAllowance = annualAllowance;


    }

    public override int grossSalary()
    {
        int finalSalary = annualAllowance + baseSalary * 12;
         return finalSalary;
    }
}
class Manager : Employee
{
    private int baseSalary = 0;
    private int fuelAllowance = 0;
    private int medicalAllowance = 0;
    private int tax = 0;

    public Manager(int baseSalary, int fuelAllowance, int medicalAllowance, int tax) : base()
    {

        this.tax = tax;

        this.baseSalary = baseSalary;

        this.medicalAllowance = medicalAllowance;
        this.fuelAllowance = fuelAllowance;

    }

    public override int grossSalary()
    {
        int finalSalary = (baseSalary * 12 + fuelAllowance * 12 + medicalAllowance * 12) - (tax * (baseSalary * 12 + fuelAllowance * 12 + medicalAllowance * 12) / 100);
        return finalSalary;
    }
}

class HR: Employee
{
    public  int telephoneAllowance = 0;
    private int baseSalary = 0;
    private int fuelAllowance = 0;
    private int medicalAllowance = 0;
    public HR(int baseSalary, int fuelAllowance, int medicalAllowance, int telephoneAllowance) : base()
    {
        this.baseSalary = baseSalary;

        this.medicalAllowance = medicalAllowance;
        this.fuelAllowance = fuelAllowance;

        this.telephoneAllowance = telephoneAllowance;

    }

    public override int grossSalary()
    {
        int finalSalary = (baseSalary * 12 + fuelAllowance * 12 + medicalAllowance * 12);
        int increment = telephoneAllowance*(medicalAllowance+fuelAllowance)/100;
        return finalSalary + increment;
    }
}



class Program
{
    static void Main(string[] args)

    {   
        Console.WriteLine("Enter number for designation: ");
        Console.WriteLine("1: Engineer");
        Console.WriteLine("2: Manager");
        Console.WriteLine("3: HR");
       
        int number = Convert.ToInt32(Console.ReadLine());
        if (number==1)
        {
             Engineer salaryCount = new Engineer(1500,7000);
                
             Console.WriteLine("Engineer Gross Salay is: " + salaryCount.grossSalary());
        }
        if (number==2)
        {
            Manager salaryCount = new Manager(1500, 250, 1000, 17);

            Console.WriteLine("Engineer Gross Salay is: " + salaryCount.grossSalary());
        }
        
        else if (number == 3)
        {
            HR salaryCount = new HR(1500, 150, 800, 10);

            Console.WriteLine("HR Gross Salay is: " + salaryCount.grossSalary());
        }
        else
        {
            Console.WriteLine("Enter correct value: 1,2,3");
        }

       
        Console.Read();
    }
}

