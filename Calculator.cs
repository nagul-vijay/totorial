using System;

namespace basiclearing{
    abstract class Program
    {
        public abstract int addNumber(int x,int y);
        public abstract int subNumber(int x , int y );
        public abstract int mulNumber(int x , int y );
        public abstract int divNumber(int x , int y );
         
    }
    class Calculator:Program
    {
        public override int addNumber(int x, int y)
        {
            return x + y;
        }
        public override int subNumber(int x, int y)
        {
           return x - y;
        }
        public override int mulNumber(int x, int y)
        {
            return x * y;
        }
        public override int divNumber(int x, int y)
        {
            if(y==0){
                return 0;
            }
            else{
            return x / y;
            }
        }
       
        
        
    }
    
}