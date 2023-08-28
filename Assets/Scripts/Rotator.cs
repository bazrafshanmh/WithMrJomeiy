using UnityEngine;
using DG.Tweening;
public class Rotator : MonoBehaviour
{   

    public float degree = 1100;
    public float rotateTime= 4;
    
    void Start()
    {
        RotateContinuously();
    }

    private void RotateContinuously()
    {
        if (GameManager.GetState() == "Play")
        {
        Sequence rotationSequence = DOTween.Sequence();
        rotationSequence.Append(transform.DORotate(new Vector3(0f, 0f, degree), rotateTime).SetRelative(true).SetEase(Ease.InOutQuad));
        rotationSequence.Append(transform.DORotate(new Vector3(0f, 0f, -degree), rotateTime).SetRelative(true).SetEase(Ease.InOutQuad));
        rotationSequence.SetLoops(-1, LoopType.Restart);
        }
    }

}
