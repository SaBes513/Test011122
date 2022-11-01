using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{
    float TimeNext = 0;
    public float TimeSp = 1, Speed = 10, Distance = 100;
    public GameObject PrefGO;
    GameObject TempGO;
    Test TempT;

    void Update()
    {
        if (TimeNext < Time.time)
        {
            TimeNext += TimeSp;
            TempGO = Instantiate(PrefGO);
            TempT = TempGO.GetComponent<Test>();
            TempT.Speed = Speed;
            TempT.Distance = Distance;
        }
    }
    public void SetTime(string Ts)
    {
        Ts = Ts.Replace('.', ',');
        float.TryParse(Ts, out TimeSp);
    }
    public void SetSpeed(string Ts)
    {
        Ts = Ts.Replace('.', ',');
        float.TryParse(Ts, out Speed);
    }
    public void SetDistance(string Ts)
    {
        Ts = Ts.Replace('.', ',');
        float.TryParse(Ts, out Distance);
    }
}
