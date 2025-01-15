using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_OOP4.Part_1
{
     class Rectangle
    {
        #region attribute
        public int width { get; set; }
        public int height { get; set; }

        #endregion


        #region constructor
        // A parameterless constructor  // and the complier genert it if i not write it
        public Rectangle()
        
        { 
        
        }
        // A constructor that accepts width and height as integers.
        public Rectangle( int num1 , int num2  )
        {
           
            width = num1;
            height = num2;


        }

        // ●	A constructor that accepts a single integer and sets both width and height to that value.

        public Rectangle (int num )
        {
            width =height = num;
        }
        #endregion


        #region  override
        public override string ToString()
        {
            return $"height {height} , width {width}";
        }

        #endregion

    }
}
