
using UnityEngine;

public class DestroyLevel : BallEvents
{
    private int currentFloorNumber = 0;
    private GameObject currentFloor;
    private Animator animator;

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Empty)
        {
            currentFloor = GameObject.Find("Floor" + currentFloorNumber.ToString());
            animator = currentFloor.GetComponent<Animator>();
            animator.enabled = true;
            Destroy(currentFloor,1);
            currentFloorNumber++;
        }
    }
}
