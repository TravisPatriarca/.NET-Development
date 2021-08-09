/*
*    allows you to type the method names of members of the 
*    System namespace without typing the word System every time.
*/
using System; 

namespace namespace1 {
    class namespace_cl {
        public void funct() {
            Console.WriteLine("Inside namespace1");
        }
    }
}

namespace namespace2 {
    class namespace_cl {
        public void funct()) {
            Console.WriteLine("Inside namespace2");
        }
    }
}

class TestClass {
    static void Main(string[] args) {
        namespace1.namespace_cl fc = new namespace1.namespace_cl();
        namespace2.namespace_cl fc = new namespace2.namespace_cl();

        fc.func();
        sc.func();

        Console.Read(); //pause before window closes
    }
}