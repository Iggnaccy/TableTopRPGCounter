using UnityEngine;
using System.Collections;

public class ListSlider : MonoBehaviour
{
    float transformY;

    void Start()
    {
        transformY = transform.localPosition.y;
    }

	public void ChangeTransform(float y)
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transformY + y, 0);
    }
}
