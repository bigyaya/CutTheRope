using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    public GameObject starPrefab;
    public Transform starContainer;
    private int starCount;

    public void AddStar()
    {
        starCount++;
        GameObject newStar = Instantiate(starPrefab, starContainer);
        newStar.transform.localPosition = new Vector3(50 * starCount, 0, 0);
    }
}
