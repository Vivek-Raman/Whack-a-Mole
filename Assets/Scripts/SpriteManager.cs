using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class SpriteManager : MonoBehaviour
{
    public Sprite HoleWithoutMole;
    public Sprite HoleWithMole;

    [Header("Debug")]
    [SerializeField] private GameManager gameManager = null;
    private void OnValidate()
    {
        foreach (Image image in gameManager.Cells)
        {
            image.sprite = HoleWithoutMole;
        }
    }
}
