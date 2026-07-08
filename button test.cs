using JetBrains.Annotations;
using UnityEngine;

public class buttontest : MonoBehaviour
{
    public int money;
    public GameObject coffe;
    public Transform Transform;
    public float fixed_time;
    public float time;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       time = fixed_time;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
         if(time <= 0)
         {
            money += 5;
            Debug.Log("1 caffè è stato comprato \n adesso hai " + money);
            time = fixed_time;
         }
        Time_Limit();
    }
    void Time_Limit()
    {
        if(fixed_time < 10)
        {
            fixed_time = 10;
            Debug.Log("upgrade maxed out");
        }
    }

    public void Random()
    {
        money++;
        Debug.Log("hai " + money);
    }

    public void buy()
    {
        if(money >= 10)
        {
            money = money - 10;
            fixed_time -= 5;
            Instantiate(coffe, Transform);
            Debug.Log("comprato");
            Debug.Log("adesso hai " + money);
              
        }
        else
        {
            Debug.Log("soldi insufficienti");
        }
    }
}
