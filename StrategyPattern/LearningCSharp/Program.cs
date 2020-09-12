using System; 

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args) 
        {
            Dog dog = new Dog(); 
            dog.setSpeakBehavior(new SpeakLikeDog());
            dog.speak();
        }
    }
}
