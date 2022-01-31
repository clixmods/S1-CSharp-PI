namespace PersonNameSpace
{
    public class Person
    {
        // propriété membre
        private int _age;
        private string _name;
         // Accesseur de la propriété _age


        public Person()
        {
            Age = _age;
            Name= _name;
        }
        public int Age
        {
            get { return _age; }
            set { 
                    if(value < 0)
                        _age = 0;
                    else
                        _age = value; 
                }
        }

        // Accesseur de la propriété _age
        public string Name
        {
            get {
                 if(_name == "" || _name == null)
                        _name = "NoNameDefined"; 

                return _name; }
            set { 
                    if(value == "" || value == null)
                        _name = "NoNameDefined";
                    else
                        _name = value; 
                }
        }

    }
}