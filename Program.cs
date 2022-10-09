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

