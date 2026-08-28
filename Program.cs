
/*
Q1

A
when we assign one object variable to another both variable refers to the same obj in the memory


B
No it doesn't  create a new object it copies the reference of the same obj



C
copying object : create a new object with it own data
coping reference : both variable point  to same object in memeory

*/


/*
Q2 

A
shallow copy :create new object but reference types inside it refer to the same object

B
Deep copy : create new object and create new seperate copies of the reference types indpendant 


C
what happens in shallow copy : reference type members   refer to the same object so any edit or modification 
will effect the original object

D
what happens in deep copy : reference type have their own seperate object  independant 
so it doest not affect the original object

E
deep copy is safer when we want to edit the copied object with change the orignal one

*/


/*
Q3 

A
static field belongs to class not the specific object
instance field belongs to each object  so every object has it own copy


B
static method is a method can be called without creating an object
,no it can not access the instance members because it belongs to specific object

C
static constructor is used to initalize statice members , it is executed auto before the class is  used for  the first time

D
static class : class that only contain static members , no we can't 
*/



/*
Q4 

A
extension method : method that allow u to add new method  to existing class or type without edit the original class

B
must use this keyword 

C
extension method must declared inside a static class

D
no becasue it can not directyle access private members because it is not a member of that class

*/


/*
Q5 

A

partial class : class that allows u to split one class into multiple files every part together represent the same class
B
to make code easier to read , organze maitainable


C
partial method : is a method the can be declared in one part of partaial class and implement in another part

D
compiler removers declaration and calls so it will not make a compile time error
*/










class Program
{



    static void Main(string[] args)
    {






    }


}