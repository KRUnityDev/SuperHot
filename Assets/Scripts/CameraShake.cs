using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
    // Transform of the camera to shake. Grabs the gameObject's transform
    // if null.
    public Transform camTransform;

    // How long the object should shake for.
    public float shakeDuration = 0f;

    // Amplitude of the shake. A larger value shakes the camera harder.
    public float shakeAmount = 0.7f;
    public float decreaseFactor = 1.0f;

    float df_shadeDuration = 0f, df_shakeAmount = 0.7f, df_decreaseFactor = 1.0f;

    Vector3 originalPos;

    public static CameraShake instance;


    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }

        if (camTransform == null)
        {
            camTransform = GetComponent(typeof(Transform)) as Transform;
        }
    }

    void OnEnable()
    {
        originalPos = camTransform.localPosition;
    }

    void Update()
    {
        if (shakeDuration > 0)
        {
            camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

            shakeDuration -= Time.deltaTime * decreaseFactor;
        }
        else
        {
            shakeDuration = 0f;
            camTransform.localPosition = originalPos;

            shakeDuration = df_shadeDuration;
            shakeAmount = df_shakeAmount;
            decreaseFactor = df_decreaseFactor;
        }
    }

    public void Shake(float duration)
    {
        Shake(duration, df_shakeAmount, df_decreaseFactor);
    }

    public void Shake(float duration, float shakeAmount)
    {
        Shake(duration, shakeAmount, df_decreaseFactor);
    }

    public void Shake(float duration, float shakeAmount, float decreaseFactor)
    {
        this.shakeDuration = duration;
        this.shakeAmount = shakeAmount;
        this.decreaseFactor = decreaseFactor;
    }

    
}