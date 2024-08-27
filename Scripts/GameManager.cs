using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Bloque;
    public float maxX;
    public Transform spawnBloque;
    public float spawnRate;

    bool InicioJuego;

    public GameObject tapText;
    public TextMeshProUGUI ScoreText;

    int score = 0;

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !InicioJuego)
        {
            Spawner();
            InicioJuego = true;
            tapText.SetActive(false);
        }
    }

    private void Spawner()
    {
        InvokeRepeating("SpawnBloques", 0.5f, spawnRate);
    }

    private void SpawnBloques()
    {
        Vector3 spawnPos = spawnBloque.position;
        spawnPos.x = Random.Range(-maxX, maxX);
        Instantiate(Bloque, spawnPos, Quaternion.identity);
        score++;
        ScoreText.text = score.ToString();
    }
}
