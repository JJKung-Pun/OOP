using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bird
{
    int wings  = 2;
    int legs   = 2;

    public void fly()
    {
        Debug.Log("I am flying.");
    }

    public void sing()
    {
        Debug.Log("I am singing.");
    }
}
public class Monkey
{
    int arms   = 2;
    int tail   = 1;

    public void climb()
    {
        Debug.Log("I am climbing.");
    }
}

public class Crow : Bird
{
    Bomb bomb01 = new Bomb();

    public void attack()
    {
        bomb01.explod();
    }
}
public class Bomb
{
    public void explod()
    {
        Debug.Log("Booooommm!!!!");
    }
}

public class Dog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Bird sompong = new Bird();
        Bird somsri  = new Bird();
        Crow somjid  = new Crow();

        sompong.fly();
        somsri.sing();
        somjid.attack();

        Monkey tel = new Monkey();

        tel.climb();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
