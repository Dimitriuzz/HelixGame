using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class LevelPalete
{
    public Color AxisColor;
    public Color BallColor;
    public Color DefaultColor;
    public Color TrapColor;
    public Color FinishColor;
    public Color BackgroundColor;
    public Color CameraColor;
}

public class ColorPalette : MonoBehaviour
{
    [SerializeField] private LevelPalete[] palete;

    [SerializeField] private Material axisMaterial;
    [SerializeField] private Material ballMaterial;
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private Material trapMaterial;
    [SerializeField] private Material finishMaterial;
    [SerializeField] private Image backgroundMaterial;
    [SerializeField] private Camera cameraMaterial;

    public void Start()
    {
        int i = Random.Range(0, palete.Length);

        axisMaterial.color=palete[i].AxisColor;
        ballMaterial.color=palete[i].BallColor;
        defaultMaterial.color=palete[i].DefaultColor;
        trapMaterial.color=palete[i].TrapColor;
        finishMaterial.color=palete[i].FinishColor;
        backgroundMaterial.color=palete[i].BackgroundColor;
        cameraMaterial.backgroundColor=palete[i].BackgroundColor;
       

    }

}
