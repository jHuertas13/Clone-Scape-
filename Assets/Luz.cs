using System.Collections;
using UnityEngine;

public class Luz : MonoBehaviour
{
    public bool on = true;
    public bool blink = true;
    public float blinkInterval = 0.5f;

    private SpriteRenderer spriteRenderer;
    private Coroutine blinkCoroutine;

    private void Start()
    {
        // Cache the SpriteRenderer component
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Initialize light state
        UpdateLightState();

        // Start blinking if enabled
        if (blink)
        {
            blinkCoroutine = StartCoroutine(Blinking(blinkInterval));
        }
    }

    private void FixedUpdate()
    {
        // If blinking is toggled on or off, start/stop the coroutine accordingly
        if (blink && blinkCoroutine == null)
        {
            blinkCoroutine = StartCoroutine(Blinking(blinkInterval));
        }
        else if (!blink && blinkCoroutine != null)
        {
            StopCoroutine(blinkCoroutine);
            blinkCoroutine = null;
            UpdateLightState(); // Ensure the light is in the correct state when stopping blinking
        }
    }

    // Toggles the light's state and updates the SpriteRenderer
    private void SwitchLight()
    {
        on = !on;
        UpdateLightState();
    }

    // Updates the SpriteRenderer's enabled state based on the 'on' variable
    private void UpdateLightState()
    {
        spriteRenderer.enabled = on;
    }

    // Coroutine to handle blinking logic
    private IEnumerator Blinking(float interval)
    {
        while (blink)
        {
            yield return new WaitForSeconds(interval > 0 ? interval : Random.Range(0.1f, 1.0f));
            SwitchLight();
        }
    }
}
