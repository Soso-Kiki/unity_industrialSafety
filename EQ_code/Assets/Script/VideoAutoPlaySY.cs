using UnityEngine;
using UnityEngine.Video;

public class VideoAutoPlaySY : MonoBehaviour
{
 private VideoPlayer video;

void Start()
{
    video = GetComponent<VideoPlayer>();
    StartCoroutine(PlayAndStopVideo());
}

private System.Collections.IEnumerator PlayAndStopVideo() // �ڷ�ƾ(Coroutine)
    {
    yield return new WaitForSeconds(5f); // 5�� ��� �� ���
    video.Play();
    yield return new WaitForSeconds(13f); // ��� �� 13�� �� ����
    video.Stop(); // �Ǵ� video.Pause();


     GetComponent<Renderer>().material.color = Color.black;//ȭ�� �˰� ����� 







    }
}
