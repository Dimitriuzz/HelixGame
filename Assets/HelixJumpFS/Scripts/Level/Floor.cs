using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    [SerializeField] private List<Segment> defaultSegment;

    public void AddEmptySegment(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            defaultSegment[i].SetEmpty();
            
        }
        for (int i = amount; i >= 0; i--)
        {

            defaultSegment.RemoveAt(i);
        }
    }

    public void AddRandomTrapSegment(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            int index = Random.Range(0, defaultSegment.Count);

            defaultSegment[index].SetTrap();
            defaultSegment.RemoveAt(index);
        }
    }

    public void SetRandomRotatation()
    {
        transform.eulerAngles = new Vector3(0, Random.Range(0, 360), 0);
    }

    public void SetFinishSegment()
    {
        for (int i = 0; i < defaultSegment.Count; i++)
        {
            defaultSegment[i].SetFinish();


        }
    }
}