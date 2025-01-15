using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_OOP4.Part_1
{
     class Complex
    
    {
        #region Attributes
        public int Real { get; set; }
        public int Img { get; set; }
        #endregion


        //#region constructor
          
        //  public Complex(int num1 , int num2)
        //  {
             
        //    Real = num1;
        //    Img = num2;

              
        //  }

        //#endregion


        #region ToString

        public override string ToString()
        {
            return $"{Real} + {Img}i";
        }
        #endregion

        #region  overload operator + and - 

        public static Complex operator + (Complex lef , Complex right)
        {

            return new Complex()
            
            {
                Real = (lef?.Real ?? 0) + (right?.Real ?? 0),
                Img = (lef?.Img ?? 0) + (right?.Img ?? 0),

            
            
            };


        }




        public static Complex operator - (Complex lef, Complex right)
        {

            return new Complex()

            {
                Real = (lef?.Real ?? 0) -  (right?.Real ?? 0),
                Img = (lef?.Img ?? 0) - (right?.Img ?? 0),



            };


        }


        #endregion








    }
}
