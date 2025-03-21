using System.Collections;
using UnityEngine;

public class RatingBar : MonoBehaviour
{
    public Animator ratingStar1;
    public Animator ratingStar2;
    public Animator ratingStar3;

    private void Start()
    {
        ratingStar1.gameObject.SetActive(false);
        ratingStar2.gameObject.SetActive(false);
        ratingStar3.gameObject.SetActive(false);
    }

    public void Show(int rating)
    {
        StartCoroutine(ShowRatingCoroutine(rating));
    }

    private IEnumerator ShowRatingCoroutine(int rating)
    {
        yield return new WaitForSeconds(2f);
        ratingStar1.gameObject.SetActive(true);
        ratingStar1.SetBool("enabled", rating >= 1);

        yield return new WaitForSeconds(0.3f);
        ratingStar2.gameObject.SetActive(true);
        ratingStar2.SetBool("enabled", rating >= 2);

        yield return new WaitForSeconds(0.3f);
        ratingStar3.gameObject.SetActive(true);
        ratingStar3.SetBool("enabled", rating >= 3);
    }
}
