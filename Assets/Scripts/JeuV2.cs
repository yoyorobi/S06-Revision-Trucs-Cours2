using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JeuV2 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _etiquettePoints;

   //public int pointsJeu = 0;
    public float tempsJeu = 0f;
    public float compteur = 0f;

    void Start()
    {
        //pointsJeu = 0;
        tempsJeu = 0;
        //InvokeRepeating("AugmenterTemps", 1f, 0.01f);
    }

    /*public void AugmenterPoints()
    {
        // Augmenter les points du jeu
        pointsJeu++;
        // Actualiser l'UI
        _etiquettePoints.text = "$" + pointsJeu.ToString();
    }*/
    public void AugmenterTemps(){
        tempsJeu += 0.01f;
        _etiquettePoints.text = "$" + tempsJeu.ToString("00.00");
    }
  
}
