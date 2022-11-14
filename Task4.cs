using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class ApplicationLicense
    {
    public ApplicationLicense(int programkey)
    {
        this.programkey = programkey;
    }
    public int programkey;
    public static double AllowTrial(double a, double b, string choise)
    {
        if (choise == "1")
            return a + b;
        else if (choise == "2")
            return a * b;
        else return 0;

    }
    public static double AllowCommon(double a, double b)
    {
        return a + b;
    }
    public static double AllowPro(double a, double b, string choise)
    {
        if (choise == "1")
            return a + b;
        else if (choise == "2")
            return a * b;
        else if (choise == "3")
            return a / b;
        else return 0;
    }

}

