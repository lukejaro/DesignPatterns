using System;

public class Dog
{
    private  SpeakBehavior speakBehavior;
    public void speak()
    {
        this.speakBehavior.speak();
    }
    public void setSpeakBehavior(SpeakBehavior sb )
    {
        this.speakBehavior = sb; 
    }
}

public interface SpeakBehavior
{
    public void speak();
}

public class SpeakLikeDog : SpeakBehavior
{
    public void speak()
    {
        Console.WriteLine("Ruff");
    }
     
}
public class SpeakLikeCat : SpeakBehavior
{
    public void speak()
    {
        Console.WriteLine("Meow");
    }

}