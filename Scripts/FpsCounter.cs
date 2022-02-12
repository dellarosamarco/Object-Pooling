using UnityEngine;
using TMPro;

public class FpsCounter : MonoBehaviour
{
    public TextMeshProUGUI fpsText;
    private int frameCount = 0;
    private float dt = 0.0f;
    private float fps = 0.0f;
    private float updateRate = 2f;

    void Update()
    {
        frameCount++;
        dt += Time.deltaTime;

        if (dt > updateRate)
        {
            fps = frameCount / dt;
            fpsText.text = fps.ToString("FPS : 0");
            frameCount = 0;
            dt = 0;
        }
    }
}
