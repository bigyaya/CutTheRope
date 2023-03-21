using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StarCounter : MonoBehaviour
{
    #region Exposed
    public static StarCounter instance;

    public TMP_Text starText;
    public int currentStar = 0;

    public Image starPrefab; // l'image d'étoile à afficher
    public Transform starContainer; // le conteneur pour les étoiles
 


#endregion



    #region Unity Lifecycle

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        starText.text = "Stars: " + currentStar.ToString();
        UpdateStarDisplay(); // met à jour l'affichage initial des étoiles

    }

 void Update()
    {

    }


    #endregion



    #region Methods

    public void IncreaseStars(int v)
    {
        currentStar += v;
        starText.text = "Stars: " + currentStar.ToString();

    }

    void UpdateStarDisplay()
    {
        // supprime toutes les étoiles actuellement affichées
        foreach (Transform child in starContainer)
        {
            Destroy(child.gameObject);
        }

        // affiche le nombre d'étoiles actuel en créant des instances de l'image d'étoile
        for (int i = 0; i < currentStar; i++)
        {
            Image newStar = Instantiate(starPrefab, starContainer);
            newStar.rectTransform.anchoredPosition = new Vector2(i * newStar.rectTransform.sizeDelta.x, 0f);
        }
    }

    #endregion



    #region Private & Protected

    #endregion
}
