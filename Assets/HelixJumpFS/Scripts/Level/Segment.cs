using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SegmentType
{
    Default,
    Trap,
    Empty,
    Finish
}

[RequireComponent(typeof(MeshRenderer))]
public class Segment : MonoBehaviour
{
    [SerializeField] private SegmentType type;

    [SerializeField] private Material traptMaterial;
    [SerializeField] private Material finishMaterial;

    private MeshRenderer meshRenderer;
    public SegmentType Type => type;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void SetTrap()
    {
        meshRenderer.enabled = true;
        meshRenderer.material = traptMaterial;
        type = SegmentType.Trap;
    }

    public void SetEmpty()
    {
        meshRenderer.enabled = false;
        
        type = SegmentType.Empty;
    }

    public void SetFinish()
    {
        meshRenderer.enabled = true;
        meshRenderer.material = finishMaterial;
        type = SegmentType.Finish;
    }
}
