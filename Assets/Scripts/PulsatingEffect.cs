using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulsatingEffect : MonoBehaviour
{
    public float pulseSpeed = 1f;  // Velocidad del efecto de pulsación
    public float minScale = 0.9f;  // Escala mínima del pulso
    public float maxScale = 1.1f;  // Escala máxima del pulso

    private Vector3 originalScale; // Almacena la escala original del objeto

    void Start()
    {
        // Guarda la escala original del objeto al iniciar
        originalScale = transform.localScale;
    }

    void Update()
    {
        float scale = minScale + (Mathf.Sin(Time.time * pulseSpeed) + 1f) / 2f * (maxScale - minScale);
        transform.localScale = originalScale * scale;
    }
}
