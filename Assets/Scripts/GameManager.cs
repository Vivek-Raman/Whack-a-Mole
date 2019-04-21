using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float TimeBetweenSpawns = 3f;

    [Header("Debug")]
    [SerializeField] private List<Image> MoleImageComponents = new List<Image>();
    [SerializeField] private Score ScoreReference;

    bool isMoleSmashed = false;
    int selectedIndex = 0;

    void Start()
    {
        // spawn moles
        StartCoroutine(MoleSpawner());

    }

    IEnumerator MoleSpawner()
    {
        while (true)
        {
            Spawn();
            yield return new WaitForSeconds(TimeBetweenSpawns);
        }
    }

    private void Spawn()
    {
        isMoleSmashed = false;
        selectedIndex = Random.Range(1, 9);
        MoleImageComponents[selectedIndex].enabled = true;
    }

    // DO NOT RENAME THIS, you'll have to re-map the buttons through inspector
    public void Hole(int holeIndex)
    {
        MoleImageComponents[selectedIndex].enabled = false;
        if (holeIndex == selectedIndex + 1)
        {
            if (!isMoleSmashed)
            {
                ScoreReference.AddScore(1f);
            }
            isMoleSmashed = true;
        }
        else
        {
            ScoreReference.AddScore(-1f);
        }
    }
}
