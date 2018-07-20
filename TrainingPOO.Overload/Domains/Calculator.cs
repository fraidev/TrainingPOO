namespace TrainingPOO.Overload.Domains
{
    public class Calculator
    {
        //Overload
        public int calculate( int a, int b){
            return a+b;
        }
        public double calculate( double a, double b){
            return a+b;
        }
        public string calculate( string a, string b){
            return a+b;
        }
        
        //Overload Method
        public string calculate( string a, string b, string c){
            return a+b+c;
        }
        public string calculate( string a, string b, string c, string d){
            return a+b+c+d;
        }
        public string calculate( string a, string b, string c, string d, string e){
            return a+b+c+d+e;
        }
        
    }
}