using Moments;
using UnityEngine;

public class Gif : MonoBehaviour
{
    public Recorder recorder;

    private void Start()
    {
        // 撮影を開始します
        recorder.Record();

        recorder.OnPreProcessingDone = OnProcessingDone;
        recorder.OnFileSaveProgress = OnFileSaveProgress;
        recorder.OnFileSaved = OnFileSaved;

        Debug.Log("Gif録画スタート!");
    }

    // 保存する準備が完了した時に呼び出されます
    private void OnProcessingDone()
    {
    }

    // 保存中に呼び出されます
    private void OnFileSaveProgress( int id, float percent )
    {
    }

    // 保存完了時に呼び出されます
    private void OnFileSaved( int id, string filepath )
    {
        // 保存が完了したら撮影を再開します
        //recorder.Record();
        Debug.Log("保存完了！");
    }

    private void Update()
    {
        // スペースキーが押されたら保存します
        if ( Input.GetKeyDown( KeyCode.Space ) )
        {
            recorder.Save();
            Debug.Log("録画終了！ 保存を待ってね！");
        }
    }
}